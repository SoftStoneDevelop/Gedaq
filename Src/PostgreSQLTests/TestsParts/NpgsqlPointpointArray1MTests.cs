

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
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6616080655290174d, y: 0.8128476616876963d),
new NpgsqlTypes.NpgsqlPoint(x: 0.022720082848117662d, y: 0.3683277454966347d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8694394744393269d, y: 0.16330079894936933d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2249072958578774d, y: 0.6580147107249382d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8077326325998072d, y: 0.4008725149749428d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2256018226315485d, y: 0.0625172300896264d),
new NpgsqlTypes.NpgsqlPoint(x: 0.042167526975863234d, y: 0.30060041749789423d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.80366672447919d, y: 0.7013259354134915d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24485603259247246d, y: 0.6668480649614635d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6627796498719515d, y: 0.2324541284356958d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8647224549036497d, y: 0.9792885116133022d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8402194474866187d, y: 0.2291726219950595d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14366821950249076d, y: 0.6711466456815498d),
new NpgsqlTypes.NpgsqlPoint(x: 0.28864890588935976d, y: 0.446156950894845d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17953283217002391d, y: 0.15562603030127586d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9205731744390626d, y: 0.5657757538499727d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9938679981700332d, y: 0.9931622251464142d),
new NpgsqlTypes.NpgsqlPoint(x: 0.29575360343194357d, y: 0.5066595524030191d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.35544686742065923d, y: 0.7715529199706196d),
new NpgsqlTypes.NpgsqlPoint(x: 0.980420608470585d, y: 0.5555994948139077d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21690967407345196d, y: 0.39628325082721483d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1681407482788475d, y: 0.9060843886709289d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6027662119661151d, y: 0.5794879921134254d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9638693816815773d, y: 0.7439343278980517d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03624814170138513d, y: 0.26202282003296884d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09440831412867012d, y: 0.5130027862367773d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8500754432024015d, y: 0.278522223701955d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6460228064875917d, y: 0.4428756616356554d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3023239815811529d, y: 0.37691553325315386d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1947092218183154d, y: 0.7781216989554551d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9092031144320116d, y: 0.5012436740004389d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4301322853124093d, y: 0.2589348450728528d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.32842349417598826d, y: 0.43149637483873793d),
new NpgsqlTypes.NpgsqlPoint(x: 0.38655230174577526d, y: 0.776914188460379d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8435767705226298d, y: 0.9623394825723761d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7312750706802466d, y: 0.7723373099456372d),
new NpgsqlTypes.NpgsqlPoint(x: 0.032557926025390316d, y: 0.38604788025297176d),
new NpgsqlTypes.NpgsqlPoint(x: 0.936223030805926d, y: 0.6797006641220129d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.35452966732218993d, y: 0.3502259146736618d),
new NpgsqlTypes.NpgsqlPoint(x: 0.730860474493496d, y: 0.11158483404295005d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2502092748554413d, y: 0.44425848345331076d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9033926206537339d, y: 0.718956755479079d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5175745492335918d, y: 0.704390390455869d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7797766145477228d, y: 0.546728073343402d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34708831191835354d, y: 0.13327013153682554d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37974634081194825d, y: 0.6884263950500602d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25543060667287987d, y: 0.19867417381791252d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1583634974507655d, y: 0.3567604824172539d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12706753775357282d, y: 0.8456931547094358d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10563478214573063d, y: 0.7672144245237795d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2235723083632999d, y: 0.5277016456718657d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5592512233955759d, y: 0.29572777547144147d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15229301170075038d, y: 0.7578251357367163d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5846165131881319d, y: 0.16794126269576382d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24503816765310327d, y: 0.3210851525283974d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9830706404259704d, y: 0.6388254369306147d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16043656223403258d, y: 0.16693700404650902d),
new NpgsqlTypes.NpgsqlPoint(x: 0.47216391629086596d, y: 0.2799404548476524d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16151751053577468d, y: 0.47863011488814067d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3781289553626145d, y: 0.9415279511387951d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9818961436207616d, y: 0.033091438104906556d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6550434302314911d, y: 0.6813483906693054d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1082623487813732d, y: 0.7611803824116122d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05412017622473109d, y: 0.6188444603461379d),
new NpgsqlTypes.NpgsqlPoint(x: 0.030494681391389777d, y: 0.3585048799649324d),
new NpgsqlTypes.NpgsqlPoint(x: 0.18183481616608288d, y: 0.7735170886423428d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37238537165700913d, y: 0.3038692584575743d),
new NpgsqlTypes.NpgsqlPoint(x: 0.02783499516917276d, y: 0.32362801639601746d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9696978585648759d, y: 0.4155722660822857d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5030484824118124d, y: 0.39857408117692106d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36376808433420715d, y: 0.18762669355401806d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6435870435617653d, y: 0.7025257659083115d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8383374731102359d, y: 0.96981953998255d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09149897111870331d, y: 0.5659456747207472d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6394793229862964d, y: 0.3700495846470635d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6036971906243642d, y: 0.9968917573823101d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5276204613468674d, y: 0.11879118415210033d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14069317268688808d, y: 0.0025315294296380797d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.713902336035031d, y: 0.3591683134032303d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6611501921182625d, y: 0.8060361856629216d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5561667461257281d, y: 0.22163611471784916d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5414984553217238d, y: 0.14936808320435757d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5986767803561631d, y: 0.8130659518155404d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21553355914297745d, y: 0.45074499196161366d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15831317490090946d, y: 0.9579619012454271d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5572391957190548d, y: 0.36610935357229746d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04858266853735027d, y: 0.573174835341846d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23968553764671074d, y: 0.1965314831406757d),
new NpgsqlTypes.NpgsqlPoint(x: 0.223776889102547d, y: 0.98641728363068d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8403446256951512d, y: 0.06860043999500931d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43186315303369893d, y: 0.7194701406933961d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1932210039708666d, y: 0.0008020282103573528d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5108287735427652d, y: 0.13887192080119526d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5816969278210312d, y: 0.7320814677381879d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8825229097895846d, y: 0.6550718163725403d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7332469154164114d, y: 0.32738352335410126d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10903776965996648d, y: 0.8741172613015088d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.805149197954783d, y: 0.5306309547192302d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22946264671879546d, y: 0.4139138882494403d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7388793032029198d, y: 0.4499553687872113d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09101429301313957d, y: 0.8391714711832d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5992851819234031d, y: 0.007201202405383134d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6808300995435165d, y: 0.5356757728305148d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5109241520091737d, y: 0.39618687610313186d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6211169218193117d, y: 0.7596346747881391d),
new NpgsqlTypes.NpgsqlPoint(x: 0.605274035774886d, y: 0.4809289588758654d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6161022393872178d, y: 0.9432478320191688d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7654134632617204d, y: 0.9803246906781437d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15357115698392743d, y: 0.11376551640651134d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7440426464002431d, y: 0.15419452455828186d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06854230214211154d, y: 0.48660099743060714d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6282954938783948d, y: 0.518667330732453d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22334829853592608d, y: 0.8888777405600511d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5711184382311448d, y: 0.7431704205179858d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0373691583985325d, y: 0.6627196981607113d),
new NpgsqlTypes.NpgsqlPoint(x: 0.961630224814327d, y: 0.7483516899928099d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4684263644568645d, y: 0.6467578734903426d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7350994500456077d, y: 0.37200770714748466d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1369052146373868d, y: 0.6670539919045917d),
new NpgsqlTypes.NpgsqlPoint(x: 0.592272048415034d, y: 0.03671045407268014d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5596244603211239d, y: 0.9677551713982027d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05105178796612542d, y: 0.11305967167019526d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5506073221725718d, y: 0.16300062674730054d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4315274268688982d, y: 0.7215266117893696d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5800393530505635d, y: 0.7029599687439613d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8449751391350645d, y: 0.9178203419555734d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39284704161906203d, y: 0.7086487636726885d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5483081927380691d, y: 0.36539649807182495d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9470486152851201d, y: 0.6419961343046906d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43064006176323677d, y: 0.6368065950560738d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5924134828878538d, y: 0.2866164823005527d),
new NpgsqlTypes.NpgsqlPoint(x: 0.41955565029316155d, y: 0.17505978575004955d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.01535160353494014d, y: 0.6464991351397661d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10326809231457612d, y: 0.42233981163675505d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8170348954045747d, y: 0.8713462207272392d),
new NpgsqlTypes.NpgsqlPoint(x: 0.40343495758884307d, y: 0.5844567693860119d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07085444757568304d, y: 0.04732535098747459d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6682488820045885d, y: 0.19966810049397177d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14188256029354995d, y: 0.2548855061752723d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9555340849404511d, y: 0.08475245810856724d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3738276078650493d, y: 0.7872854627543326d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19481184687824893d, y: 0.4255840298511425d),
new NpgsqlTypes.NpgsqlPoint(x: 0.42414758414949116d, y: 0.6006873563611254d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9671278769049068d, y: 0.8574787902558177d),
new NpgsqlTypes.NpgsqlPoint(x: 0.040066535925308955d, y: 0.23291283179574562d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07649356413874708d, y: 0.791621670827759d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2584148515030351d, y: 0.23145107965028622d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.747211069992753d, y: 0.6289635220283729d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7629778336263295d, y: 0.4640615539818368d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12346238359294393d, y: 0.05450033223675388d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3090330152008066d, y: 0.08398755198876995d),
new NpgsqlTypes.NpgsqlPoint(x: 0.44272746076052627d, y: 0.12658741067021084d),
new NpgsqlTypes.NpgsqlPoint(x: 0.45295810371319256d, y: 0.7816068594327759d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.917132654856393d, y: 0.48714599730057384d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8257922610709144d, y: 0.06202254244614802d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8496562507367071d, y: 0.19612086850555788d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2926052848937869d, y: 0.9731409695885747d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7093730531042064d, y: 0.634995034514149d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10583242402506121d, y: 0.37963031798231417d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6312823386909101d, y: 0.18979850324992253d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31421386467478796d, y: 0.34667887504357675d),
new NpgsqlTypes.NpgsqlPoint(x: 0.043029814776160635d, y: 0.18044464783650993d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5058231150910637d, y: 0.8604515247936756d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7922265831513746d, y: 0.7700820587536399d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7385480061259684d, y: 0.23335442096445702d),
new NpgsqlTypes.NpgsqlPoint(x: 0.44248921773694705d, y: 0.24762544936515762d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8195311565099385d, y: 0.6070328398314974d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.45817497992801104d, y: 0.00689826150716466d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09009275552658902d, y: 0.7971904750973021d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2842409960159107d, y: 0.37619832040893153d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9689658395980704d, y: 0.11032205546959173d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.362307192281479d, y: 0.6552345792083326d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3368059908020731d, y: 0.525955164992454d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7656952331199209d, y: 0.2955062217310328d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9469319075317467d, y: 0.15616636428425512d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7412993428069272d, y: 0.27238777132749137d),
new NpgsqlTypes.NpgsqlPoint(x: 0.727591050831809d, y: 0.4247452322495967d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5838638013989552d, y: 0.9553185392395099d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5444045861868264d, y: 0.21181694286933117d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8851378831512005d, y: 0.06372936206827051d),
new NpgsqlTypes.NpgsqlPoint(x: 0.47964362581757514d, y: 0.18947027703615416d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12922164230787747d, y: 0.28672635771997745d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7507664388526228d, y: 0.3221854690999034d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7846710863343458d, y: 0.07157114789177565d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3675817965828485d, y: 0.2862497371645525d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21911877815332692d, y: 0.4676978666387026d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3105416813882692d, y: 0.38167558722657124d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14921358503425963d, y: 0.34643874202420843d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4804721325587974d, y: 0.15179258430975306d),
new NpgsqlTypes.NpgsqlPoint(x: 0.29203533394420367d, y: 0.5572488886964984d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16148643851644062d, y: 0.6152814758956073d),
new NpgsqlTypes.NpgsqlPoint(x: 0.41065048941301885d, y: 0.13576601218301443d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23007860940929148d, y: 0.07340461160797096d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8174625829312077d, y: 0.9396838459773462d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6856351014399595d, y: 0.636098698565647d),
new NpgsqlTypes.NpgsqlPoint(x: 0.18918339181431032d, y: 0.42802675184958305d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12909445470917835d, y: 0.4475719863589802d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9524864355171994d, y: 0.943683539595948d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3920233733191355d, y: 0.3360405487593615d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5365684922981506d, y: 0.7001885231211552d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4019639206968848d, y: 0.6168719889707641d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6758912053943414d, y: 0.1950418146419609d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8375150643856446d, y: 0.05222851112351912d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2870759873544354d, y: 0.1946512806577575d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30593610643756297d, y: 0.014703433481457528d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8690621291620014d, y: 0.933052549922117d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07682793428447077d, y: 0.8726650524704003d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21652645002091808d, y: 0.1931964402464128d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6837585875722333d, y: 0.21954562648391862d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08312318291999699d, y: 0.6669903510314443d),
new NpgsqlTypes.NpgsqlPoint(x: 0.68463328024317d, y: 0.641241139311172d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9436645868328178d, y: 0.03906828257246109d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5345683871028784d, y: 0.5249499414685045d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17653061431498485d, y: 0.062057671801185155d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5175725574081902d, y: 0.9073814051789867d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2709325422015354d, y: 0.06444795298448958d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8335553189153855d, y: 0.5018378374599631d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6182550268792513d, y: 0.24792189211332438d),
new NpgsqlTypes.NpgsqlPoint(x: 0.41588152520386223d, y: 0.009426808713309476d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46535122483087865d, y: 0.1692636560207994d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9795904355045003d, y: 0.11175960407456131d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.32138115877009155d, y: 0.6278123636052816d),
new NpgsqlTypes.NpgsqlPoint(x: 0.642661486229626d, y: 0.4457356136152606d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5134926626207797d, y: 0.5334023688201088d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3688852100430302d, y: 0.0683245766099927d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7111456782400463d, y: 0.4804968207041812d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3478808879992725d, y: 0.36115801881041953d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8536979592968305d, y: 0.6649816172445585d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9443206242694487d, y: 0.2846508974849635d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7498125425668204d, y: 0.5809666983487305d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8476105091272113d, y: 0.24884510264243753d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6585587243916404d, y: 0.6714926892203621d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4151540539806041d, y: 0.6271919586349624d),
new NpgsqlTypes.NpgsqlPoint(x: 0.45604248129843217d, y: 0.4055949522589125d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4958865323663374d, y: 0.6393673451097157d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2271276255724054d, y: 0.9066218414381131d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2347074944536116d, y: 0.4218068532852445d),
new NpgsqlTypes.NpgsqlPoint(x: 0.039193672625710274d, y: 0.9557633515793681d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23272184128455786d, y: 0.8186463304633753d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9421566579496476d, y: 0.06547363661276129d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5982131149962291d, y: 0.42883597947742313d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 166,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9386371801373941d, y: 0.9194426358866349d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9311621175032403d, y: 0.7362806710898696d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46642383706945845d, y: 0.4735458436036093d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22349204788010346d, y: 0.9178265741431437d),
new NpgsqlTypes.NpgsqlPoint(x: 0.541139730368767d, y: 0.7857796123497479d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6102274615130043d, y: 0.9948507131506519d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 173,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24897076516325922d, y: 0.9337629373753223d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7645725382204798d, y: 0.9833449036945867d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2670895703995937d, y: 0.0797243895449562d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5158752671730306d, y: 0.6766386431127963d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6355284236991977d, y: 0.8912624934194117d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19945104890040366d, y: 0.03537306569307663d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0468969943221883d, y: 0.983340139952266d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09657282740532758d, y: 0.7474754901994007d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7152648372358539d, y: 0.794227720905031d),
new NpgsqlTypes.NpgsqlPoint(x: 0.048006790026210444d, y: 0.6677914794717449d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6899069246137314d, y: 0.4237333192384557d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 179,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.828838577758706d, y: 0.7407749379245949d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5583169516127685d, y: 0.5816632424209268d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2542848451811113d, y: 0.180284314665911d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8563976836389251d, y: 0.6083322695617561d),
new NpgsqlTypes.NpgsqlPoint(x: 0.48966650024000125d, y: 0.6222059610948313d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5862167352416807d, y: 0.7265852768239895d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4484329497332594d, y: 0.8284580953831204d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 187,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15643844080649894d, y: 0.34090142358835596d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7574366728189875d, y: 0.7461196397282537d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7806110776932719d, y: 0.6087585908925235d),
new NpgsqlTypes.NpgsqlPoint(x: 0.28820022755267993d, y: 0.09216847922348059d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38065297676762566d, y: 0.39513691955701413d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1606524565409092d, y: 0.19264215070241208d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04883725032383035d, y: 0.98427130911922d),
new NpgsqlTypes.NpgsqlPoint(x: 0.358821533982538d, y: 0.967108940164195d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 188,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1463981987023265d, y: 0.15811212819311826d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2287963119953731d, y: 0.6804784371961808d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6051102686190947d, y: 0.7148849829075236d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 193,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3236143381891061d, y: 0.9846172086778626d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34867135651826164d, y: 0.18210991425390877d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6366985387740978d, y: 0.2376406847069863d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6340070641206706d, y: 0.3584706128096806d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3956590335666268d, y: 0.14901734056255245d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7748603725088459d, y: 0.6455687935900561d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11392753456324545d, y: 0.11537767977847935d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8162513751374986d, y: 0.4383839082356724d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0747224366229986d, y: 0.6008285282847066d),
new NpgsqlTypes.NpgsqlPoint(x: 0.27971480570398066d, y: 0.8835555869787564d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8695230021625802d, y: 0.12591499928662098d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 199,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9656554533588182d, y: 0.5177619842680236d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6401327794702018d, y: 0.008199395070540239d),
new NpgsqlTypes.NpgsqlPoint(x: 0.29823205464705205d, y: 0.8310344642787988d),
},
    ModelInner = null,
    NullableValue = null,
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

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15229301170075038d, y: 0.7578251357367163d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5846165131881319d, y: 0.16794126269576382d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24503816765310327d, y: 0.3210851525283974d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9830706404259704d, y: 0.6388254369306147d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3781289553626145d, y: 0.9415279511387951d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9818961436207616d, y: 0.033091438104906556d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6550434302314911d, y: 0.6813483906693054d),
}));
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
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.713902336035031d, y: 0.3591683134032303d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6611501921182625d, y: 0.8060361856629216d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5561667461257281d, y: 0.22163611471784916d),
}));
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09101429301313957d, y: 0.8391714711832d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5992851819234031d, y: 0.007201202405383134d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6808300995435165d, y: 0.5356757728305148d),
}));
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
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 18;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 34;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
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
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 18;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 73;
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
                        Assert.That(models, Has.Count.EqualTo(21));

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
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 132;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 17, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 73, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 92, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[34], false);
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
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 179, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 108, query1, 34, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[26],_testData[34], false);
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
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 157, query1, 68, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 43, query1, 91, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[34], false);
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
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 34, query1, 188, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 83, 96))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatch(connection, 60, 173))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[34], false);
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
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 132);
                var models = await ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[25], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[26], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[27], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[28], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[29], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[30], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[31], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[32], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[33], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 173);
                var models =  ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[30], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[31], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[32], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[33], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[34], false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointArraypointArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointArraypointArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointArraypointArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointArraypointArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointArraypointArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointArraypointArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointArraypointArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointArraypointArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointArraypointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointArraypointArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointArraypointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA), typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                await ((INpgsqlPointArraypointArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                ((INpgsqlPointArraypointArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA), typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                await ((INpgsqlPointArraypointArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                ((INpgsqlPointArraypointArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI), typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models1 = new List<NpgsqlPointpointArray1MI>();
                var models2 = new List<NpgsqlPointpointArray1MI>();
                await ((INpgsqlPointArraypointArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MI>();
                var models2 = new List<NpgsqlPointpointArray1MI>();
                ((INpgsqlPointArraypointArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA), typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                await ((INpgsqlPointArraypointArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                ((INpgsqlPointArraypointArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

