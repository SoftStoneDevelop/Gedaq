

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
    internal partial interface INpgsqlPolygonSingleTypepolygon
    {
    }
    
    internal partial class NpgsqlPolygonSingleTypepolygon : INpgsqlPolygonSingleTypepolygon
    {


#region TestData

        private readonly NpgsqlPolygonpolygonE0M[] _testData = new NpgsqlPolygonpolygonE0M[]
        {
            new NpgsqlPolygonpolygonE0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25055675051493753d, y: 0.4840491350077868d), new NpgsqlTypes.NpgsqlPoint(x: 0.14107032786328777d, y: 0.06723309311994186d), new NpgsqlTypes.NpgsqlPoint(x: 0.3220543729404981d, y: 0.7721427505043631d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42047603068716477d, y: 0.843448344519524d), new NpgsqlTypes.NpgsqlPoint(x: 0.3984725713519348d, y: 0.5438412962793111d), new NpgsqlTypes.NpgsqlPoint(x: 0.12521023712855273d, y: 0.7319194737096407d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09556016672219303d, y: 0.3456319194679054d), new NpgsqlTypes.NpgsqlPoint(x: 0.4246402663806277d, y: 0.8398252940045188d), new NpgsqlTypes.NpgsqlPoint(x: 0.519090341953848d, y: 0.39821881817360805d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7923926608224747d, y: 0.46019064058354653d), new NpgsqlTypes.NpgsqlPoint(x: 0.4126880299034239d, y: 0.060114699483141854d), new NpgsqlTypes.NpgsqlPoint(x: 0.660903149764129d, y: 0.08966473425370092d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2971446364927257d, y: 0.3913889981750227d), new NpgsqlTypes.NpgsqlPoint(x: 0.29895770161089474d, y: 0.24982461765709274d), new NpgsqlTypes.NpgsqlPoint(x: 0.5841624462417333d, y: 0.397309738385768d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9651660890489454d, y: 0.8532156859392418d), new NpgsqlTypes.NpgsqlPoint(x: 0.2606172623656149d, y: 0.7440676625622062d), new NpgsqlTypes.NpgsqlPoint(x: 0.5534220264157026d, y: 0.7679271306382609d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7254550508450999d, y: 0.9983158015332682d), new NpgsqlTypes.NpgsqlPoint(x: 0.984570666406613d, y: 0.5715381194131781d), new NpgsqlTypes.NpgsqlPoint(x: 0.9967796299471275d, y: 0.8750050549426098d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.662135488262761d, y: 0.4705876845299999d), new NpgsqlTypes.NpgsqlPoint(x: 0.0036125910816949824d, y: 0.6798217421768656d), new NpgsqlTypes.NpgsqlPoint(x: 0.5539283606549458d, y: 0.8485013708541663d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06677888717005964d, y: 0.6659524382977374d), new NpgsqlTypes.NpgsqlPoint(x: 0.49044597290398906d, y: 0.7554308020961149d), new NpgsqlTypes.NpgsqlPoint(x: 0.12391893042721847d, y: 0.8331698237603153d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9517421092448718d, y: 0.11752321692798928d), new NpgsqlTypes.NpgsqlPoint(x: 0.9988924880169923d, y: 0.8925441553328864d), new NpgsqlTypes.NpgsqlPoint(x: 0.8118017542601994d, y: 0.2949261186369181d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6567105574200679d, y: 0.9339239154300146d), new NpgsqlTypes.NpgsqlPoint(x: 0.20549802562464037d, y: 0.09342573490292017d), new NpgsqlTypes.NpgsqlPoint(x: 0.036860781939254794d, y: 0.8101970139054735d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5241336576692532d, y: 0.018531453193142422d), new NpgsqlTypes.NpgsqlPoint(x: 0.6503009366245396d, y: 0.4662114709623546d), new NpgsqlTypes.NpgsqlPoint(x: 0.9793636234259315d, y: 0.6327441513049357d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0779456907817686d, y: 0.250123705795522d), new NpgsqlTypes.NpgsqlPoint(x: 0.22944652961465373d, y: 0.3216966083658481d), new NpgsqlTypes.NpgsqlPoint(x: 0.8077929750932772d, y: 0.8667522623231071d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2756005401775058d, y: 0.16719339775017816d), new NpgsqlTypes.NpgsqlPoint(x: 0.8609353462389122d, y: 0.2666783134704943d), new NpgsqlTypes.NpgsqlPoint(x: 0.31992513455998295d, y: 0.11362810003552337d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6171598461382948d, y: 0.8787334484316965d), new NpgsqlTypes.NpgsqlPoint(x: 0.5485885089465097d, y: 0.8521040265427529d), new NpgsqlTypes.NpgsqlPoint(x: 0.7820324722368738d, y: 0.10491763746134097d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14157492516747783d, y: 0.9512876693842792d), new NpgsqlTypes.NpgsqlPoint(x: 0.9758111464422072d, y: 0.24823865899902098d), new NpgsqlTypes.NpgsqlPoint(x: 0.2940614457719969d, y: 0.33456893953471256d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9993177248640394d, y: 0.5208537199725677d), new NpgsqlTypes.NpgsqlPoint(x: 0.6703926174648457d, y: 0.8999540376872422d), new NpgsqlTypes.NpgsqlPoint(x: 0.9997269680962725d, y: 0.41630072916715377d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.153261458684955d, y: 0.0034707873152232116d), new NpgsqlTypes.NpgsqlPoint(x: 0.652627127692234d, y: 0.9963850957972605d), new NpgsqlTypes.NpgsqlPoint(x: 0.18855614821050437d, y: 0.37850575086949434d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3303655018559314d, y: 0.7099146272092957d), new NpgsqlTypes.NpgsqlPoint(x: 0.4679785256787742d, y: 0.14622386718448288d), new NpgsqlTypes.NpgsqlPoint(x: 0.8729767332131234d, y: 0.2688875706829782d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6718167739897247d, y: 0.052419067691535814d), new NpgsqlTypes.NpgsqlPoint(x: 0.4061473440893879d, y: 0.7785147507007425d), new NpgsqlTypes.NpgsqlPoint(x: 0.7749672783826311d, y: 0.2976949835524634d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35251993502643086d, y: 0.3507690105194432d), new NpgsqlTypes.NpgsqlPoint(x: 0.9855682989311777d, y: 0.693628893909045d), new NpgsqlTypes.NpgsqlPoint(x: 0.890571024557305d, y: 0.06209754359931252d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7016031540457857d, y: 0.6208875210615452d), new NpgsqlTypes.NpgsqlPoint(x: 0.18751391270702034d, y: 0.2566111138680185d), new NpgsqlTypes.NpgsqlPoint(x: 0.08313316647496571d, y: 0.1522907019905848d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15947405120001656d, y: 0.5510760183745581d), new NpgsqlTypes.NpgsqlPoint(x: 0.7312346506984531d, y: 0.9124337045307178d), new NpgsqlTypes.NpgsqlPoint(x: 0.9771965108916203d, y: 0.018197303672677245d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5486687864674132d, y: 0.19254765730593482d), new NpgsqlTypes.NpgsqlPoint(x: 0.06865158241482916d, y: 0.9200177264094339d), new NpgsqlTypes.NpgsqlPoint(x: 0.6691642990084868d, y: 0.49279337338132134d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3645666358902969d, y: 0.35743380657607704d), new NpgsqlTypes.NpgsqlPoint(x: 0.29833954034350063d, y: 0.5811466782270457d), new NpgsqlTypes.NpgsqlPoint(x: 0.101246976928974d, y: 0.5747368545868222d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19633848943783072d, y: 0.0002480340811629178d), new NpgsqlTypes.NpgsqlPoint(x: 0.34713109999743086d, y: 0.8894096784550815d), new NpgsqlTypes.NpgsqlPoint(x: 0.2634087879650997d, y: 0.724704005324586d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46870900303456275d, y: 0.9640150563508577d), new NpgsqlTypes.NpgsqlPoint(x: 0.5522824517593318d, y: 0.4984463061604577d), new NpgsqlTypes.NpgsqlPoint(x: 0.9731734208003093d, y: 0.0939078750757465d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.93396488884039d, y: 0.4757879376778965d), new NpgsqlTypes.NpgsqlPoint(x: 0.19622935049249612d, y: 0.04902653000348711d), new NpgsqlTypes.NpgsqlPoint(x: 0.6915053656206182d, y: 0.3125389561129792d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14859530262835097d, y: 0.9892943805716105d), new NpgsqlTypes.NpgsqlPoint(x: 0.07297674197066562d, y: 0.6190387647178843d), new NpgsqlTypes.NpgsqlPoint(x: 0.6869085532118293d, y: 0.685207556542054d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6743665807142268d, y: 0.952601549613235d), new NpgsqlTypes.NpgsqlPoint(x: 0.4873936617778254d, y: 0.3975860415077491d), new NpgsqlTypes.NpgsqlPoint(x: 0.18880797982456443d, y: 0.9357244752015446d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7598047771181659d, y: 0.6156618004947694d), new NpgsqlTypes.NpgsqlPoint(x: 0.22132787374785468d, y: 0.09443409434901939d), new NpgsqlTypes.NpgsqlPoint(x: 0.3390084666263785d, y: 0.35385614386270325d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12480770561937438d, y: 0.4758601447066937d), new NpgsqlTypes.NpgsqlPoint(x: 0.919892611097335d, y: 0.9065106873194212d), new NpgsqlTypes.NpgsqlPoint(x: 0.6049719018175264d, y: 0.6295492565022421d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7175358439593534d, y: 0.43171683759575274d), new NpgsqlTypes.NpgsqlPoint(x: 0.2464736390529374d, y: 0.9408533591033301d), new NpgsqlTypes.NpgsqlPoint(x: 0.9138489087432752d, y: 0.2325665281842395d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8672751490526066d, y: 0.7308997783032967d), new NpgsqlTypes.NpgsqlPoint(x: 8.930213709690271E-05d, y: 0.10111767017495266d), new NpgsqlTypes.NpgsqlPoint(x: 0.04966121319926997d, y: 0.4082652553178232d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8627139907467335d, y: 0.17741642501680466d), new NpgsqlTypes.NpgsqlPoint(x: 0.39595213374102844d, y: 0.06061476319342274d), new NpgsqlTypes.NpgsqlPoint(x: 0.3716746255715011d, y: 0.20505001693124592d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5598195438967923d, y: 0.07711486764511599d), new NpgsqlTypes.NpgsqlPoint(x: 0.1460474167735486d, y: 0.20251020860680424d), new NpgsqlTypes.NpgsqlPoint(x: 0.37843011591898035d, y: 0.7148529609907113d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7403239009973908d, y: 0.17998689549258395d), new NpgsqlTypes.NpgsqlPoint(x: 0.9387504336351332d, y: 0.15319712718262202d), new NpgsqlTypes.NpgsqlPoint(x: 0.7015930207598216d, y: 0.28616079951409834d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20945568400123493d, y: 0.5375058777902919d), new NpgsqlTypes.NpgsqlPoint(x: 0.9493238386941556d, y: 0.10793346056660369d), new NpgsqlTypes.NpgsqlPoint(x: 0.25104526857970344d, y: 0.8598307312557962d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7712393062963532d, y: 0.6205788538606543d), new NpgsqlTypes.NpgsqlPoint(x: 0.28907333432108573d, y: 0.4511900693634765d), new NpgsqlTypes.NpgsqlPoint(x: 0.5428291020342292d, y: 0.5852164785466961d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3697346311106634d, y: 0.6185347104160678d), new NpgsqlTypes.NpgsqlPoint(x: 0.7581250973338874d, y: 0.1832131986143597d), new NpgsqlTypes.NpgsqlPoint(x: 0.8552316725636139d, y: 0.28331093923513484d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2744680016946237d, y: 0.2592831534757819d), new NpgsqlTypes.NpgsqlPoint(x: 0.0851153358173764d, y: 0.6040379808995654d), new NpgsqlTypes.NpgsqlPoint(x: 0.8892867322235742d, y: 0.6385462391100712d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 109,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4192930445425185d, y: 0.6316797500360357d), new NpgsqlTypes.NpgsqlPoint(x: 0.5466702519985771d, y: 0.40558657678733645d), new NpgsqlTypes.NpgsqlPoint(x: 0.8451691970584666d, y: 0.8046789958648171d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19561497067996692d, y: 0.3328348543401267d), new NpgsqlTypes.NpgsqlPoint(x: 0.6397722101852056d, y: 0.09345424893065402d), new NpgsqlTypes.NpgsqlPoint(x: 0.9867798257951479d, y: 0.6146320848875214d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33163667339033276d, y: 0.7288266846218947d), new NpgsqlTypes.NpgsqlPoint(x: 0.8226227759726273d, y: 0.5973287881535899d), new NpgsqlTypes.NpgsqlPoint(x: 0.05243848143506957d, y: 0.8175084380217982d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7721536935014147d, y: 0.8599264692309744d), new NpgsqlTypes.NpgsqlPoint(x: 0.5415714067941542d, y: 0.21316498427352204d), new NpgsqlTypes.NpgsqlPoint(x: 0.7863027393910419d, y: 0.981949765174014d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7981217936813106d, y: 0.6024618150254948d), new NpgsqlTypes.NpgsqlPoint(x: 0.5296555100167881d, y: 0.25943921080047794d), new NpgsqlTypes.NpgsqlPoint(x: 0.947955127276344d, y: 0.5532210526386034d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9124071978010846d, y: 0.27049034311515596d), new NpgsqlTypes.NpgsqlPoint(x: 0.9035743919276252d, y: 0.40173892403690803d), new NpgsqlTypes.NpgsqlPoint(x: 0.7918136772619951d, y: 0.4025612982345994d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 116,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9313690588596788d, y: 0.4947071648420418d), new NpgsqlTypes.NpgsqlPoint(x: 0.7627021651485842d, y: 0.9101694735576625d), new NpgsqlTypes.NpgsqlPoint(x: 0.24322074165740515d, y: 0.8214078320039101d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1152480147884416d, y: 0.5840268985538892d), new NpgsqlTypes.NpgsqlPoint(x: 0.5988386302079642d, y: 0.006839505654353872d), new NpgsqlTypes.NpgsqlPoint(x: 0.2636706015093544d, y: 0.6385672755371775d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6510487851831203d, y: 0.6499026229336907d), new NpgsqlTypes.NpgsqlPoint(x: 0.4502859985154555d, y: 0.6626466927849051d), new NpgsqlTypes.NpgsqlPoint(x: 0.5215094749825895d, y: 0.6742246232535564d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6563573085194806d, y: 0.7768842005902414d), new NpgsqlTypes.NpgsqlPoint(x: 0.9313016716463541d, y: 0.8429611892471125d), new NpgsqlTypes.NpgsqlPoint(x: 0.573388798658123d, y: 0.996934953444609d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6074051121523572d, y: 0.12108825798376566d), new NpgsqlTypes.NpgsqlPoint(x: 0.5669387384524016d, y: 0.9793658147231562d), new NpgsqlTypes.NpgsqlPoint(x: 0.4390854234179711d, y: 0.032286862301609265d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9232518509925747d, y: 0.4382971605771734d), new NpgsqlTypes.NpgsqlPoint(x: 0.3209911290011773d, y: 0.6999117564519574d), new NpgsqlTypes.NpgsqlPoint(x: 0.5431301145941637d, y: 0.8087954742241702d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3394217819671159d, y: 0.928374712754934d), new NpgsqlTypes.NpgsqlPoint(x: 0.2864170303303699d, y: 0.29101144516192934d), new NpgsqlTypes.NpgsqlPoint(x: 0.06147910466020157d, y: 0.04894324123190741d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7948741742390811d, y: 0.882510430343346d), new NpgsqlTypes.NpgsqlPoint(x: 0.2188286645477091d, y: 0.7582119136950278d), new NpgsqlTypes.NpgsqlPoint(x: 0.7900086788550652d, y: 0.8566590814566822d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.769266564589876d, y: 0.09342614819800099d), new NpgsqlTypes.NpgsqlPoint(x: 0.5471964095822681d, y: 0.045704156503978854d), new NpgsqlTypes.NpgsqlPoint(x: 0.7411291057976008d, y: 0.9309526660059531d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01781338954038325d, y: 0.9674523845880764d), new NpgsqlTypes.NpgsqlPoint(x: 0.8592742901788568d, y: 0.3424373219330884d), new NpgsqlTypes.NpgsqlPoint(x: 0.7035510374164262d, y: 0.375925703870547d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.938582251559922d, y: 0.21917434915906042d), new NpgsqlTypes.NpgsqlPoint(x: 0.6139180990576133d, y: 0.6499123093333469d), new NpgsqlTypes.NpgsqlPoint(x: 0.97321151000714d, y: 0.5172805802459169d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43751266733003047d, y: 0.9766577604583608d), new NpgsqlTypes.NpgsqlPoint(x: 0.6115979309126505d, y: 0.8850522302348096d), new NpgsqlTypes.NpgsqlPoint(x: 0.3133271295084681d, y: 0.2416137355261817d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.277927606760593d, y: 0.7263110062019804d), new NpgsqlTypes.NpgsqlPoint(x: 0.10850856963295619d, y: 0.591025475890584d), new NpgsqlTypes.NpgsqlPoint(x: 0.4643690383592469d, y: 0.5962408276763864d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6780090250995935d, y: 0.22081048909459455d), new NpgsqlTypes.NpgsqlPoint(x: 0.30882897171577683d, y: 0.7063538065921309d), new NpgsqlTypes.NpgsqlPoint(x: 0.9202898760368101d, y: 0.5470851387338068d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3333099809462414d, y: 0.5546545232696101d), new NpgsqlTypes.NpgsqlPoint(x: 0.5523784533327126d, y: 0.038705401829406405d), new NpgsqlTypes.NpgsqlPoint(x: 0.39499683861262014d, y: 0.10279147079197326d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 145,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5501476946687417d, y: 0.5196416665231969d), new NpgsqlTypes.NpgsqlPoint(x: 0.008342279951757625d, y: 0.27013228918514676d), new NpgsqlTypes.NpgsqlPoint(x: 0.15351067487847259d, y: 0.6595636131388628d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7161048874495394d, y: 0.9025736421267628d), new NpgsqlTypes.NpgsqlPoint(x: 0.03512280928275102d, y: 0.03100551446985289d), new NpgsqlTypes.NpgsqlPoint(x: 0.9474374430906476d, y: 0.9755491915994375d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2618796439638056d, y: 0.14708349177551616d), new NpgsqlTypes.NpgsqlPoint(x: 0.3781536519140666d, y: 0.2828222522960414d), new NpgsqlTypes.NpgsqlPoint(x: 0.4257735364302704d, y: 0.785779748722662d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.906625819938099d, y: 0.5606380816734661d), new NpgsqlTypes.NpgsqlPoint(x: 0.09082183392778709d, y: 0.7845520217014526d), new NpgsqlTypes.NpgsqlPoint(x: 0.7316468925558963d, y: 0.9789331206210999d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9975085524099413d, y: 0.03472962839184812d), new NpgsqlTypes.NpgsqlPoint(x: 0.5686972652456055d, y: 0.26024131645714366d), new NpgsqlTypes.NpgsqlPoint(x: 0.31427954970688343d, y: 0.383285435025709d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5174336019898199d, y: 0.6858656474380943d), new NpgsqlTypes.NpgsqlPoint(x: 0.46455134030227263d, y: 0.49733329431974027d), new NpgsqlTypes.NpgsqlPoint(x: 0.5668446756900508d, y: 0.7027762140571144d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16088357414857968d, y: 0.9459673965399557d), new NpgsqlTypes.NpgsqlPoint(x: 0.6489615615168406d, y: 0.7445193637391353d), new NpgsqlTypes.NpgsqlPoint(x: 0.9746493882447675d, y: 0.39964502990433615d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 158,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5940061975370369d, y: 0.39954929957808105d), new NpgsqlTypes.NpgsqlPoint(x: 0.037000873642683896d, y: 0.48399861937576816d), new NpgsqlTypes.NpgsqlPoint(x: 0.136705030293661d, y: 0.8981601293246569d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.015533980087660604d, y: 0.2622762441088494d), new NpgsqlTypes.NpgsqlPoint(x: 0.8864601412398644d, y: 0.9469826322340891d), new NpgsqlTypes.NpgsqlPoint(x: 0.29398271013757993d, y: 0.8486727731924301d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 162,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6210475820023197d, y: 0.780341781726529d), new NpgsqlTypes.NpgsqlPoint(x: 0.12723348310898652d, y: 0.31600791062057987d), new NpgsqlTypes.NpgsqlPoint(x: 0.5864375242367692d, y: 0.2903668706278504d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6191550448059663d, y: 0.044787982345447785d), new NpgsqlTypes.NpgsqlPoint(x: 0.33968784991160383d, y: 0.35623151070721715d), new NpgsqlTypes.NpgsqlPoint(x: 0.9812781180347038d, y: 0.6775146990432375d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7916647664785803d, y: 0.27066407007282134d), new NpgsqlTypes.NpgsqlPoint(x: 0.9754658040655886d, y: 0.05312810205883489d), new NpgsqlTypes.NpgsqlPoint(x: 0.3734887842952024d, y: 0.3491954627544853d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7557466857271669d, y: 0.46831365890734367d), new NpgsqlTypes.NpgsqlPoint(x: 0.5869156468020845d, y: 0.9518338728850962d), new NpgsqlTypes.NpgsqlPoint(x: 0.33953341053726194d, y: 0.5550679115184595d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 163,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31092460852417214d, y: 0.8269858009629382d), new NpgsqlTypes.NpgsqlPoint(x: 0.5126418109261699d, y: 0.1828438334208643d), new NpgsqlTypes.NpgsqlPoint(x: 0.399164822314508d, y: 0.10341098171029472d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3828460908859326d, y: 0.658221035324284d), new NpgsqlTypes.NpgsqlPoint(x: 0.8425560525456293d, y: 0.707252111763056d), new NpgsqlTypes.NpgsqlPoint(x: 0.7765908963165904d, y: 0.25058423002318164d)),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0mi(
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16))]
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

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0mi(
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
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

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygone0mi_id
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygone0mi_id", 
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
                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygone0mi_id
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
    npgsqlpolygonpolygone0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9517421092448718d, y: 0.11752321692798928d), new NpgsqlTypes.NpgsqlPoint(x: 0.9988924880169923d, y: 0.8925441553328864d), new NpgsqlTypes.NpgsqlPoint(x: 0.8118017542601994d, y: 0.2949261186369181d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygone0mi_id
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
    npgsqlpolygonpolygone0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygone0mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonE0M> models = null;

                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonE0M> models = null;

                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygone0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpolygonpolygone0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPolygon), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpolygonpolygone0mi_id", 
                methodParametrName: "npgsqlpolygonpolygone0mi_id", 
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

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M), typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M), typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M), typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 51;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[27],_testData[34], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M), typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 34, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 101, query1, 11, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[32],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 56, query1, 154, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatch(connection, 158, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 137, query1, 90, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 101, query1, 51, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatch(connection, 137, query1, 96, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 130, query1, 27, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatchAsync(connection, 110, 154))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[34], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatch(connection, 105, 18))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[31],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 56);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[11], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[12], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[13], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[14], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[15], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[16], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[17], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[18], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[19], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[20], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[21], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[22], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[23], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[24], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[25], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[26], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[27], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[28], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[29], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[30], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[31], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[32], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[33], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 56);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[11], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[12], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[13], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[14], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[15], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[16], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[17], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[18], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[19], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[20], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[21], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[22], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[23], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[24], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[25], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[26], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[27], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[28], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[29], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[30], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[31], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[32], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[33], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25055675051493753d, y: 0.4840491350077868d), new NpgsqlTypes.NpgsqlPoint(x: 0.14107032786328777d, y: 0.06723309311994186d), new NpgsqlTypes.NpgsqlPoint(x: 0.3220543729404981d, y: 0.7721427505043631d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42047603068716477d, y: 0.843448344519524d), new NpgsqlTypes.NpgsqlPoint(x: 0.3984725713519348d, y: 0.5438412962793111d), new NpgsqlTypes.NpgsqlPoint(x: 0.12521023712855273d, y: 0.7319194737096407d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09556016672219303d, y: 0.3456319194679054d), new NpgsqlTypes.NpgsqlPoint(x: 0.4246402663806277d, y: 0.8398252940045188d), new NpgsqlTypes.NpgsqlPoint(x: 0.519090341953848d, y: 0.39821881817360805d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7923926608224747d, y: 0.46019064058354653d), new NpgsqlTypes.NpgsqlPoint(x: 0.4126880299034239d, y: 0.060114699483141854d), new NpgsqlTypes.NpgsqlPoint(x: 0.660903149764129d, y: 0.08966473425370092d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2971446364927257d, y: 0.3913889981750227d), new NpgsqlTypes.NpgsqlPoint(x: 0.29895770161089474d, y: 0.24982461765709274d), new NpgsqlTypes.NpgsqlPoint(x: 0.5841624462417333d, y: 0.397309738385768d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9651660890489454d, y: 0.8532156859392418d), new NpgsqlTypes.NpgsqlPoint(x: 0.2606172623656149d, y: 0.7440676625622062d), new NpgsqlTypes.NpgsqlPoint(x: 0.5534220264157026d, y: 0.7679271306382609d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7254550508450999d, y: 0.9983158015332682d), new NpgsqlTypes.NpgsqlPoint(x: 0.984570666406613d, y: 0.5715381194131781d), new NpgsqlTypes.NpgsqlPoint(x: 0.9967796299471275d, y: 0.8750050549426098d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.662135488262761d, y: 0.4705876845299999d), new NpgsqlTypes.NpgsqlPoint(x: 0.0036125910816949824d, y: 0.6798217421768656d), new NpgsqlTypes.NpgsqlPoint(x: 0.5539283606549458d, y: 0.8485013708541663d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06677888717005964d, y: 0.6659524382977374d), new NpgsqlTypes.NpgsqlPoint(x: 0.49044597290398906d, y: 0.7554308020961149d), new NpgsqlTypes.NpgsqlPoint(x: 0.12391893042721847d, y: 0.8331698237603153d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9517421092448718d, y: 0.11752321692798928d), new NpgsqlTypes.NpgsqlPoint(x: 0.9988924880169923d, y: 0.8925441553328864d), new NpgsqlTypes.NpgsqlPoint(x: 0.8118017542601994d, y: 0.2949261186369181d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6567105574200679d, y: 0.9339239154300146d), new NpgsqlTypes.NpgsqlPoint(x: 0.20549802562464037d, y: 0.09342573490292017d), new NpgsqlTypes.NpgsqlPoint(x: 0.036860781939254794d, y: 0.8101970139054735d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5241336576692532d, y: 0.018531453193142422d), new NpgsqlTypes.NpgsqlPoint(x: 0.6503009366245396d, y: 0.4662114709623546d), new NpgsqlTypes.NpgsqlPoint(x: 0.9793636234259315d, y: 0.6327441513049357d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0779456907817686d, y: 0.250123705795522d), new NpgsqlTypes.NpgsqlPoint(x: 0.22944652961465373d, y: 0.3216966083658481d), new NpgsqlTypes.NpgsqlPoint(x: 0.8077929750932772d, y: 0.8667522623231071d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2756005401775058d, y: 0.16719339775017816d), new NpgsqlTypes.NpgsqlPoint(x: 0.8609353462389122d, y: 0.2666783134704943d), new NpgsqlTypes.NpgsqlPoint(x: 0.31992513455998295d, y: 0.11362810003552337d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6171598461382948d, y: 0.8787334484316965d), new NpgsqlTypes.NpgsqlPoint(x: 0.5485885089465097d, y: 0.8521040265427529d), new NpgsqlTypes.NpgsqlPoint(x: 0.7820324722368738d, y: 0.10491763746134097d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14157492516747783d, y: 0.9512876693842792d), new NpgsqlTypes.NpgsqlPoint(x: 0.9758111464422072d, y: 0.24823865899902098d), new NpgsqlTypes.NpgsqlPoint(x: 0.2940614457719969d, y: 0.33456893953471256d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9993177248640394d, y: 0.5208537199725677d), new NpgsqlTypes.NpgsqlPoint(x: 0.6703926174648457d, y: 0.8999540376872422d), new NpgsqlTypes.NpgsqlPoint(x: 0.9997269680962725d, y: 0.41630072916715377d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.153261458684955d, y: 0.0034707873152232116d), new NpgsqlTypes.NpgsqlPoint(x: 0.652627127692234d, y: 0.9963850957972605d), new NpgsqlTypes.NpgsqlPoint(x: 0.18855614821050437d, y: 0.37850575086949434d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3303655018559314d, y: 0.7099146272092957d), new NpgsqlTypes.NpgsqlPoint(x: 0.4679785256787742d, y: 0.14622386718448288d), new NpgsqlTypes.NpgsqlPoint(x: 0.8729767332131234d, y: 0.2688875706829782d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6718167739897247d, y: 0.052419067691535814d), new NpgsqlTypes.NpgsqlPoint(x: 0.4061473440893879d, y: 0.7785147507007425d), new NpgsqlTypes.NpgsqlPoint(x: 0.7749672783826311d, y: 0.2976949835524634d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35251993502643086d, y: 0.3507690105194432d), new NpgsqlTypes.NpgsqlPoint(x: 0.9855682989311777d, y: 0.693628893909045d), new NpgsqlTypes.NpgsqlPoint(x: 0.890571024557305d, y: 0.06209754359931252d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7016031540457857d, y: 0.6208875210615452d), new NpgsqlTypes.NpgsqlPoint(x: 0.18751391270702034d, y: 0.2566111138680185d), new NpgsqlTypes.NpgsqlPoint(x: 0.08313316647496571d, y: 0.1522907019905848d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15947405120001656d, y: 0.5510760183745581d), new NpgsqlTypes.NpgsqlPoint(x: 0.7312346506984531d, y: 0.9124337045307178d), new NpgsqlTypes.NpgsqlPoint(x: 0.9771965108916203d, y: 0.018197303672677245d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5486687864674132d, y: 0.19254765730593482d), new NpgsqlTypes.NpgsqlPoint(x: 0.06865158241482916d, y: 0.9200177264094339d), new NpgsqlTypes.NpgsqlPoint(x: 0.6691642990084868d, y: 0.49279337338132134d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3645666358902969d, y: 0.35743380657607704d), new NpgsqlTypes.NpgsqlPoint(x: 0.29833954034350063d, y: 0.5811466782270457d), new NpgsqlTypes.NpgsqlPoint(x: 0.101246976928974d, y: 0.5747368545868222d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19633848943783072d, y: 0.0002480340811629178d), new NpgsqlTypes.NpgsqlPoint(x: 0.34713109999743086d, y: 0.8894096784550815d), new NpgsqlTypes.NpgsqlPoint(x: 0.2634087879650997d, y: 0.724704005324586d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46870900303456275d, y: 0.9640150563508577d), new NpgsqlTypes.NpgsqlPoint(x: 0.5522824517593318d, y: 0.4984463061604577d), new NpgsqlTypes.NpgsqlPoint(x: 0.9731734208003093d, y: 0.0939078750757465d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.93396488884039d, y: 0.4757879376778965d), new NpgsqlTypes.NpgsqlPoint(x: 0.19622935049249612d, y: 0.04902653000348711d), new NpgsqlTypes.NpgsqlPoint(x: 0.6915053656206182d, y: 0.3125389561129792d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14859530262835097d, y: 0.9892943805716105d), new NpgsqlTypes.NpgsqlPoint(x: 0.07297674197066562d, y: 0.6190387647178843d), new NpgsqlTypes.NpgsqlPoint(x: 0.6869085532118293d, y: 0.685207556542054d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6743665807142268d, y: 0.952601549613235d), new NpgsqlTypes.NpgsqlPoint(x: 0.4873936617778254d, y: 0.3975860415077491d), new NpgsqlTypes.NpgsqlPoint(x: 0.18880797982456443d, y: 0.9357244752015446d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7598047771181659d, y: 0.6156618004947694d), new NpgsqlTypes.NpgsqlPoint(x: 0.22132787374785468d, y: 0.09443409434901939d), new NpgsqlTypes.NpgsqlPoint(x: 0.3390084666263785d, y: 0.35385614386270325d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12480770561937438d, y: 0.4758601447066937d), new NpgsqlTypes.NpgsqlPoint(x: 0.919892611097335d, y: 0.9065106873194212d), new NpgsqlTypes.NpgsqlPoint(x: 0.6049719018175264d, y: 0.6295492565022421d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7175358439593534d, y: 0.43171683759575274d), new NpgsqlTypes.NpgsqlPoint(x: 0.2464736390529374d, y: 0.9408533591033301d), new NpgsqlTypes.NpgsqlPoint(x: 0.9138489087432752d, y: 0.2325665281842395d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8672751490526066d, y: 0.7308997783032967d), new NpgsqlTypes.NpgsqlPoint(x: 8.930213709690271E-05d, y: 0.10111767017495266d), new NpgsqlTypes.NpgsqlPoint(x: 0.04966121319926997d, y: 0.4082652553178232d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8627139907467335d, y: 0.17741642501680466d), new NpgsqlTypes.NpgsqlPoint(x: 0.39595213374102844d, y: 0.06061476319342274d), new NpgsqlTypes.NpgsqlPoint(x: 0.3716746255715011d, y: 0.20505001693124592d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5598195438967923d, y: 0.07711486764511599d), new NpgsqlTypes.NpgsqlPoint(x: 0.1460474167735486d, y: 0.20251020860680424d), new NpgsqlTypes.NpgsqlPoint(x: 0.37843011591898035d, y: 0.7148529609907113d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7403239009973908d, y: 0.17998689549258395d), new NpgsqlTypes.NpgsqlPoint(x: 0.9387504336351332d, y: 0.15319712718262202d), new NpgsqlTypes.NpgsqlPoint(x: 0.7015930207598216d, y: 0.28616079951409834d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20945568400123493d, y: 0.5375058777902919d), new NpgsqlTypes.NpgsqlPoint(x: 0.9493238386941556d, y: 0.10793346056660369d), new NpgsqlTypes.NpgsqlPoint(x: 0.25104526857970344d, y: 0.8598307312557962d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7712393062963532d, y: 0.6205788538606543d), new NpgsqlTypes.NpgsqlPoint(x: 0.28907333432108573d, y: 0.4511900693634765d), new NpgsqlTypes.NpgsqlPoint(x: 0.5428291020342292d, y: 0.5852164785466961d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3697346311106634d, y: 0.6185347104160678d), new NpgsqlTypes.NpgsqlPoint(x: 0.7581250973338874d, y: 0.1832131986143597d), new NpgsqlTypes.NpgsqlPoint(x: 0.8552316725636139d, y: 0.28331093923513484d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2744680016946237d, y: 0.2592831534757819d), new NpgsqlTypes.NpgsqlPoint(x: 0.0851153358173764d, y: 0.6040379808995654d), new NpgsqlTypes.NpgsqlPoint(x: 0.8892867322235742d, y: 0.6385462391100712d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4192930445425185d, y: 0.6316797500360357d), new NpgsqlTypes.NpgsqlPoint(x: 0.5466702519985771d, y: 0.40558657678733645d), new NpgsqlTypes.NpgsqlPoint(x: 0.8451691970584666d, y: 0.8046789958648171d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19561497067996692d, y: 0.3328348543401267d), new NpgsqlTypes.NpgsqlPoint(x: 0.6397722101852056d, y: 0.09345424893065402d), new NpgsqlTypes.NpgsqlPoint(x: 0.9867798257951479d, y: 0.6146320848875214d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33163667339033276d, y: 0.7288266846218947d), new NpgsqlTypes.NpgsqlPoint(x: 0.8226227759726273d, y: 0.5973287881535899d), new NpgsqlTypes.NpgsqlPoint(x: 0.05243848143506957d, y: 0.8175084380217982d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7721536935014147d, y: 0.8599264692309744d), new NpgsqlTypes.NpgsqlPoint(x: 0.5415714067941542d, y: 0.21316498427352204d), new NpgsqlTypes.NpgsqlPoint(x: 0.7863027393910419d, y: 0.981949765174014d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7981217936813106d, y: 0.6024618150254948d), new NpgsqlTypes.NpgsqlPoint(x: 0.5296555100167881d, y: 0.25943921080047794d), new NpgsqlTypes.NpgsqlPoint(x: 0.947955127276344d, y: 0.5532210526386034d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9124071978010846d, y: 0.27049034311515596d), new NpgsqlTypes.NpgsqlPoint(x: 0.9035743919276252d, y: 0.40173892403690803d), new NpgsqlTypes.NpgsqlPoint(x: 0.7918136772619951d, y: 0.4025612982345994d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9313690588596788d, y: 0.4947071648420418d), new NpgsqlTypes.NpgsqlPoint(x: 0.7627021651485842d, y: 0.9101694735576625d), new NpgsqlTypes.NpgsqlPoint(x: 0.24322074165740515d, y: 0.8214078320039101d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1152480147884416d, y: 0.5840268985538892d), new NpgsqlTypes.NpgsqlPoint(x: 0.5988386302079642d, y: 0.006839505654353872d), new NpgsqlTypes.NpgsqlPoint(x: 0.2636706015093544d, y: 0.6385672755371775d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6510487851831203d, y: 0.6499026229336907d), new NpgsqlTypes.NpgsqlPoint(x: 0.4502859985154555d, y: 0.6626466927849051d), new NpgsqlTypes.NpgsqlPoint(x: 0.5215094749825895d, y: 0.6742246232535564d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6563573085194806d, y: 0.7768842005902414d), new NpgsqlTypes.NpgsqlPoint(x: 0.9313016716463541d, y: 0.8429611892471125d), new NpgsqlTypes.NpgsqlPoint(x: 0.573388798658123d, y: 0.996934953444609d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6074051121523572d, y: 0.12108825798376566d), new NpgsqlTypes.NpgsqlPoint(x: 0.5669387384524016d, y: 0.9793658147231562d), new NpgsqlTypes.NpgsqlPoint(x: 0.4390854234179711d, y: 0.032286862301609265d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9232518509925747d, y: 0.4382971605771734d), new NpgsqlTypes.NpgsqlPoint(x: 0.3209911290011773d, y: 0.6999117564519574d), new NpgsqlTypes.NpgsqlPoint(x: 0.5431301145941637d, y: 0.8087954742241702d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3394217819671159d, y: 0.928374712754934d), new NpgsqlTypes.NpgsqlPoint(x: 0.2864170303303699d, y: 0.29101144516192934d), new NpgsqlTypes.NpgsqlPoint(x: 0.06147910466020157d, y: 0.04894324123190741d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7948741742390811d, y: 0.882510430343346d), new NpgsqlTypes.NpgsqlPoint(x: 0.2188286645477091d, y: 0.7582119136950278d), new NpgsqlTypes.NpgsqlPoint(x: 0.7900086788550652d, y: 0.8566590814566822d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.769266564589876d, y: 0.09342614819800099d), new NpgsqlTypes.NpgsqlPoint(x: 0.5471964095822681d, y: 0.045704156503978854d), new NpgsqlTypes.NpgsqlPoint(x: 0.7411291057976008d, y: 0.9309526660059531d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01781338954038325d, y: 0.9674523845880764d), new NpgsqlTypes.NpgsqlPoint(x: 0.8592742901788568d, y: 0.3424373219330884d), new NpgsqlTypes.NpgsqlPoint(x: 0.7035510374164262d, y: 0.375925703870547d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.938582251559922d, y: 0.21917434915906042d), new NpgsqlTypes.NpgsqlPoint(x: 0.6139180990576133d, y: 0.6499123093333469d), new NpgsqlTypes.NpgsqlPoint(x: 0.97321151000714d, y: 0.5172805802459169d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43751266733003047d, y: 0.9766577604583608d), new NpgsqlTypes.NpgsqlPoint(x: 0.6115979309126505d, y: 0.8850522302348096d), new NpgsqlTypes.NpgsqlPoint(x: 0.3133271295084681d, y: 0.2416137355261817d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.277927606760593d, y: 0.7263110062019804d), new NpgsqlTypes.NpgsqlPoint(x: 0.10850856963295619d, y: 0.591025475890584d), new NpgsqlTypes.NpgsqlPoint(x: 0.4643690383592469d, y: 0.5962408276763864d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6780090250995935d, y: 0.22081048909459455d), new NpgsqlTypes.NpgsqlPoint(x: 0.30882897171577683d, y: 0.7063538065921309d), new NpgsqlTypes.NpgsqlPoint(x: 0.9202898760368101d, y: 0.5470851387338068d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3333099809462414d, y: 0.5546545232696101d), new NpgsqlTypes.NpgsqlPoint(x: 0.5523784533327126d, y: 0.038705401829406405d), new NpgsqlTypes.NpgsqlPoint(x: 0.39499683861262014d, y: 0.10279147079197326d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5501476946687417d, y: 0.5196416665231969d), new NpgsqlTypes.NpgsqlPoint(x: 0.008342279951757625d, y: 0.27013228918514676d), new NpgsqlTypes.NpgsqlPoint(x: 0.15351067487847259d, y: 0.6595636131388628d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7161048874495394d, y: 0.9025736421267628d), new NpgsqlTypes.NpgsqlPoint(x: 0.03512280928275102d, y: 0.03100551446985289d), new NpgsqlTypes.NpgsqlPoint(x: 0.9474374430906476d, y: 0.9755491915994375d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2618796439638056d, y: 0.14708349177551616d), new NpgsqlTypes.NpgsqlPoint(x: 0.3781536519140666d, y: 0.2828222522960414d), new NpgsqlTypes.NpgsqlPoint(x: 0.4257735364302704d, y: 0.785779748722662d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.906625819938099d, y: 0.5606380816734661d), new NpgsqlTypes.NpgsqlPoint(x: 0.09082183392778709d, y: 0.7845520217014526d), new NpgsqlTypes.NpgsqlPoint(x: 0.7316468925558963d, y: 0.9789331206210999d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9975085524099413d, y: 0.03472962839184812d), new NpgsqlTypes.NpgsqlPoint(x: 0.5686972652456055d, y: 0.26024131645714366d), new NpgsqlTypes.NpgsqlPoint(x: 0.31427954970688343d, y: 0.383285435025709d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5174336019898199d, y: 0.6858656474380943d), new NpgsqlTypes.NpgsqlPoint(x: 0.46455134030227263d, y: 0.49733329431974027d), new NpgsqlTypes.NpgsqlPoint(x: 0.5668446756900508d, y: 0.7027762140571144d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16088357414857968d, y: 0.9459673965399557d), new NpgsqlTypes.NpgsqlPoint(x: 0.6489615615168406d, y: 0.7445193637391353d), new NpgsqlTypes.NpgsqlPoint(x: 0.9746493882447675d, y: 0.39964502990433615d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5940061975370369d, y: 0.39954929957808105d), new NpgsqlTypes.NpgsqlPoint(x: 0.037000873642683896d, y: 0.48399861937576816d), new NpgsqlTypes.NpgsqlPoint(x: 0.136705030293661d, y: 0.8981601293246569d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.015533980087660604d, y: 0.2622762441088494d), new NpgsqlTypes.NpgsqlPoint(x: 0.8864601412398644d, y: 0.9469826322340891d), new NpgsqlTypes.NpgsqlPoint(x: 0.29398271013757993d, y: 0.8486727731924301d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6210475820023197d, y: 0.780341781726529d), new NpgsqlTypes.NpgsqlPoint(x: 0.12723348310898652d, y: 0.31600791062057987d), new NpgsqlTypes.NpgsqlPoint(x: 0.5864375242367692d, y: 0.2903668706278504d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6191550448059663d, y: 0.044787982345447785d), new NpgsqlTypes.NpgsqlPoint(x: 0.33968784991160383d, y: 0.35623151070721715d), new NpgsqlTypes.NpgsqlPoint(x: 0.9812781180347038d, y: 0.6775146990432375d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7916647664785803d, y: 0.27066407007282134d), new NpgsqlTypes.NpgsqlPoint(x: 0.9754658040655886d, y: 0.05312810205883489d), new NpgsqlTypes.NpgsqlPoint(x: 0.3734887842952024d, y: 0.3491954627544853d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7557466857271669d, y: 0.46831365890734367d), new NpgsqlTypes.NpgsqlPoint(x: 0.5869156468020845d, y: 0.9518338728850962d), new NpgsqlTypes.NpgsqlPoint(x: 0.33953341053726194d, y: 0.5550679115184595d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31092460852417214d, y: 0.8269858009629382d), new NpgsqlTypes.NpgsqlPoint(x: 0.5126418109261699d, y: 0.1828438334208643d), new NpgsqlTypes.NpgsqlPoint(x: 0.399164822314508d, y: 0.10341098171029472d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3828460908859326d, y: 0.658221035324284d), new NpgsqlTypes.NpgsqlPoint(x: 0.8425560525456293d, y: 0.707252111763056d), new NpgsqlTypes.NpgsqlPoint(x: 0.7765908963165904d, y: 0.25058423002318164d)))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25055675051493753d, y: 0.4840491350077868d), new NpgsqlTypes.NpgsqlPoint(x: 0.14107032786328777d, y: 0.06723309311994186d), new NpgsqlTypes.NpgsqlPoint(x: 0.3220543729404981d, y: 0.7721427505043631d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42047603068716477d, y: 0.843448344519524d), new NpgsqlTypes.NpgsqlPoint(x: 0.3984725713519348d, y: 0.5438412962793111d), new NpgsqlTypes.NpgsqlPoint(x: 0.12521023712855273d, y: 0.7319194737096407d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09556016672219303d, y: 0.3456319194679054d), new NpgsqlTypes.NpgsqlPoint(x: 0.4246402663806277d, y: 0.8398252940045188d), new NpgsqlTypes.NpgsqlPoint(x: 0.519090341953848d, y: 0.39821881817360805d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7923926608224747d, y: 0.46019064058354653d), new NpgsqlTypes.NpgsqlPoint(x: 0.4126880299034239d, y: 0.060114699483141854d), new NpgsqlTypes.NpgsqlPoint(x: 0.660903149764129d, y: 0.08966473425370092d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2971446364927257d, y: 0.3913889981750227d), new NpgsqlTypes.NpgsqlPoint(x: 0.29895770161089474d, y: 0.24982461765709274d), new NpgsqlTypes.NpgsqlPoint(x: 0.5841624462417333d, y: 0.397309738385768d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9651660890489454d, y: 0.8532156859392418d), new NpgsqlTypes.NpgsqlPoint(x: 0.2606172623656149d, y: 0.7440676625622062d), new NpgsqlTypes.NpgsqlPoint(x: 0.5534220264157026d, y: 0.7679271306382609d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7254550508450999d, y: 0.9983158015332682d), new NpgsqlTypes.NpgsqlPoint(x: 0.984570666406613d, y: 0.5715381194131781d), new NpgsqlTypes.NpgsqlPoint(x: 0.9967796299471275d, y: 0.8750050549426098d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.662135488262761d, y: 0.4705876845299999d), new NpgsqlTypes.NpgsqlPoint(x: 0.0036125910816949824d, y: 0.6798217421768656d), new NpgsqlTypes.NpgsqlPoint(x: 0.5539283606549458d, y: 0.8485013708541663d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06677888717005964d, y: 0.6659524382977374d), new NpgsqlTypes.NpgsqlPoint(x: 0.49044597290398906d, y: 0.7554308020961149d), new NpgsqlTypes.NpgsqlPoint(x: 0.12391893042721847d, y: 0.8331698237603153d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9517421092448718d, y: 0.11752321692798928d), new NpgsqlTypes.NpgsqlPoint(x: 0.9988924880169923d, y: 0.8925441553328864d), new NpgsqlTypes.NpgsqlPoint(x: 0.8118017542601994d, y: 0.2949261186369181d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6567105574200679d, y: 0.9339239154300146d), new NpgsqlTypes.NpgsqlPoint(x: 0.20549802562464037d, y: 0.09342573490292017d), new NpgsqlTypes.NpgsqlPoint(x: 0.036860781939254794d, y: 0.8101970139054735d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5241336576692532d, y: 0.018531453193142422d), new NpgsqlTypes.NpgsqlPoint(x: 0.6503009366245396d, y: 0.4662114709623546d), new NpgsqlTypes.NpgsqlPoint(x: 0.9793636234259315d, y: 0.6327441513049357d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0779456907817686d, y: 0.250123705795522d), new NpgsqlTypes.NpgsqlPoint(x: 0.22944652961465373d, y: 0.3216966083658481d), new NpgsqlTypes.NpgsqlPoint(x: 0.8077929750932772d, y: 0.8667522623231071d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2756005401775058d, y: 0.16719339775017816d), new NpgsqlTypes.NpgsqlPoint(x: 0.8609353462389122d, y: 0.2666783134704943d), new NpgsqlTypes.NpgsqlPoint(x: 0.31992513455998295d, y: 0.11362810003552337d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6171598461382948d, y: 0.8787334484316965d), new NpgsqlTypes.NpgsqlPoint(x: 0.5485885089465097d, y: 0.8521040265427529d), new NpgsqlTypes.NpgsqlPoint(x: 0.7820324722368738d, y: 0.10491763746134097d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14157492516747783d, y: 0.9512876693842792d), new NpgsqlTypes.NpgsqlPoint(x: 0.9758111464422072d, y: 0.24823865899902098d), new NpgsqlTypes.NpgsqlPoint(x: 0.2940614457719969d, y: 0.33456893953471256d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9993177248640394d, y: 0.5208537199725677d), new NpgsqlTypes.NpgsqlPoint(x: 0.6703926174648457d, y: 0.8999540376872422d), new NpgsqlTypes.NpgsqlPoint(x: 0.9997269680962725d, y: 0.41630072916715377d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.153261458684955d, y: 0.0034707873152232116d), new NpgsqlTypes.NpgsqlPoint(x: 0.652627127692234d, y: 0.9963850957972605d), new NpgsqlTypes.NpgsqlPoint(x: 0.18855614821050437d, y: 0.37850575086949434d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3303655018559314d, y: 0.7099146272092957d), new NpgsqlTypes.NpgsqlPoint(x: 0.4679785256787742d, y: 0.14622386718448288d), new NpgsqlTypes.NpgsqlPoint(x: 0.8729767332131234d, y: 0.2688875706829782d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6718167739897247d, y: 0.052419067691535814d), new NpgsqlTypes.NpgsqlPoint(x: 0.4061473440893879d, y: 0.7785147507007425d), new NpgsqlTypes.NpgsqlPoint(x: 0.7749672783826311d, y: 0.2976949835524634d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35251993502643086d, y: 0.3507690105194432d), new NpgsqlTypes.NpgsqlPoint(x: 0.9855682989311777d, y: 0.693628893909045d), new NpgsqlTypes.NpgsqlPoint(x: 0.890571024557305d, y: 0.06209754359931252d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7016031540457857d, y: 0.6208875210615452d), new NpgsqlTypes.NpgsqlPoint(x: 0.18751391270702034d, y: 0.2566111138680185d), new NpgsqlTypes.NpgsqlPoint(x: 0.08313316647496571d, y: 0.1522907019905848d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15947405120001656d, y: 0.5510760183745581d), new NpgsqlTypes.NpgsqlPoint(x: 0.7312346506984531d, y: 0.9124337045307178d), new NpgsqlTypes.NpgsqlPoint(x: 0.9771965108916203d, y: 0.018197303672677245d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5486687864674132d, y: 0.19254765730593482d), new NpgsqlTypes.NpgsqlPoint(x: 0.06865158241482916d, y: 0.9200177264094339d), new NpgsqlTypes.NpgsqlPoint(x: 0.6691642990084868d, y: 0.49279337338132134d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3645666358902969d, y: 0.35743380657607704d), new NpgsqlTypes.NpgsqlPoint(x: 0.29833954034350063d, y: 0.5811466782270457d), new NpgsqlTypes.NpgsqlPoint(x: 0.101246976928974d, y: 0.5747368545868222d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19633848943783072d, y: 0.0002480340811629178d), new NpgsqlTypes.NpgsqlPoint(x: 0.34713109999743086d, y: 0.8894096784550815d), new NpgsqlTypes.NpgsqlPoint(x: 0.2634087879650997d, y: 0.724704005324586d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46870900303456275d, y: 0.9640150563508577d), new NpgsqlTypes.NpgsqlPoint(x: 0.5522824517593318d, y: 0.4984463061604577d), new NpgsqlTypes.NpgsqlPoint(x: 0.9731734208003093d, y: 0.0939078750757465d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.93396488884039d, y: 0.4757879376778965d), new NpgsqlTypes.NpgsqlPoint(x: 0.19622935049249612d, y: 0.04902653000348711d), new NpgsqlTypes.NpgsqlPoint(x: 0.6915053656206182d, y: 0.3125389561129792d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14859530262835097d, y: 0.9892943805716105d), new NpgsqlTypes.NpgsqlPoint(x: 0.07297674197066562d, y: 0.6190387647178843d), new NpgsqlTypes.NpgsqlPoint(x: 0.6869085532118293d, y: 0.685207556542054d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6743665807142268d, y: 0.952601549613235d), new NpgsqlTypes.NpgsqlPoint(x: 0.4873936617778254d, y: 0.3975860415077491d), new NpgsqlTypes.NpgsqlPoint(x: 0.18880797982456443d, y: 0.9357244752015446d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7598047771181659d, y: 0.6156618004947694d), new NpgsqlTypes.NpgsqlPoint(x: 0.22132787374785468d, y: 0.09443409434901939d), new NpgsqlTypes.NpgsqlPoint(x: 0.3390084666263785d, y: 0.35385614386270325d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12480770561937438d, y: 0.4758601447066937d), new NpgsqlTypes.NpgsqlPoint(x: 0.919892611097335d, y: 0.9065106873194212d), new NpgsqlTypes.NpgsqlPoint(x: 0.6049719018175264d, y: 0.6295492565022421d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7175358439593534d, y: 0.43171683759575274d), new NpgsqlTypes.NpgsqlPoint(x: 0.2464736390529374d, y: 0.9408533591033301d), new NpgsqlTypes.NpgsqlPoint(x: 0.9138489087432752d, y: 0.2325665281842395d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8672751490526066d, y: 0.7308997783032967d), new NpgsqlTypes.NpgsqlPoint(x: 8.930213709690271E-05d, y: 0.10111767017495266d), new NpgsqlTypes.NpgsqlPoint(x: 0.04966121319926997d, y: 0.4082652553178232d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8627139907467335d, y: 0.17741642501680466d), new NpgsqlTypes.NpgsqlPoint(x: 0.39595213374102844d, y: 0.06061476319342274d), new NpgsqlTypes.NpgsqlPoint(x: 0.3716746255715011d, y: 0.20505001693124592d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5598195438967923d, y: 0.07711486764511599d), new NpgsqlTypes.NpgsqlPoint(x: 0.1460474167735486d, y: 0.20251020860680424d), new NpgsqlTypes.NpgsqlPoint(x: 0.37843011591898035d, y: 0.7148529609907113d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7403239009973908d, y: 0.17998689549258395d), new NpgsqlTypes.NpgsqlPoint(x: 0.9387504336351332d, y: 0.15319712718262202d), new NpgsqlTypes.NpgsqlPoint(x: 0.7015930207598216d, y: 0.28616079951409834d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20945568400123493d, y: 0.5375058777902919d), new NpgsqlTypes.NpgsqlPoint(x: 0.9493238386941556d, y: 0.10793346056660369d), new NpgsqlTypes.NpgsqlPoint(x: 0.25104526857970344d, y: 0.8598307312557962d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7712393062963532d, y: 0.6205788538606543d), new NpgsqlTypes.NpgsqlPoint(x: 0.28907333432108573d, y: 0.4511900693634765d), new NpgsqlTypes.NpgsqlPoint(x: 0.5428291020342292d, y: 0.5852164785466961d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3697346311106634d, y: 0.6185347104160678d), new NpgsqlTypes.NpgsqlPoint(x: 0.7581250973338874d, y: 0.1832131986143597d), new NpgsqlTypes.NpgsqlPoint(x: 0.8552316725636139d, y: 0.28331093923513484d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2744680016946237d, y: 0.2592831534757819d), new NpgsqlTypes.NpgsqlPoint(x: 0.0851153358173764d, y: 0.6040379808995654d), new NpgsqlTypes.NpgsqlPoint(x: 0.8892867322235742d, y: 0.6385462391100712d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4192930445425185d, y: 0.6316797500360357d), new NpgsqlTypes.NpgsqlPoint(x: 0.5466702519985771d, y: 0.40558657678733645d), new NpgsqlTypes.NpgsqlPoint(x: 0.8451691970584666d, y: 0.8046789958648171d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19561497067996692d, y: 0.3328348543401267d), new NpgsqlTypes.NpgsqlPoint(x: 0.6397722101852056d, y: 0.09345424893065402d), new NpgsqlTypes.NpgsqlPoint(x: 0.9867798257951479d, y: 0.6146320848875214d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33163667339033276d, y: 0.7288266846218947d), new NpgsqlTypes.NpgsqlPoint(x: 0.8226227759726273d, y: 0.5973287881535899d), new NpgsqlTypes.NpgsqlPoint(x: 0.05243848143506957d, y: 0.8175084380217982d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7721536935014147d, y: 0.8599264692309744d), new NpgsqlTypes.NpgsqlPoint(x: 0.5415714067941542d, y: 0.21316498427352204d), new NpgsqlTypes.NpgsqlPoint(x: 0.7863027393910419d, y: 0.981949765174014d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7981217936813106d, y: 0.6024618150254948d), new NpgsqlTypes.NpgsqlPoint(x: 0.5296555100167881d, y: 0.25943921080047794d), new NpgsqlTypes.NpgsqlPoint(x: 0.947955127276344d, y: 0.5532210526386034d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9124071978010846d, y: 0.27049034311515596d), new NpgsqlTypes.NpgsqlPoint(x: 0.9035743919276252d, y: 0.40173892403690803d), new NpgsqlTypes.NpgsqlPoint(x: 0.7918136772619951d, y: 0.4025612982345994d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9313690588596788d, y: 0.4947071648420418d), new NpgsqlTypes.NpgsqlPoint(x: 0.7627021651485842d, y: 0.9101694735576625d), new NpgsqlTypes.NpgsqlPoint(x: 0.24322074165740515d, y: 0.8214078320039101d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1152480147884416d, y: 0.5840268985538892d), new NpgsqlTypes.NpgsqlPoint(x: 0.5988386302079642d, y: 0.006839505654353872d), new NpgsqlTypes.NpgsqlPoint(x: 0.2636706015093544d, y: 0.6385672755371775d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6510487851831203d, y: 0.6499026229336907d), new NpgsqlTypes.NpgsqlPoint(x: 0.4502859985154555d, y: 0.6626466927849051d), new NpgsqlTypes.NpgsqlPoint(x: 0.5215094749825895d, y: 0.6742246232535564d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6563573085194806d, y: 0.7768842005902414d), new NpgsqlTypes.NpgsqlPoint(x: 0.9313016716463541d, y: 0.8429611892471125d), new NpgsqlTypes.NpgsqlPoint(x: 0.573388798658123d, y: 0.996934953444609d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6074051121523572d, y: 0.12108825798376566d), new NpgsqlTypes.NpgsqlPoint(x: 0.5669387384524016d, y: 0.9793658147231562d), new NpgsqlTypes.NpgsqlPoint(x: 0.4390854234179711d, y: 0.032286862301609265d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9232518509925747d, y: 0.4382971605771734d), new NpgsqlTypes.NpgsqlPoint(x: 0.3209911290011773d, y: 0.6999117564519574d), new NpgsqlTypes.NpgsqlPoint(x: 0.5431301145941637d, y: 0.8087954742241702d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3394217819671159d, y: 0.928374712754934d), new NpgsqlTypes.NpgsqlPoint(x: 0.2864170303303699d, y: 0.29101144516192934d), new NpgsqlTypes.NpgsqlPoint(x: 0.06147910466020157d, y: 0.04894324123190741d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7948741742390811d, y: 0.882510430343346d), new NpgsqlTypes.NpgsqlPoint(x: 0.2188286645477091d, y: 0.7582119136950278d), new NpgsqlTypes.NpgsqlPoint(x: 0.7900086788550652d, y: 0.8566590814566822d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.769266564589876d, y: 0.09342614819800099d), new NpgsqlTypes.NpgsqlPoint(x: 0.5471964095822681d, y: 0.045704156503978854d), new NpgsqlTypes.NpgsqlPoint(x: 0.7411291057976008d, y: 0.9309526660059531d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01781338954038325d, y: 0.9674523845880764d), new NpgsqlTypes.NpgsqlPoint(x: 0.8592742901788568d, y: 0.3424373219330884d), new NpgsqlTypes.NpgsqlPoint(x: 0.7035510374164262d, y: 0.375925703870547d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.938582251559922d, y: 0.21917434915906042d), new NpgsqlTypes.NpgsqlPoint(x: 0.6139180990576133d, y: 0.6499123093333469d), new NpgsqlTypes.NpgsqlPoint(x: 0.97321151000714d, y: 0.5172805802459169d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43751266733003047d, y: 0.9766577604583608d), new NpgsqlTypes.NpgsqlPoint(x: 0.6115979309126505d, y: 0.8850522302348096d), new NpgsqlTypes.NpgsqlPoint(x: 0.3133271295084681d, y: 0.2416137355261817d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.277927606760593d, y: 0.7263110062019804d), new NpgsqlTypes.NpgsqlPoint(x: 0.10850856963295619d, y: 0.591025475890584d), new NpgsqlTypes.NpgsqlPoint(x: 0.4643690383592469d, y: 0.5962408276763864d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6780090250995935d, y: 0.22081048909459455d), new NpgsqlTypes.NpgsqlPoint(x: 0.30882897171577683d, y: 0.7063538065921309d), new NpgsqlTypes.NpgsqlPoint(x: 0.9202898760368101d, y: 0.5470851387338068d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3333099809462414d, y: 0.5546545232696101d), new NpgsqlTypes.NpgsqlPoint(x: 0.5523784533327126d, y: 0.038705401829406405d), new NpgsqlTypes.NpgsqlPoint(x: 0.39499683861262014d, y: 0.10279147079197326d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5501476946687417d, y: 0.5196416665231969d), new NpgsqlTypes.NpgsqlPoint(x: 0.008342279951757625d, y: 0.27013228918514676d), new NpgsqlTypes.NpgsqlPoint(x: 0.15351067487847259d, y: 0.6595636131388628d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7161048874495394d, y: 0.9025736421267628d), new NpgsqlTypes.NpgsqlPoint(x: 0.03512280928275102d, y: 0.03100551446985289d), new NpgsqlTypes.NpgsqlPoint(x: 0.9474374430906476d, y: 0.9755491915994375d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2618796439638056d, y: 0.14708349177551616d), new NpgsqlTypes.NpgsqlPoint(x: 0.3781536519140666d, y: 0.2828222522960414d), new NpgsqlTypes.NpgsqlPoint(x: 0.4257735364302704d, y: 0.785779748722662d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.906625819938099d, y: 0.5606380816734661d), new NpgsqlTypes.NpgsqlPoint(x: 0.09082183392778709d, y: 0.7845520217014526d), new NpgsqlTypes.NpgsqlPoint(x: 0.7316468925558963d, y: 0.9789331206210999d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9975085524099413d, y: 0.03472962839184812d), new NpgsqlTypes.NpgsqlPoint(x: 0.5686972652456055d, y: 0.26024131645714366d), new NpgsqlTypes.NpgsqlPoint(x: 0.31427954970688343d, y: 0.383285435025709d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5174336019898199d, y: 0.6858656474380943d), new NpgsqlTypes.NpgsqlPoint(x: 0.46455134030227263d, y: 0.49733329431974027d), new NpgsqlTypes.NpgsqlPoint(x: 0.5668446756900508d, y: 0.7027762140571144d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16088357414857968d, y: 0.9459673965399557d), new NpgsqlTypes.NpgsqlPoint(x: 0.6489615615168406d, y: 0.7445193637391353d), new NpgsqlTypes.NpgsqlPoint(x: 0.9746493882447675d, y: 0.39964502990433615d)))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5940061975370369d, y: 0.39954929957808105d), new NpgsqlTypes.NpgsqlPoint(x: 0.037000873642683896d, y: 0.48399861937576816d), new NpgsqlTypes.NpgsqlPoint(x: 0.136705030293661d, y: 0.8981601293246569d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.015533980087660604d, y: 0.2622762441088494d), new NpgsqlTypes.NpgsqlPoint(x: 0.8864601412398644d, y: 0.9469826322340891d), new NpgsqlTypes.NpgsqlPoint(x: 0.29398271013757993d, y: 0.8486727731924301d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6210475820023197d, y: 0.780341781726529d), new NpgsqlTypes.NpgsqlPoint(x: 0.12723348310898652d, y: 0.31600791062057987d), new NpgsqlTypes.NpgsqlPoint(x: 0.5864375242367692d, y: 0.2903668706278504d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6191550448059663d, y: 0.044787982345447785d), new NpgsqlTypes.NpgsqlPoint(x: 0.33968784991160383d, y: 0.35623151070721715d), new NpgsqlTypes.NpgsqlPoint(x: 0.9812781180347038d, y: 0.6775146990432375d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7916647664785803d, y: 0.27066407007282134d), new NpgsqlTypes.NpgsqlPoint(x: 0.9754658040655886d, y: 0.05312810205883489d), new NpgsqlTypes.NpgsqlPoint(x: 0.3734887842952024d, y: 0.3491954627544853d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7557466857271669d, y: 0.46831365890734367d), new NpgsqlTypes.NpgsqlPoint(x: 0.5869156468020845d, y: 0.9518338728850962d), new NpgsqlTypes.NpgsqlPoint(x: 0.33953341053726194d, y: 0.5550679115184595d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31092460852417214d, y: 0.8269858009629382d), new NpgsqlTypes.NpgsqlPoint(x: 0.5126418109261699d, y: 0.1828438334208643d), new NpgsqlTypes.NpgsqlPoint(x: 0.399164822314508d, y: 0.10341098171029472d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3828460908859326d, y: 0.658221035324284d), new NpgsqlTypes.NpgsqlPoint(x: 0.8425560525456293d, y: 0.707252111763056d), new NpgsqlTypes.NpgsqlPoint(x: 0.7765908963165904d, y: 0.25058423002318164d)))));

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
FROM public.binary_npgsqlpolygonpolygone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonE0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonE0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygone0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonE0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
FROM public.binary_npgsqlpolygonpolygone0m m
LEFT JOIN public.binary_npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygone0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA), typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
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
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
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
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA), typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
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
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
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
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MI), typeof(NpgsqlPolygonpolygonE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models1 = new List<NpgsqlPolygonpolygonE0MI>();
                var models2 = new List<NpgsqlPolygonpolygonE0MI>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonE0MI>();
                var models2 = new List<NpgsqlPolygonpolygonE0MI>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA), typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

