

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
    internal partial interface IBigIntegerMArraynumericMMArrayD1
    {
    }
    
    internal partial class BigIntegerMArraynumericMMArrayD1 : IBigIntegerMArraynumericMMArrayD1
    {


#region TestData

        private readonly BigIntegernumericMMArrayD1E1M[] _testData = new BigIntegernumericMMArrayD1E1M[]
        {
            new BigIntegernumericMMArrayD1E1M
{
    Id = 1,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4423688313893299770L),
new System.Numerics.BigInteger(8731788363454087351L),
new System.Numerics.BigInteger(1100870180614713798L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6378561080562891355L),
new System.Numerics.BigInteger(1272379700074452432L),
new System.Numerics.BigInteger(5195480150376040532L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 2,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3817422971633118200L),
new System.Numerics.BigInteger(3822271423990546796L),
new System.Numerics.BigInteger(2133228846231913912L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 8,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3709294204943131350L),
new System.Numerics.BigInteger(3099041376127162287L),
new System.Numerics.BigInteger(7106157631592098920L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5539566584572850648L),
new System.Numerics.BigInteger(4797503379816841301L),
new System.Numerics.BigInteger(8645947133453618490L),
new System.Numerics.BigInteger(4211411273532014636L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1145660015452394563L),
new System.Numerics.BigInteger(4928375556581713486L),
new System.Numerics.BigInteger(2404106940330495621L),
new System.Numerics.BigInteger(2802517250790349771L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 4,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1159733543519360891L),
new System.Numerics.BigInteger(1183212624298791247L),
new System.Numerics.BigInteger(2617567114435695079L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 8,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4777224494594634022L),
new System.Numerics.BigInteger(3326289656778612375L),
new System.Numerics.BigInteger(739657698324817578L),
new System.Numerics.BigInteger(4430700367356789439L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 17,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3953862552487463016L),
new System.Numerics.BigInteger(2382745494059511040L),
new System.Numerics.BigInteger(3585409968128153846L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(533760809677813853L),
new System.Numerics.BigInteger(3636615600092067867L),
new System.Numerics.BigInteger(1811553206788112460L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5697853608083045115L),
new System.Numerics.BigInteger(2230599190342123456L),
new System.Numerics.BigInteger(7993104340548066922L),
new System.Numerics.BigInteger(5485071632248719707L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 9,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8428390578725511564L),
new System.Numerics.BigInteger(153731653276994283L),
new System.Numerics.BigInteger(639952446329023829L),
new System.Numerics.BigInteger(7414956984516003930L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 15,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1856025367158076728L),
new System.Numerics.BigInteger(5479196208183153336L),
new System.Numerics.BigInteger(1032320233845239861L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 25,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5458046679094010190L),
new System.Numerics.BigInteger(3716544376819900677L),
new System.Numerics.BigInteger(65402259078195093L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1106998160052451777L),
new System.Numerics.BigInteger(880503781470217823L),
new System.Numerics.BigInteger(6740641274829957338L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(358481686766542046L),
new System.Numerics.BigInteger(8213680282736405960L),
new System.Numerics.BigInteger(1210593977214406514L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 23,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(137213306275236627L),
new System.Numerics.BigInteger(6009130250631175207L),
new System.Numerics.BigInteger(7676088329249926414L),
new System.Numerics.BigInteger(1223766253260392829L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 31,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5386469076365812263L),
new System.Numerics.BigInteger(1454506959420520275L),
new System.Numerics.BigInteger(3242083270232919008L),
new System.Numerics.BigInteger(4761667383256932648L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 31,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8988915766486679423L),
new System.Numerics.BigInteger(1976997163182540613L),
new System.Numerics.BigInteger(2191978164775687278L),
new System.Numerics.BigInteger(2355631079716240323L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8053426768869388805L),
new System.Numerics.BigInteger(9154012929003729434L),
new System.Numerics.BigInteger(3778443640248910181L),
new System.Numerics.BigInteger(7293808224172596942L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 32,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8111491951846246897L),
new System.Numerics.BigInteger(8090491720955442032L),
new System.Numerics.BigInteger(6908090625786765990L),
new System.Numerics.BigInteger(9189684630610595278L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5209730556106380045L),
new System.Numerics.BigInteger(6412405489876140991L),
new System.Numerics.BigInteger(8705473732249168146L),
new System.Numerics.BigInteger(7667423016615417118L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 38,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6144365461221469165L),
new System.Numerics.BigInteger(40662738212611944L),
new System.Numerics.BigInteger(8802425083061679546L),
new System.Numerics.BigInteger(2600789478568123717L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7133354445807873759L),
new System.Numerics.BigInteger(863635999844987750L),
new System.Numerics.BigInteger(6832365306787778395L),
new System.Numerics.BigInteger(1916228758339795138L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(416865885869041852L),
new System.Numerics.BigInteger(2449944490556938649L),
new System.Numerics.BigInteger(4145510781817158820L),
new System.Numerics.BigInteger(403014583768708296L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5679107787959528848L),
new System.Numerics.BigInteger(2437834409089708526L),
new System.Numerics.BigInteger(8116548698705123789L),
new System.Numerics.BigInteger(5133188231123734945L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 40,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3433987830378705365L),
new System.Numerics.BigInteger(4650791603068107096L),
new System.Numerics.BigInteger(7694037954149898252L),
new System.Numerics.BigInteger(5641736804128422204L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 46,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7661852613447329023L),
new System.Numerics.BigInteger(1830099033829913089L),
new System.Numerics.BigInteger(6366465535045927078L),
new System.Numerics.BigInteger(2979565986794189234L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 43,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3671665682891140264L),
new System.Numerics.BigInteger(3874855281580386481L),
new System.Numerics.BigInteger(3663365214497141223L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7118249964173371559L),
new System.Numerics.BigInteger(1935531546668428897L),
new System.Numerics.BigInteger(1366543762275112500L),
},
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 55,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6571858093356024046L),
new System.Numerics.BigInteger(948421557255877651L),
new System.Numerics.BigInteger(4927727129883616310L),
new System.Numerics.BigInteger(2711888321922493769L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 64,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7054027998263516761L),
new System.Numerics.BigInteger(7550422642142178672L),
new System.Numerics.BigInteger(1588853419932738078L),
new System.Numerics.BigInteger(211423262081350539L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 49,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8848930708225636151L),
new System.Numerics.BigInteger(4711952367380204463L),
new System.Numerics.BigInteger(5489082542787885970L),
new System.Numerics.BigInteger(8554850095012979091L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 65,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1020853571039516584L),
new System.Numerics.BigInteger(4402435269744385510L),
new System.Numerics.BigInteger(2960947352575280127L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 74,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1659069964109179290L),
new System.Numerics.BigInteger(8491510544831911512L),
new System.Numerics.BigInteger(5536156782525379377L),
new System.Numerics.BigInteger(3700519044570660697L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 53,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7419019194168137702L),
new System.Numerics.BigInteger(3231725489115240063L),
new System.Numerics.BigInteger(744038123894669371L),
new System.Numerics.BigInteger(7608885255333910202L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 75,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(393803405376884143L),
new System.Numerics.BigInteger(1116284747034267044L),
new System.Numerics.BigInteger(6077164745330467440L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3341942362594241572L),
new System.Numerics.BigInteger(6623240523697107431L),
new System.Numerics.BigInteger(5157254126121457203L),
new System.Numerics.BigInteger(7849645282249933889L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 83,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2434674517947420889L),
new System.Numerics.BigInteger(2536184437217247800L),
new System.Numerics.BigInteger(9124781561387664717L),
new System.Numerics.BigInteger(3388169951353388288L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 61,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1703500808176026139L),
new System.Numerics.BigInteger(4369877840352232115L),
new System.Numerics.BigInteger(6140884044381181864L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5707356990669309909L),
new System.Numerics.BigInteger(5668618304070493354L),
new System.Numerics.BigInteger(8688389426687737655L),
new System.Numerics.BigInteger(2593214328558544210L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 92,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5799661416177703016L),
new System.Numerics.BigInteger(8483013468448391673L),
new System.Numerics.BigInteger(8952074801506658406L),
new System.Numerics.BigInteger(1119933612163805713L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 100,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7975371880759727032L),
new System.Numerics.BigInteger(1567270970355472803L),
new System.Numerics.BigInteger(5589991700102110798L),
new System.Numerics.BigInteger(555836110961769697L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 70,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1957031390964629794L),
new System.Numerics.BigInteger(6702096815161008107L),
new System.Numerics.BigInteger(2785190914572594996L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8667298266288742276L),
new System.Numerics.BigInteger(9217180156810703032L),
new System.Numerics.BigInteger(9202965838043608331L),
new System.Numerics.BigInteger(1536286737184633460L),
},
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 104,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4055252382973879534L),
new System.Numerics.BigInteger(402084857140885080L),
new System.Numerics.BigInteger(7503288985061128392L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6064942267262677861L),
new System.Numerics.BigInteger(4136620084094116285L),
new System.Numerics.BigInteger(2017797866321204927L),
new System.Numerics.BigInteger(8372737100990046792L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 111,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4867863882828986338L),
new System.Numerics.BigInteger(3429199274400690297L),
new System.Numerics.BigInteger(5882422748278435846L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 79,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2258065329442318299L),
new System.Numerics.BigInteger(8359030051250734475L),
new System.Numerics.BigInteger(6071953536128053056L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(952838303671902937L),
new System.Numerics.BigInteger(3431111978864536540L),
new System.Numerics.BigInteger(8821369790656100081L),
},
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 118,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1135616613390425743L),
new System.Numerics.BigInteger(5165431751410786272L),
new System.Numerics.BigInteger(3282476632985375976L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5350642286530781612L),
new System.Numerics.BigInteger(6807823028424698322L),
new System.Numerics.BigInteger(9021653129582448157L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 121,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4862481740957240575L),
new System.Numerics.BigInteger(8686898228513834032L),
new System.Numerics.BigInteger(8557031832184693459L),
new System.Numerics.BigInteger(2006144752473463940L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7937634630645930163L),
new System.Numerics.BigInteger(1845033022434184619L),
new System.Numerics.BigInteger(5618640617822317765L),
new System.Numerics.BigInteger(117481370993317714L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6790833166642393183L),
new System.Numerics.BigInteger(6302504654126846536L),
new System.Numerics.BigInteger(870668730034286887L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 128,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7917010479630276995L),
new System.Numerics.BigInteger(2843344310661774185L),
new System.Numerics.BigInteger(6693988586431032907L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3475352550401339245L),
new System.Numerics.BigInteger(4207866936511156194L),
new System.Numerics.BigInteger(1133583173025216184L),
new System.Numerics.BigInteger(7001536781453655928L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 129,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8557753134685290524L),
new System.Numerics.BigInteger(8735598013891315106L),
new System.Numerics.BigInteger(8220971189187515898L),
new System.Numerics.BigInteger(4302133357499843373L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 89,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(604834877744354077L),
new System.Numerics.BigInteger(5016309356503261459L),
new System.Numerics.BigInteger(7340557101362349990L),
new System.Numerics.BigInteger(2077101828513414069L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9056090639791848333L),
new System.Numerics.BigInteger(2953876191439518306L),
new System.Numerics.BigInteger(4126735292040182152L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1623133864141174632L),
new System.Numerics.BigInteger(2345511458198982729L),
new System.Numerics.BigInteger(1433048054476271707L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 138,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(729505628085813041L),
new System.Numerics.BigInteger(4825227182682540009L),
new System.Numerics.BigInteger(6607964107072247419L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7288528103326986623L),
new System.Numerics.BigInteger(4284337467555060412L),
new System.Numerics.BigInteger(6390123377788091993L),
new System.Numerics.BigInteger(8997710241935458779L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 141,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8188449418125298946L),
new System.Numerics.BigInteger(5576707526854252491L),
new System.Numerics.BigInteger(6432450845944000138L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 93,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1762130653585270501L),
new System.Numerics.BigInteger(9011331613481774301L),
new System.Numerics.BigInteger(4289081898231803127L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 150,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(863610760985296991L),
new System.Numerics.BigInteger(988573112512403022L),
new System.Numerics.BigInteger(4428291532312483645L),
new System.Numerics.BigInteger(1692742532037123791L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 153,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1931347899912608242L),
new System.Numerics.BigInteger(7378714743328773431L),
new System.Numerics.BigInteger(2876878534745194371L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 97,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3413519532017242704L),
new System.Numerics.BigInteger(5789067333829200622L),
new System.Numerics.BigInteger(7257906341738767426L),
new System.Numerics.BigInteger(7803124934143737567L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5776326486539380844L),
new System.Numerics.BigInteger(8058637048306316879L),
new System.Numerics.BigInteger(8910804057388772003L),
},
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 161,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4475233909635134305L),
new System.Numerics.BigInteger(1347024804292037344L),
new System.Numerics.BigInteger(4626334949603548185L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(156315062732127749L),
new System.Numerics.BigInteger(228713713971741542L),
new System.Numerics.BigInteger(684072689050525077L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 168,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6623960287340361500L),
new System.Numerics.BigInteger(7492794694335656769L),
new System.Numerics.BigInteger(5808004121902599415L),
new System.Numerics.BigInteger(3403257000071462960L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 101,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1311755645844765014L),
new System.Numerics.BigInteger(7818241881606098459L),
new System.Numerics.BigInteger(6058710343989056193L),
new System.Numerics.BigInteger(9162293792215613742L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9222825056809638367L),
new System.Numerics.BigInteger(884744886751081201L),
new System.Numerics.BigInteger(8877658118217317865L),
},
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 174,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(361050232757830672L),
new System.Numerics.BigInteger(5385774831129011356L),
new System.Numerics.BigInteger(1519630223855484188L),
new System.Numerics.BigInteger(2476443545352357165L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(420501293943487930L),
new System.Numerics.BigInteger(5898266476713034473L),
new System.Numerics.BigInteger(3115644881820198800L),
new System.Numerics.BigInteger(3330794319555836793L),
},
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 178,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7309440309284200130L),
new System.Numerics.BigInteger(376381557504720631L),
new System.Numerics.BigInteger(4981609562208711062L),
new System.Numerics.BigInteger(3967523814342087630L),
},
    ModelInner = new BigIntegernumericMMArrayD1E1MI
{
    Id = 105,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6540139143780208470L),
new System.Numerics.BigInteger(2168026376170999074L),
new System.Numerics.BigInteger(3673320000172338192L),
new System.Numerics.BigInteger(5888898212483076951L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD1E1M
{
    Id = 183,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4944125635803255544L),
new System.Numerics.BigInteger(2749306803423785669L),
new System.Numerics.BigInteger(6013367027862758729L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2317033454407717978L),
new System.Numerics.BigInteger(7711425391293360073L),
new System.Numerics.BigInteger(5797315376119422417L),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd1e1mi(
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd1e1mi(
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
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
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

                changedRows =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd1e1mi_id
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericmmarrayd1e1mi_id", 
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
                changedRows =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd1e1mi_id
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
    bigintegernumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
INSERT INTO public.bigintegernumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd1e1mi_id
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
    bigintegernumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericmmarrayd1e1mi_id", 
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
                List<BigIntegernumericMMArrayD1E1M> models = null;

                models =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericMMArrayD1E1M> models = null;

                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M), typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
LEFT JOIN public.bigintegernumericmmarrayd1e1mi mi ON mi.id = m.bigintegernumericmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M), typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
LEFT JOIN public.bigintegernumericmmarrayd1e1mi mi ON mi.id = m.bigintegernumericmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M), typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 168;
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 4;
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
LEFT JOIN public.bigintegernumericmmarrayd1e1mi mi ON mi.id = m.bigintegernumericmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models = await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M), typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 2, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 23, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 1, query1, 168, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 168, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 65, query1, 118, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 121, query1, 121, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 15, query1, 141, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
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
FROM public.bigintegernumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD1E1M>();
                 ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 104, query1, 138, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatBigIntegernumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd1e1m m
LEFT JOIN public.bigintegernumericmmarrayd1e1mi mi ON mi.id = m.bigintegernumericmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models = await((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 8, 9))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 2, 40))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        BigIntegernumericMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerMArraynumericMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerMArraynumericMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 64);
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerMArraynumericMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerMArraynumericMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 141);
                var models =  ((IBigIntegerMArraynumericMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                BigIntegernumericMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                BigIntegernumericMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
FROM public.binary_bigintegernumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD1E1MIWA),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD1E1MI),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerMArraynumericMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerMArraynumericMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericMMArrayD1E1M),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
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
FROM public.binary_bigintegernumericmmarrayd1e1m m
LEFT JOIN public.binary_bigintegernumericmmarrayd1e1mi mi ON mi.id = m.bigintegernumericmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerMArraynumericMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerMArraynumericMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models =  ((IBigIntegerMArraynumericMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA), typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
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
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
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
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA), typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
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
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
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
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MI), typeof(BigIntegernumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MI>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MI>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MI>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MI>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA), typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD1E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD1))]
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
                var models = await ((IBigIntegerMArraynumericMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

