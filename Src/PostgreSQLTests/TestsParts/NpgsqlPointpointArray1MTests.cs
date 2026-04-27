

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
    internal partial interface INpgsqlPointArraypointArray
    {
    }
    
    internal partial class NpgsqlPointArraypointArray : INpgsqlPointArraypointArray
    {


#region TestData

        private readonly NpgsqlPointpointArray1M[] _testData = new NpgsqlPointpointArray1M[]
        {
            new NpgsqlPointpointArray1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7346967013763768d, y: 0.8621443659611534d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5309538019971648d, y: 0.042674486888857666d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7487993652559076d, y: 0.48080902962830985d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9839957273826142d, y: 0.26387836127615827d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8717759017588499d, y: 0.6156484006468598d),
new NpgsqlTypes.NpgsqlPoint(x: 0.28743661193959125d, y: 0.6827926447130305d),
new NpgsqlTypes.NpgsqlPoint(x: 0.38747008323913146d, y: 0.7193870699589955d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4092574049231542d, y: 0.5944176011604624d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3132369746295218d, y: 0.3846236251405746d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13280129823467368d, y: 0.9397909376040009d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12287351555945814d, y: 0.7937864550487416d),
new NpgsqlTypes.NpgsqlPoint(x: 0.441912653499673d, y: 0.9729598329739845d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7438084599919554d, y: 0.5187561322868102d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5845162213611962d, y: 0.1624801511467907d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2685061779552592d, y: 0.1710688917084766d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8255415656273978d, y: 0.6935088397095845d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1533893873812351d, y: 0.27469310383149204d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6720915462896067d, y: 0.9957375847923645d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6600088596605909d, y: 0.5308754203138112d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40065532009791216d, y: 0.6880211478965201d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5277783417953336d, y: 0.47734981856572933d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23826014534894235d, y: 0.434342508264985d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8397958786575104d, y: 0.6456909532546354d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5349752315317028d, y: 0.8067106100944449d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6328056484925394d, y: 0.3552256758694471d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4614004210591668d, y: 0.7198399730018428d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6667510459056789d, y: 0.1442970574526241d),
new NpgsqlTypes.NpgsqlPoint(x: 0.779599928732106d, y: 0.8057082871733835d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6534029915508063d, y: 0.6773762188561907d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4282582489704021d, y: 0.733432644857968d),
new NpgsqlTypes.NpgsqlPoint(x: 0.011265209939612553d, y: 0.25583388774992555d),
new NpgsqlTypes.NpgsqlPoint(x: 0.047781464967082576d, y: 0.9236959860912185d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5779297158904071d, y: 0.16191785131317815d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5755570963180957d, y: 0.41992102891173555d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6554694681534169d, y: 0.5255432241999327d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8831517377426457d, y: 0.6001581006299282d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2390332877001765d, y: 0.001422497458027694d),
new NpgsqlTypes.NpgsqlPoint(x: 0.641160044054328d, y: 0.31405612616351863d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7139211496023559d, y: 0.2636421880676121d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5850919477941398d, y: 0.5772125304357582d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7785620927816483d, y: 0.3841923473525748d),
new NpgsqlTypes.NpgsqlPoint(x: 0.699117746607374d, y: 0.28232890435910596d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7993108487942548d, y: 0.997656722756427d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.921088295197619d, y: 0.07602613442763373d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7082110111253427d, y: 0.691287345795646d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17087139143416663d, y: 0.22196596950552028d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43877235247343904d, y: 0.040918714693758296d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1257267161191996d, y: 0.4132357126207926d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6672865638531179d, y: 0.8078761709586514d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.44785631110347845d, y: 0.08765632456406114d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9242302308646801d, y: 0.5596730394494324d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1334486260614548d, y: 0.6867100378230717d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.014408454104856583d, y: 0.37704345778332293d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05008434738045642d, y: 0.1375514038653154d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8397741281214467d, y: 0.9959269648204112d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4890346169295513d, y: 0.3580556103699759d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5565819811479941d, y: 0.7325170601625752d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07940565740652594d, y: 0.024012223302871227d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6209954369972991d, y: 0.5756403497297741d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06496589011918719d, y: 0.6149787849672703d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8511398438911691d, y: 0.04731101956935413d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6393922550669159d, y: 0.9680966634132646d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8693494774128402d, y: 0.6632112326738805d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7451536920291765d, y: 0.6053871256810909d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5699757677406988d, y: 0.024312081492286586d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13349790149563312d, y: 0.3858818864057013d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10296727737793354d, y: 0.28643015188382004d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5430345539458531d, y: 0.47123862783133175d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4071498000234851d, y: 0.34692215091101175d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17070101081096523d, y: 0.7913044931592409d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8856295662648921d, y: 0.9619288961782547d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8059313602290842d, y: 0.8943500410939447d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5697718595162243d, y: 0.7585645867787951d),
new NpgsqlTypes.NpgsqlPoint(x: 0.032733024089803275d, y: 0.7345446201883131d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7671337455066809d, y: 0.4533403217203721d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25245064614282964d, y: 0.8450205297407986d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4041660500896087d, y: 0.5141102574374793d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15374869251293954d, y: 0.5577303034914719d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26498240681438034d, y: 0.12053489035628218d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9138053516223d, y: 0.919933316563818d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.45608593989869595d, y: 0.7401108608518554d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9519219158781788d, y: 0.5301229891902752d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9651984792460059d, y: 0.24847718598445634d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04166268818276608d, y: 0.36016675450350844d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26193714752001696d, y: 0.4200763886071045d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8400759620883893d, y: 0.07436653924609304d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9595466396867004d, y: 0.08186658467038554d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9891826447768024d, y: 0.5142617527406795d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7632286696939836d, y: 0.34931295242461446d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2501974713432741d, y: 0.3575948523502446d),
new NpgsqlTypes.NpgsqlPoint(x: 0.37055679033288125d, y: 0.08623847378330052d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10657484992233557d, y: 0.15150282761936196d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2994152357361608d, y: 0.8737954689752262d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8928021514966397d, y: 0.31866444009149963d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6536972215869549d, y: 0.5452432570985235d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7123118830061926d, y: 0.06857926675273207d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8336139593738233d, y: 0.9792145578911196d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5976012521137382d, y: 0.3352544303600775d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7847247930925751d, y: 0.9849320615393831d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9573960778007734d, y: 0.4812764957712474d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7934618214491665d, y: 0.661313369619416d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4382153389800377d, y: 0.11190514051401668d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22776710994192084d, y: 0.5637239687792254d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6269081709281025d, y: 0.5762127056207859d),
new NpgsqlTypes.NpgsqlPoint(x: 0.005642089296595376d, y: 0.22407353563362686d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9588722121465525d, y: 0.2533102087127189d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5794633020326383d, y: 0.8056503415989491d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23025622769338805d, y: 0.6784193935840702d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7289207435698221d, y: 0.7954657104794546d),
new NpgsqlTypes.NpgsqlPoint(x: 0.28742020714421845d, y: 0.9489992738764769d),
new NpgsqlTypes.NpgsqlPoint(x: 0.18194035933248465d, y: 0.9103021273922773d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4762407335799179d, y: 0.9708720601698511d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26663061156285395d, y: 0.7302099849631175d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05004970788015206d, y: 0.0339178080870266d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12175013952951552d, y: 0.7447658909037481d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6033758111457295d, y: 0.7854413478381278d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7771962227889674d, y: 0.6406462798417049d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8249963208665917d, y: 0.4355964688415068d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12271184011875902d, y: 0.0236651177640117d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6457598801106169d, y: 0.008813470335664375d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08046407963829683d, y: 0.38186592505277506d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9026097835363948d, y: 0.36448125904089756d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7137688596411262d, y: 0.18629736590759316d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9788437631139248d, y: 0.4055260330853002d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6719536305232079d, y: 0.11456030804004125d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9810330169113863d, y: 0.20561138210786933d),
new NpgsqlTypes.NpgsqlPoint(x: 0.35712546871240536d, y: 0.25743606450446854d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9610793419392953d, y: 0.517316143952995d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20692717331138544d, y: 0.7322453083512306d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09492306782088311d, y: 0.8646497360472483d),
new NpgsqlTypes.NpgsqlPoint(x: 0.744455475126943d, y: 0.994057403728939d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7482433781353537d, y: 0.8234684191415227d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5331865818074614d, y: 0.29955158211672483d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34247786550935466d, y: 0.7597721397586473d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7218544925837758d, y: 0.575888669223081d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5609219307373204d, y: 0.6325654169760816d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31820688952594867d, y: 0.9102647843819156d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4966711138507275d, y: 0.39365485490025043d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8420633755146437d, y: 0.03845626805894009d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9029636611219086d, y: 0.9572390074787609d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8938901559136299d, y: 0.5552850420725939d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5487881113444998d, y: 0.08350386875648652d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22091869371786665d, y: 0.22255685559797833d),
new NpgsqlTypes.NpgsqlPoint(x: 0.019012965841791685d, y: 0.5138488635832141d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5853000435200977d, y: 0.5541516711084993d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06529226325641901d, y: 0.2497792363651895d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03030340847884161d, y: 0.48446936626539705d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07553541640280792d, y: 0.4933885034534593d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11028011164745843d, y: 0.9667884150855918d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7972673709584018d, y: 0.7942506229207624d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2369133167244234d, y: 0.07069215606848633d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9665397312662928d, y: 0.34619965734570657d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7558756019911543d, y: 0.9934833233850974d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7975841249796919d, y: 0.2982599834800139d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5670167237469299d, y: 0.28439550376106537d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3675809976907912d, y: 0.7999304994403762d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2561993084324735d, y: 0.9297744016269d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10498502257795816d, y: 0.4823470202826059d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6545385032267499d, y: 0.5810652639571565d),
new NpgsqlTypes.NpgsqlPoint(x: 0.42305130545514025d, y: 0.6450877382272272d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8800391099290773d, y: 0.9617615194787328d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9747917451407524d, y: 0.34983672042915637d),
new NpgsqlTypes.NpgsqlPoint(x: 0.41285088559128724d, y: 0.07237448060889562d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22013441539057554d, y: 0.026424624953841347d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14242541323835578d, y: 0.2734514182886415d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4989473155310957d, y: 0.08663807084243014d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5340913411258568d, y: 0.5559929456512552d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5871438051643856d, y: 0.2530609915443611d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9923919613931877d, y: 0.6486691193748112d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5550265098496281d, y: 0.7675519246426366d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5522962163585193d, y: 0.6180499792280405d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.446362313557394d, y: 0.8204778031104278d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8788096939408842d, y: 0.867401049498763d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04677199162708956d, y: 0.43332350827250865d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.35808526029512366d, y: 0.4733308088709399d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4096863515514241d, y: 0.7956282168095765d),
new NpgsqlTypes.NpgsqlPoint(x: 0.38117176372946704d, y: 0.21054713184308083d),
new NpgsqlTypes.NpgsqlPoint(x: 0.014541657036151179d, y: 0.06872030845321786d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6352962062789173d, y: 0.883113891372887d),
new NpgsqlTypes.NpgsqlPoint(x: 0.980891147357317d, y: 0.3978971840122779d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2027877738522319d, y: 0.8243589605830909d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40476810857695034d, y: 0.7145661638918737d),
new NpgsqlTypes.NpgsqlPoint(x: 0.471343441177267d, y: 0.19242279768796744d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6094867583378514d, y: 0.9952719888231616d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7902924955198236d, y: 0.1569266516837512d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2588036594267864d, y: 0.3447647221545628d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4971655582607193d, y: 0.46368366279826423d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9167773148071772d, y: 0.11083861132436401d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4227370517312071d, y: 0.17139033744956d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6958243302640326d, y: 0.3183110438888128d),
new NpgsqlTypes.NpgsqlPoint(x: 0.598141706603808d, y: 0.24395200981674614d),
new NpgsqlTypes.NpgsqlPoint(x: 0.940660505666352d, y: 0.6277900939183584d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.520980521218994d, y: 0.453387592608246d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07046771057400347d, y: 0.5720595166914759d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30041844822817043d, y: 0.1891229698914919d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7235028587113039d, y: 0.7838291426903199d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7165292720661713d, y: 0.9587102197306613d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9132264351182746d, y: 0.4407972513615489d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10991036356638428d, y: 0.8807350689488715d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.34183632193929336d, y: 0.004775608878270887d),
new NpgsqlTypes.NpgsqlPoint(x: 0.524705332147622d, y: 0.6285667303367982d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24077158475550897d, y: 0.4828392615066007d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4416902414803435d, y: 0.8788497657025772d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9139942791698179d, y: 0.08627047864368576d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08451141914674531d, y: 0.48550741378077455d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2587865135122419d, y: 0.9627753021619764d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0576511279755233d, y: 0.7093267544158391d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4453038465756194d, y: 0.34087272320738293d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6017832405036827d, y: 0.675132325076225d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23076447929188615d, y: 0.9706767960579074d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31100224047607117d, y: 0.4661750262359272d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9307065808167351d, y: 0.22182529766663484d),
new NpgsqlTypes.NpgsqlPoint(x: 0.015533132832546093d, y: 0.06960647794161812d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
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

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
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
                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.921088295197619d, y: 0.07602613442763373d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7082110111253427d, y: 0.691287345795646d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17087139143416663d, y: 0.22196596950552028d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06496589011918719d, y: 0.6149787849672703d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8511398438911691d, y: 0.04731101956935413d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6393922550669159d, y: 0.9680966634132646d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8693494774128402d, y: 0.6632112326738805d),
}));
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8856295662648921d, y: 0.9619288961782547d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8059313602290842d, y: 0.8943500410939447d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5697718595162243d, y: 0.7585645867787951d),
new NpgsqlTypes.NpgsqlPoint(x: 0.032733024089803275d, y: 0.7345446201883131d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15374869251293954d, y: 0.5577303034914719d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26498240681438034d, y: 0.12053489035628218d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9138053516223d, y: 0.919933316563818d),
}));
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;

                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointArraypointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointArraypointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 118;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 8;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[29], false);
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
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[29], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[29], false);
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
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 126, query1, 48, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 67, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 61, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 126, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 9, query1, 72, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 21, query1, 8, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 54, query1, 67, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 33, query1, 21, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 150, 14))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[26],_testData[29], false);
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
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatch(connection, 33, 21))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 9);
                var models = await ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[2], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[3], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[4], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[5], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[6], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[7], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[22],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[23],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[24],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[25],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[26],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 89);
                var models =  ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MI),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPointArraypointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPointArraypointArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPointArraypointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointArray1M),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
FROM public.binary_npgsqlpointpointarray1m m
LEFT JOIN public.binary_npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray1M>(15);

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
                ((INpgsqlPointArraypointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPointArraypointArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPointArraypointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPointpointArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPointpointArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPointpointArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPointpointArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPointpointArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPointpointArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPointpointArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPointpointArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPointpointArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPointpointArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPointpointArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPointpointArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPointpointArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPointpointArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPointpointArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
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
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
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
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

