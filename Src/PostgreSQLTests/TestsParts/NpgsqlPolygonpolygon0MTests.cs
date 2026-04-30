

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

        private readonly NpgsqlPolygonpolygon0M[] _testData = new NpgsqlPolygonpolygon0M[]
        {
            new NpgsqlPolygonpolygon0M
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47854203589015865d, y: 0.8632395920837231d), new NpgsqlTypes.NpgsqlPoint(x: 0.21951076135728653d, y: 0.16059717266479423d), new NpgsqlTypes.NpgsqlPoint(x: 0.5319597137348396d, y: 0.5180058343701825d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5949844513697679d, y: 0.35439245446545475d), new NpgsqlTypes.NpgsqlPoint(x: 0.03609352996936177d, y: 0.9625121694812953d), new NpgsqlTypes.NpgsqlPoint(x: 0.04441988321745005d, y: 0.9431931570624134d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04479076467063925d, y: 0.9979144753731223d), new NpgsqlTypes.NpgsqlPoint(x: 0.3071511632578434d, y: 0.5871049641087083d), new NpgsqlTypes.NpgsqlPoint(x: 0.7107052857426485d, y: 0.3427949267423346d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5894234810197579d, y: 0.39617020185215446d), new NpgsqlTypes.NpgsqlPoint(x: 0.6358937751487997d, y: 0.15072582786256172d), new NpgsqlTypes.NpgsqlPoint(x: 0.1515605843384461d, y: 0.7908537572907192d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7309864919380982d, y: 0.5458698963760436d), new NpgsqlTypes.NpgsqlPoint(x: 0.25137346219418366d, y: 0.3442187876256255d), new NpgsqlTypes.NpgsqlPoint(x: 0.7439998623111422d, y: 0.09994118285164966d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7074382747634201d, y: 0.3346461346476265d), new NpgsqlTypes.NpgsqlPoint(x: 0.2275041609724111d, y: 0.8547392314862727d), new NpgsqlTypes.NpgsqlPoint(x: 0.08809183813053845d, y: 0.598078401426564d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41323005317976247d, y: 0.7141790931057528d), new NpgsqlTypes.NpgsqlPoint(x: 0.9851363548840308d, y: 0.5270445215277486d), new NpgsqlTypes.NpgsqlPoint(x: 0.15755358431526745d, y: 0.18478680897887745d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8401813765055595d, y: 0.8162449883151163d), new NpgsqlTypes.NpgsqlPoint(x: 0.02838718436912213d, y: 0.9253022652547482d), new NpgsqlTypes.NpgsqlPoint(x: 0.0843335419701724d, y: 0.14800954214349848d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5060914097081468d, y: 0.21211161840780524d), new NpgsqlTypes.NpgsqlPoint(x: 0.49626425495884874d, y: 0.30374230956685355d), new NpgsqlTypes.NpgsqlPoint(x: 0.32481224941509157d, y: 0.6010012762028923d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9128867444030799d, y: 0.9706471950344402d), new NpgsqlTypes.NpgsqlPoint(x: 0.16893546787767344d, y: 0.6328085918590829d), new NpgsqlTypes.NpgsqlPoint(x: 0.1845205006836078d, y: 0.6047182448089415d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8112310116526411d, y: 0.39166543663115283d), new NpgsqlTypes.NpgsqlPoint(x: 0.9861190390296057d, y: 0.5355681028156098d), new NpgsqlTypes.NpgsqlPoint(x: 0.4861231764091626d, y: 0.5450868063610683d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01608807784057187d, y: 0.0594930064090714d), new NpgsqlTypes.NpgsqlPoint(x: 0.04140216809034647d, y: 0.14262379637764167d), new NpgsqlTypes.NpgsqlPoint(x: 0.3221447833409192d, y: 0.761044327039397d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9350192868687435d, y: 0.9465624510808704d), new NpgsqlTypes.NpgsqlPoint(x: 0.03594268032174919d, y: 0.15522619289905304d), new NpgsqlTypes.NpgsqlPoint(x: 0.13382231485225615d, y: 0.7128316239193d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35742027072688143d, y: 0.2868883305948623d), new NpgsqlTypes.NpgsqlPoint(x: 0.5609264024949179d, y: 0.5092289586918365d), new NpgsqlTypes.NpgsqlPoint(x: 0.21525325049354826d, y: 0.9319075067673992d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40339262391205033d, y: 0.09184354736293188d), new NpgsqlTypes.NpgsqlPoint(x: 0.15520568890752895d, y: 0.22094020108280277d), new NpgsqlTypes.NpgsqlPoint(x: 0.38257161407019336d, y: 0.23407439483474823d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2576896481233145d, y: 0.07233721809871518d), new NpgsqlTypes.NpgsqlPoint(x: 0.48515640213308353d, y: 0.9665353399034815d), new NpgsqlTypes.NpgsqlPoint(x: 0.2304452863176537d, y: 0.052855378985326995d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10509289042327419d, y: 0.5886218276961376d), new NpgsqlTypes.NpgsqlPoint(x: 0.8434367175398496d, y: 0.7697706163320451d), new NpgsqlTypes.NpgsqlPoint(x: 0.1898738532378451d, y: 0.217795104174484d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3327051058001693d, y: 0.6823928488940242d), new NpgsqlTypes.NpgsqlPoint(x: 0.8622767317104726d, y: 0.5593940251403483d), new NpgsqlTypes.NpgsqlPoint(x: 0.507807595711752d, y: 0.2975603265470447d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10792781848492938d, y: 0.8708383916450625d), new NpgsqlTypes.NpgsqlPoint(x: 0.8569135940349191d, y: 0.7377846323737739d), new NpgsqlTypes.NpgsqlPoint(x: 0.823701262911664d, y: 0.13927827573393836d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6479461611980292d, y: 0.8668326097333933d), new NpgsqlTypes.NpgsqlPoint(x: 0.486899662003361d, y: 0.03846777728227446d), new NpgsqlTypes.NpgsqlPoint(x: 0.7936230650977261d, y: 0.002438172917123449d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8863005984076276d, y: 0.6626883394510646d), new NpgsqlTypes.NpgsqlPoint(x: 0.7772813470880178d, y: 0.9553586343914595d), new NpgsqlTypes.NpgsqlPoint(x: 0.35456640280941754d, y: 0.2032949703648077d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7939699705310395d, y: 0.9045198186028054d), new NpgsqlTypes.NpgsqlPoint(x: 0.38445799940071135d, y: 0.6140684182000284d), new NpgsqlTypes.NpgsqlPoint(x: 0.3115682619391653d, y: 0.9466318746350769d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3625937964989002d, y: 0.7496775375724646d), new NpgsqlTypes.NpgsqlPoint(x: 0.34134801002738735d, y: 0.014978443339773162d), new NpgsqlTypes.NpgsqlPoint(x: 0.725977375623462d, y: 0.10826738408449277d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9777282599688215d, y: 0.5717383796465876d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810404984280208d, y: 0.1289564059050975d), new NpgsqlTypes.NpgsqlPoint(x: 0.5984744832353461d, y: 0.2239767965226397d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7621968283795096d, y: 0.5503092450804598d), new NpgsqlTypes.NpgsqlPoint(x: 0.5283263594573284d, y: 0.8566687193792157d), new NpgsqlTypes.NpgsqlPoint(x: 0.5766448212781959d, y: 0.9255176933207386d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25441994453344985d, y: 0.8199059021247755d), new NpgsqlTypes.NpgsqlPoint(x: 0.7495223734805441d, y: 0.4697001388372759d), new NpgsqlTypes.NpgsqlPoint(x: 0.5153254097866103d, y: 0.4973804700638518d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3581047582662725d, y: 0.5296989570094808d), new NpgsqlTypes.NpgsqlPoint(x: 0.41109832145377045d, y: 0.7896395836912202d), new NpgsqlTypes.NpgsqlPoint(x: 0.8069530328048186d, y: 0.10171457961100283d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41981349434916815d, y: 0.9836922810105839d), new NpgsqlTypes.NpgsqlPoint(x: 0.4129277071385308d, y: 0.6248104688772149d), new NpgsqlTypes.NpgsqlPoint(x: 0.032962886102523625d, y: 0.5542507369782864d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08711805348556756d, y: 0.7589704365697073d), new NpgsqlTypes.NpgsqlPoint(x: 0.8275414353109345d, y: 0.9169353686911911d), new NpgsqlTypes.NpgsqlPoint(x: 0.8522804073731495d, y: 0.7249396294482657d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6518789863124391d, y: 0.07659867459616765d), new NpgsqlTypes.NpgsqlPoint(x: 0.9093545226433819d, y: 0.9290617469863841d), new NpgsqlTypes.NpgsqlPoint(x: 0.19725744381189236d, y: 0.3487221111457799d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49522595749328546d, y: 0.445128105497979d), new NpgsqlTypes.NpgsqlPoint(x: 0.8576243894126948d, y: 0.1509886123644989d), new NpgsqlTypes.NpgsqlPoint(x: 0.7275810064673848d, y: 0.6496439038204179d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4492963013912873d, y: 0.2926530807303227d), new NpgsqlTypes.NpgsqlPoint(x: 0.40017838915807036d, y: 0.7697766466740059d), new NpgsqlTypes.NpgsqlPoint(x: 0.29410366978774694d, y: 0.053630539627329665d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23845334765111947d, y: 0.8959386829149497d), new NpgsqlTypes.NpgsqlPoint(x: 0.7116697373171442d, y: 0.7915304599260578d), new NpgsqlTypes.NpgsqlPoint(x: 0.7983977280280019d, y: 0.12792702946269296d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14441879469762964d, y: 0.9251685678103317d), new NpgsqlTypes.NpgsqlPoint(x: 0.24790422142171253d, y: 0.41869443227661773d), new NpgsqlTypes.NpgsqlPoint(x: 0.6273401568644607d, y: 0.15175363641856898d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21589112299584146d, y: 0.19353842452683379d), new NpgsqlTypes.NpgsqlPoint(x: 0.31995616381666536d, y: 0.637112765356931d), new NpgsqlTypes.NpgsqlPoint(x: 0.43162732324413455d, y: 0.7677688347959479d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6482137385506258d, y: 0.28449658188472715d), new NpgsqlTypes.NpgsqlPoint(x: 0.8020278851369339d, y: 0.05105300973188209d), new NpgsqlTypes.NpgsqlPoint(x: 0.07875793689535637d, y: 0.4394070830124168d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34971428879028543d, y: 0.25548448504654175d), new NpgsqlTypes.NpgsqlPoint(x: 0.4616495984434055d, y: 0.3772636223098339d), new NpgsqlTypes.NpgsqlPoint(x: 0.3282523740864668d, y: 0.9738033492925648d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7892313079792892d, y: 0.08221592414866497d), new NpgsqlTypes.NpgsqlPoint(x: 0.015964195223893363d, y: 0.34994288457865064d), new NpgsqlTypes.NpgsqlPoint(x: 0.9943888930978593d, y: 0.2172955711859943d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27910866095873244d, y: 0.4436817630921769d), new NpgsqlTypes.NpgsqlPoint(x: 0.007175479300001064d, y: 0.029863566119674445d), new NpgsqlTypes.NpgsqlPoint(x: 0.21955270079101208d, y: 0.2465501382297166d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2849538702036195d, y: 0.6372569030321273d), new NpgsqlTypes.NpgsqlPoint(x: 0.40525120736654874d, y: 0.25538369245140113d), new NpgsqlTypes.NpgsqlPoint(x: 0.8743929604249232d, y: 0.3715174753742392d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36170571042899646d, y: 0.13192567186802173d), new NpgsqlTypes.NpgsqlPoint(x: 0.8501868206506181d, y: 0.14431866819688854d), new NpgsqlTypes.NpgsqlPoint(x: 0.303981756228743d, y: 0.7736464826235475d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5595120563834889d, y: 0.47225569952892865d), new NpgsqlTypes.NpgsqlPoint(x: 0.09252392922958841d, y: 0.2182288551252587d), new NpgsqlTypes.NpgsqlPoint(x: 0.3567903335029786d, y: 0.12066439589667532d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10917132612843661d, y: 0.9177456677990913d), new NpgsqlTypes.NpgsqlPoint(x: 0.028166103125499498d, y: 0.44805532180794483d), new NpgsqlTypes.NpgsqlPoint(x: 0.4328917509183491d, y: 0.1553859882612928d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7012421150173912d, y: 0.23436219133795788d), new NpgsqlTypes.NpgsqlPoint(x: 0.9793026082212046d, y: 0.02603273554259644d), new NpgsqlTypes.NpgsqlPoint(x: 0.4517048297429913d, y: 0.3048873513036142d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9873812952462345d, y: 0.7344948738534179d), new NpgsqlTypes.NpgsqlPoint(x: 0.9408761092435458d, y: 0.33699727182665473d), new NpgsqlTypes.NpgsqlPoint(x: 0.07289105687443087d, y: 0.7398088321522082d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 109,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22408704512723965d, y: 0.3514009768000268d), new NpgsqlTypes.NpgsqlPoint(x: 0.7026015328715233d, y: 0.4252395504282468d), new NpgsqlTypes.NpgsqlPoint(x: 0.5490373450697249d, y: 0.17698679543332374d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2796584340723731d, y: 0.37551589111526673d), new NpgsqlTypes.NpgsqlPoint(x: 0.7829857191996891d, y: 0.21292401214186907d), new NpgsqlTypes.NpgsqlPoint(x: 0.10423347988956833d, y: 0.6526533672644249d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4626786894286027d, y: 0.5363767190000002d), new NpgsqlTypes.NpgsqlPoint(x: 0.036684227154878624d, y: 0.43071103045185455d), new NpgsqlTypes.NpgsqlPoint(x: 0.48225901200417276d, y: 0.12918547393093627d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9598874434463679d, y: 0.5733126297030362d), new NpgsqlTypes.NpgsqlPoint(x: 0.6379697745795281d, y: 0.9771440500267222d), new NpgsqlTypes.NpgsqlPoint(x: 0.395750017214029d, y: 0.48819713821081845d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7044283032782511d, y: 0.619495370901677d), new NpgsqlTypes.NpgsqlPoint(x: 0.8805051526399932d, y: 0.9061310107150312d), new NpgsqlTypes.NpgsqlPoint(x: 0.9230026757908243d, y: 0.4087859248727531d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 122,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8338201117832655d, y: 0.06045469095887335d), new NpgsqlTypes.NpgsqlPoint(x: 0.4629866837280112d, y: 0.19088056055717484d), new NpgsqlTypes.NpgsqlPoint(x: 0.5848941825664705d, y: 0.7791919152899317d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15755851055502434d, y: 0.7149027183166015d), new NpgsqlTypes.NpgsqlPoint(x: 0.025943579663880167d, y: 0.9161383582354821d), new NpgsqlTypes.NpgsqlPoint(x: 0.8922805041234468d, y: 0.8278345233348301d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.154870740298087d, y: 0.6446071118935331d), new NpgsqlTypes.NpgsqlPoint(x: 0.5636182325357448d, y: 0.39508184976030825d), new NpgsqlTypes.NpgsqlPoint(x: 0.11737582570290539d, y: 0.469066608431836d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 129,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8989563858798937d, y: 0.16909010554149528d), new NpgsqlTypes.NpgsqlPoint(x: 0.19061618523399348d, y: 0.7955031984028107d), new NpgsqlTypes.NpgsqlPoint(x: 0.6468957359668825d, y: 0.9507795853878653d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8241353325415366d, y: 0.7113142810430834d), new NpgsqlTypes.NpgsqlPoint(x: 0.333749841685302d, y: 0.38698947735944644d), new NpgsqlTypes.NpgsqlPoint(x: 0.6344796794541114d, y: 0.5902895309478374d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9703287776948224d, y: 0.41494710928073264d), new NpgsqlTypes.NpgsqlPoint(x: 0.6659188548736334d, y: 0.2965102709592594d), new NpgsqlTypes.NpgsqlPoint(x: 0.3889832978184419d, y: 0.8066099439158989d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.030973502246785523d, y: 0.3195215884834709d), new NpgsqlTypes.NpgsqlPoint(x: 0.5746209501562352d, y: 0.34863054767598634d), new NpgsqlTypes.NpgsqlPoint(x: 0.5362095455458603d, y: 0.35696972579959885d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.702780309894357d, y: 0.9642942958022979d), new NpgsqlTypes.NpgsqlPoint(x: 0.9776153827367314d, y: 0.22640361640343898d), new NpgsqlTypes.NpgsqlPoint(x: 0.8801785761873993d, y: 0.07735509385453998d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 134,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5590001537709748d, y: 0.9377967746894111d), new NpgsqlTypes.NpgsqlPoint(x: 0.09068091224509356d, y: 0.34034524167146774d), new NpgsqlTypes.NpgsqlPoint(x: 0.8505843216691523d, y: 0.4377791764834694d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.578521318039991d, y: 0.2153933471277888d), new NpgsqlTypes.NpgsqlPoint(x: 0.9967594914432898d, y: 0.6894524655936248d), new NpgsqlTypes.NpgsqlPoint(x: 0.22996626057234104d, y: 0.1738854929896152d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3992439709616151d, y: 0.7169090395247573d), new NpgsqlTypes.NpgsqlPoint(x: 0.5476405394950119d, y: 0.36651314606141905d), new NpgsqlTypes.NpgsqlPoint(x: 0.19602394716567284d, y: 0.09780583510579033d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6393102665029315d, y: 0.003946845188108394d), new NpgsqlTypes.NpgsqlPoint(x: 0.47988587761311674d, y: 0.26939017417607625d), new NpgsqlTypes.NpgsqlPoint(x: 0.9966653422310259d, y: 0.5002526162930305d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.469079606883972d, y: 0.4060760992713379d), new NpgsqlTypes.NpgsqlPoint(x: 0.6387497740459769d, y: 0.6528507116247284d), new NpgsqlTypes.NpgsqlPoint(x: 0.15540878068361197d, y: 0.3493916239790764d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 157,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2176618579074192d, y: 0.8840931211369485d), new NpgsqlTypes.NpgsqlPoint(x: 0.2501441758580273d, y: 0.9766146684628154d), new NpgsqlTypes.NpgsqlPoint(x: 0.686033170555358d, y: 0.17455202137262715d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7732185547001881d, y: 0.7963928742299331d), new NpgsqlTypes.NpgsqlPoint(x: 0.271136315481453d, y: 0.4581457881339379d), new NpgsqlTypes.NpgsqlPoint(x: 0.7866730187039868d, y: 0.8440086762294993d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3604207440936661d, y: 0.09233658184962501d), new NpgsqlTypes.NpgsqlPoint(x: 0.6006934150157375d, y: 0.4748506359963882d), new NpgsqlTypes.NpgsqlPoint(x: 0.5885103960663388d, y: 0.3215072867875388d)),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
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
INSERT INTO public.npgsqlpolygonpolygon0mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
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
INSERT INTO public.npgsqlpolygonpolygon0mi(
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

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
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
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01608807784057187d, y: 0.0594930064090714d), new NpgsqlTypes.NpgsqlPoint(x: 0.04140216809034647d, y: 0.14262379637764167d), new NpgsqlTypes.NpgsqlPoint(x: 0.3221447833409192d, y: 0.761044327039397d))));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2576896481233145d, y: 0.07233721809871518d), new NpgsqlTypes.NpgsqlPoint(x: 0.48515640213308353d, y: 0.9665353399034815d), new NpgsqlTypes.NpgsqlPoint(x: 0.2304452863176537d, y: 0.052855378985326995d))));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3327051058001693d, y: 0.6823928488940242d), new NpgsqlTypes.NpgsqlPoint(x: 0.8622767317104726d, y: 0.5593940251403483d), new NpgsqlTypes.NpgsqlPoint(x: 0.507807595711752d, y: 0.2975603265470447d))));
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
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25441994453344985d, y: 0.8199059021247755d), new NpgsqlTypes.NpgsqlPoint(x: 0.7495223734805441d, y: 0.4697001388372759d), new NpgsqlTypes.NpgsqlPoint(x: 0.5153254097866103d, y: 0.4973804700638518d))));
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08711805348556756d, y: 0.7589704365697073d), new NpgsqlTypes.NpgsqlPoint(x: 0.8275414353109345d, y: 0.9169353686911911d), new NpgsqlTypes.NpgsqlPoint(x: 0.8522804073731495d, y: 0.7249396294482657d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygon0M> models = null;

                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygon0M> models = null;

                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpolygonpolygon0mi_id
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
                parametrName: "npgsqlpolygonpolygon0mi_id", 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
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

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[29], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[27],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[29], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 57, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 22, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 31, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[26],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatch(connection, 109, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 67, query1, 140, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 22, query1, 84, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatch(connection, 134, query1, 26, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 16, query1, 106, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatchAsync(connection, 140, 57))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatch(connection, 140, 134))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[29], false);
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
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 122);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 76);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47854203589015865d, y: 0.8632395920837231d), new NpgsqlTypes.NpgsqlPoint(x: 0.21951076135728653d, y: 0.16059717266479423d), new NpgsqlTypes.NpgsqlPoint(x: 0.5319597137348396d, y: 0.5180058343701825d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5949844513697679d, y: 0.35439245446545475d), new NpgsqlTypes.NpgsqlPoint(x: 0.03609352996936177d, y: 0.9625121694812953d), new NpgsqlTypes.NpgsqlPoint(x: 0.04441988321745005d, y: 0.9431931570624134d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04479076467063925d, y: 0.9979144753731223d), new NpgsqlTypes.NpgsqlPoint(x: 0.3071511632578434d, y: 0.5871049641087083d), new NpgsqlTypes.NpgsqlPoint(x: 0.7107052857426485d, y: 0.3427949267423346d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5894234810197579d, y: 0.39617020185215446d), new NpgsqlTypes.NpgsqlPoint(x: 0.6358937751487997d, y: 0.15072582786256172d), new NpgsqlTypes.NpgsqlPoint(x: 0.1515605843384461d, y: 0.7908537572907192d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7309864919380982d, y: 0.5458698963760436d), new NpgsqlTypes.NpgsqlPoint(x: 0.25137346219418366d, y: 0.3442187876256255d), new NpgsqlTypes.NpgsqlPoint(x: 0.7439998623111422d, y: 0.09994118285164966d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7074382747634201d, y: 0.3346461346476265d), new NpgsqlTypes.NpgsqlPoint(x: 0.2275041609724111d, y: 0.8547392314862727d), new NpgsqlTypes.NpgsqlPoint(x: 0.08809183813053845d, y: 0.598078401426564d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41323005317976247d, y: 0.7141790931057528d), new NpgsqlTypes.NpgsqlPoint(x: 0.9851363548840308d, y: 0.5270445215277486d), new NpgsqlTypes.NpgsqlPoint(x: 0.15755358431526745d, y: 0.18478680897887745d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8401813765055595d, y: 0.8162449883151163d), new NpgsqlTypes.NpgsqlPoint(x: 0.02838718436912213d, y: 0.9253022652547482d), new NpgsqlTypes.NpgsqlPoint(x: 0.0843335419701724d, y: 0.14800954214349848d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5060914097081468d, y: 0.21211161840780524d), new NpgsqlTypes.NpgsqlPoint(x: 0.49626425495884874d, y: 0.30374230956685355d), new NpgsqlTypes.NpgsqlPoint(x: 0.32481224941509157d, y: 0.6010012762028923d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9128867444030799d, y: 0.9706471950344402d), new NpgsqlTypes.NpgsqlPoint(x: 0.16893546787767344d, y: 0.6328085918590829d), new NpgsqlTypes.NpgsqlPoint(x: 0.1845205006836078d, y: 0.6047182448089415d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8112310116526411d, y: 0.39166543663115283d), new NpgsqlTypes.NpgsqlPoint(x: 0.9861190390296057d, y: 0.5355681028156098d), new NpgsqlTypes.NpgsqlPoint(x: 0.4861231764091626d, y: 0.5450868063610683d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01608807784057187d, y: 0.0594930064090714d), new NpgsqlTypes.NpgsqlPoint(x: 0.04140216809034647d, y: 0.14262379637764167d), new NpgsqlTypes.NpgsqlPoint(x: 0.3221447833409192d, y: 0.761044327039397d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9350192868687435d, y: 0.9465624510808704d), new NpgsqlTypes.NpgsqlPoint(x: 0.03594268032174919d, y: 0.15522619289905304d), new NpgsqlTypes.NpgsqlPoint(x: 0.13382231485225615d, y: 0.7128316239193d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35742027072688143d, y: 0.2868883305948623d), new NpgsqlTypes.NpgsqlPoint(x: 0.5609264024949179d, y: 0.5092289586918365d), new NpgsqlTypes.NpgsqlPoint(x: 0.21525325049354826d, y: 0.9319075067673992d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40339262391205033d, y: 0.09184354736293188d), new NpgsqlTypes.NpgsqlPoint(x: 0.15520568890752895d, y: 0.22094020108280277d), new NpgsqlTypes.NpgsqlPoint(x: 0.38257161407019336d, y: 0.23407439483474823d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2576896481233145d, y: 0.07233721809871518d), new NpgsqlTypes.NpgsqlPoint(x: 0.48515640213308353d, y: 0.9665353399034815d), new NpgsqlTypes.NpgsqlPoint(x: 0.2304452863176537d, y: 0.052855378985326995d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10509289042327419d, y: 0.5886218276961376d), new NpgsqlTypes.NpgsqlPoint(x: 0.8434367175398496d, y: 0.7697706163320451d), new NpgsqlTypes.NpgsqlPoint(x: 0.1898738532378451d, y: 0.217795104174484d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3327051058001693d, y: 0.6823928488940242d), new NpgsqlTypes.NpgsqlPoint(x: 0.8622767317104726d, y: 0.5593940251403483d), new NpgsqlTypes.NpgsqlPoint(x: 0.507807595711752d, y: 0.2975603265470447d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10792781848492938d, y: 0.8708383916450625d), new NpgsqlTypes.NpgsqlPoint(x: 0.8569135940349191d, y: 0.7377846323737739d), new NpgsqlTypes.NpgsqlPoint(x: 0.823701262911664d, y: 0.13927827573393836d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6479461611980292d, y: 0.8668326097333933d), new NpgsqlTypes.NpgsqlPoint(x: 0.486899662003361d, y: 0.03846777728227446d), new NpgsqlTypes.NpgsqlPoint(x: 0.7936230650977261d, y: 0.002438172917123449d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8863005984076276d, y: 0.6626883394510646d), new NpgsqlTypes.NpgsqlPoint(x: 0.7772813470880178d, y: 0.9553586343914595d), new NpgsqlTypes.NpgsqlPoint(x: 0.35456640280941754d, y: 0.2032949703648077d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7939699705310395d, y: 0.9045198186028054d), new NpgsqlTypes.NpgsqlPoint(x: 0.38445799940071135d, y: 0.6140684182000284d), new NpgsqlTypes.NpgsqlPoint(x: 0.3115682619391653d, y: 0.9466318746350769d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3625937964989002d, y: 0.7496775375724646d), new NpgsqlTypes.NpgsqlPoint(x: 0.34134801002738735d, y: 0.014978443339773162d), new NpgsqlTypes.NpgsqlPoint(x: 0.725977375623462d, y: 0.10826738408449277d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9777282599688215d, y: 0.5717383796465876d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810404984280208d, y: 0.1289564059050975d), new NpgsqlTypes.NpgsqlPoint(x: 0.5984744832353461d, y: 0.2239767965226397d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7621968283795096d, y: 0.5503092450804598d), new NpgsqlTypes.NpgsqlPoint(x: 0.5283263594573284d, y: 0.8566687193792157d), new NpgsqlTypes.NpgsqlPoint(x: 0.5766448212781959d, y: 0.9255176933207386d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25441994453344985d, y: 0.8199059021247755d), new NpgsqlTypes.NpgsqlPoint(x: 0.7495223734805441d, y: 0.4697001388372759d), new NpgsqlTypes.NpgsqlPoint(x: 0.5153254097866103d, y: 0.4973804700638518d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3581047582662725d, y: 0.5296989570094808d), new NpgsqlTypes.NpgsqlPoint(x: 0.41109832145377045d, y: 0.7896395836912202d), new NpgsqlTypes.NpgsqlPoint(x: 0.8069530328048186d, y: 0.10171457961100283d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41981349434916815d, y: 0.9836922810105839d), new NpgsqlTypes.NpgsqlPoint(x: 0.4129277071385308d, y: 0.6248104688772149d), new NpgsqlTypes.NpgsqlPoint(x: 0.032962886102523625d, y: 0.5542507369782864d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08711805348556756d, y: 0.7589704365697073d), new NpgsqlTypes.NpgsqlPoint(x: 0.8275414353109345d, y: 0.9169353686911911d), new NpgsqlTypes.NpgsqlPoint(x: 0.8522804073731495d, y: 0.7249396294482657d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6518789863124391d, y: 0.07659867459616765d), new NpgsqlTypes.NpgsqlPoint(x: 0.9093545226433819d, y: 0.9290617469863841d), new NpgsqlTypes.NpgsqlPoint(x: 0.19725744381189236d, y: 0.3487221111457799d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49522595749328546d, y: 0.445128105497979d), new NpgsqlTypes.NpgsqlPoint(x: 0.8576243894126948d, y: 0.1509886123644989d), new NpgsqlTypes.NpgsqlPoint(x: 0.7275810064673848d, y: 0.6496439038204179d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4492963013912873d, y: 0.2926530807303227d), new NpgsqlTypes.NpgsqlPoint(x: 0.40017838915807036d, y: 0.7697766466740059d), new NpgsqlTypes.NpgsqlPoint(x: 0.29410366978774694d, y: 0.053630539627329665d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23845334765111947d, y: 0.8959386829149497d), new NpgsqlTypes.NpgsqlPoint(x: 0.7116697373171442d, y: 0.7915304599260578d), new NpgsqlTypes.NpgsqlPoint(x: 0.7983977280280019d, y: 0.12792702946269296d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14441879469762964d, y: 0.9251685678103317d), new NpgsqlTypes.NpgsqlPoint(x: 0.24790422142171253d, y: 0.41869443227661773d), new NpgsqlTypes.NpgsqlPoint(x: 0.6273401568644607d, y: 0.15175363641856898d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21589112299584146d, y: 0.19353842452683379d), new NpgsqlTypes.NpgsqlPoint(x: 0.31995616381666536d, y: 0.637112765356931d), new NpgsqlTypes.NpgsqlPoint(x: 0.43162732324413455d, y: 0.7677688347959479d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6482137385506258d, y: 0.28449658188472715d), new NpgsqlTypes.NpgsqlPoint(x: 0.8020278851369339d, y: 0.05105300973188209d), new NpgsqlTypes.NpgsqlPoint(x: 0.07875793689535637d, y: 0.4394070830124168d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34971428879028543d, y: 0.25548448504654175d), new NpgsqlTypes.NpgsqlPoint(x: 0.4616495984434055d, y: 0.3772636223098339d), new NpgsqlTypes.NpgsqlPoint(x: 0.3282523740864668d, y: 0.9738033492925648d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7892313079792892d, y: 0.08221592414866497d), new NpgsqlTypes.NpgsqlPoint(x: 0.015964195223893363d, y: 0.34994288457865064d), new NpgsqlTypes.NpgsqlPoint(x: 0.9943888930978593d, y: 0.2172955711859943d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27910866095873244d, y: 0.4436817630921769d), new NpgsqlTypes.NpgsqlPoint(x: 0.007175479300001064d, y: 0.029863566119674445d), new NpgsqlTypes.NpgsqlPoint(x: 0.21955270079101208d, y: 0.2465501382297166d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2849538702036195d, y: 0.6372569030321273d), new NpgsqlTypes.NpgsqlPoint(x: 0.40525120736654874d, y: 0.25538369245140113d), new NpgsqlTypes.NpgsqlPoint(x: 0.8743929604249232d, y: 0.3715174753742392d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36170571042899646d, y: 0.13192567186802173d), new NpgsqlTypes.NpgsqlPoint(x: 0.8501868206506181d, y: 0.14431866819688854d), new NpgsqlTypes.NpgsqlPoint(x: 0.303981756228743d, y: 0.7736464826235475d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5595120563834889d, y: 0.47225569952892865d), new NpgsqlTypes.NpgsqlPoint(x: 0.09252392922958841d, y: 0.2182288551252587d), new NpgsqlTypes.NpgsqlPoint(x: 0.3567903335029786d, y: 0.12066439589667532d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10917132612843661d, y: 0.9177456677990913d), new NpgsqlTypes.NpgsqlPoint(x: 0.028166103125499498d, y: 0.44805532180794483d), new NpgsqlTypes.NpgsqlPoint(x: 0.4328917509183491d, y: 0.1553859882612928d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7012421150173912d, y: 0.23436219133795788d), new NpgsqlTypes.NpgsqlPoint(x: 0.9793026082212046d, y: 0.02603273554259644d), new NpgsqlTypes.NpgsqlPoint(x: 0.4517048297429913d, y: 0.3048873513036142d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9873812952462345d, y: 0.7344948738534179d), new NpgsqlTypes.NpgsqlPoint(x: 0.9408761092435458d, y: 0.33699727182665473d), new NpgsqlTypes.NpgsqlPoint(x: 0.07289105687443087d, y: 0.7398088321522082d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22408704512723965d, y: 0.3514009768000268d), new NpgsqlTypes.NpgsqlPoint(x: 0.7026015328715233d, y: 0.4252395504282468d), new NpgsqlTypes.NpgsqlPoint(x: 0.5490373450697249d, y: 0.17698679543332374d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2796584340723731d, y: 0.37551589111526673d), new NpgsqlTypes.NpgsqlPoint(x: 0.7829857191996891d, y: 0.21292401214186907d), new NpgsqlTypes.NpgsqlPoint(x: 0.10423347988956833d, y: 0.6526533672644249d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4626786894286027d, y: 0.5363767190000002d), new NpgsqlTypes.NpgsqlPoint(x: 0.036684227154878624d, y: 0.43071103045185455d), new NpgsqlTypes.NpgsqlPoint(x: 0.48225901200417276d, y: 0.12918547393093627d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9598874434463679d, y: 0.5733126297030362d), new NpgsqlTypes.NpgsqlPoint(x: 0.6379697745795281d, y: 0.9771440500267222d), new NpgsqlTypes.NpgsqlPoint(x: 0.395750017214029d, y: 0.48819713821081845d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7044283032782511d, y: 0.619495370901677d), new NpgsqlTypes.NpgsqlPoint(x: 0.8805051526399932d, y: 0.9061310107150312d), new NpgsqlTypes.NpgsqlPoint(x: 0.9230026757908243d, y: 0.4087859248727531d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8338201117832655d, y: 0.06045469095887335d), new NpgsqlTypes.NpgsqlPoint(x: 0.4629866837280112d, y: 0.19088056055717484d), new NpgsqlTypes.NpgsqlPoint(x: 0.5848941825664705d, y: 0.7791919152899317d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15755851055502434d, y: 0.7149027183166015d), new NpgsqlTypes.NpgsqlPoint(x: 0.025943579663880167d, y: 0.9161383582354821d), new NpgsqlTypes.NpgsqlPoint(x: 0.8922805041234468d, y: 0.8278345233348301d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.154870740298087d, y: 0.6446071118935331d), new NpgsqlTypes.NpgsqlPoint(x: 0.5636182325357448d, y: 0.39508184976030825d), new NpgsqlTypes.NpgsqlPoint(x: 0.11737582570290539d, y: 0.469066608431836d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8989563858798937d, y: 0.16909010554149528d), new NpgsqlTypes.NpgsqlPoint(x: 0.19061618523399348d, y: 0.7955031984028107d), new NpgsqlTypes.NpgsqlPoint(x: 0.6468957359668825d, y: 0.9507795853878653d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8241353325415366d, y: 0.7113142810430834d), new NpgsqlTypes.NpgsqlPoint(x: 0.333749841685302d, y: 0.38698947735944644d), new NpgsqlTypes.NpgsqlPoint(x: 0.6344796794541114d, y: 0.5902895309478374d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9703287776948224d, y: 0.41494710928073264d), new NpgsqlTypes.NpgsqlPoint(x: 0.6659188548736334d, y: 0.2965102709592594d), new NpgsqlTypes.NpgsqlPoint(x: 0.3889832978184419d, y: 0.8066099439158989d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.030973502246785523d, y: 0.3195215884834709d), new NpgsqlTypes.NpgsqlPoint(x: 0.5746209501562352d, y: 0.34863054767598634d), new NpgsqlTypes.NpgsqlPoint(x: 0.5362095455458603d, y: 0.35696972579959885d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.702780309894357d, y: 0.9642942958022979d), new NpgsqlTypes.NpgsqlPoint(x: 0.9776153827367314d, y: 0.22640361640343898d), new NpgsqlTypes.NpgsqlPoint(x: 0.8801785761873993d, y: 0.07735509385453998d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5590001537709748d, y: 0.9377967746894111d), new NpgsqlTypes.NpgsqlPoint(x: 0.09068091224509356d, y: 0.34034524167146774d), new NpgsqlTypes.NpgsqlPoint(x: 0.8505843216691523d, y: 0.4377791764834694d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.578521318039991d, y: 0.2153933471277888d), new NpgsqlTypes.NpgsqlPoint(x: 0.9967594914432898d, y: 0.6894524655936248d), new NpgsqlTypes.NpgsqlPoint(x: 0.22996626057234104d, y: 0.1738854929896152d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3992439709616151d, y: 0.7169090395247573d), new NpgsqlTypes.NpgsqlPoint(x: 0.5476405394950119d, y: 0.36651314606141905d), new NpgsqlTypes.NpgsqlPoint(x: 0.19602394716567284d, y: 0.09780583510579033d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6393102665029315d, y: 0.003946845188108394d), new NpgsqlTypes.NpgsqlPoint(x: 0.47988587761311674d, y: 0.26939017417607625d), new NpgsqlTypes.NpgsqlPoint(x: 0.9966653422310259d, y: 0.5002526162930305d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.469079606883972d, y: 0.4060760992713379d), new NpgsqlTypes.NpgsqlPoint(x: 0.6387497740459769d, y: 0.6528507116247284d), new NpgsqlTypes.NpgsqlPoint(x: 0.15540878068361197d, y: 0.3493916239790764d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2176618579074192d, y: 0.8840931211369485d), new NpgsqlTypes.NpgsqlPoint(x: 0.2501441758580273d, y: 0.9766146684628154d), new NpgsqlTypes.NpgsqlPoint(x: 0.686033170555358d, y: 0.17455202137262715d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7732185547001881d, y: 0.7963928742299331d), new NpgsqlTypes.NpgsqlPoint(x: 0.271136315481453d, y: 0.4581457881339379d), new NpgsqlTypes.NpgsqlPoint(x: 0.7866730187039868d, y: 0.8440086762294993d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3604207440936661d, y: 0.09233658184962501d), new NpgsqlTypes.NpgsqlPoint(x: 0.6006934150157375d, y: 0.4748506359963882d), new NpgsqlTypes.NpgsqlPoint(x: 0.5885103960663388d, y: 0.3215072867875388d)))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47854203589015865d, y: 0.8632395920837231d), new NpgsqlTypes.NpgsqlPoint(x: 0.21951076135728653d, y: 0.16059717266479423d), new NpgsqlTypes.NpgsqlPoint(x: 0.5319597137348396d, y: 0.5180058343701825d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5949844513697679d, y: 0.35439245446545475d), new NpgsqlTypes.NpgsqlPoint(x: 0.03609352996936177d, y: 0.9625121694812953d), new NpgsqlTypes.NpgsqlPoint(x: 0.04441988321745005d, y: 0.9431931570624134d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04479076467063925d, y: 0.9979144753731223d), new NpgsqlTypes.NpgsqlPoint(x: 0.3071511632578434d, y: 0.5871049641087083d), new NpgsqlTypes.NpgsqlPoint(x: 0.7107052857426485d, y: 0.3427949267423346d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5894234810197579d, y: 0.39617020185215446d), new NpgsqlTypes.NpgsqlPoint(x: 0.6358937751487997d, y: 0.15072582786256172d), new NpgsqlTypes.NpgsqlPoint(x: 0.1515605843384461d, y: 0.7908537572907192d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7309864919380982d, y: 0.5458698963760436d), new NpgsqlTypes.NpgsqlPoint(x: 0.25137346219418366d, y: 0.3442187876256255d), new NpgsqlTypes.NpgsqlPoint(x: 0.7439998623111422d, y: 0.09994118285164966d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7074382747634201d, y: 0.3346461346476265d), new NpgsqlTypes.NpgsqlPoint(x: 0.2275041609724111d, y: 0.8547392314862727d), new NpgsqlTypes.NpgsqlPoint(x: 0.08809183813053845d, y: 0.598078401426564d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41323005317976247d, y: 0.7141790931057528d), new NpgsqlTypes.NpgsqlPoint(x: 0.9851363548840308d, y: 0.5270445215277486d), new NpgsqlTypes.NpgsqlPoint(x: 0.15755358431526745d, y: 0.18478680897887745d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8401813765055595d, y: 0.8162449883151163d), new NpgsqlTypes.NpgsqlPoint(x: 0.02838718436912213d, y: 0.9253022652547482d), new NpgsqlTypes.NpgsqlPoint(x: 0.0843335419701724d, y: 0.14800954214349848d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5060914097081468d, y: 0.21211161840780524d), new NpgsqlTypes.NpgsqlPoint(x: 0.49626425495884874d, y: 0.30374230956685355d), new NpgsqlTypes.NpgsqlPoint(x: 0.32481224941509157d, y: 0.6010012762028923d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9128867444030799d, y: 0.9706471950344402d), new NpgsqlTypes.NpgsqlPoint(x: 0.16893546787767344d, y: 0.6328085918590829d), new NpgsqlTypes.NpgsqlPoint(x: 0.1845205006836078d, y: 0.6047182448089415d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8112310116526411d, y: 0.39166543663115283d), new NpgsqlTypes.NpgsqlPoint(x: 0.9861190390296057d, y: 0.5355681028156098d), new NpgsqlTypes.NpgsqlPoint(x: 0.4861231764091626d, y: 0.5450868063610683d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01608807784057187d, y: 0.0594930064090714d), new NpgsqlTypes.NpgsqlPoint(x: 0.04140216809034647d, y: 0.14262379637764167d), new NpgsqlTypes.NpgsqlPoint(x: 0.3221447833409192d, y: 0.761044327039397d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9350192868687435d, y: 0.9465624510808704d), new NpgsqlTypes.NpgsqlPoint(x: 0.03594268032174919d, y: 0.15522619289905304d), new NpgsqlTypes.NpgsqlPoint(x: 0.13382231485225615d, y: 0.7128316239193d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35742027072688143d, y: 0.2868883305948623d), new NpgsqlTypes.NpgsqlPoint(x: 0.5609264024949179d, y: 0.5092289586918365d), new NpgsqlTypes.NpgsqlPoint(x: 0.21525325049354826d, y: 0.9319075067673992d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40339262391205033d, y: 0.09184354736293188d), new NpgsqlTypes.NpgsqlPoint(x: 0.15520568890752895d, y: 0.22094020108280277d), new NpgsqlTypes.NpgsqlPoint(x: 0.38257161407019336d, y: 0.23407439483474823d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2576896481233145d, y: 0.07233721809871518d), new NpgsqlTypes.NpgsqlPoint(x: 0.48515640213308353d, y: 0.9665353399034815d), new NpgsqlTypes.NpgsqlPoint(x: 0.2304452863176537d, y: 0.052855378985326995d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10509289042327419d, y: 0.5886218276961376d), new NpgsqlTypes.NpgsqlPoint(x: 0.8434367175398496d, y: 0.7697706163320451d), new NpgsqlTypes.NpgsqlPoint(x: 0.1898738532378451d, y: 0.217795104174484d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3327051058001693d, y: 0.6823928488940242d), new NpgsqlTypes.NpgsqlPoint(x: 0.8622767317104726d, y: 0.5593940251403483d), new NpgsqlTypes.NpgsqlPoint(x: 0.507807595711752d, y: 0.2975603265470447d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10792781848492938d, y: 0.8708383916450625d), new NpgsqlTypes.NpgsqlPoint(x: 0.8569135940349191d, y: 0.7377846323737739d), new NpgsqlTypes.NpgsqlPoint(x: 0.823701262911664d, y: 0.13927827573393836d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6479461611980292d, y: 0.8668326097333933d), new NpgsqlTypes.NpgsqlPoint(x: 0.486899662003361d, y: 0.03846777728227446d), new NpgsqlTypes.NpgsqlPoint(x: 0.7936230650977261d, y: 0.002438172917123449d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8863005984076276d, y: 0.6626883394510646d), new NpgsqlTypes.NpgsqlPoint(x: 0.7772813470880178d, y: 0.9553586343914595d), new NpgsqlTypes.NpgsqlPoint(x: 0.35456640280941754d, y: 0.2032949703648077d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7939699705310395d, y: 0.9045198186028054d), new NpgsqlTypes.NpgsqlPoint(x: 0.38445799940071135d, y: 0.6140684182000284d), new NpgsqlTypes.NpgsqlPoint(x: 0.3115682619391653d, y: 0.9466318746350769d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3625937964989002d, y: 0.7496775375724646d), new NpgsqlTypes.NpgsqlPoint(x: 0.34134801002738735d, y: 0.014978443339773162d), new NpgsqlTypes.NpgsqlPoint(x: 0.725977375623462d, y: 0.10826738408449277d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9777282599688215d, y: 0.5717383796465876d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810404984280208d, y: 0.1289564059050975d), new NpgsqlTypes.NpgsqlPoint(x: 0.5984744832353461d, y: 0.2239767965226397d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7621968283795096d, y: 0.5503092450804598d), new NpgsqlTypes.NpgsqlPoint(x: 0.5283263594573284d, y: 0.8566687193792157d), new NpgsqlTypes.NpgsqlPoint(x: 0.5766448212781959d, y: 0.9255176933207386d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25441994453344985d, y: 0.8199059021247755d), new NpgsqlTypes.NpgsqlPoint(x: 0.7495223734805441d, y: 0.4697001388372759d), new NpgsqlTypes.NpgsqlPoint(x: 0.5153254097866103d, y: 0.4973804700638518d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3581047582662725d, y: 0.5296989570094808d), new NpgsqlTypes.NpgsqlPoint(x: 0.41109832145377045d, y: 0.7896395836912202d), new NpgsqlTypes.NpgsqlPoint(x: 0.8069530328048186d, y: 0.10171457961100283d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41981349434916815d, y: 0.9836922810105839d), new NpgsqlTypes.NpgsqlPoint(x: 0.4129277071385308d, y: 0.6248104688772149d), new NpgsqlTypes.NpgsqlPoint(x: 0.032962886102523625d, y: 0.5542507369782864d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08711805348556756d, y: 0.7589704365697073d), new NpgsqlTypes.NpgsqlPoint(x: 0.8275414353109345d, y: 0.9169353686911911d), new NpgsqlTypes.NpgsqlPoint(x: 0.8522804073731495d, y: 0.7249396294482657d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6518789863124391d, y: 0.07659867459616765d), new NpgsqlTypes.NpgsqlPoint(x: 0.9093545226433819d, y: 0.9290617469863841d), new NpgsqlTypes.NpgsqlPoint(x: 0.19725744381189236d, y: 0.3487221111457799d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49522595749328546d, y: 0.445128105497979d), new NpgsqlTypes.NpgsqlPoint(x: 0.8576243894126948d, y: 0.1509886123644989d), new NpgsqlTypes.NpgsqlPoint(x: 0.7275810064673848d, y: 0.6496439038204179d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4492963013912873d, y: 0.2926530807303227d), new NpgsqlTypes.NpgsqlPoint(x: 0.40017838915807036d, y: 0.7697766466740059d), new NpgsqlTypes.NpgsqlPoint(x: 0.29410366978774694d, y: 0.053630539627329665d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23845334765111947d, y: 0.8959386829149497d), new NpgsqlTypes.NpgsqlPoint(x: 0.7116697373171442d, y: 0.7915304599260578d), new NpgsqlTypes.NpgsqlPoint(x: 0.7983977280280019d, y: 0.12792702946269296d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14441879469762964d, y: 0.9251685678103317d), new NpgsqlTypes.NpgsqlPoint(x: 0.24790422142171253d, y: 0.41869443227661773d), new NpgsqlTypes.NpgsqlPoint(x: 0.6273401568644607d, y: 0.15175363641856898d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21589112299584146d, y: 0.19353842452683379d), new NpgsqlTypes.NpgsqlPoint(x: 0.31995616381666536d, y: 0.637112765356931d), new NpgsqlTypes.NpgsqlPoint(x: 0.43162732324413455d, y: 0.7677688347959479d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6482137385506258d, y: 0.28449658188472715d), new NpgsqlTypes.NpgsqlPoint(x: 0.8020278851369339d, y: 0.05105300973188209d), new NpgsqlTypes.NpgsqlPoint(x: 0.07875793689535637d, y: 0.4394070830124168d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34971428879028543d, y: 0.25548448504654175d), new NpgsqlTypes.NpgsqlPoint(x: 0.4616495984434055d, y: 0.3772636223098339d), new NpgsqlTypes.NpgsqlPoint(x: 0.3282523740864668d, y: 0.9738033492925648d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7892313079792892d, y: 0.08221592414866497d), new NpgsqlTypes.NpgsqlPoint(x: 0.015964195223893363d, y: 0.34994288457865064d), new NpgsqlTypes.NpgsqlPoint(x: 0.9943888930978593d, y: 0.2172955711859943d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27910866095873244d, y: 0.4436817630921769d), new NpgsqlTypes.NpgsqlPoint(x: 0.007175479300001064d, y: 0.029863566119674445d), new NpgsqlTypes.NpgsqlPoint(x: 0.21955270079101208d, y: 0.2465501382297166d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2849538702036195d, y: 0.6372569030321273d), new NpgsqlTypes.NpgsqlPoint(x: 0.40525120736654874d, y: 0.25538369245140113d), new NpgsqlTypes.NpgsqlPoint(x: 0.8743929604249232d, y: 0.3715174753742392d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36170571042899646d, y: 0.13192567186802173d), new NpgsqlTypes.NpgsqlPoint(x: 0.8501868206506181d, y: 0.14431866819688854d), new NpgsqlTypes.NpgsqlPoint(x: 0.303981756228743d, y: 0.7736464826235475d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5595120563834889d, y: 0.47225569952892865d), new NpgsqlTypes.NpgsqlPoint(x: 0.09252392922958841d, y: 0.2182288551252587d), new NpgsqlTypes.NpgsqlPoint(x: 0.3567903335029786d, y: 0.12066439589667532d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10917132612843661d, y: 0.9177456677990913d), new NpgsqlTypes.NpgsqlPoint(x: 0.028166103125499498d, y: 0.44805532180794483d), new NpgsqlTypes.NpgsqlPoint(x: 0.4328917509183491d, y: 0.1553859882612928d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7012421150173912d, y: 0.23436219133795788d), new NpgsqlTypes.NpgsqlPoint(x: 0.9793026082212046d, y: 0.02603273554259644d), new NpgsqlTypes.NpgsqlPoint(x: 0.4517048297429913d, y: 0.3048873513036142d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9873812952462345d, y: 0.7344948738534179d), new NpgsqlTypes.NpgsqlPoint(x: 0.9408761092435458d, y: 0.33699727182665473d), new NpgsqlTypes.NpgsqlPoint(x: 0.07289105687443087d, y: 0.7398088321522082d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22408704512723965d, y: 0.3514009768000268d), new NpgsqlTypes.NpgsqlPoint(x: 0.7026015328715233d, y: 0.4252395504282468d), new NpgsqlTypes.NpgsqlPoint(x: 0.5490373450697249d, y: 0.17698679543332374d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2796584340723731d, y: 0.37551589111526673d), new NpgsqlTypes.NpgsqlPoint(x: 0.7829857191996891d, y: 0.21292401214186907d), new NpgsqlTypes.NpgsqlPoint(x: 0.10423347988956833d, y: 0.6526533672644249d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4626786894286027d, y: 0.5363767190000002d), new NpgsqlTypes.NpgsqlPoint(x: 0.036684227154878624d, y: 0.43071103045185455d), new NpgsqlTypes.NpgsqlPoint(x: 0.48225901200417276d, y: 0.12918547393093627d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9598874434463679d, y: 0.5733126297030362d), new NpgsqlTypes.NpgsqlPoint(x: 0.6379697745795281d, y: 0.9771440500267222d), new NpgsqlTypes.NpgsqlPoint(x: 0.395750017214029d, y: 0.48819713821081845d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7044283032782511d, y: 0.619495370901677d), new NpgsqlTypes.NpgsqlPoint(x: 0.8805051526399932d, y: 0.9061310107150312d), new NpgsqlTypes.NpgsqlPoint(x: 0.9230026757908243d, y: 0.4087859248727531d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8338201117832655d, y: 0.06045469095887335d), new NpgsqlTypes.NpgsqlPoint(x: 0.4629866837280112d, y: 0.19088056055717484d), new NpgsqlTypes.NpgsqlPoint(x: 0.5848941825664705d, y: 0.7791919152899317d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15755851055502434d, y: 0.7149027183166015d), new NpgsqlTypes.NpgsqlPoint(x: 0.025943579663880167d, y: 0.9161383582354821d), new NpgsqlTypes.NpgsqlPoint(x: 0.8922805041234468d, y: 0.8278345233348301d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.154870740298087d, y: 0.6446071118935331d), new NpgsqlTypes.NpgsqlPoint(x: 0.5636182325357448d, y: 0.39508184976030825d), new NpgsqlTypes.NpgsqlPoint(x: 0.11737582570290539d, y: 0.469066608431836d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8989563858798937d, y: 0.16909010554149528d), new NpgsqlTypes.NpgsqlPoint(x: 0.19061618523399348d, y: 0.7955031984028107d), new NpgsqlTypes.NpgsqlPoint(x: 0.6468957359668825d, y: 0.9507795853878653d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8241353325415366d, y: 0.7113142810430834d), new NpgsqlTypes.NpgsqlPoint(x: 0.333749841685302d, y: 0.38698947735944644d), new NpgsqlTypes.NpgsqlPoint(x: 0.6344796794541114d, y: 0.5902895309478374d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9703287776948224d, y: 0.41494710928073264d), new NpgsqlTypes.NpgsqlPoint(x: 0.6659188548736334d, y: 0.2965102709592594d), new NpgsqlTypes.NpgsqlPoint(x: 0.3889832978184419d, y: 0.8066099439158989d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.030973502246785523d, y: 0.3195215884834709d), new NpgsqlTypes.NpgsqlPoint(x: 0.5746209501562352d, y: 0.34863054767598634d), new NpgsqlTypes.NpgsqlPoint(x: 0.5362095455458603d, y: 0.35696972579959885d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.702780309894357d, y: 0.9642942958022979d), new NpgsqlTypes.NpgsqlPoint(x: 0.9776153827367314d, y: 0.22640361640343898d), new NpgsqlTypes.NpgsqlPoint(x: 0.8801785761873993d, y: 0.07735509385453998d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5590001537709748d, y: 0.9377967746894111d), new NpgsqlTypes.NpgsqlPoint(x: 0.09068091224509356d, y: 0.34034524167146774d), new NpgsqlTypes.NpgsqlPoint(x: 0.8505843216691523d, y: 0.4377791764834694d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.578521318039991d, y: 0.2153933471277888d), new NpgsqlTypes.NpgsqlPoint(x: 0.9967594914432898d, y: 0.6894524655936248d), new NpgsqlTypes.NpgsqlPoint(x: 0.22996626057234104d, y: 0.1738854929896152d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3992439709616151d, y: 0.7169090395247573d), new NpgsqlTypes.NpgsqlPoint(x: 0.5476405394950119d, y: 0.36651314606141905d), new NpgsqlTypes.NpgsqlPoint(x: 0.19602394716567284d, y: 0.09780583510579033d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6393102665029315d, y: 0.003946845188108394d), new NpgsqlTypes.NpgsqlPoint(x: 0.47988587761311674d, y: 0.26939017417607625d), new NpgsqlTypes.NpgsqlPoint(x: 0.9966653422310259d, y: 0.5002526162930305d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.469079606883972d, y: 0.4060760992713379d), new NpgsqlTypes.NpgsqlPoint(x: 0.6387497740459769d, y: 0.6528507116247284d), new NpgsqlTypes.NpgsqlPoint(x: 0.15540878068361197d, y: 0.3493916239790764d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2176618579074192d, y: 0.8840931211369485d), new NpgsqlTypes.NpgsqlPoint(x: 0.2501441758580273d, y: 0.9766146684628154d), new NpgsqlTypes.NpgsqlPoint(x: 0.686033170555358d, y: 0.17455202137262715d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7732185547001881d, y: 0.7963928742299331d), new NpgsqlTypes.NpgsqlPoint(x: 0.271136315481453d, y: 0.4581457881339379d), new NpgsqlTypes.NpgsqlPoint(x: 0.7866730187039868d, y: 0.8440086762294993d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3604207440936661d, y: 0.09233658184962501d), new NpgsqlTypes.NpgsqlPoint(x: 0.6006934150157375d, y: 0.4748506359963882d), new NpgsqlTypes.NpgsqlPoint(x: 0.5885103960663388d, y: 0.3215072867875388d)))));

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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MI),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygon0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MI),
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygon0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygon0M),
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
FROM public.binary_npgsqlpolygonpolygon0m m
LEFT JOIN public.binary_npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygon0M>(15);

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
                ((INpgsqlPolygonSingleTypepolygon)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[14], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[15], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[16], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[17], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[18], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[19], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[20], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[21], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[22], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[23], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[24], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[25], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[26], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[27], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[28], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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
                    NpgsqlPolygonpolygon0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
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
                    NpgsqlPolygonpolygon0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

