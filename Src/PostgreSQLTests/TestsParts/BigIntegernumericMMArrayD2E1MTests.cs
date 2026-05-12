

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
    internal partial interface IBigIntegerMArraynumericMMArrayD2
    {
    }
    
    internal partial class BigIntegerMArraynumericMMArrayD2 : IBigIntegerMArraynumericMMArrayD2
    {


#region TestData

        private readonly BigIntegernumericMMArrayD2E1M[] _testData = new BigIntegernumericMMArrayD2E1M[]
        {
            new BigIntegernumericMMArrayD2E1M
{
    Id = 8,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2321880236960195145L), new System.Numerics.BigInteger(2543650951533335424L), }, { new System.Numerics.BigInteger(1066039983952907618L), new System.Numerics.BigInteger(2983305653123834748L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 10,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3696244006258570224L), new System.Numerics.BigInteger(5349064941947775223L), }, { new System.Numerics.BigInteger(7251649499132545057L), new System.Numerics.BigInteger(2430152579466179781L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 7,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4709928172617802828L), new System.Numerics.BigInteger(3377302168573176664L), }, { new System.Numerics.BigInteger(8770487466267839372L), new System.Numerics.BigInteger(6004265558266308855L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(585628303136723163L), new System.Numerics.BigInteger(1261720631318115031L), }, { new System.Numerics.BigInteger(627816939425040632L), new System.Numerics.BigInteger(4510393141987472148L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8091134692468179315L), new System.Numerics.BigInteger(7958672080323107793L), }, { new System.Numerics.BigInteger(276413440906587811L), new System.Numerics.BigInteger(1176826300535863289L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 12,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4334158577456279348L), new System.Numerics.BigInteger(5230409139514063064L), }, { new System.Numerics.BigInteger(7408968500966357727L), new System.Numerics.BigInteger(5186850051573433623L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3081798496033550513L), new System.Numerics.BigInteger(3997296261344195470L), }, { new System.Numerics.BigInteger(7774942683111235811L), new System.Numerics.BigInteger(7798685162688663752L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 13,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1449024271602118826L), new System.Numerics.BigInteger(1991554369236202318L), }, { new System.Numerics.BigInteger(661448621848420098L), new System.Numerics.BigInteger(3783095956646224459L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 15,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2699346356555283902L), new System.Numerics.BigInteger(8496972748266337528L), }, { new System.Numerics.BigInteger(5912318925528176637L), new System.Numerics.BigInteger(2578099200216993686L), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6765552309696875676L), new System.Numerics.BigInteger(5569135468684848843L), }, { new System.Numerics.BigInteger(6063052831611346922L), new System.Numerics.BigInteger(3194510682860604006L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 16,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(946874410097894443L), new System.Numerics.BigInteger(6370975486923309543L), }, { new System.Numerics.BigInteger(5950987007249787614L), new System.Numerics.BigInteger(2727998734487207741L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 22,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6788579658465554172L), new System.Numerics.BigInteger(323000948981697785L), }, { new System.Numerics.BigInteger(7619193195677353212L), new System.Numerics.BigInteger(6421146669022491823L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 16,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5360007788141788974L), new System.Numerics.BigInteger(8914996079323579962L), }, { new System.Numerics.BigInteger(6861570440271468484L), new System.Numerics.BigInteger(5686209896618564650L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6490967065550844961L), new System.Numerics.BigInteger(3808355611999970837L), }, { new System.Numerics.BigInteger(5826943684723765008L), new System.Numerics.BigInteger(6852606207359026062L), }, },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 23,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6886042481332787557L), new System.Numerics.BigInteger(4712792091057515555L), }, { new System.Numerics.BigInteger(8734947477863057400L), new System.Numerics.BigInteger(8970079396316983203L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4518649171012138962L), new System.Numerics.BigInteger(2130188241087407959L), }, { new System.Numerics.BigInteger(8463578722419688724L), new System.Numerics.BigInteger(2269514033905676515L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 28,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3116797953710679795L), new System.Numerics.BigInteger(7672042494225024574L), }, { new System.Numerics.BigInteger(3314220089452761580L), new System.Numerics.BigInteger(5852952419573091819L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 19,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3193729338348518200L), new System.Numerics.BigInteger(1898675932205170328L), }, { new System.Numerics.BigInteger(5542566252100427911L), new System.Numerics.BigInteger(2652540002168009951L), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7148995767356720911L), new System.Numerics.BigInteger(26741927078715647L), }, { new System.Numerics.BigInteger(4398991372827136210L), new System.Numerics.BigInteger(8681607481764896684L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 35,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8683719099267652049L), new System.Numerics.BigInteger(3661964072198247480L), }, { new System.Numerics.BigInteger(4500875098030456254L), new System.Numerics.BigInteger(5761173618545503213L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7097771242156623889L), new System.Numerics.BigInteger(4180762718393501841L), }, { new System.Numerics.BigInteger(3790251226457597036L), new System.Numerics.BigInteger(6928423167089440790L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 43,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(701337401224609696L), new System.Numerics.BigInteger(2196623657280753760L), }, { new System.Numerics.BigInteger(3881626427041444923L), new System.Numerics.BigInteger(742573421066654231L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 26,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1300984032974548274L), new System.Numerics.BigInteger(597960036236472642L), }, { new System.Numerics.BigInteger(8502530304808510755L), new System.Numerics.BigInteger(5327523481279794851L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8241381945063124789L), new System.Numerics.BigInteger(8843658552052252317L), }, { new System.Numerics.BigInteger(6937762497583474334L), new System.Numerics.BigInteger(4724672243591312377L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1336112112869849390L), new System.Numerics.BigInteger(1323281322077353434L), }, { new System.Numerics.BigInteger(6974727929095980504L), new System.Numerics.BigInteger(5684911279558242395L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 51,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5736979926926113577L), new System.Numerics.BigInteger(8728345397044831426L), }, { new System.Numerics.BigInteger(3102271603835150806L), new System.Numerics.BigInteger(4182598870424739250L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 55,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7727984298589975597L), new System.Numerics.BigInteger(8356151653184442029L), }, { new System.Numerics.BigInteger(2199437459396922446L), new System.Numerics.BigInteger(6530142099651081224L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 30,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1028646772700901788L), new System.Numerics.BigInteger(2368019815139178682L), }, { new System.Numerics.BigInteger(721410285719555515L), new System.Numerics.BigInteger(1071583801973227362L), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 63,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8234678694028807332L), new System.Numerics.BigInteger(1793120830671699763L), }, { new System.Numerics.BigInteger(8029888401397469826L), new System.Numerics.BigInteger(5304025416773466751L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1695127586943613322L), new System.Numerics.BigInteger(5703043646908335575L), }, { new System.Numerics.BigInteger(6330248479371268085L), new System.Numerics.BigInteger(5239820081870618705L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 69,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2723483214607309629L), new System.Numerics.BigInteger(6331306874526165612L), }, { new System.Numerics.BigInteger(768766248289946035L), new System.Numerics.BigInteger(8843214846931174195L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 32,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6920185157385535375L), new System.Numerics.BigInteger(3332438812362893203L), }, { new System.Numerics.BigInteger(195250153871366625L), new System.Numerics.BigInteger(9047576682648390970L), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(14544562940225720L), new System.Numerics.BigInteger(5301387881278044252L), }, { new System.Numerics.BigInteger(3238173888346302289L), new System.Numerics.BigInteger(487765675729042508L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 77,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6700020909638620541L), new System.Numerics.BigInteger(7377492679401819597L), }, { new System.Numerics.BigInteger(4687108531277425147L), new System.Numerics.BigInteger(7728901395425831734L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2228480046069435367L), new System.Numerics.BigInteger(5386518033873428234L), }, { new System.Numerics.BigInteger(907425968070262317L), new System.Numerics.BigInteger(1130848841272790672L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 83,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2276698283523593071L), new System.Numerics.BigInteger(1261464260849714432L), }, { new System.Numerics.BigInteger(5466745696125490440L), new System.Numerics.BigInteger(3078997303923823524L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 34,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(59146473903977253L), new System.Numerics.BigInteger(2907097058041322433L), }, { new System.Numerics.BigInteger(6976617772787775633L), new System.Numerics.BigInteger(2562677754580687585L), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 89,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4309831541319024525L), new System.Numerics.BigInteger(8366138867665612971L), }, { new System.Numerics.BigInteger(1801623599055601251L), new System.Numerics.BigInteger(8518996722276877638L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3391612685293343781L), new System.Numerics.BigInteger(8212843923190158021L), }, { new System.Numerics.BigInteger(5574087642617778448L), new System.Numerics.BigInteger(8315837083206490123L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 96,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6469035840853107077L), new System.Numerics.BigInteger(8997826032383426725L), }, { new System.Numerics.BigInteger(668909850031826784L), new System.Numerics.BigInteger(3878433077839880470L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 41,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6178314046814411212L), new System.Numerics.BigInteger(5482013939626559064L), }, { new System.Numerics.BigInteger(3403129858850200430L), new System.Numerics.BigInteger(3216728576763819448L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6327473854461715374L), new System.Numerics.BigInteger(4727922276419326343L), }, { new System.Numerics.BigInteger(7425605064601951592L), new System.Numerics.BigInteger(6953151953106643356L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1022257714563973205L), new System.Numerics.BigInteger(7789717368976403439L), }, { new System.Numerics.BigInteger(5651433201027278112L), new System.Numerics.BigInteger(5408754567115326303L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 100,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5112066520653581772L), new System.Numerics.BigInteger(1021116076803091915L), }, { new System.Numerics.BigInteger(1193893165320990594L), new System.Numerics.BigInteger(3021483029351588499L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 103,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4060793542589121089L), new System.Numerics.BigInteger(5866116418466604043L), }, { new System.Numerics.BigInteger(587970917680149254L), new System.Numerics.BigInteger(2896200660130548149L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 47,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(9001848850032498385L), new System.Numerics.BigInteger(5261630616222909069L), }, { new System.Numerics.BigInteger(1326109087308234746L), new System.Numerics.BigInteger(6847974574917991286L), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2338299488134785736L), new System.Numerics.BigInteger(4290566077064289749L), }, { new System.Numerics.BigInteger(2099068190282896201L), new System.Numerics.BigInteger(3370939381209394576L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 105,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3815778360143653428L), new System.Numerics.BigInteger(1524866849290821649L), }, { new System.Numerics.BigInteger(6990294501332613328L), new System.Numerics.BigInteger(5389499564461061868L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 108,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6631145550790706859L), new System.Numerics.BigInteger(8125703420778183213L), }, { new System.Numerics.BigInteger(5377122466261957558L), new System.Numerics.BigInteger(2278086861546907451L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 54,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1401240311189128317L), new System.Numerics.BigInteger(2164479637011493622L), }, { new System.Numerics.BigInteger(6879898335128801981L), new System.Numerics.BigInteger(5123125720537389438L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3934195286258880601L), new System.Numerics.BigInteger(8630859268637961290L), }, { new System.Numerics.BigInteger(1001801973971464018L), new System.Numerics.BigInteger(5088294520983222824L), }, },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 117,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6920442367658229561L), new System.Numerics.BigInteger(6201701542747988838L), }, { new System.Numerics.BigInteger(8525696891934779648L), new System.Numerics.BigInteger(5210857347968607554L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2569039001879705347L), new System.Numerics.BigInteger(8470372979363779654L), }, { new System.Numerics.BigInteger(2248891017669126007L), new System.Numerics.BigInteger(8355383783400404511L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 125,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2596275139294720493L), new System.Numerics.BigInteger(2058341001122943526L), }, { new System.Numerics.BigInteger(1762922238647756453L), new System.Numerics.BigInteger(2253480415061843726L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 63,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(708282069768617885L), new System.Numerics.BigInteger(7360839929510472197L), }, { new System.Numerics.BigInteger(1452463621327561927L), new System.Numerics.BigInteger(2263202133538211871L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3004023892598369159L), new System.Numerics.BigInteger(3028837166952981760L), }, { new System.Numerics.BigInteger(2915145029346652608L), new System.Numerics.BigInteger(1365885205358153158L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2636254989622953012L), new System.Numerics.BigInteger(445557739578569236L), }, { new System.Numerics.BigInteger(665252567302335850L), new System.Numerics.BigInteger(683096376249630364L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 126,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4542632618203894470L), new System.Numerics.BigInteger(1809274436310737207L), }, { new System.Numerics.BigInteger(1834865819351351659L), new System.Numerics.BigInteger(336567184938820156L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6562802696674404015L), new System.Numerics.BigInteger(3495862903595637351L), }, { new System.Numerics.BigInteger(158846169592209160L), new System.Numerics.BigInteger(3513243340232495560L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 132,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3705342917193387071L), new System.Numerics.BigInteger(4203308371042269895L), }, { new System.Numerics.BigInteger(7202215254346351336L), new System.Numerics.BigInteger(5996404792409634837L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 64,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5958347563988774664L), new System.Numerics.BigInteger(5464287115004299905L), }, { new System.Numerics.BigInteger(1160715022843393542L), new System.Numerics.BigInteger(5049402157260240554L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1588880164134207700L), new System.Numerics.BigInteger(6371381741415779711L), }, { new System.Numerics.BigInteger(1358310138536169132L), new System.Numerics.BigInteger(2529734166999487016L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(84931188398240937L), new System.Numerics.BigInteger(4094033765544094130L), }, { new System.Numerics.BigInteger(5503900161726818680L), new System.Numerics.BigInteger(115355894027950414L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 139,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2443683666042869075L), new System.Numerics.BigInteger(3838562689009446373L), }, { new System.Numerics.BigInteger(3643354320747998212L), new System.Numerics.BigInteger(720167343153737102L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8765297738440660529L), new System.Numerics.BigInteger(3758692066122858354L), }, { new System.Numerics.BigInteger(733798877390998900L), new System.Numerics.BigInteger(6061362690441962902L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 142,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8659834124906002326L), new System.Numerics.BigInteger(1565718005208762187L), }, { new System.Numerics.BigInteger(7637715574397456648L), new System.Numerics.BigInteger(158643207552798738L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 65,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1297969528753716791L), new System.Numerics.BigInteger(1443951556982498953L), }, { new System.Numerics.BigInteger(4525714509453673570L), new System.Numerics.BigInteger(6316803522544788888L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7306104519589076678L), new System.Numerics.BigInteger(8195898143111704877L), }, { new System.Numerics.BigInteger(1045059681217165695L), new System.Numerics.BigInteger(1948411570720379950L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8021445878653599504L), new System.Numerics.BigInteger(1928808032882252411L), }, { new System.Numerics.BigInteger(1731397759301597931L), new System.Numerics.BigInteger(3613769765692191743L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 150,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(915207402386696553L), new System.Numerics.BigInteger(5684908934686922919L), }, { new System.Numerics.BigInteger(4704364654287571405L), new System.Numerics.BigInteger(5502802560149694187L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 153,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6833508014815275070L), new System.Numerics.BigInteger(5359770908095775326L), }, { new System.Numerics.BigInteger(7536762691629154924L), new System.Numerics.BigInteger(1801911293350181817L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 68,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2835665366785125733L), new System.Numerics.BigInteger(4102748378253510311L), }, { new System.Numerics.BigInteger(5321558737134926964L), new System.Numerics.BigInteger(1448442364862647551L), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(9168730784332365870L), new System.Numerics.BigInteger(1092286896574420572L), }, { new System.Numerics.BigInteger(1457585358754692435L), new System.Numerics.BigInteger(1901103239259124164L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 159,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1327097133099720009L), new System.Numerics.BigInteger(6441687896383399088L), }, { new System.Numerics.BigInteger(466622832348878336L), new System.Numerics.BigInteger(2922720933384303869L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4459932993862755644L), new System.Numerics.BigInteger(4064356667438463086L), }, { new System.Numerics.BigInteger(8401483905401110495L), new System.Numerics.BigInteger(153795213983620679L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 161,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6355334820052396420L), new System.Numerics.BigInteger(6529147550337247638L), }, { new System.Numerics.BigInteger(4897560975143861698L), new System.Numerics.BigInteger(2035645574347540115L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 73,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2547817442954657216L), new System.Numerics.BigInteger(5925134882916273911L), }, { new System.Numerics.BigInteger(2671292055625384996L), new System.Numerics.BigInteger(3383125452536785114L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3532747148597259350L), new System.Numerics.BigInteger(7306302458071328812L), }, { new System.Numerics.BigInteger(8680698549107231159L), new System.Numerics.BigInteger(5619463692426114359L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2027077504069464161L), new System.Numerics.BigInteger(2906377651750525314L), }, { new System.Numerics.BigInteger(1009603355068175961L), new System.Numerics.BigInteger(5362593708705695916L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 170,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1788916800295264594L), new System.Numerics.BigInteger(4077076180665288224L), }, { new System.Numerics.BigInteger(3015457657276157097L), new System.Numerics.BigInteger(3129986110306015956L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6153165771876863565L), new System.Numerics.BigInteger(162425618838683044L), }, { new System.Numerics.BigInteger(9078032365342059120L), new System.Numerics.BigInteger(8866873190104366549L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 177,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2737585906420454599L), new System.Numerics.BigInteger(7557751624588600054L), }, { new System.Numerics.BigInteger(3505609892855305950L), new System.Numerics.BigInteger(6853543231758536078L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 80,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(278844474901810620L), new System.Numerics.BigInteger(546152599340199012L), }, { new System.Numerics.BigInteger(7979721957003201590L), new System.Numerics.BigInteger(386120878109822689L), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2510728717202800484L), new System.Numerics.BigInteger(3051608337700732047L), }, { new System.Numerics.BigInteger(3317751651541525967L), new System.Numerics.BigInteger(3195914503369542487L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 186,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8238356180199669756L), new System.Numerics.BigInteger(6497289361075099110L), }, { new System.Numerics.BigInteger(6995765498470888209L), new System.Numerics.BigInteger(8674219969868963138L), }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd2e1mi(
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd2e1mi(
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
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
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

                changedRows =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd2e1mi_id
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericmmarrayd2e1mi_id", 
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
                changedRows =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd2e1mi_id
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
    bigintegernumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd2e1mi_id
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
    bigintegernumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericmmarrayd2e1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericMMArrayD2E1M> models = null;

                models =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericMMArrayD2E1M> models = null;

                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M), typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
LEFT JOIN public.bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M), typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
LEFT JOIN public.bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M), typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 132;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 142;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 96;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 170;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
LEFT JOIN public.bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M), typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 96, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 96, query1, 69, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 142, query1, 108, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 10, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 89, query1, 77, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 103, query1, 100, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 8, query1, 100, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 126, query1, 8, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
LEFT JOIN public.bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 103, 55))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 12, 117))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerMArraynumericMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerMArraynumericMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 139);
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerMArraynumericMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerMArraynumericMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 125);
                var models =  ((IBigIntegerMArraynumericMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
FROM public.binary_bigintegernumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
FROM public.binary_bigintegernumericmmarrayd2e1m m
LEFT JOIN public.binary_bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models =  ((IBigIntegerMArraynumericMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA), typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
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
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
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
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA), typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
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
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
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
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MI), typeof(BigIntegernumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MI>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MI>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MI>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MI>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA), typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

