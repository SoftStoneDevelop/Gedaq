

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
    internal partial interface INpgsqlLineMArraylineMMArrayD2
    {
    }
    
    internal partial class NpgsqlLineMArraylineMMArrayD2 : INpgsqlLineMArraylineMMArrayD2
    {


#region TestData

        private readonly NpgsqlLinelineMMArrayD2E1M[] _testData = new NpgsqlLinelineMMArrayD2E1M[]
        {
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9941703132830189d, b: 0.5582028423720312d, c: 0.7815733552869633d), new NpgsqlTypes.NpgsqlLine(a: 0.3159667657771007d, b: 0.29516894855590303d, c: 0.18105494038059167d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9529915781336487d, b: 0.6455783674703917d, c: 0.7958960323719375d), new NpgsqlTypes.NpgsqlLine(a: 0.8789760222961468d, b: 0.6519636983454803d, c: 0.9665223626325438d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5861366182981465d, b: 0.9112537099388585d, c: 0.7661682615307458d), new NpgsqlTypes.NpgsqlLine(a: 0.6709570210353828d, b: 0.04917719665450582d, c: 0.47604207016945044d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8973101828586146d, b: 0.7753665729513715d, c: 0.024930318317361477d), new NpgsqlTypes.NpgsqlLine(a: 0.018268580408415502d, b: 0.1826191852950413d, c: 0.4308468375100343d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9843712399108826d, b: 0.3998952577226349d, c: 0.3503185883552862d), new NpgsqlTypes.NpgsqlLine(a: 0.982597911353349d, b: 0.3719741870466472d, c: 0.049638044266291925d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8829930726958782d, b: 0.2787623422838238d, c: 0.1974950044054149d), new NpgsqlTypes.NpgsqlLine(a: 0.9725105892794415d, b: 0.9219230881676586d, c: 0.19037179938201798d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.66205642514408d, b: 0.9733523404019611d, c: 0.7876289322886714d), new NpgsqlTypes.NpgsqlLine(a: 0.33863945809670815d, b: 0.008175627320594958d, c: 0.5267433917144466d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.25269764875032985d, b: 0.8179984934101225d, c: 0.4319699674206051d), new NpgsqlTypes.NpgsqlLine(a: 0.07054627727277141d, b: 0.5319834980773661d, c: 0.7167981452162475d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.3829837103422089d, b: 0.4605199813105917d, c: 0.7376758566317269d), new NpgsqlTypes.NpgsqlLine(a: 0.2685318304898371d, b: 0.6351306664781584d, c: 0.2616592342218521d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9444425949837092d, b: 0.17805308827169664d, c: 0.13737382327653525d), new NpgsqlTypes.NpgsqlLine(a: 0.2979059093653119d, b: 0.3792584372794986d, c: 0.18173446338385757d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.2451291275006845d, b: 0.10034451411434064d, c: 0.7048832080369204d), new NpgsqlTypes.NpgsqlLine(a: 0.17200289852451645d, b: 0.8827058745694436d, c: 0.3019335985488537d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.0933832317159381d, b: 0.8874197301761576d, c: 0.05627206830377307d), new NpgsqlTypes.NpgsqlLine(a: 0.407337503679181d, b: 0.7048875215368161d, c: 0.11350775860838191d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.04390147279051948d, b: 0.6629619731739824d, c: 0.2796384040710599d), new NpgsqlTypes.NpgsqlLine(a: 0.9491826748819437d, b: 0.3928078540937855d, c: 0.725321070686105d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.16415415461033422d, b: 0.7018343017661189d, c: 0.45914531254585733d), new NpgsqlTypes.NpgsqlLine(a: 0.865981307602437d, b: 0.7618736496226112d, c: 0.22811245689795046d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.28787592185701527d, b: 0.22713481302664884d, c: 0.20005483190504125d), new NpgsqlTypes.NpgsqlLine(a: 0.6897321446471484d, b: 0.5362186463834916d, c: 0.730771236398011d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.607222954814727d, b: 0.08782190360179398d, c: 0.3603493076401735d), new NpgsqlTypes.NpgsqlLine(a: 0.8795146169756067d, b: 0.8938552319305513d, c: 0.35747346155933724d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8634520509403517d, b: 0.04492144306876156d, c: 0.6820016174749587d), new NpgsqlTypes.NpgsqlLine(a: 0.5641758983875064d, b: 0.8891646594960367d, c: 0.8176386738782675d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8864830011442141d, b: 0.8572415967615457d, c: 0.1294334783011195d), new NpgsqlTypes.NpgsqlLine(a: 0.10759927324078034d, b: 0.3449154139709565d, c: 0.8641686843571859d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9234342413856134d, b: 0.589339370744882d, c: 0.06256340907627889d), new NpgsqlTypes.NpgsqlLine(a: 0.8442897760523728d, b: 0.5729175320663761d, c: 0.35557643157314944d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.4077266759184408d, b: 0.8918532898321622d, c: 0.09393602913966281d), new NpgsqlTypes.NpgsqlLine(a: 0.0726600025159202d, b: 0.877076917771268d, c: 0.814841990502719d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5362022600399848d, b: 0.8225835227130351d, c: 0.017792326567327876d), new NpgsqlTypes.NpgsqlLine(a: 0.8197040924677758d, b: 0.3061360843171951d, c: 0.040669033303415425d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.5113588282643746d, b: 0.4030759156864655d, c: 0.6220257260143588d), new NpgsqlTypes.NpgsqlLine(a: 0.005166777672626188d, b: 0.4007547893226652d, c: 0.9250840265386109d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.07042971258688868d, b: 0.24077445519142282d, c: 0.9239392448144745d), new NpgsqlTypes.NpgsqlLine(a: 0.8272633054824432d, b: 0.7806909463761172d, c: 0.29260779814112925d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.02031153355347093d, b: 0.712839958478285d, c: 0.021310793485695534d), new NpgsqlTypes.NpgsqlLine(a: 0.5678126783763257d, b: 0.48049178805346715d, c: 0.5366344827116959d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.38795045270899386d, b: 0.5159235553118956d, c: 0.7065115680618006d), new NpgsqlTypes.NpgsqlLine(a: 0.5998580715084397d, b: 0.6835936250383353d, c: 0.03975070767961031d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.4529180019304171d, b: 0.562998777587717d, c: 0.1527113690553934d), new NpgsqlTypes.NpgsqlLine(a: 0.17707146022611175d, b: 0.009459334345976345d, c: 0.1356694255701396d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5823893988560626d, b: 0.46782965753375716d, c: 0.8137398249322644d), new NpgsqlTypes.NpgsqlLine(a: 0.8822835003179489d, b: 0.013220741220582255d, c: 0.15020831410856483d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6153507700611639d, b: 0.8041060405365031d, c: 0.0502345699850234d), new NpgsqlTypes.NpgsqlLine(a: 0.9626052977848791d, b: 0.37062015799339276d, c: 0.24220357860099306d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.09592769371335796d, b: 0.3738521494458381d, c: 0.3206001706603755d), new NpgsqlTypes.NpgsqlLine(a: 0.6814327794797855d, b: 0.9460478780234389d, c: 0.5102288603885418d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.11670829154681528d, b: 0.36789139795020687d, c: 0.6165841947539717d), new NpgsqlTypes.NpgsqlLine(a: 0.6738921148294248d, b: 0.7416562267520084d, c: 0.38035556917240687d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.3279041985822909d, b: 0.7571500206841252d, c: 0.8874564768348696d), new NpgsqlTypes.NpgsqlLine(a: 0.463340773884775d, b: 0.6521480685254718d, c: 0.8663404472546006d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8903488662890431d, b: 0.11859067329067718d, c: 0.7025209598298803d), new NpgsqlTypes.NpgsqlLine(a: 0.9771614292317972d, b: 0.24412843402306794d, c: 0.5862416222978043d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9777634537746226d, b: 0.9706032329330118d, c: 0.23175828454767478d), new NpgsqlTypes.NpgsqlLine(a: 0.8100364303428867d, b: 0.6374208518256824d, c: 0.20359410170064363d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.638370406520764d, b: 0.48329009831714287d, c: 0.6778887822830215d), new NpgsqlTypes.NpgsqlLine(a: 0.13540570709400623d, b: 0.47099761626787084d, c: 0.028418620236089653d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5018375285875207d, b: 0.7971904664887924d, c: 0.745019206731728d), new NpgsqlTypes.NpgsqlLine(a: 0.555092741446248d, b: 0.5477539524178833d, c: 0.10398911200972105d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.022931726491324134d, b: 0.6884066691748336d, c: 0.8434959161535701d), new NpgsqlTypes.NpgsqlLine(a: 0.7619669688680893d, b: 0.3923374422922995d, c: 0.6229008061647408d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5120169764891288d, b: 0.44901361029501896d, c: 0.3391111910477316d), new NpgsqlTypes.NpgsqlLine(a: 0.7950422650765697d, b: 0.7154248050666798d, c: 0.8170181911406598d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.5312058094418823d, b: 0.884532630766466d, c: 0.718586630036502d), new NpgsqlTypes.NpgsqlLine(a: 0.6866450963859121d, b: 0.25408191901144406d, c: 0.2522787313734982d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.928110000659532d, b: 0.7673328252043695d, c: 0.3145009717089865d), new NpgsqlTypes.NpgsqlLine(a: 0.3219264741827652d, b: 0.7695735849013853d, c: 0.7868352734982611d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.11457507138061551d, b: 0.4230461556178755d, c: 0.2818498141660858d), new NpgsqlTypes.NpgsqlLine(a: 0.7504815392007315d, b: 0.06465218169182518d, c: 0.9486032809696978d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.48837978768422274d, b: 0.8246525105165865d, c: 0.6324601860592839d), new NpgsqlTypes.NpgsqlLine(a: 0.19004361548193216d, b: 0.5394927792954393d, c: 0.014414650988462285d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6229072521851162d, b: 0.07290755487281741d, c: 0.14001559741422576d), new NpgsqlTypes.NpgsqlLine(a: 0.32447239394765437d, b: 0.7579929200647064d, c: 0.8098292220175569d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.2729021816114572d, b: 0.8257422751211503d, c: 0.6419391601177936d), new NpgsqlTypes.NpgsqlLine(a: 0.919982240594804d, b: 0.5162654822145347d, c: 0.5181789009983016d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6446797232569262d, b: 0.47160440713086105d, c: 0.06544587600221563d), new NpgsqlTypes.NpgsqlLine(a: 0.03392285761191438d, b: 0.89611728613138d, c: 0.39011973503718633d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7779688551863276d, b: 0.5287811004690427d, c: 0.6043582328601265d), new NpgsqlTypes.NpgsqlLine(a: 0.1908873400719514d, b: 0.20180457672093566d, c: 0.3381060582883241d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.5853006330240987d, b: 0.7571596507421474d, c: 0.697971319700105d), new NpgsqlTypes.NpgsqlLine(a: 0.5901721631382555d, b: 0.47456242331166343d, c: 0.8254869572147472d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8645573812108682d, b: 0.04747398208976261d, c: 0.23230478691740208d), new NpgsqlTypes.NpgsqlLine(a: 0.0978631407599474d, b: 0.4519720335953582d, c: 0.47305242467075725d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.020744927993113005d, b: 0.3234711883846204d, c: 0.3220567985952283d), new NpgsqlTypes.NpgsqlLine(a: 0.03242564572425077d, b: 0.9960142239899994d, c: 0.1829946192016314d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.12180327924479495d, b: 0.622858099572053d, c: 0.35311305116086544d), new NpgsqlTypes.NpgsqlLine(a: 0.24722538573843567d, b: 0.832351503658621d, c: 0.7722869723796524d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9732291202219838d, b: 0.894851698026215d, c: 0.3948237463902322d), new NpgsqlTypes.NpgsqlLine(a: 0.3096857578322265d, b: 0.8779564904341381d, c: 0.46170187998244105d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.38263702979007197d, b: 0.03770830040706463d, c: 0.24515758242189523d), new NpgsqlTypes.NpgsqlLine(a: 0.9905269431840008d, b: 0.3530693410696344d, c: 0.39198709357151773d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7481558824313264d, b: 0.35083391832205313d, c: 0.27679042862092074d), new NpgsqlTypes.NpgsqlLine(a: 0.7100536231213223d, b: 0.39123346094760625d, c: 0.6201765185718601d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6064072356157376d, b: 0.11945283023073461d, c: 0.19788126394606653d), new NpgsqlTypes.NpgsqlLine(a: 0.8548719196769873d, b: 0.9100595687007353d, c: 0.0627539906079736d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.2874116641671849d, b: 0.788342329798332d, c: 0.9369766845328206d), new NpgsqlTypes.NpgsqlLine(a: 0.54570478910889d, b: 0.5655138367912098d, c: 0.9601425099281349d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.41075482841447175d, b: 0.8439512671409427d, c: 0.03316186552276357d), new NpgsqlTypes.NpgsqlLine(a: 0.06834069037359236d, b: 0.4345511493999108d, c: 0.6533198353636996d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.08875249965766419d, b: 0.7026710108298707d, c: 0.2260037807972748d), new NpgsqlTypes.NpgsqlLine(a: 0.29767941915110263d, b: 0.07537070478800545d, c: 0.7425318369060608d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.04827660651604382d, b: 0.20342723091391246d, c: 0.1143562022482042d), new NpgsqlTypes.NpgsqlLine(a: 0.2916135064223496d, b: 0.37402860659653114d, c: 0.3917571075713706d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9194916587311676d, b: 0.9860137866573243d, c: 0.47777262647597807d), new NpgsqlTypes.NpgsqlLine(a: 0.48345865011692624d, b: 0.5957183241688713d, c: 0.863140522591698d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.0831869721805445d, b: 0.9444860219545598d, c: 0.27306446278615726d), new NpgsqlTypes.NpgsqlLine(a: 0.5607219950242108d, b: 0.1548380388689884d, c: 0.7739054198557775d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.26530789083435236d, b: 0.6915294696922898d, c: 0.009008444760394752d), new NpgsqlTypes.NpgsqlLine(a: 0.8133775217983684d, b: 0.21532787313662027d, c: 0.4520881023730755d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.18130534031313184d, b: 0.36239655500662604d, c: 0.4579624536833091d), new NpgsqlTypes.NpgsqlLine(a: 0.7850940176803403d, b: 0.2252221268457575d, c: 0.7273569314017224d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8689633607486348d, b: 0.2482214315567044d, c: 0.3917026738920405d), new NpgsqlTypes.NpgsqlLine(a: 0.4090709819358683d, b: 0.6462133671733262d, c: 0.6855305302453926d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.17694382019665456d, b: 0.6510865524444757d, c: 0.08670284255568406d), new NpgsqlTypes.NpgsqlLine(a: 0.9028118859795935d, b: 0.765094650971544d, c: 0.8353355721585651d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.35622788884422674d, b: 0.04146347898336611d, c: 0.895907134498788d), new NpgsqlTypes.NpgsqlLine(a: 0.8524221922531011d, b: 0.33908231489718477d, c: 0.820560088359932d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7660857949185235d, b: 0.5738556393805392d, c: 0.31368097911883197d), new NpgsqlTypes.NpgsqlLine(a: 0.745876232344539d, b: 0.09541206671540592d, c: 0.18218063517517502d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.15307366418404866d, b: 0.36481766700853846d, c: 0.850559518092229d), new NpgsqlTypes.NpgsqlLine(a: 0.24396715149089832d, b: 0.519075476562003d, c: 0.5123411537904061d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.3568898483426771d, b: 0.8115357122595003d, c: 0.5333631969833956d), new NpgsqlTypes.NpgsqlLine(a: 0.08920773139145377d, b: 0.12735655744322538d, c: 0.694349823878667d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.12087532787815036d, b: 0.8589089378309696d, c: 0.9185839367652999d), new NpgsqlTypes.NpgsqlLine(a: 0.8093759142763025d, b: 0.7512445540125233d, c: 0.5560674258992854d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9886188141215968d, b: 0.7325411092362379d, c: 0.6308323130622026d), new NpgsqlTypes.NpgsqlLine(a: 0.04256830246661736d, b: 0.4591995901502409d, c: 0.7645162437507234d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.935607360095701d, b: 0.38515602289991036d, c: 0.18903527581459956d), new NpgsqlTypes.NpgsqlLine(a: 0.28049916782367523d, b: 0.8108699288019917d, c: 0.4413631447458084d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.0412626597513116d, b: 0.8684769856883963d, c: 0.5970813512612018d), new NpgsqlTypes.NpgsqlLine(a: 0.8110085835575283d, b: 0.9240577203869198d, c: 0.4190504475640303d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7782014236455246d, b: 0.9327031025904463d, c: 0.1853180098676389d), new NpgsqlTypes.NpgsqlLine(a: 0.6923333637214023d, b: 0.8248751199527885d, c: 0.5642735278286146d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.605672901647045d, b: 0.28193592731623784d, c: 0.265087178004357d), new NpgsqlTypes.NpgsqlLine(a: 0.5309954170321155d, b: 0.0013124873312444496d, c: 0.7131114798555397d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.29519292164793276d, b: 0.4609029147755661d, c: 0.596593123102531d), new NpgsqlTypes.NpgsqlLine(a: 0.6389462550702383d, b: 0.892496097898249d, c: 0.3673925428355611d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8595849858015288d, b: 0.26778710123288607d, c: 0.6531909151259028d), new NpgsqlTypes.NpgsqlLine(a: 0.8080270635562792d, b: 0.23049339371247013d, c: 0.7457673389758523d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9858588743535274d, b: 0.05845220687153618d, c: 0.5923224139625572d), new NpgsqlTypes.NpgsqlLine(a: 0.4661567116491748d, b: 0.6452719340651274d, c: 0.9707904440278683d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6556928515256337d, b: 0.9547978838155139d, c: 0.09468289034887845d), new NpgsqlTypes.NpgsqlLine(a: 0.2666013693013327d, b: 0.847859210360997d, c: 0.25537852929661153d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9298218327177448d, b: 0.4540498888114902d, c: 0.03199048460019005d), new NpgsqlTypes.NpgsqlLine(a: 0.8616008700935676d, b: 0.29103313138996467d, c: 0.7205772672397769d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.08496303463298871d, b: 0.10496998071845787d, c: 0.7285329778963432d), new NpgsqlTypes.NpgsqlLine(a: 0.9704412144323917d, b: 0.12849264713321662d, c: 0.043405073240336045d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.2837866340741726d, b: 0.5274941844940427d, c: 0.29693899972700466d), new NpgsqlTypes.NpgsqlLine(a: 0.24782171333411274d, b: 0.5492733475441649d, c: 0.47893995914932896d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.616859832644424d, b: 0.5420935794601734d, c: 0.635660288149603d), new NpgsqlTypes.NpgsqlLine(a: 0.757728162973319d, b: 0.7950656081436974d, c: 0.3576140756139392d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9458578026558716d, b: 0.36708657034566683d, c: 0.5450234755385078d), new NpgsqlTypes.NpgsqlLine(a: 0.7017302445127243d, b: 0.7961284086751268d, c: 0.4197371743439978d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7256466224535537d, b: 0.8523134370884228d, c: 0.011094429155968144d), new NpgsqlTypes.NpgsqlLine(a: 0.4194416306595493d, b: 0.604279926698904d, c: 0.8792205590141845d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.47212564845938465d, b: 0.4084058818865598d, c: 0.048882707088758304d), new NpgsqlTypes.NpgsqlLine(a: 0.08205850724783703d, b: 0.09421049207222687d, c: 0.7262827042338837d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.02663992153242334d, b: 0.1878395770060386d, c: 0.24394441921556942d), new NpgsqlTypes.NpgsqlLine(a: 0.7854548013753556d, b: 0.17474889312828146d, c: 0.0850839074835501d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.729900852883987d, b: 0.8405512209809216d, c: 0.6576474051622564d), new NpgsqlTypes.NpgsqlLine(a: 0.8358442813375123d, b: 0.888371147929191d, c: 0.7859960029183057d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.25200492890370574d, b: 0.5695942584108038d, c: 0.7412097811615572d), new NpgsqlTypes.NpgsqlLine(a: 0.898146715508659d, b: 0.4353718808004349d, c: 0.6461892581444495d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.43173408639078814d, b: 0.13208052627846734d, c: 0.449819337867742d), new NpgsqlTypes.NpgsqlLine(a: 0.97063881456371d, b: 0.7551762334522588d, c: 0.7097849377444019d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7917190243154503d, b: 0.7815096695384856d, c: 0.8745945996095154d), new NpgsqlTypes.NpgsqlLine(a: 0.2913455983855673d, b: 0.5497731559249942d, c: 0.681124560426908d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.31658549023835725d, b: 0.4350995603362553d, c: 0.23878859851690226d), new NpgsqlTypes.NpgsqlLine(a: 0.30147927324268253d, b: 0.994748151084092d, c: 0.1090965558724214d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9046372522219936d, b: 0.03274085896807122d, c: 0.09319536173481024d), new NpgsqlTypes.NpgsqlLine(a: 0.7828322509336478d, b: 0.07099241278843371d, c: 0.3718574648491526d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8764776633517681d, b: 0.9495633273327841d, c: 0.06989722200627213d), new NpgsqlTypes.NpgsqlLine(a: 0.3406990263049182d, b: 0.3923750042596187d, c: 0.38852769399010534d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.09313479045411044d, b: 0.29365394307666126d, c: 0.08390683885646599d), new NpgsqlTypes.NpgsqlLine(a: 0.10312727244669773d, b: 0.5469478784755316d, c: 0.030374090254783548d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.10612203266941389d, b: 0.1754409240393462d, c: 0.21264800785257343d), new NpgsqlTypes.NpgsqlLine(a: 0.8366131735411102d, b: 0.13554459707532196d, c: 0.38698055848321167d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.2762996499116156d, b: 0.7337580391445632d, c: 0.7297120834617515d), new NpgsqlTypes.NpgsqlLine(a: 0.035524870489282656d, b: 0.41577921322133526d, c: 0.3109807923841228d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.350868467199575d, b: 0.6173688087394517d, c: 0.9682840353423671d), new NpgsqlTypes.NpgsqlLine(a: 0.5676202153471254d, b: 0.983535294900083d, c: 0.9325927507083931d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.03208661961609971d, b: 0.1773304180347942d, c: 0.9741137662919274d), new NpgsqlTypes.NpgsqlLine(a: 0.4932970615766138d, b: 0.9140695577030545d, c: 0.43591416034519725d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.5704890227728374d, b: 0.6012592068428471d, c: 0.8290160928624126d), new NpgsqlTypes.NpgsqlLine(a: 0.7583506220832115d, b: 0.2604723811002647d, c: 0.3210692819386445d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9131616702515241d, b: 0.7726745401194043d, c: 0.4521769014766245d), new NpgsqlTypes.NpgsqlLine(a: 0.3229290164475972d, b: 0.12281028689138807d, c: 0.33060029606034425d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.5985767579730876d, b: 0.3827446733822839d, c: 0.07741458054903327d), new NpgsqlTypes.NpgsqlLine(a: 0.4180948943814613d, b: 0.58316832751644d, c: 0.9242266042457422d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.21836535182916705d, b: 0.2935257763645506d, c: 0.2618643427632176d), new NpgsqlTypes.NpgsqlLine(a: 0.4248150058174275d, b: 0.7050309985195773d, c: 0.5246749564857677d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8544310663229396d, b: 0.913496693318377d, c: 0.4086096859198969d), new NpgsqlTypes.NpgsqlLine(a: 0.22417761322075502d, b: 0.8228462945790278d, c: 0.2874949947464487d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7452721730237436d, b: 0.530179738999347d, c: 0.5506372139626009d), new NpgsqlTypes.NpgsqlLine(a: 0.5641852145809708d, b: 0.27499417967639184d, c: 0.8103860335651161d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9565954503590552d, b: 0.11810492245260362d, c: 0.16957797569056843d), new NpgsqlTypes.NpgsqlLine(a: 0.4776182430268223d, b: 0.09109815989103631d, c: 0.20809780202589878d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.45396401442492473d, b: 0.605356847049742d, c: 0.09762553402081708d), new NpgsqlTypes.NpgsqlLine(a: 0.10673605031867162d, b: 0.7122721075976888d, c: 0.2537445812658997d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9734125146132917d, b: 0.13369767412296196d, c: 0.0682635225402205d), new NpgsqlTypes.NpgsqlLine(a: 0.8519631305850628d, b: 0.550013991339173d, c: 0.9581400362284667d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9976605334670979d, b: 0.885058056406821d, c: 0.6981379962948621d), new NpgsqlTypes.NpgsqlLine(a: 0.2428608143055918d, b: 0.0809798882329712d, c: 0.4965621571221517d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.18243325673336985d, b: 0.1742678245202789d, c: 0.0655565380670744d), new NpgsqlTypes.NpgsqlLine(a: 0.7311951402586138d, b: 0.05183123652734045d, c: 0.5117712663426122d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9423291527893111d, b: 0.8144342504131178d, c: 0.1328531027627553d), new NpgsqlTypes.NpgsqlLine(a: 0.5412290339471575d, b: 0.48495962181141017d, c: 0.3771881140959731d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.45791167897422413d, b: 0.8101550751936278d, c: 0.4289567396434134d), new NpgsqlTypes.NpgsqlLine(a: 0.8771057244328822d, b: 0.96854496333702d, c: 0.16640306906769864d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.4964254081344399d, b: 0.5148341740291135d, c: 0.027960691871539378d), new NpgsqlTypes.NpgsqlLine(a: 0.9959183729541244d, b: 0.20208880037715715d, c: 0.7603063229273639d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.600647475387589d, b: 0.523915022855033d, c: 0.4081278653346907d), new NpgsqlTypes.NpgsqlLine(a: 0.4943421512746169d, b: 0.04304963434660125d, c: 0.952963301725313d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.018117821891669772d, b: 0.47526686473962043d, c: 0.04123563825844878d), new NpgsqlTypes.NpgsqlLine(a: 0.9516483152078851d, b: 0.6327009909635716d, c: 0.8447038407756061d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.14090843956785404d, b: 0.8730408429827808d, c: 0.6496244305991424d), new NpgsqlTypes.NpgsqlLine(a: 0.3623874130447148d, b: 0.566027776805654d, c: 0.35206227947036284d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.4526425696794053d, b: 0.38002193392809946d, c: 0.5867331073339987d), new NpgsqlTypes.NpgsqlLine(a: 0.5456623371764848d, b: 0.9525076188124066d, c: 0.6212801371814997d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.2635306768653678d, b: 0.4738542708870366d, c: 0.6735625973392887d), new NpgsqlTypes.NpgsqlLine(a: 0.738670539503686d, b: 0.8817747600020427d, c: 0.08850377547966581d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5598238810041305d, b: 0.44227047319974166d, c: 0.9025341181414548d), new NpgsqlTypes.NpgsqlLine(a: 0.2828636406941013d, b: 0.49344626912832235d, c: 0.3349137079198048d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8644909508740729d, b: 0.5746578314124935d, c: 0.6425059107217502d), new NpgsqlTypes.NpgsqlLine(a: 0.2446467317973524d, b: 0.10798945830368045d, c: 0.42274414412426453d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5987350139779296d, b: 0.1394119803864483d, c: 0.6326054116500666d), new NpgsqlTypes.NpgsqlLine(a: 0.15204939549905216d, b: 0.7856442956314899d, c: 0.9484202209545616d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.19545958527933993d, b: 0.9881735311201751d, c: 0.6273732412516596d), new NpgsqlTypes.NpgsqlLine(a: 0.029436756583783197d, b: 0.34233450066116855d, c: 0.6598373479167198d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6441328578197397d, b: 0.14598698762129725d, c: 0.36117633113426484d), new NpgsqlTypes.NpgsqlLine(a: 0.49639151221970634d, b: 0.6408801370428738d, c: 0.3576136421171823d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.3444233728568358d, b: 0.48670965885270756d, c: 0.2016728837593813d), new NpgsqlTypes.NpgsqlLine(a: 0.854448485576522d, b: 0.22306930890202925d, c: 0.058825133088389214d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.38592154606522455d, b: 0.5177869977209119d, c: 0.32539821535788527d), new NpgsqlTypes.NpgsqlLine(a: 0.35795907675223226d, b: 0.8996228383662548d, c: 0.7636492463691104d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.47447454413847845d, b: 0.3616661594861261d, c: 0.5853749117118013d), new NpgsqlTypes.NpgsqlLine(a: 0.09153270761949073d, b: 0.22677963889135622d, c: 0.45900314225746464d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.10866662384695036d, b: 0.04245138632323486d, c: 0.922831418582475d), new NpgsqlTypes.NpgsqlLine(a: 0.5458420612244667d, b: 0.2306899827259009d, c: 0.6042329743696221d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7008396111177256d, b: 0.040422929590327006d, c: 0.25741869439630416d), new NpgsqlTypes.NpgsqlLine(a: 0.06558255444224192d, b: 0.6548930191015323d, c: 0.11611298387195113d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.1892220124114642d, b: 0.9991232439138796d, c: 0.6329111189554357d), new NpgsqlTypes.NpgsqlLine(a: 0.37478623427810975d, b: 0.11238770831246792d, c: 0.18423833270499956d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.05466552786620693d, b: 0.21964117001427985d, c: 0.9083479150284496d), new NpgsqlTypes.NpgsqlLine(a: 0.5154688645230425d, b: 0.857985041548052d, c: 0.9506336028049379d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.33938487079421287d, b: 0.3820771813325242d, c: 0.35151922994750484d), new NpgsqlTypes.NpgsqlLine(a: 0.6286061971588848d, b: 0.9421508107293216d, c: 0.24048620190351522d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6447390580005524d, b: 0.8926803722452323d, c: 0.5406639190544151d), new NpgsqlTypes.NpgsqlLine(a: 0.7608909142345702d, b: 0.37250454572776903d, c: 0.8495174913693248d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.30980458888025897d, b: 0.7583352144758981d, c: 0.05975145160374529d), new NpgsqlTypes.NpgsqlLine(a: 0.6523325613194408d, b: 0.034434963074472025d, c: 0.5003213744359492d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7156551497919564d, b: 0.4459619481193591d, c: 0.7201960566651683d), new NpgsqlTypes.NpgsqlLine(a: 0.9711312660839237d, b: 0.6155251551684158d, c: 0.5026493726525685d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.007245870707798918d, b: 0.4426208559448712d, c: 0.8850428357043482d), new NpgsqlTypes.NpgsqlLine(a: 0.12675678222804088d, b: 0.35924543129417263d, c: 0.8888610662034967d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.5190211838640476d, b: 0.9882654061489968d, c: 0.8224270578670204d), new NpgsqlTypes.NpgsqlLine(a: 0.8456313923980122d, b: 0.32776769827609076d, c: 0.7658202146838415d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.27103874533930683d, b: 0.7763089231084863d, c: 0.6919324882133727d), new NpgsqlTypes.NpgsqlLine(a: 0.6892080797519083d, b: 0.5693802293442778d, c: 0.7734011106675894d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.4633294558326987d, b: 0.2704645018163023d, c: 0.6896150985675571d), new NpgsqlTypes.NpgsqlLine(a: 0.6375825824814653d, b: 0.09928367944260696d, c: 0.5672512903867273d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9757519654061163d, b: 0.6160169222408339d, c: 0.059491563241718004d), new NpgsqlTypes.NpgsqlLine(a: 0.5949768308550836d, b: 0.10381024174378006d, c: 0.16930618741977377d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6634797950950585d, b: 0.1380366988388747d, c: 0.09518703181911525d), new NpgsqlTypes.NpgsqlLine(a: 0.9875244667943313d, b: 0.11821287101257627d, c: 0.9049432976924431d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9346739550464703d, b: 0.721305042993904d, c: 0.31271000152364326d), new NpgsqlTypes.NpgsqlLine(a: 0.13976708194609289d, b: 0.43433951324433573d, c: 0.003550006959084251d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9460838697800747d, b: 0.09312205860761436d, c: 0.307839421262729d), new NpgsqlTypes.NpgsqlLine(a: 0.40005224286790164d, b: 0.7347929053135179d, c: 0.7930349907893519d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.4821448246686453d, b: 0.6155424466140406d, c: 0.06864970810243431d), new NpgsqlTypes.NpgsqlLine(a: 0.8505663047988682d, b: 0.9498499921351581d, c: 0.1220047182940015d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7261416716191114d, b: 0.9647030515775722d, c: 0.866369103584786d), new NpgsqlTypes.NpgsqlLine(a: 0.6146867350877726d, b: 0.21188392681953816d, c: 0.46121225421320977d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8774065996847237d, b: 0.8493675497076587d, c: 0.4442218230389037d), new NpgsqlTypes.NpgsqlLine(a: 0.03498216956726008d, b: 0.7656563942405572d, c: 0.06679531832721541d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8888652304212087d, b: 0.1558970343075584d, c: 0.20773422753740922d), new NpgsqlTypes.NpgsqlLine(a: 0.8889794005328221d, b: 0.863307371976417d, c: 0.35031928367258935d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.13873332632050428d, b: 0.5921675056224915d, c: 0.5005331369536217d), new NpgsqlTypes.NpgsqlLine(a: 0.8242464275003707d, b: 0.8806396801234333d, c: 0.9548679955078755d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9664082369087504d, b: 0.506905450212516d, c: 0.14210337704730003d), new NpgsqlTypes.NpgsqlLine(a: 0.19183102744727032d, b: 0.827146861553045d, c: 0.9512827052508768d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7699250560932861d, b: 0.8924229998524015d, c: 0.1932463474885845d), new NpgsqlTypes.NpgsqlLine(a: 0.3757543814546711d, b: 0.8271493486438372d, c: 0.5569158704630995d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.5090211981902546d, b: 0.43406298706191004d, c: 0.8964438000350204d), new NpgsqlTypes.NpgsqlLine(a: 0.7843239552235194d, b: 0.5277111868143467d, c: 0.44116133848979944d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.4473668455646994d, b: 0.04357949487832602d, c: 0.6421950285024947d), new NpgsqlTypes.NpgsqlLine(a: 0.5055183441911802d, b: 0.7037379806710133d, c: 0.6130137013113502d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.139645400471181d, b: 0.11305092733309274d, c: 0.6145540491935517d), new NpgsqlTypes.NpgsqlLine(a: 0.34298467241538344d, b: 0.6449239859333408d, c: 0.6315619539599954d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8968689920318935d, b: 0.7659567691132083d, c: 0.40105443434131527d), new NpgsqlTypes.NpgsqlLine(a: 0.6618705838042063d, b: 0.8888919023922114d, c: 0.6360898076831416d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8972148759304724d, b: 0.20088029656496198d, c: 0.453611115257041d), new NpgsqlTypes.NpgsqlLine(a: 0.5910080274561976d, b: 0.7636279697920108d, c: 0.40196894894298496d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.0051491691460407996d, b: 0.7271256854459802d, c: 0.3498659134522123d), new NpgsqlTypes.NpgsqlLine(a: 0.6558615426298168d, b: 0.9871736289143651d, c: 0.7581418727605826d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.08795342063353873d, b: 0.4817410052348351d, c: 0.818140232763114d), new NpgsqlTypes.NpgsqlLine(a: 0.12518845430930214d, b: 0.10090728792508985d, c: 0.7908299817071189d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.27575030495719455d, b: 0.15172793955469344d, c: 0.8368673353977631d), new NpgsqlTypes.NpgsqlLine(a: 0.06344668573548329d, b: 0.9593560551570813d, c: 0.29275972830742425d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6996784409308017d, b: 0.2661241419528666d, c: 0.35856200346153655d), new NpgsqlTypes.NpgsqlLine(a: 0.22915357484601662d, b: 0.7905981079498992d, c: 0.7883762445455594d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.0325128010637078d, b: 0.06505387375851945d, c: 0.29748635382094424d), new NpgsqlTypes.NpgsqlLine(a: 0.9164715366478533d, b: 0.14547392471382503d, c: 0.15725272269903845d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.41380697854178017d, b: 0.7342497403055174d, c: 0.9502210378622563d), new NpgsqlTypes.NpgsqlLine(a: 0.4333440934153905d, b: 0.39854722730669434d, c: 0.1625633035518833d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8483105816993745d, b: 0.4535123804861366d, c: 0.13803235501967315d), new NpgsqlTypes.NpgsqlLine(a: 0.8761058727120521d, b: 0.5468713387638888d, c: 0.06576111147806207d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.011398086041792377d, b: 0.06939650418054177d, c: 0.9773419894536797d), new NpgsqlTypes.NpgsqlLine(a: 0.07874491654162619d, b: 0.7527369248490717d, c: 0.4046341997703604d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.970058503294956d, b: 0.00971767799117118d, c: 0.5504952980288109d), new NpgsqlTypes.NpgsqlLine(a: 0.9889301409355532d, b: 0.6969406724693596d, c: 0.6473319013909923d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.989118811869376d, b: 0.6503315139951752d, c: 0.4774597229353694d), new NpgsqlTypes.NpgsqlLine(a: 0.6279248307481587d, b: 0.17519121505505608d, c: 0.13670501996475604d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6411100237976223d, b: 0.2929474886390371d, c: 0.020885956604523415d), new NpgsqlTypes.NpgsqlLine(a: 0.4403034150286653d, b: 0.9847935507840445d, c: 0.26852474376319635d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9463651705807832d, b: 0.955459208753923d, c: 0.33490881612485546d), new NpgsqlTypes.NpgsqlLine(a: 0.9234394198396779d, b: 0.3371814381962164d, c: 0.9981205487105347d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.04682194637905601d, b: 0.4461836259389249d, c: 0.602658499669949d), new NpgsqlTypes.NpgsqlLine(a: 0.9646502866133604d, b: 0.3504003045999964d, c: 0.38068587674042853d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9232365594659586d, b: 0.7106958401466649d, c: 0.7176339590280068d), new NpgsqlTypes.NpgsqlLine(a: 0.02264740571245183d, b: 0.7450009036985068d, c: 0.8654234978480055d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7960275457739349d, b: 0.39017750987128896d, c: 0.6832549839606928d), new NpgsqlTypes.NpgsqlLine(a: 0.9654520854841863d, b: 0.26969157622626183d, c: 0.31940936435277734d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.538687494052586d, b: 0.21811466745597952d, c: 0.36584071259255d), new NpgsqlTypes.NpgsqlLine(a: 0.4179988249114962d, b: 0.7330694336511192d, c: 0.06282731475076664d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.2633294092876608d, b: 0.6197536785447343d, c: 0.19255243507479558d), new NpgsqlTypes.NpgsqlLine(a: 0.8215204618816003d, b: 0.8181451533178257d, c: 0.987838349596092d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.3696325296298222d, b: 0.6225797206616908d, c: 0.43531154930028193d), new NpgsqlTypes.NpgsqlLine(a: 0.8382236268162377d, b: 0.41621991891538346d, c: 0.8964115840804275d), }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
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

                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinemmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd2e1mi_id
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
    npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.07042971258688868d, b: 0.24077445519142282d, c: 0.9239392448144745d), new NpgsqlTypes.NpgsqlLine(a: 0.8272633054824432d, b: 0.7806909463761172d, c: 0.29260779814112925d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.02031153355347093d, b: 0.712839958478285d, c: 0.021310793485695534d), new NpgsqlTypes.NpgsqlLine(a: 0.5678126783763257d, b: 0.48049178805346715d, c: 0.5366344827116959d), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.3279041985822909d, b: 0.7571500206841252d, c: 0.8874564768348696d), new NpgsqlTypes.NpgsqlLine(a: 0.463340773884775d, b: 0.6521480685254718d, c: 0.8663404472546006d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8903488662890431d, b: 0.11859067329067718d, c: 0.7025209598298803d), new NpgsqlTypes.NpgsqlLine(a: 0.9771614292317972d, b: 0.24412843402306794d, c: 0.5862416222978043d), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5018375285875207d, b: 0.7971904664887924d, c: 0.745019206731728d), new NpgsqlTypes.NpgsqlLine(a: 0.555092741446248d, b: 0.5477539524178833d, c: 0.10398911200972105d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.022931726491324134d, b: 0.6884066691748336d, c: 0.8434959161535701d), new NpgsqlTypes.NpgsqlLine(a: 0.7619669688680893d, b: 0.3923374422922995d, c: 0.6229008061647408d), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.48837978768422274d, b: 0.8246525105165865d, c: 0.6324601860592839d), new NpgsqlTypes.NpgsqlLine(a: 0.19004361548193216d, b: 0.5394927792954393d, c: 0.014414650988462285d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6229072521851162d, b: 0.07290755487281741d, c: 0.14001559741422576d), new NpgsqlTypes.NpgsqlLine(a: 0.32447239394765437d, b: 0.7579929200647064d, c: 0.8098292220175569d), }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd2e1mi_id
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
    npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinemmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7779688551863276d, b: 0.5287811004690427d, c: 0.6043582328601265d), new NpgsqlTypes.NpgsqlLine(a: 0.1908873400719514d, b: 0.20180457672093566d, c: 0.3381060582883241d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.5853006330240987d, b: 0.7571596507421474d, c: 0.697971319700105d), new NpgsqlTypes.NpgsqlLine(a: 0.5901721631382555d, b: 0.47456242331166343d, c: 0.8254869572147472d), }, }));
                nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6064072356157376d, b: 0.11945283023073461d, c: 0.19788126394606653d), new NpgsqlTypes.NpgsqlLine(a: 0.8548719196769873d, b: 0.9100595687007353d, c: 0.0627539906079736d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.2874116641671849d, b: 0.788342329798332d, c: 0.9369766845328206d), new NpgsqlTypes.NpgsqlLine(a: 0.54570478910889d, b: 0.5655138367912098d, c: 0.9601425099281349d), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.17694382019665456d, b: 0.6510865524444757d, c: 0.08670284255568406d), new NpgsqlTypes.NpgsqlLine(a: 0.9028118859795935d, b: 0.765094650971544d, c: 0.8353355721585651d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.35622788884422674d, b: 0.04146347898336611d, c: 0.895907134498788d), new NpgsqlTypes.NpgsqlLine(a: 0.8524221922531011d, b: 0.33908231489718477d, c: 0.820560088359932d), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineMMArrayD2E1M> models = null;

                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineMMArrayD2E1M> models = null;

                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 150;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 112, query1, 155, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 108, query1, 155, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 131, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 63, query1, 108, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 34, query1, 51, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 108, query1, 113, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 7, query1, 23, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 138, query1, 37, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 107, 93))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 23, 58))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineMArraylineMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineMArraylineMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 150);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineMArraylineMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineMArraylineMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 7);
                var models =  ((INpgsqlLineMArraylineMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(33));

                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
FROM public.binary_npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.binary_npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models =  ((INpgsqlLineMArraylineMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA), typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA), typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI), typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA), typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

