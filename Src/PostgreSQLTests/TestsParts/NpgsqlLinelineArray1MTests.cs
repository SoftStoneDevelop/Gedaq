

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
    internal partial interface INpgsqlLineArraylineArray
    {
    }
    
    internal partial class NpgsqlLineArraylineArray : INpgsqlLineArraylineArray
    {


#region TestData

        private readonly NpgsqlLinelineArray1M[] _testData = new NpgsqlLinelineArray1M[]
        {
            new NpgsqlLinelineArray1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7507094876006435d, b: 0.7592307528532463d, c: 0.28799041124919955d),
new NpgsqlTypes.NpgsqlLine(a: 0.4673281617493088d, b: 0.2568011066198571d, c: 0.060161560306224104d),
new NpgsqlTypes.NpgsqlLine(a: 0.21689785904414893d, b: 0.4699730078680898d, c: 0.5902555969909562d),
new NpgsqlTypes.NpgsqlLine(a: 0.02329866879413567d, b: 0.5703162890701803d, c: 0.7272495827003054d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.74098563389531d, b: 0.2578220365344691d, c: 0.01694379980326899d),
new NpgsqlTypes.NpgsqlLine(a: 0.5501989950289035d, b: 0.34010119944807393d, c: 0.3498034269153045d),
new NpgsqlTypes.NpgsqlLine(a: 0.8698612345903837d, b: 0.19811011165423298d, c: 0.17642909364865889d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.821560475034174d, b: 0.6205493116101898d, c: 0.5592296346834817d),
new NpgsqlTypes.NpgsqlLine(a: 0.3919081294672738d, b: 0.106420257296156d, c: 0.11922090421180565d),
new NpgsqlTypes.NpgsqlLine(a: 0.4222653924908679d, b: 0.6155361680274254d, c: 0.7784129710504722d),
new NpgsqlTypes.NpgsqlLine(a: 0.45007302135952765d, b: 0.6285004388156991d, c: 0.7265039107565793d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7053817458471945d, b: 0.8459708301885245d, c: 0.9643560918788147d),
new NpgsqlTypes.NpgsqlLine(a: 0.03185118743895432d, b: 0.007937649191883d, c: 0.4738797126216474d),
new NpgsqlTypes.NpgsqlLine(a: 0.5261712661724035d, b: 0.032048421805589755d, c: 0.15428229077338562d),
new NpgsqlTypes.NpgsqlLine(a: 0.1859607592118967d, b: 0.07359535742988188d, c: 0.4606189336659856d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5515919141868928d, b: 0.8055287963777154d, c: 0.6774689324683342d),
new NpgsqlTypes.NpgsqlLine(a: 0.24760706507010855d, b: 0.9487507969474182d, c: 0.4350908668651178d),
new NpgsqlTypes.NpgsqlLine(a: 0.14609180468293392d, b: 0.9684434238547373d, c: 0.504484095597122d),
new NpgsqlTypes.NpgsqlLine(a: 0.9747805475124238d, b: 0.4773789628473818d, c: 0.09907933312206108d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2566709456088129d, b: 0.7890481464928624d, c: 0.680631475110813d),
new NpgsqlTypes.NpgsqlLine(a: 0.4043035696259376d, b: 0.3527294523239547d, c: 0.001123584883003792d),
new NpgsqlTypes.NpgsqlLine(a: 0.7114152449176706d, b: 0.5309636373581604d, c: 0.9266098586099759d),
new NpgsqlTypes.NpgsqlLine(a: 0.5550208822664601d, b: 0.013516843957313895d, c: 0.4600734504391961d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04888965989298322d, b: 0.051858270990943534d, c: 0.20308347616870126d),
new NpgsqlTypes.NpgsqlLine(a: 0.2618647954330121d, b: 0.7303788177034648d, c: 0.3285263409207221d),
new NpgsqlTypes.NpgsqlLine(a: 0.30157932884472916d, b: 0.5772525196252933d, c: 0.961826529455776d),
new NpgsqlTypes.NpgsqlLine(a: 0.9197540172485695d, b: 0.155829270510632d, c: 0.47855629217557205d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19353694001669808d, b: 0.26764625397379915d, c: 0.8989830967324194d),
new NpgsqlTypes.NpgsqlLine(a: 0.6621104496341826d, b: 0.05356541351276334d, c: 0.404774336820536d),
new NpgsqlTypes.NpgsqlLine(a: 0.7588654955864501d, b: 0.1356328289534331d, c: 0.10341584974474483d),
new NpgsqlTypes.NpgsqlLine(a: 0.5213317950339297d, b: 0.9809598941013926d, c: 0.35606767175433285d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8421193984771114d, b: 0.3574909641437556d, c: 0.18287867019505843d),
new NpgsqlTypes.NpgsqlLine(a: 0.06632620818965007d, b: 0.08300032682150016d, c: 0.08648581106632924d),
new NpgsqlTypes.NpgsqlLine(a: 0.5133677811573429d, b: 0.514154362744827d, c: 0.006710681453198641d),
new NpgsqlTypes.NpgsqlLine(a: 0.9746448399264267d, b: 0.5736543566900657d, c: 0.577271661287872d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5051151112679267d, b: 0.3585640504612344d, c: 0.010516176240218167d),
new NpgsqlTypes.NpgsqlLine(a: 0.32357236963656677d, b: 0.8058788702361471d, c: 0.944479167826818d),
new NpgsqlTypes.NpgsqlLine(a: 0.9243685292643199d, b: 0.33664697174771685d, c: 0.8513042487160248d),
new NpgsqlTypes.NpgsqlLine(a: 0.48426470483928086d, b: 0.32532229325988704d, c: 0.5197715636266009d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21500521567260056d, b: 0.22036506591088179d, c: 0.6405928239722497d),
new NpgsqlTypes.NpgsqlLine(a: 0.7038147141965756d, b: 0.6920759488228031d, c: 0.8632111029125288d),
new NpgsqlTypes.NpgsqlLine(a: 0.4671978013083379d, b: 0.5744941922123983d, c: 0.8579629293635291d),
new NpgsqlTypes.NpgsqlLine(a: 0.3014625615747909d, b: 0.21526987341958193d, c: 0.3430153736512641d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8152818034025209d, b: 0.2856352765346988d, c: 0.148803961101862d),
new NpgsqlTypes.NpgsqlLine(a: 0.6482429282279814d, b: 0.016024937320815114d, c: 0.8905157256135917d),
new NpgsqlTypes.NpgsqlLine(a: 0.5491794069065875d, b: 0.9461840065906251d, c: 0.3939608312188583d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.502105145929982d, b: 0.2758126053763452d, c: 0.19949587656821333d),
new NpgsqlTypes.NpgsqlLine(a: 0.9173827134414929d, b: 0.7966586953713031d, c: 0.3690069423254577d),
new NpgsqlTypes.NpgsqlLine(a: 0.4517572378117758d, b: 0.9065501829646946d, c: 0.5495921201930763d),
new NpgsqlTypes.NpgsqlLine(a: 0.8406254589921254d, b: 0.22374298470179343d, c: 0.6286124263214619d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4856494735921245d, b: 0.8916479801312576d, c: 0.1511267840159205d),
new NpgsqlTypes.NpgsqlLine(a: 0.531741592286103d, b: 0.20528204810031658d, c: 0.4750828039620134d),
new NpgsqlTypes.NpgsqlLine(a: 0.9890502679815385d, b: 0.9232981346026963d, c: 0.33900573802625056d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.01588495168666426d, b: 0.6305538812695421d, c: 0.33631959814037016d),
new NpgsqlTypes.NpgsqlLine(a: 0.8392655084321609d, b: 0.9862487761206016d, c: 0.30477488892812354d),
new NpgsqlTypes.NpgsqlLine(a: 0.7922159153942421d, b: 0.030375658549092854d, c: 0.7192166100493749d),
new NpgsqlTypes.NpgsqlLine(a: 0.5575638969164307d, b: 0.8732432044117983d, c: 0.9866221653696433d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9654774369746818d, b: 0.5143222875356371d, c: 0.2544646633904728d),
new NpgsqlTypes.NpgsqlLine(a: 0.972843057440411d, b: 0.0508527155744245d, c: 0.4715259411367171d),
new NpgsqlTypes.NpgsqlLine(a: 0.4608525124775418d, b: 0.7167434782337984d, c: 0.10618790579368798d),
new NpgsqlTypes.NpgsqlLine(a: 0.2767491641940105d, b: 0.32984056361740355d, c: 0.6308127170273438d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.01813665530059394d, b: 0.1594287386015154d, c: 0.24979546937680042d),
new NpgsqlTypes.NpgsqlLine(a: 0.9055342070918769d, b: 0.45879667010161995d, c: 0.015972896109812118d),
new NpgsqlTypes.NpgsqlLine(a: 0.4650781879056771d, b: 0.16649613757367854d, c: 0.21498357631406628d),
new NpgsqlTypes.NpgsqlLine(a: 0.4431375029829159d, b: 0.47614751040628944d, c: 0.890117170907802d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5000869202643663d, b: 0.2617911752094976d, c: 0.820390622553643d),
new NpgsqlTypes.NpgsqlLine(a: 0.025943240328060835d, b: 0.460689876490854d, c: 0.23787427657243965d),
new NpgsqlTypes.NpgsqlLine(a: 0.7600209718568187d, b: 0.12329216707955237d, c: 0.9255780128262402d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5793854355970032d, b: 0.2466751669370385d, c: 0.22644974050983846d),
new NpgsqlTypes.NpgsqlLine(a: 0.4373936817453259d, b: 0.9789321233601215d, c: 0.8622516224901552d),
new NpgsqlTypes.NpgsqlLine(a: 0.5984676996949538d, b: 0.9167048699400872d, c: 0.23353335758556215d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.983069413510571d, b: 0.5192919654062109d, c: 0.4845127801124647d),
new NpgsqlTypes.NpgsqlLine(a: 0.21583753695557195d, b: 0.48688562192701623d, c: 0.47639742207123126d),
new NpgsqlTypes.NpgsqlLine(a: 0.34131725606976493d, b: 0.8134502964635836d, c: 0.7182109081123879d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7035651461131941d, b: 0.7930846757123046d, c: 0.3173283093045385d),
new NpgsqlTypes.NpgsqlLine(a: 0.10586181130696182d, b: 0.5886347630615808d, c: 0.8392145549127414d),
new NpgsqlTypes.NpgsqlLine(a: 0.5527750015828982d, b: 0.27601222255586644d, c: 0.6105253112172075d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6458040926028844d, b: 0.8182700305160392d, c: 0.20126416427920168d),
new NpgsqlTypes.NpgsqlLine(a: 0.5028678035231939d, b: 0.9468764083039626d, c: 0.4500782957337912d),
new NpgsqlTypes.NpgsqlLine(a: 0.8794569864820806d, b: 0.04704259335803862d, c: 0.5883352173773911d),
new NpgsqlTypes.NpgsqlLine(a: 0.9217164479732171d, b: 0.829411496116619d, c: 0.538371010778046d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.011179836961140999d, b: 0.12941189481442972d, c: 0.9747913315727917d),
new NpgsqlTypes.NpgsqlLine(a: 0.5281171909247112d, b: 0.09069819252933176d, c: 0.974481945523524d),
new NpgsqlTypes.NpgsqlLine(a: 0.9679231134920196d, b: 0.8856977608558081d, c: 0.5928774227664012d),
new NpgsqlTypes.NpgsqlLine(a: 0.2211577277338772d, b: 0.5226907134748395d, c: 0.5821164659036395d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8382031264135394d, b: 0.7156073400780754d, c: 0.5642257399251629d),
new NpgsqlTypes.NpgsqlLine(a: 0.14100880496928647d, b: 0.7259324597606839d, c: 0.8191268710842132d),
new NpgsqlTypes.NpgsqlLine(a: 0.017734139789323033d, b: 0.7311976823666437d, c: 0.1294945627459937d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.330395931640179d, b: 0.045286917457775355d, c: 0.8672575134408735d),
new NpgsqlTypes.NpgsqlLine(a: 0.3953764704704219d, b: 0.6573960016569382d, c: 0.6192284550572522d),
new NpgsqlTypes.NpgsqlLine(a: 0.18916729447799574d, b: 0.4630000719294486d, c: 0.8353767816703279d),
new NpgsqlTypes.NpgsqlLine(a: 0.6774311293563398d, b: 0.3655261624467431d, c: 0.8025758711675328d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7347230699221069d, b: 0.2802119325277346d, c: 0.050927386868688695d),
new NpgsqlTypes.NpgsqlLine(a: 0.006268905009914283d, b: 0.11964163663546001d, c: 0.08310393149084139d),
new NpgsqlTypes.NpgsqlLine(a: 0.2948312796495496d, b: 0.561094745807749d, c: 0.9781004872475699d),
new NpgsqlTypes.NpgsqlLine(a: 0.934889203486963d, b: 0.24996666334205397d, c: 0.2673931960896626d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08453423047461917d, b: 0.8153090886739124d, c: 0.6229193572801137d),
new NpgsqlTypes.NpgsqlLine(a: 0.7356755282050378d, b: 0.695154323596412d, c: 0.8411370352672795d),
new NpgsqlTypes.NpgsqlLine(a: 0.8172833802668175d, b: 0.6933240396328542d, c: 0.951693047572343d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2296485629991316d, b: 0.6386127612276136d, c: 0.9139606902214689d),
new NpgsqlTypes.NpgsqlLine(a: 0.9938314085845098d, b: 0.48064823216973374d, c: 0.19243388718578214d),
new NpgsqlTypes.NpgsqlLine(a: 0.6481329607349499d, b: 0.3423872413782518d, c: 0.8439816304191059d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5362863362950387d, b: 0.4776591072567393d, c: 0.6173371618876248d),
new NpgsqlTypes.NpgsqlLine(a: 0.019569524653818005d, b: 0.6293649312308006d, c: 0.8198163722563558d),
new NpgsqlTypes.NpgsqlLine(a: 0.7962432125307076d, b: 0.9365208654428726d, c: 0.14489340401164386d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7019582964228754d, b: 0.6606752361516351d, c: 0.6777003467062184d),
new NpgsqlTypes.NpgsqlLine(a: 0.563213109160682d, b: 0.38937732959299953d, c: 0.49968452311811484d),
new NpgsqlTypes.NpgsqlLine(a: 0.02376113046691042d, b: 0.6366811797213198d, c: 0.4923860355641019d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8047131786436064d, b: 0.09756749456428648d, c: 0.37249530102293016d),
new NpgsqlTypes.NpgsqlLine(a: 0.4913642734052106d, b: 0.16755543453095578d, c: 0.5822244188715934d),
new NpgsqlTypes.NpgsqlLine(a: 0.7281984788783478d, b: 0.182662601017629d, c: 0.49629805556818396d),
new NpgsqlTypes.NpgsqlLine(a: 0.835654722467787d, b: 0.7383288951620376d, c: 0.27530682160073516d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.326202532890976d, b: 0.0885083511361493d, c: 0.4440483201978961d),
new NpgsqlTypes.NpgsqlLine(a: 0.7430227389551578d, b: 0.457341706894576d, c: 0.27229464666503334d),
new NpgsqlTypes.NpgsqlLine(a: 0.05293701080153845d, b: 0.21852467227893513d, c: 0.6190287864233643d),
new NpgsqlTypes.NpgsqlLine(a: 0.42462707851847437d, b: 0.1225737790185144d, c: 0.11784538604877948d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9791150636410236d, b: 0.1899225700583662d, c: 0.31168870659835324d),
new NpgsqlTypes.NpgsqlLine(a: 0.1452291285273607d, b: 0.48087247971534564d, c: 0.7239327518704065d),
new NpgsqlTypes.NpgsqlLine(a: 0.6615301354055797d, b: 0.7362405481370088d, c: 0.04668517424295171d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.44902982889356524d, b: 0.7087149128877451d, c: 0.8316939168015989d),
new NpgsqlTypes.NpgsqlLine(a: 0.08587161411228283d, b: 0.7758290224886255d, c: 0.7872719430733659d),
new NpgsqlTypes.NpgsqlLine(a: 0.22010453916796668d, b: 0.5753617009738339d, c: 0.6197889762551732d),
new NpgsqlTypes.NpgsqlLine(a: 0.07789456709617992d, b: 0.7102990096813079d, c: 0.09751719466021547d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.45531921504053385d, b: 0.04781677379376226d, c: 0.8196044048554976d),
new NpgsqlTypes.NpgsqlLine(a: 0.8483648275449082d, b: 0.13169369370305706d, c: 0.8327794308545033d),
new NpgsqlTypes.NpgsqlLine(a: 0.61835336793095d, b: 0.2828453022961508d, c: 0.026938014022825252d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16014887330149274d, b: 0.13728757718119855d, c: 0.5931529524655986d),
new NpgsqlTypes.NpgsqlLine(a: 0.46903379621818864d, b: 0.13665845237845187d, c: 0.7975911058866559d),
new NpgsqlTypes.NpgsqlLine(a: 0.9619083252023786d, b: 0.384988415642608d, c: 0.4556399604591247d),
new NpgsqlTypes.NpgsqlLine(a: 0.007139299628547202d, b: 0.6034997276054568d, c: 0.2664297792892445d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5031160125264703d, b: 0.8667197489268754d, c: 0.10576865440635408d),
new NpgsqlTypes.NpgsqlLine(a: 0.9392234739196073d, b: 0.8888576466950756d, c: 0.6288952947716887d),
new NpgsqlTypes.NpgsqlLine(a: 0.6455904561835518d, b: 0.06565680249055694d, c: 0.9521948508516175d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8526648686884989d, b: 0.3999071481157407d, c: 0.7349819471825078d),
new NpgsqlTypes.NpgsqlLine(a: 0.7816056044258488d, b: 0.9707060394706067d, c: 0.7946500550764322d),
new NpgsqlTypes.NpgsqlLine(a: 0.09796513153520559d, b: 0.8223301047267428d, c: 0.027553108392103343d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5473260677418458d, b: 0.10937247126039384d, c: 0.2916400789081668d),
new NpgsqlTypes.NpgsqlLine(a: 0.15657516369680047d, b: 0.8304193189734945d, c: 0.5913064748394342d),
new NpgsqlTypes.NpgsqlLine(a: 0.8167280654505494d, b: 0.8643960083309925d, c: 0.2010022203917251d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.13617892089391792d, b: 0.9877045129900273d, c: 0.2835642002160973d),
new NpgsqlTypes.NpgsqlLine(a: 0.2840897388253879d, b: 0.31038123463082135d, c: 0.05351259816611609d),
new NpgsqlTypes.NpgsqlLine(a: 0.6894220670001596d, b: 0.309359907856789d, c: 0.018152950500037734d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14118420791329322d, b: 0.7382019151896824d, c: 0.46227055286539276d),
new NpgsqlTypes.NpgsqlLine(a: 0.49524598695823885d, b: 0.3065198813626582d, c: 0.8823905834744556d),
new NpgsqlTypes.NpgsqlLine(a: 0.49118650032158995d, b: 0.11941980578691824d, c: 0.42679052399618234d),
new NpgsqlTypes.NpgsqlLine(a: 0.812503632683458d, b: 0.9793745821763316d, c: 0.634132848662487d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6325980833351861d, b: 0.12189266414081001d, c: 0.8147676179593176d),
new NpgsqlTypes.NpgsqlLine(a: 0.09522228530182053d, b: 0.15431399880433827d, c: 0.8839929930014405d),
new NpgsqlTypes.NpgsqlLine(a: 0.4123609021503293d, b: 0.38386134541477157d, c: 0.5641969474835501d),
new NpgsqlTypes.NpgsqlLine(a: 0.8524579154391931d, b: 0.5886746628894763d, c: 0.7020246344083491d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10420854071086749d, b: 0.05971312514336169d, c: 0.9007135909466584d),
new NpgsqlTypes.NpgsqlLine(a: 0.24907476850272536d, b: 0.8679166701809781d, c: 0.1534472743921016d),
new NpgsqlTypes.NpgsqlLine(a: 0.8555904308721296d, b: 0.09186748328165528d, c: 0.19958704038630581d),
new NpgsqlTypes.NpgsqlLine(a: 0.13641960664208042d, b: 0.3123278277728061d, c: 0.7508251286291989d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9014564208173316d, b: 0.16634625037823636d, c: 0.7005457120985181d),
new NpgsqlTypes.NpgsqlLine(a: 0.13610735727282852d, b: 0.5236303083826723d, c: 0.3597273731411671d),
new NpgsqlTypes.NpgsqlLine(a: 0.42373799177958693d, b: 0.07229668834064418d, c: 0.15368342309055205d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.546443688999098d, b: 0.028338288524440203d, c: 0.30976715939634136d),
new NpgsqlTypes.NpgsqlLine(a: 0.18032454826676325d, b: 0.7847182560212448d, c: 0.6655546404789126d),
new NpgsqlTypes.NpgsqlLine(a: 0.41421503763371303d, b: 0.21511041843256218d, c: 0.2730721700801124d),
new NpgsqlTypes.NpgsqlLine(a: 0.705365252191828d, b: 0.33656377961171746d, c: 0.5136414664567731d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.0960715931823316d, b: 0.40290440493561275d, c: 0.9873880391224809d),
new NpgsqlTypes.NpgsqlLine(a: 0.28809386760125977d, b: 0.9148888048559394d, c: 0.8614674295040147d),
new NpgsqlTypes.NpgsqlLine(a: 0.8257153098428539d, b: 0.8032916916190349d, c: 0.9308391159963716d),
new NpgsqlTypes.NpgsqlLine(a: 0.03684114273906114d, b: 0.09080422551916856d, c: 0.04754258980096171d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8829031374506116d, b: 0.2952766712992134d, c: 0.37185635685464435d),
new NpgsqlTypes.NpgsqlLine(a: 0.5870553459831349d, b: 0.44259217960343344d, c: 0.7037605873716029d),
new NpgsqlTypes.NpgsqlLine(a: 0.24404361687558296d, b: 0.6545541288954316d, c: 0.49165514038499614d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16571917077269838d, b: 0.09162270444151432d, c: 0.6098422789615972d),
new NpgsqlTypes.NpgsqlLine(a: 0.4537674719040471d, b: 0.04865007614630146d, c: 0.6052092475152145d),
new NpgsqlTypes.NpgsqlLine(a: 0.16627184494822356d, b: 0.053993856361005954d, c: 0.09645794599834656d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.47714046439424596d, b: 0.943110752064452d, c: 0.16237512523500974d),
new NpgsqlTypes.NpgsqlLine(a: 0.3160702987935562d, b: 0.7710781127895218d, c: 0.10894167703411006d),
new NpgsqlTypes.NpgsqlLine(a: 0.7879367345407693d, b: 0.22541132362933203d, c: 0.5437204979153509d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3207584293837622d, b: 0.3187143333250648d, c: 0.42578317426042556d),
new NpgsqlTypes.NpgsqlLine(a: 0.3241016324424406d, b: 0.36176646069731755d, c: 0.7146377937392319d),
new NpgsqlTypes.NpgsqlLine(a: 0.978180366242612d, b: 0.4761034763551487d, c: 0.6486362991531905d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9322417363042157d, b: 0.6370290681859819d, c: 0.7526543364745574d),
new NpgsqlTypes.NpgsqlLine(a: 0.13575543538029355d, b: 0.6904421440406281d, c: 0.34842487733265526d),
new NpgsqlTypes.NpgsqlLine(a: 0.2147362486315083d, b: 0.9879066394894993d, c: 0.8367285014939219d),
new NpgsqlTypes.NpgsqlLine(a: 0.4968828295588489d, b: 0.402014331306505d, c: 0.6492523468257976d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5964547202330323d, b: 0.06213708070574264d, c: 0.261604205937246d),
new NpgsqlTypes.NpgsqlLine(a: 0.9378919694846727d, b: 0.553603285051393d, c: 0.5745687117709736d),
new NpgsqlTypes.NpgsqlLine(a: 0.5122444145075844d, b: 0.33106448818486134d, c: 0.9554510601374699d),
new NpgsqlTypes.NpgsqlLine(a: 0.983266428520711d, b: 0.7752541263701296d, c: 0.3645278163047776d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6064759955322425d, b: 0.3283623089480133d, c: 0.5933693523210424d),
new NpgsqlTypes.NpgsqlLine(a: 0.42279308362954326d, b: 0.6822016729300727d, c: 0.7519826314209936d),
new NpgsqlTypes.NpgsqlLine(a: 0.030429890914488444d, b: 0.07470065930563086d, c: 0.21925684396722922d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.856381179060968d, b: 0.6773225576753082d, c: 0.6365429450921164d),
new NpgsqlTypes.NpgsqlLine(a: 0.8783948676306815d, b: 0.9535066524339847d, c: 0.4402156332956235d),
new NpgsqlTypes.NpgsqlLine(a: 0.8304989810591432d, b: 0.9723713941433428d, c: 0.9414926911515694d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.32795719481276675d, b: 0.033442139429598394d, c: 0.8346051996359919d),
new NpgsqlTypes.NpgsqlLine(a: 0.971794859851099d, b: 0.9163436762600903d, c: 0.9478307088763939d),
new NpgsqlTypes.NpgsqlLine(a: 0.44753251082766854d, b: 0.4743051809086807d, c: 0.13206747279758135d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9224185219768382d, b: 0.1874982924649915d, c: 0.557508229655444d),
new NpgsqlTypes.NpgsqlLine(a: 0.5678804894334541d, b: 0.9529007961179713d, c: 0.3297480692505719d),
new NpgsqlTypes.NpgsqlLine(a: 0.4046269472551459d, b: 0.4400134410082972d, c: 0.22459894191683516d),
new NpgsqlTypes.NpgsqlLine(a: 0.3319629930783661d, b: 0.9164872394007081d, c: 0.1904239821109558d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7540146994745199d, b: 0.7108903983784068d, c: 0.1308306853826029d),
new NpgsqlTypes.NpgsqlLine(a: 0.5374701456159303d, b: 0.46352015630268506d, c: 0.36473146272317736d),
new NpgsqlTypes.NpgsqlLine(a: 0.031411379735336475d, b: 0.5970777060693463d, c: 0.6128219945464993d),
new NpgsqlTypes.NpgsqlLine(a: 0.4999041387333244d, b: 0.2798379019736559d, c: 0.5828939237354339d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14103496696826945d, b: 0.5530827446153346d, c: 0.8291633056576542d),
new NpgsqlTypes.NpgsqlLine(a: 0.754460894853136d, b: 0.9517480742759014d, c: 0.9534643905352472d),
new NpgsqlTypes.NpgsqlLine(a: 0.890644879422706d, b: 0.9058667408544286d, c: 0.7924014885769622d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7688405161932858d, b: 0.5578527122554079d, c: 0.17264185164459123d),
new NpgsqlTypes.NpgsqlLine(a: 0.1646703189825669d, b: 0.5216469850603692d, c: 0.8290295721607762d),
new NpgsqlTypes.NpgsqlLine(a: 0.7579416846223199d, b: 0.4610874845048626d, c: 0.29189733782440985d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6959643540016993d, b: 0.11600746577840593d, c: 0.6141314497216d),
new NpgsqlTypes.NpgsqlLine(a: 0.39602665648127733d, b: 0.30743067498834675d, c: 0.560545335941986d),
new NpgsqlTypes.NpgsqlLine(a: 0.5413935247890823d, b: 0.17083885104222662d, c: 0.3198065960799428d),
new NpgsqlTypes.NpgsqlLine(a: 0.922240856755119d, b: 0.4107810490788657d, c: 0.7541874383392639d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7876282841376806d, b: 0.1576152884852977d, c: 0.21497874615555923d),
new NpgsqlTypes.NpgsqlLine(a: 0.551458408975057d, b: 0.8212093257181171d, c: 0.1528993588978249d),
new NpgsqlTypes.NpgsqlLine(a: 0.9939693563693698d, b: 0.4042106651795041d, c: 0.6153968265093249d),
new NpgsqlTypes.NpgsqlLine(a: 0.3936035060612102d, b: 0.5998699463950139d, c: 0.3485158413477554d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.49692317032876143d, b: 0.04543286851553163d, c: 0.5292361682910824d),
new NpgsqlTypes.NpgsqlLine(a: 0.02162308010586267d, b: 0.928578491445678d, c: 0.2435975643860966d),
new NpgsqlTypes.NpgsqlLine(a: 0.7583826151915116d, b: 0.2448501707907652d, c: 0.9475933570945418d),
new NpgsqlTypes.NpgsqlLine(a: 0.6151157769196584d, b: 0.4579178343164697d, c: 0.06154899779885925d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6552853061385085d, b: 0.6676589649987441d, c: 0.8019875172568889d),
new NpgsqlTypes.NpgsqlLine(a: 0.9365456637794045d, b: 0.7409029136665969d, c: 0.9496963848329085d),
new NpgsqlTypes.NpgsqlLine(a: 0.8621772198320421d, b: 0.35569523494008426d, c: 0.6220853192212508d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8174411366799788d, b: 0.4461551944093368d, c: 0.6355780380429171d),
new NpgsqlTypes.NpgsqlLine(a: 0.020607650165167524d, b: 0.7256552662395366d, c: 0.9046532427228192d),
new NpgsqlTypes.NpgsqlLine(a: 0.8025857386740047d, b: 0.42679773765033613d, c: 0.8945711332890991d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9576993478893938d, b: 0.9149606825427498d, c: 0.211262592315546d),
new NpgsqlTypes.NpgsqlLine(a: 0.3111325558635547d, b: 0.752149644055843d, c: 0.8562528220475659d),
new NpgsqlTypes.NpgsqlLine(a: 0.3980700116411374d, b: 0.7563110368946697d, c: 0.32634851614293314d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2932866290045226d, b: 0.8666568964519712d, c: 0.5981301616113555d),
new NpgsqlTypes.NpgsqlLine(a: 0.22263455722927505d, b: 0.11663042058246453d, c: 0.37530984927590616d),
new NpgsqlTypes.NpgsqlLine(a: 0.41832715961769706d, b: 0.3766306381933616d, c: 0.809447080024547d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.011770689854370575d, b: 0.3371857943128739d, c: 0.8957703140409191d),
new NpgsqlTypes.NpgsqlLine(a: 0.13160155748133762d, b: 0.48840685071856593d, c: 0.7702389810257285d),
new NpgsqlTypes.NpgsqlLine(a: 0.2885231348326579d, b: 0.4343177802826389d, c: 0.13899205830656092d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.29503360882733254d, b: 0.9721880250515025d, c: 0.30489645360674267d),
new NpgsqlTypes.NpgsqlLine(a: 0.6134323099768066d, b: 0.25254265355780736d, c: 0.960626899651006d),
new NpgsqlTypes.NpgsqlLine(a: 0.37507693992132274d, b: 0.8856695326875026d, c: 0.9237822325935973d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9228126668018449d, b: 0.3507358614619581d, c: 0.8263330884412362d),
new NpgsqlTypes.NpgsqlLine(a: 0.885867985094471d, b: 0.8637677662955288d, c: 0.36003753625745805d),
new NpgsqlTypes.NpgsqlLine(a: 0.18336232949620423d, b: 0.24603226756420515d, c: 0.5076522542858899d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5352391762979836d, b: 0.9684616460063261d, c: 0.7772274112004394d),
new NpgsqlTypes.NpgsqlLine(a: 0.8543871682191597d, b: 0.9409052299853857d, c: 0.06560861222895442d),
new NpgsqlTypes.NpgsqlLine(a: 0.8933113668200672d, b: 0.6306882987595778d, c: 0.919745512587997d),
new NpgsqlTypes.NpgsqlLine(a: 0.4707115552761334d, b: 0.6369284875061183d, c: 0.8622369085990009d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3478644549437041d, b: 0.5886999812656235d, c: 0.5332533545694356d),
new NpgsqlTypes.NpgsqlLine(a: 0.27707632682834826d, b: 0.6676211035602315d, c: 0.2669744116042492d),
new NpgsqlTypes.NpgsqlLine(a: 0.38582820557267905d, b: 0.49270842138771376d, c: 0.6101399135262273d),
new NpgsqlTypes.NpgsqlLine(a: 0.3539270577775895d, b: 0.2886233555211839d, c: 0.22476887148436753d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4604700339880391d, b: 0.537618880426903d, c: 0.10127589339996312d),
new NpgsqlTypes.NpgsqlLine(a: 0.10947235914154563d, b: 0.5939001796755279d, c: 0.07045356556556415d),
new NpgsqlTypes.NpgsqlLine(a: 0.7421903554241972d, b: 0.6748912013509741d, c: 0.20529724872144728d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5052574988766049d, b: 0.9622506613865353d, c: 0.7701316662383662d),
new NpgsqlTypes.NpgsqlLine(a: 0.806294244804864d, b: 0.7157328361752477d, c: 0.10935227192347241d),
new NpgsqlTypes.NpgsqlLine(a: 0.31083275087444173d, b: 0.614211769910822d, c: 0.9581847212657073d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8755837302059281d, b: 0.7238174824773916d, c: 0.9771599073390657d),
new NpgsqlTypes.NpgsqlLine(a: 0.350763410767446d, b: 0.06464221485098887d, c: 0.10157920370439211d),
new NpgsqlTypes.NpgsqlLine(a: 0.8569761255871626d, b: 0.9791051683860502d, c: 0.7380698757883672d),
new NpgsqlTypes.NpgsqlLine(a: 0.21354675734517992d, b: 0.7162965444882853d, c: 0.23168856523266768d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.03892444202930134d, b: 0.9956195379827877d, c: 0.782646989799614d),
new NpgsqlTypes.NpgsqlLine(a: 0.2959843981786491d, b: 0.36393867410934544d, c: 0.7055402680876923d),
new NpgsqlTypes.NpgsqlLine(a: 0.14129461345165328d, b: 0.6915105818409653d, c: 0.7621987529660054d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7633422617892023d, b: 0.6051362802761946d, c: 0.11042337553254755d),
new NpgsqlTypes.NpgsqlLine(a: 0.553502804908541d, b: 0.0904579401307104d, c: 0.0471540193960891d),
new NpgsqlTypes.NpgsqlLine(a: 0.5655050190453541d, b: 0.9000072904630307d, c: 0.02935864613907635d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1mi(
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
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

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5051151112679267d, b: 0.3585640504612344d, c: 0.010516176240218167d),
new NpgsqlTypes.NpgsqlLine(a: 0.32357236963656677d, b: 0.8058788702361471d, c: 0.944479167826818d),
new NpgsqlTypes.NpgsqlLine(a: 0.9243685292643199d, b: 0.33664697174771685d, c: 0.8513042487160248d),
new NpgsqlTypes.NpgsqlLine(a: 0.48426470483928086d, b: 0.32532229325988704d, c: 0.5197715636266009d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.01588495168666426d, b: 0.6305538812695421d, c: 0.33631959814037016d),
new NpgsqlTypes.NpgsqlLine(a: 0.8392655084321609d, b: 0.9862487761206016d, c: 0.30477488892812354d),
new NpgsqlTypes.NpgsqlLine(a: 0.7922159153942421d, b: 0.030375658549092854d, c: 0.7192166100493749d),
new NpgsqlTypes.NpgsqlLine(a: 0.5575638969164307d, b: 0.8732432044117983d, c: 0.9866221653696433d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5000869202643663d, b: 0.2617911752094976d, c: 0.820390622553643d),
new NpgsqlTypes.NpgsqlLine(a: 0.025943240328060835d, b: 0.460689876490854d, c: 0.23787427657243965d),
new NpgsqlTypes.NpgsqlLine(a: 0.7600209718568187d, b: 0.12329216707955237d, c: 0.9255780128262402d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.983069413510571d, b: 0.5192919654062109d, c: 0.4845127801124647d),
new NpgsqlTypes.NpgsqlLine(a: 0.21583753695557195d, b: 0.48688562192701623d, c: 0.47639742207123126d),
new NpgsqlTypes.NpgsqlLine(a: 0.34131725606976493d, b: 0.8134502964635836d, c: 0.7182109081123879d),
}));
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8382031264135394d, b: 0.7156073400780754d, c: 0.5642257399251629d),
new NpgsqlTypes.NpgsqlLine(a: 0.14100880496928647d, b: 0.7259324597606839d, c: 0.8191268710842132d),
new NpgsqlTypes.NpgsqlLine(a: 0.017734139789323033d, b: 0.7311976823666437d, c: 0.1294945627459937d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;

                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineArraylineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineArraylineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 158;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 118;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[34], false);
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
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 49, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 141, query1, 154, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 121, query1, 158, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 49, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 18, query1, 57, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 78, query1, 26, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 123, query1, 26, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[29],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 154, query1, 131, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 33, 154))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[34], false);
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
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatch(connection, 3, 76))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 155);
                var models = await ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[32], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[33], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 121);
                var models =  ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[25], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[26], false);
                NpgsqlLinelineArray1M.AssertModel(models[3],_testData[27], false);
                NpgsqlLinelineArray1M.AssertModel(models[4],_testData[28], false);
                NpgsqlLinelineArray1M.AssertModel(models[5],_testData[29], false);
                NpgsqlLinelineArray1M.AssertModel(models[6],_testData[30], false);
                NpgsqlLinelineArray1M.AssertModel(models[7],_testData[31], false);
                NpgsqlLinelineArray1M.AssertModel(models[8],_testData[32], false);
                NpgsqlLinelineArray1M.AssertModel(models[9],_testData[33], false);
                NpgsqlLinelineArray1M.AssertModel(models[10],_testData[34], false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MIWA),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineArraylineArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineArraylineArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineArraylineArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineArraylineArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineArraylineArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MI),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineArraylineArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineArraylineArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineArraylineArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineArraylineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineArray1M),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
FROM public.binary_npgsqllinelinearray1m m
LEFT JOIN public.binary_npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineArraylineArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineArraylineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models =  ((INpgsqlLineArraylineArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA), typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                await ((INpgsqlLineArraylineArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                ((INpgsqlLineArraylineArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA), typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                await ((INpgsqlLineArraylineArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                ((INpgsqlLineArraylineArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI), typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models1 = new List<NpgsqlLinelineArray1MI>();
                var models2 = new List<NpgsqlLinelineArray1MI>();
                await ((INpgsqlLineArraylineArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MI>();
                var models2 = new List<NpgsqlLinelineArray1MI>();
                ((INpgsqlLineArraylineArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA), typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                await ((INpgsqlLineArraylineArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                ((INpgsqlLineArraylineArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

