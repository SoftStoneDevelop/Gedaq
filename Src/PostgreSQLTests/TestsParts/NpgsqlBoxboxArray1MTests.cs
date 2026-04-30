

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
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4739118899097954d,right: 0.23336768582155176d,bottom: 0.024029348019444785d,left: 0.17882468696078768d),
new NpgsqlTypes.NpgsqlBox(top: 0.34371825994494043d,right: 0.902194862804781d,bottom: 0.06148905931681825d,left: 0.5862011817637022d),
new NpgsqlTypes.NpgsqlBox(top: 0.9294267315431658d,right: 0.8325233097889323d,bottom: 0.8655934778693042d,left: 0.7867072252887537d),
new NpgsqlTypes.NpgsqlBox(top: 0.377706957145606d,right: 0.4898143484918478d,bottom: 0.2692773019286031d,left: 0.23261005660234302d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8322133822630192d,right: 0.8356966475308761d,bottom: 0.5308883833521904d,left: 0.41336049855623136d),
new NpgsqlTypes.NpgsqlBox(top: 0.5543294031569577d,right: 0.8436171884971394d,bottom: 0.40446303158157415d,left: 0.17834927610848983d),
new NpgsqlTypes.NpgsqlBox(top: 0.7014527909436982d,right: 0.6582831849211103d,bottom: 0.4736692974330813d,left: 0.10469413659948013d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6366395050473731d,right: 0.6774498716085657d,bottom: 0.07848346614954804d,left: 0.5937931392174327d),
new NpgsqlTypes.NpgsqlBox(top: 0.6195583964908724d,right: 0.56899733798235d,bottom: 0.2341898886676731d,left: 0.27632037599320614d),
new NpgsqlTypes.NpgsqlBox(top: 0.7518853394528965d,right: 0.0579632810852726d,bottom: 0.51559789319373d,left: 0.049604268138031316d),
new NpgsqlTypes.NpgsqlBox(top: 0.9611623280541892d,right: 0.9690379422489646d,bottom: 0.6923095419719606d,left: 0.41285551809080145d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7368285030930584d,right: 0.5509327250170843d,bottom: 0.7225745084007339d,left: 0.14610718484315977d),
new NpgsqlTypes.NpgsqlBox(top: 0.8169254407546077d,right: 0.3673858998213828d,bottom: 0.07779621526750424d,left: 0.1351769777221199d),
new NpgsqlTypes.NpgsqlBox(top: 0.4828366896452858d,right: 0.6845212933255053d,bottom: 0.2730721887407741d,left: 0.1935157530016547d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.36417161352092153d,right: 0.9322915338203722d,bottom: 0.09056587543418548d,left: 0.6293278294273297d),
new NpgsqlTypes.NpgsqlBox(top: 0.7182501958637363d,right: 0.5769813222511763d,bottom: 0.14317835749404573d,left: 0.02413137899022899d),
new NpgsqlTypes.NpgsqlBox(top: 0.8996521797739583d,right: 0.8299932381018152d,bottom: 0.4431613175253345d,left: 0.40111916452104146d),
new NpgsqlTypes.NpgsqlBox(top: 0.5752138248236996d,right: 0.7503699723959116d,bottom: 0.23026608256845915d,left: 0.5228100576580097d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4784880324230094d,right: 0.8805044509592649d,bottom: 0.04811681686909752d,left: 0.8599542840515014d),
new NpgsqlTypes.NpgsqlBox(top: 0.8293415721588827d,right: 0.32617516352173137d,bottom: 0.48570092794624764d,left: 0.18517338988196053d),
new NpgsqlTypes.NpgsqlBox(top: 0.22039395200503475d,right: 0.428571748535019d,bottom: 0.1110307098620783d,left: 0.029261536687197887d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8385361704063309d,right: 0.8516906912587539d,bottom: 0.14393719601449162d,left: 0.43933478957909355d),
new NpgsqlTypes.NpgsqlBox(top: 0.6163391252532342d,right: 0.517579961987983d,bottom: 0.04960083611690824d,left: 0.4332906270282688d),
new NpgsqlTypes.NpgsqlBox(top: 0.9535793646691995d,right: 0.20279536911536766d,bottom: 0.519969373059428d,left: 0.11345098516230323d),
new NpgsqlTypes.NpgsqlBox(top: 0.7430498069048002d,right: 0.9611595032861351d,bottom: 0.6563233222102824d,left: 0.7041616218907177d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5814569275095792d,right: 0.8664752158018095d,bottom: 0.0662432516608682d,left: 0.5959505235692216d),
new NpgsqlTypes.NpgsqlBox(top: 0.41480481953363446d,right: 0.9670473723914195d,bottom: 0.3035414875147736d,left: 0.5279999062035791d),
new NpgsqlTypes.NpgsqlBox(top: 0.6976094590547606d,right: 0.8970959188965194d,bottom: 0.42393942334675827d,left: 0.8421250952021947d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6775346450238788d,right: 0.49493644972021056d,bottom: 0.06950255157269347d,left: 0.12237631928356563d),
new NpgsqlTypes.NpgsqlBox(top: 0.9793172372158796d,right: 0.33114190865766213d,bottom: 0.17587568255928698d,left: 0.21854974026499652d),
new NpgsqlTypes.NpgsqlBox(top: 0.5222390761470891d,right: 0.19935291950034095d,bottom: 0.0036639716811368572d,left: 0.04266390450473678d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5808320769091285d,right: 0.39068423073002234d,bottom: 0.06482435560264443d,left: 0.01731251935472744d),
new NpgsqlTypes.NpgsqlBox(top: 0.9708140455814153d,right: 0.60088542206842d,bottom: 0.7368948356648759d,left: 0.00804819643181387d),
new NpgsqlTypes.NpgsqlBox(top: 0.5089592615502663d,right: 0.7084913141825236d,bottom: 0.3795475080777907d,left: 0.4084639177122268d),
new NpgsqlTypes.NpgsqlBox(top: 0.6846127099108679d,right: 0.7811589645146514d,bottom: 0.293823401293559d,left: 0.3961355106543294d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9802698890406581d,right: 0.7385998286442544d,bottom: 0.13109852441705305d,left: 0.3881969016246021d),
new NpgsqlTypes.NpgsqlBox(top: 0.3516667438317935d,right: 0.8521618048164743d,bottom: 0.1588187476502757d,left: 0.3716150633538058d),
new NpgsqlTypes.NpgsqlBox(top: 0.5881158674448342d,right: 0.9780373715826063d,bottom: 0.5264837097352287d,left: 0.6886513262377019d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5438559543652994d,right: 0.3555913627024573d,bottom: 0.17780500700382762d,left: 0.07429454730410978d),
new NpgsqlTypes.NpgsqlBox(top: 0.697304110010877d,right: 0.3561245745907533d,bottom: 0.1907957087876987d,left: 0.3355367959737028d),
new NpgsqlTypes.NpgsqlBox(top: 0.8567222839063703d,right: 0.4945855720399356d,bottom: 0.5368699588502664d,left: 0.38048696903067825d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3082015260090658d,right: 0.5319400951825917d,bottom: 0.1409731453589761d,left: 0.017677226014896297d),
new NpgsqlTypes.NpgsqlBox(top: 0.4156958650759066d,right: 0.10402248182885188d,bottom: 0.35190101435344656d,left: 0.022310979867131597d),
new NpgsqlTypes.NpgsqlBox(top: 0.8066384683779679d,right: 0.9203985964973462d,bottom: 0.1536606344878919d,left: 0.09630131727151625d),
new NpgsqlTypes.NpgsqlBox(top: 0.20490329159704324d,right: 0.682608773956946d,bottom: 0.1166983017076123d,left: 0.44385392354086817d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9282591606076275d,right: 0.9518490302195802d,bottom: 0.05707437957163142d,left: 0.33712204240714116d),
new NpgsqlTypes.NpgsqlBox(top: 0.40195065692444376d,right: 0.8087915702298198d,bottom: 0.02730854085794865d,left: 0.5923023803039883d),
new NpgsqlTypes.NpgsqlBox(top: 0.8975200826339736d,right: 0.08371423079914408d,bottom: 0.4925691814993266d,left: 0.07082306437308228d),
new NpgsqlTypes.NpgsqlBox(top: 0.5633914743891115d,right: 0.8768765428786608d,bottom: 0.02710403596984523d,left: 0.4072410656448917d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4532906100518215d,right: 0.9691111953257734d,bottom: 0.38158339254017126d,left: 0.006477646730044917d),
new NpgsqlTypes.NpgsqlBox(top: 0.8731006725826329d,right: 0.7219366045958866d,bottom: 0.09832962335515849d,left: 0.016815949585022416d),
new NpgsqlTypes.NpgsqlBox(top: 0.7204193157863441d,right: 0.6685090933241618d,bottom: 0.6326598679426696d,left: 0.11673303259164369d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7950892599332574d,right: 0.29380878234959096d,bottom: 0.205406921608837d,left: 0.22169281569371946d),
new NpgsqlTypes.NpgsqlBox(top: 0.9714953499732862d,right: 0.7126815360658082d,bottom: 0.7600915720507528d,left: 0.5933175497584015d),
new NpgsqlTypes.NpgsqlBox(top: 0.9953831852727743d,right: 0.44552863335525195d,bottom: 0.7076380123293441d,left: 0.43456413209865197d),
new NpgsqlTypes.NpgsqlBox(top: 0.8664383025001169d,right: 0.08981506242877635d,bottom: 0.5469345394648231d,left: 0.06587889155891236d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8374785393155956d,right: 0.8576971696033756d,bottom: 0.3092069346172017d,left: 0.5189316493684307d),
new NpgsqlTypes.NpgsqlBox(top: 0.7122968472287343d,right: 0.6937898441810347d,bottom: 0.08620156818726432d,left: 0.09779873640443815d),
new NpgsqlTypes.NpgsqlBox(top: 0.5029958448693391d,right: 0.9958164950366349d,bottom: 0.4790241343592113d,left: 0.1249993587251702d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6879576198892103d,right: 0.5754697940850758d,bottom: 0.6443501368029914d,left: 0.3592590120655621d),
new NpgsqlTypes.NpgsqlBox(top: 0.24846667445750992d,right: 0.32595839083643374d,bottom: 0.030243136909503088d,left: 0.10259092645374046d),
new NpgsqlTypes.NpgsqlBox(top: 0.8329476714373153d,right: 0.49712916711306887d,bottom: 0.5254128251405276d,left: 0.29890313382311684d),
new NpgsqlTypes.NpgsqlBox(top: 0.9216012554659864d,right: 0.9438151882666505d,bottom: 0.5831716913500671d,left: 0.4529260582783994d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.918549521269544d,right: 0.9624052313381356d,bottom: 0.38915796179686246d,left: 0.7145223956497097d),
new NpgsqlTypes.NpgsqlBox(top: 0.7524643277355444d,right: 0.27831137697388353d,bottom: 0.42248634855029144d,left: 0.20368069237483877d),
new NpgsqlTypes.NpgsqlBox(top: 0.5521814062862942d,right: 0.9697228775575183d,bottom: 0.2922868612486842d,left: 0.24154507992275076d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.12516471574860888d,right: 0.9956944990370545d,bottom: 0.02129298901959098d,left: 0.91220987352961d),
new NpgsqlTypes.NpgsqlBox(top: 0.8383528584673812d,right: 0.7664828647336845d,bottom: 0.2794904820012225d,left: 0.4690838178612171d),
new NpgsqlTypes.NpgsqlBox(top: 0.8851691765004687d,right: 0.8579764863035977d,bottom: 0.15962200569152896d,left: 0.08568334027950097d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.38556079950810385d,right: 0.9060004130703674d,bottom: 0.02853892047402684d,left: 0.6402397838183103d),
new NpgsqlTypes.NpgsqlBox(top: 0.6366319521741296d,right: 0.7145442075293258d,bottom: 0.6211922657588517d,left: 0.37652048463477117d),
new NpgsqlTypes.NpgsqlBox(top: 0.25694011304031805d,right: 0.4087321132021682d,bottom: 0.002415333445970669d,left: 0.1142711747752071d),
new NpgsqlTypes.NpgsqlBox(top: 0.4040549901260443d,right: 0.18839021236043685d,bottom: 0.14687359766785657d,left: 0.1185066765115057d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9285913861246908d,right: 0.637742087821499d,bottom: 0.40515867269491235d,left: 0.38846832791607444d),
new NpgsqlTypes.NpgsqlBox(top: 0.8921202633120325d,right: 0.8928126304616429d,bottom: 0.1285614546052094d,left: 0.8725276881156567d),
new NpgsqlTypes.NpgsqlBox(top: 0.8766688762297865d,right: 0.9567537074933883d,bottom: 0.12251018278524883d,left: 0.11806364385155332d),
new NpgsqlTypes.NpgsqlBox(top: 0.7005113295689774d,right: 0.9580596873853382d,bottom: 0.1935160137413119d,left: 0.8554843954547738d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5596447291776504d,right: 0.6355844558960099d,bottom: 0.4087057758393269d,left: 0.08161771236764725d),
new NpgsqlTypes.NpgsqlBox(top: 0.7061021289069174d,right: 0.9521670218273256d,bottom: 0.47771201617977066d,left: 0.6047587668577878d),
new NpgsqlTypes.NpgsqlBox(top: 0.6526483416686035d,right: 0.9552139498863286d,bottom: 0.28102528825167217d,left: 0.8416859722405163d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6108497379433508d,right: 0.6206254553214793d,bottom: 0.29721703883147055d,left: 0.4688385568803217d),
new NpgsqlTypes.NpgsqlBox(top: 0.3775795306342694d,right: 0.8059208977617874d,bottom: 0.19167765126805159d,left: 0.17667154293338283d),
new NpgsqlTypes.NpgsqlBox(top: 0.4067080528802559d,right: 0.6901190074846608d,bottom: 0.01824097147084458d,left: 0.635399541587826d),
new NpgsqlTypes.NpgsqlBox(top: 0.13002094355059102d,right: 0.9622405153539566d,bottom: 0.12980097477899621d,left: 0.8147165138440527d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8512753994393155d,right: 0.8558502178341729d,bottom: 0.07727982446394932d,left: 0.12041628616800626d),
new NpgsqlTypes.NpgsqlBox(top: 0.547107411745406d,right: 0.427005710122499d,bottom: 0.09089591745222558d,left: 0.3068833713242426d),
new NpgsqlTypes.NpgsqlBox(top: 0.9397759822630286d,right: 0.14045927450272533d,bottom: 0.6099210645413679d,left: 0.006717160254884891d),
new NpgsqlTypes.NpgsqlBox(top: 0.57821534981056d,right: 0.7171940727479658d,bottom: 0.41990095358297264d,left: 0.45151554715667785d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5416784418007909d,right: 0.8953309503090641d,bottom: 0.08839522427168967d,left: 0.4512311636964539d),
new NpgsqlTypes.NpgsqlBox(top: 0.8893271354055491d,right: 0.8779915148668334d,bottom: 0.06383782544675187d,left: 0.8704119835960964d),
new NpgsqlTypes.NpgsqlBox(top: 0.6311816786786223d,right: 0.51933185875464d,bottom: 0.24834346024088794d,left: 0.43063573621011086d),
new NpgsqlTypes.NpgsqlBox(top: 0.34316724122134257d,right: 0.5379830874893474d,bottom: 0.03724457551386229d,left: 0.529926210888514d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8949132102448213d,right: 0.7770957000616026d,bottom: 0.6150094790669395d,left: 0.3404391342450932d),
new NpgsqlTypes.NpgsqlBox(top: 0.9392730924731616d,right: 0.8074949814515752d,bottom: 0.09183051703465639d,left: 0.07733828781465935d),
new NpgsqlTypes.NpgsqlBox(top: 0.350262997309702d,right: 0.9822348665601981d,bottom: 0.11262666438140989d,left: 0.33942897470273303d),
new NpgsqlTypes.NpgsqlBox(top: 0.387677939005159d,right: 0.5144306500023168d,bottom: 0.0017902379062585405d,left: 0.38489356036352496d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7657644741091092d,right: 0.8241145368290632d,bottom: 0.3738366190348813d,left: 0.38654656563229806d),
new NpgsqlTypes.NpgsqlBox(top: 0.43540346822504805d,right: 0.42174196956037513d,bottom: 0.2794618403165302d,left: 0.38352208512240415d),
new NpgsqlTypes.NpgsqlBox(top: 0.3798875664664032d,right: 0.5941235943218063d,bottom: 0.04371067713454335d,left: 0.4456631088719145d),
new NpgsqlTypes.NpgsqlBox(top: 0.43569037281268064d,right: 0.424042310221021d,bottom: 0.20921574659758213d,left: 0.21585120371208466d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8766994533292316d,right: 0.47177741791094974d,bottom: 0.022176483654900103d,left: 0.16451669427267923d),
new NpgsqlTypes.NpgsqlBox(top: 0.5291557781070337d,right: 0.23891986082989136d,bottom: 0.26108096857871543d,left: 0.020607299237816346d),
new NpgsqlTypes.NpgsqlBox(top: 0.7500076945625765d,right: 0.886893107814591d,bottom: 0.6287697747587969d,left: 0.30678015644065126d),
new NpgsqlTypes.NpgsqlBox(top: 0.6520112032195673d,right: 0.5674372174075477d,bottom: 0.48899379563527534d,left: 0.2710064410628147d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5283768453502943d,right: 0.5083427823873667d,bottom: 0.12472402990182152d,left: 0.22670917075448538d),
new NpgsqlTypes.NpgsqlBox(top: 0.9892777223024659d,right: 0.6987048032815103d,bottom: 0.9848640431141137d,left: 0.5005855559797309d),
new NpgsqlTypes.NpgsqlBox(top: 0.44684836003301664d,right: 0.8174740670714387d,bottom: 0.3864687139005941d,left: 0.3007090811908716d),
new NpgsqlTypes.NpgsqlBox(top: 0.7651459096008292d,right: 0.5183881118272194d,bottom: 0.5615735544372097d,left: 0.36186101761800027d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9918859489523805d,right: 0.9545790621844542d,bottom: 0.3408153556229516d,left: 0.1260286853818341d),
new NpgsqlTypes.NpgsqlBox(top: 0.9063394235963578d,right: 0.6917058954930454d,bottom: 0.6973346459709293d,left: 0.07387984332373998d),
new NpgsqlTypes.NpgsqlBox(top: 0.32814323680372726d,right: 0.7742192400579929d,bottom: 0.31127038315977684d,left: 0.36047061789624857d),
new NpgsqlTypes.NpgsqlBox(top: 0.6990179494456398d,right: 0.43807566951296684d,bottom: 0.4912173531287308d,left: 0.3565504867692112d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.838755306570079d,right: 0.5237803830724377d,bottom: 0.004141903881659248d,left: 0.38075962571265975d),
new NpgsqlTypes.NpgsqlBox(top: 0.8703921659392664d,right: 0.6803978305337904d,bottom: 0.6427963497053171d,left: 0.2733497412341709d),
new NpgsqlTypes.NpgsqlBox(top: 0.7233523634986605d,right: 0.3630764782401994d,bottom: 0.6020841068499929d,left: 0.06955020106098087d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.548854360693857d,right: 0.45181791224360424d,bottom: 0.34112083445244235d,left: 0.21853727889373442d),
new NpgsqlTypes.NpgsqlBox(top: 0.7716409363975619d,right: 0.9335304552263641d,bottom: 0.2582709648991467d,left: 0.6332983876041095d),
new NpgsqlTypes.NpgsqlBox(top: 0.4485205296848166d,right: 0.679083041442607d,bottom: 0.21832474468975016d,left: 0.1272367671010527d),
new NpgsqlTypes.NpgsqlBox(top: 0.9517826699680456d,right: 0.08162125737934767d,bottom: 0.5719964053349748d,left: 0.025899108319162756d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2994558272227227d,right: 0.6534276534381743d,bottom: 0.2210446293369812d,left: 0.525395381207354d),
new NpgsqlTypes.NpgsqlBox(top: 0.7595834264373947d,right: 0.44206140372935465d,bottom: 0.4651127303816387d,left: 0.42884097462492043d),
new NpgsqlTypes.NpgsqlBox(top: 0.7391264525026158d,right: 0.8499806555366867d,bottom: 0.6478241129061832d,left: 0.31265235509993816d),
new NpgsqlTypes.NpgsqlBox(top: 0.8670443956271281d,right: 0.640095246926165d,bottom: 0.5498571558495322d,left: 0.5363621647804351d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6033035081774343d,right: 0.9859050096963232d,bottom: 0.17331783906733067d,left: 0.25404333194951534d),
new NpgsqlTypes.NpgsqlBox(top: 0.9233210342363369d,right: 0.38604356681151086d,bottom: 0.12735536624377553d,left: 0.23034945054422518d),
new NpgsqlTypes.NpgsqlBox(top: 0.635826150718056d,right: 0.6508421674839379d,bottom: 0.629003172840945d,left: 0.3883104790324102d),
new NpgsqlTypes.NpgsqlBox(top: 0.9621852056348744d,right: 0.9651373201097216d,bottom: 0.4968537634220731d,left: 0.16015314766536626d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7517961250754649d,right: 0.935864361744013d,bottom: 0.5369677803773213d,left: 0.1664891375984191d),
new NpgsqlTypes.NpgsqlBox(top: 0.9717271666144232d,right: 0.508041126238494d,bottom: 0.04185939974485531d,left: 0.3443953623406554d),
new NpgsqlTypes.NpgsqlBox(top: 0.7505550168341281d,right: 0.8509391965123486d,bottom: 0.6408113498676586d,left: 0.719422412796051d),
new NpgsqlTypes.NpgsqlBox(top: 0.7802067009841632d,right: 0.70759602166088d,bottom: 0.0220995522542472d,left: 0.2842975874404441d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9196380955037406d,right: 0.2717766784188024d,bottom: 0.4037312293125067d,left: 0.2379501772038879d),
new NpgsqlTypes.NpgsqlBox(top: 0.2778591386064554d,right: 0.9620884722680428d,bottom: 0.1850957344334625d,left: 0.11063731566982771d),
new NpgsqlTypes.NpgsqlBox(top: 0.3708765765316978d,right: 0.6594134743656758d,bottom: 0.09712842118794118d,left: 0.5006420864291496d),
new NpgsqlTypes.NpgsqlBox(top: 0.822637370141379d,right: 0.3097331554793432d,bottom: 0.20529788103494284d,left: 0.29377423904924793d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.969259180884231d,right: 0.6378476068742502d,bottom: 0.5543123240269313d,left: 0.537388199893261d),
new NpgsqlTypes.NpgsqlBox(top: 0.7333448261870865d,right: 0.8468338464412788d,bottom: 0.588979611575824d,left: 0.4501228205255583d),
new NpgsqlTypes.NpgsqlBox(top: 0.5335923359654364d,right: 0.31076289669128243d,bottom: 0.3754772309342661d,left: 0.24119026835727309d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.42439009445115716d,right: 0.4114380042301464d,bottom: 0.2119741296922536d,left: 0.22000399939605375d),
new NpgsqlTypes.NpgsqlBox(top: 0.5855825928219637d,right: 0.8897801086166445d,bottom: 0.44508272452994546d,left: 0.5845862218389875d),
new NpgsqlTypes.NpgsqlBox(top: 0.9141048166008984d,right: 0.912239853637669d,bottom: 0.65457338260269d,left: 0.11179803264573063d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7058790236879536d,right: 0.9181042724783683d,bottom: 0.6177446335793567d,left: 0.6681708290393665d),
new NpgsqlTypes.NpgsqlBox(top: 0.9077924890210558d,right: 0.780928094227486d,bottom: 0.7471672727396544d,left: 0.2491409636089683d),
new NpgsqlTypes.NpgsqlBox(top: 0.8531068818781109d,right: 0.6702947606147771d,bottom: 0.5410828046104866d,left: 0.47574877637401913d),
new NpgsqlTypes.NpgsqlBox(top: 0.670463232837626d,right: 0.5292830675849299d,bottom: 0.16832746614822858d,left: 0.22624414888742117d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7701425897933443d,right: 0.8225248313466352d,bottom: 0.13563511366297698d,left: 0.39511405986010184d),
new NpgsqlTypes.NpgsqlBox(top: 0.5719610869653927d,right: 0.7923864716021224d,bottom: 0.33742162881851523d,left: 0.09263512661942519d),
new NpgsqlTypes.NpgsqlBox(top: 0.5119388900035544d,right: 0.4497999764441566d,bottom: 0.1511861470305158d,left: 0.03085004057196039d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7971725295452192d,right: 0.41338037400701855d,bottom: 0.21522426864204713d,left: 0.0027977701185648574d),
new NpgsqlTypes.NpgsqlBox(top: 0.9808637484178011d,right: 0.9472754693137835d,bottom: 0.5479646593877533d,left: 0.2402993672106174d),
new NpgsqlTypes.NpgsqlBox(top: 0.790564527812834d,right: 0.5338769159265276d,bottom: 0.4840536525928497d,left: 0.46701289203244367d),
new NpgsqlTypes.NpgsqlBox(top: 0.6449568804656851d,right: 0.6322589369946657d,bottom: 0.12828736175045719d,left: 0.6221267023874233d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5372568930810578d,right: 0.9723311963363211d,bottom: 0.4088698423048479d,left: 0.413855491153195d),
new NpgsqlTypes.NpgsqlBox(top: 0.9666228883963394d,right: 0.987669868716191d,bottom: 0.680803745163886d,left: 0.8621537641323008d),
new NpgsqlTypes.NpgsqlBox(top: 0.45380938854535513d,right: 0.25621239107710836d,bottom: 0.3051439208679112d,left: 0.12897453718974117d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7965026619710389d,right: 0.9497018880851483d,bottom: 0.5242250107968986d,left: 0.17988782804032843d),
new NpgsqlTypes.NpgsqlBox(top: 0.5843968035549857d,right: 0.7818365851207203d,bottom: 0.1456823395477288d,left: 0.36486945159697093d),
new NpgsqlTypes.NpgsqlBox(top: 0.5962336505446454d,right: 0.3842730694599308d,bottom: 0.3464213291396311d,left: 0.24973901533005782d),
new NpgsqlTypes.NpgsqlBox(top: 0.6898898022486993d,right: 0.4838813900962772d,bottom: 0.5437973809831416d,left: 0.11738608074431811d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8993469449276521d,right: 0.38677788479943664d,bottom: 0.22607689809105014d,left: 0.19379008920713603d),
new NpgsqlTypes.NpgsqlBox(top: 0.984471542884513d,right: 0.6729829754406169d,bottom: 0.6006905365795939d,left: 0.23145939736950627d),
new NpgsqlTypes.NpgsqlBox(top: 0.5247326227570699d,right: 0.27000997973648144d,bottom: 0.5209323361659938d,left: 0.23213000613516588d),
new NpgsqlTypes.NpgsqlBox(top: 0.48668747967939174d,right: 0.4587228592016054d,bottom: 0.2646951454984946d,left: 0.13080399474925986d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.835593684550916d,right: 0.8563733054221166d,bottom: 0.20098865227869223d,left: 0.47107149414604854d),
new NpgsqlTypes.NpgsqlBox(top: 0.9665415235583193d,right: 0.6629005429394974d,bottom: 0.09418539302672924d,left: 0.655240627354273d),
new NpgsqlTypes.NpgsqlBox(top: 0.32368020434600653d,right: 0.04690874868087325d,bottom: 0.028453934418102844d,left: 0.024773781752314372d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8267368434199158d,right: 0.9755353542692209d,bottom: 0.0881844466959365d,left: 0.39171989398323925d),
new NpgsqlTypes.NpgsqlBox(top: 0.8937372207028798d,right: 0.822284784699728d,bottom: 0.8430417471358879d,left: 0.2766959613343676d),
new NpgsqlTypes.NpgsqlBox(top: 0.7762151674062878d,right: 0.5672879782472259d,bottom: 0.12957264548956493d,left: 0.1493278282522863d),
new NpgsqlTypes.NpgsqlBox(top: 0.8222195429742859d,right: 0.6083316984922287d,bottom: 0.5632499696285549d,left: 0.5029040836764724d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8205031085342944d,right: 0.9619126764391018d,bottom: 0.2041166928488185d,left: 0.6085451324293355d),
new NpgsqlTypes.NpgsqlBox(top: 0.5174753774356945d,right: 0.3541806492319638d,bottom: 0.3072918171946951d,left: 0.2671745819726439d),
new NpgsqlTypes.NpgsqlBox(top: 0.6780006714763825d,right: 0.7916893291734841d,bottom: 0.03921511512009912d,left: 0.28709272024656884d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.22833092944080247d,right: 0.8364809285830501d,bottom: 0.017270174321674214d,left: 0.5026826341659139d),
new NpgsqlTypes.NpgsqlBox(top: 0.6201324451515172d,right: 0.3221504473356124d,bottom: 0.05516412033955698d,left: 0.047223575721321964d),
new NpgsqlTypes.NpgsqlBox(top: 0.4898428760631208d,right: 0.541772727171036d,bottom: 0.17309401864717266d,left: 0.43452914135452403d),
new NpgsqlTypes.NpgsqlBox(top: 0.984819365412355d,right: 0.6661147678385105d,bottom: 0.8803676560613907d,left: 0.28687099051890796d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9245526661364709d,right: 0.9115445229149584d,bottom: 0.2704246386278133d,left: 0.17031210674065567d),
new NpgsqlTypes.NpgsqlBox(top: 0.671797062182786d,right: 0.6041168576933829d,bottom: 0.2806268608616259d,left: 0.35802018307389427d),
new NpgsqlTypes.NpgsqlBox(top: 0.17293514588090397d,right: 0.3481643907523809d,bottom: 0.05206810332871137d,left: 0.1551186681919624d),
new NpgsqlTypes.NpgsqlBox(top: 0.5491551170330258d,right: 0.8331161009841261d,bottom: 0.2668853378833097d,left: 0.5294064710318223d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7963802449039286d,right: 0.6176217679288243d,bottom: 0.17640592804438326d,left: 0.4639993650216111d),
new NpgsqlTypes.NpgsqlBox(top: 0.8026953064408785d,right: 0.2599677029880856d,bottom: 0.6474118936020358d,left: 0.1365758436185195d),
new NpgsqlTypes.NpgsqlBox(top: 0.9884774517347161d,right: 0.3802966700151271d,bottom: 0.24076389021246358d,left: 0.08547949831233592d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.531994247616971d,right: 0.5730901661639327d,bottom: 0.4736239498039677d,left: 0.1914017728955245d),
new NpgsqlTypes.NpgsqlBox(top: 0.403210687680046d,right: 0.25324146413493465d,bottom: 0.03051002531906999d,left: 0.015084483658682979d),
new NpgsqlTypes.NpgsqlBox(top: 0.6132018135866288d,right: 0.8929271383808325d,bottom: 0.35306674322587606d,left: 0.4781621447915275d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9879683317931743d,right: 0.26367653021375315d,bottom: 0.7094317502990075d,left: 0.16995838781824657d),
new NpgsqlTypes.NpgsqlBox(top: 0.9757748401530038d,right: 0.9739069703685992d,bottom: 0.26421967027574433d,left: 0.0814375038145746d),
new NpgsqlTypes.NpgsqlBox(top: 0.9632664726817939d,right: 0.8405552721842996d,bottom: 0.1711480179640802d,left: 0.7676557565795794d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9757890779706332d,right: 0.6916745004117523d,bottom: 0.23435827697097d,left: 0.1567850655349935d),
new NpgsqlTypes.NpgsqlBox(top: 0.4579420355656657d,right: 0.8897041524607208d,bottom: 0.2184013190904721d,left: 0.6486252201569802d),
new NpgsqlTypes.NpgsqlBox(top: 0.985996909088041d,right: 0.3779075061398328d,bottom: 0.8913255173470962d,left: 0.1591029794028722d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8833275043860664d,right: 0.9391930259820656d,bottom: 0.009720902652101682d,left: 0.16601715980125242d),
new NpgsqlTypes.NpgsqlBox(top: 0.33703524530902096d,right: 0.6605342846436086d,bottom: 0.034896978912841936d,left: 0.1647255459936342d),
new NpgsqlTypes.NpgsqlBox(top: 0.6538629873190106d,right: 0.824302127682675d,bottom: 0.48397748103343974d,left: 0.43349116464768145d),
new NpgsqlTypes.NpgsqlBox(top: 0.4900782261212122d,right: 0.9633703996885916d,bottom: 0.32206057607070404d,left: 0.8981658677926325d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.785964186139786d,right: 0.8301392378319771d,bottom: 0.24701256815393402d,left: 0.5333981424303943d),
new NpgsqlTypes.NpgsqlBox(top: 0.61591976280092d,right: 0.9131797997818013d,bottom: 0.5534670011646033d,left: 0.33072192552142465d),
new NpgsqlTypes.NpgsqlBox(top: 0.37397477188001105d,right: 0.9409612013399362d,bottom: 0.1245236913473633d,left: 0.6405416618436474d),
new NpgsqlTypes.NpgsqlBox(top: 0.3890522153389695d,right: 0.9984163272609722d,bottom: 0.17050482440356174d,left: 0.009778536433182272d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.923026880925182d,right: 0.42254945810906896d,bottom: 0.26571120806308746d,left: 0.1711426722431778d),
new NpgsqlTypes.NpgsqlBox(top: 0.6422610031731432d,right: 0.963261118126738d,bottom: 0.33619476803139103d,left: 0.050537561706961d),
new NpgsqlTypes.NpgsqlBox(top: 0.9928286511588154d,right: 0.3686797370671431d,bottom: 0.8259908684608271d,left: 0.08426084687771729d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9626677823051079d,right: 0.413599300605909d,bottom: 0.17143750434271465d,left: 0.39395409309122065d),
new NpgsqlTypes.NpgsqlBox(top: 0.9099044555586889d,right: 0.9199312112399234d,bottom: 0.4305800429134061d,left: 0.45238792409085826d),
new NpgsqlTypes.NpgsqlBox(top: 0.7391082976616458d,right: 0.5584633919886786d,bottom: 0.7143064865400587d,left: 0.11023724273387092d),
new NpgsqlTypes.NpgsqlBox(top: 0.592858112015879d,right: 0.9402687439128626d,bottom: 0.45506784692258895d,left: 0.17893305128536385d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6859390906872311d,right: 0.3153413701374659d,bottom: 0.2435227641983605d,left: 0.27756388218484196d),
new NpgsqlTypes.NpgsqlBox(top: 0.7282468352761983d,right: 0.9070050236065829d,bottom: 0.47047498747037186d,left: 0.013885755575243852d),
new NpgsqlTypes.NpgsqlBox(top: 0.8053234584394211d,right: 0.36111044634376566d,bottom: 0.3091588238718622d,left: 0.13514516072844251d),
new NpgsqlTypes.NpgsqlBox(top: 0.8046391843651247d,right: 0.45717964207164374d,bottom: 0.22510494478048226d,left: 0.02513026995836276d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7299647327717149d,right: 0.908732798384759d,bottom: 0.7076952356080348d,left: 0.5581708552660525d),
new NpgsqlTypes.NpgsqlBox(top: 0.8978922143018504d,right: 0.652071729118263d,bottom: 0.7878168365044167d,left: 0.14842693819507757d),
new NpgsqlTypes.NpgsqlBox(top: 0.41060503195757625d,right: 0.6125629987906468d,bottom: 0.08091017148617952d,left: 0.39223340507707005d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.49398025672486146d,right: 0.9805421035605169d,bottom: 0.31762467096328584d,left: 0.12128515903862913d),
new NpgsqlTypes.NpgsqlBox(top: 0.290162348792222d,right: 0.17201977903019472d,bottom: 0.09050438309227238d,left: 0.1380494365818704d),
new NpgsqlTypes.NpgsqlBox(top: 0.6407077482167924d,right: 0.6364499521092029d,bottom: 0.11192039264839782d,left: 0.3349210606471199d),
new NpgsqlTypes.NpgsqlBox(top: 0.9709630376469651d,right: 0.6722418586127245d,bottom: 0.5859359204045921d,left: 0.6392317702498305d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6062424627087232d,right: 0.7754967692749566d,bottom: 0.4195843132220146d,left: 0.5968525320161887d),
new NpgsqlTypes.NpgsqlBox(top: 0.31636681430773395d,right: 0.917351962476187d,bottom: 0.09425067148289867d,left: 0.8348841371393282d),
new NpgsqlTypes.NpgsqlBox(top: 0.285169390994921d,right: 0.35734283881855344d,bottom: 0.07828588192815522d,left: 0.06290439824338079d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.13244154788924634d,right: 0.6846976522452732d,bottom: 0.010118514967316306d,left: 0.245212539992669d),
new NpgsqlTypes.NpgsqlBox(top: 0.44726433139952737d,right: 0.3478200894142466d,bottom: 0.0031888125433524594d,left: 0.2966022237660796d),
new NpgsqlTypes.NpgsqlBox(top: 0.7617009167596827d,right: 0.40066142638706237d,bottom: 0.44285140272826407d,left: 0.17538934953418728d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6529228128036357d,right: 0.7583830712336017d,bottom: 0.2094736034538066d,left: 0.49239288541367054d),
new NpgsqlTypes.NpgsqlBox(top: 0.0772403968608193d,right: 0.6524846303074894d,bottom: 0.038981544428745796d,left: 0.606098153819272d),
new NpgsqlTypes.NpgsqlBox(top: 0.9509721377489132d,right: 0.9085344679300222d,bottom: 0.34808416995385005d,left: 0.26127883407811126d),
new NpgsqlTypes.NpgsqlBox(top: 0.8375933642145124d,right: 0.7398997739637442d,bottom: 0.04452897301908654d,left: 0.43454932459691165d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9277548651846673d,right: 0.7269794554626295d,bottom: 0.4256338182613767d,left: 0.7052799669086575d),
new NpgsqlTypes.NpgsqlBox(top: 0.7984392645452444d,right: 0.9739039539195273d,bottom: 0.6895316264346247d,left: 0.057644630649755446d),
new NpgsqlTypes.NpgsqlBox(top: 0.9123701866045906d,right: 0.6913304669585951d,bottom: 0.19362229727417335d,left: 0.5193360829117012d),
new NpgsqlTypes.NpgsqlBox(top: 0.6141467706262415d,right: 0.5493419358745013d,bottom: 0.4837344054432807d,left: 0.08093949382158483d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4074050248677238d,right: 0.6814071897734264d,bottom: 0.32673233793785583d,left: 0.19778575148653632d),
new NpgsqlTypes.NpgsqlBox(top: 0.47992694208112696d,right: 0.9128718241706753d,bottom: 0.2921551079381961d,left: 0.40388637720197396d),
new NpgsqlTypes.NpgsqlBox(top: 0.9120170389489489d,right: 0.713097943061008d,bottom: 0.6480048488726848d,left: 0.3048655607107742d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7311539197329987d,right: 0.9275314842088014d,bottom: 0.7192643801541243d,left: 0.43297409755962957d),
new NpgsqlTypes.NpgsqlBox(top: 0.6180919463375997d,right: 0.9670496389412915d,bottom: 0.36744714042443904d,left: 0.5563643689273939d),
new NpgsqlTypes.NpgsqlBox(top: 0.8961619982995662d,right: 0.528424098331817d,bottom: 0.2807298754943667d,left: 0.2642084892084967d),
new NpgsqlTypes.NpgsqlBox(top: 0.9231329909152579d,right: 0.9455479973534594d,bottom: 0.40340126953899835d,left: 0.8035941578563774d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.796285203067911d,right: 0.9668523639534913d,bottom: 0.41066106406451786d,left: 0.160625501263446d),
new NpgsqlTypes.NpgsqlBox(top: 0.6456741372747258d,right: 0.8791951539910281d,bottom: 0.2151627083512837d,left: 0.30223292628494014d),
new NpgsqlTypes.NpgsqlBox(top: 0.5186804520753852d,right: 0.8008241987668826d,bottom: 0.46657045217717774d,left: 0.6894161583277d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4942371287429196d,right: 0.46724010573493313d,bottom: 0.3061317917166462d,left: 0.11547389313157197d),
new NpgsqlTypes.NpgsqlBox(top: 0.8659104333146594d,right: 0.11809322027972069d,bottom: 0.17518555823220006d,left: 0.02660469051926595d),
new NpgsqlTypes.NpgsqlBox(top: 0.6949939126582285d,right: 0.23787904734137333d,bottom: 0.5807445259978447d,left: 0.07398303411076468d),
new NpgsqlTypes.NpgsqlBox(top: 0.8682283362300166d,right: 0.7706084802291232d,bottom: 0.009198752828928902d,left: 0.5240500575119992d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9202570932903514d,right: 0.7248004389791323d,bottom: 0.08098129846402369d,left: 0.6192536808979144d),
new NpgsqlTypes.NpgsqlBox(top: 0.9748352109229086d,right: 0.11946455320044569d,bottom: 0.962903235913409d,left: 0.023952524938308906d),
new NpgsqlTypes.NpgsqlBox(top: 0.6386920361436794d,right: 0.11174788761520627d,bottom: 0.4379141300795504d,left: 0.014600325985410167d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9665291581327541d,right: 0.011614608762114731d,bottom: 0.9194757683851932d,left: 7.285494176967333E-05d),
new NpgsqlTypes.NpgsqlBox(top: 0.8872266782847679d,right: 0.7245964814310709d,bottom: 0.4999672145328674d,left: 0.70046173584354d),
new NpgsqlTypes.NpgsqlBox(top: 0.8389396106617669d,right: 0.7627948633689126d,bottom: 0.5910723669654402d,left: 0.5576281228545694d),
new NpgsqlTypes.NpgsqlBox(top: 0.8538937149811637d,right: 0.7978502565811555d,bottom: 0.6590631416557149d,left: 0.10129777608798596d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6820800402133597d,right: 0.7111874366122394d,bottom: 0.5611226835171983d,left: 0.0820484476026282d),
new NpgsqlTypes.NpgsqlBox(top: 0.6354331325674648d,right: 0.8837687486067314d,bottom: 0.3167223581316818d,left: 0.03068479298491611d),
new NpgsqlTypes.NpgsqlBox(top: 0.38214783577467637d,right: 0.3146574725604896d,bottom: 0.09912803727397268d,left: 0.029814051326744972d),
new NpgsqlTypes.NpgsqlBox(top: 0.935393130395736d,right: 0.8975077276713067d,bottom: 0.4187435789411704d,left: 0.35505506336911274d),
},
    NullableValue = null,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9802698890406581d,right: 0.7385998286442544d,bottom: 0.13109852441705305d,left: 0.3881969016246021d),
new NpgsqlTypes.NpgsqlBox(top: 0.3516667438317935d,right: 0.8521618048164743d,bottom: 0.1588187476502757d,left: 0.3716150633538058d),
new NpgsqlTypes.NpgsqlBox(top: 0.5881158674448342d,right: 0.9780373715826063d,bottom: 0.5264837097352287d,left: 0.6886513262377019d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4532906100518215d,right: 0.9691111953257734d,bottom: 0.38158339254017126d,left: 0.006477646730044917d),
new NpgsqlTypes.NpgsqlBox(top: 0.8731006725826329d,right: 0.7219366045958866d,bottom: 0.09832962335515849d,left: 0.016815949585022416d),
new NpgsqlTypes.NpgsqlBox(top: 0.7204193157863441d,right: 0.6685090933241618d,bottom: 0.6326598679426696d,left: 0.11673303259164369d),
}));
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
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8374785393155956d,right: 0.8576971696033756d,bottom: 0.3092069346172017d,left: 0.5189316493684307d),
new NpgsqlTypes.NpgsqlBox(top: 0.7122968472287343d,right: 0.6937898441810347d,bottom: 0.08620156818726432d,left: 0.09779873640443815d),
new NpgsqlTypes.NpgsqlBox(top: 0.5029958448693391d,right: 0.9958164950366349d,bottom: 0.4790241343592113d,left: 0.1249993587251702d),
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
                Assert.That(nullable, Is.Null);
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
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8512753994393155d,right: 0.8558502178341729d,bottom: 0.07727982446394932d,left: 0.12041628616800626d),
new NpgsqlTypes.NpgsqlBox(top: 0.547107411745406d,right: 0.427005710122499d,bottom: 0.09089591745222558d,left: 0.3068833713242426d),
new NpgsqlTypes.NpgsqlBox(top: 0.9397759822630286d,right: 0.14045927450272533d,bottom: 0.6099210645413679d,left: 0.006717160254884891d),
new NpgsqlTypes.NpgsqlBox(top: 0.57821534981056d,right: 0.7171940727479658d,bottom: 0.41990095358297264d,left: 0.45151554715667785d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5283768453502943d,right: 0.5083427823873667d,bottom: 0.12472402990182152d,left: 0.22670917075448538d),
new NpgsqlTypes.NpgsqlBox(top: 0.9892777223024659d,right: 0.6987048032815103d,bottom: 0.9848640431141137d,left: 0.5005855559797309d),
new NpgsqlTypes.NpgsqlBox(top: 0.44684836003301664d,right: 0.8174740670714387d,bottom: 0.3864687139005941d,left: 0.3007090811908716d),
new NpgsqlTypes.NpgsqlBox(top: 0.7651459096008292d,right: 0.5183881118272194d,bottom: 0.5615735544372097d,left: 0.36186101761800027d),
}));
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 8;
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[29], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[29], false);
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
                parametr1.Value = 8;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
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
                parametr1.Value = 83;
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[29], false);
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
                parametr1.Value = 8;
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
                        Assert.That(models, Has.Count.EqualTo(28));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

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
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 24, query1, 64, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
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
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 60, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[29], false);
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
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 110, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
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
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 89, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 68, query1, 86, query2))
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[29], false);
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
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 89, query1, 70, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 24, query1, 35, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[29], false);
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
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 18, query1, 3, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
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
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[28],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 83, 66))
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatch(connection, 86, 18))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[29], false);
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
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[2], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[3], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[4], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[5], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[6], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[7], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 64);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[29], false);
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 0; i < 6; i++)
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectImportModelInnerAsync(connection);
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

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 4; i < 10; i++)
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectImportModelInner(connection);
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxArrayboxArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlBoxboxArray1MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxArrayboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
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

