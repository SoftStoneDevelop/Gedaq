

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
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4399110961868671d,right: 0.9750436844554259d,bottom: 0.42340217554345494d,left: 0.3648989160506154d),
new NpgsqlTypes.NpgsqlBox(top: 0.9570497816772632d,right: 0.5047871110338273d,bottom: 0.3864579079039905d,left: 0.1140373195209946d),
new NpgsqlTypes.NpgsqlBox(top: 0.6556913426303255d,right: 0.9824657799018268d,bottom: 0.5625692807626116d,left: 0.42500272250004645d),
new NpgsqlTypes.NpgsqlBox(top: 0.7653303369686836d,right: 0.4048064838289588d,bottom: 0.635598776842592d,left: 0.2564688268873717d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8560121177071424d,right: 0.46430622412261635d,bottom: 0.5178061410932296d,left: 0.16180177400210305d),
new NpgsqlTypes.NpgsqlBox(top: 0.7174051861118002d,right: 0.9282610044325205d,bottom: 0.6899437866631902d,left: 0.7186690049489158d),
new NpgsqlTypes.NpgsqlBox(top: 0.7343550560191401d,right: 0.8275843347220252d,bottom: 0.6964709547175622d,left: 0.17352446436786695d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9416210983179776d,right: 0.9605995198452141d,bottom: 0.2698605613440872d,left: 0.7294952986274191d),
new NpgsqlTypes.NpgsqlBox(top: 0.8415034637501873d,right: 0.9656356189097367d,bottom: 0.7690947291703968d,left: 0.8457326364930725d),
new NpgsqlTypes.NpgsqlBox(top: 0.45975652257440425d,right: 0.6911283930676887d,bottom: 0.1953403087602602d,left: 0.16497253421703406d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8944419770702193d,right: 0.5912175916728903d,bottom: 0.04215214357569941d,left: 0.2041180445030496d),
new NpgsqlTypes.NpgsqlBox(top: 0.7559395159567185d,right: 0.1752555860294731d,bottom: 0.5333068168395043d,left: 0.05175651489847244d),
new NpgsqlTypes.NpgsqlBox(top: 0.41787917495523774d,right: 0.9320906851073831d,bottom: 0.25880374186730803d,left: 0.6894711674193628d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4740975661154232d,right: 0.6422521831387784d,bottom: 0.3383416466687975d,left: 0.6127372570683117d),
new NpgsqlTypes.NpgsqlBox(top: 0.8546689065057297d,right: 0.6254053113292354d,bottom: 0.447262569773218d,left: 0.07767437621247175d),
new NpgsqlTypes.NpgsqlBox(top: 0.824604684926818d,right: 0.9303429198088167d,bottom: 0.19347970025081063d,left: 0.7189065815970259d),
new NpgsqlTypes.NpgsqlBox(top: 0.9875198084226522d,right: 0.7490341201348294d,bottom: 0.79394222222242d,left: 0.10940803385917475d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.817742694878488d,right: 0.9958997374985541d,bottom: 0.6038543566052978d,left: 0.21309724545730868d),
new NpgsqlTypes.NpgsqlBox(top: 0.82757665099935d,right: 0.4733878740814521d,bottom: 0.6208216352290025d,left: 0.0731312264685895d),
new NpgsqlTypes.NpgsqlBox(top: 0.6343652431965521d,right: 0.6096990658164029d,bottom: 0.5514164775534426d,left: 0.5570153233029043d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6920223189172902d,right: 0.3701920266097857d,bottom: 0.16918048329083735d,left: 0.12970855665681413d),
new NpgsqlTypes.NpgsqlBox(top: 0.8700819111920414d,right: 0.8203037574907317d,bottom: 0.6790253753911412d,left: 0.4703228003344265d),
new NpgsqlTypes.NpgsqlBox(top: 0.9070135192291495d,right: 0.9588965001676413d,bottom: 0.26436626067498714d,left: 0.7201825120459612d),
new NpgsqlTypes.NpgsqlBox(top: 0.9971496634905372d,right: 0.397376772761852d,bottom: 0.5476256326402917d,left: 0.29202095957146956d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8580376862276088d,right: 0.3735390723923734d,bottom: 0.7594422178634012d,left: 0.014001378564174827d),
new NpgsqlTypes.NpgsqlBox(top: 0.9335005735138096d,right: 0.9848588022463536d,bottom: 0.631731599068575d,left: 0.4989667547818335d),
new NpgsqlTypes.NpgsqlBox(top: 0.7464224610668834d,right: 0.9505654429784819d,bottom: 0.5759512069296939d,left: 0.2899932548821671d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3191367362035916d,right: 0.7885885863887145d,bottom: 0.25290734005991067d,left: 0.27309179247494575d),
new NpgsqlTypes.NpgsqlBox(top: 0.1327508207629713d,right: 0.7961989818024964d,bottom: 0.033333471208571774d,left: 0.40148174059712494d),
new NpgsqlTypes.NpgsqlBox(top: 0.9209283180835265d,right: 0.6157667715601144d,bottom: 0.5897315252175924d,left: 0.2690913905087554d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6517162075794037d,right: 0.9723073407074116d,bottom: 0.4058628372897264d,left: 0.7752706947013289d),
new NpgsqlTypes.NpgsqlBox(top: 0.716110296940139d,right: 0.5884857951014211d,bottom: 0.598859583134335d,left: 0.41306395364327475d),
new NpgsqlTypes.NpgsqlBox(top: 0.4497599701759223d,right: 0.5409370164471818d,bottom: 0.15729715541209144d,left: 0.4917301832995298d),
new NpgsqlTypes.NpgsqlBox(top: 0.13431690955264375d,right: 0.3416833714497757d,bottom: 0.013567984692783086d,left: 0.17011030485517564d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3687136910298068d,right: 0.9857256372490619d,bottom: 0.1207701045216627d,left: 0.13517171240771764d),
new NpgsqlTypes.NpgsqlBox(top: 0.4755961117510472d,right: 0.7172788522035818d,bottom: 0.3977182803552636d,left: 0.08615464091063585d),
new NpgsqlTypes.NpgsqlBox(top: 0.9872587177741733d,right: 0.47864248226378203d,bottom: 0.019585196550404027d,left: 0.1711702870020636d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9226556207581432d,right: 0.9174654476093158d,bottom: 0.868886778127974d,left: 0.2723095124808661d),
new NpgsqlTypes.NpgsqlBox(top: 0.6835492284615899d,right: 0.9532830199474871d,bottom: 0.48592786889495d,left: 0.80686070841676d),
new NpgsqlTypes.NpgsqlBox(top: 0.672473004794167d,right: 0.5529495996770636d,bottom: 0.5381800602357901d,left: 0.5192440599237823d),
new NpgsqlTypes.NpgsqlBox(top: 0.8593199056015417d,right: 0.976840345451925d,bottom: 0.5908308001881459d,left: 0.45932839806581394d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.46205928193655077d,right: 0.7500940224032134d,bottom: 0.35493086652652495d,left: 0.4949316714961387d),
new NpgsqlTypes.NpgsqlBox(top: 0.9521401153003709d,right: 0.3556563483937356d,bottom: 0.25396768679446735d,left: 0.3373510361683517d),
new NpgsqlTypes.NpgsqlBox(top: 0.1796801095249575d,right: 0.887332788604551d,bottom: 0.15502394820976106d,left: 0.5150634538795629d),
new NpgsqlTypes.NpgsqlBox(top: 0.03946018092206205d,right: 0.24792507034577282d,bottom: 0.029530276362581542d,left: 0.0482062951128408d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2739690827665373d,right: 0.7525771753582511d,bottom: 0.08887318277569844d,left: 0.6244968145608311d),
new NpgsqlTypes.NpgsqlBox(top: 0.8130599335622095d,right: 0.7601620151636661d,bottom: 0.752298122351248d,left: 0.2566929145225333d),
new NpgsqlTypes.NpgsqlBox(top: 0.7471454628073039d,right: 0.6750671574091647d,bottom: 0.041968062702443354d,left: 0.37114155597525644d),
new NpgsqlTypes.NpgsqlBox(top: 0.3639024350178359d,right: 0.7719355332310228d,bottom: 0.09520125641900812d,left: 0.7329047050799334d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5483897965102039d,right: 0.435608498751236d,bottom: 0.5252202908679391d,left: 0.2729680242854634d),
new NpgsqlTypes.NpgsqlBox(top: 0.9490641972539028d,right: 0.7809170358281734d,bottom: 0.633308044569886d,left: 0.07342526322933884d),
new NpgsqlTypes.NpgsqlBox(top: 0.8077826059987504d,right: 0.5518760336622571d,bottom: 0.5363547856852008d,left: 0.26220487456984887d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9327075282386936d,right: 0.7841818133018644d,bottom: 0.15867334185797377d,left: 0.3927211007106659d),
new NpgsqlTypes.NpgsqlBox(top: 0.46254033636447633d,right: 0.8117778129167225d,bottom: 0.12006511682164889d,left: 0.21924633043404074d),
new NpgsqlTypes.NpgsqlBox(top: 0.46956940662694147d,right: 0.7354450859476429d,bottom: 0.41241226309451773d,left: 0.3087021784047145d),
new NpgsqlTypes.NpgsqlBox(top: 0.9040921691969921d,right: 0.5765398228024217d,bottom: 0.23882504891147338d,left: 0.3499526391585478d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7558752635231457d,right: 0.20219911060789897d,bottom: 0.6651310153617561d,left: 0.021842946353843873d),
new NpgsqlTypes.NpgsqlBox(top: 0.4291387752154179d,right: 0.3806941961050695d,bottom: 0.2263784271643784d,left: 0.20612433317560386d),
new NpgsqlTypes.NpgsqlBox(top: 0.592441430137654d,right: 0.8475102638668189d,bottom: 0.23998762109033733d,left: 0.10339933793347211d),
new NpgsqlTypes.NpgsqlBox(top: 0.9003465832284859d,right: 0.34856093252658926d,bottom: 0.21394318493234177d,left: 0.08306493943500437d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7920168962519769d,right: 0.9123191962174463d,bottom: 0.679624350516369d,left: 0.13187397912275267d),
new NpgsqlTypes.NpgsqlBox(top: 0.9207836820215506d,right: 0.8093640687358793d,bottom: 0.67175145969573d,left: 0.7364916598580706d),
new NpgsqlTypes.NpgsqlBox(top: 0.5085439856283543d,right: 0.5937481900850673d,bottom: 0.13398736258803579d,left: 0.5915819561536962d),
new NpgsqlTypes.NpgsqlBox(top: 0.35670823683718855d,right: 0.7142259438620874d,bottom: 0.1867730225300136d,left: 0.4762867555857466d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9997564394577017d,right: 0.46162566536139715d,bottom: 0.029418181227192863d,left: 0.18184853371004206d),
new NpgsqlTypes.NpgsqlBox(top: 0.5802709900555365d,right: 0.4460964265915649d,bottom: 0.01516446475464428d,left: 0.06893760009491146d),
new NpgsqlTypes.NpgsqlBox(top: 0.7112150344165932d,right: 0.7941776680097895d,bottom: 0.6957761025098051d,left: 0.5327563924927602d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7727141194491677d,right: 0.9631760821657721d,bottom: 0.10233240507604424d,left: 0.27958188328844813d),
new NpgsqlTypes.NpgsqlBox(top: 0.8610114470011611d,right: 0.772748108033433d,bottom: 0.295170365222879d,left: 0.23095117360576578d),
new NpgsqlTypes.NpgsqlBox(top: 0.8253569516000331d,right: 0.9171304154762175d,bottom: 0.14415875387139654d,left: 0.2025363159485103d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5246853110032205d,right: 0.741305377422093d,bottom: 0.1835411351848778d,left: 0.12211208868322343d),
new NpgsqlTypes.NpgsqlBox(top: 0.42909314837073476d,right: 0.8013930681096874d,bottom: 0.11026527755004423d,left: 0.4666816374869549d),
new NpgsqlTypes.NpgsqlBox(top: 0.4356025426769671d,right: 0.8910688656682507d,bottom: 0.291005474756067d,left: 0.2571187294629338d),
new NpgsqlTypes.NpgsqlBox(top: 0.9828799520091233d,right: 0.9608533642547974d,bottom: 0.2993872242012171d,left: 0.34065384324071635d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7173910510195726d,right: 0.5767554004284956d,bottom: 0.22578792690069438d,left: 0.5230760632047055d),
new NpgsqlTypes.NpgsqlBox(top: 0.47757640482294905d,right: 0.6809888870512544d,bottom: 0.04704414275094415d,left: 0.33383077880109957d),
new NpgsqlTypes.NpgsqlBox(top: 0.7460864770247528d,right: 0.9751800907145937d,bottom: 0.44230364447560566d,left: 0.5109552308680365d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6570776221244714d,right: 0.9658451800191712d,bottom: 0.34125613422449275d,left: 0.22570802773464693d),
new NpgsqlTypes.NpgsqlBox(top: 0.46592720907239293d,right: 0.17434035604099563d,bottom: 0.30060800357867457d,left: 0.11273643759972052d),
new NpgsqlTypes.NpgsqlBox(top: 0.7694086825718295d,right: 0.9471442177944489d,bottom: 0.5610360498768338d,left: 0.5673089318820789d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9958077655776021d,right: 0.17300946607839374d,bottom: 0.5000973355588739d,left: 0.13775149961472233d),
new NpgsqlTypes.NpgsqlBox(top: 0.9755341651624674d,right: 0.6092057542009238d,bottom: 0.629732365169791d,left: 0.387004400905686d),
new NpgsqlTypes.NpgsqlBox(top: 0.3375784034826478d,right: 0.5559433130686151d,bottom: 0.06255517080129236d,left: 0.015850440249212783d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8594978540661466d,right: 0.9174949125646813d,bottom: 0.8343788359452126d,left: 0.49663023243906645d),
new NpgsqlTypes.NpgsqlBox(top: 0.5883641986448268d,right: 0.5914430467586423d,bottom: 0.4352396176208788d,left: 0.4153920152679309d),
new NpgsqlTypes.NpgsqlBox(top: 0.5643623088760317d,right: 0.8399891884709353d,bottom: 0.32126157885413154d,left: 0.0003191095592118831d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5339422940507402d,right: 0.5590326810835893d,bottom: 0.21481027620413407d,left: 0.25914518763041217d),
new NpgsqlTypes.NpgsqlBox(top: 0.14658422330124177d,right: 0.961954745771193d,bottom: 0.021545157293456296d,left: 0.8150718906644576d),
new NpgsqlTypes.NpgsqlBox(top: 0.4904662673509218d,right: 0.3244840984592151d,bottom: 0.4089284626679339d,left: 0.06422858836217182d),
new NpgsqlTypes.NpgsqlBox(top: 0.7660465882034456d,right: 0.9705725997017707d,bottom: 0.4404018142892673d,left: 0.6516987527253989d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3985815527513502d,right: 0.8965216803058128d,bottom: 0.22705806719399457d,left: 0.40224562131984865d),
new NpgsqlTypes.NpgsqlBox(top: 0.7352939416277741d,right: 0.35009233971391607d,bottom: 0.34635093656938465d,left: 0.3155704397555915d),
new NpgsqlTypes.NpgsqlBox(top: 0.6746376938216182d,right: 0.3656028003605607d,bottom: 0.06058499147557783d,left: 0.0016881095623307862d),
new NpgsqlTypes.NpgsqlBox(top: 0.981995208334101d,right: 0.8823019723973217d,bottom: 0.7812308623899582d,left: 0.1983680087040538d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.24318219539935815d,right: 0.9044248885751097d,bottom: 0.11688219789844789d,left: 0.595116817831658d),
new NpgsqlTypes.NpgsqlBox(top: 0.4547675152971554d,right: 0.37287344385805d,bottom: 0.4011352029261259d,left: 0.21232973912683195d),
new NpgsqlTypes.NpgsqlBox(top: 0.7311777729494569d,right: 0.31658081274845695d,bottom: 0.2635664000240878d,left: 0.19262847373423186d),
new NpgsqlTypes.NpgsqlBox(top: 0.6018081998857875d,right: 0.9727000335134995d,bottom: 0.2179876526417207d,left: 0.6201001479444483d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7419259321810688d,right: 0.9533575988431068d,bottom: 0.524984022056874d,left: 0.34464489847515767d),
new NpgsqlTypes.NpgsqlBox(top: 0.5255067422459284d,right: 0.5593077863978273d,bottom: 0.4416197457780069d,left: 0.5450048072626054d),
new NpgsqlTypes.NpgsqlBox(top: 0.8376583761005941d,right: 0.18186016529312465d,bottom: 0.03770174220828304d,left: 0.1274121208426815d),
new NpgsqlTypes.NpgsqlBox(top: 0.7677312410315436d,right: 0.5309703120593523d,bottom: 0.5174438140438951d,left: 0.16065418333561532d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.42361240241274134d,right: 0.6219857580084156d,bottom: 0.237448661707366d,left: 0.34728580061894454d),
new NpgsqlTypes.NpgsqlBox(top: 0.8393214778337657d,right: 0.4660041888752028d,bottom: 0.6057715741038112d,left: 0.2365270793644899d),
new NpgsqlTypes.NpgsqlBox(top: 0.7345076977013427d,right: 0.2628165630425756d,bottom: 0.46632170580909527d,left: 0.04001912348093084d),
new NpgsqlTypes.NpgsqlBox(top: 0.9803071948139659d,right: 0.1530334312501943d,bottom: 0.8970335369155101d,left: 0.09918701364179305d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8136888341545525d,right: 0.8211263003544896d,bottom: 0.30426677724719664d,left: 0.016082782152937347d),
new NpgsqlTypes.NpgsqlBox(top: 0.5557079415082805d,right: 0.8726444999899845d,bottom: 0.38140236438523656d,left: 0.7081324922372307d),
new NpgsqlTypes.NpgsqlBox(top: 0.4619010967761952d,right: 0.7405025535409814d,bottom: 0.42327271367467256d,left: 0.1680813464032027d),
new NpgsqlTypes.NpgsqlBox(top: 0.8792512539925919d,right: 0.6272410924234947d,bottom: 0.46167884031517925d,left: 0.5792563596707258d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5383688624488147d,right: 0.39391850510720705d,bottom: 0.27551759547496213d,left: 0.39090616168343106d),
new NpgsqlTypes.NpgsqlBox(top: 0.15300086769143417d,right: 0.7936554798845302d,bottom: 0.11788491427452785d,left: 0.01875892855950545d),
new NpgsqlTypes.NpgsqlBox(top: 0.7370782716846315d,right: 0.7275790183559949d,bottom: 0.11040586343454184d,left: 0.2296858498683757d),
new NpgsqlTypes.NpgsqlBox(top: 0.9156098830570333d,right: 0.3119842001233336d,bottom: 0.5239050501106768d,left: 0.09724006923442641d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9245036880276781d,right: 0.6523902786629884d,bottom: 0.346250630823411d,left: 0.16543519904212123d),
new NpgsqlTypes.NpgsqlBox(top: 0.7922165750975515d,right: 0.4493970217851557d,bottom: 0.20002988568927038d,left: 0.11096967689438364d),
new NpgsqlTypes.NpgsqlBox(top: 0.5935952467894168d,right: 0.9494944600120986d,bottom: 0.4771426683371759d,left: 0.019630799111740482d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8409699507271982d,right: 0.7417886040334398d,bottom: 0.8341730378576817d,left: 0.0698755341975037d),
new NpgsqlTypes.NpgsqlBox(top: 0.842424554983555d,right: 0.3407479090272315d,bottom: 0.2530354886959386d,left: 0.14724717848245528d),
new NpgsqlTypes.NpgsqlBox(top: 0.5873370082108029d,right: 0.9315433123122705d,bottom: 0.18024305734241808d,left: 0.7345475537176793d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7163657459420878d,right: 0.9287181143219396d,bottom: 0.47708309028669005d,left: 0.8232861387477345d),
new NpgsqlTypes.NpgsqlBox(top: 0.6046183029025163d,right: 0.5446358140370408d,bottom: 0.4613383180595767d,left: 0.181159930630597d),
new NpgsqlTypes.NpgsqlBox(top: 0.6996772942669421d,right: 0.37175897675129177d,bottom: 0.15758281458972645d,left: 0.1967285780722745d),
new NpgsqlTypes.NpgsqlBox(top: 0.4573302305879815d,right: 0.8498787924600582d,bottom: 0.20234138196116314d,left: 0.8182886453874192d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5017092974080336d,right: 0.9930067112695319d,bottom: 0.49988396121198664d,left: 0.5007948650629909d),
new NpgsqlTypes.NpgsqlBox(top: 0.4846024237820241d,right: 0.6374316509876948d,bottom: 0.14397279866949464d,left: 0.348221851062712d),
new NpgsqlTypes.NpgsqlBox(top: 0.6385815731199076d,right: 0.8554829177756043d,bottom: 0.04691472706163591d,left: 0.6220661436961774d),
new NpgsqlTypes.NpgsqlBox(top: 0.5007609920905018d,right: 0.6915950593334687d,bottom: 0.35262553722597667d,left: 0.5136007135462242d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7858040523208306d,right: 0.9732720048144458d,bottom: 0.059392058781442714d,left: 0.5801261666560232d),
new NpgsqlTypes.NpgsqlBox(top: 0.7814546255903879d,right: 0.35816981017508664d,bottom: 0.40135985920917705d,left: 0.28493084093913157d),
new NpgsqlTypes.NpgsqlBox(top: 0.9088427928819907d,right: 0.680743528161773d,bottom: 0.7894718971621177d,left: 0.13096434761098974d),
new NpgsqlTypes.NpgsqlBox(top: 0.3346931067557831d,right: 0.21355649248698927d,bottom: 0.27532539430347236d,left: 0.21067482966751572d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5306784058901312d,right: 0.5344294461406914d,bottom: 0.05519157542647857d,left: 0.4071463711773372d),
new NpgsqlTypes.NpgsqlBox(top: 0.7113255076496511d,right: 0.9897000652242639d,bottom: 0.38038846512559277d,left: 0.7032914575318648d),
new NpgsqlTypes.NpgsqlBox(top: 0.6037291921526896d,right: 0.6659862689879429d,bottom: 0.22011218415156597d,left: 0.5328152363088393d),
new NpgsqlTypes.NpgsqlBox(top: 0.8176497852455304d,right: 0.6720718157411497d,bottom: 0.62981818205962d,left: 0.17536312809073673d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3680682446158734d,right: 0.6031691406080626d,bottom: 0.12244947883354762d,left: 0.3875283489261082d),
new NpgsqlTypes.NpgsqlBox(top: 0.8578856387142781d,right: 0.565476515984689d,bottom: 0.7732271027358381d,left: 0.3876367423709257d),
new NpgsqlTypes.NpgsqlBox(top: 0.7706678095465882d,right: 0.4613789443232803d,bottom: 0.2790166050612398d,left: 0.20396447798954553d),
new NpgsqlTypes.NpgsqlBox(top: 0.9363395469751536d,right: 0.5352955487449346d,bottom: 0.5716743167112979d,left: 0.06542317489573446d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.31941038611539774d,right: 0.4943337923259976d,bottom: 0.08496433871986553d,left: 0.36526196022973934d),
new NpgsqlTypes.NpgsqlBox(top: 0.19154262305290815d,right: 0.961127812472752d,bottom: 0.15175198550929858d,left: 0.5355033989987945d),
new NpgsqlTypes.NpgsqlBox(top: 0.7157620810293679d,right: 0.7278178175712192d,bottom: 0.14081443290498086d,left: 0.35602034072718736d),
new NpgsqlTypes.NpgsqlBox(top: 0.46265775572398005d,right: 0.4625970953283345d,bottom: 0.056166799284566804d,left: 0.26703368405162575d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5412828605968255d,right: 0.9760295694961714d,bottom: 0.3123190042345768d,left: 0.26771998100065375d),
new NpgsqlTypes.NpgsqlBox(top: 0.5956655517850427d,right: 0.5823352243543178d,bottom: 0.5723093756068627d,left: 0.5366557737472359d),
new NpgsqlTypes.NpgsqlBox(top: 0.3774701326416211d,right: 0.9687386955209111d,bottom: 0.27257001921116364d,left: 0.7515982556524307d),
new NpgsqlTypes.NpgsqlBox(top: 0.8448716903414318d,right: 0.5776393991751732d,bottom: 0.634584278808194d,left: 0.49377060392777117d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8637274549178054d,right: 0.7085498738648045d,bottom: 0.1333805774713238d,left: 0.24344192517237728d),
new NpgsqlTypes.NpgsqlBox(top: 0.6054109152368015d,right: 0.8759830152485553d,bottom: 0.24271669374112637d,left: 0.6386990490989783d),
new NpgsqlTypes.NpgsqlBox(top: 0.6950639598343822d,right: 0.13520175733458473d,bottom: 0.1423793412283183d,left: 0.09058711576553369d),
new NpgsqlTypes.NpgsqlBox(top: 0.48594251162367375d,right: 0.9752479871437576d,bottom: 0.2898598736136042d,left: 0.9164911774264493d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7442637852439168d,right: 0.792764797307823d,bottom: 0.1696988300725003d,left: 0.2841973670548179d),
new NpgsqlTypes.NpgsqlBox(top: 0.4201585013661132d,right: 0.8091905726716965d,bottom: 0.38615306838418006d,left: 0.3263882169445722d),
new NpgsqlTypes.NpgsqlBox(top: 0.920865927026502d,right: 0.854769361842949d,bottom: 0.8329273054069848d,left: 0.6441547021969606d),
new NpgsqlTypes.NpgsqlBox(top: 0.9658249643284055d,right: 0.9481360893406856d,bottom: 0.3649185310223756d,left: 0.8409842655233769d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6411962042445266d,right: 0.5846662348401779d,bottom: 0.02674657646577494d,left: 0.00952066640083904d),
new NpgsqlTypes.NpgsqlBox(top: 0.7263018008483115d,right: 0.529439865668956d,bottom: 0.21042852496051345d,left: 0.3196592581226365d),
new NpgsqlTypes.NpgsqlBox(top: 0.9180736798693996d,right: 0.727143184616411d,bottom: 0.33758473107388554d,left: 0.06074533878102906d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9311245849521482d,right: 0.8656320441290719d,bottom: 0.3364022038939404d,left: 0.0051991023662782965d),
new NpgsqlTypes.NpgsqlBox(top: 0.9317435445859409d,right: 0.9277232853345841d,bottom: 0.1291957175939501d,left: 0.16275341313071479d),
new NpgsqlTypes.NpgsqlBox(top: 0.4626079949034436d,right: 0.2794273530402407d,bottom: 0.2602867826726327d,left: 0.2530567562164219d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.91952365987618d,right: 0.7574993357888532d,bottom: 0.20208697817067267d,left: 0.7573795758937208d),
new NpgsqlTypes.NpgsqlBox(top: 0.9903649631379022d,right: 0.5771812684255881d,bottom: 0.09147351937635495d,left: 0.32432790863268623d),
new NpgsqlTypes.NpgsqlBox(top: 0.7820006775115674d,right: 0.9364014171125844d,bottom: 0.7307987758787442d,left: 0.626926065526646d),
new NpgsqlTypes.NpgsqlBox(top: 0.6892227085508985d,right: 0.6435375438482663d,bottom: 0.6619723310480828d,left: 0.5634403697509852d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.17099481590754328d,right: 0.9081991271019658d,bottom: 0.1445666604542608d,left: 0.20767533262747107d),
new NpgsqlTypes.NpgsqlBox(top: 0.53698845876119d,right: 0.33580196910112237d,bottom: 0.3802704050821658d,left: 0.3099198378612086d),
new NpgsqlTypes.NpgsqlBox(top: 0.5617710369250039d,right: 0.9860562833118638d,bottom: 0.053751958636568786d,left: 0.0035732562821390035d),
new NpgsqlTypes.NpgsqlBox(top: 0.7225373922263473d,right: 0.8705475751148783d,bottom: 0.04648749070422531d,left: 0.046644187753701605d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7674629874126515d,right: 0.6943854733084083d,bottom: 0.09832525865998609d,left: 0.2697738330255013d),
new NpgsqlTypes.NpgsqlBox(top: 0.8482682810750752d,right: 0.6332517704549362d,bottom: 0.8108733854559238d,left: 0.5432051151434739d),
new NpgsqlTypes.NpgsqlBox(top: 0.46330424832776096d,right: 0.7360843779828532d,bottom: 0.01976162993157815d,left: 0.35919973484214696d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7005842600023664d,right: 0.9141079101040912d,bottom: 0.36191036358108775d,left: 0.7841578955368157d),
new NpgsqlTypes.NpgsqlBox(top: 0.6188212361892181d,right: 0.38638443503501374d,bottom: 0.4008720617645253d,left: 0.04661489744965008d),
new NpgsqlTypes.NpgsqlBox(top: 0.6544889665047074d,right: 0.5479736272240172d,bottom: 0.31447492565261825d,left: 0.375064310375404d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.509698863208784d,right: 0.7382709462149298d,bottom: 0.21968000576574542d,left: 0.2822199692316715d),
new NpgsqlTypes.NpgsqlBox(top: 0.6310053810905143d,right: 0.6646643132798816d,bottom: 0.48154660388961223d,left: 0.021248572986147574d),
new NpgsqlTypes.NpgsqlBox(top: 0.9293176947120758d,right: 0.9701855953373376d,bottom: 0.8474164377107647d,left: 0.7852783562102744d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6198360426094278d,right: 0.6430650369162412d,bottom: 0.33765612847633897d,left: 0.5899972463890614d),
new NpgsqlTypes.NpgsqlBox(top: 0.07728582557652608d,right: 0.9636554646368672d,bottom: 0.059059718837539577d,left: 0.5329130426360644d),
new NpgsqlTypes.NpgsqlBox(top: 0.20960794039285802d,right: 0.43032619096674274d,bottom: 0.06465772405177694d,left: 0.19656244285974456d),
new NpgsqlTypes.NpgsqlBox(top: 0.7356064990303562d,right: 0.9999230126060961d,bottom: 0.10531327584011851d,left: 0.25394322441158756d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5360438357800607d,right: 0.7536334969976948d,bottom: 0.043173190512377446d,left: 0.14979593763542143d),
new NpgsqlTypes.NpgsqlBox(top: 0.6102415682354533d,right: 0.5110046435527432d,bottom: 0.5176964233515724d,left: 0.18440516195388923d),
new NpgsqlTypes.NpgsqlBox(top: 0.9592643891366782d,right: 0.8236043071684719d,bottom: 0.5146178716006027d,left: 0.5558587867634475d),
new NpgsqlTypes.NpgsqlBox(top: 0.9455771499440158d,right: 0.1416960530188086d,bottom: 0.40886238348134696d,left: 0.08242607162828386d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.552351417148211d,right: 0.9865234585540354d,bottom: 0.10249239658387654d,left: 0.3986503248694553d),
new NpgsqlTypes.NpgsqlBox(top: 0.6537153095121749d,right: 0.37120191042047346d,bottom: 0.04834883302387882d,left: 0.27130527629941836d),
new NpgsqlTypes.NpgsqlBox(top: 0.24984650336741676d,right: 0.29180444572630804d,bottom: 0.17990402238486425d,left: 0.05782881293122877d),
new NpgsqlTypes.NpgsqlBox(top: 0.6346531079443664d,right: 0.9813797568783028d,bottom: 0.6141279239222414d,left: 0.4770824733102744d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6342923044373021d,right: 0.7012767912914968d,bottom: 0.027200268880155032d,left: 0.23772808107950316d),
new NpgsqlTypes.NpgsqlBox(top: 0.6718476437114089d,right: 0.8659543218604538d,bottom: 0.6632995043589485d,left: 0.0791399683597831d),
new NpgsqlTypes.NpgsqlBox(top: 0.8759030256951005d,right: 0.28276501564800927d,bottom: 0.7011086787197749d,left: 0.18794644487450052d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.72671297537897d,right: 0.6472017661268499d,bottom: 0.4929359565410668d,left: 0.531780320997925d),
new NpgsqlTypes.NpgsqlBox(top: 0.4157340142233499d,right: 0.24595778003152236d,bottom: 0.011761385877191666d,left: 0.12016638289218118d),
new NpgsqlTypes.NpgsqlBox(top: 0.9107842122966039d,right: 0.889977538476586d,bottom: 0.6333565817628087d,left: 0.040380037487730114d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4704385099328563d,right: 0.674215738485252d,bottom: 0.3544420320391187d,left: 0.42221496087873067d),
new NpgsqlTypes.NpgsqlBox(top: 0.4779558536018319d,right: 0.748430834131534d,bottom: 0.12364777858072695d,left: 0.1567312043706457d),
new NpgsqlTypes.NpgsqlBox(top: 0.9155917574922217d,right: 0.5793154659792834d,bottom: 0.05468503671082203d,left: 0.4282412945551697d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9403749638219456d,right: 0.766323418929908d,bottom: 0.6875834578575895d,left: 0.5941485291370237d),
new NpgsqlTypes.NpgsqlBox(top: 0.9505766574319652d,right: 0.25215430806784855d,bottom: 0.41545700165945765d,left: 0.20815617022866229d),
new NpgsqlTypes.NpgsqlBox(top: 0.44661638715617713d,right: 0.14375518592991077d,bottom: 0.005139970124911297d,left: 0.04556927342918027d),
new NpgsqlTypes.NpgsqlBox(top: 0.8926727110763621d,right: 0.25571831458542804d,bottom: 0.2836501771411598d,left: 0.07445045376983872d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9486061872249246d,right: 0.8926838498693734d,bottom: 0.2816260397630135d,left: 0.3170249282493284d),
new NpgsqlTypes.NpgsqlBox(top: 0.8762432356769588d,right: 0.7587436455017111d,bottom: 0.242717540682575d,left: 0.6504232170918627d),
new NpgsqlTypes.NpgsqlBox(top: 0.6914965152112401d,right: 0.7264458599907211d,bottom: 0.21080811268293487d,left: 0.25032710279811665d),
new NpgsqlTypes.NpgsqlBox(top: 0.7474285597681514d,right: 0.6029658847827613d,bottom: 0.3547266873702297d,left: 0.4706434954469131d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3614478825532088d,right: 0.6905546829636325d,bottom: 0.09692757083483172d,left: 0.2003909531426733d),
new NpgsqlTypes.NpgsqlBox(top: 0.999893663069663d,right: 0.6522959123587979d,bottom: 0.9014352059094949d,left: 0.5705974972981948d),
new NpgsqlTypes.NpgsqlBox(top: 0.830574554281563d,right: 0.49633790261730837d,bottom: 0.5577451011318878d,left: 0.4344851938231691d),
new NpgsqlTypes.NpgsqlBox(top: 0.6086111795846584d,right: 0.970328442223862d,bottom: 0.10101377797859779d,left: 0.663252688505231d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7823447502587826d,right: 0.7829218816963409d,bottom: 0.4197755583998476d,left: 0.4668658764180349d),
new NpgsqlTypes.NpgsqlBox(top: 0.7976739716468714d,right: 0.861211192997597d,bottom: 0.438872760785455d,left: 0.31938703608236807d),
new NpgsqlTypes.NpgsqlBox(top: 0.4764919922666433d,right: 0.7547190070148702d,bottom: 0.015681578777956062d,left: 0.6682502424761292d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7123965626159419d,right: 0.3862468211489857d,bottom: 0.6650647952605172d,left: 0.38312397613230154d),
new NpgsqlTypes.NpgsqlBox(top: 0.5348738055156909d,right: 0.6809677483595444d,bottom: 0.22693381463395113d,left: 0.27196665827745337d),
new NpgsqlTypes.NpgsqlBox(top: 0.594121418865866d,right: 0.6503246919306324d,bottom: 0.15671358417646708d,left: 0.5920363432888958d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.71240355696618d,right: 0.9582066732869492d,bottom: 0.22437056079768658d,left: 0.2724935164056945d),
new NpgsqlTypes.NpgsqlBox(top: 0.5399414568292771d,right: 0.7350863143448505d,bottom: 0.07040799481421978d,left: 0.17422507834950496d),
new NpgsqlTypes.NpgsqlBox(top: 0.6795165421849689d,right: 0.9805895529039065d,bottom: 0.34234856802103786d,left: 0.8173710517773201d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6066388187959999d,right: 0.5276020460520197d,bottom: 0.04476708143690045d,left: 0.23692287593090455d),
new NpgsqlTypes.NpgsqlBox(top: 0.16036813407535278d,right: 0.8671158451711589d,bottom: 0.15997468903876844d,left: 0.5440656519506782d),
new NpgsqlTypes.NpgsqlBox(top: 0.7235268250257495d,right: 0.9151360812751976d,bottom: 0.3876240687647873d,left: 0.47122824712166544d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8546673098250303d,right: 0.8432654324566534d,bottom: 0.7429424247441497d,left: 0.3487363193061437d),
new NpgsqlTypes.NpgsqlBox(top: 0.6405366902355153d,right: 0.7423236274667163d,bottom: 0.5843208479935599d,left: 0.030697403417720648d),
new NpgsqlTypes.NpgsqlBox(top: 0.9975460802670806d,right: 0.7928702824105985d,bottom: 0.26553981818189054d,left: 0.7590549536176541d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8590381809438635d,right: 0.6978556693254532d,bottom: 0.2774044529921186d,left: 0.3007624113932895d),
new NpgsqlTypes.NpgsqlBox(top: 0.5134038510566927d,right: 0.1888102230405413d,bottom: 0.35742467229068753d,left: 0.02445140509483945d),
new NpgsqlTypes.NpgsqlBox(top: 0.9167560473991333d,right: 0.6907663572699652d,bottom: 0.5835006227201025d,left: 0.18969293008826404d),
new NpgsqlTypes.NpgsqlBox(top: 0.5431662636789829d,right: 0.8298517695428603d,bottom: 0.09865073029755678d,left: 0.4701298484353965d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.920507283804301d,right: 0.6620007821944961d,bottom: 0.5436769881008792d,left: 0.44811140317564635d),
new NpgsqlTypes.NpgsqlBox(top: 0.5006093382352702d,right: 0.6884736419025034d,bottom: 0.1615546439656046d,left: 0.44177082456533256d),
new NpgsqlTypes.NpgsqlBox(top: 0.832130820286185d,right: 0.6067336753109535d,bottom: 0.7981747915242885d,left: 0.09098951642442454d),
new NpgsqlTypes.NpgsqlBox(top: 0.5268644551832594d,right: 0.47264098586855163d,bottom: 0.23024035434774648d,left: 0.31425788049128267d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5030220254520392d,right: 0.943518071077343d,bottom: 0.32158139058870183d,left: 0.7876566491243907d),
new NpgsqlTypes.NpgsqlBox(top: 0.09427738743437386d,right: 0.41574367374875487d,bottom: 0.05408341031968111d,left: 0.4027287797525052d),
new NpgsqlTypes.NpgsqlBox(top: 0.9364680962517152d,right: 0.7610969985298469d,bottom: 0.6452648031738837d,left: 0.6737642501497467d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6623560056340986d,right: 0.996683104158006d,bottom: 0.08877441950252096d,left: 0.2055967426165597d),
new NpgsqlTypes.NpgsqlBox(top: 0.6991362866599637d,right: 0.8761991027444808d,bottom: 0.3373267245912265d,left: 0.36367632161118324d),
new NpgsqlTypes.NpgsqlBox(top: 0.7903644427995674d,right: 0.41085075979135377d,bottom: 0.13582338095946134d,left: 0.21445172553483394d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6957030150598009d,right: 0.29478462685027185d,bottom: 0.2763721836055849d,left: 0.0015321551533448163d),
new NpgsqlTypes.NpgsqlBox(top: 0.5952421534365319d,right: 0.8087651886469952d,bottom: 0.02866911153649976d,left: 0.13625169103764556d),
new NpgsqlTypes.NpgsqlBox(top: 0.09388214986076782d,right: 0.9582707639706792d,bottom: 0.0455436019533777d,left: 0.4949160222621294d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2863311581195339d,right: 0.7291166520663704d,bottom: 0.0023048385813589922d,left: 0.6243731162802971d),
new NpgsqlTypes.NpgsqlBox(top: 0.7220323390424246d,right: 0.5231717851607408d,bottom: 0.6183554190471146d,left: 0.06623921022727108d),
new NpgsqlTypes.NpgsqlBox(top: 0.18904350604205544d,right: 0.3824984813860537d,bottom: 0.08019338983296576d,left: 0.13590868705042214d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 161,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7648622344911051d,right: 0.6565221946504157d,bottom: 0.6799652606990553d,left: 0.4829287810498797d),
new NpgsqlTypes.NpgsqlBox(top: 0.6949834074785379d,right: 0.2650393308708947d,bottom: 0.52115808857485d,left: 0.1151965997940082d),
new NpgsqlTypes.NpgsqlBox(top: 0.7549626048524437d,right: 0.8809775062613897d,bottom: 0.6801662212302112d,left: 0.08945113036147623d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5319512955767269d,right: 0.7077014555663527d,bottom: 0.01762247020493657d,left: 0.34832055005139106d),
new NpgsqlTypes.NpgsqlBox(top: 0.5688560216136551d,right: 0.7918100627891929d,bottom: 0.29378259927365336d,left: 0.40098662110344774d),
new NpgsqlTypes.NpgsqlBox(top: 0.8383659420011217d,right: 0.7906007725188265d,bottom: 0.735357005605521d,left: 0.6099013854010044d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 164,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6013710706356027d,right: 0.5970763732237959d,bottom: 0.5529049829639625d,left: 0.3615946108138385d),
new NpgsqlTypes.NpgsqlBox(top: 0.3997070348521552d,right: 0.6215917440262515d,bottom: 0.07781168286153417d,left: 0.10268313056088874d),
new NpgsqlTypes.NpgsqlBox(top: 0.45048233847657715d,right: 0.8455815365132345d,bottom: 0.40211537316518464d,left: 0.38707470523081355d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9934453001370742d,right: 0.9621006135467794d,bottom: 0.5799066848673153d,left: 0.5079994657433369d),
new NpgsqlTypes.NpgsqlBox(top: 0.9408097505271307d,right: 0.9145111374391366d,bottom: 0.05602202457562089d,left: 0.9105545544644646d),
new NpgsqlTypes.NpgsqlBox(top: 0.8087627877225387d,right: 0.35774874718599403d,bottom: 0.17941471828016664d,left: 0.19048356120121257d),
new NpgsqlTypes.NpgsqlBox(top: 0.854577207387243d,right: 0.5167482514618935d,bottom: 0.18015606148324714d,left: 0.24929396380974644d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 169,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4719003319577304d,right: 0.367027381843539d,bottom: 0.05557654213305496d,left: 0.30598145323309855d),
new NpgsqlTypes.NpgsqlBox(top: 0.5545287568019515d,right: 0.658624706505453d,bottom: 0.30510523782297083d,left: 0.5612234918389073d),
new NpgsqlTypes.NpgsqlBox(top: 0.6178852047091077d,right: 0.9110664467340652d,bottom: 0.10049335428134698d,left: 0.6201731959268946d),
new NpgsqlTypes.NpgsqlBox(top: 0.7198219386248296d,right: 0.6745883262256147d,bottom: 0.11890777044982814d,left: 0.46795566069314254d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4248728808803227d,right: 0.8361915734504803d,bottom: 0.03884098544933823d,left: 0.1468740265229358d),
new NpgsqlTypes.NpgsqlBox(top: 0.9914803317705139d,right: 0.8727166370738202d,bottom: 0.8681261221271602d,left: 0.013747701159232295d),
new NpgsqlTypes.NpgsqlBox(top: 0.7216466860075443d,right: 0.8617665123001053d,bottom: 0.6760410963216463d,left: 0.8533515754113573d),
new NpgsqlTypes.NpgsqlBox(top: 0.378475106558514d,right: 0.9285816963291248d,bottom: 0.01907541277632674d,left: 0.06995361634079433d),
},
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

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9226556207581432d,right: 0.9174654476093158d,bottom: 0.868886778127974d,left: 0.2723095124808661d),
new NpgsqlTypes.NpgsqlBox(top: 0.6835492284615899d,right: 0.9532830199474871d,bottom: 0.48592786889495d,left: 0.80686070841676d),
new NpgsqlTypes.NpgsqlBox(top: 0.672473004794167d,right: 0.5529495996770636d,bottom: 0.5381800602357901d,left: 0.5192440599237823d),
new NpgsqlTypes.NpgsqlBox(top: 0.8593199056015417d,right: 0.976840345451925d,bottom: 0.5908308001881459d,left: 0.45932839806581394d),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7558752635231457d,right: 0.20219911060789897d,bottom: 0.6651310153617561d,left: 0.021842946353843873d),
new NpgsqlTypes.NpgsqlBox(top: 0.4291387752154179d,right: 0.3806941961050695d,bottom: 0.2263784271643784d,left: 0.20612433317560386d),
new NpgsqlTypes.NpgsqlBox(top: 0.592441430137654d,right: 0.8475102638668189d,bottom: 0.23998762109033733d,left: 0.10339933793347211d),
new NpgsqlTypes.NpgsqlBox(top: 0.9003465832284859d,right: 0.34856093252658926d,bottom: 0.21394318493234177d,left: 0.08306493943500437d),
}));
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
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7727141194491677d,right: 0.9631760821657721d,bottom: 0.10233240507604424d,left: 0.27958188328844813d),
new NpgsqlTypes.NpgsqlBox(top: 0.8610114470011611d,right: 0.772748108033433d,bottom: 0.295170365222879d,left: 0.23095117360576578d),
new NpgsqlTypes.NpgsqlBox(top: 0.8253569516000331d,right: 0.9171304154762175d,bottom: 0.14415875387139654d,left: 0.2025363159485103d),
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
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9958077655776021d,right: 0.17300946607839374d,bottom: 0.5000973355588739d,left: 0.13775149961472233d),
new NpgsqlTypes.NpgsqlBox(top: 0.9755341651624674d,right: 0.6092057542009238d,bottom: 0.629732365169791d,left: 0.387004400905686d),
new NpgsqlTypes.NpgsqlBox(top: 0.3375784034826478d,right: 0.5559433130686151d,bottom: 0.06255517080129236d,left: 0.015850440249212783d),
}));
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
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[34], false);
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
                parametr2.Value = 61;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
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
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 124;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
                        Assert.That(models, Has.Count.EqualTo(30));

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
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

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
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[32],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 93, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[34], false);
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
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 91, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 6, query1, 64, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
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
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[34], false);
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
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 20, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
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
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 70, query1, 156, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[34], false);
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
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 66, query1, 66, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
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
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 93, query1, 62, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

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
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[34], false);
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
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 142, query1, 45, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
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
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 39, 31))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

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
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatch(connection, 161, 142))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[34], false);
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
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 82);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[21], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[22], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[23], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[24], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[25], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[26], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[27], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[28], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[29], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[30], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[31], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[32], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[33], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 70);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[20], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[21], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[22], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[23], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[24], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[25], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[26], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[27], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[28], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[29], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[30], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[31], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[32], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[33], false);
                NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[34], false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxArrayboxArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxArrayboxArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(NpgsqlBoxboxArray1M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxArrayboxArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxArrayboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI), typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxArray1MI>();
                var models2 = new List<NpgsqlBoxboxArray1MI>();
                await ((INpgsqlBoxArrayboxArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MI>();
                var models2 = new List<NpgsqlBoxboxArray1MI>();
                ((INpgsqlBoxArrayboxArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxArrayboxArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

