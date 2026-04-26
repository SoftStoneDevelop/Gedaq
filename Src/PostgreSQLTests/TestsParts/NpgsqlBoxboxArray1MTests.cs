

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
    internal partial interface INpgsqlBoxArrayboxArray
    {
    }
    
    internal partial class NpgsqlBoxArrayboxArray : INpgsqlBoxArrayboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray1M[] _testData = new NpgsqlBoxboxArray1M[]
        {
            new NpgsqlBoxboxArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8531956621533755d,right: 0.823993176167334d,bottom: 0.043836048774395175d,left: 0.3655083659009476d),
new NpgsqlTypes.NpgsqlBox(top: 0.7695557238234914d,right: 0.7233334673273552d,bottom: 0.5430699784194932d,left: 0.7134232330052361d),
new NpgsqlTypes.NpgsqlBox(top: 0.9454356674650822d,right: 0.5699331583058985d,bottom: 0.928848754295772d,left: 0.02057071679817435d),
new NpgsqlTypes.NpgsqlBox(top: 0.6847597445987709d,right: 0.9906501821141203d,bottom: 0.4916062045853067d,left: 0.34683504144602806d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.23520461174011997d,right: 0.9668326202441105d,bottom: 0.19465355410232144d,left: 0.623456195767733d),
new NpgsqlTypes.NpgsqlBox(top: 0.5048322149825325d,right: 0.5008780314650383d,bottom: 0.045289740485540575d,left: 0.11763974691952084d),
new NpgsqlTypes.NpgsqlBox(top: 0.7449057574639969d,right: 0.9862033495141784d,bottom: 0.728856115883334d,left: 0.4706604869690266d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2627537926041964d,right: 0.4144457000131281d,bottom: 0.11609115548911919d,left: 0.15203570246462594d),
new NpgsqlTypes.NpgsqlBox(top: 0.6605263254136378d,right: 0.18606611306430743d,bottom: 0.41954929990195666d,left: 0.048955379612286576d),
new NpgsqlTypes.NpgsqlBox(top: 0.5161552141654718d,right: 0.15774967916214222d,bottom: 0.28590542495425353d,left: 0.12115215906785559d),
new NpgsqlTypes.NpgsqlBox(top: 0.533764452545303d,right: 0.9255611702141947d,bottom: 0.04819697556634661d,left: 0.6930352397594061d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.37687686263586617d,right: 0.5178142266408992d,bottom: 0.2787307172928045d,left: 0.15806044599077118d),
new NpgsqlTypes.NpgsqlBox(top: 0.5947490923921914d,right: 0.5795491788744125d,bottom: 0.3764658139663951d,left: 0.15960018448998725d),
new NpgsqlTypes.NpgsqlBox(top: 0.7978844144129391d,right: 0.7773969690946763d,bottom: 0.7946924635148945d,left: 0.16953390439041138d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8627842453995799d,right: 0.7656515971143774d,bottom: 0.6305215816064532d,left: 0.14422907442482968d),
new NpgsqlTypes.NpgsqlBox(top: 0.7232331064391264d,right: 0.6323696417973423d,bottom: 0.5318243139977266d,left: 0.17040083954200824d),
new NpgsqlTypes.NpgsqlBox(top: 0.6983288170287104d,right: 0.7838058240963328d,bottom: 0.5814518844036306d,left: 0.4137261385118747d),
new NpgsqlTypes.NpgsqlBox(top: 0.9089050527232829d,right: 0.8055686333596501d,bottom: 0.870322229078407d,left: 0.03317237550130003d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8680051075007649d,right: 0.604789939904556d,bottom: 0.4163262108140392d,left: 0.4474946671898028d),
new NpgsqlTypes.NpgsqlBox(top: 0.64231367587096d,right: 0.40411398360739403d,bottom: 0.4694567255594929d,left: 0.10492728271834095d),
new NpgsqlTypes.NpgsqlBox(top: 0.9422420159779997d,right: 0.9027804214444202d,bottom: 0.8566538523755632d,left: 0.8186488604154859d),
new NpgsqlTypes.NpgsqlBox(top: 0.865935021507813d,right: 0.9936941969381853d,bottom: 0.48528606495873927d,left: 0.38285014919304217d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9730664206327836d,right: 0.6938913885737384d,bottom: 0.5867775480664742d,left: 0.063225214697048d),
new NpgsqlTypes.NpgsqlBox(top: 0.6754691263851172d,right: 0.6042496091348796d,bottom: 0.02354531927839676d,left: 0.31138945615568125d),
new NpgsqlTypes.NpgsqlBox(top: 0.5896807325815913d,right: 0.9483694404379405d,bottom: 0.16674721209847054d,left: 0.09330225467292486d),
new NpgsqlTypes.NpgsqlBox(top: 0.8427350477175976d,right: 0.589222123875757d,bottom: 0.8176969913963876d,left: 0.4767023386430438d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.16346988934611528d,right: 0.7763655499578559d,bottom: 0.1271958499232314d,left: 0.30248321925442967d),
new NpgsqlTypes.NpgsqlBox(top: 0.6753255626679923d,right: 0.9324043645434313d,bottom: 0.15442847152859507d,left: 0.9218387972236417d),
new NpgsqlTypes.NpgsqlBox(top: 0.38208070301617836d,right: 0.638597881515395d,bottom: 0.359029401361715d,left: 0.5944867476565198d),
new NpgsqlTypes.NpgsqlBox(top: 0.5942545643950737d,right: 0.583081357809808d,bottom: 0.2272583999169292d,left: 0.5653291513602093d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9088936304204138d,right: 0.7640111600870311d,bottom: 0.8080561557659891d,left: 0.20364172938110536d),
new NpgsqlTypes.NpgsqlBox(top: 0.3031099035018857d,right: 0.8594422236253221d,bottom: 0.27347018446296445d,left: 0.1692056883098173d),
new NpgsqlTypes.NpgsqlBox(top: 0.3582820268071749d,right: 0.5588894081257983d,bottom: 0.1518197379551357d,left: 0.23417867283090132d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.047501702504758825d,right: 0.2926347423044414d,bottom: 0.04060078321706495d,left: 0.050651909411491225d),
new NpgsqlTypes.NpgsqlBox(top: 0.4127894081977468d,right: 0.9759619495252879d,bottom: 0.2645843264662884d,left: 0.8335414618542399d),
new NpgsqlTypes.NpgsqlBox(top: 0.7013522884399512d,right: 0.48338603157067717d,bottom: 0.38722185042598034d,left: 0.10154915147792198d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.46044989123826996d,right: 0.9313620338389873d,bottom: 0.2589687062502972d,left: 0.20253755034768162d),
new NpgsqlTypes.NpgsqlBox(top: 0.5247889283101783d,right: 0.5730238195937748d,bottom: 0.12044515678128098d,left: 0.16900463713716307d),
new NpgsqlTypes.NpgsqlBox(top: 0.9881087964906495d,right: 0.2170412182300433d,bottom: 0.06949601403294348d,left: 0.11948743372719806d),
new NpgsqlTypes.NpgsqlBox(top: 0.8116571703156069d,right: 0.7868024038427963d,bottom: 0.3959465561382517d,left: 0.23466441569821483d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.668716581627369d,right: 0.738757414056899d,bottom: 0.5399268099344922d,left: 0.589252054557222d),
new NpgsqlTypes.NpgsqlBox(top: 0.5744785267193401d,right: 0.4038417939489568d,bottom: 0.23832446319827283d,left: 0.18271993625317928d),
new NpgsqlTypes.NpgsqlBox(top: 0.9360022319330734d,right: 0.5594521461432815d,bottom: 0.9277627836048699d,left: 0.0006546314671688203d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6642712066848971d,right: 0.48314459535677357d,bottom: 0.6113261016334922d,left: 0.3108541056277514d),
new NpgsqlTypes.NpgsqlBox(top: 0.8424704915879311d,right: 0.4439475268842664d,bottom: 0.44800567228772714d,left: 0.15923763332650087d),
new NpgsqlTypes.NpgsqlBox(top: 0.5177619871309016d,right: 0.22857698650644043d,bottom: 0.386057683886913d,left: 0.1787698654412747d),
new NpgsqlTypes.NpgsqlBox(top: 0.6311906859237814d,right: 0.6601826437292263d,bottom: 0.2666112260840301d,left: 0.16675710258289134d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8138861546602199d,right: 0.8956898783589369d,bottom: 0.3930101446439219d,left: 0.7642835309244891d),
new NpgsqlTypes.NpgsqlBox(top: 0.11885868713226466d,right: 0.8860895059115581d,bottom: 0.08316091539803883d,left: 0.2965457401976185d),
new NpgsqlTypes.NpgsqlBox(top: 0.7181319276868786d,right: 0.5783132306831132d,bottom: 0.35741654050967d,left: 0.16375297533138267d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5957824092523276d,right: 0.870246401822214d,bottom: 0.3124387290802123d,left: 0.04070026778833524d),
new NpgsqlTypes.NpgsqlBox(top: 0.34674259772613747d,right: 0.7970695117053953d,bottom: 0.25727223005132216d,left: 0.37491530278621854d),
new NpgsqlTypes.NpgsqlBox(top: 0.7766448969592916d,right: 0.9367991498880265d,bottom: 0.26676713424804477d,left: 0.8359191855672835d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7969353281191659d,right: 0.6285108547204364d,bottom: 0.2549636645852903d,left: 0.18335217064096387d),
new NpgsqlTypes.NpgsqlBox(top: 0.5869116176520806d,right: 0.5458759027034639d,bottom: 0.39906047436059544d,left: 0.2343540289100311d),
new NpgsqlTypes.NpgsqlBox(top: 0.8886331421535223d,right: 0.8848905987993627d,bottom: 0.6194618144398746d,left: 0.590827533083532d),
new NpgsqlTypes.NpgsqlBox(top: 0.6874384468178316d,right: 0.5161537000104086d,bottom: 0.4390086386289531d,left: 0.24782682416633073d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.40043508945763684d,right: 0.4836371869015125d,bottom: 0.08090556702015783d,left: 0.3603952141581199d),
new NpgsqlTypes.NpgsqlBox(top: 0.7464419624704145d,right: 0.5442016840203369d,bottom: 0.7081456394082686d,left: 0.14761851214113153d),
new NpgsqlTypes.NpgsqlBox(top: 0.8892733659249454d,right: 0.738190371063497d,bottom: 0.5643473218573885d,left: 0.016218139475112636d),
new NpgsqlTypes.NpgsqlBox(top: 0.9950861491168456d,right: 0.43406499041325397d,bottom: 0.6673071540229705d,left: 0.2883856492285525d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7342689597996535d,right: 0.7300193164229064d,bottom: 0.00042492701374385877d,left: 0.00123599869626978d),
new NpgsqlTypes.NpgsqlBox(top: 0.8300593327432275d,right: 0.9431539987453088d,bottom: 0.4517445270233639d,left: 0.7766564036994782d),
new NpgsqlTypes.NpgsqlBox(top: 0.45593083980281d,right: 0.143641764708635d,bottom: 0.1486096454329382d,left: 0.02948010561114378d),
new NpgsqlTypes.NpgsqlBox(top: 0.928295478486455d,right: 0.8351829732501144d,bottom: 0.7546810949371231d,left: 0.4662475035384046d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9522094888701113d,right: 0.5975636400049423d,bottom: 0.23281275716726313d,left: 0.5865469746532698d),
new NpgsqlTypes.NpgsqlBox(top: 0.30867670634009714d,right: 0.9070811432712986d,bottom: 0.19974112261611277d,left: 0.7178200307279701d),
new NpgsqlTypes.NpgsqlBox(top: 0.9955126818064947d,right: 0.4372378201030963d,bottom: 0.8332032373346447d,left: 0.3458193013316049d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7468988324645848d,right: 0.5386438495931809d,bottom: 0.1358349920042542d,left: 0.277510905397218d),
new NpgsqlTypes.NpgsqlBox(top: 0.7988562564237103d,right: 0.617746923425713d,bottom: 0.17770769797018804d,left: 0.22125204021174993d),
new NpgsqlTypes.NpgsqlBox(top: 0.4380978280505068d,right: 0.9531183584885037d,bottom: 0.33561348023252935d,left: 0.0014565915315699618d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7288718744814914d,right: 0.8013936064824415d,bottom: 0.6038510038525741d,left: 0.04898905669447551d),
new NpgsqlTypes.NpgsqlBox(top: 0.3881392319961765d,right: 0.45786050978809567d,bottom: 0.20480070002798334d,left: 0.26982061862061935d),
new NpgsqlTypes.NpgsqlBox(top: 0.8641069498977155d,right: 0.578419061535134d,bottom: 0.5570838090391695d,left: 0.054242588005672165d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8764878272333341d,right: 0.640766195592396d,bottom: 0.6080113515192833d,left: 0.06558164417586998d),
new NpgsqlTypes.NpgsqlBox(top: 0.36224025392969517d,right: 0.2454906331340403d,bottom: 0.16585699506933094d,left: 0.14061520632214553d),
new NpgsqlTypes.NpgsqlBox(top: 0.758947291724013d,right: 0.3219962349747463d,bottom: 0.4785936229942429d,left: 0.1831679206370329d),
new NpgsqlTypes.NpgsqlBox(top: 0.7499926684894939d,right: 0.6279152975679244d,bottom: 0.3025901584232029d,left: 0.5656409447355525d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6949397445838037d,right: 0.8103048905731678d,bottom: 0.45673334001810406d,left: 0.6584061931407953d),
new NpgsqlTypes.NpgsqlBox(top: 0.6908056494749143d,right: 0.9995928200760918d,bottom: 0.16452650787395284d,left: 0.27748725611045666d),
new NpgsqlTypes.NpgsqlBox(top: 0.3328603307796185d,right: 0.8015267807763475d,bottom: 0.04417595015960474d,left: 0.638776257942464d),
new NpgsqlTypes.NpgsqlBox(top: 0.7610456034954698d,right: 0.7046191416658389d,bottom: 0.18564508540050517d,left: 0.669211538235686d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7535300510246675d,right: 0.6744980949147109d,bottom: 0.17487194629810932d,left: 0.2860687906735916d),
new NpgsqlTypes.NpgsqlBox(top: 0.49203365967332036d,right: 0.5542812053006199d,bottom: 0.2375326889889685d,left: 0.17607027791338603d),
new NpgsqlTypes.NpgsqlBox(top: 0.8830440753582706d,right: 0.14916359603383922d,bottom: 0.14690742783847588d,left: 0.011728473098541192d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9331805619324403d,right: 0.9425735945009894d,bottom: 0.6993452412374525d,left: 0.569855667763214d),
new NpgsqlTypes.NpgsqlBox(top: 0.6417442893368278d,right: 0.5948918118536186d,bottom: 0.5484996043785735d,left: 0.11497142263780513d),
new NpgsqlTypes.NpgsqlBox(top: 0.6298288292914933d,right: 0.717202035212976d,bottom: 0.3671301046125819d,left: 0.3801903870104901d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9751551277544276d,right: 0.45959099378756507d,bottom: 0.009782819684474031d,left: 0.45904467613087296d),
new NpgsqlTypes.NpgsqlBox(top: 0.1864065980432137d,right: 0.2552284091094116d,bottom: 0.01363860839223252d,left: 0.22228459099300657d),
new NpgsqlTypes.NpgsqlBox(top: 0.6767822913191529d,right: 0.42859052117160945d,bottom: 0.6612234414671952d,left: 0.29528139690898947d),
new NpgsqlTypes.NpgsqlBox(top: 0.8841078125216575d,right: 0.4126130672422468d,bottom: 0.773364709529138d,left: 0.2640284423644208d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.10199968788530844d,right: 0.9032787521112171d,bottom: 0.03877540731249418d,left: 0.0009756066802715235d),
new NpgsqlTypes.NpgsqlBox(top: 0.9053818801123628d,right: 0.6208638069018159d,bottom: 0.7607260256685678d,left: 0.12483157062819406d),
new NpgsqlTypes.NpgsqlBox(top: 0.9832787364992348d,right: 0.7631368263182112d,bottom: 0.22730594616759225d,left: 0.2833066939306177d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8706891363551548d,right: 0.5592300799643023d,bottom: 0.5804919559067621d,left: 0.4183147166618407d),
new NpgsqlTypes.NpgsqlBox(top: 0.8139574440121031d,right: 0.7221312854199501d,bottom: 0.6924150258981835d,left: 0.47362748944413247d),
new NpgsqlTypes.NpgsqlBox(top: 0.5316903394518468d,right: 0.813135876037221d,bottom: 0.3302638662603151d,left: 0.31277599325767225d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3587363927445856d,right: 0.5537445463949922d,bottom: 0.3361834519784611d,left: 0.3532317843771382d),
new NpgsqlTypes.NpgsqlBox(top: 0.504509540789736d,right: 0.5331445239899532d,bottom: 0.3159153196392367d,left: 0.32389777802274855d),
new NpgsqlTypes.NpgsqlBox(top: 0.9812700105993857d,right: 0.26600714309440887d,bottom: 0.7027538605059869d,left: 0.08251357028146655d),
new NpgsqlTypes.NpgsqlBox(top: 0.5981496077301613d,right: 0.5141633848016846d,bottom: 0.5777396431750604d,left: 0.2302121984937846d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3613655176896301d,right: 0.897192250215759d,bottom: 0.05788636642597356d,left: 0.4085527235442139d),
new NpgsqlTypes.NpgsqlBox(top: 0.40393483386333195d,right: 0.4933225801425638d,bottom: 0.1424897132984817d,left: 0.29627183137745483d),
new NpgsqlTypes.NpgsqlBox(top: 0.9653747183008623d,right: 0.302200090925973d,bottom: 0.5789741844730745d,left: 0.2520867344990243d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6777862642965903d,right: 0.8898712656774206d,bottom: 0.5792993055209217d,left: 0.8664642358043658d),
new NpgsqlTypes.NpgsqlBox(top: 0.6828338752305032d,right: 0.986854953179555d,bottom: 0.41578619347070056d,left: 0.9061811523534985d),
new NpgsqlTypes.NpgsqlBox(top: 0.541894351724969d,right: 0.6862734694991105d,bottom: 0.4197672554804436d,left: 0.5001062024162736d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8456269929597312d,right: 0.5865014593165698d,bottom: 0.19185078406824074d,left: 0.08941986920668088d),
new NpgsqlTypes.NpgsqlBox(top: 0.23250472642445696d,right: 0.869931716457107d,bottom: 0.09984137470728405d,left: 0.8398496721262789d),
new NpgsqlTypes.NpgsqlBox(top: 0.40948585282823213d,right: 0.9591291817692486d,bottom: 0.1946477931067564d,left: 0.5100830994411729d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9018162018685162d,right: 0.896302381213593d,bottom: 0.7287103183105104d,left: 0.48630058056174996d),
new NpgsqlTypes.NpgsqlBox(top: 0.7746199442814921d,right: 0.6822814796960422d,bottom: 0.5467645177545429d,left: 0.4045756646114632d),
new NpgsqlTypes.NpgsqlBox(top: 0.9919821179095518d,right: 0.8843545148121719d,bottom: 0.9043394972100129d,left: 0.8307065935330744d),
new NpgsqlTypes.NpgsqlBox(top: 0.8836110876014592d,right: 0.8947347459121421d,bottom: 0.5604418705598098d,left: 0.5320753025094731d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9488300620947695d,right: 0.8463296514337938d,bottom: 0.3556880333518806d,left: 0.5422857277834416d),
new NpgsqlTypes.NpgsqlBox(top: 0.5836125019062866d,right: 0.8353386412000927d,bottom: 0.432773722321555d,left: 0.06662660834366707d),
new NpgsqlTypes.NpgsqlBox(top: 0.6405568210567449d,right: 0.5988814367690739d,bottom: 0.11269192588339805d,left: 0.4967752314688645d),
new NpgsqlTypes.NpgsqlBox(top: 0.9008846606859355d,right: 0.8537965107127877d,bottom: 0.4700064227842943d,left: 0.27972690494524655d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.36827815259406305d,right: 0.5475598438843409d,bottom: 0.06028530934363874d,left: 0.04026918303840332d),
new NpgsqlTypes.NpgsqlBox(top: 0.41781235911573467d,right: 0.7556018366528147d,bottom: 0.2548240102336383d,left: 0.001677323427098143d),
new NpgsqlTypes.NpgsqlBox(top: 0.8702592296781216d,right: 0.4585616656931546d,bottom: 0.6594606225474974d,left: 0.05913421918310058d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7853029685142264d,right: 0.1669280499766761d,bottom: 0.44492955347294516d,left: 0.07646284047440344d),
new NpgsqlTypes.NpgsqlBox(top: 0.387420204488949d,right: 0.8594274498469715d,bottom: 0.27129181319603024d,left: 0.7977482555511852d),
new NpgsqlTypes.NpgsqlBox(top: 0.6696626251750339d,right: 0.6567420651791269d,bottom: 0.29957111242331724d,left: 0.5541436553850312d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7650632930311051d,right: 0.824417410327882d,bottom: 0.3193189982647302d,left: 0.7478911070611595d),
new NpgsqlTypes.NpgsqlBox(top: 0.8481746141872063d,right: 0.4562524207667542d,bottom: 0.10202523506245342d,left: 0.29350490378212735d),
new NpgsqlTypes.NpgsqlBox(top: 0.8514055553272089d,right: 0.9680160950955832d,bottom: 0.7230492446459594d,left: 0.6217949784106945d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.784831206238839d,right: 0.5875669287330645d,bottom: 0.5289394187270117d,left: 0.26792118354978967d),
new NpgsqlTypes.NpgsqlBox(top: 0.34767545096679864d,right: 0.9095436082845174d,bottom: 0.040787543714820074d,left: 0.37131210640879186d),
new NpgsqlTypes.NpgsqlBox(top: 0.6799876648947739d,right: 0.9828017333994046d,bottom: 0.29557987026995713d,left: 0.7590955624831007d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.819154126949686d,right: 0.3016032710049802d,bottom: 0.7869190285208156d,left: 0.04470130489406876d),
new NpgsqlTypes.NpgsqlBox(top: 0.8865915222667755d,right: 0.7098458488191716d,bottom: 0.6227536741482528d,left: 0.04072165739980205d),
new NpgsqlTypes.NpgsqlBox(top: 0.5779005152273896d,right: 0.8192156646040882d,bottom: 0.37303976849386145d,left: 0.11257144631893101d),
new NpgsqlTypes.NpgsqlBox(top: 0.8380099502898969d,right: 0.4758650820062631d,bottom: 0.0973874932542409d,left: 0.2585305394641392d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3208784908302783d,right: 0.9839832015206742d,bottom: 0.2079758603289653d,left: 0.35987622033025346d),
new NpgsqlTypes.NpgsqlBox(top: 0.14436310108041883d,right: 0.6914501526817018d,bottom: 0.025084828850962748d,left: 0.5800801265685264d),
new NpgsqlTypes.NpgsqlBox(top: 0.4477055163628104d,right: 0.9907665269113203d,bottom: 0.024432664211694433d,left: 0.5392939344213585d),
new NpgsqlTypes.NpgsqlBox(top: 0.0563078032287353d,right: 0.6178630777741873d,bottom: 0.010134292888639873d,left: 0.016830304620266356d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7318339648327407d,right: 0.4760489918561067d,bottom: 0.3815231567473166d,left: 0.22169859937455982d),
new NpgsqlTypes.NpgsqlBox(top: 0.7936673355262343d,right: 0.8059698313828806d,bottom: 0.23531500587479393d,left: 0.5186507483894236d),
new NpgsqlTypes.NpgsqlBox(top: 0.5619696826644714d,right: 0.3118662795182736d,bottom: 0.30436275415929315d,left: 0.19794648839337758d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8319200681815769d,right: 0.45239605876495104d,bottom: 0.01747665408772403d,left: 0.04194633812270365d),
new NpgsqlTypes.NpgsqlBox(top: 0.8639654376245041d,right: 0.8940723752892198d,bottom: 0.862459850807148d,left: 0.44119430067146626d),
new NpgsqlTypes.NpgsqlBox(top: 0.7989859228966263d,right: 0.029019464181871846d,bottom: 0.7578681092602699d,left: 0.01522631964376897d),
new NpgsqlTypes.NpgsqlBox(top: 0.3460199229815514d,right: 0.8034647915762011d,bottom: 0.11001343074610115d,left: 0.7808865141300068d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4613043884768664d,right: 0.5143452467478508d,bottom: 0.40957031763240925d,left: 0.33131328469769794d),
new NpgsqlTypes.NpgsqlBox(top: 0.5392371203100899d,right: 0.999960404250325d,bottom: 0.15498284576312116d,left: 0.7318850805609725d),
new NpgsqlTypes.NpgsqlBox(top: 0.5003319760632802d,right: 0.7563728524621802d,bottom: 0.08653666560815843d,left: 0.1327353498508479d),
new NpgsqlTypes.NpgsqlBox(top: 0.6015271433861213d,right: 0.47290136332043753d,bottom: 0.1583836775323001d,left: 0.4533239011813185d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2235411368177589d,right: 0.29106538257953996d,bottom: 0.036075485582831135d,left: 0.21849606685938128d),
new NpgsqlTypes.NpgsqlBox(top: 0.933287226446686d,right: 0.9656108540264929d,bottom: 0.26456941249640376d,left: 0.5674134854758766d),
new NpgsqlTypes.NpgsqlBox(top: 0.7306953373612608d,right: 0.7586096276342245d,bottom: 0.27556783588829414d,left: 0.4697678262254683d),
new NpgsqlTypes.NpgsqlBox(top: 0.5111728518720796d,right: 0.8220455920439976d,bottom: 0.5095289295347146d,left: 0.5366473412518135d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4691190786612509d,right: 0.9886735513309893d,bottom: 0.2795248490465563d,left: 0.9104296807108931d),
new NpgsqlTypes.NpgsqlBox(top: 0.9991753927501993d,right: 0.5694749077198118d,bottom: 0.5419954739765389d,left: 0.08298006282399084d),
new NpgsqlTypes.NpgsqlBox(top: 0.6782049893202651d,right: 0.5823371160799801d,bottom: 0.6166010746345713d,left: 0.3874518402788252d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.797861433524063d,right: 0.8024344811295187d,bottom: 0.11207979435652538d,left: 0.21418140503646566d),
new NpgsqlTypes.NpgsqlBox(top: 0.3902088300060881d,right: 0.7636541206551697d,bottom: 0.3571270976111659d,left: 0.5382783558521218d),
new NpgsqlTypes.NpgsqlBox(top: 0.7587669404311269d,right: 0.9629023950757796d,bottom: 0.04803007417874883d,left: 0.7546622946656181d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7187805238088113d,right: 0.7796978671680665d,bottom: 0.6981476329081928d,left: 0.3427627323694188d),
new NpgsqlTypes.NpgsqlBox(top: 0.9141637379900952d,right: 0.9770772334172366d,bottom: 0.7645131480672576d,left: 0.9549470057709107d),
new NpgsqlTypes.NpgsqlBox(top: 0.4945454319453596d,right: 0.6142477136722204d,bottom: 0.07650789552126158d,left: 0.06759826001522573d),
new NpgsqlTypes.NpgsqlBox(top: 0.5409397676606401d,right: 0.6651477137699926d,bottom: 0.0322230138722458d,left: 0.3072276545307754d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9795915483754365d,right: 0.9864470182511778d,bottom: 0.5740889064714656d,left: 0.4231850792278856d),
new NpgsqlTypes.NpgsqlBox(top: 0.6381403153283841d,right: 0.8966833171760854d,bottom: 0.5377865298335842d,left: 0.5869484518182143d),
new NpgsqlTypes.NpgsqlBox(top: 0.5234070216129453d,right: 0.8544193790224308d,bottom: 0.3528658219632962d,left: 0.3271702285358614d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9808431692520905d,right: 0.9001479876605298d,bottom: 0.15515649889091943d,left: 0.48163554642560225d),
new NpgsqlTypes.NpgsqlBox(top: 0.7710038771291473d,right: 0.7324739977743803d,bottom: 0.6334933304426383d,left: 0.11383884752572204d),
new NpgsqlTypes.NpgsqlBox(top: 0.8561986648251008d,right: 0.7985384045382745d,bottom: 0.0006590402263472184d,left: 0.11195782606706017d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.622914145235288d,right: 0.24309368702760792d,bottom: 0.3009630243916833d,left: 0.197896095005897d),
new NpgsqlTypes.NpgsqlBox(top: 0.7652079018444164d,right: 0.39411533276630284d,bottom: 0.6151910028479887d,left: 0.06071679232885552d),
new NpgsqlTypes.NpgsqlBox(top: 0.917831701157534d,right: 0.4224842955106395d,bottom: 0.2708915381966821d,left: 0.04872457620544801d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8488845438279757d,right: 0.7840394157307394d,bottom: 0.21294091887040223d,left: 0.37402697707346133d),
new NpgsqlTypes.NpgsqlBox(top: 0.47466154616279843d,right: 0.9525369099147424d,bottom: 0.43873393377115233d,left: 0.37597143470196903d),
new NpgsqlTypes.NpgsqlBox(top: 0.6678865669287409d,right: 0.5232820918408674d,bottom: 0.07566567757420861d,left: 0.21501887611030512d),
new NpgsqlTypes.NpgsqlBox(top: 0.7946137149688951d,right: 0.7763501036757897d,bottom: 0.21364847082625993d,left: 0.13571737720453902d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6996498229001565d,right: 0.5277261113108366d,bottom: 0.6814078697894453d,left: 0.06824731338357859d),
new NpgsqlTypes.NpgsqlBox(top: 0.6678618403980681d,right: 0.8900596275074251d,bottom: 0.34502350764000744d,left: 0.861522217280995d),
new NpgsqlTypes.NpgsqlBox(top: 0.6889810044032575d,right: 0.9143771948878037d,bottom: 0.14302028720194215d,left: 0.39931504903426795d),
new NpgsqlTypes.NpgsqlBox(top: 0.9241794742866231d,right: 0.5663361668065674d,bottom: 0.7895843138488778d,left: 0.42018616260842634d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9465598787731971d,right: 0.8631110658706553d,bottom: 0.2937690893710754d,left: 0.8437510359419984d),
new NpgsqlTypes.NpgsqlBox(top: 0.6760646373979301d,right: 0.46497745772357146d,bottom: 0.03740294927376109d,left: 0.38249556915133165d),
new NpgsqlTypes.NpgsqlBox(top: 0.7272986460493497d,right: 0.8880607510662113d,bottom: 0.5765098361974695d,left: 0.67231740663773d),
new NpgsqlTypes.NpgsqlBox(top: 0.9764035019613533d,right: 0.8306390068052995d,bottom: 0.7145139405248314d,left: 0.7873589258626372d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5613624285842683d,right: 0.7345866890955314d,bottom: 0.49676516949435756d,left: 0.17572502846134186d),
new NpgsqlTypes.NpgsqlBox(top: 0.9575042858654229d,right: 0.8814899365814812d,bottom: 0.8123493453774796d,left: 0.3714441422340782d),
new NpgsqlTypes.NpgsqlBox(top: 0.6738065541662656d,right: 0.9954274146471187d,bottom: 0.14317701331854094d,left: 0.9267334809555349d),
new NpgsqlTypes.NpgsqlBox(top: 0.7849991658191742d,right: 0.9717036485054557d,bottom: 0.6841696551586686d,left: 0.9274740779142111d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9099104919113371d,right: 0.41042061361525195d,bottom: 0.4702902471055954d,left: 0.1428669221045883d),
new NpgsqlTypes.NpgsqlBox(top: 0.8247284263436919d,right: 0.5487201804908706d,bottom: 0.6455897035943023d,left: 0.1406644700227624d),
new NpgsqlTypes.NpgsqlBox(top: 0.8275339522105676d,right: 0.9736123366922697d,bottom: 0.5896882128208191d,left: 0.11506733962009308d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6888815390925216d,right: 0.24626172827169734d,bottom: 0.21199916408245134d,left: 0.1322003694005729d),
new NpgsqlTypes.NpgsqlBox(top: 0.39024363831914866d,right: 0.8490585425331731d,bottom: 0.21775942041835883d,left: 0.28285903040722016d),
new NpgsqlTypes.NpgsqlBox(top: 0.5089113844846294d,right: 0.9418408669956999d,bottom: 0.16203968408960767d,left: 0.6925801695458512d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6865558135467562d,right: 0.5569599002248264d,bottom: 0.2078081064267996d,left: 0.1080993776590613d),
new NpgsqlTypes.NpgsqlBox(top: 0.44616407586464046d,right: 0.7709562089890978d,bottom: 0.4283702132708458d,left: 0.3700150118176295d),
new NpgsqlTypes.NpgsqlBox(top: 0.8004367846677729d,right: 0.8072206070302381d,bottom: 0.6884197174460154d,left: 0.2321586653531872d),
new NpgsqlTypes.NpgsqlBox(top: 0.809122878778521d,right: 0.8892572565708255d,bottom: 0.8079819566323989d,left: 0.238260180378558d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8307096020442223d,right: 0.6234173056330252d,bottom: 0.5999478413731977d,left: 0.10378732447881456d),
new NpgsqlTypes.NpgsqlBox(top: 0.3945209764214457d,right: 0.8552940510132249d,bottom: 0.12790259616269706d,left: 0.24600416972644135d),
new NpgsqlTypes.NpgsqlBox(top: 0.9691604918044788d,right: 0.37483273047314813d,bottom: 0.20353477265957587d,left: 0.08948711559981071d),
new NpgsqlTypes.NpgsqlBox(top: 0.9773503426140868d,right: 0.6016196270088406d,bottom: 0.26803324516536153d,left: 0.0233855327121526d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.22526831217683208d,right: 0.9654098724081035d,bottom: 0.10575905977974509d,left: 0.9167589389844173d),
new NpgsqlTypes.NpgsqlBox(top: 0.6401918461235756d,right: 0.5804020595627429d,bottom: 0.5893116547056875d,left: 0.461762269825738d),
new NpgsqlTypes.NpgsqlBox(top: 0.9764411191812035d,right: 0.8806722625665845d,bottom: 0.4131213206982526d,left: 0.4903062733680451d),
new NpgsqlTypes.NpgsqlBox(top: 0.4733052730338152d,right: 0.8831606715734142d,bottom: 0.3152834792149778d,left: 0.5798157933459721d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6185595790020326d,right: 0.434746590040217d,bottom: 0.33001388136190724d,left: 0.13936269939077006d),
new NpgsqlTypes.NpgsqlBox(top: 0.48169154676649184d,right: 0.8980903133243451d,bottom: 0.07077335341212376d,left: 0.06020654594195929d),
new NpgsqlTypes.NpgsqlBox(top: 0.8486902327965545d,right: 0.35101977345004776d,bottom: 0.05184125543352258d,left: 0.15179473140699995d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9576883480424716d,right: 0.5451533756194229d,bottom: 0.006339863422011871d,left: 0.45461896913046274d),
new NpgsqlTypes.NpgsqlBox(top: 0.44673088381081305d,right: 0.338422011990678d,bottom: 0.25584944445575564d,left: 0.25004740342239373d),
new NpgsqlTypes.NpgsqlBox(top: 0.4589106513039024d,right: 0.38735977802783617d,bottom: 0.17012065420327394d,left: 0.09512039800288141d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.25456170440570813d,right: 0.8793815453959667d,bottom: 0.06605852366872511d,left: 0.5022204605026719d),
new NpgsqlTypes.NpgsqlBox(top: 0.2506398725407325d,right: 0.5377325295356116d,bottom: 0.11574678805475036d,left: 0.40051794916293804d),
new NpgsqlTypes.NpgsqlBox(top: 0.290908556941737d,right: 0.9323872644783084d,bottom: 0.046082944265213976d,left: 0.8804451042890952d),
new NpgsqlTypes.NpgsqlBox(top: 0.5499286251648463d,right: 0.6582765489986093d,bottom: 0.516491214689138d,left: 0.5214102621359178d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8626971073592234d,right: 0.906058899312306d,bottom: 0.199571210455618d,left: 0.05564307000453961d),
new NpgsqlTypes.NpgsqlBox(top: 0.9496242192873569d,right: 0.9515837370814922d,bottom: 0.594849682186263d,left: 0.8603597559514116d),
new NpgsqlTypes.NpgsqlBox(top: 0.6146198319359887d,right: 0.9713737691342594d,bottom: 0.17478378630956115d,left: 0.9389394251429545d),
new NpgsqlTypes.NpgsqlBox(top: 0.7877059378820236d,right: 0.676659431632157d,bottom: 0.46048036858769437d,left: 0.4951595103609475d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.18177553807801028d,right: 0.9582064107553565d,bottom: 0.1509275222130274d,left: 0.30346910927963855d),
new NpgsqlTypes.NpgsqlBox(top: 0.9206962320092816d,right: 0.2741572640985579d,bottom: 0.6492936665345392d,left: 0.14757539381768148d),
new NpgsqlTypes.NpgsqlBox(top: 0.27222789290661553d,right: 0.8059930165172112d,bottom: 0.15764792958483997d,left: 0.6449173627182141d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3999723390427944d,right: 0.6043663214165463d,bottom: 0.31979731205845907d,left: 0.49241631376318373d),
new NpgsqlTypes.NpgsqlBox(top: 0.21909016001609605d,right: 0.8124361462204257d,bottom: 0.010584632017313744d,left: 0.6009920491900793d),
new NpgsqlTypes.NpgsqlBox(top: 0.4542648772034861d,right: 0.8492892053250208d,bottom: 0.12443560406080012d,left: 0.7488734326869461d),
new NpgsqlTypes.NpgsqlBox(top: 0.6583191122655058d,right: 0.8792557950276356d,bottom: 0.237680279393354d,left: 0.02746878998233293d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.234862559653102d,right: 0.6276536369864663d,bottom: 0.22944896619551214d,left: 0.5132340577701553d),
new NpgsqlTypes.NpgsqlBox(top: 0.5566830814752736d,right: 0.9086295126410575d,bottom: 0.4691903138036453d,left: 0.899512563924042d),
new NpgsqlTypes.NpgsqlBox(top: 0.8057656276276368d,right: 0.7019652175842812d,bottom: 0.3160372252334852d,left: 0.44629856431268844d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6577301316388731d,right: 0.6168127049964346d,bottom: 0.03242179571418036d,left: 0.46840711132395685d),
new NpgsqlTypes.NpgsqlBox(top: 0.4106673029280735d,right: 0.8842111257120217d,bottom: 0.2946971811535627d,left: 0.451395539566268d),
new NpgsqlTypes.NpgsqlBox(top: 0.38690223244628164d,right: 0.996189019072118d,bottom: 0.254585179243377d,left: 0.6815985782672841d),
new NpgsqlTypes.NpgsqlBox(top: 0.9503338729051747d,right: 0.7280589048029839d,bottom: 0.32000212172497566d,left: 0.007983653745618713d),
},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1mi(
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
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

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.40043508945763684d,right: 0.4836371869015125d,bottom: 0.08090556702015783d,left: 0.3603952141581199d),
new NpgsqlTypes.NpgsqlBox(top: 0.7464419624704145d,right: 0.5442016840203369d,bottom: 0.7081456394082686d,left: 0.14761851214113153d),
new NpgsqlTypes.NpgsqlBox(top: 0.8892733659249454d,right: 0.738190371063497d,bottom: 0.5643473218573885d,left: 0.016218139475112636d),
new NpgsqlTypes.NpgsqlBox(top: 0.9950861491168456d,right: 0.43406499041325397d,bottom: 0.6673071540229705d,left: 0.2883856492285525d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9522094888701113d,right: 0.5975636400049423d,bottom: 0.23281275716726313d,left: 0.5865469746532698d),
new NpgsqlTypes.NpgsqlBox(top: 0.30867670634009714d,right: 0.9070811432712986d,bottom: 0.19974112261611277d,left: 0.7178200307279701d),
new NpgsqlTypes.NpgsqlBox(top: 0.9955126818064947d,right: 0.4372378201030963d,bottom: 0.8332032373346447d,left: 0.3458193013316049d),
}));
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[29], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 69;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[29], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[29], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 67, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 13, query1, 53, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 97, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 18, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 107, query1, 32, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 83, query1, 50, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 79, query1, 79, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 67, query1, 107, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 91, 47))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[29], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatch(connection, 50, 39))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[29], false);
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
                await using var cmd = await ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 91);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 97);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlBoxArrayboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlBoxArrayboxArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
FROM public.binary_npgsqlboxboxarray1m m
LEFT JOIN public.binary_npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray1M>(15);

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
                ((INpgsqlBoxArrayboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlBoxArrayboxArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxArrayboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxArrayboxArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

