

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
    internal partial interface INpgsqlPathMArraypathMMArrayD3
    {
    }
    
    internal partial class NpgsqlPathMArraypathMMArrayD3 : INpgsqlPathMArraypathMMArrayD3
    {


#region TestData

        private readonly NpgsqlPathpathMMArrayD3E1M[] _testData = new NpgsqlPathpathMMArrayD3E1M[]
        {
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3594536715595613d, y: 0.32820500788348117d), new NpgsqlTypes.NpgsqlPoint(x: 0.6386690756051954d, y: 0.3507027025301699d), new NpgsqlTypes.NpgsqlPoint(x: 0.05197719784850141d, y: 0.047598943504928104d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39151394026306696d, y: 0.33960130038210246d), new NpgsqlTypes.NpgsqlPoint(x: 0.11982150870307573d, y: 0.13153125443834734d), new NpgsqlTypes.NpgsqlPoint(x: 0.4453358055813923d, y: 0.8491195214116297d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28039041812819976d, y: 0.7553777897087453d), new NpgsqlTypes.NpgsqlPoint(x: 0.42571167258388165d, y: 0.6589319299435297d), new NpgsqlTypes.NpgsqlPoint(x: 0.9260854004776929d, y: 0.264061803704551d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22564109069914495d, y: 0.8432298605089482d), new NpgsqlTypes.NpgsqlPoint(x: 0.8984588273121371d, y: 0.43597806259374283d), new NpgsqlTypes.NpgsqlPoint(x: 0.5740636333245865d, y: 0.7894046255274472d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9835134737695012d, y: 0.025143258183494055d), new NpgsqlTypes.NpgsqlPoint(x: 0.26406089325762483d, y: 0.20115556849220118d), new NpgsqlTypes.NpgsqlPoint(x: 0.5342051314003811d, y: 0.27460800988296374d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8818811633159445d, y: 0.15390425949758246d), new NpgsqlTypes.NpgsqlPoint(x: 0.08028236729177829d, y: 0.06424843093004085d), new NpgsqlTypes.NpgsqlPoint(x: 0.1507205791495586d, y: 0.6261337719208958d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5156010858908592d, y: 0.9361837039509439d), new NpgsqlTypes.NpgsqlPoint(x: 0.2580851469952907d, y: 0.19951066530815764d), new NpgsqlTypes.NpgsqlPoint(x: 0.3540389603870303d, y: 0.16143278406611195d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48429454635397595d, y: 0.5845160876809272d), new NpgsqlTypes.NpgsqlPoint(x: 0.8644400226932746d, y: 0.5605127552426081d), new NpgsqlTypes.NpgsqlPoint(x: 0.10147297054087534d, y: 0.43214728984419537d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5839426147255303d, y: 0.22766162852057614d), new NpgsqlTypes.NpgsqlPoint(x: 0.2664499971676709d, y: 0.5790463319626241d), new NpgsqlTypes.NpgsqlPoint(x: 0.9280438490282789d, y: 0.6170516264288857d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4892698768764516d, y: 0.526571956182613d), new NpgsqlTypes.NpgsqlPoint(x: 0.025254190042017677d, y: 0.4962839443280841d), new NpgsqlTypes.NpgsqlPoint(x: 0.8719736864629516d, y: 0.8389666707542353d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5520879784534402d, y: 0.3950333890594373d), new NpgsqlTypes.NpgsqlPoint(x: 0.8472156701909924d, y: 0.14672721113646492d), new NpgsqlTypes.NpgsqlPoint(x: 0.7629166302492805d, y: 0.2681135740929669d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0980310488309909d, y: 0.8687202011125411d), new NpgsqlTypes.NpgsqlPoint(x: 0.21708351411171367d, y: 0.2628149198305324d), new NpgsqlTypes.NpgsqlPoint(x: 0.4549536089618923d, y: 0.3919145831839762d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5809009141444017d, y: 0.532750275691674d), new NpgsqlTypes.NpgsqlPoint(x: 0.6670619376885448d, y: 0.856504320107432d), new NpgsqlTypes.NpgsqlPoint(x: 0.8143430555664571d, y: 0.6700192159999948d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5152603461877395d, y: 0.40931129527666743d), new NpgsqlTypes.NpgsqlPoint(x: 0.6566007709911603d, y: 0.9620199072176168d), new NpgsqlTypes.NpgsqlPoint(x: 0.6962312839883791d, y: 0.44059365661351657d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6728420471548872d, y: 0.9476787424438318d), new NpgsqlTypes.NpgsqlPoint(x: 0.21801587176590098d, y: 0.9924810874039038d), new NpgsqlTypes.NpgsqlPoint(x: 0.8612826040300842d, y: 0.26933408506525924d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.524510299126571d, y: 0.914174585687824d), new NpgsqlTypes.NpgsqlPoint(x: 0.2200015857689116d, y: 0.015586268453072205d), new NpgsqlTypes.NpgsqlPoint(x: 0.0840095387602674d, y: 0.42614703665922116d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2889856449372852d, y: 0.05186326283236753d), new NpgsqlTypes.NpgsqlPoint(x: 0.22607587471120838d, y: 0.2023754238356984d), new NpgsqlTypes.NpgsqlPoint(x: 0.03606905993175591d, y: 0.38119244497318494d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6942138519822305d, y: 0.4833561522328109d), new NpgsqlTypes.NpgsqlPoint(x: 0.9731917007880502d, y: 0.933549579822948d), new NpgsqlTypes.NpgsqlPoint(x: 0.6141099612334971d, y: 0.9940249415407635d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9932916535635904d, y: 0.6615300957212665d), new NpgsqlTypes.NpgsqlPoint(x: 0.679443835035724d, y: 0.8002935320421439d), new NpgsqlTypes.NpgsqlPoint(x: 0.7988354813142582d, y: 0.012787026138932567d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47086719663209786d, y: 0.10632462416638155d), new NpgsqlTypes.NpgsqlPoint(x: 0.156767307809498d, y: 0.7938320950333492d), new NpgsqlTypes.NpgsqlPoint(x: 0.7281874602178604d, y: 0.5562622354810898d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07626834663566417d, y: 0.7104711993206511d), new NpgsqlTypes.NpgsqlPoint(x: 0.901720914411924d, y: 0.1876975860020048d), new NpgsqlTypes.NpgsqlPoint(x: 0.8945373234444348d, y: 0.5997776911697884d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12497266729634782d, y: 0.9462089850062194d), new NpgsqlTypes.NpgsqlPoint(x: 0.9159804273373265d, y: 0.26713066945375663d), new NpgsqlTypes.NpgsqlPoint(x: 0.004549012221379156d, y: 0.8410245226055967d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15395694205589383d, y: 0.42774284676001884d), new NpgsqlTypes.NpgsqlPoint(x: 0.8929008209182848d, y: 0.25560985152120175d), new NpgsqlTypes.NpgsqlPoint(x: 0.17934561698794016d, y: 0.7806901435169847d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005044963835252325d, y: 0.16044659715995613d), new NpgsqlTypes.NpgsqlPoint(x: 0.49645371210339795d, y: 0.3294005577124647d), new NpgsqlTypes.NpgsqlPoint(x: 0.6015991236899961d, y: 0.00902624724793899d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34067425718157873d, y: 0.08826013912172492d), new NpgsqlTypes.NpgsqlPoint(x: 0.19660341601446896d, y: 0.5592664127442737d), new NpgsqlTypes.NpgsqlPoint(x: 0.3676710486400334d, y: 0.2847988126007923d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03145953339449781d, y: 0.41014126598235345d), new NpgsqlTypes.NpgsqlPoint(x: 0.5962956959028818d, y: 0.5674914104301763d), new NpgsqlTypes.NpgsqlPoint(x: 0.6044791371283609d, y: 0.5674999886405809d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9032218862410983d, y: 0.8606324106699511d), new NpgsqlTypes.NpgsqlPoint(x: 0.16068657979159406d, y: 0.1697899276054231d), new NpgsqlTypes.NpgsqlPoint(x: 0.5337261902330107d, y: 0.8974628855167399d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7394245660473268d, y: 0.1116873882420012d), new NpgsqlTypes.NpgsqlPoint(x: 0.3943994155360425d, y: 0.6318730778575951d), new NpgsqlTypes.NpgsqlPoint(x: 0.19248603438173095d, y: 0.8373941300805562d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23366236400076124d, y: 0.9474683738298286d), new NpgsqlTypes.NpgsqlPoint(x: 0.609619597835324d, y: 0.40064133319734685d), new NpgsqlTypes.NpgsqlPoint(x: 0.8177007206634647d, y: 0.1354481835882051d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6635835234905711d, y: 0.5001414083277642d), new NpgsqlTypes.NpgsqlPoint(x: 0.0948614395249694d, y: 0.4411976134722756d), new NpgsqlTypes.NpgsqlPoint(x: 0.30015551885278047d, y: 0.21593980383420408d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1603752520925511d, y: 0.9307662453032736d), new NpgsqlTypes.NpgsqlPoint(x: 0.11389098411278098d, y: 0.5791413000364732d), new NpgsqlTypes.NpgsqlPoint(x: 0.4212339342099588d, y: 0.03861921038586158d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6459955453239954d, y: 0.4074772714996471d), new NpgsqlTypes.NpgsqlPoint(x: 0.24080380396373158d, y: 0.02133063028843807d), new NpgsqlTypes.NpgsqlPoint(x: 0.6475617147694127d, y: 0.6299295194284568d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6600016975517111d, y: 0.08199927928928341d), new NpgsqlTypes.NpgsqlPoint(x: 0.39812277995758016d, y: 0.20707075374902784d), new NpgsqlTypes.NpgsqlPoint(x: 0.30017442555508667d, y: 0.25474236941991646d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32990818147410583d, y: 0.21394914059647463d), new NpgsqlTypes.NpgsqlPoint(x: 0.6265774473386442d, y: 0.20582974103334672d), new NpgsqlTypes.NpgsqlPoint(x: 0.3695682546043062d, y: 0.5387874135933481d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7964238657152672d, y: 0.31941943035179743d), new NpgsqlTypes.NpgsqlPoint(x: 0.5386845954714324d, y: 0.763384015896783d), new NpgsqlTypes.NpgsqlPoint(x: 0.23909176211117222d, y: 0.8839530887485887d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.295266332886182d, y: 0.07210155014849551d), new NpgsqlTypes.NpgsqlPoint(x: 0.9575805615034458d, y: 0.7518730919734742d), new NpgsqlTypes.NpgsqlPoint(x: 0.6423765512589746d, y: 0.062375212121116075d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.673085388779768d, y: 0.26160373979461005d), new NpgsqlTypes.NpgsqlPoint(x: 0.48661150658251917d, y: 0.6627158819280364d), new NpgsqlTypes.NpgsqlPoint(x: 0.11571406313295152d, y: 0.6611464096447343d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7216582438546226d, y: 0.019669327730432173d), new NpgsqlTypes.NpgsqlPoint(x: 0.9660857485881725d, y: 0.24251623207045525d), new NpgsqlTypes.NpgsqlPoint(x: 0.5126277563232219d, y: 0.686144585295389d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.804848731498434d, y: 0.515600463368776d), new NpgsqlTypes.NpgsqlPoint(x: 0.7453285736150922d, y: 0.6406272717277202d), new NpgsqlTypes.NpgsqlPoint(x: 0.7985960893069715d, y: 0.9104532393651408d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31144798142525554d, y: 0.8731119534263985d), new NpgsqlTypes.NpgsqlPoint(x: 0.052331659836125866d, y: 0.34869132006469805d), new NpgsqlTypes.NpgsqlPoint(x: 0.3004742237070356d, y: 0.4577208204052471d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9344623141408083d, y: 0.6683945627242385d), new NpgsqlTypes.NpgsqlPoint(x: 0.30021506326779057d, y: 0.13520181529804542d), new NpgsqlTypes.NpgsqlPoint(x: 0.7095220066440876d, y: 0.2477402225294496d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6169090626590855d, y: 0.02133582755761454d), new NpgsqlTypes.NpgsqlPoint(x: 0.4375881203925843d, y: 0.8085835015704382d), new NpgsqlTypes.NpgsqlPoint(x: 0.27153064322034237d, y: 0.7734881101421256d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.020531833992817106d, y: 0.4645840275417408d), new NpgsqlTypes.NpgsqlPoint(x: 0.22905243762760197d, y: 0.506606295036181d), new NpgsqlTypes.NpgsqlPoint(x: 0.5185260237581428d, y: 0.08323639482771583d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6251878180513185d, y: 0.551307000816941d), new NpgsqlTypes.NpgsqlPoint(x: 0.6467863614283178d, y: 0.5680325175982043d), new NpgsqlTypes.NpgsqlPoint(x: 0.8648432057237618d, y: 0.23285605513059182d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5824038597284787d, y: 0.15956156403394284d), new NpgsqlTypes.NpgsqlPoint(x: 0.9871041413564059d, y: 0.7114292352074416d), new NpgsqlTypes.NpgsqlPoint(x: 0.24317885068783396d, y: 0.7195807569340451d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6799020631569155d, y: 0.3661329887547604d), new NpgsqlTypes.NpgsqlPoint(x: 0.6044900196908572d, y: 0.22275899324149595d), new NpgsqlTypes.NpgsqlPoint(x: 0.5020579767228808d, y: 0.06478120772491558d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2637730052494801d, y: 0.3614369198091717d), new NpgsqlTypes.NpgsqlPoint(x: 0.2623338381559023d, y: 0.11753492245685704d), new NpgsqlTypes.NpgsqlPoint(x: 0.25291141205774126d, y: 0.3907539464835589d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9254951515117306d, y: 0.4441269333479926d), new NpgsqlTypes.NpgsqlPoint(x: 0.02631854562186975d, y: 0.6037756030583562d), new NpgsqlTypes.NpgsqlPoint(x: 0.7721560021077639d, y: 0.21480022295620083d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7168476390948616d, y: 0.37127707358584316d), new NpgsqlTypes.NpgsqlPoint(x: 0.10964861054877317d, y: 0.32885773759464243d), new NpgsqlTypes.NpgsqlPoint(x: 0.5177085999982836d, y: 0.11105403926903545d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7326739132084492d, y: 0.8697513034668726d), new NpgsqlTypes.NpgsqlPoint(x: 0.18683719004752886d, y: 0.7879033022768137d), new NpgsqlTypes.NpgsqlPoint(x: 0.5877916596845371d, y: 0.28416468003152395d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05960182881994547d, y: 0.4557615563940953d), new NpgsqlTypes.NpgsqlPoint(x: 0.2201881733334411d, y: 0.9961721239218402d), new NpgsqlTypes.NpgsqlPoint(x: 0.3752525826331925d, y: 0.041500241033898266d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20537298758971045d, y: 0.3353778012894554d), new NpgsqlTypes.NpgsqlPoint(x: 0.031867596744828974d, y: 0.6397728480736445d), new NpgsqlTypes.NpgsqlPoint(x: 0.4838209573273561d, y: 0.8489907087908115d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6302064497588848d, y: 0.5998217393683163d), new NpgsqlTypes.NpgsqlPoint(x: 0.556326721674881d, y: 0.1019292755035357d), new NpgsqlTypes.NpgsqlPoint(x: 0.35993417689588214d, y: 0.6043356563215999d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6455307128535636d, y: 0.9291053838456509d), new NpgsqlTypes.NpgsqlPoint(x: 0.13713142694390446d, y: 0.4951891333884334d), new NpgsqlTypes.NpgsqlPoint(x: 0.7205632944765388d, y: 0.4464153971851762d)), }, }, },
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33041960286312366d, y: 0.19139888319575937d), new NpgsqlTypes.NpgsqlPoint(x: 0.05486942678934914d, y: 0.7849987651181386d), new NpgsqlTypes.NpgsqlPoint(x: 0.854034711320348d, y: 0.8749605261419372d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9335437732874106d, y: 0.9068276971081259d), new NpgsqlTypes.NpgsqlPoint(x: 0.9712883167158657d, y: 0.22776789478947368d), new NpgsqlTypes.NpgsqlPoint(x: 0.564425365402285d, y: 0.7654580396088426d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10245411141582594d, y: 0.586726869263d), new NpgsqlTypes.NpgsqlPoint(x: 0.41047143043429746d, y: 0.6986920884390942d), new NpgsqlTypes.NpgsqlPoint(x: 0.443084570492125d, y: 0.6390841838323579d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07211299216182943d, y: 0.8420833225221078d), new NpgsqlTypes.NpgsqlPoint(x: 0.6971979307028778d, y: 0.20287687322348524d), new NpgsqlTypes.NpgsqlPoint(x: 0.31208962691019704d, y: 0.8163575997180524d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20244123170878814d, y: 0.1533175281331377d), new NpgsqlTypes.NpgsqlPoint(x: 0.45020789536228756d, y: 0.2384321711663735d), new NpgsqlTypes.NpgsqlPoint(x: 0.26549253394897865d, y: 0.8685843844936892d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33855109406684014d, y: 0.13189384924856873d), new NpgsqlTypes.NpgsqlPoint(x: 0.746146140266903d, y: 0.14357490028701803d), new NpgsqlTypes.NpgsqlPoint(x: 0.6144438930365701d, y: 0.8140521488153526d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46910026524803394d, y: 0.3298439251181454d), new NpgsqlTypes.NpgsqlPoint(x: 0.040729910555452165d, y: 0.75919132324687d), new NpgsqlTypes.NpgsqlPoint(x: 0.37706224062836935d, y: 0.9932814785200353d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8740867475372661d, y: 0.27785548278206085d), new NpgsqlTypes.NpgsqlPoint(x: 0.5636623600260601d, y: 0.4480169021566247d), new NpgsqlTypes.NpgsqlPoint(x: 0.6122571383593611d, y: 0.05023028920150896d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3704056175939082d, y: 0.5042917765353636d), new NpgsqlTypes.NpgsqlPoint(x: 0.09759702456998087d, y: 0.9619277131509434d), new NpgsqlTypes.NpgsqlPoint(x: 0.19146066477874624d, y: 0.3593834917504062d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1267342536846553d, y: 0.41182132132757676d), new NpgsqlTypes.NpgsqlPoint(x: 0.20316145751127246d, y: 0.46761077116328764d), new NpgsqlTypes.NpgsqlPoint(x: 0.1117547892117795d, y: 0.7503142262801638d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23057323572219224d, y: 0.03886006244270057d), new NpgsqlTypes.NpgsqlPoint(x: 0.006428767302488425d, y: 0.21889233305780864d), new NpgsqlTypes.NpgsqlPoint(x: 0.04570411758180759d, y: 0.6349172404044862d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5960001088307857d, y: 0.38968127142100073d), new NpgsqlTypes.NpgsqlPoint(x: 0.7648770350111584d, y: 0.8859023515884079d), new NpgsqlTypes.NpgsqlPoint(x: 0.786891048815373d, y: 0.5110095415078056d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7598437544198374d, y: 0.9649107614051531d), new NpgsqlTypes.NpgsqlPoint(x: 0.8063763193900941d, y: 0.4373414915723427d), new NpgsqlTypes.NpgsqlPoint(x: 0.7101137649113645d, y: 0.8109040016219955d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.713963183112753d, y: 0.5160356507591319d), new NpgsqlTypes.NpgsqlPoint(x: 0.7389419023051362d, y: 0.22957494834382142d), new NpgsqlTypes.NpgsqlPoint(x: 0.4014408190535713d, y: 0.11852689287807483d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2769685756400625d, y: 0.4664330461047128d), new NpgsqlTypes.NpgsqlPoint(x: 0.6608856421568178d, y: 0.43921651471084766d), new NpgsqlTypes.NpgsqlPoint(x: 0.8760830932121945d, y: 0.27172766204184284d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4995797390938783d, y: 0.16399968318117575d), new NpgsqlTypes.NpgsqlPoint(x: 0.40385733497112275d, y: 0.4432895210477159d), new NpgsqlTypes.NpgsqlPoint(x: 0.7066250392232276d, y: 0.3992157707002669d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05335744689625266d, y: 0.8483443862463715d), new NpgsqlTypes.NpgsqlPoint(x: 0.6731405065647681d, y: 0.06976574530748347d), new NpgsqlTypes.NpgsqlPoint(x: 0.4589070814878906d, y: 0.09900474484341959d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8010677720137789d, y: 0.903441806269164d), new NpgsqlTypes.NpgsqlPoint(x: 0.0225234695529829d, y: 0.8442824855780607d), new NpgsqlTypes.NpgsqlPoint(x: 0.05191581692579439d, y: 0.7505369889775755d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6725830196517302d, y: 0.7980190980347971d), new NpgsqlTypes.NpgsqlPoint(x: 0.9747505699947508d, y: 0.5593440676640925d), new NpgsqlTypes.NpgsqlPoint(x: 0.5281064069362563d, y: 0.3884951419748255d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8299348822793553d, y: 0.5672644055572379d), new NpgsqlTypes.NpgsqlPoint(x: 0.22385737412347173d, y: 0.7563690260454288d), new NpgsqlTypes.NpgsqlPoint(x: 0.008794671878627147d, y: 0.9670612909175172d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9735880315663988d, y: 0.14695314126791925d), new NpgsqlTypes.NpgsqlPoint(x: 0.7580979168138767d, y: 0.1635320470815067d), new NpgsqlTypes.NpgsqlPoint(x: 0.941456768457483d, y: 0.05764341492302072d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07334086670137507d, y: 0.6549441939291333d), new NpgsqlTypes.NpgsqlPoint(x: 0.818823688585073d, y: 0.5116783898993286d), new NpgsqlTypes.NpgsqlPoint(x: 0.23188102425207935d, y: 0.788448263118415d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5278882333069703d, y: 0.5581516373899431d), new NpgsqlTypes.NpgsqlPoint(x: 0.37715856900096345d, y: 0.3320901568143422d), new NpgsqlTypes.NpgsqlPoint(x: 0.5699363634703517d, y: 0.1317873683632812d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9570973226143282d, y: 0.23024598315154976d), new NpgsqlTypes.NpgsqlPoint(x: 0.10431696685375702d, y: 0.49895239833665905d), new NpgsqlTypes.NpgsqlPoint(x: 0.8533337975920675d, y: 0.7784706590332089d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1427521926855052d, y: 0.4280085106700867d), new NpgsqlTypes.NpgsqlPoint(x: 0.7552772086060116d, y: 0.1587627387577184d), new NpgsqlTypes.NpgsqlPoint(x: 0.028428604475343233d, y: 0.9543506753135251d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32389156421099075d, y: 0.7701209513699276d), new NpgsqlTypes.NpgsqlPoint(x: 0.7750624292309612d, y: 0.6665479285844801d), new NpgsqlTypes.NpgsqlPoint(x: 0.9608720521560503d, y: 0.2602673674441508d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18420831185434616d, y: 0.8184921843948506d), new NpgsqlTypes.NpgsqlPoint(x: 0.8993596359656305d, y: 0.9385836912575927d), new NpgsqlTypes.NpgsqlPoint(x: 0.7466275115299074d, y: 0.6440109569798416d)), }, }, },
    ModelInner = new NpgsqlPathpathMMArrayD3E1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2714792361985495d, y: 0.2932549357043924d), new NpgsqlTypes.NpgsqlPoint(x: 0.9218985570113087d, y: 0.9603244600096503d), new NpgsqlTypes.NpgsqlPoint(x: 0.4498999895455601d, y: 0.35627993470370933d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08351848640726645d, y: 0.613993568894274d), new NpgsqlTypes.NpgsqlPoint(x: 0.11366484768256635d, y: 0.5168957455404132d), new NpgsqlTypes.NpgsqlPoint(x: 0.6036579620637372d, y: 0.6841052617739111d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8262615262638461d, y: 0.9730709017068851d), new NpgsqlTypes.NpgsqlPoint(x: 0.6660734902806263d, y: 0.6074133705799891d), new NpgsqlTypes.NpgsqlPoint(x: 0.9892716551016116d, y: 0.3654821349443028d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5868505908539856d, y: 0.5433880176994326d), new NpgsqlTypes.NpgsqlPoint(x: 0.8341585407713907d, y: 0.9309697940093993d), new NpgsqlTypes.NpgsqlPoint(x: 0.5784847851901674d, y: 0.7934476346561066d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8661528117554272d, y: 0.42881995981777454d), new NpgsqlTypes.NpgsqlPoint(x: 0.8825877749521964d, y: 0.48351490728408475d), new NpgsqlTypes.NpgsqlPoint(x: 0.8822759625319996d, y: 0.22204819350199512d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9117048318371916d, y: 0.8172204203788972d), new NpgsqlTypes.NpgsqlPoint(x: 0.017365140343385987d, y: 0.008847102052760736d), new NpgsqlTypes.NpgsqlPoint(x: 0.3299274923242107d, y: 0.815198074559023d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15972492118371584d, y: 0.34384093718088715d), new NpgsqlTypes.NpgsqlPoint(x: 0.6457489924358348d, y: 0.08548965482907767d), new NpgsqlTypes.NpgsqlPoint(x: 0.4183512304049276d, y: 0.05392361414489588d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7284024248185614d, y: 0.4676492567848788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7373843351328642d, y: 0.23678073410063039d), new NpgsqlTypes.NpgsqlPoint(x: 0.9288730392168785d, y: 0.5093010230077856d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.85213427890024d, y: 0.20548766810903607d), new NpgsqlTypes.NpgsqlPoint(x: 0.16165380326649648d, y: 0.37335291614514554d), new NpgsqlTypes.NpgsqlPoint(x: 0.812645449332846d, y: 0.3074924309646453d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48315573555820546d, y: 0.6784761377951268d), new NpgsqlTypes.NpgsqlPoint(x: 0.5715911884590555d, y: 0.4137392094347665d), new NpgsqlTypes.NpgsqlPoint(x: 0.21646327341270555d, y: 0.6765077526360187d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10781152299727226d, y: 0.03014519703938745d), new NpgsqlTypes.NpgsqlPoint(x: 0.15327959720832407d, y: 0.13264905633974944d), new NpgsqlTypes.NpgsqlPoint(x: 0.9535803127753272d, y: 0.1302124908562985d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21307760032634793d, y: 0.5522503251906229d), new NpgsqlTypes.NpgsqlPoint(x: 0.39029985799272104d, y: 0.9157216606946014d), new NpgsqlTypes.NpgsqlPoint(x: 0.18796290377208957d, y: 0.8403133118524756d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6269704553804781d, y: 0.7583659695140686d), new NpgsqlTypes.NpgsqlPoint(x: 0.5070943671671464d, y: 0.9710019100771932d), new NpgsqlTypes.NpgsqlPoint(x: 0.5330119997811522d, y: 0.1413705062647399d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34934656617058657d, y: 0.7444883084299005d), new NpgsqlTypes.NpgsqlPoint(x: 0.032226395513939465d, y: 0.5923926896903831d), new NpgsqlTypes.NpgsqlPoint(x: 0.1293776006153896d, y: 0.1438022219111842d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03864701443406149d, y: 0.5854505768797755d), new NpgsqlTypes.NpgsqlPoint(x: 0.8276398839498257d, y: 0.4303029142553604d), new NpgsqlTypes.NpgsqlPoint(x: 0.7892094702761484d, y: 0.8735424472045934d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3434710828050769d, y: 0.6375984294048266d), new NpgsqlTypes.NpgsqlPoint(x: 0.6207256398560318d, y: 0.729710098903815d), new NpgsqlTypes.NpgsqlPoint(x: 0.39401835771452265d, y: 0.13071774693444727d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5047212016357612d, y: 0.12318575506856322d), new NpgsqlTypes.NpgsqlPoint(x: 0.7170936229775444d, y: 0.4813578377809513d), new NpgsqlTypes.NpgsqlPoint(x: 0.7867169810787199d, y: 0.2999201046223583d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.361528383541751d, y: 0.2941692505008854d), new NpgsqlTypes.NpgsqlPoint(x: 0.6407867459658428d, y: 0.05876510183613648d), new NpgsqlTypes.NpgsqlPoint(x: 0.45638899954138035d, y: 0.18909453171089263d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9935653563288349d, y: 0.8826238548744805d), new NpgsqlTypes.NpgsqlPoint(x: 0.49878912000262365d, y: 0.10712008020371078d), new NpgsqlTypes.NpgsqlPoint(x: 0.6947315341571454d, y: 0.05841886263366214d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6778583057738382d, y: 0.9629862512785258d), new NpgsqlTypes.NpgsqlPoint(x: 0.7775587323393045d, y: 0.6519840849042741d), new NpgsqlTypes.NpgsqlPoint(x: 0.4238741230989469d, y: 0.06765131398492907d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7538329285812554d, y: 0.2308561065931417d), new NpgsqlTypes.NpgsqlPoint(x: 0.8862520965785119d, y: 0.6231858769375809d), new NpgsqlTypes.NpgsqlPoint(x: 0.32266747265354545d, y: 0.6505012668903539d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36068715574980204d, y: 0.1847061223010199d), new NpgsqlTypes.NpgsqlPoint(x: 0.4535153464225665d, y: 0.8931431348787202d), new NpgsqlTypes.NpgsqlPoint(x: 0.9035671640756553d, y: 0.340388224987507d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7485312448412577d, y: 0.17859335360745743d), new NpgsqlTypes.NpgsqlPoint(x: 0.6850505378365426d, y: 0.04939183127943536d), new NpgsqlTypes.NpgsqlPoint(x: 0.7187719005111566d, y: 0.15498474651784455d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7726871679999802d, y: 0.7825539310507097d), new NpgsqlTypes.NpgsqlPoint(x: 0.18121429592031124d, y: 0.8893712752489048d), new NpgsqlTypes.NpgsqlPoint(x: 0.7303665035082701d, y: 0.28028450398607085d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2506109504653897d, y: 0.6732320696736319d), new NpgsqlTypes.NpgsqlPoint(x: 0.6938101478801224d, y: 0.829080828590956d), new NpgsqlTypes.NpgsqlPoint(x: 0.009174948418642637d, y: 0.6913505316484884d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23138166763694767d, y: 0.36354897473528536d), new NpgsqlTypes.NpgsqlPoint(x: 0.19969728564508027d, y: 0.23054564931554133d), new NpgsqlTypes.NpgsqlPoint(x: 0.4264583487502982d, y: 0.776584696217514d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.890048478882422d, y: 0.5042012756782793d), new NpgsqlTypes.NpgsqlPoint(x: 0.9724331647666755d, y: 0.46079753873164264d), new NpgsqlTypes.NpgsqlPoint(x: 0.1358334425495099d, y: 0.5823965093746242d)), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8664088457573318d, y: 0.13703931250981494d), new NpgsqlTypes.NpgsqlPoint(x: 0.4085169928290382d, y: 0.23770554030651814d), new NpgsqlTypes.NpgsqlPoint(x: 0.614580376217905d, y: 0.8036250385929504d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5556359931052256d, y: 0.6955424994288137d), new NpgsqlTypes.NpgsqlPoint(x: 0.8254421357828884d, y: 0.581405631914516d), new NpgsqlTypes.NpgsqlPoint(x: 0.3114741110621664d, y: 0.2177526707502141d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23553028460614023d, y: 0.7139547382417457d), new NpgsqlTypes.NpgsqlPoint(x: 0.08979844395151271d, y: 0.26831263160039853d), new NpgsqlTypes.NpgsqlPoint(x: 0.10070497373845932d, y: 0.8387358601444701d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5445982513814637d, y: 0.3915815108719668d), new NpgsqlTypes.NpgsqlPoint(x: 0.1803139614018009d, y: 0.7398745987262303d), new NpgsqlTypes.NpgsqlPoint(x: 0.8949442549680794d, y: 0.6789534438972822d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3527764822375923d, y: 0.014819572571856288d), new NpgsqlTypes.NpgsqlPoint(x: 0.7475548367485475d, y: 0.627355726499288d), new NpgsqlTypes.NpgsqlPoint(x: 0.7828471049487085d, y: 0.6825385031930657d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9834560156562003d, y: 0.6296561323951406d), new NpgsqlTypes.NpgsqlPoint(x: 0.11669202157276792d, y: 0.500781875096966d), new NpgsqlTypes.NpgsqlPoint(x: 0.0807383132327053d, y: 0.6521551717308942d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7151037222824997d, y: 0.7614301288482381d), new NpgsqlTypes.NpgsqlPoint(x: 0.6426665106498507d, y: 0.6164442662668858d), new NpgsqlTypes.NpgsqlPoint(x: 0.816185616357885d, y: 0.3778174446597078d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37871891883164177d, y: 0.39465818138208897d), new NpgsqlTypes.NpgsqlPoint(x: 0.26636844064442156d, y: 0.7527829526618809d), new NpgsqlTypes.NpgsqlPoint(x: 0.06549658587714147d, y: 0.6735980856973949d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9154712343004214d, y: 0.6589170061788137d), new NpgsqlTypes.NpgsqlPoint(x: 0.04498272755371402d, y: 0.05714052775832046d), new NpgsqlTypes.NpgsqlPoint(x: 0.03548543241836988d, y: 0.062343774919132566d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39929962441725875d, y: 0.07587050225495495d), new NpgsqlTypes.NpgsqlPoint(x: 0.12289129914871055d, y: 0.12500608719645534d), new NpgsqlTypes.NpgsqlPoint(x: 0.06376271915208676d, y: 0.5885520057661805d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27721258789339487d, y: 0.9848556379667743d), new NpgsqlTypes.NpgsqlPoint(x: 0.48211472482753137d, y: 0.7702907171677015d), new NpgsqlTypes.NpgsqlPoint(x: 0.2104328050275842d, y: 0.061071403158416304d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8000223658863339d, y: 0.7754867549023763d), new NpgsqlTypes.NpgsqlPoint(x: 0.10955750858833069d, y: 0.596577395013806d), new NpgsqlTypes.NpgsqlPoint(x: 0.07253487108182977d, y: 0.6629118356929524d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6845861081291931d, y: 0.31890620366515043d), new NpgsqlTypes.NpgsqlPoint(x: 0.0655095717506724d, y: 0.5322885666935862d), new NpgsqlTypes.NpgsqlPoint(x: 0.4873467514367473d, y: 0.5362098657676424d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9759276409674617d, y: 0.8532865830800926d), new NpgsqlTypes.NpgsqlPoint(x: 0.30953308543838975d, y: 0.8099110734527587d), new NpgsqlTypes.NpgsqlPoint(x: 0.9478367673728657d, y: 0.9454345380620849d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36598371945623d, y: 0.7027533423023626d), new NpgsqlTypes.NpgsqlPoint(x: 0.9482426862818796d, y: 0.27768680710537685d), new NpgsqlTypes.NpgsqlPoint(x: 0.8375318723847937d, y: 0.7108479919934924d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06177171448730234d, y: 0.3116528109366662d), new NpgsqlTypes.NpgsqlPoint(x: 0.5940028947537157d, y: 0.9196539078195267d), new NpgsqlTypes.NpgsqlPoint(x: 0.29918687277711464d, y: 0.3361963217752131d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02142087550885341d, y: 0.3515836967134379d), new NpgsqlTypes.NpgsqlPoint(x: 0.981835683085789d, y: 0.0706881859759263d), new NpgsqlTypes.NpgsqlPoint(x: 0.4524831143386471d, y: 0.4768924976003571d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31441865440183514d, y: 0.9947741065546953d), new NpgsqlTypes.NpgsqlPoint(x: 0.2197858578200147d, y: 0.9410143097507013d), new NpgsqlTypes.NpgsqlPoint(x: 0.29826722814171847d, y: 0.5202191424061283d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5269112935097169d, y: 0.08480630667676248d), new NpgsqlTypes.NpgsqlPoint(x: 0.6283144141434355d, y: 0.7674329260768608d), new NpgsqlTypes.NpgsqlPoint(x: 0.4355382467522694d, y: 0.03128130577375676d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3259329405306387d, y: 0.462322809016134d), new NpgsqlTypes.NpgsqlPoint(x: 0.8301354551620214d, y: 0.12654221073975191d), new NpgsqlTypes.NpgsqlPoint(x: 0.8428381478453472d, y: 0.14492967956624447d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.803695913804979d, y: 0.5595046272390122d), new NpgsqlTypes.NpgsqlPoint(x: 0.6012179044684817d, y: 0.9985486937622335d), new NpgsqlTypes.NpgsqlPoint(x: 0.4539009528944742d, y: 0.22294963607175222d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03567884193440152d, y: 0.49553211360297755d), new NpgsqlTypes.NpgsqlPoint(x: 0.6541081360536881d, y: 0.6333445685173055d), new NpgsqlTypes.NpgsqlPoint(x: 0.6273647408052219d, y: 0.988487771260594d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9730824797821483d, y: 0.76137444662535d), new NpgsqlTypes.NpgsqlPoint(x: 0.11836602930647777d, y: 0.5044616569616116d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455257780493498d, y: 0.5104636290277942d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5264473603455776d, y: 0.10157826273027182d), new NpgsqlTypes.NpgsqlPoint(x: 0.326973930843908d, y: 0.7156533021387671d), new NpgsqlTypes.NpgsqlPoint(x: 0.8654581055370086d, y: 0.0663829965076298d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9495260401983194d, y: 0.6362787494148221d), new NpgsqlTypes.NpgsqlPoint(x: 0.8282480412798463d, y: 0.5331767399304944d), new NpgsqlTypes.NpgsqlPoint(x: 0.25678182689496465d, y: 0.9583300996046943d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49308709601253986d, y: 0.8274741949388463d), new NpgsqlTypes.NpgsqlPoint(x: 0.9743322121562857d, y: 0.7594281992586759d), new NpgsqlTypes.NpgsqlPoint(x: 0.16749262785157004d, y: 0.9858729931630767d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8831202480429253d, y: 0.668422991163673d), new NpgsqlTypes.NpgsqlPoint(x: 0.9466674419089395d, y: 0.8828140423509635d), new NpgsqlTypes.NpgsqlPoint(x: 0.11991688119827792d, y: 0.1504738715805639d)), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10451994160205635d, y: 0.7578467982216661d), new NpgsqlTypes.NpgsqlPoint(x: 0.007838672415780734d, y: 0.8907137617451305d), new NpgsqlTypes.NpgsqlPoint(x: 0.4146236009403259d, y: 0.190768786251039d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7505229837915215d, y: 0.5895315098232815d), new NpgsqlTypes.NpgsqlPoint(x: 0.3105929814287103d, y: 0.36874301324730374d), new NpgsqlTypes.NpgsqlPoint(x: 0.29679585994136803d, y: 0.37493080157394376d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7622560590856374d, y: 0.9766491775473903d), new NpgsqlTypes.NpgsqlPoint(x: 0.3586935192919165d, y: 0.4243187115761273d), new NpgsqlTypes.NpgsqlPoint(x: 0.5832646086000649d, y: 0.290846625667874d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4927368212769252d, y: 0.7211084247308246d), new NpgsqlTypes.NpgsqlPoint(x: 0.3182071153140742d, y: 0.6959924373545262d), new NpgsqlTypes.NpgsqlPoint(x: 0.4736945907826535d, y: 0.24076615340760932d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8597679595621492d, y: 0.14200026094046225d), new NpgsqlTypes.NpgsqlPoint(x: 0.7934446094480071d, y: 0.7178202233850055d), new NpgsqlTypes.NpgsqlPoint(x: 0.0086748716630628d, y: 0.47724427040850703d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5535665396056596d, y: 0.7856045846787018d), new NpgsqlTypes.NpgsqlPoint(x: 0.5742604462614908d, y: 0.8541057556898376d), new NpgsqlTypes.NpgsqlPoint(x: 0.4063166313772001d, y: 0.952597412060413d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34060964757571766d, y: 0.09606936432354496d), new NpgsqlTypes.NpgsqlPoint(x: 0.9636159145044837d, y: 0.6652593422095067d), new NpgsqlTypes.NpgsqlPoint(x: 0.11286804237298065d, y: 0.7812732906452174d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6002537665352461d, y: 0.6101764429514248d), new NpgsqlTypes.NpgsqlPoint(x: 0.31002444534720897d, y: 0.30125590946593095d), new NpgsqlTypes.NpgsqlPoint(x: 0.32309685098085694d, y: 0.057899907100195214d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16657527459618815d, y: 0.4259568614970418d), new NpgsqlTypes.NpgsqlPoint(x: 0.5976883875436132d, y: 0.9491626787385873d), new NpgsqlTypes.NpgsqlPoint(x: 0.1300258995475504d, y: 0.07048014849491968d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9088929691468347d, y: 0.8429197055554561d), new NpgsqlTypes.NpgsqlPoint(x: 0.4399582737601988d, y: 0.9051952628994746d), new NpgsqlTypes.NpgsqlPoint(x: 0.07261910062463306d, y: 0.21532538584996974d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33953126966031644d, y: 0.6523968859208015d), new NpgsqlTypes.NpgsqlPoint(x: 0.9047905231783586d, y: 0.3496352152830672d), new NpgsqlTypes.NpgsqlPoint(x: 0.4227608510218662d, y: 0.7340249807020401d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8451214182048001d, y: 0.7002560272997441d), new NpgsqlTypes.NpgsqlPoint(x: 0.7801855034719668d, y: 0.8317530048201368d), new NpgsqlTypes.NpgsqlPoint(x: 0.9476254405065647d, y: 0.35095911198236984d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2959123423385871d, y: 0.2921192969181743d), new NpgsqlTypes.NpgsqlPoint(x: 0.29527927189698355d, y: 0.2855331600957297d), new NpgsqlTypes.NpgsqlPoint(x: 0.5388647189174851d, y: 0.6967358975753394d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7389092740871224d, y: 0.7037554701392484d), new NpgsqlTypes.NpgsqlPoint(x: 0.9559173662239999d, y: 0.1360328011470836d), new NpgsqlTypes.NpgsqlPoint(x: 0.7009392546276789d, y: 0.9530771004246299d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5700121083674257d, y: 0.33420011914002035d), new NpgsqlTypes.NpgsqlPoint(x: 0.09399310431320307d, y: 0.27900703591137954d), new NpgsqlTypes.NpgsqlPoint(x: 0.21973666365869726d, y: 0.45601901280644874d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6085095765578901d, y: 0.6313127525344225d), new NpgsqlTypes.NpgsqlPoint(x: 0.43354773571122396d, y: 0.09233103229681128d), new NpgsqlTypes.NpgsqlPoint(x: 0.622168048831318d, y: 0.8396255933583827d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4378053939840386d, y: 0.9144696340778442d), new NpgsqlTypes.NpgsqlPoint(x: 0.4358139064259723d, y: 0.4308268233270993d), new NpgsqlTypes.NpgsqlPoint(x: 0.08719649891437531d, y: 0.7504646198186239d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16587225960962504d, y: 0.009516206247891956d), new NpgsqlTypes.NpgsqlPoint(x: 0.36626029386940784d, y: 0.7196367160124957d), new NpgsqlTypes.NpgsqlPoint(x: 0.6908255011788207d, y: 0.8375427679497207d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6776844665858041d, y: 0.5306498172910666d), new NpgsqlTypes.NpgsqlPoint(x: 0.7899406570821159d, y: 0.10040328606965088d), new NpgsqlTypes.NpgsqlPoint(x: 0.42300666873960857d, y: 0.2608765198917564d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08428458791869742d, y: 0.07923157391298385d), new NpgsqlTypes.NpgsqlPoint(x: 0.7525991296564668d, y: 0.018398496660875452d), new NpgsqlTypes.NpgsqlPoint(x: 0.2147896985162976d, y: 0.7514361235729107d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9706165159784889d, y: 0.2639465392447623d), new NpgsqlTypes.NpgsqlPoint(x: 0.8982328058589566d, y: 0.6146999032851073d), new NpgsqlTypes.NpgsqlPoint(x: 0.1898973742534833d, y: 0.23528816573398237d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9219570516763005d, y: 0.5675373421448692d), new NpgsqlTypes.NpgsqlPoint(x: 0.08870277510793279d, y: 0.32182066566870005d), new NpgsqlTypes.NpgsqlPoint(x: 0.6063540160523205d, y: 0.3102163865843569d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8388270294195296d, y: 0.9603549257964713d), new NpgsqlTypes.NpgsqlPoint(x: 0.9464116590001608d, y: 0.9337659518323898d), new NpgsqlTypes.NpgsqlPoint(x: 0.5964164974369622d, y: 0.4843868968753152d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4658242491521871d, y: 0.6728813913993097d), new NpgsqlTypes.NpgsqlPoint(x: 0.626975836808467d, y: 0.2106294485355682d), new NpgsqlTypes.NpgsqlPoint(x: 0.9549855904006815d, y: 0.03771346749250415d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07866875967017417d, y: 0.04285891943899345d), new NpgsqlTypes.NpgsqlPoint(x: 0.9603580607538328d, y: 0.4354730620096092d), new NpgsqlTypes.NpgsqlPoint(x: 0.8514861806650971d, y: 0.16671248542175754d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.029417370040957458d, y: 0.5628294847119917d), new NpgsqlTypes.NpgsqlPoint(x: 0.24688655295058548d, y: 0.5232499155216018d), new NpgsqlTypes.NpgsqlPoint(x: 0.4322740623910831d, y: 0.5522087314516068d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.020018066888738195d, y: 0.4383860603455767d), new NpgsqlTypes.NpgsqlPoint(x: 0.31137967434831415d, y: 0.3085620495931437d), new NpgsqlTypes.NpgsqlPoint(x: 0.7733164819410637d, y: 0.11005264183943908d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6143861899837458d, y: 0.9433543460476933d), new NpgsqlTypes.NpgsqlPoint(x: 0.12038459333481344d, y: 0.6661459492707555d), new NpgsqlTypes.NpgsqlPoint(x: 0.6017944568146093d, y: 0.7248150804967488d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9577095772544133d, y: 0.9382798360073148d), new NpgsqlTypes.NpgsqlPoint(x: 0.009097910736115322d, y: 0.14907761079817894d), new NpgsqlTypes.NpgsqlPoint(x: 0.9375615500502844d, y: 0.18511889923428304d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8678983344644104d, y: 0.5091072162997009d), new NpgsqlTypes.NpgsqlPoint(x: 0.2118193640606335d, y: 0.24634006569157496d), new NpgsqlTypes.NpgsqlPoint(x: 0.12961829599023234d, y: 0.020308011456775077d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16431539938696704d, y: 0.4727206486792913d), new NpgsqlTypes.NpgsqlPoint(x: 0.15914336119156303d, y: 0.24939999865834062d), new NpgsqlTypes.NpgsqlPoint(x: 0.6862205537993248d, y: 0.9679658156142492d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07424608553078049d, y: 0.34384599759155754d), new NpgsqlTypes.NpgsqlPoint(x: 0.046487352971788964d, y: 0.9267750992143547d), new NpgsqlTypes.NpgsqlPoint(x: 0.7539609919995909d, y: 0.16128994995064694d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7113500443665682d, y: 0.23384272443853482d), new NpgsqlTypes.NpgsqlPoint(x: 0.6568683444807923d, y: 0.3562282333340253d), new NpgsqlTypes.NpgsqlPoint(x: 0.3333361626814755d, y: 0.9898041566503014d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5549504889294425d, y: 0.9621794074409088d), new NpgsqlTypes.NpgsqlPoint(x: 0.37216372787868257d, y: 0.3195435862754642d), new NpgsqlTypes.NpgsqlPoint(x: 0.9357437676090384d, y: 0.969967392564382d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8494962674052333d, y: 0.16107305319443366d), new NpgsqlTypes.NpgsqlPoint(x: 0.8885826067686484d, y: 0.16615791081574982d), new NpgsqlTypes.NpgsqlPoint(x: 0.9729066093413968d, y: 0.12987402156310401d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4535444199803671d, y: 0.4865103874131441d), new NpgsqlTypes.NpgsqlPoint(x: 0.01728393523444849d, y: 0.35933618652241894d), new NpgsqlTypes.NpgsqlPoint(x: 0.12126467701487986d, y: 0.11441258080391481d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.881992267657717d, y: 0.23316583477158193d), new NpgsqlTypes.NpgsqlPoint(x: 0.21364750611253625d, y: 0.023393054968238958d), new NpgsqlTypes.NpgsqlPoint(x: 0.28016803841681226d, y: 0.863360611248167d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8181245645306362d, y: 0.05130882911681667d), new NpgsqlTypes.NpgsqlPoint(x: 0.6171771028213526d, y: 0.05413806842232727d), new NpgsqlTypes.NpgsqlPoint(x: 0.4396753375893634d, y: 0.20644309760854185d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.614583455039514d, y: 0.3530205538706074d), new NpgsqlTypes.NpgsqlPoint(x: 0.5700305352901126d, y: 0.45816207665748254d), new NpgsqlTypes.NpgsqlPoint(x: 0.2877592450701376d, y: 0.9942004492384521d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3391883441970851d, y: 0.7486135675055076d), new NpgsqlTypes.NpgsqlPoint(x: 0.061794559987399134d, y: 0.3840002817231727d), new NpgsqlTypes.NpgsqlPoint(x: 0.7808101820703128d, y: 0.9993976187730278d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2686456663799589d, y: 0.18585416862510962d), new NpgsqlTypes.NpgsqlPoint(x: 0.8127569094968256d, y: 0.609163416314902d), new NpgsqlTypes.NpgsqlPoint(x: 0.6755016366085594d, y: 0.19487866864265269d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5506893505122008d, y: 0.9285684791399942d), new NpgsqlTypes.NpgsqlPoint(x: 0.3790965708269505d, y: 0.49680568298720573d), new NpgsqlTypes.NpgsqlPoint(x: 0.33629047852188065d, y: 0.5126573025996315d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4663178569873462d, y: 0.3457382701552364d), new NpgsqlTypes.NpgsqlPoint(x: 0.11917680246619644d, y: 0.6000695671868319d), new NpgsqlTypes.NpgsqlPoint(x: 0.019129575604100446d, y: 0.7360861276685902d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8891621349981401d, y: 0.046729273317224096d), new NpgsqlTypes.NpgsqlPoint(x: 0.3513689078497507d, y: 0.22631772513155335d), new NpgsqlTypes.NpgsqlPoint(x: 0.8468467070534553d, y: 0.733488807441473d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24773057523378084d, y: 0.8861582472717519d), new NpgsqlTypes.NpgsqlPoint(x: 0.7484057755086916d, y: 0.5895380868463306d), new NpgsqlTypes.NpgsqlPoint(x: 0.22562251372395437d, y: 0.7202901743456604d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1640440068447543d, y: 0.16420869073774302d), new NpgsqlTypes.NpgsqlPoint(x: 0.30358439402245807d, y: 0.9318224536866687d), new NpgsqlTypes.NpgsqlPoint(x: 0.9311538023511063d, y: 0.24186937605386238d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15685023824353583d, y: 0.6523299583992878d), new NpgsqlTypes.NpgsqlPoint(x: 0.49418993341594275d, y: 0.3935425301801584d), new NpgsqlTypes.NpgsqlPoint(x: 0.36356483265886563d, y: 0.09552266546181498d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1731366381478341d, y: 0.25943497202637533d), new NpgsqlTypes.NpgsqlPoint(x: 0.0020684173248747273d, y: 0.20535590362807932d), new NpgsqlTypes.NpgsqlPoint(x: 0.9897399244568608d, y: 0.13730334515215403d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7957876154561598d, y: 0.566154489173277d), new NpgsqlTypes.NpgsqlPoint(x: 0.8948103279176216d, y: 0.19657408302386692d), new NpgsqlTypes.NpgsqlPoint(x: 0.40783032868301095d, y: 0.23552216311828444d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20691477763185984d, y: 0.34836633584540677d), new NpgsqlTypes.NpgsqlPoint(x: 0.27602500851936396d, y: 0.9985341009452012d), new NpgsqlTypes.NpgsqlPoint(x: 0.05571561182414031d, y: 0.15423146460679016d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43884363358164247d, y: 0.5675043269221391d), new NpgsqlTypes.NpgsqlPoint(x: 0.4398305580395969d, y: 0.6590416251154807d), new NpgsqlTypes.NpgsqlPoint(x: 0.9147670289961332d, y: 0.43358742313638354d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9467280696896946d, y: 0.2335502122963583d), new NpgsqlTypes.NpgsqlPoint(x: 0.21915679036254698d, y: 0.31074352054248955d), new NpgsqlTypes.NpgsqlPoint(x: 0.2585468814289458d, y: 0.09928678995662599d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4609053911948162d, y: 0.8076953667403094d), new NpgsqlTypes.NpgsqlPoint(x: 0.5851565138660112d, y: 0.44575552758588644d), new NpgsqlTypes.NpgsqlPoint(x: 0.3720939403066117d, y: 0.3909810231608445d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0746163616762563d, y: 0.1872329042865627d), new NpgsqlTypes.NpgsqlPoint(x: 0.6101347229375392d, y: 0.28890853236903d), new NpgsqlTypes.NpgsqlPoint(x: 0.8394888077318802d, y: 0.4040532219392068d)), }, }, },
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41364828589855807d, y: 0.0988280458605506d), new NpgsqlTypes.NpgsqlPoint(x: 0.0695922117425467d, y: 0.14249172551920808d), new NpgsqlTypes.NpgsqlPoint(x: 0.9939239941860807d, y: 0.9201513645819798d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9393131405746356d, y: 0.8752375121526081d), new NpgsqlTypes.NpgsqlPoint(x: 0.7867681957606896d, y: 0.6142917963962611d), new NpgsqlTypes.NpgsqlPoint(x: 0.8811864410726052d, y: 0.5815231721277471d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27916520052365046d, y: 0.22344616565972408d), new NpgsqlTypes.NpgsqlPoint(x: 0.11772164120686246d, y: 0.3494604297849535d), new NpgsqlTypes.NpgsqlPoint(x: 0.2039248954452516d, y: 0.8545896743003604d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5249294327468662d, y: 0.6333293298952968d), new NpgsqlTypes.NpgsqlPoint(x: 0.46296366936550126d, y: 0.8854051625986544d), new NpgsqlTypes.NpgsqlPoint(x: 0.7727936476951134d, y: 0.3062025925510845d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5290191747986539d, y: 0.34318795974462346d), new NpgsqlTypes.NpgsqlPoint(x: 0.25787769553423545d, y: 0.2487402313622311d), new NpgsqlTypes.NpgsqlPoint(x: 0.23449379315362462d, y: 0.4038714081707824d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8561961088608625d, y: 0.4820320293944764d), new NpgsqlTypes.NpgsqlPoint(x: 0.21470596613183102d, y: 0.6457571935475394d), new NpgsqlTypes.NpgsqlPoint(x: 0.38870460232205617d, y: 0.3435786818121507d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7432730399181814d, y: 0.9875572543272824d), new NpgsqlTypes.NpgsqlPoint(x: 0.800263735066403d, y: 0.7209614290823938d), new NpgsqlTypes.NpgsqlPoint(x: 0.18084427584609886d, y: 0.18497962594831374d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8901561376293327d, y: 0.02144281535198045d), new NpgsqlTypes.NpgsqlPoint(x: 0.18172012709294316d, y: 0.9145314238182862d), new NpgsqlTypes.NpgsqlPoint(x: 0.789845569483959d, y: 0.8712866050614791d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.731191425671065d, y: 0.5177355730338976d), new NpgsqlTypes.NpgsqlPoint(x: 0.6386641416701972d, y: 0.46758062232763276d), new NpgsqlTypes.NpgsqlPoint(x: 0.7808528634916766d, y: 0.548251836829907d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8376307356860665d, y: 0.5194038853550619d), new NpgsqlTypes.NpgsqlPoint(x: 0.05489423139072036d, y: 0.8266507639282594d), new NpgsqlTypes.NpgsqlPoint(x: 0.6269460906701168d, y: 0.19912584320838966d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48916505207349836d, y: 0.12797206971561959d), new NpgsqlTypes.NpgsqlPoint(x: 0.13527321784936042d, y: 0.8121445936359906d), new NpgsqlTypes.NpgsqlPoint(x: 0.6312486212941285d, y: 0.2341770382848729d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8997384075257968d, y: 0.8369355447545309d), new NpgsqlTypes.NpgsqlPoint(x: 0.26175906556002526d, y: 0.9240977157634707d), new NpgsqlTypes.NpgsqlPoint(x: 0.6028167115231059d, y: 0.3845705365166676d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5397198205383281d, y: 0.9147830010072912d), new NpgsqlTypes.NpgsqlPoint(x: 0.35090330099822487d, y: 0.3620527476575963d), new NpgsqlTypes.NpgsqlPoint(x: 0.28126443658993816d, y: 0.6129899984563124d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6576693541560786d, y: 0.06851920606079753d), new NpgsqlTypes.NpgsqlPoint(x: 0.768356124919511d, y: 0.542820782265493d), new NpgsqlTypes.NpgsqlPoint(x: 0.3752585712388976d, y: 0.5066798726586607d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46472201143863323d, y: 0.6899489450821515d), new NpgsqlTypes.NpgsqlPoint(x: 0.07902298682400821d, y: 0.8746584263128636d), new NpgsqlTypes.NpgsqlPoint(x: 0.904575755564508d, y: 0.7162593645641071d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9059872407664209d, y: 0.26873736034373286d), new NpgsqlTypes.NpgsqlPoint(x: 0.9092312123931718d, y: 0.6682623034463424d), new NpgsqlTypes.NpgsqlPoint(x: 0.9079188748800144d, y: 0.35192840883059817d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7844522789093178d, y: 0.9455505376716036d), new NpgsqlTypes.NpgsqlPoint(x: 0.45001729360955d, y: 0.7133905061870576d), new NpgsqlTypes.NpgsqlPoint(x: 0.3441691091243674d, y: 0.7357105407401745d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33497619906073994d, y: 0.398162642927242d), new NpgsqlTypes.NpgsqlPoint(x: 0.36222669591138856d, y: 0.7574383821969327d), new NpgsqlTypes.NpgsqlPoint(x: 0.1477909513006891d, y: 0.29974817192400904d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48985322207905724d, y: 0.8229120168510097d), new NpgsqlTypes.NpgsqlPoint(x: 0.5140108101208668d, y: 0.7263556493220694d), new NpgsqlTypes.NpgsqlPoint(x: 0.7818349266436933d, y: 0.26903029816196833d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7561869457478234d, y: 0.5496639663550769d), new NpgsqlTypes.NpgsqlPoint(x: 0.3337701200344445d, y: 0.8934385731075312d), new NpgsqlTypes.NpgsqlPoint(x: 0.16211412307640993d, y: 0.024375013121417655d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8029667459548808d, y: 0.6290889897073246d), new NpgsqlTypes.NpgsqlPoint(x: 0.4915870344039108d, y: 0.37647036501575615d), new NpgsqlTypes.NpgsqlPoint(x: 0.43985920038709925d, y: 0.010560933168485165d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7663300658483005d, y: 0.7402960362848392d), new NpgsqlTypes.NpgsqlPoint(x: 0.5800252952340611d, y: 0.7901538842799003d), new NpgsqlTypes.NpgsqlPoint(x: 0.8209134771387896d, y: 0.9606906374022534d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6762968643367595d, y: 0.6133001005762854d), new NpgsqlTypes.NpgsqlPoint(x: 0.5510284733682406d, y: 0.3534543668894121d), new NpgsqlTypes.NpgsqlPoint(x: 0.11513299278883782d, y: 0.2845759894900962d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9519897394390675d, y: 0.5571403349566822d), new NpgsqlTypes.NpgsqlPoint(x: 0.27017534407672483d, y: 0.41573476672112797d), new NpgsqlTypes.NpgsqlPoint(x: 0.32394926579315d, y: 0.045216479954925504d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7066790189690508d, y: 0.34950570990439533d), new NpgsqlTypes.NpgsqlPoint(x: 0.8047410660391062d, y: 0.2336645675629131d), new NpgsqlTypes.NpgsqlPoint(x: 0.05701000446991422d, y: 0.17724554371797563d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28164354831198113d, y: 0.11888254247274943d), new NpgsqlTypes.NpgsqlPoint(x: 0.4832285104028614d, y: 0.42897717092884247d), new NpgsqlTypes.NpgsqlPoint(x: 0.5537373018286537d, y: 0.2444125758950737d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.771285219675823d, y: 0.589866734222995d), new NpgsqlTypes.NpgsqlPoint(x: 0.34228535799459714d, y: 0.6908126379037223d), new NpgsqlTypes.NpgsqlPoint(x: 0.1817537439506529d, y: 0.08955600202214709d)), }, }, },
    ModelInner = new NpgsqlPathpathMMArrayD3E1MI
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4193573925419989d, y: 0.7603664120421401d), new NpgsqlTypes.NpgsqlPoint(x: 0.5367067692948099d, y: 0.3711415378532209d), new NpgsqlTypes.NpgsqlPoint(x: 0.7370867079396183d, y: 0.7924594145207317d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5820200983586222d, y: 0.9334137074623566d), new NpgsqlTypes.NpgsqlPoint(x: 0.24104048040854853d, y: 0.5700310850387484d), new NpgsqlTypes.NpgsqlPoint(x: 0.04496701232590594d, y: 0.4990732193907764d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3434967409145958d, y: 0.504118316560593d), new NpgsqlTypes.NpgsqlPoint(x: 0.17714451136101295d, y: 0.17313119140962419d), new NpgsqlTypes.NpgsqlPoint(x: 0.0251810926803423d, y: 0.06955079034384415d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5627522383210507d, y: 0.964754160227705d), new NpgsqlTypes.NpgsqlPoint(x: 0.8730559439551818d, y: 0.3880365149786523d), new NpgsqlTypes.NpgsqlPoint(x: 0.509913199779609d, y: 0.5396938706364736d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0362888369892691d, y: 0.08108756852838217d), new NpgsqlTypes.NpgsqlPoint(x: 0.7767754602693284d, y: 0.41393381944404006d), new NpgsqlTypes.NpgsqlPoint(x: 0.418572164827713d, y: 0.16203222162220565d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6881950972463179d, y: 0.41023217835476333d), new NpgsqlTypes.NpgsqlPoint(x: 0.5702649268901456d, y: 0.27255953432886126d), new NpgsqlTypes.NpgsqlPoint(x: 0.4088438522546878d, y: 0.4999737226607863d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07797912800690499d, y: 0.5249560927395466d), new NpgsqlTypes.NpgsqlPoint(x: 0.07049795169466266d, y: 0.9357584705679569d), new NpgsqlTypes.NpgsqlPoint(x: 0.28114253733995465d, y: 0.8721834162873217d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9618047526144087d, y: 0.050704307962481376d), new NpgsqlTypes.NpgsqlPoint(x: 0.9523485769696235d, y: 0.5219445988585301d), new NpgsqlTypes.NpgsqlPoint(x: 0.11971996124384265d, y: 0.47998969921808365d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7898029911951098d, y: 0.44844108010417594d), new NpgsqlTypes.NpgsqlPoint(x: 0.198194748830837d, y: 0.08580248649347033d), new NpgsqlTypes.NpgsqlPoint(x: 0.690788926435261d, y: 0.45199114556227593d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2054406257029734d, y: 0.7046807094712477d), new NpgsqlTypes.NpgsqlPoint(x: 0.49040361693630696d, y: 0.8806701575467555d), new NpgsqlTypes.NpgsqlPoint(x: 0.10848856418604791d, y: 0.7517831831458843d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.280555464674595d, y: 0.9385493795006572d), new NpgsqlTypes.NpgsqlPoint(x: 0.34539807699725555d, y: 0.9674444745430182d), new NpgsqlTypes.NpgsqlPoint(x: 0.3038981848377964d, y: 0.29497364626446d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41927977235202374d, y: 0.5704103749761009d), new NpgsqlTypes.NpgsqlPoint(x: 0.5198868950428387d, y: 0.547269025506843d), new NpgsqlTypes.NpgsqlPoint(x: 0.9919914361285325d, y: 0.8221650484983134d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7357163526377937d, y: 0.8104998399520433d), new NpgsqlTypes.NpgsqlPoint(x: 0.950632960801419d, y: 0.3277677084589581d), new NpgsqlTypes.NpgsqlPoint(x: 0.5652440632436331d, y: 0.08479889847986444d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3341552201881708d, y: 0.18087851780118303d), new NpgsqlTypes.NpgsqlPoint(x: 0.6376199714582059d, y: 0.6725492835548805d), new NpgsqlTypes.NpgsqlPoint(x: 0.9665666490091623d, y: 0.19330727863476294d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21261508115877237d, y: 0.37061255453712216d), new NpgsqlTypes.NpgsqlPoint(x: 0.2316516589515606d, y: 0.7620942645445427d), new NpgsqlTypes.NpgsqlPoint(x: 0.3799570640201203d, y: 0.23778649644404937d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48556886375962716d, y: 0.6386835146048323d), new NpgsqlTypes.NpgsqlPoint(x: 0.3394717591017833d, y: 0.015724693204360318d), new NpgsqlTypes.NpgsqlPoint(x: 0.07569849726030242d, y: 0.8872301417543461d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6163612724744635d, y: 0.2900544022495829d), new NpgsqlTypes.NpgsqlPoint(x: 0.34724908637613827d, y: 0.88588891569927d), new NpgsqlTypes.NpgsqlPoint(x: 0.3830405693087914d, y: 0.9359522536827501d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3722547372401228d, y: 0.7384893364556699d), new NpgsqlTypes.NpgsqlPoint(x: 0.5095889871539757d, y: 0.3382916176262727d), new NpgsqlTypes.NpgsqlPoint(x: 0.8585259552758765d, y: 0.041744356563149676d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.789959008994845d, y: 0.22882058295654606d), new NpgsqlTypes.NpgsqlPoint(x: 0.6956305053228681d, y: 0.20220389135715422d), new NpgsqlTypes.NpgsqlPoint(x: 0.07933728388982941d, y: 0.8458618038791735d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38729790158157507d, y: 0.9359156650878692d), new NpgsqlTypes.NpgsqlPoint(x: 0.41269383930711345d, y: 0.5410624161694088d), new NpgsqlTypes.NpgsqlPoint(x: 0.07612893296258971d, y: 0.0012198506786071928d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.751557593045089d, y: 0.9144569816220292d), new NpgsqlTypes.NpgsqlPoint(x: 0.37129789558431614d, y: 0.8941593314557333d), new NpgsqlTypes.NpgsqlPoint(x: 0.07860011125593824d, y: 0.3755514086060583d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02621081825846794d, y: 0.8683440200864088d), new NpgsqlTypes.NpgsqlPoint(x: 0.37696245392250116d, y: 0.549781778831656d), new NpgsqlTypes.NpgsqlPoint(x: 0.14392322504250943d, y: 0.695212072212581d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9706973111162095d, y: 0.8539177348824408d), new NpgsqlTypes.NpgsqlPoint(x: 0.5901452707989888d, y: 0.7462765430125705d), new NpgsqlTypes.NpgsqlPoint(x: 0.5431565011822418d, y: 0.7397485597919038d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7705846399017638d, y: 0.27873811499483614d), new NpgsqlTypes.NpgsqlPoint(x: 0.3805254824609976d, y: 0.11161235892551968d), new NpgsqlTypes.NpgsqlPoint(x: 0.22203501201859088d, y: 0.05006824998114534d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22760115672231063d, y: 0.2266832365660857d), new NpgsqlTypes.NpgsqlPoint(x: 0.19271538560206725d, y: 0.21014767073797302d), new NpgsqlTypes.NpgsqlPoint(x: 0.5250644956229592d, y: 0.37631977334265787d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5564144674410795d, y: 0.07403827091007797d), new NpgsqlTypes.NpgsqlPoint(x: 0.08838007229188893d, y: 0.15376717592963252d), new NpgsqlTypes.NpgsqlPoint(x: 0.6809010550619166d, y: 0.02889589483843169d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33886355284793235d, y: 0.8294293121077132d), new NpgsqlTypes.NpgsqlPoint(x: 0.8063790195506159d, y: 0.5801126240777575d), new NpgsqlTypes.NpgsqlPoint(x: 0.9287906287120263d, y: 0.5860246302184536d)), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05256579707086473d, y: 0.42094868859295287d), new NpgsqlTypes.NpgsqlPoint(x: 0.8429117008261957d, y: 0.24932034064957675d), new NpgsqlTypes.NpgsqlPoint(x: 0.3551844675188557d, y: 0.8628105950933781d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5901694057826182d, y: 0.4398625250466781d), new NpgsqlTypes.NpgsqlPoint(x: 0.873218025449962d, y: 0.0029558303547477793d), new NpgsqlTypes.NpgsqlPoint(x: 0.019995984084753782d, y: 0.7984638322968705d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5431777447107778d, y: 0.6264425682716344d), new NpgsqlTypes.NpgsqlPoint(x: 0.8068589805108164d, y: 0.5169623235847224d), new NpgsqlTypes.NpgsqlPoint(x: 0.10702863518908323d, y: 0.10662748156204915d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3201277121924082d, y: 0.1772825251988448d), new NpgsqlTypes.NpgsqlPoint(x: 0.7205285788005602d, y: 0.39342265056560555d), new NpgsqlTypes.NpgsqlPoint(x: 0.28926864669563457d, y: 0.7220703120822296d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22739803729054953d, y: 0.8905769804904151d), new NpgsqlTypes.NpgsqlPoint(x: 0.16457097931974918d, y: 0.7882129130005809d), new NpgsqlTypes.NpgsqlPoint(x: 0.4439212508922711d, y: 0.8382720241429478d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9869834087961571d, y: 0.3930373561142335d), new NpgsqlTypes.NpgsqlPoint(x: 0.7718252298280583d, y: 0.880345450371625d), new NpgsqlTypes.NpgsqlPoint(x: 0.6802442911148113d, y: 0.782719506511274d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3778103510532561d, y: 0.6290992164872194d), new NpgsqlTypes.NpgsqlPoint(x: 0.7410700923522027d, y: 0.3595636629268638d), new NpgsqlTypes.NpgsqlPoint(x: 0.781798324926535d, y: 0.9023194172973171d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7179345307531616d, y: 0.5314479062815776d), new NpgsqlTypes.NpgsqlPoint(x: 0.8931989026789254d, y: 0.6660528964305609d), new NpgsqlTypes.NpgsqlPoint(x: 0.7316985041811306d, y: 0.06685733310715836d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4106146824655921d, y: 0.978646246794436d), new NpgsqlTypes.NpgsqlPoint(x: 0.7541952897969024d, y: 0.0026243154264626867d), new NpgsqlTypes.NpgsqlPoint(x: 0.429076180564004d, y: 0.06929642425092797d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4910510876902183d, y: 0.2553711885772172d), new NpgsqlTypes.NpgsqlPoint(x: 0.22230621729443667d, y: 0.33792162235731993d), new NpgsqlTypes.NpgsqlPoint(x: 0.36434991392010474d, y: 0.19129352650090392d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024529720596377813d, y: 0.39241328699530376d), new NpgsqlTypes.NpgsqlPoint(x: 0.8357311483447356d, y: 0.29950331916902306d), new NpgsqlTypes.NpgsqlPoint(x: 0.6277982432515431d, y: 0.3597428748701117d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8667552282334099d, y: 0.7945217173865771d), new NpgsqlTypes.NpgsqlPoint(x: 0.14884205608489542d, y: 0.7110651835369828d), new NpgsqlTypes.NpgsqlPoint(x: 0.781125802364948d, y: 0.003225073410525914d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27610583856485493d, y: 0.29776305283702365d), new NpgsqlTypes.NpgsqlPoint(x: 0.6928540391912804d, y: 0.7653987714554693d), new NpgsqlTypes.NpgsqlPoint(x: 0.8827834465116012d, y: 0.2407281908012352d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2849558487323577d, y: 0.8812061909439547d), new NpgsqlTypes.NpgsqlPoint(x: 0.8167101965348748d, y: 0.3776722829117539d), new NpgsqlTypes.NpgsqlPoint(x: 0.26673464740817243d, y: 0.25337306134233406d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39138530602268373d, y: 0.26696186138841127d), new NpgsqlTypes.NpgsqlPoint(x: 0.39017085947090024d, y: 0.926280070607262d), new NpgsqlTypes.NpgsqlPoint(x: 0.994447680664153d, y: 0.2685167438107867d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20398303958403008d, y: 0.5106991105238032d), new NpgsqlTypes.NpgsqlPoint(x: 0.03195628489276936d, y: 0.7732330075983169d), new NpgsqlTypes.NpgsqlPoint(x: 0.5250800317021624d, y: 0.7807104638752775d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8023901805215391d, y: 0.1091248469843017d), new NpgsqlTypes.NpgsqlPoint(x: 0.630744331054999d, y: 0.059363324201104684d), new NpgsqlTypes.NpgsqlPoint(x: 0.23851608330889418d, y: 0.4029423759972294d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.355781355692953d, y: 0.21772440646204205d), new NpgsqlTypes.NpgsqlPoint(x: 0.05495715091904163d, y: 0.5324346409770839d), new NpgsqlTypes.NpgsqlPoint(x: 0.08814629526450612d, y: 0.236418615039785d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23684463352038287d, y: 0.35494505206226834d), new NpgsqlTypes.NpgsqlPoint(x: 0.09240823498874584d, y: 0.1813590448615554d), new NpgsqlTypes.NpgsqlPoint(x: 0.7424842746146009d, y: 0.8973187007816548d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06760156083458524d, y: 0.6244769088572987d), new NpgsqlTypes.NpgsqlPoint(x: 0.3128158385840336d, y: 0.8458980964095661d), new NpgsqlTypes.NpgsqlPoint(x: 0.1091460431781428d, y: 0.6156634328370163d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3416137186710737d, y: 0.5946206048001216d), new NpgsqlTypes.NpgsqlPoint(x: 0.13603162470088315d, y: 0.6897263218027176d), new NpgsqlTypes.NpgsqlPoint(x: 0.4183158348397116d, y: 0.5051675136567595d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7848095391386167d, y: 0.1456257258359004d), new NpgsqlTypes.NpgsqlPoint(x: 0.0588796018584683d, y: 0.44140594283143586d), new NpgsqlTypes.NpgsqlPoint(x: 0.7639472436629664d, y: 0.4752993881134303d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07726367339877316d, y: 0.2242118128526186d), new NpgsqlTypes.NpgsqlPoint(x: 0.23524372718625453d, y: 0.33592447858800467d), new NpgsqlTypes.NpgsqlPoint(x: 0.2458014187671017d, y: 0.9535528906729195d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07312818384445241d, y: 0.17456878310249546d), new NpgsqlTypes.NpgsqlPoint(x: 0.45335935606349176d, y: 0.03849824208884334d), new NpgsqlTypes.NpgsqlPoint(x: 0.6712125186994066d, y: 0.7884353753632917d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7632677644044559d, y: 0.22545076743415204d), new NpgsqlTypes.NpgsqlPoint(x: 0.30198830710712943d, y: 0.08389097036105242d), new NpgsqlTypes.NpgsqlPoint(x: 0.34089094964521016d, y: 0.5250639003189569d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9493198598718757d, y: 0.8415184563013884d), new NpgsqlTypes.NpgsqlPoint(x: 0.011775996833731539d, y: 0.13272713968473981d), new NpgsqlTypes.NpgsqlPoint(x: 0.3324846929172328d, y: 0.278562087776397d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9964015530798795d, y: 0.6032061067422321d), new NpgsqlTypes.NpgsqlPoint(x: 0.7967105013719618d, y: 0.9078468228029538d), new NpgsqlTypes.NpgsqlPoint(x: 0.4047997031512226d, y: 0.393854403528071d)), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7527384155515491d, y: 0.6966971895266814d), new NpgsqlTypes.NpgsqlPoint(x: 0.9050913565375943d, y: 0.42912038715274636d), new NpgsqlTypes.NpgsqlPoint(x: 0.6684771876225566d, y: 0.7328704610979421d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8184969849885988d, y: 0.19010034000870624d), new NpgsqlTypes.NpgsqlPoint(x: 0.022018280072863106d, y: 0.6663396235581451d), new NpgsqlTypes.NpgsqlPoint(x: 0.1548391768475671d, y: 0.3711405714336936d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19192014446242422d, y: 0.5252423621303227d), new NpgsqlTypes.NpgsqlPoint(x: 0.8288311467271172d, y: 0.2386439073021721d), new NpgsqlTypes.NpgsqlPoint(x: 0.9185374237587832d, y: 0.6570168580820419d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5439610684363084d, y: 0.9762034912373446d), new NpgsqlTypes.NpgsqlPoint(x: 0.4498199233270185d, y: 0.43940956754102345d), new NpgsqlTypes.NpgsqlPoint(x: 0.4056455261855828d, y: 0.2482019561086144d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.202550989927898d, y: 0.046505366806751214d), new NpgsqlTypes.NpgsqlPoint(x: 0.6069505311217517d, y: 0.7039684088060192d), new NpgsqlTypes.NpgsqlPoint(x: 0.9583581438261022d, y: 0.625369801337149d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11576730792760537d, y: 0.837123503465663d), new NpgsqlTypes.NpgsqlPoint(x: 0.8706249924342425d, y: 0.09330807721320056d), new NpgsqlTypes.NpgsqlPoint(x: 0.5363869926684632d, y: 0.3306971099243672d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8261609772956381d, y: 0.7688611712370285d), new NpgsqlTypes.NpgsqlPoint(x: 0.08729209294805962d, y: 0.6921847822728041d), new NpgsqlTypes.NpgsqlPoint(x: 0.13555731663409398d, y: 0.314868398827021d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7668478255883057d, y: 0.45666152936979876d), new NpgsqlTypes.NpgsqlPoint(x: 0.8656608206388664d, y: 0.3206671577127348d), new NpgsqlTypes.NpgsqlPoint(x: 0.937427378924145d, y: 0.9318688868515034d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6795174521224586d, y: 0.2627108498307642d), new NpgsqlTypes.NpgsqlPoint(x: 0.6059587910933202d, y: 0.6800790223033248d), new NpgsqlTypes.NpgsqlPoint(x: 0.08963823876480315d, y: 0.719768368471822d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34079611642946717d, y: 0.940365266278192d), new NpgsqlTypes.NpgsqlPoint(x: 0.4376782874262346d, y: 0.6886307879351192d), new NpgsqlTypes.NpgsqlPoint(x: 0.18642051684711247d, y: 0.465813690072028d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8190220214789125d, y: 0.18391325420763804d), new NpgsqlTypes.NpgsqlPoint(x: 0.398047259723997d, y: 0.49738015517258427d), new NpgsqlTypes.NpgsqlPoint(x: 0.7615326386033993d, y: 0.37537186796079136d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14186793599477154d, y: 0.8605207247174934d), new NpgsqlTypes.NpgsqlPoint(x: 0.5663452610643054d, y: 0.2261636043154428d), new NpgsqlTypes.NpgsqlPoint(x: 0.31544682978907335d, y: 0.746802148309473d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4977113913360769d, y: 0.6198289721801861d), new NpgsqlTypes.NpgsqlPoint(x: 0.43013239206019527d, y: 0.9489761530350524d), new NpgsqlTypes.NpgsqlPoint(x: 0.5525915334126456d, y: 0.22688477448609035d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4843252039757321d, y: 0.38517080904511614d), new NpgsqlTypes.NpgsqlPoint(x: 0.873842299828514d, y: 0.5007834608900036d), new NpgsqlTypes.NpgsqlPoint(x: 0.28282978858015007d, y: 0.1885521095016659d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27461429598494635d, y: 0.004654969800110598d), new NpgsqlTypes.NpgsqlPoint(x: 0.7054962252924222d, y: 0.9954176422122623d), new NpgsqlTypes.NpgsqlPoint(x: 0.2849479542823987d, y: 0.1426420548845453d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1565982278649235d, y: 0.5198844106578002d), new NpgsqlTypes.NpgsqlPoint(x: 0.022441264258324267d, y: 0.5388512542032824d), new NpgsqlTypes.NpgsqlPoint(x: 0.16679072247342885d, y: 0.7691888899182936d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.027535117745780435d, y: 0.07222392665296773d), new NpgsqlTypes.NpgsqlPoint(x: 0.167453797196077d, y: 0.4641425611898239d), new NpgsqlTypes.NpgsqlPoint(x: 0.4674122600961028d, y: 0.670804364085289d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.020364441837062763d, y: 0.031993498900290684d), new NpgsqlTypes.NpgsqlPoint(x: 0.5290860972867071d, y: 0.48414975195996324d), new NpgsqlTypes.NpgsqlPoint(x: 0.5934399766244454d, y: 0.2934899713468859d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31931922818016567d, y: 0.36436173641452574d), new NpgsqlTypes.NpgsqlPoint(x: 0.3765244372760287d, y: 0.5537801005019124d), new NpgsqlTypes.NpgsqlPoint(x: 0.1508469230892442d, y: 0.7521482319264341d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07599465915733727d, y: 0.6036755357516403d), new NpgsqlTypes.NpgsqlPoint(x: 0.6730782962653339d, y: 0.1497775563685263d), new NpgsqlTypes.NpgsqlPoint(x: 0.5820012796722251d, y: 0.2319113300879676d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07663135690276446d, y: 0.5112294526350489d), new NpgsqlTypes.NpgsqlPoint(x: 0.7686605897326414d, y: 0.333173948684896d), new NpgsqlTypes.NpgsqlPoint(x: 0.7460788452128134d, y: 0.11231486570129157d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7302863218129254d, y: 0.8637032307140682d), new NpgsqlTypes.NpgsqlPoint(x: 0.04800107106260476d, y: 0.2745645852562394d), new NpgsqlTypes.NpgsqlPoint(x: 0.9453986723395232d, y: 0.891146045547111d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09103868438661855d, y: 0.019187337651588643d), new NpgsqlTypes.NpgsqlPoint(x: 0.19276686639543938d, y: 0.9656816246299322d), new NpgsqlTypes.NpgsqlPoint(x: 0.8674640207126734d, y: 0.984220209359654d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9548446421221489d, y: 0.3671481264082048d), new NpgsqlTypes.NpgsqlPoint(x: 0.45329483190019326d, y: 0.47383211709660067d), new NpgsqlTypes.NpgsqlPoint(x: 0.6735455015124998d, y: 0.1584732786917089d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2680921041384331d, y: 0.17014114203453945d), new NpgsqlTypes.NpgsqlPoint(x: 0.9832919116590612d, y: 0.09258916906677894d), new NpgsqlTypes.NpgsqlPoint(x: 0.5207410845779764d, y: 0.5452008744415661d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6207231187764424d, y: 0.28982079900357105d), new NpgsqlTypes.NpgsqlPoint(x: 0.3304468879002548d, y: 0.7272707080232733d), new NpgsqlTypes.NpgsqlPoint(x: 0.062326060413642415d, y: 0.5613809544004418d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49944724621623626d, y: 0.08457710844225763d), new NpgsqlTypes.NpgsqlPoint(x: 0.4461125610393861d, y: 0.9101917394203132d), new NpgsqlTypes.NpgsqlPoint(x: 0.41100389207114796d, y: 0.5007907983396152d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28143146607435854d, y: 0.010756047277640457d), new NpgsqlTypes.NpgsqlPoint(x: 0.5002221958340397d, y: 0.6231930927387598d), new NpgsqlTypes.NpgsqlPoint(x: 0.34929600721043175d, y: 0.20437994203828413d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42170264814464675d, y: 0.9518733192976732d), new NpgsqlTypes.NpgsqlPoint(x: 0.05041688098945929d, y: 0.31818083184322077d), new NpgsqlTypes.NpgsqlPoint(x: 0.775296098700866d, y: 0.3587017358254152d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3438869883133021d, y: 0.4662214009449688d), new NpgsqlTypes.NpgsqlPoint(x: 0.6681039766144102d, y: 0.23326991234897076d), new NpgsqlTypes.NpgsqlPoint(x: 0.7549554575307524d, y: 0.6333336589398124d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06678380584234522d, y: 0.021354360260871008d), new NpgsqlTypes.NpgsqlPoint(x: 0.6100598334069836d, y: 0.7022993546010816d), new NpgsqlTypes.NpgsqlPoint(x: 0.48696946927412144d, y: 0.5056841792342321d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3284888372340903d, y: 0.06432298886836096d), new NpgsqlTypes.NpgsqlPoint(x: 0.4397770474753383d, y: 0.24915140194265673d), new NpgsqlTypes.NpgsqlPoint(x: 0.8333206281201082d, y: 0.9059130703384126d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33173916559488403d, y: 0.6088425546272261d), new NpgsqlTypes.NpgsqlPoint(x: 0.20679437013516433d, y: 0.5283215478747202d), new NpgsqlTypes.NpgsqlPoint(x: 0.35867177311161036d, y: 0.512959952373532d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4432556875769197d, y: 0.4607787038464637d), new NpgsqlTypes.NpgsqlPoint(x: 0.7590485076824235d, y: 0.9772435731493212d), new NpgsqlTypes.NpgsqlPoint(x: 0.7297160661470978d, y: 0.23692592731845508d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7627875217214002d, y: 0.5684286937879964d), new NpgsqlTypes.NpgsqlPoint(x: 0.32510132224579624d, y: 0.25940979063657543d), new NpgsqlTypes.NpgsqlPoint(x: 0.782457500107036d, y: 0.8068350307827655d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2259499839992415d, y: 0.045462224828744624d), new NpgsqlTypes.NpgsqlPoint(x: 0.8509830737067559d, y: 0.8886814783327027d), new NpgsqlTypes.NpgsqlPoint(x: 0.5986964081114592d, y: 0.8524241248443032d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41808039376930595d, y: 0.6023941646545327d), new NpgsqlTypes.NpgsqlPoint(x: 0.29492173288207435d, y: 0.9674910268974084d), new NpgsqlTypes.NpgsqlPoint(x: 0.17881428086286877d, y: 0.7695679140019842d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19382124775683784d, y: 0.4916156350877827d), new NpgsqlTypes.NpgsqlPoint(x: 0.19133735310476252d, y: 0.41503689771822017d), new NpgsqlTypes.NpgsqlPoint(x: 0.43655216753002213d, y: 0.35706745912045745d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24568360094422126d, y: 0.2897211415697307d), new NpgsqlTypes.NpgsqlPoint(x: 0.12376374878956142d, y: 0.6270472560387577d), new NpgsqlTypes.NpgsqlPoint(x: 0.2522933373749434d, y: 0.8042539651129716d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24519797234141305d, y: 0.4053875347199515d), new NpgsqlTypes.NpgsqlPoint(x: 0.6403399987089546d, y: 0.6343592761050791d), new NpgsqlTypes.NpgsqlPoint(x: 0.8357307637189205d, y: 0.7357416361473756d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2724547283956449d, y: 0.9997944879966704d), new NpgsqlTypes.NpgsqlPoint(x: 0.01103884263795396d, y: 0.08142985267993408d), new NpgsqlTypes.NpgsqlPoint(x: 0.36051018431596793d, y: 0.19821194104846662d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33535082540066974d, y: 0.8271851200217377d), new NpgsqlTypes.NpgsqlPoint(x: 0.5515484759447576d, y: 0.48355672081560375d), new NpgsqlTypes.NpgsqlPoint(x: 0.8810658993559776d, y: 0.974228524971523d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6869122489693817d, y: 0.9584820107367106d), new NpgsqlTypes.NpgsqlPoint(x: 0.8886294404492959d, y: 0.01128744319646413d), new NpgsqlTypes.NpgsqlPoint(x: 0.9191913489316623d, y: 0.5503573393170176d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24370724486380457d, y: 0.5964863463181086d), new NpgsqlTypes.NpgsqlPoint(x: 0.08269862770958702d, y: 0.19488507975863034d), new NpgsqlTypes.NpgsqlPoint(x: 0.19420580491183848d, y: 0.7238839624217775d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2725237892970298d, y: 0.30794057529649244d), new NpgsqlTypes.NpgsqlPoint(x: 0.405392498705788d, y: 0.11038489531216411d), new NpgsqlTypes.NpgsqlPoint(x: 0.17603248693406048d, y: 0.9507769914573396d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024452459199897025d, y: 0.658245181998308d), new NpgsqlTypes.NpgsqlPoint(x: 0.5960118994295807d, y: 0.28888223407101143d), new NpgsqlTypes.NpgsqlPoint(x: 0.06679125417850129d, y: 0.5647520884588683d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3792364941912606d, y: 0.6671892205820111d), new NpgsqlTypes.NpgsqlPoint(x: 0.8180922388707608d, y: 0.03653400697349929d), new NpgsqlTypes.NpgsqlPoint(x: 0.3595585584928077d, y: 0.3900448839073839d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9729657004743565d, y: 0.3089677188256267d), new NpgsqlTypes.NpgsqlPoint(x: 0.7233258471747523d, y: 0.19815747777024684d), new NpgsqlTypes.NpgsqlPoint(x: 0.6607332958984167d, y: 0.5040332734046108d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8436189183966517d, y: 0.48960814443059586d), new NpgsqlTypes.NpgsqlPoint(x: 0.14560173061586235d, y: 0.6443318376394966d), new NpgsqlTypes.NpgsqlPoint(x: 0.5484113084809691d, y: 0.0006380157769507733d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.785732528875523d, y: 0.9705236397161134d), new NpgsqlTypes.NpgsqlPoint(x: 0.12385463467448798d, y: 0.5583362775398131d), new NpgsqlTypes.NpgsqlPoint(x: 0.788629785338016d, y: 0.6884343511215546d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44801864370926614d, y: 0.9711761740737156d), new NpgsqlTypes.NpgsqlPoint(x: 0.9919279317957006d, y: 0.2962404611310241d), new NpgsqlTypes.NpgsqlPoint(x: 0.34016209127554464d, y: 0.8205334484591218d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6876594113201503d, y: 0.472849168537105d), new NpgsqlTypes.NpgsqlPoint(x: 0.4333611485264558d, y: 0.5266612604098436d), new NpgsqlTypes.NpgsqlPoint(x: 0.04440267200814563d, y: 0.6359653389957493d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7945972025704022d, y: 0.17337441684349175d), new NpgsqlTypes.NpgsqlPoint(x: 0.498853435208763d, y: 0.5052396616696269d), new NpgsqlTypes.NpgsqlPoint(x: 0.8790275290359856d, y: 0.1373128481167769d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8641161345143326d, y: 0.8952717481062611d), new NpgsqlTypes.NpgsqlPoint(x: 0.48163744638881756d, y: 0.6306896055407653d), new NpgsqlTypes.NpgsqlPoint(x: 0.3500911534120752d, y: 0.24965209542208022d)), }, }, },
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07229658355300006d, y: 0.6014636669994888d), new NpgsqlTypes.NpgsqlPoint(x: 0.9106716534112465d, y: 0.3778831737640468d), new NpgsqlTypes.NpgsqlPoint(x: 0.5443248050865567d, y: 0.6770437612074862d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41923138852502406d, y: 0.5892091285344059d), new NpgsqlTypes.NpgsqlPoint(x: 0.8489271867186897d, y: 0.004729464430808461d), new NpgsqlTypes.NpgsqlPoint(x: 0.46160550247402177d, y: 0.6696015464841595d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6965249888319841d, y: 0.3263387919057753d), new NpgsqlTypes.NpgsqlPoint(x: 0.5801163677487439d, y: 0.5979265363915719d), new NpgsqlTypes.NpgsqlPoint(x: 0.6355587804149209d, y: 0.23234732356739707d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4894527223687962d, y: 0.7577142818625583d), new NpgsqlTypes.NpgsqlPoint(x: 0.7353110130071043d, y: 0.725582146793455d), new NpgsqlTypes.NpgsqlPoint(x: 0.8497505955220429d, y: 0.014025175491794495d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38074804319461963d, y: 0.7670960869527232d), new NpgsqlTypes.NpgsqlPoint(x: 0.7331222572356856d, y: 0.6868488941665628d), new NpgsqlTypes.NpgsqlPoint(x: 0.837267630912782d, y: 0.8881451957677088d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12746233792709127d, y: 0.739319448087544d), new NpgsqlTypes.NpgsqlPoint(x: 0.8411497540100703d, y: 0.5503920747823677d), new NpgsqlTypes.NpgsqlPoint(x: 0.48926576164228597d, y: 0.31963992449306666d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7992079659151708d, y: 0.8560549731273924d), new NpgsqlTypes.NpgsqlPoint(x: 0.4482942941388175d, y: 0.29287141607368206d), new NpgsqlTypes.NpgsqlPoint(x: 0.5521453726768324d, y: 0.5828614558593387d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9661062225209471d, y: 0.18886376649356407d), new NpgsqlTypes.NpgsqlPoint(x: 0.8888838336110954d, y: 0.3516192077148216d), new NpgsqlTypes.NpgsqlPoint(x: 0.09510196738360355d, y: 0.3851507534860874d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6152317786218857d, y: 0.9117201466917022d), new NpgsqlTypes.NpgsqlPoint(x: 0.049267232623866675d, y: 0.18173168181410737d), new NpgsqlTypes.NpgsqlPoint(x: 0.9753191825309333d, y: 0.04405791570884665d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9508406400364431d, y: 0.5225013893335411d), new NpgsqlTypes.NpgsqlPoint(x: 0.4704897254026086d, y: 0.6933527759581805d), new NpgsqlTypes.NpgsqlPoint(x: 0.8231929532091384d, y: 0.943094329532485d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6840679093435732d, y: 0.9462527142400464d), new NpgsqlTypes.NpgsqlPoint(x: 0.9572503693112273d, y: 0.4117471517198844d), new NpgsqlTypes.NpgsqlPoint(x: 0.44319792401933555d, y: 0.7879215182368537d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45068090520585313d, y: 0.48830349075628576d), new NpgsqlTypes.NpgsqlPoint(x: 0.8520347574167938d, y: 0.278130606050211d), new NpgsqlTypes.NpgsqlPoint(x: 0.9882744211910489d, y: 0.8043630344115066d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8905834409788801d, y: 0.799568444599215d), new NpgsqlTypes.NpgsqlPoint(x: 0.7864127297969011d, y: 0.6354624445523234d), new NpgsqlTypes.NpgsqlPoint(x: 0.5350859747415846d, y: 0.3448988134744225d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9874690497660475d, y: 0.4681447921599994d), new NpgsqlTypes.NpgsqlPoint(x: 0.1593370181427819d, y: 0.8319450055336182d), new NpgsqlTypes.NpgsqlPoint(x: 0.572596944205133d, y: 0.8774630275220264d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18024471571586476d, y: 0.15971198990231528d), new NpgsqlTypes.NpgsqlPoint(x: 0.44601465972070176d, y: 0.5580190285004512d), new NpgsqlTypes.NpgsqlPoint(x: 0.25059147589524455d, y: 0.6745455858338205d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9845235904440403d, y: 0.9834315393481583d), new NpgsqlTypes.NpgsqlPoint(x: 0.2590246848259107d, y: 0.7386833405322751d), new NpgsqlTypes.NpgsqlPoint(x: 0.9800180430235861d, y: 0.8670929918340339d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9681156679035717d, y: 0.4203304945323598d), new NpgsqlTypes.NpgsqlPoint(x: 0.31472278960069355d, y: 0.8527435586028355d), new NpgsqlTypes.NpgsqlPoint(x: 0.7157774810712882d, y: 0.9815072545693528d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40468387747872114d, y: 0.09971881604786148d), new NpgsqlTypes.NpgsqlPoint(x: 0.17860942985501305d, y: 0.18449050108614062d), new NpgsqlTypes.NpgsqlPoint(x: 0.12952093278626953d, y: 0.30665824167134326d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8857281449000646d, y: 0.5901416120435097d), new NpgsqlTypes.NpgsqlPoint(x: 0.1384451606707362d, y: 0.9502114344278018d), new NpgsqlTypes.NpgsqlPoint(x: 0.8677990411053029d, y: 0.4885941448216192d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6769213482033971d, y: 0.457823952513404d), new NpgsqlTypes.NpgsqlPoint(x: 0.19532673912935739d, y: 0.37220759221698074d), new NpgsqlTypes.NpgsqlPoint(x: 0.0961381170719835d, y: 0.9387139120402942d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4399441194311109d, y: 0.035675487398951544d), new NpgsqlTypes.NpgsqlPoint(x: 0.8725290457780419d, y: 0.09362141474191155d), new NpgsqlTypes.NpgsqlPoint(x: 0.31552302077158423d, y: 0.47133772938328133d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9163928180859631d, y: 0.5418213325625492d), new NpgsqlTypes.NpgsqlPoint(x: 0.8886211242651081d, y: 0.20791293581356252d), new NpgsqlTypes.NpgsqlPoint(x: 0.6763003190364719d, y: 0.5721583846797514d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3683622865966991d, y: 0.7984987721429699d), new NpgsqlTypes.NpgsqlPoint(x: 0.9238423147350159d, y: 0.2685010332750756d), new NpgsqlTypes.NpgsqlPoint(x: 0.9452545378866496d, y: 0.1729920522770978d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4976671390278645d, y: 0.2318564025824036d), new NpgsqlTypes.NpgsqlPoint(x: 0.36243174523080524d, y: 0.8498410044229472d), new NpgsqlTypes.NpgsqlPoint(x: 0.41952571384001025d, y: 0.6772722980328211d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9592593201970679d, y: 0.9338895656110076d), new NpgsqlTypes.NpgsqlPoint(x: 0.5206212304453716d, y: 0.5450057706647587d), new NpgsqlTypes.NpgsqlPoint(x: 0.5737417048784529d, y: 0.5483443760730855d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9921615823725896d, y: 0.7265530944881873d), new NpgsqlTypes.NpgsqlPoint(x: 0.4184791252405198d, y: 0.537874483974664d), new NpgsqlTypes.NpgsqlPoint(x: 0.7358506057024355d, y: 0.29524224584467673d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.050797404946251956d, y: 0.1758679011791131d), new NpgsqlTypes.NpgsqlPoint(x: 0.9571961100646553d, y: 0.29015647553776414d), new NpgsqlTypes.NpgsqlPoint(x: 0.5949228535396545d, y: 0.7065201743767568d)), }, }, },
    ModelInner = new NpgsqlPathpathMMArrayD3E1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5886850033294421d, y: 0.5873943025990146d), new NpgsqlTypes.NpgsqlPoint(x: 0.8406136722731166d, y: 0.6247001355556212d), new NpgsqlTypes.NpgsqlPoint(x: 0.8349182269624106d, y: 0.7696397670311529d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18310499904596078d, y: 0.3340378229058698d), new NpgsqlTypes.NpgsqlPoint(x: 0.5387114395397028d, y: 0.2570371151650932d), new NpgsqlTypes.NpgsqlPoint(x: 0.2730201410740578d, y: 0.34691419861558626d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01616151063220206d, y: 0.1925736552303905d), new NpgsqlTypes.NpgsqlPoint(x: 0.7484993218391228d, y: 0.40240753333541d), new NpgsqlTypes.NpgsqlPoint(x: 0.9924619675602139d, y: 0.08028574421058177d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19272166085008047d, y: 0.13474188417451993d), new NpgsqlTypes.NpgsqlPoint(x: 0.8610398102606325d, y: 0.32289199393060164d), new NpgsqlTypes.NpgsqlPoint(x: 0.858498353389134d, y: 0.3173070541742419d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9557040763800622d, y: 0.8382436648627101d), new NpgsqlTypes.NpgsqlPoint(x: 0.9474243719820543d, y: 0.7771153534925471d), new NpgsqlTypes.NpgsqlPoint(x: 0.7136252688129365d, y: 0.4545629681485983d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4232196895081338d, y: 0.291222528968604d), new NpgsqlTypes.NpgsqlPoint(x: 0.8874653266070291d, y: 0.15203110256573138d), new NpgsqlTypes.NpgsqlPoint(x: 0.6522907402500085d, y: 0.8913775154100949d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7247486149464227d, y: 0.9013750663264578d), new NpgsqlTypes.NpgsqlPoint(x: 0.6458189291289763d, y: 0.5479536380564548d), new NpgsqlTypes.NpgsqlPoint(x: 0.354217308307319d, y: 0.23340755298273852d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40579129701465544d, y: 0.5428443295298614d), new NpgsqlTypes.NpgsqlPoint(x: 0.9236364731659642d, y: 0.161518427658494d), new NpgsqlTypes.NpgsqlPoint(x: 0.6666741045294593d, y: 0.3424041669898261d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8386453219491341d, y: 0.3462055706158197d), new NpgsqlTypes.NpgsqlPoint(x: 0.6418338019316461d, y: 0.33250724124038156d), new NpgsqlTypes.NpgsqlPoint(x: 0.37319991138935504d, y: 0.5948968675721706d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5395907483969934d, y: 0.5986881213634085d), new NpgsqlTypes.NpgsqlPoint(x: 0.29850524064189266d, y: 0.17340327206880535d), new NpgsqlTypes.NpgsqlPoint(x: 0.05025941258764954d, y: 0.3504558843022053d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5822600440306819d, y: 0.4815290620269965d), new NpgsqlTypes.NpgsqlPoint(x: 0.5275570640876273d, y: 0.4674002322827401d), new NpgsqlTypes.NpgsqlPoint(x: 0.9824957514566893d, y: 0.09072721551070362d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.764188485138812d, y: 0.7940909274823986d), new NpgsqlTypes.NpgsqlPoint(x: 0.630329453391917d, y: 0.21334077595433953d), new NpgsqlTypes.NpgsqlPoint(x: 0.4062873174448718d, y: 0.2111147328999865d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004927986572067167d, y: 0.9865457059766652d), new NpgsqlTypes.NpgsqlPoint(x: 0.5261698338195492d, y: 0.30447866703827975d), new NpgsqlTypes.NpgsqlPoint(x: 0.5173006802159106d, y: 0.4297999464415948d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9013884880904586d, y: 0.9223291797652367d), new NpgsqlTypes.NpgsqlPoint(x: 0.4886796789388276d, y: 0.47434942885923925d), new NpgsqlTypes.NpgsqlPoint(x: 0.8104446992466197d, y: 0.022350011999031194d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08765379458061107d, y: 0.8545132940933589d), new NpgsqlTypes.NpgsqlPoint(x: 0.5756936133347189d, y: 0.1896262079477068d), new NpgsqlTypes.NpgsqlPoint(x: 0.9333964161307551d, y: 0.46417859411458395d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.990994756622114d, y: 0.02046339887395987d), new NpgsqlTypes.NpgsqlPoint(x: 0.10671034635910559d, y: 0.3239426544116819d), new NpgsqlTypes.NpgsqlPoint(x: 0.2239376417314236d, y: 0.3967835050707017d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12671726635670166d, y: 0.9806293668497483d), new NpgsqlTypes.NpgsqlPoint(x: 0.9217651667969053d, y: 0.2661729240784617d), new NpgsqlTypes.NpgsqlPoint(x: 0.24638483739480033d, y: 0.0882970008969084d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7447232966674538d, y: 0.5293952982195687d), new NpgsqlTypes.NpgsqlPoint(x: 0.014490612449679974d, y: 0.19741562758764652d), new NpgsqlTypes.NpgsqlPoint(x: 0.6700760042843235d, y: 0.24979428715390228d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.664401006569129d, y: 0.8323132398221167d), new NpgsqlTypes.NpgsqlPoint(x: 0.2762034342106652d, y: 0.7383187618802571d), new NpgsqlTypes.NpgsqlPoint(x: 0.3711620636200671d, y: 0.7668089233049523d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9314019423651277d, y: 0.7707286444280951d), new NpgsqlTypes.NpgsqlPoint(x: 0.3978307736096418d, y: 0.29095317510651364d), new NpgsqlTypes.NpgsqlPoint(x: 0.2937432996813777d, y: 0.6663616205421988d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4207293626875138d, y: 0.22012320692872345d), new NpgsqlTypes.NpgsqlPoint(x: 0.09973428299658116d, y: 0.5964040874760106d), new NpgsqlTypes.NpgsqlPoint(x: 0.11597295253365858d, y: 0.6032436204038232d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23944732905220523d, y: 0.39297248221396075d), new NpgsqlTypes.NpgsqlPoint(x: 0.5552427547324649d, y: 0.947010633862018d), new NpgsqlTypes.NpgsqlPoint(x: 0.24883936857162325d, y: 0.9265648000914852d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5510564795235041d, y: 0.36584882273290076d), new NpgsqlTypes.NpgsqlPoint(x: 0.016737212941980273d, y: 0.963509325644608d), new NpgsqlTypes.NpgsqlPoint(x: 0.8403116989484277d, y: 0.181807235873491d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.840152980242447d, y: 0.8203176114362276d), new NpgsqlTypes.NpgsqlPoint(x: 0.8378424178236638d, y: 0.9134655324309685d), new NpgsqlTypes.NpgsqlPoint(x: 0.5559828883610747d, y: 0.17223417395638452d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6168207062477544d, y: 0.6175400936540567d), new NpgsqlTypes.NpgsqlPoint(x: 0.3345642008264258d, y: 0.514095349918483d), new NpgsqlTypes.NpgsqlPoint(x: 0.7230051185223915d, y: 0.14933347646902695d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12411246170482615d, y: 0.4153257109204501d), new NpgsqlTypes.NpgsqlPoint(x: 0.43815105680709965d, y: 0.9863999174866349d), new NpgsqlTypes.NpgsqlPoint(x: 0.6732140737358704d, y: 0.040428332689599d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24421827968209975d, y: 0.6318109180952951d), new NpgsqlTypes.NpgsqlPoint(x: 0.5602871443566184d, y: 0.7909058992747834d), new NpgsqlTypes.NpgsqlPoint(x: 0.609420093191491d, y: 0.25105291385043293d)), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08039708163314319d, y: 0.04291495634086073d), new NpgsqlTypes.NpgsqlPoint(x: 0.5692253618004705d, y: 0.8596941571363848d), new NpgsqlTypes.NpgsqlPoint(x: 0.8463843362388245d, y: 0.3550275254067936d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3774178589947893d, y: 0.36436896445289213d), new NpgsqlTypes.NpgsqlPoint(x: 0.45825428337548424d, y: 0.7001645730284244d), new NpgsqlTypes.NpgsqlPoint(x: 0.32130867554204046d, y: 0.573844016792452d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5037808690815442d, y: 0.5631352022313302d), new NpgsqlTypes.NpgsqlPoint(x: 0.44364447027820963d, y: 0.8580824457360108d), new NpgsqlTypes.NpgsqlPoint(x: 0.6713550998036352d, y: 0.9696579813392155d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.208826638204625d, y: 0.4570502500908046d), new NpgsqlTypes.NpgsqlPoint(x: 0.36088697266045433d, y: 0.577392713887478d), new NpgsqlTypes.NpgsqlPoint(x: 0.3544652894599355d, y: 0.5384877731264541d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2566580874078267d, y: 0.7934665834992276d), new NpgsqlTypes.NpgsqlPoint(x: 0.6852333282216219d, y: 0.010331666542006901d), new NpgsqlTypes.NpgsqlPoint(x: 0.8236309274653159d, y: 0.6480715202436875d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17159214995080185d, y: 0.16654003337867307d), new NpgsqlTypes.NpgsqlPoint(x: 0.7962460677575303d, y: 0.9053404984672032d), new NpgsqlTypes.NpgsqlPoint(x: 0.8163883339908036d, y: 0.31204544462875716d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8935072936849469d, y: 0.14460118860520843d), new NpgsqlTypes.NpgsqlPoint(x: 0.02419409043459031d, y: 0.02951367368125024d), new NpgsqlTypes.NpgsqlPoint(x: 0.20462691312318604d, y: 0.8837801519460603d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.517723691177248d, y: 0.8716190050621432d), new NpgsqlTypes.NpgsqlPoint(x: 0.530301338208073d, y: 0.4459273215688936d), new NpgsqlTypes.NpgsqlPoint(x: 0.7152268258226394d, y: 0.04712774152867372d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8013948902662946d, y: 0.046024887228480305d), new NpgsqlTypes.NpgsqlPoint(x: 0.604977048054696d, y: 0.3350243095677343d), new NpgsqlTypes.NpgsqlPoint(x: 0.09243600976020727d, y: 0.8408673692851083d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3940143251152637d, y: 0.7965447729190058d), new NpgsqlTypes.NpgsqlPoint(x: 0.27200520672036554d, y: 0.6576326536956103d), new NpgsqlTypes.NpgsqlPoint(x: 0.7132700987516611d, y: 0.31874131094549196d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.874306126537816d, y: 0.5939565691000658d), new NpgsqlTypes.NpgsqlPoint(x: 0.9400782930136162d, y: 0.808656981202125d), new NpgsqlTypes.NpgsqlPoint(x: 0.5013873394803983d, y: 0.8144540210260025d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.897029279555736d, y: 0.36316720221438414d), new NpgsqlTypes.NpgsqlPoint(x: 0.11838773550493176d, y: 0.05401751904577412d), new NpgsqlTypes.NpgsqlPoint(x: 0.12540957502082617d, y: 0.011872994697656902d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8732773830525156d, y: 0.6012976243511406d), new NpgsqlTypes.NpgsqlPoint(x: 0.504096767437557d, y: 0.33081828752337294d), new NpgsqlTypes.NpgsqlPoint(x: 0.3319914168575423d, y: 0.9294907016661969d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45520632779048087d, y: 0.7124031710208342d), new NpgsqlTypes.NpgsqlPoint(x: 0.06929481294576167d, y: 0.6610224109449485d), new NpgsqlTypes.NpgsqlPoint(x: 0.06054279212468194d, y: 0.5502808941054727d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7447677924688118d, y: 0.14099929624466623d), new NpgsqlTypes.NpgsqlPoint(x: 0.21844270503685337d, y: 0.8037295768888961d), new NpgsqlTypes.NpgsqlPoint(x: 0.2298912199998978d, y: 0.2164621260892523d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4018400786411118d, y: 0.9474773824382557d), new NpgsqlTypes.NpgsqlPoint(x: 0.5528385598808759d, y: 0.579765153636318d), new NpgsqlTypes.NpgsqlPoint(x: 0.6905132708362142d, y: 0.14682945914054546d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9368476309429256d, y: 0.756107960034265d), new NpgsqlTypes.NpgsqlPoint(x: 0.8490619725720097d, y: 0.9624702459380163d), new NpgsqlTypes.NpgsqlPoint(x: 0.03617803182386703d, y: 0.23772926538814854d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1887427001210117d, y: 0.08074895614468225d), new NpgsqlTypes.NpgsqlPoint(x: 0.18766796870328428d, y: 0.2615074845262725d), new NpgsqlTypes.NpgsqlPoint(x: 0.20842247807299175d, y: 0.6046176419262822d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7195618797023688d, y: 0.8518244494057216d), new NpgsqlTypes.NpgsqlPoint(x: 0.42649714760569535d, y: 0.9336510898368857d), new NpgsqlTypes.NpgsqlPoint(x: 0.9488252696278987d, y: 0.3236799883157834d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5504381793444308d, y: 0.2687857216413482d), new NpgsqlTypes.NpgsqlPoint(x: 0.16924075675614347d, y: 0.1772392104175965d), new NpgsqlTypes.NpgsqlPoint(x: 0.06767717022906938d, y: 0.25254753906047667d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26638156374870026d, y: 0.9365249956539194d), new NpgsqlTypes.NpgsqlPoint(x: 0.6324793055273707d, y: 0.8587350223326263d), new NpgsqlTypes.NpgsqlPoint(x: 0.9561964558809068d, y: 0.24491172327963717d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2525872478185608d, y: 0.3970493657478873d), new NpgsqlTypes.NpgsqlPoint(x: 0.6011773014717088d, y: 0.36414170657874523d), new NpgsqlTypes.NpgsqlPoint(x: 0.5357767064194235d, y: 0.7927172563457625d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39544089401229343d, y: 0.0788742131315453d), new NpgsqlTypes.NpgsqlPoint(x: 0.047705193536167534d, y: 0.19923623228404708d), new NpgsqlTypes.NpgsqlPoint(x: 0.8508452553076428d, y: 0.5333418515052658d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43780224524736855d, y: 0.7689807087164718d), new NpgsqlTypes.NpgsqlPoint(x: 0.963350197694425d, y: 0.5128716711333147d), new NpgsqlTypes.NpgsqlPoint(x: 0.6187056732721646d, y: 0.8698122130113577d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5712659966870225d, y: 0.18045198973446408d), new NpgsqlTypes.NpgsqlPoint(x: 0.8143487342942193d, y: 0.9767613360862806d), new NpgsqlTypes.NpgsqlPoint(x: 0.9821599675284155d, y: 0.37678115973681514d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4641820717295142d, y: 0.7446680884918288d), new NpgsqlTypes.NpgsqlPoint(x: 0.791883797311251d, y: 0.3579983021334301d), new NpgsqlTypes.NpgsqlPoint(x: 0.5245180024746658d, y: 0.8424910007240723d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35304058815538764d, y: 0.807310946718691d), new NpgsqlTypes.NpgsqlPoint(x: 0.927376466565971d, y: 0.5269351646243516d), new NpgsqlTypes.NpgsqlPoint(x: 0.4396379305915916d, y: 0.9079129943330313d)), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38939051183259354d, y: 0.801185866762641d), new NpgsqlTypes.NpgsqlPoint(x: 0.12076767719747117d, y: 0.3888785289917446d), new NpgsqlTypes.NpgsqlPoint(x: 0.5024194359766333d, y: 0.7053421553753558d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13374940651194256d, y: 0.5769003088094463d), new NpgsqlTypes.NpgsqlPoint(x: 0.318441111954203d, y: 0.4863156551672121d), new NpgsqlTypes.NpgsqlPoint(x: 0.8265790609207364d, y: 0.6750518885950907d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18280077820276064d, y: 0.8589792175511425d), new NpgsqlTypes.NpgsqlPoint(x: 0.2098634686370503d, y: 0.7146827047355605d), new NpgsqlTypes.NpgsqlPoint(x: 0.1661350424445831d, y: 0.6252446259378502d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6475820634656623d, y: 0.08128416847602749d), new NpgsqlTypes.NpgsqlPoint(x: 0.7194586975994743d, y: 0.7066737925825967d), new NpgsqlTypes.NpgsqlPoint(x: 0.2102076350192994d, y: 0.7307866930248348d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9220126367115539d, y: 0.7879784369128383d), new NpgsqlTypes.NpgsqlPoint(x: 0.7194801295917528d, y: 0.8461653732398678d), new NpgsqlTypes.NpgsqlPoint(x: 0.40405664337565617d, y: 0.4732942493767337d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9972129527319765d, y: 0.28320968104678024d), new NpgsqlTypes.NpgsqlPoint(x: 0.2632346795797542d, y: 0.7470584807687197d), new NpgsqlTypes.NpgsqlPoint(x: 0.4018715554188229d, y: 0.4314358684131545d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5370293566699518d, y: 0.17786729882721708d), new NpgsqlTypes.NpgsqlPoint(x: 0.22650247819728153d, y: 0.03494395950946616d), new NpgsqlTypes.NpgsqlPoint(x: 0.4838076356398977d, y: 0.6111369939263271d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4468733158810425d, y: 0.9200915689172469d), new NpgsqlTypes.NpgsqlPoint(x: 0.23353380686900627d, y: 0.6345236580667393d), new NpgsqlTypes.NpgsqlPoint(x: 0.2612124735088983d, y: 0.07389378695224202d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2276687783035134d, y: 0.43596912409562694d), new NpgsqlTypes.NpgsqlPoint(x: 0.26626827636156447d, y: 0.1365508111743331d), new NpgsqlTypes.NpgsqlPoint(x: 0.38736660765193054d, y: 0.12506652259162088d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12299368212988082d, y: 0.2837210034212665d), new NpgsqlTypes.NpgsqlPoint(x: 0.11290163968935263d, y: 0.21375835270995536d), new NpgsqlTypes.NpgsqlPoint(x: 0.306652220874455d, y: 0.5362246784835505d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8650787376749717d, y: 0.7444471574714266d), new NpgsqlTypes.NpgsqlPoint(x: 0.6403616833936386d, y: 0.8138975606854972d), new NpgsqlTypes.NpgsqlPoint(x: 0.490334338023915d, y: 0.09130752657812113d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9372800735659653d, y: 0.0162158732394313d), new NpgsqlTypes.NpgsqlPoint(x: 0.566181398488063d, y: 0.471353203332987d), new NpgsqlTypes.NpgsqlPoint(x: 0.8938267967955497d, y: 0.6360025895129363d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5019706114614657d, y: 0.16596302242977468d), new NpgsqlTypes.NpgsqlPoint(x: 0.2839322526471598d, y: 0.042944897757447587d), new NpgsqlTypes.NpgsqlPoint(x: 0.9637253802603426d, y: 0.3035176100764686d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15431237482982685d, y: 0.5097677632532812d), new NpgsqlTypes.NpgsqlPoint(x: 0.39791503560372044d, y: 0.7375433700601399d), new NpgsqlTypes.NpgsqlPoint(x: 0.7544678429343522d, y: 0.07316464893846875d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12170221568665074d, y: 0.47493621058249935d), new NpgsqlTypes.NpgsqlPoint(x: 0.8303728036684325d, y: 0.9914124691388136d), new NpgsqlTypes.NpgsqlPoint(x: 0.1174876031836165d, y: 0.2818589735755872d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9257367295210233d, y: 0.15486360393709853d), new NpgsqlTypes.NpgsqlPoint(x: 0.5808759934265157d, y: 0.5649458771503836d), new NpgsqlTypes.NpgsqlPoint(x: 0.11127787185205851d, y: 0.008834632188332248d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6484174681190642d, y: 0.17897107287498215d), new NpgsqlTypes.NpgsqlPoint(x: 0.3615219053233103d, y: 0.1001027012483039d), new NpgsqlTypes.NpgsqlPoint(x: 0.948115134045244d, y: 0.8924221583694069d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8092483964236844d, y: 0.16183705480725297d), new NpgsqlTypes.NpgsqlPoint(x: 0.7596615317799441d, y: 0.8586208306071342d), new NpgsqlTypes.NpgsqlPoint(x: 0.5375804945164103d, y: 0.3588512540479628d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8474668259722927d, y: 0.1819919940027881d), new NpgsqlTypes.NpgsqlPoint(x: 0.615700654773769d, y: 0.3875694628296037d), new NpgsqlTypes.NpgsqlPoint(x: 0.5454363327257369d, y: 0.561728238955845d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7977596006801084d, y: 0.8084579444654827d), new NpgsqlTypes.NpgsqlPoint(x: 0.3149415948570833d, y: 0.25305423104854174d), new NpgsqlTypes.NpgsqlPoint(x: 0.5821998933878052d, y: 0.2915531223480735d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.777141679840868d, y: 0.8076085032677405d), new NpgsqlTypes.NpgsqlPoint(x: 0.49750054950550504d, y: 0.9525890900658319d), new NpgsqlTypes.NpgsqlPoint(x: 0.5644220709064954d, y: 0.5231150489346158d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0563537494750066d, y: 0.6350012425682197d), new NpgsqlTypes.NpgsqlPoint(x: 0.8363566656996576d, y: 0.9001113831910301d), new NpgsqlTypes.NpgsqlPoint(x: 0.27278670231091295d, y: 0.8465593650182984d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8931817043437679d, y: 0.3085717109441318d), new NpgsqlTypes.NpgsqlPoint(x: 0.7104688257163159d, y: 0.054121112777550606d), new NpgsqlTypes.NpgsqlPoint(x: 0.844957583725981d, y: 0.265775633428345d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6349072686543055d, y: 0.8920449943377503d), new NpgsqlTypes.NpgsqlPoint(x: 0.22446984551795934d, y: 0.8029951033577032d), new NpgsqlTypes.NpgsqlPoint(x: 0.048143615735721346d, y: 0.03695387344582357d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46413197033349296d, y: 0.5549434427135247d), new NpgsqlTypes.NpgsqlPoint(x: 0.41938435011587805d, y: 0.5457971451278961d), new NpgsqlTypes.NpgsqlPoint(x: 0.24552424501355463d, y: 0.3297208592138582d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.644079575710833d, y: 0.38628054809966883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6815018274938908d, y: 0.20296675442094336d), new NpgsqlTypes.NpgsqlPoint(x: 0.8022602738157246d, y: 0.694312745940946d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49837163818781893d, y: 0.464211489100987d), new NpgsqlTypes.NpgsqlPoint(x: 0.18081679353401714d, y: 0.9424865886067908d), new NpgsqlTypes.NpgsqlPoint(x: 0.7759402257077126d, y: 0.5269624029982946d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3621527578414774d, y: 0.6700465348177397d), new NpgsqlTypes.NpgsqlPoint(x: 0.5539180520875117d, y: 0.007564278892389531d), new NpgsqlTypes.NpgsqlPoint(x: 0.4679523994592455d, y: 0.23362481486112519d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.550966948535055d, y: 0.11809496618691784d), new NpgsqlTypes.NpgsqlPoint(x: 0.26161462778301825d, y: 0.09885255422240813d), new NpgsqlTypes.NpgsqlPoint(x: 0.6389948037384271d, y: 0.1442891333432964d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9208568740890463d, y: 0.6460543892198596d), new NpgsqlTypes.NpgsqlPoint(x: 0.24505576166701404d, y: 0.9364649626038566d), new NpgsqlTypes.NpgsqlPoint(x: 0.5484601089940572d, y: 0.9438388588069144d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9809108080034521d, y: 0.501823770498509d), new NpgsqlTypes.NpgsqlPoint(x: 0.0013616521159991457d, y: 0.8925655267243119d), new NpgsqlTypes.NpgsqlPoint(x: 0.2241802353565342d, y: 0.1814889865664171d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6931467279707214d, y: 0.570948831130915d), new NpgsqlTypes.NpgsqlPoint(x: 0.8241231486322572d, y: 0.7224921841028585d), new NpgsqlTypes.NpgsqlPoint(x: 0.5173499760736233d, y: 0.027207825782829764d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27420138461703547d, y: 0.09261833534277875d), new NpgsqlTypes.NpgsqlPoint(x: 0.3635811922485963d, y: 0.6293323465372196d), new NpgsqlTypes.NpgsqlPoint(x: 0.18566088407217152d, y: 0.4089248892196845d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9791638506748948d, y: 0.5815458405051117d), new NpgsqlTypes.NpgsqlPoint(x: 0.007410204678079291d, y: 0.6436536445732475d), new NpgsqlTypes.NpgsqlPoint(x: 0.7562119371815833d, y: 0.13861211133867235d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39760131460713877d, y: 0.8951236678318213d), new NpgsqlTypes.NpgsqlPoint(x: 0.24366654398396226d, y: 0.6222803261527301d), new NpgsqlTypes.NpgsqlPoint(x: 0.6761887007174576d, y: 0.8179924273715304d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8866583891820486d, y: 0.3939836731825883d), new NpgsqlTypes.NpgsqlPoint(x: 0.15140841550721407d, y: 0.7051532473885775d), new NpgsqlTypes.NpgsqlPoint(x: 0.7473975721507063d, y: 0.7507419600232498d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7578952972760509d, y: 0.7524087767490396d), new NpgsqlTypes.NpgsqlPoint(x: 0.8945273421638016d, y: 0.6598821442506053d), new NpgsqlTypes.NpgsqlPoint(x: 0.43435917974039284d, y: 0.21312082652388253d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6609609007793532d, y: 0.39253245434343054d), new NpgsqlTypes.NpgsqlPoint(x: 0.37832668046905893d, y: 0.0732127012720305d), new NpgsqlTypes.NpgsqlPoint(x: 0.06574583542418522d, y: 0.9740793714971675d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25318187585834984d, y: 0.5104978029330274d), new NpgsqlTypes.NpgsqlPoint(x: 0.1604252363731664d, y: 0.4722252259907418d), new NpgsqlTypes.NpgsqlPoint(x: 0.46110121391220615d, y: 0.4044424998271652d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5451385806765613d, y: 0.20870246744038967d), new NpgsqlTypes.NpgsqlPoint(x: 0.6004496409551663d, y: 0.33706248351994184d), new NpgsqlTypes.NpgsqlPoint(x: 0.26480477476320086d, y: 0.29260953329128636d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06935520705041187d, y: 0.9866508254322538d), new NpgsqlTypes.NpgsqlPoint(x: 0.43173426259863024d, y: 0.14240851914109554d), new NpgsqlTypes.NpgsqlPoint(x: 0.05467182863613396d, y: 0.4308699280632151d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4739667321988488d, y: 0.7287783807575148d), new NpgsqlTypes.NpgsqlPoint(x: 0.6607434785910855d, y: 0.0035256552132942875d), new NpgsqlTypes.NpgsqlPoint(x: 0.0879388571106573d, y: 0.46808988750671543d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04328870797159423d, y: 0.4469944837683618d), new NpgsqlTypes.NpgsqlPoint(x: 0.8345904376308408d, y: 0.1057434655794296d), new NpgsqlTypes.NpgsqlPoint(x: 0.31961951998652915d, y: 0.0009540884028409469d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4549945988174502d, y: 0.8114487092484851d), new NpgsqlTypes.NpgsqlPoint(x: 0.22390575093129916d, y: 0.7410059868475669d), new NpgsqlTypes.NpgsqlPoint(x: 0.9586407376093218d, y: 0.9816353868965522d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.754284158772406d, y: 0.8545207219406141d), new NpgsqlTypes.NpgsqlPoint(x: 0.9710518683865016d, y: 0.588351048131504d), new NpgsqlTypes.NpgsqlPoint(x: 0.13816636205162813d, y: 0.678769886883405d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42121638871417233d, y: 0.012245971643451092d), new NpgsqlTypes.NpgsqlPoint(x: 0.18470064843860512d, y: 0.6719436829600615d), new NpgsqlTypes.NpgsqlPoint(x: 0.7702398907485807d, y: 0.2554999345168595d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22128698802411007d, y: 0.6531111502766881d), new NpgsqlTypes.NpgsqlPoint(x: 0.9744553624742407d, y: 0.07946377334727206d), new NpgsqlTypes.NpgsqlPoint(x: 0.8457410728902063d, y: 0.12924277000292517d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7822286160637627d, y: 0.49991429923047515d), new NpgsqlTypes.NpgsqlPoint(x: 0.46356487772446897d, y: 0.8062881507630052d), new NpgsqlTypes.NpgsqlPoint(x: 0.04241521398924142d, y: 0.6461887229381195d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8966590919572702d, y: 0.9834126983923546d), new NpgsqlTypes.NpgsqlPoint(x: 0.6358726637368026d, y: 0.7343095711892268d), new NpgsqlTypes.NpgsqlPoint(x: 0.8721193715760117d, y: 0.07017333047897756d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.996727202066098d, y: 0.3934617921295426d), new NpgsqlTypes.NpgsqlPoint(x: 0.4553763117510172d, y: 0.6531443106979117d), new NpgsqlTypes.NpgsqlPoint(x: 0.1623122571841883d, y: 0.33994566823459227d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7060478290834118d, y: 0.7857474902298692d), new NpgsqlTypes.NpgsqlPoint(x: 0.6428936278350482d, y: 0.6856421192272735d), new NpgsqlTypes.NpgsqlPoint(x: 0.9272487357328189d, y: 0.28378362758253584d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29717616118415513d, y: 0.91103016093123d), new NpgsqlTypes.NpgsqlPoint(x: 0.8888046463065735d, y: 0.2739955458604688d), new NpgsqlTypes.NpgsqlPoint(x: 0.17480311344462296d, y: 0.6805710227205855d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22854804938709705d, y: 0.3539823775713572d), new NpgsqlTypes.NpgsqlPoint(x: 0.07506275964543807d, y: 0.2988574529836676d), new NpgsqlTypes.NpgsqlPoint(x: 0.27199007192032876d, y: 0.12408124492930195d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3941780049988921d, y: 0.4858631998123265d), new NpgsqlTypes.NpgsqlPoint(x: 0.08952127761364281d, y: 0.7596303192412892d), new NpgsqlTypes.NpgsqlPoint(x: 0.3043391926866932d, y: 0.6246034346002213d)), }, }, },
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7613487515075563d, y: 0.7037468969855332d), new NpgsqlTypes.NpgsqlPoint(x: 0.2471699325149571d, y: 0.3946469796064226d), new NpgsqlTypes.NpgsqlPoint(x: 0.8178817614640244d, y: 0.317527048369298d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7455150949595739d, y: 0.5857252549753548d), new NpgsqlTypes.NpgsqlPoint(x: 0.7425655978842834d, y: 0.12698103028028784d), new NpgsqlTypes.NpgsqlPoint(x: 0.6143735178358742d, y: 0.5322928121517885d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3134964360810225d, y: 0.137716774248413d), new NpgsqlTypes.NpgsqlPoint(x: 0.8453403999069219d, y: 0.3580041876678678d), new NpgsqlTypes.NpgsqlPoint(x: 0.7940295085299204d, y: 0.4554762225225638d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8857654631920214d, y: 0.936500584423394d), new NpgsqlTypes.NpgsqlPoint(x: 0.553884377685194d, y: 0.6730062033709547d), new NpgsqlTypes.NpgsqlPoint(x: 0.3818167308571413d, y: 0.35217347455724957d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9477683606846412d, y: 0.6071392540936492d), new NpgsqlTypes.NpgsqlPoint(x: 0.034294993732363d, y: 0.4431533663123033d), new NpgsqlTypes.NpgsqlPoint(x: 0.41437462418933135d, y: 0.20745386752076111d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9640061209125241d, y: 0.9500794673382345d), new NpgsqlTypes.NpgsqlPoint(x: 0.3001021722346391d, y: 0.9959683301813165d), new NpgsqlTypes.NpgsqlPoint(x: 0.3410449024097576d, y: 0.09795947604664279d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09199195954830441d, y: 0.170810634122603d), new NpgsqlTypes.NpgsqlPoint(x: 0.28192657842288893d, y: 0.1878538604857234d), new NpgsqlTypes.NpgsqlPoint(x: 0.6863418339537415d, y: 0.1339932106846864d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01812021837147615d, y: 0.4597625963015609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9252428367839189d, y: 0.6671351396557383d), new NpgsqlTypes.NpgsqlPoint(x: 0.8210832569463467d, y: 0.8978187715460545d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7405725899341932d, y: 0.021495855212766868d), new NpgsqlTypes.NpgsqlPoint(x: 0.9167970566777133d, y: 0.2453586044667888d), new NpgsqlTypes.NpgsqlPoint(x: 0.5766464642237219d, y: 0.842085727044722d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6092939789322759d, y: 0.8260975702091448d), new NpgsqlTypes.NpgsqlPoint(x: 0.552020516593483d, y: 0.5344893988466934d), new NpgsqlTypes.NpgsqlPoint(x: 0.4480248120789041d, y: 0.8529921418432116d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.904547141675362d, y: 0.3583321346221311d), new NpgsqlTypes.NpgsqlPoint(x: 0.10313491431654587d, y: 0.13694477806056626d), new NpgsqlTypes.NpgsqlPoint(x: 0.90254682020623d, y: 0.5773843001663855d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9320544684169286d, y: 0.6015378774421754d), new NpgsqlTypes.NpgsqlPoint(x: 0.024978584298632867d, y: 0.19609303929415312d), new NpgsqlTypes.NpgsqlPoint(x: 0.31646803653592803d, y: 0.5389983176586783d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4978950524161919d, y: 0.9300177867758359d), new NpgsqlTypes.NpgsqlPoint(x: 0.5809348027079225d, y: 0.35079019321341487d), new NpgsqlTypes.NpgsqlPoint(x: 0.7097977091659671d, y: 0.7625346012195157d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7967576559726881d, y: 0.8183958349543109d), new NpgsqlTypes.NpgsqlPoint(x: 0.41429937777668924d, y: 0.5595079393456891d), new NpgsqlTypes.NpgsqlPoint(x: 0.8610499858443224d, y: 0.07768146511367724d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26343132321217366d, y: 0.4841793263703391d), new NpgsqlTypes.NpgsqlPoint(x: 0.12549054811921712d, y: 0.7988734758779461d), new NpgsqlTypes.NpgsqlPoint(x: 0.27486735399807627d, y: 0.761108161651287d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2801396109958564d, y: 0.322286173235491d), new NpgsqlTypes.NpgsqlPoint(x: 0.15004985091040735d, y: 0.5736998468888609d), new NpgsqlTypes.NpgsqlPoint(x: 0.16675038638188056d, y: 0.16708268304972307d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6391808321435694d, y: 0.6374088642653783d), new NpgsqlTypes.NpgsqlPoint(x: 0.6690736332392839d, y: 0.04342591846616417d), new NpgsqlTypes.NpgsqlPoint(x: 0.2824059343993648d, y: 0.5403622799435043d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2487385354330096d, y: 0.681571626238989d), new NpgsqlTypes.NpgsqlPoint(x: 0.18719764245564796d, y: 0.5217535873154898d), new NpgsqlTypes.NpgsqlPoint(x: 0.7112392878738236d, y: 0.048638763851491795d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21343849836657625d, y: 0.4689756685662847d), new NpgsqlTypes.NpgsqlPoint(x: 0.4114729051526158d, y: 0.3576849823358823d), new NpgsqlTypes.NpgsqlPoint(x: 0.47467083529594556d, y: 0.3717806325627848d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6546025877598682d, y: 0.4426640384930789d), new NpgsqlTypes.NpgsqlPoint(x: 0.5499358133355089d, y: 0.16299790844014994d), new NpgsqlTypes.NpgsqlPoint(x: 0.3412855072560932d, y: 0.025001030055394335d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24208590939118224d, y: 0.9672474576786819d), new NpgsqlTypes.NpgsqlPoint(x: 0.18668247314280173d, y: 0.4143536870796932d), new NpgsqlTypes.NpgsqlPoint(x: 0.915475651024245d, y: 0.6519709204317438d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3716426283816553d, y: 0.40853154187262486d), new NpgsqlTypes.NpgsqlPoint(x: 0.45886047062263535d, y: 0.42258535569128164d), new NpgsqlTypes.NpgsqlPoint(x: 0.9201940622650921d, y: 0.5747012295874668d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3064705468805671d, y: 0.6361896100079217d), new NpgsqlTypes.NpgsqlPoint(x: 0.04086046392536069d, y: 0.2548757396081458d), new NpgsqlTypes.NpgsqlPoint(x: 0.6529713870166437d, y: 0.9856436708092717d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7806779053310493d, y: 0.37464498835749993d), new NpgsqlTypes.NpgsqlPoint(x: 0.418734498942121d, y: 0.169965150462829d), new NpgsqlTypes.NpgsqlPoint(x: 0.032108287039997574d, y: 0.060542326608596486d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9093394112750119d, y: 0.38415261610699614d), new NpgsqlTypes.NpgsqlPoint(x: 0.957237990452368d, y: 0.030079429791198597d), new NpgsqlTypes.NpgsqlPoint(x: 0.3109262057506451d, y: 0.2703190677408671d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9096535484061081d, y: 0.8071685726838398d), new NpgsqlTypes.NpgsqlPoint(x: 0.8990591371746122d, y: 0.40306551079213593d), new NpgsqlTypes.NpgsqlPoint(x: 0.43178059985294415d, y: 0.31340766086442795d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9389137537487303d, y: 0.5698322348304868d), new NpgsqlTypes.NpgsqlPoint(x: 0.5230859266162118d, y: 0.19063861462319365d), new NpgsqlTypes.NpgsqlPoint(x: 0.4382380401185465d, y: 0.8173270654629198d)), }, }, },
    ModelInner = new NpgsqlPathpathMMArrayD3E1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2570429354702297d, y: 0.8140298336376505d), new NpgsqlTypes.NpgsqlPoint(x: 0.25836716961342154d, y: 0.7059889597211664d), new NpgsqlTypes.NpgsqlPoint(x: 0.13418520262289957d, y: 0.5282914225268025d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6472504523458131d, y: 0.7124019055001003d), new NpgsqlTypes.NpgsqlPoint(x: 0.4897927997575774d, y: 0.006988973124792075d), new NpgsqlTypes.NpgsqlPoint(x: 0.11933584412412657d, y: 0.2469349533699724d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8933840522113372d, y: 0.5472613597562525d), new NpgsqlTypes.NpgsqlPoint(x: 0.2213802051717879d, y: 0.3405168857069045d), new NpgsqlTypes.NpgsqlPoint(x: 0.16005253321552582d, y: 0.4134189507126792d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17818474119897199d, y: 0.6697242190022027d), new NpgsqlTypes.NpgsqlPoint(x: 0.7054597915974194d, y: 0.09199206525623604d), new NpgsqlTypes.NpgsqlPoint(x: 0.7296693755877937d, y: 0.4764952203640951d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4387394479472877d, y: 0.3347889787771956d), new NpgsqlTypes.NpgsqlPoint(x: 0.9632063038757893d, y: 0.5751510057591775d), new NpgsqlTypes.NpgsqlPoint(x: 0.7423766824614122d, y: 0.7433065271322673d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8995212034157996d, y: 0.30526844451975366d), new NpgsqlTypes.NpgsqlPoint(x: 0.48986714659516195d, y: 0.5731340191624964d), new NpgsqlTypes.NpgsqlPoint(x: 0.9556798307571085d, y: 0.2661183720295017d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5340498794551172d, y: 0.7650155322117846d), new NpgsqlTypes.NpgsqlPoint(x: 0.4550365602595584d, y: 0.4698981251019205d), new NpgsqlTypes.NpgsqlPoint(x: 0.6053285289600058d, y: 0.5246736114999268d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5909998356640289d, y: 0.41167841425065643d), new NpgsqlTypes.NpgsqlPoint(x: 0.11856994620888961d, y: 0.585172093769591d), new NpgsqlTypes.NpgsqlPoint(x: 0.7757202961878015d, y: 0.140333941069672d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007641339054633267d, y: 0.16667312393483724d), new NpgsqlTypes.NpgsqlPoint(x: 0.5813588439053945d, y: 0.2938203010493394d), new NpgsqlTypes.NpgsqlPoint(x: 0.07356258197804988d, y: 0.6645708863231207d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8009318354068082d, y: 0.7087601273166952d), new NpgsqlTypes.NpgsqlPoint(x: 0.7320076420598156d, y: 0.13715881978024203d), new NpgsqlTypes.NpgsqlPoint(x: 0.4616081527051342d, y: 0.7583073970714274d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9049926739564704d, y: 0.7220189427628915d), new NpgsqlTypes.NpgsqlPoint(x: 0.9928278573395882d, y: 0.8511784245308167d), new NpgsqlTypes.NpgsqlPoint(x: 0.02983487958357789d, y: 0.04436286830374958d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5370449252596898d, y: 0.17721478724312634d), new NpgsqlTypes.NpgsqlPoint(x: 0.06713377412712696d, y: 0.4368787633422786d), new NpgsqlTypes.NpgsqlPoint(x: 0.6917857869418502d, y: 0.25064559859371793d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6881384436548047d, y: 0.39042984041280726d), new NpgsqlTypes.NpgsqlPoint(x: 0.5040024706865461d, y: 0.2342699693755388d), new NpgsqlTypes.NpgsqlPoint(x: 0.015831101093239375d, y: 0.40528377400296367d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013785423703872701d, y: 0.7312218769970839d), new NpgsqlTypes.NpgsqlPoint(x: 0.18668612518461347d, y: 0.12618026988197018d), new NpgsqlTypes.NpgsqlPoint(x: 0.8385099981596628d, y: 0.7505345964198407d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8074153649206111d, y: 0.795715108311572d), new NpgsqlTypes.NpgsqlPoint(x: 0.3225470812972082d, y: 0.15442910145222066d), new NpgsqlTypes.NpgsqlPoint(x: 0.4818397214456851d, y: 0.9787516084553957d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8147353700057807d, y: 0.9176882711237861d), new NpgsqlTypes.NpgsqlPoint(x: 0.5179462664885409d, y: 0.6468307462587585d), new NpgsqlTypes.NpgsqlPoint(x: 0.36610638720266475d, y: 0.8067886332620753d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4573907873717321d, y: 0.7666318841445514d), new NpgsqlTypes.NpgsqlPoint(x: 0.12178770509046521d, y: 0.6373212702935788d), new NpgsqlTypes.NpgsqlPoint(x: 0.4641434230210715d, y: 0.5109000066251326d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29551302875151475d, y: 0.14891169333322496d), new NpgsqlTypes.NpgsqlPoint(x: 0.5161225732176502d, y: 0.9709757169112074d), new NpgsqlTypes.NpgsqlPoint(x: 0.1539397098135884d, y: 0.7378404714054737d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6110531706559726d, y: 0.06139509829539169d), new NpgsqlTypes.NpgsqlPoint(x: 0.4247842009216274d, y: 0.7618476307390278d), new NpgsqlTypes.NpgsqlPoint(x: 0.034119415613173665d, y: 0.919198958984324d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4038853648548921d, y: 0.2398220799250903d), new NpgsqlTypes.NpgsqlPoint(x: 0.32052382424421233d, y: 0.04226101128758908d), new NpgsqlTypes.NpgsqlPoint(x: 0.026015318037566626d, y: 0.26454813693971546d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5105027490919689d, y: 0.3430506259077829d), new NpgsqlTypes.NpgsqlPoint(x: 0.1830237476761949d, y: 0.6166801174989799d), new NpgsqlTypes.NpgsqlPoint(x: 0.6594759802985453d, y: 0.5585672039216251d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4029175768006704d, y: 0.36918926795468043d), new NpgsqlTypes.NpgsqlPoint(x: 0.295440606721626d, y: 0.5540734247601192d), new NpgsqlTypes.NpgsqlPoint(x: 0.22997878234374547d, y: 0.8102724736352979d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5475077344535025d, y: 0.36720325916670304d), new NpgsqlTypes.NpgsqlPoint(x: 0.866990109699317d, y: 0.6255999626852078d), new NpgsqlTypes.NpgsqlPoint(x: 0.06151632768756454d, y: 0.20505230311262979d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.022813308038365787d, y: 0.794579388933337d), new NpgsqlTypes.NpgsqlPoint(x: 0.827718965890505d, y: 0.27272668336311234d), new NpgsqlTypes.NpgsqlPoint(x: 0.671031057522809d, y: 0.6799864175332428d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8192004878804122d, y: 0.008643980756551928d), new NpgsqlTypes.NpgsqlPoint(x: 0.32575560646035806d, y: 0.821792028462624d), new NpgsqlTypes.NpgsqlPoint(x: 0.6831045129745309d, y: 0.8977297217661219d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.187738930721142d, y: 0.09767580227877692d), new NpgsqlTypes.NpgsqlPoint(x: 0.09409603477047856d, y: 0.9363394018051774d), new NpgsqlTypes.NpgsqlPoint(x: 0.9237251653277849d, y: 0.6862976243760224d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7103502518648925d, y: 0.7363397386363885d), new NpgsqlTypes.NpgsqlPoint(x: 0.5244420993660092d, y: 0.4035053071256588d), new NpgsqlTypes.NpgsqlPoint(x: 0.2596338530168285d, y: 0.5506860121840064d)), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4324073438010976d, y: 0.7488355084902225d), new NpgsqlTypes.NpgsqlPoint(x: 0.5842989708426948d, y: 0.1036616857488647d), new NpgsqlTypes.NpgsqlPoint(x: 0.9902960512824187d, y: 0.8192249270898354d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.695496234650113d, y: 0.7508458073327766d), new NpgsqlTypes.NpgsqlPoint(x: 0.7396281853400827d, y: 0.37958660298290015d), new NpgsqlTypes.NpgsqlPoint(x: 0.9561071988141947d, y: 0.42645796580071527d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5642768040125723d, y: 0.39449804077540196d), new NpgsqlTypes.NpgsqlPoint(x: 0.67656268392012d, y: 0.08115506337701206d), new NpgsqlTypes.NpgsqlPoint(x: 0.3360914125103668d, y: 0.9222050450340982d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5247590402385768d, y: 0.356039992051539d), new NpgsqlTypes.NpgsqlPoint(x: 0.5656530111628605d, y: 0.43132396312935684d), new NpgsqlTypes.NpgsqlPoint(x: 0.4381564738854984d, y: 0.5656706050337107d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.033422370095518295d, y: 0.7367948127338093d), new NpgsqlTypes.NpgsqlPoint(x: 0.5430726047081833d, y: 0.811114870700495d), new NpgsqlTypes.NpgsqlPoint(x: 0.22593838267837774d, y: 0.8534460848569754d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22531620413337194d, y: 0.759455478746053d), new NpgsqlTypes.NpgsqlPoint(x: 0.39869063737930677d, y: 0.7594752246538224d), new NpgsqlTypes.NpgsqlPoint(x: 0.8554850062101443d, y: 0.9304791598798876d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.055601437566663914d, y: 0.14961441177374735d), new NpgsqlTypes.NpgsqlPoint(x: 0.3025044665525952d, y: 0.3656605135704464d), new NpgsqlTypes.NpgsqlPoint(x: 0.6339568161170069d, y: 0.9524432982409868d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4307081506718117d, y: 0.4092028474058197d), new NpgsqlTypes.NpgsqlPoint(x: 0.04239190820079286d, y: 0.41588061104599794d), new NpgsqlTypes.NpgsqlPoint(x: 0.40545212304123923d, y: 0.5218637372089109d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7793917401069043d, y: 0.3271660971496856d), new NpgsqlTypes.NpgsqlPoint(x: 0.4818998635520023d, y: 0.85352849789131d), new NpgsqlTypes.NpgsqlPoint(x: 0.8993545501423829d, y: 0.8476767019895703d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6700362373581044d, y: 0.9315160932275094d), new NpgsqlTypes.NpgsqlPoint(x: 0.018689769981418025d, y: 0.20358612825078815d), new NpgsqlTypes.NpgsqlPoint(x: 0.8012776619234772d, y: 0.30786240027890155d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6368613492036065d, y: 0.5061519459975923d), new NpgsqlTypes.NpgsqlPoint(x: 0.20952346013078804d, y: 0.7197469541597685d), new NpgsqlTypes.NpgsqlPoint(x: 0.33672882327915976d, y: 0.05679088265020038d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20740695888026361d, y: 0.9495584013433926d), new NpgsqlTypes.NpgsqlPoint(x: 0.6617267165691548d, y: 0.4160425824616665d), new NpgsqlTypes.NpgsqlPoint(x: 0.951157771592864d, y: 0.1453148499419008d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5365303164533274d, y: 0.6848447933632636d), new NpgsqlTypes.NpgsqlPoint(x: 0.958598470298515d, y: 0.39939508660404477d), new NpgsqlTypes.NpgsqlPoint(x: 0.21242858965371514d, y: 0.039121857599310195d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4760176176848946d, y: 0.645988943753542d), new NpgsqlTypes.NpgsqlPoint(x: 0.3092077252347961d, y: 0.16558085652599108d), new NpgsqlTypes.NpgsqlPoint(x: 0.7107375005632081d, y: 0.4718609144263485d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9138982787184087d, y: 0.2912768997692543d), new NpgsqlTypes.NpgsqlPoint(x: 0.41699842432107537d, y: 0.10726510910269449d), new NpgsqlTypes.NpgsqlPoint(x: 0.8463810765940061d, y: 0.46795728660016167d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6549870784497652d, y: 0.29533783312127504d), new NpgsqlTypes.NpgsqlPoint(x: 0.6681334515405434d, y: 0.6667860177829287d), new NpgsqlTypes.NpgsqlPoint(x: 0.030965456679876713d, y: 0.14692421106833364d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7948373495077337d, y: 0.5315930579931393d), new NpgsqlTypes.NpgsqlPoint(x: 0.6116526880282884d, y: 0.8255238611627099d), new NpgsqlTypes.NpgsqlPoint(x: 0.841786795329041d, y: 0.7448889812407349d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4162349072683016d, y: 0.7080054650553064d), new NpgsqlTypes.NpgsqlPoint(x: 0.7717545242729659d, y: 0.7532482113963394d), new NpgsqlTypes.NpgsqlPoint(x: 0.023404813654858914d, y: 0.6860449982755084d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.806365292009005d, y: 0.9086854341934318d), new NpgsqlTypes.NpgsqlPoint(x: 0.7018586133814843d, y: 0.9864020028646224d), new NpgsqlTypes.NpgsqlPoint(x: 0.5923092265759755d, y: 0.00906243500007653d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8865300723354814d, y: 0.4891764920803794d), new NpgsqlTypes.NpgsqlPoint(x: 0.34623979618087997d, y: 0.8935875488792484d), new NpgsqlTypes.NpgsqlPoint(x: 0.9833253685487755d, y: 0.09007110845578314d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8179795755798344d, y: 0.3917226087586533d), new NpgsqlTypes.NpgsqlPoint(x: 0.04224884964125841d, y: 0.47888863505511114d), new NpgsqlTypes.NpgsqlPoint(x: 0.6668500265036479d, y: 0.057491072250027586d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02906193868526996d, y: 0.2742106386979217d), new NpgsqlTypes.NpgsqlPoint(x: 0.04321534368595226d, y: 0.146743870722718d), new NpgsqlTypes.NpgsqlPoint(x: 0.796609157327169d, y: 0.7469984259266278d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3189183653864811d, y: 0.7257264045069894d), new NpgsqlTypes.NpgsqlPoint(x: 0.8072042334001565d, y: 0.36848466220084064d), new NpgsqlTypes.NpgsqlPoint(x: 0.16131036638675367d, y: 0.7350455722219079d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01452277562734694d, y: 0.705004922068023d), new NpgsqlTypes.NpgsqlPoint(x: 0.4206744967532895d, y: 0.7606855791315995d), new NpgsqlTypes.NpgsqlPoint(x: 0.6595265077975723d, y: 0.902932420213371d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.132844505598957d, y: 0.6228912188496498d), new NpgsqlTypes.NpgsqlPoint(x: 0.8055312808808202d, y: 0.09702800168763326d), new NpgsqlTypes.NpgsqlPoint(x: 0.6722736562821429d, y: 0.8408762696619365d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6651244965733045d, y: 0.6622777867752938d), new NpgsqlTypes.NpgsqlPoint(x: 0.7697696721384144d, y: 0.8183036095988359d), new NpgsqlTypes.NpgsqlPoint(x: 0.46212414093017473d, y: 0.4676152275481794d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7166184179011617d, y: 0.7563502621820068d), new NpgsqlTypes.NpgsqlPoint(x: 0.4483099173625533d, y: 0.17468937294898357d), new NpgsqlTypes.NpgsqlPoint(x: 0.9572089936201214d, y: 0.656474793394225d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44169823820570076d, y: 0.05980789049672963d), new NpgsqlTypes.NpgsqlPoint(x: 0.516401045776469d, y: 0.1581819420293783d), new NpgsqlTypes.NpgsqlPoint(x: 0.5066364460223247d, y: 0.6393367587568785d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3431565051458494d, y: 0.47599719747121516d), new NpgsqlTypes.NpgsqlPoint(x: 0.31552551547430474d, y: 0.20550215183930953d), new NpgsqlTypes.NpgsqlPoint(x: 0.5136914403982789d, y: 0.22870566053264885d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.649410681184525d, y: 0.8759407463686075d), new NpgsqlTypes.NpgsqlPoint(x: 0.6880472188819448d, y: 0.037244867014821326d), new NpgsqlTypes.NpgsqlPoint(x: 0.8166458981367276d, y: 0.39757139467760927d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0916793117868151d, y: 0.2731887347579113d), new NpgsqlTypes.NpgsqlPoint(x: 0.20283879868845045d, y: 0.6495057578440196d), new NpgsqlTypes.NpgsqlPoint(x: 0.27135129875743d, y: 0.6396739751276075d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48385584294604234d, y: 0.43376997072910795d), new NpgsqlTypes.NpgsqlPoint(x: 0.39267886307968913d, y: 0.8155451655491394d), new NpgsqlTypes.NpgsqlPoint(x: 0.08799873959926918d, y: 0.921288679543806d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6843170032384582d, y: 0.1254499136783097d), new NpgsqlTypes.NpgsqlPoint(x: 0.17953037520020598d, y: 0.4076360031459171d), new NpgsqlTypes.NpgsqlPoint(x: 0.43265459910865944d, y: 0.12232969349371925d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15277032001609803d, y: 0.7450225369676965d), new NpgsqlTypes.NpgsqlPoint(x: 0.11650045257992003d, y: 0.2733622560011165d), new NpgsqlTypes.NpgsqlPoint(x: 0.21008299124118313d, y: 0.29600643295186524d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.903147439360496d, y: 0.5517164587933284d), new NpgsqlTypes.NpgsqlPoint(x: 0.2945157395381357d, y: 0.5604049792666097d), new NpgsqlTypes.NpgsqlPoint(x: 0.46108517348374156d, y: 0.5633560666733326d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11769027572725588d, y: 0.6119941774910684d), new NpgsqlTypes.NpgsqlPoint(x: 0.826088851417683d, y: 0.5644264177024126d), new NpgsqlTypes.NpgsqlPoint(x: 0.20262412506708327d, y: 0.9428519151337422d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8520794311277616d, y: 0.18899570495754425d), new NpgsqlTypes.NpgsqlPoint(x: 0.49438885499102114d, y: 0.5540375166901018d), new NpgsqlTypes.NpgsqlPoint(x: 0.5532529156046603d, y: 0.8273981769772711d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8475772033375825d, y: 0.7326722006319272d), new NpgsqlTypes.NpgsqlPoint(x: 0.6582858163492157d, y: 0.287582193325409d), new NpgsqlTypes.NpgsqlPoint(x: 0.17850134502364734d, y: 0.5261247320206628d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.446211942724962d, y: 0.0515822656968592d), new NpgsqlTypes.NpgsqlPoint(x: 0.13234744580274815d, y: 0.8775900565104662d), new NpgsqlTypes.NpgsqlPoint(x: 0.4739971901347413d, y: 0.8759504568110364d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2841094147833596d, y: 0.6911706692058508d), new NpgsqlTypes.NpgsqlPoint(x: 0.11574262284649472d, y: 0.9234914207580301d), new NpgsqlTypes.NpgsqlPoint(x: 0.48872990366802915d, y: 0.1643076312074756d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6890750047986974d, y: 0.42633382557084665d), new NpgsqlTypes.NpgsqlPoint(x: 0.3768966605692188d, y: 0.9054933375736824d), new NpgsqlTypes.NpgsqlPoint(x: 0.23233675384092223d, y: 0.9571922609919118d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08574558987657055d, y: 0.9323602624876968d), new NpgsqlTypes.NpgsqlPoint(x: 0.3489291634419993d, y: 0.5024247764951233d), new NpgsqlTypes.NpgsqlPoint(x: 0.24719834880972302d, y: 0.9120705357064175d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18142740608376584d, y: 0.6037744147191096d), new NpgsqlTypes.NpgsqlPoint(x: 0.5775215336361889d, y: 0.8455238053300198d), new NpgsqlTypes.NpgsqlPoint(x: 0.08491295585194503d, y: 0.6389089735292622d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4508298679218996d, y: 0.34431377991480794d), new NpgsqlTypes.NpgsqlPoint(x: 0.020912063830642813d, y: 0.4978001433394762d), new NpgsqlTypes.NpgsqlPoint(x: 0.6530858556464209d, y: 0.7057596206258303d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39564739837261964d, y: 0.17818309446238434d), new NpgsqlTypes.NpgsqlPoint(x: 0.20895170968358834d, y: 0.9320626769830482d), new NpgsqlTypes.NpgsqlPoint(x: 0.6604248620485315d, y: 0.36350357541455336d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6615854378252646d, y: 0.9958323135256372d), new NpgsqlTypes.NpgsqlPoint(x: 0.783634380467075d, y: 0.703501726990607d), new NpgsqlTypes.NpgsqlPoint(x: 0.8802804430452748d, y: 0.7543548802844631d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9458877574183888d, y: 0.7988171347887939d), new NpgsqlTypes.NpgsqlPoint(x: 0.2104250520315959d, y: 0.7858254782268886d), new NpgsqlTypes.NpgsqlPoint(x: 0.04572977179363713d, y: 0.6718158037407465d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.543747604048682d, y: 0.2745715645119816d), new NpgsqlTypes.NpgsqlPoint(x: 0.6801420686921864d, y: 0.6856761389737606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5375507374330812d, y: 0.39098651052401956d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34519969628199954d, y: 0.8320134123267656d), new NpgsqlTypes.NpgsqlPoint(x: 0.4102978937418056d, y: 0.8903570383999195d), new NpgsqlTypes.NpgsqlPoint(x: 0.4081440520568228d, y: 0.3203616305491793d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6812818535782486d, y: 0.17677209232779123d), new NpgsqlTypes.NpgsqlPoint(x: 0.17329352950497712d, y: 0.2570504339960009d), new NpgsqlTypes.NpgsqlPoint(x: 0.023672510316804174d, y: 0.7773404135246004d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08192382851378888d, y: 0.7909091028296621d), new NpgsqlTypes.NpgsqlPoint(x: 0.750688012962843d, y: 0.4294821828109543d), new NpgsqlTypes.NpgsqlPoint(x: 0.11212493652101674d, y: 0.9861470721000797d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3708463731731806d, y: 0.4519941083803328d), new NpgsqlTypes.NpgsqlPoint(x: 0.1680836091331317d, y: 0.26599206694013067d), new NpgsqlTypes.NpgsqlPoint(x: 0.8724192024372095d, y: 0.5355842534467985d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8207479299253216d, y: 0.46082208579463346d), new NpgsqlTypes.NpgsqlPoint(x: 0.7546987538851605d, y: 0.9349774027937672d), new NpgsqlTypes.NpgsqlPoint(x: 0.06902534906415514d, y: 0.07291307644636658d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7406554034105044d, y: 0.06946503626481915d), new NpgsqlTypes.NpgsqlPoint(x: 0.7983828183746848d, y: 0.94751062013509d), new NpgsqlTypes.NpgsqlPoint(x: 0.8974844916666614d, y: 0.7009002321170537d)), }, }, },
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43428378927948796d, y: 0.7088750434303581d), new NpgsqlTypes.NpgsqlPoint(x: 0.2990498768452462d, y: 0.7498063427323265d), new NpgsqlTypes.NpgsqlPoint(x: 0.24753027180146248d, y: 0.17113529518825266d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8011089496505517d, y: 0.07336632078228644d), new NpgsqlTypes.NpgsqlPoint(x: 0.8769432177427581d, y: 0.29715171026863285d), new NpgsqlTypes.NpgsqlPoint(x: 0.8019087609370764d, y: 0.537587942697443d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5127708733522665d, y: 0.3768587591731104d), new NpgsqlTypes.NpgsqlPoint(x: 0.605345205140355d, y: 0.9776897955732757d), new NpgsqlTypes.NpgsqlPoint(x: 0.28273113394082106d, y: 0.7066464148708357d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.972500677594112d, y: 0.723146274570947d), new NpgsqlTypes.NpgsqlPoint(x: 0.9458867633399144d, y: 0.08759307841257125d), new NpgsqlTypes.NpgsqlPoint(x: 0.07119985747456226d, y: 0.5720073843359434d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.565088282827213d, y: 0.48575668541858996d), new NpgsqlTypes.NpgsqlPoint(x: 0.7263337524101814d, y: 0.24461325057025674d), new NpgsqlTypes.NpgsqlPoint(x: 0.7184212476563094d, y: 0.7990646651045943d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35711929244933294d, y: 0.7117976689136355d), new NpgsqlTypes.NpgsqlPoint(x: 0.8798652747178691d, y: 0.19934174862521126d), new NpgsqlTypes.NpgsqlPoint(x: 0.12173929313588039d, y: 0.23166783362290644d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3486020006896403d, y: 0.45595500693473257d), new NpgsqlTypes.NpgsqlPoint(x: 0.8198858126402551d, y: 0.7103306851638884d), new NpgsqlTypes.NpgsqlPoint(x: 0.6447121601058333d, y: 0.14862125260559433d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4901777358552758d, y: 0.6293686131840179d), new NpgsqlTypes.NpgsqlPoint(x: 0.7110699892079069d, y: 0.6542435312859181d), new NpgsqlTypes.NpgsqlPoint(x: 0.08765421804468387d, y: 0.026550336275607656d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27680607204483365d, y: 0.44556802484399205d), new NpgsqlTypes.NpgsqlPoint(x: 0.03358942492271966d, y: 0.10756012546652638d), new NpgsqlTypes.NpgsqlPoint(x: 0.16069182327802d, y: 0.7957274018298677d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7922154834893838d, y: 0.5645866690389201d), new NpgsqlTypes.NpgsqlPoint(x: 0.012445414896262164d, y: 0.1538471878453751d), new NpgsqlTypes.NpgsqlPoint(x: 0.8091018814840809d, y: 0.9610482770150377d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5791052540632139d, y: 0.8993874970994368d), new NpgsqlTypes.NpgsqlPoint(x: 0.25487836326083824d, y: 0.5536906455729489d), new NpgsqlTypes.NpgsqlPoint(x: 0.14768884815630068d, y: 0.5945643758581616d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2314714467184118d, y: 0.3832339910476561d), new NpgsqlTypes.NpgsqlPoint(x: 0.3004430145882916d, y: 0.7445092899952043d), new NpgsqlTypes.NpgsqlPoint(x: 0.9800735563393218d, y: 0.0839641081149447d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42195118653952446d, y: 0.7122481215511612d), new NpgsqlTypes.NpgsqlPoint(x: 0.53938600453824d, y: 0.5720659410699114d), new NpgsqlTypes.NpgsqlPoint(x: 0.4581490889842662d, y: 0.24491355898080114d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9205521393716958d, y: 0.8706176271367347d), new NpgsqlTypes.NpgsqlPoint(x: 0.8876673057772182d, y: 0.2783929952167693d), new NpgsqlTypes.NpgsqlPoint(x: 0.07229665799145235d, y: 0.8584591355578549d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4534692731267176d, y: 0.9169097478124437d), new NpgsqlTypes.NpgsqlPoint(x: 0.1658062381151324d, y: 0.9578490808759831d), new NpgsqlTypes.NpgsqlPoint(x: 0.1961197553109716d, y: 0.6917910697063236d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3181137966337143d, y: 0.4361636657409709d), new NpgsqlTypes.NpgsqlPoint(x: 0.42729630862741474d, y: 0.9302740620237883d), new NpgsqlTypes.NpgsqlPoint(x: 0.7535402504079628d, y: 0.3434623272978399d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6297051055164075d, y: 0.9087573691702802d), new NpgsqlTypes.NpgsqlPoint(x: 0.17303673892521643d, y: 0.9150077310914282d), new NpgsqlTypes.NpgsqlPoint(x: 0.9009531736829645d, y: 0.54562657897845d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5447408495356167d, y: 0.45304858880905285d), new NpgsqlTypes.NpgsqlPoint(x: 0.5820280736119819d, y: 0.9406826087601151d), new NpgsqlTypes.NpgsqlPoint(x: 0.3943586494076937d, y: 0.9408091572829373d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.532417005147095d, y: 0.7836149609909753d), new NpgsqlTypes.NpgsqlPoint(x: 0.7853386918474603d, y: 0.379041262608119d), new NpgsqlTypes.NpgsqlPoint(x: 0.7875357434713114d, y: 0.19657271794458786d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.516535040288168d, y: 0.5695813269405257d), new NpgsqlTypes.NpgsqlPoint(x: 0.06946546979231571d, y: 0.7483065525200765d), new NpgsqlTypes.NpgsqlPoint(x: 0.42851207866492824d, y: 0.7331980414082198d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3216100931088334d, y: 0.9915512445937051d), new NpgsqlTypes.NpgsqlPoint(x: 0.8501063333645495d, y: 0.5900750065547948d), new NpgsqlTypes.NpgsqlPoint(x: 0.5387095536663786d, y: 0.9319177015506374d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1643265369026824d, y: 0.9942168744475796d), new NpgsqlTypes.NpgsqlPoint(x: 0.7456235687491047d, y: 0.9505504293540683d), new NpgsqlTypes.NpgsqlPoint(x: 0.7376388681956549d, y: 0.6762683425913328d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8623452520348392d, y: 0.05236898206915752d), new NpgsqlTypes.NpgsqlPoint(x: 0.10921717517148344d, y: 0.6157041243656691d), new NpgsqlTypes.NpgsqlPoint(x: 0.5825115194202793d, y: 0.6990293004985426d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8691897970884385d, y: 0.33329898468297525d), new NpgsqlTypes.NpgsqlPoint(x: 0.30386403442697596d, y: 0.345373339597675d), new NpgsqlTypes.NpgsqlPoint(x: 0.13812382721803995d, y: 0.24852963561627284d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17876049910435254d, y: 0.28177129801388945d), new NpgsqlTypes.NpgsqlPoint(x: 0.5161307753954316d, y: 0.6211076796341696d), new NpgsqlTypes.NpgsqlPoint(x: 0.35798488594488187d, y: 0.9594363813817052d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9403608740409197d, y: 0.2398822928979073d), new NpgsqlTypes.NpgsqlPoint(x: 0.976397633121177d, y: 0.01602557533445992d), new NpgsqlTypes.NpgsqlPoint(x: 0.02109469130678443d, y: 0.9943526470276299d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7140211790412807d, y: 0.12240537838847432d), new NpgsqlTypes.NpgsqlPoint(x: 0.7711753082973529d, y: 0.8813317201780849d), new NpgsqlTypes.NpgsqlPoint(x: 0.22712411157338963d, y: 0.26529155478816724d)), }, }, },
    ModelInner = new NpgsqlPathpathMMArrayD3E1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8148178605848281d, y: 0.06640118983634846d), new NpgsqlTypes.NpgsqlPoint(x: 0.2271080188056216d, y: 0.8855128307267288d), new NpgsqlTypes.NpgsqlPoint(x: 0.5771102839604607d, y: 0.5178328033279886d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8102375946334914d, y: 0.503933016801588d), new NpgsqlTypes.NpgsqlPoint(x: 0.5671318139148325d, y: 0.9962389614184086d), new NpgsqlTypes.NpgsqlPoint(x: 0.0689967611792981d, y: 0.8897796354676709d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08809847837626517d, y: 0.8008293462963032d), new NpgsqlTypes.NpgsqlPoint(x: 0.3862620468570789d, y: 0.4926625201600382d), new NpgsqlTypes.NpgsqlPoint(x: 0.49191538348764674d, y: 0.010445933093206183d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9190774232824621d, y: 0.5240959923433829d), new NpgsqlTypes.NpgsqlPoint(x: 0.8697484057655551d, y: 0.08228869901094682d), new NpgsqlTypes.NpgsqlPoint(x: 0.9116376329916912d, y: 0.5376121574694245d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7996532379730865d, y: 0.32405975793189956d), new NpgsqlTypes.NpgsqlPoint(x: 0.5692444570031491d, y: 0.7185931292338655d), new NpgsqlTypes.NpgsqlPoint(x: 0.02582162648056019d, y: 0.358679044066177d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.062073754002645476d, y: 0.4565604184916545d), new NpgsqlTypes.NpgsqlPoint(x: 0.9025882525829596d, y: 0.5236574665030033d), new NpgsqlTypes.NpgsqlPoint(x: 0.00401406995866449d, y: 0.3549867047369213d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3404174514285734d, y: 0.8854614461274828d), new NpgsqlTypes.NpgsqlPoint(x: 0.7982982752806773d, y: 0.7399929067879547d), new NpgsqlTypes.NpgsqlPoint(x: 0.4049569523591219d, y: 0.4344315875971191d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6352629903138842d, y: 0.9873579155554244d), new NpgsqlTypes.NpgsqlPoint(x: 0.20822245460722344d, y: 0.35879927832953706d), new NpgsqlTypes.NpgsqlPoint(x: 0.28970069071652504d, y: 0.11962415534413662d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7264218036358641d, y: 0.7045648808682542d), new NpgsqlTypes.NpgsqlPoint(x: 0.6376930242899925d, y: 0.7447353055526709d), new NpgsqlTypes.NpgsqlPoint(x: 0.38203265188167534d, y: 0.12470493533840488d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2825265862436418d, y: 0.3552400591580841d), new NpgsqlTypes.NpgsqlPoint(x: 0.13617146426016535d, y: 0.6465430601840924d), new NpgsqlTypes.NpgsqlPoint(x: 0.7797975530349888d, y: 0.4153417798132799d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4214210798812753d, y: 0.6782110217235847d), new NpgsqlTypes.NpgsqlPoint(x: 0.5540762180359584d, y: 0.12313643879523628d), new NpgsqlTypes.NpgsqlPoint(x: 0.11574562006766809d, y: 0.5135082213839467d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5489259751939248d, y: 0.6283413272913418d), new NpgsqlTypes.NpgsqlPoint(x: 0.8762910056131525d, y: 0.7399258798647709d), new NpgsqlTypes.NpgsqlPoint(x: 0.6040029604855716d, y: 0.34147386776024424d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2589280166173652d, y: 0.579698318592206d), new NpgsqlTypes.NpgsqlPoint(x: 0.5295596539922727d, y: 0.26610396390279056d), new NpgsqlTypes.NpgsqlPoint(x: 0.40363672939447615d, y: 0.6594558586086029d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.032001135329532415d, y: 0.645890189160355d), new NpgsqlTypes.NpgsqlPoint(x: 0.5754200140796009d, y: 0.6970556801649629d), new NpgsqlTypes.NpgsqlPoint(x: 0.3497384718174845d, y: 0.09211349622096932d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4945362571129699d, y: 0.5481644033490136d), new NpgsqlTypes.NpgsqlPoint(x: 0.5354156897236069d, y: 0.22529255455302044d), new NpgsqlTypes.NpgsqlPoint(x: 0.8156020045713668d, y: 0.5241365153227513d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.969735003911177d, y: 0.5234386984802846d), new NpgsqlTypes.NpgsqlPoint(x: 0.729342448054733d, y: 0.07140938412252673d), new NpgsqlTypes.NpgsqlPoint(x: 0.34115286624523056d, y: 0.13813889449869132d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45188012350553863d, y: 0.9054530597501763d), new NpgsqlTypes.NpgsqlPoint(x: 0.24116163089722142d, y: 0.9658159858018351d), new NpgsqlTypes.NpgsqlPoint(x: 0.7160553100725329d, y: 0.628934081725516d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16554554031639057d, y: 0.4828588961932838d), new NpgsqlTypes.NpgsqlPoint(x: 0.12276947194464549d, y: 0.26495449705349283d), new NpgsqlTypes.NpgsqlPoint(x: 0.9182240697475205d, y: 0.5260992087666008d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.586663853842825d, y: 0.11407379087039904d), new NpgsqlTypes.NpgsqlPoint(x: 0.2372008041718513d, y: 0.28052385841864247d), new NpgsqlTypes.NpgsqlPoint(x: 0.7984069242347506d, y: 0.2651621100147922d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42142821870124003d, y: 0.7742709797988235d), new NpgsqlTypes.NpgsqlPoint(x: 0.44840428296462853d, y: 0.3187751630128739d), new NpgsqlTypes.NpgsqlPoint(x: 0.6023685994049234d, y: 0.15801345532756983d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5655117838426847d, y: 0.6271182854096532d), new NpgsqlTypes.NpgsqlPoint(x: 0.8370194909248407d, y: 0.48416934497380926d), new NpgsqlTypes.NpgsqlPoint(x: 0.4449205622612714d, y: 0.6499984964548595d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9408484309287528d, y: 0.8416532791480145d), new NpgsqlTypes.NpgsqlPoint(x: 0.8757178897443185d, y: 0.23949402361324956d), new NpgsqlTypes.NpgsqlPoint(x: 0.5857193886241391d, y: 0.8791362548980839d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06989142931938663d, y: 0.509376008045657d), new NpgsqlTypes.NpgsqlPoint(x: 0.6042225798452739d, y: 0.39153048194445084d), new NpgsqlTypes.NpgsqlPoint(x: 0.7923998536121507d, y: 0.017482838557401292d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26765063754911944d, y: 0.36139162285353266d), new NpgsqlTypes.NpgsqlPoint(x: 0.3661609249590566d, y: 0.028515953784644665d), new NpgsqlTypes.NpgsqlPoint(x: 0.14569397905793213d, y: 0.07165560406140725d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33602704596132127d, y: 0.30636793025696296d), new NpgsqlTypes.NpgsqlPoint(x: 0.3617093497075794d, y: 0.16108892409044484d), new NpgsqlTypes.NpgsqlPoint(x: 0.2945687665719827d, y: 0.8752563040414559d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4656087773413259d, y: 0.18721029026572344d), new NpgsqlTypes.NpgsqlPoint(x: 0.8256264878848122d, y: 0.7649927743103595d), new NpgsqlTypes.NpgsqlPoint(x: 0.7324622081882395d, y: 0.5373934196195647d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.93767393148356d, y: 0.3737775948053479d), new NpgsqlTypes.NpgsqlPoint(x: 0.6541854856313192d, y: 0.3635481085994079d), new NpgsqlTypes.NpgsqlPoint(x: 0.4006903139666327d, y: 0.5073639948979557d)), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21072811975951755d, y: 0.36995182743584354d), new NpgsqlTypes.NpgsqlPoint(x: 0.4977911984266169d, y: 0.9156370044209067d), new NpgsqlTypes.NpgsqlPoint(x: 0.41255636543491236d, y: 0.18451706588690975d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12746953409366446d, y: 0.5972496373723789d), new NpgsqlTypes.NpgsqlPoint(x: 0.9135574844521628d, y: 0.6059107022367745d), new NpgsqlTypes.NpgsqlPoint(x: 0.9068293115711535d, y: 0.4471586380879069d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7088944083945937d, y: 0.37927079536753294d), new NpgsqlTypes.NpgsqlPoint(x: 0.09751083987475373d, y: 0.05128403140489535d), new NpgsqlTypes.NpgsqlPoint(x: 0.9445935155130856d, y: 0.11772002653643965d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7394715406547487d, y: 0.9959795985023971d), new NpgsqlTypes.NpgsqlPoint(x: 0.44042043307410195d, y: 0.5253651743764435d), new NpgsqlTypes.NpgsqlPoint(x: 0.2646233537098649d, y: 0.4928391518399754d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8007017595630177d, y: 0.6202681143311711d), new NpgsqlTypes.NpgsqlPoint(x: 0.33152976127870004d, y: 0.4346107387540854d), new NpgsqlTypes.NpgsqlPoint(x: 0.3758673893724377d, y: 0.7214120141375006d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2000961838304911d, y: 0.29219278197114795d), new NpgsqlTypes.NpgsqlPoint(x: 0.9895173013144468d, y: 0.8541799833432756d), new NpgsqlTypes.NpgsqlPoint(x: 0.6888595502410554d, y: 0.9596970554248755d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024397242517665618d, y: 0.7029375126120136d), new NpgsqlTypes.NpgsqlPoint(x: 0.5963252713823896d, y: 0.7029654053459222d), new NpgsqlTypes.NpgsqlPoint(x: 0.7180414008930163d, y: 0.23443037636920927d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7972711462655508d, y: 0.08498719282941669d), new NpgsqlTypes.NpgsqlPoint(x: 0.7373559296295801d, y: 0.7634091715776687d), new NpgsqlTypes.NpgsqlPoint(x: 0.1385859224150886d, y: 0.6092479392883681d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7756519135675151d, y: 0.6467010079744152d), new NpgsqlTypes.NpgsqlPoint(x: 0.538333546403731d, y: 0.796269424456077d), new NpgsqlTypes.NpgsqlPoint(x: 0.5026225702304968d, y: 0.18903389948545302d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11627817840291865d, y: 0.8409270601068863d), new NpgsqlTypes.NpgsqlPoint(x: 0.8056496857635626d, y: 0.9180260931143078d), new NpgsqlTypes.NpgsqlPoint(x: 0.47898170673982055d, y: 0.15431672206673663d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8848966538630094d, y: 0.6670837489612435d), new NpgsqlTypes.NpgsqlPoint(x: 0.09844125758895661d, y: 0.11015607585852627d), new NpgsqlTypes.NpgsqlPoint(x: 0.28864802914587906d, y: 0.27523445826333826d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5468338590753433d, y: 0.7757667549249259d), new NpgsqlTypes.NpgsqlPoint(x: 0.41171599584665697d, y: 0.619682021376679d), new NpgsqlTypes.NpgsqlPoint(x: 0.5346387550866539d, y: 0.9854198968048241d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0626964073474201d, y: 0.05012124312767541d), new NpgsqlTypes.NpgsqlPoint(x: 0.29822403349983473d, y: 0.6612916942641188d), new NpgsqlTypes.NpgsqlPoint(x: 0.33319613639498313d, y: 0.541294354623509d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9072023403092384d, y: 0.47526544406065974d), new NpgsqlTypes.NpgsqlPoint(x: 0.30859937168865126d, y: 0.3139527528667587d), new NpgsqlTypes.NpgsqlPoint(x: 0.7731678106818654d, y: 0.10704488071950236d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15459076059121535d, y: 0.5531888483370193d), new NpgsqlTypes.NpgsqlPoint(x: 0.3774400149337236d, y: 0.13558488099573518d), new NpgsqlTypes.NpgsqlPoint(x: 0.004142982447735033d, y: 0.41662290088297316d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.976131974303664d, y: 0.28468505578873726d), new NpgsqlTypes.NpgsqlPoint(x: 0.24362345687052367d, y: 0.1265584708209634d), new NpgsqlTypes.NpgsqlPoint(x: 0.9831650284825505d, y: 0.7171015157404683d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14508776929690392d, y: 0.7473674650005689d), new NpgsqlTypes.NpgsqlPoint(x: 0.5909556438794277d, y: 0.6118624813571542d), new NpgsqlTypes.NpgsqlPoint(x: 0.8584299263690366d, y: 0.9749932750380399d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9367093921198957d, y: 0.7709439637833397d), new NpgsqlTypes.NpgsqlPoint(x: 0.5075964304691633d, y: 0.6225861863159692d), new NpgsqlTypes.NpgsqlPoint(x: 0.2071552252843818d, y: 0.8848366318939564d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7763388499377363d, y: 0.8777872779209533d), new NpgsqlTypes.NpgsqlPoint(x: 0.7232363021582943d, y: 0.9462293753324252d), new NpgsqlTypes.NpgsqlPoint(x: 0.9865502056778434d, y: 0.21031630550908387d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6427465728987608d, y: 0.4227977433606085d), new NpgsqlTypes.NpgsqlPoint(x: 0.6641416868073321d, y: 0.21740447541292196d), new NpgsqlTypes.NpgsqlPoint(x: 0.6113340699897202d, y: 0.8886124661419385d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7173551685450018d, y: 0.10487660810765354d), new NpgsqlTypes.NpgsqlPoint(x: 0.29040398923208965d, y: 0.3527173105598964d), new NpgsqlTypes.NpgsqlPoint(x: 0.8167523532227294d, y: 0.7269769304723402d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.010935574075002563d, y: 0.8291055059018363d), new NpgsqlTypes.NpgsqlPoint(x: 0.3613788072444163d, y: 0.3477670209620215d), new NpgsqlTypes.NpgsqlPoint(x: 0.15346891711310395d, y: 0.5921515299466898d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14574485210713106d, y: 0.19007773969195807d), new NpgsqlTypes.NpgsqlPoint(x: 0.5671979751763442d, y: 0.7205332720892602d), new NpgsqlTypes.NpgsqlPoint(x: 0.0011513234249159732d, y: 0.2077117735191355d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29556853185279675d, y: 0.015368248175944177d), new NpgsqlTypes.NpgsqlPoint(x: 0.6400885869243311d, y: 0.16955523493199676d), new NpgsqlTypes.NpgsqlPoint(x: 0.8302143578183152d, y: 0.3773830490651977d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6066541096324037d, y: 0.09792517770846731d), new NpgsqlTypes.NpgsqlPoint(x: 0.7451254344994132d, y: 0.73133502767292d), new NpgsqlTypes.NpgsqlPoint(x: 0.6986174432956759d, y: 0.2774244853819132d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34628126425329386d, y: 0.6394982226326984d), new NpgsqlTypes.NpgsqlPoint(x: 0.05262534809896258d, y: 0.7070898596524029d), new NpgsqlTypes.NpgsqlPoint(x: 0.8517594255061633d, y: 0.39038302097093236d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6070469159076866d, y: 0.5828166297887046d), new NpgsqlTypes.NpgsqlPoint(x: 0.8610790350652292d, y: 0.5926617878913626d), new NpgsqlTypes.NpgsqlPoint(x: 0.5501563729825499d, y: 0.8005392507296644d)), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7365082515449226d, y: 0.9050455677174857d), new NpgsqlTypes.NpgsqlPoint(x: 0.37774801129603397d, y: 0.24001779118895994d), new NpgsqlTypes.NpgsqlPoint(x: 0.753690947867974d, y: 0.5233952338263821d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8247137072429215d, y: 0.6095765036285543d), new NpgsqlTypes.NpgsqlPoint(x: 0.11307320862233394d, y: 0.32912352040872794d), new NpgsqlTypes.NpgsqlPoint(x: 0.11195008951901342d, y: 0.22069954346167164d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06919487089436138d, y: 0.714435643514663d), new NpgsqlTypes.NpgsqlPoint(x: 0.8996921172275562d, y: 0.18603285391236823d), new NpgsqlTypes.NpgsqlPoint(x: 0.5691619541849472d, y: 0.3266881497644064d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13341984565520792d, y: 0.16138021752760923d), new NpgsqlTypes.NpgsqlPoint(x: 0.6739875521958918d, y: 0.24853516281543497d), new NpgsqlTypes.NpgsqlPoint(x: 0.14087091505848148d, y: 0.2917538460060365d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27942593857481546d, y: 0.41192221914286364d), new NpgsqlTypes.NpgsqlPoint(x: 0.10649039216150025d, y: 0.9195505839340651d), new NpgsqlTypes.NpgsqlPoint(x: 0.34297034861133646d, y: 0.11466248186238359d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8464972332966847d, y: 0.1909876290777528d), new NpgsqlTypes.NpgsqlPoint(x: 0.625112456553742d, y: 0.19247121857524263d), new NpgsqlTypes.NpgsqlPoint(x: 0.6605799562156038d, y: 0.5642750857297617d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6879354170719743d, y: 0.3889317642168776d), new NpgsqlTypes.NpgsqlPoint(x: 0.36624038515923685d, y: 0.6874349057857476d), new NpgsqlTypes.NpgsqlPoint(x: 0.39878973971493603d, y: 0.4135932799274872d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8558874107103366d, y: 0.4102366582739959d), new NpgsqlTypes.NpgsqlPoint(x: 0.20375011642916074d, y: 0.314376372238109d), new NpgsqlTypes.NpgsqlPoint(x: 0.9030642434213403d, y: 0.28935690541276227d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2080295503961771d, y: 0.39676649314618817d), new NpgsqlTypes.NpgsqlPoint(x: 0.05174534705823208d, y: 0.4474703368287135d), new NpgsqlTypes.NpgsqlPoint(x: 0.6340567678275821d, y: 0.06343247539998909d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5255710916004924d, y: 0.24020761022277404d), new NpgsqlTypes.NpgsqlPoint(x: 0.5432833327311551d, y: 0.8713431359322714d), new NpgsqlTypes.NpgsqlPoint(x: 0.19101719331652545d, y: 0.4700968314242199d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25941821099556384d, y: 0.4102720056248168d), new NpgsqlTypes.NpgsqlPoint(x: 0.505219355695547d, y: 0.6883772403242799d), new NpgsqlTypes.NpgsqlPoint(x: 0.23053756758589927d, y: 0.5837091094006917d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.715546100444727d, y: 0.6482103072582004d), new NpgsqlTypes.NpgsqlPoint(x: 0.6687511675947331d, y: 0.11014013899255282d), new NpgsqlTypes.NpgsqlPoint(x: 0.656440214409268d, y: 0.08061430343276277d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30390391820195395d, y: 0.9391010422880631d), new NpgsqlTypes.NpgsqlPoint(x: 0.7768154023625204d, y: 0.17921545747473389d), new NpgsqlTypes.NpgsqlPoint(x: 0.40417320957641834d, y: 0.5756130437621567d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4845133327729073d, y: 0.9764224638666489d), new NpgsqlTypes.NpgsqlPoint(x: 0.22124178672244788d, y: 0.8859116908141454d), new NpgsqlTypes.NpgsqlPoint(x: 0.829141780880766d, y: 0.6531413465519214d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30619178169748085d, y: 0.41708363311782526d), new NpgsqlTypes.NpgsqlPoint(x: 0.28119516799363253d, y: 0.04000392166276978d), new NpgsqlTypes.NpgsqlPoint(x: 0.5246280388840334d, y: 0.23519150246189646d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.623748828812975d, y: 0.528880579667838d), new NpgsqlTypes.NpgsqlPoint(x: 0.30807767530041275d, y: 0.41260294487006d), new NpgsqlTypes.NpgsqlPoint(x: 0.22464763934235144d, y: 0.41558058570636236d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7960538939519348d, y: 0.6827220642103898d), new NpgsqlTypes.NpgsqlPoint(x: 0.28536710004361643d, y: 0.751052837161349d), new NpgsqlTypes.NpgsqlPoint(x: 0.2835309685109887d, y: 0.5590611692790622d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31184335521530104d, y: 0.707919060128813d), new NpgsqlTypes.NpgsqlPoint(x: 0.7007321120933929d, y: 0.4077814799646543d), new NpgsqlTypes.NpgsqlPoint(x: 0.6752704861517504d, y: 0.9733356248687943d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9369967325488028d, y: 0.37897612683809134d), new NpgsqlTypes.NpgsqlPoint(x: 0.34700147720372676d, y: 0.47627056462804873d), new NpgsqlTypes.NpgsqlPoint(x: 0.45449983980806885d, y: 0.19994395324787562d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5251016651598894d, y: 0.8883587728544128d), new NpgsqlTypes.NpgsqlPoint(x: 0.019844895570232723d, y: 0.32790814972371185d), new NpgsqlTypes.NpgsqlPoint(x: 0.1824178761365659d, y: 0.8897551675119079d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6884150098163169d, y: 0.5420816191181951d), new NpgsqlTypes.NpgsqlPoint(x: 0.34352767706552145d, y: 0.07911631054366763d), new NpgsqlTypes.NpgsqlPoint(x: 0.4123063302516181d, y: 0.45305603113314163d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39694631114044854d, y: 0.07827213282449885d), new NpgsqlTypes.NpgsqlPoint(x: 0.09981651726030982d, y: 0.05835666230963377d), new NpgsqlTypes.NpgsqlPoint(x: 0.532931589271782d, y: 0.5623174405249358d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16316358674972842d, y: 0.2646051483893963d), new NpgsqlTypes.NpgsqlPoint(x: 0.7526118951345694d, y: 0.7333419627006982d), new NpgsqlTypes.NpgsqlPoint(x: 0.6289141129539297d, y: 0.4563987645162766d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7850440635348748d, y: 0.9614435393534863d), new NpgsqlTypes.NpgsqlPoint(x: 0.11776757796078441d, y: 0.10370537826427695d), new NpgsqlTypes.NpgsqlPoint(x: 0.0925715784277833d, y: 0.7689519780427733d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.055911674747873286d, y: 0.9326407020230835d), new NpgsqlTypes.NpgsqlPoint(x: 0.2554202583798486d, y: 0.5830825409103377d), new NpgsqlTypes.NpgsqlPoint(x: 0.47875182395438387d, y: 0.3468191126275014d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5856739556674709d, y: 0.7632669803631896d), new NpgsqlTypes.NpgsqlPoint(x: 0.5327387607347472d, y: 0.3822612079735055d), new NpgsqlTypes.NpgsqlPoint(x: 0.6631417913327552d, y: 0.673017442600067d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.508311981798587d, y: 0.9556991251217326d), new NpgsqlTypes.NpgsqlPoint(x: 0.2521450145756652d, y: 0.9990895051628548d), new NpgsqlTypes.NpgsqlPoint(x: 0.9882211661578281d, y: 0.5355669132877363d)), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5698961009106327d, y: 0.9401131184047306d), new NpgsqlTypes.NpgsqlPoint(x: 0.16172235377157873d, y: 0.7195952313918371d), new NpgsqlTypes.NpgsqlPoint(x: 0.6104293533771091d, y: 0.7329729728887162d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8189914709591946d, y: 0.8913066120798888d), new NpgsqlTypes.NpgsqlPoint(x: 0.7532675248682428d, y: 0.9158176879281476d), new NpgsqlTypes.NpgsqlPoint(x: 0.12794509540747423d, y: 0.49268802892819497d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2866407308345279d, y: 0.2421463415977828d), new NpgsqlTypes.NpgsqlPoint(x: 0.5421194611033442d, y: 0.3833897752700053d), new NpgsqlTypes.NpgsqlPoint(x: 0.8688558448961085d, y: 0.04182730055537409d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22553135027736193d, y: 0.017342396790133052d), new NpgsqlTypes.NpgsqlPoint(x: 0.8797682970459417d, y: 0.7046809456961544d), new NpgsqlTypes.NpgsqlPoint(x: 0.8751741139369043d, y: 0.028062236299770116d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45382654385621124d, y: 0.1304867907501187d), new NpgsqlTypes.NpgsqlPoint(x: 0.36428082406265805d, y: 0.8212230725110581d), new NpgsqlTypes.NpgsqlPoint(x: 0.6670130556393802d, y: 0.10100033901062455d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4551125603464108d, y: 0.11072677874650849d), new NpgsqlTypes.NpgsqlPoint(x: 0.48281376121183295d, y: 0.9267876382239357d), new NpgsqlTypes.NpgsqlPoint(x: 0.9572116933587599d, y: 0.809850109881491d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14067789691353816d, y: 0.751253590898316d), new NpgsqlTypes.NpgsqlPoint(x: 0.7197999332300011d, y: 0.6663824379064965d), new NpgsqlTypes.NpgsqlPoint(x: 0.03071725227872657d, y: 0.2908986696904664d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4273963095687222d, y: 0.1701142211651897d), new NpgsqlTypes.NpgsqlPoint(x: 0.9490369178791167d, y: 0.6988702599805844d), new NpgsqlTypes.NpgsqlPoint(x: 0.12201242745782381d, y: 0.41345363694259063d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5672564001293366d, y: 0.5550793371531917d), new NpgsqlTypes.NpgsqlPoint(x: 0.1643166438135346d, y: 0.4905340012725983d), new NpgsqlTypes.NpgsqlPoint(x: 0.2293670366740833d, y: 0.45005568119016715d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5644342239033296d, y: 0.11796086306784626d), new NpgsqlTypes.NpgsqlPoint(x: 0.42966157416893813d, y: 0.8639281351784576d), new NpgsqlTypes.NpgsqlPoint(x: 0.2393306049678794d, y: 0.3072519995589167d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2959709228566749d, y: 0.5543818477802646d), new NpgsqlTypes.NpgsqlPoint(x: 0.1565302718541406d, y: 0.3148230833971656d), new NpgsqlTypes.NpgsqlPoint(x: 0.6486792222659797d, y: 0.8405379721089904d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23945219393161177d, y: 0.8506616870827105d), new NpgsqlTypes.NpgsqlPoint(x: 0.39705548349226727d, y: 0.35255650247253967d), new NpgsqlTypes.NpgsqlPoint(x: 0.21665122914016788d, y: 0.3228429850115416d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5702287494002309d, y: 0.4722801428302479d), new NpgsqlTypes.NpgsqlPoint(x: 0.6394875772038112d, y: 0.915348678935065d), new NpgsqlTypes.NpgsqlPoint(x: 0.8527330181913636d, y: 0.5642990412946091d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5665006501383036d, y: 0.1707136874856119d), new NpgsqlTypes.NpgsqlPoint(x: 0.13171780962173896d, y: 0.7169253044488989d), new NpgsqlTypes.NpgsqlPoint(x: 0.08184775887664297d, y: 0.8085370975055134d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4322017010824102d, y: 0.8219541676315796d), new NpgsqlTypes.NpgsqlPoint(x: 0.8581183977458957d, y: 0.36022675972832774d), new NpgsqlTypes.NpgsqlPoint(x: 0.43906998955381116d, y: 0.1481579797347493d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9810417669908676d, y: 0.34354501062076903d), new NpgsqlTypes.NpgsqlPoint(x: 0.48649634789214724d, y: 0.40982228871698845d), new NpgsqlTypes.NpgsqlPoint(x: 0.7049811328379915d, y: 0.3520651430305901d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9371670264471401d, y: 0.866229871838664d), new NpgsqlTypes.NpgsqlPoint(x: 0.3559134777422839d, y: 0.09280845073279986d), new NpgsqlTypes.NpgsqlPoint(x: 0.2110964819697425d, y: 0.14916929547380364d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6501022973453556d, y: 0.8109944628886124d), new NpgsqlTypes.NpgsqlPoint(x: 0.6811237140393157d, y: 0.5571204067388709d), new NpgsqlTypes.NpgsqlPoint(x: 0.04782910276777963d, y: 0.695748305165124d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04439662352067819d, y: 0.8471463847228208d), new NpgsqlTypes.NpgsqlPoint(x: 0.7213190435189819d, y: 0.9492121703183394d), new NpgsqlTypes.NpgsqlPoint(x: 0.14487061958992076d, y: 0.5100109930925047d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.770098142381984d, y: 0.623570795846429d), new NpgsqlTypes.NpgsqlPoint(x: 0.568250562084699d, y: 0.9727436186832419d), new NpgsqlTypes.NpgsqlPoint(x: 0.4767349344835521d, y: 0.6551126401306498d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8001783664310166d, y: 0.37123877889975343d), new NpgsqlTypes.NpgsqlPoint(x: 0.4428986355361656d, y: 0.43934638492626765d), new NpgsqlTypes.NpgsqlPoint(x: 0.22751567790559912d, y: 0.5150674717693963d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9167014050451621d, y: 0.20131531261387803d), new NpgsqlTypes.NpgsqlPoint(x: 0.09277625884572571d, y: 0.29265193096542286d), new NpgsqlTypes.NpgsqlPoint(x: 0.5244181853679726d, y: 0.781098101870203d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.003578397769735786d, y: 0.9985929342459594d), new NpgsqlTypes.NpgsqlPoint(x: 0.0017066052444585367d, y: 0.7630897936947741d), new NpgsqlTypes.NpgsqlPoint(x: 0.6764935035417152d, y: 0.2382436746759462d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015489519548210318d, y: 0.19065225173165978d), new NpgsqlTypes.NpgsqlPoint(x: 0.03269342743407022d, y: 0.7351994365080701d), new NpgsqlTypes.NpgsqlPoint(x: 0.9698956949156196d, y: 0.6902671564465126d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.571365415559004d, y: 0.0270392048253576d), new NpgsqlTypes.NpgsqlPoint(x: 0.6455857436419139d, y: 0.9255007709365363d), new NpgsqlTypes.NpgsqlPoint(x: 0.17441536020069714d, y: 0.7509911631340072d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37393603472200476d, y: 0.7735404276557156d), new NpgsqlTypes.NpgsqlPoint(x: 0.15557643255641374d, y: 0.8956181365889967d), new NpgsqlTypes.NpgsqlPoint(x: 0.5618605246816971d, y: 0.2537327842938779d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05200985430404337d, y: 0.5243524283277173d), new NpgsqlTypes.NpgsqlPoint(x: 0.6826837436118677d, y: 0.8632549953720483d), new NpgsqlTypes.NpgsqlPoint(x: 0.033382026474501725d, y: 0.5959199985347062d)), }, }, },
    ModelInner = new NpgsqlPathpathMMArrayD3E1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9242810807224593d, y: 0.3493564253646948d), new NpgsqlTypes.NpgsqlPoint(x: 0.46081242615727336d, y: 0.6959452191406654d), new NpgsqlTypes.NpgsqlPoint(x: 0.08906623006875058d, y: 0.8962941996406142d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4055019656322443d, y: 0.8015586937986634d), new NpgsqlTypes.NpgsqlPoint(x: 0.23977560474049542d, y: 0.5981365315945004d), new NpgsqlTypes.NpgsqlPoint(x: 0.5949592301241944d, y: 0.690032880063009d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06319138698705762d, y: 0.4662565957279974d), new NpgsqlTypes.NpgsqlPoint(x: 0.869052648986788d, y: 0.8437613489829332d), new NpgsqlTypes.NpgsqlPoint(x: 0.5428885698328282d, y: 0.5139302246493141d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7544480564730777d, y: 0.6502405562741115d), new NpgsqlTypes.NpgsqlPoint(x: 0.7078180446580239d, y: 0.9398206319636111d), new NpgsqlTypes.NpgsqlPoint(x: 0.1132570782938701d, y: 0.09362300639000054d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6815018805910436d, y: 0.4040792968989808d), new NpgsqlTypes.NpgsqlPoint(x: 0.15092617387671525d, y: 0.5042020846105321d), new NpgsqlTypes.NpgsqlPoint(x: 0.7229846194569368d, y: 0.3560720892327566d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.807441867486243d, y: 0.06643505659303106d), new NpgsqlTypes.NpgsqlPoint(x: 0.05642402842116978d, y: 0.13203686036132944d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455790772185175d, y: 0.17432628559506835d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6569477034688989d, y: 0.6062226020134889d), new NpgsqlTypes.NpgsqlPoint(x: 0.44130195341499134d, y: 0.3171364501397992d), new NpgsqlTypes.NpgsqlPoint(x: 0.8202765770047832d, y: 0.032028204783573044d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7833386872904006d, y: 0.1485661915435773d), new NpgsqlTypes.NpgsqlPoint(x: 0.3460674258363484d, y: 0.6131409983176774d), new NpgsqlTypes.NpgsqlPoint(x: 0.6104997945487699d, y: 0.34262726348653694d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6082629119382211d, y: 0.0336829691932945d), new NpgsqlTypes.NpgsqlPoint(x: 0.13713418590485527d, y: 0.5759843028625892d), new NpgsqlTypes.NpgsqlPoint(x: 0.8680211679621812d, y: 0.5916364696616919d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2394389562693202d, y: 0.621770654408503d), new NpgsqlTypes.NpgsqlPoint(x: 0.9739617749818709d, y: 0.45191506492327904d), new NpgsqlTypes.NpgsqlPoint(x: 0.8702837841222028d, y: 0.42996227347612137d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4005622777299661d, y: 0.31630951114132644d), new NpgsqlTypes.NpgsqlPoint(x: 0.8852666503731804d, y: 0.8935167622160504d), new NpgsqlTypes.NpgsqlPoint(x: 0.9848720903572951d, y: 0.9475206602014844d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09702022982534941d, y: 0.6856490702774395d), new NpgsqlTypes.NpgsqlPoint(x: 0.520523682028566d, y: 0.21825556031851012d), new NpgsqlTypes.NpgsqlPoint(x: 0.6189038834694682d, y: 0.2800203435345583d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3574285593428369d, y: 0.7561536208029584d), new NpgsqlTypes.NpgsqlPoint(x: 0.9690479194609591d, y: 0.5963316669538763d), new NpgsqlTypes.NpgsqlPoint(x: 0.028096133235456344d, y: 0.13641214910168398d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19285259655426223d, y: 0.24796522890633477d), new NpgsqlTypes.NpgsqlPoint(x: 0.040100048081671225d, y: 0.6434273922426066d), new NpgsqlTypes.NpgsqlPoint(x: 0.9942335115288142d, y: 0.8335956422952566d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24154118147661197d, y: 0.9574947151203325d), new NpgsqlTypes.NpgsqlPoint(x: 0.7913951169901999d, y: 0.6535513503063308d), new NpgsqlTypes.NpgsqlPoint(x: 0.2740260749899126d, y: 0.14629771683884973d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8635084435758317d, y: 0.8102418760026476d), new NpgsqlTypes.NpgsqlPoint(x: 0.1149342210025166d, y: 0.637447198858571d), new NpgsqlTypes.NpgsqlPoint(x: 0.262063646817276d, y: 0.3941030685084811d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.451437575331307d, y: 0.3061272617642371d), new NpgsqlTypes.NpgsqlPoint(x: 0.5955289645734748d, y: 0.5982567105171401d), new NpgsqlTypes.NpgsqlPoint(x: 0.046934728841157014d, y: 0.23214122790725777d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01585286965549393d, y: 0.05805798674952667d), new NpgsqlTypes.NpgsqlPoint(x: 0.4932210995197157d, y: 0.714750631428198d), new NpgsqlTypes.NpgsqlPoint(x: 0.02558876789632203d, y: 0.49335256746222267d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8863985431958652d, y: 0.5442443621817757d), new NpgsqlTypes.NpgsqlPoint(x: 0.3708765987973651d, y: 0.6321961558543194d), new NpgsqlTypes.NpgsqlPoint(x: 0.5600896313076801d, y: 0.6599479121332794d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6291855842033846d, y: 0.5161283393034242d), new NpgsqlTypes.NpgsqlPoint(x: 0.17171917309248674d, y: 0.8057835580872266d), new NpgsqlTypes.NpgsqlPoint(x: 0.21353570856884585d, y: 0.27065156944681545d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6634002660268985d, y: 0.9402944521510073d), new NpgsqlTypes.NpgsqlPoint(x: 0.7424751589593831d, y: 0.9310822099778873d), new NpgsqlTypes.NpgsqlPoint(x: 0.5768517726602379d, y: 0.017586619743241494d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38267016633517803d, y: 0.5401383566264211d), new NpgsqlTypes.NpgsqlPoint(x: 0.9206736175155144d, y: 0.7935841343355989d), new NpgsqlTypes.NpgsqlPoint(x: 0.08096500484090852d, y: 0.09594037849475401d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.023678957482228258d, y: 0.42317555882971647d), new NpgsqlTypes.NpgsqlPoint(x: 0.7265865411157287d, y: 0.19509362356342086d), new NpgsqlTypes.NpgsqlPoint(x: 0.959360342297558d, y: 0.6367646637756157d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8030693088867547d, y: 0.21173506710197687d), new NpgsqlTypes.NpgsqlPoint(x: 0.3036763468678717d, y: 0.040494309419011554d), new NpgsqlTypes.NpgsqlPoint(x: 0.6105286562126006d, y: 0.09003896711917259d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03313847460522079d, y: 0.725688718048426d), new NpgsqlTypes.NpgsqlPoint(x: 0.17913622342093993d, y: 0.20473418674559452d), new NpgsqlTypes.NpgsqlPoint(x: 0.9458840289060927d, y: 0.05875168374381301d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6799641584821878d, y: 0.2862887299015474d), new NpgsqlTypes.NpgsqlPoint(x: 0.8623696592639557d, y: 0.08274001326490887d), new NpgsqlTypes.NpgsqlPoint(x: 0.9387743863216637d, y: 0.8710743671895278d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4497793042595579d, y: 0.6485376088483128d), new NpgsqlTypes.NpgsqlPoint(x: 0.6152114104428047d, y: 0.4038743080061027d), new NpgsqlTypes.NpgsqlPoint(x: 0.9944724880901725d, y: 0.5194960829302255d)), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6864582092298587d, y: 0.9954748718397162d), new NpgsqlTypes.NpgsqlPoint(x: 0.7457978010678021d, y: 0.9202691302684146d), new NpgsqlTypes.NpgsqlPoint(x: 0.47380704088190384d, y: 0.3179356845327599d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7642442695506864d, y: 0.165914098100436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5830838926641454d, y: 0.40616995024484004d), new NpgsqlTypes.NpgsqlPoint(x: 0.2558214486236018d, y: 0.5884270732241328d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6027799926296652d, y: 0.7399049317049036d), new NpgsqlTypes.NpgsqlPoint(x: 0.8614046169617418d, y: 0.30151030143047275d), new NpgsqlTypes.NpgsqlPoint(x: 0.696506848703642d, y: 0.4373890817830216d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7779469987286225d, y: 0.12091638335015853d), new NpgsqlTypes.NpgsqlPoint(x: 0.5511490629623602d, y: 0.4035935782299075d), new NpgsqlTypes.NpgsqlPoint(x: 0.40526332630701056d, y: 0.8739500134034995d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1448952323803293d, y: 0.061185550474690875d), new NpgsqlTypes.NpgsqlPoint(x: 0.10257825254942532d, y: 0.7887663877686392d), new NpgsqlTypes.NpgsqlPoint(x: 0.5283693428707426d, y: 0.5951397311429315d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5291869492920807d, y: 0.2986699660172626d), new NpgsqlTypes.NpgsqlPoint(x: 0.018107369853008648d, y: 0.3827682175432957d), new NpgsqlTypes.NpgsqlPoint(x: 0.13521557741308166d, y: 0.35269077324324405d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8920361734996465d, y: 0.8178865262055824d), new NpgsqlTypes.NpgsqlPoint(x: 0.8840527846907272d, y: 0.13664742833266852d), new NpgsqlTypes.NpgsqlPoint(x: 0.41603770758868075d, y: 0.7687836462967298d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6378083390310846d, y: 0.3676494277348208d), new NpgsqlTypes.NpgsqlPoint(x: 0.2618273998540682d, y: 0.8504538364045086d), new NpgsqlTypes.NpgsqlPoint(x: 0.1384540353798297d, y: 0.8995403524132538d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9923594781531455d, y: 0.6406799983799535d), new NpgsqlTypes.NpgsqlPoint(x: 0.6296826932377918d, y: 0.5586952268585735d), new NpgsqlTypes.NpgsqlPoint(x: 0.0005567416189214969d, y: 0.08191797929014d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28828094765098544d, y: 0.8941509161106128d), new NpgsqlTypes.NpgsqlPoint(x: 0.9875570047691282d, y: 0.9672314112980085d), new NpgsqlTypes.NpgsqlPoint(x: 0.48387059176405256d, y: 0.21673996598090017d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6245665132704546d, y: 0.720254134395571d), new NpgsqlTypes.NpgsqlPoint(x: 0.6944109019798825d, y: 0.7687448916932074d), new NpgsqlTypes.NpgsqlPoint(x: 0.3830327946557076d, y: 0.9557866048698646d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44891889414736164d, y: 0.9040618604823356d), new NpgsqlTypes.NpgsqlPoint(x: 0.5509980272748148d, y: 0.6564066671236759d), new NpgsqlTypes.NpgsqlPoint(x: 0.4007256777390663d, y: 0.12634750472787915d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38137208130576816d, y: 0.44494474054291056d), new NpgsqlTypes.NpgsqlPoint(x: 0.7939630863892824d, y: 0.7757402764840283d), new NpgsqlTypes.NpgsqlPoint(x: 0.8825369414496326d, y: 0.29308926417184633d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7756563319709959d, y: 0.7775417104772172d), new NpgsqlTypes.NpgsqlPoint(x: 0.39178322439181545d, y: 0.3949026628523099d), new NpgsqlTypes.NpgsqlPoint(x: 0.7061822654857154d, y: 0.43574318898703535d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48426854026203414d, y: 0.7795007701013805d), new NpgsqlTypes.NpgsqlPoint(x: 0.0797595168800449d, y: 0.6887543668422933d), new NpgsqlTypes.NpgsqlPoint(x: 0.6396574380918032d, y: 0.4936818298568636d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6663346713225934d, y: 0.8816133426024166d), new NpgsqlTypes.NpgsqlPoint(x: 0.5850045406940432d, y: 0.13775848895202547d), new NpgsqlTypes.NpgsqlPoint(x: 0.3119894455771731d, y: 0.3352340921972513d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22165507162871345d, y: 0.7659141936299666d), new NpgsqlTypes.NpgsqlPoint(x: 0.7586774839771143d, y: 0.08506962754648784d), new NpgsqlTypes.NpgsqlPoint(x: 0.6866443347336424d, y: 0.1161348957143955d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5610209805228714d, y: 0.8235546679997617d), new NpgsqlTypes.NpgsqlPoint(x: 0.8362525255698016d, y: 0.9800085921738222d), new NpgsqlTypes.NpgsqlPoint(x: 0.2529533224046364d, y: 0.9823484153401236d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.944090985157447d, y: 0.8242352686417674d), new NpgsqlTypes.NpgsqlPoint(x: 0.12796483218610855d, y: 0.022557950450600495d), new NpgsqlTypes.NpgsqlPoint(x: 0.7651728511319548d, y: 0.7130627028506614d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9856395636675314d, y: 0.9797445480858856d), new NpgsqlTypes.NpgsqlPoint(x: 0.5026818996658045d, y: 0.9343117262848922d), new NpgsqlTypes.NpgsqlPoint(x: 0.5029537625900941d, y: 0.4275533199392122d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.560883277760194d, y: 0.5652616215007414d), new NpgsqlTypes.NpgsqlPoint(x: 0.03980947984911276d, y: 0.0015947028030978139d), new NpgsqlTypes.NpgsqlPoint(x: 0.9320106057352954d, y: 0.7296218507751061d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.026601887302222127d, y: 0.9799332147025595d), new NpgsqlTypes.NpgsqlPoint(x: 0.13598380453745795d, y: 0.9308203165277908d), new NpgsqlTypes.NpgsqlPoint(x: 0.2017740649759241d, y: 0.7868338851810506d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12121937973205499d, y: 0.30303834311450184d), new NpgsqlTypes.NpgsqlPoint(x: 0.6311139222436415d, y: 0.6002015238949147d), new NpgsqlTypes.NpgsqlPoint(x: 0.4481705860257791d, y: 0.26925752356036403d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10978373522240747d, y: 0.5069459605475556d), new NpgsqlTypes.NpgsqlPoint(x: 0.35537661999086145d, y: 0.44892228231118225d), new NpgsqlTypes.NpgsqlPoint(x: 0.5779689824356918d, y: 0.39963662500574926d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23620703506325968d, y: 0.7504510211052119d), new NpgsqlTypes.NpgsqlPoint(x: 0.5832114494053707d, y: 0.001793838684219562d), new NpgsqlTypes.NpgsqlPoint(x: 0.8617551211868699d, y: 0.5400239986637252d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005811023890381017d, y: 0.7648569994873541d), new NpgsqlTypes.NpgsqlPoint(x: 0.7312724154210882d, y: 0.07170882743704288d), new NpgsqlTypes.NpgsqlPoint(x: 0.14204801604815243d, y: 0.26804470094391875d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6715070271805607d, y: 0.733066493922692d), new NpgsqlTypes.NpgsqlPoint(x: 0.944845649850707d, y: 0.6470075250969073d), new NpgsqlTypes.NpgsqlPoint(x: 0.5607271423027478d, y: 0.3695222283798665d)), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8067278684358002d, y: 0.3559228978722674d), new NpgsqlTypes.NpgsqlPoint(x: 0.8445406829135684d, y: 0.4235211653586106d), new NpgsqlTypes.NpgsqlPoint(x: 0.24535709195318278d, y: 0.7165240783568432d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7454338471135872d, y: 0.8002277238603697d), new NpgsqlTypes.NpgsqlPoint(x: 0.08469277634193428d, y: 0.26753405175790446d), new NpgsqlTypes.NpgsqlPoint(x: 0.06291821030509404d, y: 0.62481106384091d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34011000857290596d, y: 0.43171905969478597d), new NpgsqlTypes.NpgsqlPoint(x: 0.3050772529633684d, y: 0.1388637706584147d), new NpgsqlTypes.NpgsqlPoint(x: 0.5508236562757705d, y: 0.6404175225231838d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9611647401730188d, y: 0.9131860930120892d), new NpgsqlTypes.NpgsqlPoint(x: 0.8042518006748753d, y: 0.9518511034739565d), new NpgsqlTypes.NpgsqlPoint(x: 0.7818420364738732d, y: 0.5960860268894347d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18223024580890634d, y: 0.33833308263027495d), new NpgsqlTypes.NpgsqlPoint(x: 0.7686702144434765d, y: 0.5569411693639746d), new NpgsqlTypes.NpgsqlPoint(x: 0.05439651153628666d, y: 0.06719610936119735d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4530668994900172d, y: 0.1678508263934193d), new NpgsqlTypes.NpgsqlPoint(x: 0.5230769820345161d, y: 0.8036412561659123d), new NpgsqlTypes.NpgsqlPoint(x: 0.4455448212216029d, y: 0.6947878971048639d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5123883474710507d, y: 0.31135085486752323d), new NpgsqlTypes.NpgsqlPoint(x: 0.7291855053518272d, y: 0.3652719013426463d), new NpgsqlTypes.NpgsqlPoint(x: 0.7341341304487181d, y: 0.9856001413945108d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6793480590760465d, y: 0.06813508447780647d), new NpgsqlTypes.NpgsqlPoint(x: 0.5637662555622756d, y: 0.4448076644669007d), new NpgsqlTypes.NpgsqlPoint(x: 0.526257858169329d, y: 0.2989311306070477d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2425466160609565d, y: 0.008695484379493412d), new NpgsqlTypes.NpgsqlPoint(x: 0.07866162674959398d, y: 0.8593632153733409d), new NpgsqlTypes.NpgsqlPoint(x: 0.2639685082698723d, y: 0.3636790542218039d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6030074441473137d, y: 0.626651159580392d), new NpgsqlTypes.NpgsqlPoint(x: 0.9695611804807502d, y: 0.3137092134209305d), new NpgsqlTypes.NpgsqlPoint(x: 0.05206509800133097d, y: 0.13029756156510663d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5331761162557895d, y: 0.6564155609580083d), new NpgsqlTypes.NpgsqlPoint(x: 0.12037849922110766d, y: 0.47487766245486884d), new NpgsqlTypes.NpgsqlPoint(x: 0.3651224569721817d, y: 0.7400460814802121d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2344892513694541d, y: 0.4450070914449049d), new NpgsqlTypes.NpgsqlPoint(x: 0.7015901142191121d, y: 0.5116994309161731d), new NpgsqlTypes.NpgsqlPoint(x: 0.8286082859873279d, y: 0.6748818679546177d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24749574661451212d, y: 0.8836993712982558d), new NpgsqlTypes.NpgsqlPoint(x: 0.2525851927043531d, y: 0.625530086127037d), new NpgsqlTypes.NpgsqlPoint(x: 0.3510520608701361d, y: 0.3017272293716865d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9164051675761824d, y: 0.6662784595758507d), new NpgsqlTypes.NpgsqlPoint(x: 0.7551632292608287d, y: 0.8608424462676582d), new NpgsqlTypes.NpgsqlPoint(x: 0.9343306641880841d, y: 0.40908503766920623d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15159951998924237d, y: 0.27088016737685616d), new NpgsqlTypes.NpgsqlPoint(x: 0.9167792646775339d, y: 0.7441470262222979d), new NpgsqlTypes.NpgsqlPoint(x: 0.350629552927857d, y: 0.7235911399992081d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3990443421157135d, y: 0.044174685926576474d), new NpgsqlTypes.NpgsqlPoint(x: 0.5249780777927445d, y: 0.7244506392181984d), new NpgsqlTypes.NpgsqlPoint(x: 0.5789589417419359d, y: 0.4473767142060616d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07696503149157496d, y: 0.6895724683315495d), new NpgsqlTypes.NpgsqlPoint(x: 0.746897009589789d, y: 0.19098774044658806d), new NpgsqlTypes.NpgsqlPoint(x: 0.8447711619894669d, y: 0.03354530886841933d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5155402254754845d, y: 0.05696923555786182d), new NpgsqlTypes.NpgsqlPoint(x: 0.992407793307323d, y: 0.8477916561743458d), new NpgsqlTypes.NpgsqlPoint(x: 0.3043862576765528d, y: 0.9806910131910186d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9374146559503075d, y: 0.661600564104479d), new NpgsqlTypes.NpgsqlPoint(x: 0.7218892371571848d, y: 0.5063853739186023d), new NpgsqlTypes.NpgsqlPoint(x: 0.6862961643806683d, y: 0.5990747687724295d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20077875964713265d, y: 0.5279404257883833d), new NpgsqlTypes.NpgsqlPoint(x: 0.8805700295090662d, y: 0.21696987378793087d), new NpgsqlTypes.NpgsqlPoint(x: 0.5199580342447203d, y: 0.8000800921086688d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3362515164709372d, y: 0.11319286780641968d), new NpgsqlTypes.NpgsqlPoint(x: 0.7496087554001574d, y: 0.09369493904325255d), new NpgsqlTypes.NpgsqlPoint(x: 0.9260604916345259d, y: 0.10945278450780749d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40962904733044825d, y: 0.6433250943793627d), new NpgsqlTypes.NpgsqlPoint(x: 0.9597977648637721d, y: 0.458706506736386d), new NpgsqlTypes.NpgsqlPoint(x: 0.46613327060920773d, y: 0.1494552856124708d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4659678160868197d, y: 0.3290689892671814d), new NpgsqlTypes.NpgsqlPoint(x: 0.058812249286284146d, y: 0.32175800205867366d), new NpgsqlTypes.NpgsqlPoint(x: 0.6974142581844276d, y: 0.02547174686522824d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004632361116082673d, y: 0.7795146266687276d), new NpgsqlTypes.NpgsqlPoint(x: 0.9343635861400559d, y: 0.5769560163906766d), new NpgsqlTypes.NpgsqlPoint(x: 0.519415861772074d, y: 0.9019010310307493d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08388378611461977d, y: 0.8469496610831585d), new NpgsqlTypes.NpgsqlPoint(x: 0.579769264227973d, y: 0.2688126831080917d), new NpgsqlTypes.NpgsqlPoint(x: 0.024986884865158432d, y: 0.6792663357905765d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8907293596561006d, y: 0.2488044113096225d), new NpgsqlTypes.NpgsqlPoint(x: 0.20453498748350363d, y: 0.4799797915616745d), new NpgsqlTypes.NpgsqlPoint(x: 0.4663666838335955d, y: 0.8197462803743868d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6903744121065479d, y: 0.6024371395304432d), new NpgsqlTypes.NpgsqlPoint(x: 0.38014410415612454d, y: 0.5404021632398139d), new NpgsqlTypes.NpgsqlPoint(x: 0.1906944481580657d, y: 0.012556597395005475d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.956761544917504d, y: 0.08819494974171704d), new NpgsqlTypes.NpgsqlPoint(x: 0.9149401959615552d, y: 0.3556453585292464d), new NpgsqlTypes.NpgsqlPoint(x: 0.3119361611404008d, y: 0.5733726026637006d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5968535463123885d, y: 0.9298783025611055d), new NpgsqlTypes.NpgsqlPoint(x: 0.3042000381912565d, y: 0.8218711441751054d), new NpgsqlTypes.NpgsqlPoint(x: 0.6307380156382184d, y: 0.9086889819157028d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8727230910124852d, y: 0.07525656457910357d), new NpgsqlTypes.NpgsqlPoint(x: 0.3013951348385979d, y: 0.5698882731740942d), new NpgsqlTypes.NpgsqlPoint(x: 0.48798807911332376d, y: 0.7543986111336666d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.488749440006758d, y: 0.9972045129170285d), new NpgsqlTypes.NpgsqlPoint(x: 0.9137109534043322d, y: 0.496906615618114d), new NpgsqlTypes.NpgsqlPoint(x: 0.0886018196838394d, y: 0.30826741710466365d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18580544521797948d, y: 0.43455598347217106d), new NpgsqlTypes.NpgsqlPoint(x: 0.828845506622159d, y: 0.20609298036137402d), new NpgsqlTypes.NpgsqlPoint(x: 0.056758670841707715d, y: 0.29796331021673905d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3923783023494969d, y: 0.19172037210569626d), new NpgsqlTypes.NpgsqlPoint(x: 0.8393786955057166d, y: 0.004726974334768541d), new NpgsqlTypes.NpgsqlPoint(x: 0.8091390297210412d, y: 0.14946952891347576d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10397696087801733d, y: 0.2620170462593604d), new NpgsqlTypes.NpgsqlPoint(x: 0.06509243104535023d, y: 0.5302914657707212d), new NpgsqlTypes.NpgsqlPoint(x: 0.662618264030394d, y: 0.8074281476636791d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8560313730513784d, y: 0.038601284714059214d), new NpgsqlTypes.NpgsqlPoint(x: 0.8491297470075546d, y: 0.20384659424912244d), new NpgsqlTypes.NpgsqlPoint(x: 0.9377419509388474d, y: 0.5463667393738565d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2440042436037515d, y: 0.9513780549961038d), new NpgsqlTypes.NpgsqlPoint(x: 0.18329485827533754d, y: 0.6295261413001552d), new NpgsqlTypes.NpgsqlPoint(x: 0.8212432832615834d, y: 0.1674145605449633d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9414455038937646d, y: 0.47154824525566374d), new NpgsqlTypes.NpgsqlPoint(x: 0.11148734796859916d, y: 0.875925362089397d), new NpgsqlTypes.NpgsqlPoint(x: 0.2820494571248283d, y: 0.598938392166523d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47382712144704d, y: 0.8703056532588974d), new NpgsqlTypes.NpgsqlPoint(x: 0.32085551670906576d, y: 0.7299244081963461d), new NpgsqlTypes.NpgsqlPoint(x: 0.2277401069063033d, y: 0.4738309219132749d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2713036717761359d, y: 0.7249875497931161d), new NpgsqlTypes.NpgsqlPoint(x: 0.835643074036816d, y: 0.863115535951523d), new NpgsqlTypes.NpgsqlPoint(x: 0.7134798672699276d, y: 0.10454735985731367d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40882373092735813d, y: 0.2808968458229617d), new NpgsqlTypes.NpgsqlPoint(x: 0.6427388278346461d, y: 0.17405304437128544d), new NpgsqlTypes.NpgsqlPoint(x: 0.4756342392169628d, y: 0.45177385802896775d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.087298583087973d, y: 0.7645709929628249d), new NpgsqlTypes.NpgsqlPoint(x: 0.3409613558480097d, y: 0.8759147880236856d), new NpgsqlTypes.NpgsqlPoint(x: 0.5054130863329399d, y: 0.6239894952841417d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8981143294620303d, y: 0.7134163842338641d), new NpgsqlTypes.NpgsqlPoint(x: 0.5965966972401947d, y: 0.4162776396675748d), new NpgsqlTypes.NpgsqlPoint(x: 0.5596089181319954d, y: 0.5026842723104652d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.504775658734164d, y: 0.5107360694185986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5345472258814205d, y: 0.40916176896260215d), new NpgsqlTypes.NpgsqlPoint(x: 0.04660779117397218d, y: 0.23079726184368976d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5293817423119266d, y: 0.5707164086457662d), new NpgsqlTypes.NpgsqlPoint(x: 0.4814590385480303d, y: 0.5588081793920561d), new NpgsqlTypes.NpgsqlPoint(x: 0.8142091641268953d, y: 0.10904593994400069d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3478960232396585d, y: 0.49329042432474746d), new NpgsqlTypes.NpgsqlPoint(x: 0.622081734366701d, y: 0.62564341707517d), new NpgsqlTypes.NpgsqlPoint(x: 0.6181990726843454d, y: 0.5138432811098549d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7961947097860902d, y: 0.8666306850950846d), new NpgsqlTypes.NpgsqlPoint(x: 0.14089365161037248d, y: 0.8341298879558582d), new NpgsqlTypes.NpgsqlPoint(x: 0.15800671211759654d, y: 0.5128610874380115d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2526344517688658d, y: 0.5089665495925996d), new NpgsqlTypes.NpgsqlPoint(x: 0.8350978277368012d, y: 0.9405655278831702d), new NpgsqlTypes.NpgsqlPoint(x: 0.4042606443481991d, y: 0.40286453982435244d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15261918596559465d, y: 0.009991326756012109d), new NpgsqlTypes.NpgsqlPoint(x: 0.11733034378792717d, y: 0.23945451245229876d), new NpgsqlTypes.NpgsqlPoint(x: 0.9346221751039723d, y: 0.31348608565058644d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9922887317290424d, y: 0.1289700776180316d), new NpgsqlTypes.NpgsqlPoint(x: 0.12334486762950359d, y: 0.309229511409404d), new NpgsqlTypes.NpgsqlPoint(x: 0.3069276043311675d, y: 0.06176261501799374d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34027254230604d, y: 0.05306590042279524d), new NpgsqlTypes.NpgsqlPoint(x: 0.5421508028363862d, y: 0.525425596578603d), new NpgsqlTypes.NpgsqlPoint(x: 0.49394772595852166d, y: 0.43650186995937634d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.711071320835047d, y: 0.775179564793146d), new NpgsqlTypes.NpgsqlPoint(x: 0.4364425147914158d, y: 0.8416526380521895d), new NpgsqlTypes.NpgsqlPoint(x: 0.5863216103590152d, y: 0.16989883011603402d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6562098093121288d, y: 0.21482618100579298d), new NpgsqlTypes.NpgsqlPoint(x: 0.26651445223208603d, y: 0.1839999857295952d), new NpgsqlTypes.NpgsqlPoint(x: 0.8770323373296127d, y: 0.6252800864901402d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20593395866021114d, y: 0.845533703284979d), new NpgsqlTypes.NpgsqlPoint(x: 0.2859271222108073d, y: 0.9050096925354423d), new NpgsqlTypes.NpgsqlPoint(x: 0.5366113487336628d, y: 0.664033567733339d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9869568373880155d, y: 0.7709987625369049d), new NpgsqlTypes.NpgsqlPoint(x: 0.6948423443412282d, y: 0.23968011171369374d), new NpgsqlTypes.NpgsqlPoint(x: 0.4020529425414494d, y: 0.24276570510949091d)), }, }, },
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3385408271677396d, y: 0.41328997488835384d), new NpgsqlTypes.NpgsqlPoint(x: 0.4066270562762433d, y: 0.5967813295019846d), new NpgsqlTypes.NpgsqlPoint(x: 0.09545586434303877d, y: 0.2504622713726322d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7797808625414022d, y: 0.854460964034902d), new NpgsqlTypes.NpgsqlPoint(x: 0.16983667151790116d, y: 0.026480320276061398d), new NpgsqlTypes.NpgsqlPoint(x: 0.014551276097522159d, y: 0.8628689543287603d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6866728511186573d, y: 0.5016622505827633d), new NpgsqlTypes.NpgsqlPoint(x: 0.7717688462758429d, y: 0.38137619256222377d), new NpgsqlTypes.NpgsqlPoint(x: 0.5390387995539332d, y: 0.04399127164408245d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6575106570391307d, y: 0.7548699447936202d), new NpgsqlTypes.NpgsqlPoint(x: 0.3769521521612593d, y: 0.11245082434965448d), new NpgsqlTypes.NpgsqlPoint(x: 0.11837592005569497d, y: 0.5962197512626897d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4959781201166876d, y: 0.2942796772426808d), new NpgsqlTypes.NpgsqlPoint(x: 0.7301379942959771d, y: 0.18035854299774823d), new NpgsqlTypes.NpgsqlPoint(x: 0.3389159743872163d, y: 0.4139276255795169d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3201735831577013d, y: 0.012256940401195626d), new NpgsqlTypes.NpgsqlPoint(x: 0.5748052199814955d, y: 0.8451873382362667d), new NpgsqlTypes.NpgsqlPoint(x: 0.7421259990479699d, y: 0.12446843194340551d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4385003037105919d, y: 0.22988063863128005d), new NpgsqlTypes.NpgsqlPoint(x: 0.44632571572059665d, y: 0.7500352691642429d), new NpgsqlTypes.NpgsqlPoint(x: 0.4862757694415486d, y: 0.9157321108997414d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06075631109835067d, y: 0.5742853181868357d), new NpgsqlTypes.NpgsqlPoint(x: 0.2765879110482128d, y: 0.4620823056698765d), new NpgsqlTypes.NpgsqlPoint(x: 0.18462237436681994d, y: 0.6561749338561921d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.234571466068612d, y: 0.48117458071169206d), new NpgsqlTypes.NpgsqlPoint(x: 0.6328423754827184d, y: 0.009240337533183207d), new NpgsqlTypes.NpgsqlPoint(x: 0.05683759563834312d, y: 0.013813944788887311d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6584815540559548d, y: 0.9100916247641448d), new NpgsqlTypes.NpgsqlPoint(x: 0.018587921634308446d, y: 0.2258243252387736d), new NpgsqlTypes.NpgsqlPoint(x: 0.6393091215623787d, y: 0.48258787642076073d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5897878779192383d, y: 0.7743824085589519d), new NpgsqlTypes.NpgsqlPoint(x: 0.8512334892303755d, y: 0.11145230858271082d), new NpgsqlTypes.NpgsqlPoint(x: 0.9325847878483893d, y: 0.23062783612615d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9365465925109144d, y: 0.19315964667138974d), new NpgsqlTypes.NpgsqlPoint(x: 0.27757566258393274d, y: 0.19749527636498998d), new NpgsqlTypes.NpgsqlPoint(x: 0.3679349888410589d, y: 0.6360606153124999d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.644760844125899d, y: 0.11841380538090207d), new NpgsqlTypes.NpgsqlPoint(x: 0.682018284395902d, y: 0.6977156997084176d), new NpgsqlTypes.NpgsqlPoint(x: 0.122218802913723d, y: 0.32225548505429535d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34543453007714975d, y: 0.11490939021008872d), new NpgsqlTypes.NpgsqlPoint(x: 0.48523639431145793d, y: 0.17494121773843496d), new NpgsqlTypes.NpgsqlPoint(x: 0.7077683007421962d, y: 0.32714811460705884d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6246455174677952d, y: 0.5021540217540675d), new NpgsqlTypes.NpgsqlPoint(x: 0.18484899054660608d, y: 0.5468423762424157d), new NpgsqlTypes.NpgsqlPoint(x: 0.5061377445564441d, y: 0.8329373404162208d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.299182253879842d, y: 0.4592936617169493d), new NpgsqlTypes.NpgsqlPoint(x: 0.4904323020162974d, y: 0.8703165583851353d), new NpgsqlTypes.NpgsqlPoint(x: 0.9578527299773072d, y: 0.15021537929409545d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04986815382281795d, y: 0.8226713955713193d), new NpgsqlTypes.NpgsqlPoint(x: 0.5207388619910603d, y: 0.22746741851128738d), new NpgsqlTypes.NpgsqlPoint(x: 0.5165665885905784d, y: 0.6024411973484433d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9002241632187973d, y: 0.6289328239429816d), new NpgsqlTypes.NpgsqlPoint(x: 0.19369044094199894d, y: 0.6844563738168182d), new NpgsqlTypes.NpgsqlPoint(x: 0.8634330055917698d, y: 0.048365466472709895d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015370993654417742d, y: 0.2547579572894433d), new NpgsqlTypes.NpgsqlPoint(x: 0.6520969233386429d, y: 0.20070850105590543d), new NpgsqlTypes.NpgsqlPoint(x: 0.9710128060982226d, y: 0.8443034567980395d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42133828438260157d, y: 0.9759533453685296d), new NpgsqlTypes.NpgsqlPoint(x: 0.46112460641363107d, y: 0.4110256452781138d), new NpgsqlTypes.NpgsqlPoint(x: 0.11390085992090782d, y: 0.30803587906901764d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14288053090156227d, y: 0.852004398295612d), new NpgsqlTypes.NpgsqlPoint(x: 0.18668565268534387d, y: 0.23462189753057205d), new NpgsqlTypes.NpgsqlPoint(x: 0.7289903070775122d, y: 0.17981656211235886d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0809215593362973d, y: 0.2551809923003545d), new NpgsqlTypes.NpgsqlPoint(x: 0.0006944281966327903d, y: 0.7791044470128269d), new NpgsqlTypes.NpgsqlPoint(x: 0.9645902947985938d, y: 0.16153726509084554d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24953555572798292d, y: 0.28493402713827454d), new NpgsqlTypes.NpgsqlPoint(x: 0.6770085710023116d, y: 0.6590089678614411d), new NpgsqlTypes.NpgsqlPoint(x: 0.270938364802056d, y: 0.09957411853376508d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3742273686793516d, y: 0.740654046037746d), new NpgsqlTypes.NpgsqlPoint(x: 0.04752521431826151d, y: 0.2438777763699831d), new NpgsqlTypes.NpgsqlPoint(x: 0.17455199371073427d, y: 0.006272295518251703d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27910642127022567d, y: 0.40736401663683774d), new NpgsqlTypes.NpgsqlPoint(x: 0.13864506798616216d, y: 0.4756958979718693d), new NpgsqlTypes.NpgsqlPoint(x: 0.740876607074563d, y: 0.25767846184433685d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.034784138719757385d, y: 0.19771759274323797d), new NpgsqlTypes.NpgsqlPoint(x: 0.6618059235016133d, y: 0.6176682151068998d), new NpgsqlTypes.NpgsqlPoint(x: 0.14644312575393226d, y: 0.3870649710974794d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31788645833157514d, y: 0.6441338280354283d), new NpgsqlTypes.NpgsqlPoint(x: 0.9157260084077353d, y: 0.45911716371237465d), new NpgsqlTypes.NpgsqlPoint(x: 0.745506825179706d, y: 0.21055863085989712d)), }, }, },
    ModelInner = new NpgsqlPathpathMMArrayD3E1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.035416952119318945d, y: 0.1864361360304454d), new NpgsqlTypes.NpgsqlPoint(x: 0.6845291040479015d, y: 0.7914288968525022d), new NpgsqlTypes.NpgsqlPoint(x: 0.8093132077075381d, y: 0.15363941281970173d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9995592321238348d, y: 0.3730412049588123d), new NpgsqlTypes.NpgsqlPoint(x: 0.562376483565744d, y: 0.9166912934210038d), new NpgsqlTypes.NpgsqlPoint(x: 0.7890930904425189d, y: 0.7616117193473313d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8409102968902685d, y: 0.12235522440319668d), new NpgsqlTypes.NpgsqlPoint(x: 0.2117142061918007d, y: 0.5518547294848245d), new NpgsqlTypes.NpgsqlPoint(x: 0.4538989362144885d, y: 0.2097058087355841d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15146641198722888d, y: 0.872688051356555d), new NpgsqlTypes.NpgsqlPoint(x: 0.1749126681548674d, y: 0.5101459340700794d), new NpgsqlTypes.NpgsqlPoint(x: 0.4544182121580159d, y: 0.9180942122341181d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6152673018454147d, y: 0.37745775682464644d), new NpgsqlTypes.NpgsqlPoint(x: 0.6315330571697605d, y: 0.6756328742108388d), new NpgsqlTypes.NpgsqlPoint(x: 0.8430156925505966d, y: 0.1694066104320502d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08135108879885755d, y: 0.23550624753304406d), new NpgsqlTypes.NpgsqlPoint(x: 0.38213009732313474d, y: 0.3851092921159216d), new NpgsqlTypes.NpgsqlPoint(x: 0.6519768273064245d, y: 0.3522630747232761d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.380113766993193d, y: 0.5266859582435373d), new NpgsqlTypes.NpgsqlPoint(x: 0.08336797159660847d, y: 0.9522716073282664d), new NpgsqlTypes.NpgsqlPoint(x: 0.6889051271651018d, y: 0.4730132377297671d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6015596605174237d, y: 0.42662062678852886d), new NpgsqlTypes.NpgsqlPoint(x: 0.21961354948182998d, y: 0.6364988727104902d), new NpgsqlTypes.NpgsqlPoint(x: 0.7784604684801177d, y: 0.4640274662883931d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1310243430646698d, y: 0.03823531995660856d), new NpgsqlTypes.NpgsqlPoint(x: 0.734456943459718d, y: 0.7587288926104951d), new NpgsqlTypes.NpgsqlPoint(x: 0.7909165744649844d, y: 0.40819126842789666d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34114210869046047d, y: 0.17999438792886313d), new NpgsqlTypes.NpgsqlPoint(x: 0.5893555188158949d, y: 0.04916445754875609d), new NpgsqlTypes.NpgsqlPoint(x: 0.7443840857426447d, y: 0.9688258611861771d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7811636021678834d, y: 0.3748231269420186d), new NpgsqlTypes.NpgsqlPoint(x: 0.8085285754838405d, y: 0.6673674142881607d), new NpgsqlTypes.NpgsqlPoint(x: 0.19902628005100798d, y: 0.21882303170532535d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23836183444779357d, y: 0.8272231175784959d), new NpgsqlTypes.NpgsqlPoint(x: 0.9896957971685867d, y: 0.5062490888267623d), new NpgsqlTypes.NpgsqlPoint(x: 0.7394426603647334d, y: 0.3672100014419102d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9336184612118632d, y: 0.8726912063359151d), new NpgsqlTypes.NpgsqlPoint(x: 0.9367076434791158d, y: 0.7732669618910328d), new NpgsqlTypes.NpgsqlPoint(x: 0.39532508071603323d, y: 0.728717266093544d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8512769049225234d, y: 0.05089826399785791d), new NpgsqlTypes.NpgsqlPoint(x: 0.7934007531901628d, y: 0.3179863491265501d), new NpgsqlTypes.NpgsqlPoint(x: 0.6501203771007843d, y: 0.14426117713659048d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5428726411105372d, y: 0.7061758518290121d), new NpgsqlTypes.NpgsqlPoint(x: 0.9964692291607106d, y: 0.8270693242686497d), new NpgsqlTypes.NpgsqlPoint(x: 0.8048858987737997d, y: 0.463821430895487d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42297602371237875d, y: 0.20851441054024067d), new NpgsqlTypes.NpgsqlPoint(x: 0.27246920140630504d, y: 0.928450704210815d), new NpgsqlTypes.NpgsqlPoint(x: 0.026173081872367998d, y: 0.700832048694135d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5429713543557515d, y: 0.9521786920590779d), new NpgsqlTypes.NpgsqlPoint(x: 0.813896471615423d, y: 0.7736393025544519d), new NpgsqlTypes.NpgsqlPoint(x: 0.5213113022684146d, y: 0.781245310441929d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5940624069300866d, y: 0.5133836956934144d), new NpgsqlTypes.NpgsqlPoint(x: 0.20800440803261477d, y: 0.022099074688917364d), new NpgsqlTypes.NpgsqlPoint(x: 0.5678421379229359d, y: 0.22547406082599963d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45905284466970264d, y: 0.9505037403295283d), new NpgsqlTypes.NpgsqlPoint(x: 0.17188089630754666d, y: 0.03664077786516351d), new NpgsqlTypes.NpgsqlPoint(x: 0.5931547199757102d, y: 0.6311094280906515d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015505355744276472d, y: 0.7976538114239535d), new NpgsqlTypes.NpgsqlPoint(x: 0.14767349911262495d, y: 0.7354292669147603d), new NpgsqlTypes.NpgsqlPoint(x: 0.3029489274054967d, y: 0.3490165580440918d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3309089900678587d, y: 0.37769749275526054d), new NpgsqlTypes.NpgsqlPoint(x: 0.029416856292213134d, y: 0.2584378979836949d), new NpgsqlTypes.NpgsqlPoint(x: 0.1176648362796533d, y: 0.0785744936018149d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36829094870979495d, y: 0.29348921236756875d), new NpgsqlTypes.NpgsqlPoint(x: 0.7417248534218819d, y: 0.3968305554921563d), new NpgsqlTypes.NpgsqlPoint(x: 0.8092977674758135d, y: 0.10715618737741706d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3353792064732819d, y: 0.99310964149572d), new NpgsqlTypes.NpgsqlPoint(x: 0.903681343368136d, y: 0.7809854573925034d), new NpgsqlTypes.NpgsqlPoint(x: 0.24557649602814757d, y: 0.5615414852444751d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.045154190161701746d, y: 0.07632431374372162d), new NpgsqlTypes.NpgsqlPoint(x: 0.7446053693666519d, y: 0.43788818732491275d), new NpgsqlTypes.NpgsqlPoint(x: 0.7773845003653823d, y: 0.3250697547376179d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6813304417684519d, y: 0.09021261093465427d), new NpgsqlTypes.NpgsqlPoint(x: 0.9131170738733834d, y: 0.8004131388805967d), new NpgsqlTypes.NpgsqlPoint(x: 0.3371513714355352d, y: 0.8482868883303094d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19091003889066938d, y: 0.6101797064708923d), new NpgsqlTypes.NpgsqlPoint(x: 0.20793079869030695d, y: 0.17291070357505212d), new NpgsqlTypes.NpgsqlPoint(x: 0.02971355686580668d, y: 0.5936042642192652d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6883409060191535d, y: 0.2736459188790603d), new NpgsqlTypes.NpgsqlPoint(x: 0.11585815716721237d, y: 0.9863783098439959d), new NpgsqlTypes.NpgsqlPoint(x: 0.970669948652491d, y: 0.6613115005815751d)), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8595439046338255d, y: 0.1725230136228948d), new NpgsqlTypes.NpgsqlPoint(x: 0.268253518883364d, y: 0.7249705479366126d), new NpgsqlTypes.NpgsqlPoint(x: 0.9425790046454942d, y: 0.43348651656357784d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8142782227627352d, y: 0.4350332930050935d), new NpgsqlTypes.NpgsqlPoint(x: 0.11606156438827886d, y: 0.1401846418387619d), new NpgsqlTypes.NpgsqlPoint(x: 0.904276131876247d, y: 0.12450563022637351d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.489698714437686d, y: 0.8225167507108063d), new NpgsqlTypes.NpgsqlPoint(x: 0.3584602668915875d, y: 0.37216755968507076d), new NpgsqlTypes.NpgsqlPoint(x: 0.7425303028723499d, y: 0.7407520141510322d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9335378564533943d, y: 0.38910379948273244d), new NpgsqlTypes.NpgsqlPoint(x: 0.9574295059042212d, y: 0.830239055291662d), new NpgsqlTypes.NpgsqlPoint(x: 0.6472580485904934d, y: 0.6469947536562576d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11251393761737494d, y: 0.3119109189495902d), new NpgsqlTypes.NpgsqlPoint(x: 0.8358591928979877d, y: 0.4990737339445481d), new NpgsqlTypes.NpgsqlPoint(x: 0.7063429363568109d, y: 0.47729539553577327d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.681348646818885d, y: 0.3898965283721062d), new NpgsqlTypes.NpgsqlPoint(x: 0.6869217286598889d, y: 0.2080197225198711d), new NpgsqlTypes.NpgsqlPoint(x: 0.8039388933661876d, y: 0.7201929098199987d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8749547456183271d, y: 0.3110630978887976d), new NpgsqlTypes.NpgsqlPoint(x: 0.7108381870374417d, y: 0.8804765788943084d), new NpgsqlTypes.NpgsqlPoint(x: 0.7428390286201033d, y: 0.8955431551234609d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8381545940944182d, y: 0.9815623960633209d), new NpgsqlTypes.NpgsqlPoint(x: 0.905950935651574d, y: 0.35987327756241605d), new NpgsqlTypes.NpgsqlPoint(x: 0.5381901053986681d, y: 0.8174967405316319d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8935746163327593d, y: 0.06995786649784685d), new NpgsqlTypes.NpgsqlPoint(x: 0.20062740722004524d, y: 0.3431327221053496d), new NpgsqlTypes.NpgsqlPoint(x: 0.16499895653554686d, y: 0.4083054040710127d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8341020202285898d, y: 0.7915003282135374d), new NpgsqlTypes.NpgsqlPoint(x: 0.9536637820311622d, y: 0.25787983788281144d), new NpgsqlTypes.NpgsqlPoint(x: 0.2772499971341912d, y: 0.8873013353479681d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4203124815928848d, y: 0.8784826383065476d), new NpgsqlTypes.NpgsqlPoint(x: 0.256769261046361d, y: 0.19995812225173626d), new NpgsqlTypes.NpgsqlPoint(x: 0.047417248930582745d, y: 0.41583537295225137d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5717378627147007d, y: 0.9157731914979809d), new NpgsqlTypes.NpgsqlPoint(x: 0.5836621507122441d, y: 0.7526443166779413d), new NpgsqlTypes.NpgsqlPoint(x: 0.4868890461176084d, y: 0.43708996054457516d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49582766041545945d, y: 0.8401781712445023d), new NpgsqlTypes.NpgsqlPoint(x: 0.7073145170427962d, y: 0.9613821933149086d), new NpgsqlTypes.NpgsqlPoint(x: 0.2966026917315715d, y: 0.1299998777844702d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7045220951951525d, y: 0.48620677237613663d), new NpgsqlTypes.NpgsqlPoint(x: 0.1030381743467389d, y: 0.1543870474906487d), new NpgsqlTypes.NpgsqlPoint(x: 0.9139106594899267d, y: 0.3389705290195911d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7141603239947285d, y: 0.8568688904659544d), new NpgsqlTypes.NpgsqlPoint(x: 0.9316185974367042d, y: 0.1869333117754146d), new NpgsqlTypes.NpgsqlPoint(x: 0.19522611109327026d, y: 0.7304042657948148d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5004473246184192d, y: 0.9028772274155109d), new NpgsqlTypes.NpgsqlPoint(x: 0.7701246428679396d, y: 0.5340256324611361d), new NpgsqlTypes.NpgsqlPoint(x: 0.5345668459136224d, y: 0.24311019410814794d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8087925135646545d, y: 0.701377763847423d), new NpgsqlTypes.NpgsqlPoint(x: 0.5877091331211015d, y: 0.0825579039212978d), new NpgsqlTypes.NpgsqlPoint(x: 0.3029793692285625d, y: 0.5332696315307167d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4791323717582403d, y: 0.45492811865154614d), new NpgsqlTypes.NpgsqlPoint(x: 0.4679701515135041d, y: 0.7041635475114121d), new NpgsqlTypes.NpgsqlPoint(x: 0.4888337913914609d, y: 0.784366350025871d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.817945694339527d, y: 0.9983927499643522d), new NpgsqlTypes.NpgsqlPoint(x: 0.7296207924659733d, y: 0.8341702880007636d), new NpgsqlTypes.NpgsqlPoint(x: 0.4584248018579946d, y: 0.21312036063642648d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9753078902220598d, y: 0.5911916832964357d), new NpgsqlTypes.NpgsqlPoint(x: 0.5246327653815124d, y: 0.6510833594298442d), new NpgsqlTypes.NpgsqlPoint(x: 0.5578708472110665d, y: 0.065798645053734d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3151249020894643d, y: 0.8696338747855112d), new NpgsqlTypes.NpgsqlPoint(x: 0.2668628149584642d, y: 0.2249457727070785d), new NpgsqlTypes.NpgsqlPoint(x: 0.5376193552284003d, y: 0.07972501040724889d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23595849863954632d, y: 0.6692658577189956d), new NpgsqlTypes.NpgsqlPoint(x: 0.3515026071998715d, y: 0.45156783289656255d), new NpgsqlTypes.NpgsqlPoint(x: 0.12885976010359979d, y: 0.9139960430596535d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007752451310135022d, y: 0.014845271455953268d), new NpgsqlTypes.NpgsqlPoint(x: 0.9401122522493686d, y: 0.9320877491727189d), new NpgsqlTypes.NpgsqlPoint(x: 0.7852429569775657d, y: 0.957913036958621d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5018732268866386d, y: 0.8233874093506366d), new NpgsqlTypes.NpgsqlPoint(x: 0.9721353597229647d, y: 0.26749600168634047d), new NpgsqlTypes.NpgsqlPoint(x: 0.8354719437664895d, y: 0.8068137721149132d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48172006458284566d, y: 0.7396728824529347d), new NpgsqlTypes.NpgsqlPoint(x: 0.8273463124496483d, y: 0.5603126679788215d), new NpgsqlTypes.NpgsqlPoint(x: 0.39315436791416924d, y: 0.7972897973378567d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.010761106555600586d, y: 0.9638796973350975d), new NpgsqlTypes.NpgsqlPoint(x: 0.7361643329934002d, y: 0.6802092150314866d), new NpgsqlTypes.NpgsqlPoint(x: 0.07601032411201314d, y: 0.597119718545429d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48602291697995337d, y: 0.9381476899368459d), new NpgsqlTypes.NpgsqlPoint(x: 0.07965852097528658d, y: 0.309545870455757d), new NpgsqlTypes.NpgsqlPoint(x: 0.49065144998988297d, y: 0.007500681143174148d)), }, }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13816985838242524d, y: 0.14885617675811924d), new NpgsqlTypes.NpgsqlPoint(x: 0.03493725418989979d, y: 0.33563848335262947d), new NpgsqlTypes.NpgsqlPoint(x: 0.46056109484825203d, y: 0.3379704530789186d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4323615981111044d, y: 0.12981277602089247d), new NpgsqlTypes.NpgsqlPoint(x: 0.44482366439567156d, y: 0.9356633560984752d), new NpgsqlTypes.NpgsqlPoint(x: 0.28302547462980543d, y: 0.38197264991357016d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4582328628806851d, y: 0.5929587043595083d), new NpgsqlTypes.NpgsqlPoint(x: 0.3880342480357736d, y: 0.6587956744101504d), new NpgsqlTypes.NpgsqlPoint(x: 0.07199424206985916d, y: 0.4526739999763342d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5297573941117137d, y: 0.4826439622684162d), new NpgsqlTypes.NpgsqlPoint(x: 0.28102114952447366d, y: 0.6669755789822625d), new NpgsqlTypes.NpgsqlPoint(x: 0.17903010623784676d, y: 0.9535983197745845d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8334556297839546d, y: 0.26375463888980766d), new NpgsqlTypes.NpgsqlPoint(x: 0.4138561355182664d, y: 0.5181264902215432d), new NpgsqlTypes.NpgsqlPoint(x: 0.7480642583082167d, y: 0.8181779195237396d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5044467305622341d, y: 0.8081384852208613d), new NpgsqlTypes.NpgsqlPoint(x: 0.9147496082093718d, y: 0.7031307852942416d), new NpgsqlTypes.NpgsqlPoint(x: 0.3777240791485945d, y: 0.9900145759941533d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5420290794932685d, y: 0.8314472906935303d), new NpgsqlTypes.NpgsqlPoint(x: 0.38801400976826306d, y: 0.7588902990015399d), new NpgsqlTypes.NpgsqlPoint(x: 0.11652632382860573d, y: 0.19674099592096683d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4028050295300458d, y: 0.28887373470561417d), new NpgsqlTypes.NpgsqlPoint(x: 0.43548655113527324d, y: 0.01402818391811167d), new NpgsqlTypes.NpgsqlPoint(x: 0.7811195505263793d, y: 0.07605259301046752d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6134233296192368d, y: 0.27933184451398085d), new NpgsqlTypes.NpgsqlPoint(x: 0.6014794729866939d, y: 0.05119918954531344d), new NpgsqlTypes.NpgsqlPoint(x: 0.4121742568828032d, y: 0.05492085986405981d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4269567738460496d, y: 0.04068033658345438d), new NpgsqlTypes.NpgsqlPoint(x: 0.5469509004409375d, y: 0.8273150474486282d), new NpgsqlTypes.NpgsqlPoint(x: 0.6490198860636208d, y: 0.27382751939270955d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9403046361637366d, y: 0.15510256271219047d), new NpgsqlTypes.NpgsqlPoint(x: 0.6604631995969432d, y: 0.4938222558321128d), new NpgsqlTypes.NpgsqlPoint(x: 0.5202208343740969d, y: 0.038441349741939246d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9024464285045536d, y: 0.4621051226972104d), new NpgsqlTypes.NpgsqlPoint(x: 0.4956667648108055d, y: 0.9841065330814124d), new NpgsqlTypes.NpgsqlPoint(x: 0.825856341188651d, y: 0.8795990726018951d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47994938475883175d, y: 0.9558813192115015d), new NpgsqlTypes.NpgsqlPoint(x: 0.8103270042093299d, y: 0.25123129557048596d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810475051858105d, y: 0.31445294282904324d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34612555299089176d, y: 0.670349683317536d), new NpgsqlTypes.NpgsqlPoint(x: 0.7746978216510839d, y: 0.060113575979440004d), new NpgsqlTypes.NpgsqlPoint(x: 0.608840184988192d, y: 0.8754827842873039d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32518654408106096d, y: 0.9242315329813907d), new NpgsqlTypes.NpgsqlPoint(x: 0.84338492738722d, y: 0.6748188491967383d), new NpgsqlTypes.NpgsqlPoint(x: 0.021171056441484648d, y: 0.8994693746296123d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4600943682586587d, y: 0.6268316954598706d), new NpgsqlTypes.NpgsqlPoint(x: 0.4202733557698257d, y: 0.4549486846499945d), new NpgsqlTypes.NpgsqlPoint(x: 0.021951255117833135d, y: 0.7218146425157496d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03725991238207238d, y: 0.5933842024551965d), new NpgsqlTypes.NpgsqlPoint(x: 0.7003732279497885d, y: 0.32551152083019663d), new NpgsqlTypes.NpgsqlPoint(x: 0.1538634997836793d, y: 0.060189667683265835d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9678237681204923d, y: 0.26580255428909405d), new NpgsqlTypes.NpgsqlPoint(x: 0.6710940006135435d, y: 0.19485920876984075d), new NpgsqlTypes.NpgsqlPoint(x: 0.06104180667847936d, y: 0.41739167376867603d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3555494951388688d, y: 0.6965635720992855d), new NpgsqlTypes.NpgsqlPoint(x: 0.2639935537306739d, y: 0.6025402252585572d), new NpgsqlTypes.NpgsqlPoint(x: 0.6004266976999117d, y: 0.5604953764939219d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08576886577530363d, y: 0.39717388232119843d), new NpgsqlTypes.NpgsqlPoint(x: 0.9338232222172437d, y: 0.40650743550306145d), new NpgsqlTypes.NpgsqlPoint(x: 0.4973501726339167d, y: 0.48486951794906985d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9754816266711321d, y: 0.2210190292603258d), new NpgsqlTypes.NpgsqlPoint(x: 0.9454399194731697d, y: 0.35013249703326743d), new NpgsqlTypes.NpgsqlPoint(x: 0.8173099047671945d, y: 0.9223162906365673d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5453776379584021d, y: 0.1537311972169777d), new NpgsqlTypes.NpgsqlPoint(x: 0.49700942402365134d, y: 0.04198605940151212d), new NpgsqlTypes.NpgsqlPoint(x: 0.8462681366965054d, y: 0.06226340243043649d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6280085528044753d, y: 0.052278204120733585d), new NpgsqlTypes.NpgsqlPoint(x: 0.09651147548515626d, y: 0.8099570954414439d), new NpgsqlTypes.NpgsqlPoint(x: 0.6000146862549834d, y: 0.04872274167321333d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06866175538933661d, y: 0.35788515399776766d), new NpgsqlTypes.NpgsqlPoint(x: 0.1759743429984536d, y: 0.4387135624549432d), new NpgsqlTypes.NpgsqlPoint(x: 0.8326126456614885d, y: 0.30196619804130886d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9432637032392748d, y: 0.39188367008317604d), new NpgsqlTypes.NpgsqlPoint(x: 0.8506396118222487d, y: 0.04175595748783556d), new NpgsqlTypes.NpgsqlPoint(x: 0.023799499856765438d, y: 0.3171151077375003d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5828461428979421d, y: 0.16590725877776935d), new NpgsqlTypes.NpgsqlPoint(x: 0.36279114983890604d, y: 0.6146057889214304d), new NpgsqlTypes.NpgsqlPoint(x: 0.76262219762729d, y: 0.6012046175599318d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.950967149874997d, y: 0.32650136555445863d), new NpgsqlTypes.NpgsqlPoint(x: 0.6413243441466948d, y: 0.3138627767356603d), new NpgsqlTypes.NpgsqlPoint(x: 0.4142083100331684d, y: 0.025474064466961654d)), }, }, },
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6032146651538285d, y: 0.33459094194440375d), new NpgsqlTypes.NpgsqlPoint(x: 0.6308465174324052d, y: 0.3284470562659467d), new NpgsqlTypes.NpgsqlPoint(x: 0.32343274449709547d, y: 0.26549880475096677d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5866373021574947d, y: 0.5900701192144229d), new NpgsqlTypes.NpgsqlPoint(x: 0.4410180670704078d, y: 0.02132621933429113d), new NpgsqlTypes.NpgsqlPoint(x: 0.7681959020887819d, y: 0.6448797322696092d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7402844748204718d, y: 0.2722864266336148d), new NpgsqlTypes.NpgsqlPoint(x: 0.6071383162448377d, y: 0.5921458834842954d), new NpgsqlTypes.NpgsqlPoint(x: 0.6792454465240487d, y: 0.0007544155343370829d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6872369964861093d, y: 0.12689865178223136d), new NpgsqlTypes.NpgsqlPoint(x: 0.5168890418584813d, y: 0.0657662620171724d), new NpgsqlTypes.NpgsqlPoint(x: 0.2771912641028508d, y: 0.872909393877341d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05016124047984283d, y: 0.38418566358348105d), new NpgsqlTypes.NpgsqlPoint(x: 0.14230407705247827d, y: 0.16112451635559355d), new NpgsqlTypes.NpgsqlPoint(x: 0.981072049365636d, y: 0.683887874329871d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.541994218454107d, y: 0.3568102171533305d), new NpgsqlTypes.NpgsqlPoint(x: 0.7871662418869944d, y: 0.5374031730259073d), new NpgsqlTypes.NpgsqlPoint(x: 0.9276505428962392d, y: 0.9726937213889388d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9473866991261218d, y: 0.13296533447927328d), new NpgsqlTypes.NpgsqlPoint(x: 0.15988705673013004d, y: 0.4092907315083033d), new NpgsqlTypes.NpgsqlPoint(x: 0.10265221660926493d, y: 0.8334545604157055d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04672868282099707d, y: 0.30448022948714804d), new NpgsqlTypes.NpgsqlPoint(x: 0.027142064063879312d, y: 0.05101779097438852d), new NpgsqlTypes.NpgsqlPoint(x: 0.9194444663624842d, y: 0.3938741464657739d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46133600529618113d, y: 0.11575679581261133d), new NpgsqlTypes.NpgsqlPoint(x: 0.7312201074761432d, y: 0.3868734237606368d), new NpgsqlTypes.NpgsqlPoint(x: 0.5319544103414336d, y: 0.07449995372565787d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3410425365377324d, y: 0.5754635916376374d), new NpgsqlTypes.NpgsqlPoint(x: 0.6427326584915276d, y: 0.7797845048440103d), new NpgsqlTypes.NpgsqlPoint(x: 0.19541934244549708d, y: 4.951800582175814E-05d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11607408142780451d, y: 0.34018696276549654d), new NpgsqlTypes.NpgsqlPoint(x: 0.03191442257525101d, y: 0.025756206495938683d), new NpgsqlTypes.NpgsqlPoint(x: 0.8035357077750865d, y: 0.884995377474332d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5763586819022898d, y: 0.16013804898561768d), new NpgsqlTypes.NpgsqlPoint(x: 0.21191649224886544d, y: 0.06697680105727766d), new NpgsqlTypes.NpgsqlPoint(x: 0.6915224698382945d, y: 0.8790140517011829d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.867127273380534d, y: 0.2899901625032023d), new NpgsqlTypes.NpgsqlPoint(x: 0.9425090012441547d, y: 0.086150896867625d), new NpgsqlTypes.NpgsqlPoint(x: 0.4568476842416236d, y: 0.3072058348103398d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6299879225299188d, y: 0.3385929236544424d), new NpgsqlTypes.NpgsqlPoint(x: 0.1062092710598721d, y: 0.4127995629636456d), new NpgsqlTypes.NpgsqlPoint(x: 0.507222461604863d, y: 0.06270119381257111d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8911526857317252d, y: 0.5222520344524784d), new NpgsqlTypes.NpgsqlPoint(x: 0.8104046772431752d, y: 0.6907248522193099d), new NpgsqlTypes.NpgsqlPoint(x: 0.23373860844416183d, y: 0.23383296850216095d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1747497498185141d, y: 0.878779391326608d), new NpgsqlTypes.NpgsqlPoint(x: 0.9139591703549985d, y: 0.8735180661340294d), new NpgsqlTypes.NpgsqlPoint(x: 0.6601917410441527d, y: 0.5827441468377421d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49547600001006364d, y: 0.802273411270331d), new NpgsqlTypes.NpgsqlPoint(x: 0.4060987799438658d, y: 0.8030758016342251d), new NpgsqlTypes.NpgsqlPoint(x: 0.6690878872585881d, y: 0.023174593475666416d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5072394895736267d, y: 0.2474995471712087d), new NpgsqlTypes.NpgsqlPoint(x: 0.36870944853956966d, y: 0.8207170378366672d), new NpgsqlTypes.NpgsqlPoint(x: 0.5247281828749764d, y: 0.8157464496315513d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2817942281004787d, y: 0.7011542702541782d), new NpgsqlTypes.NpgsqlPoint(x: 0.8567543247599189d, y: 0.9348267007618094d), new NpgsqlTypes.NpgsqlPoint(x: 0.7390398890464258d, y: 0.2914844900634075d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7332009205324186d, y: 0.8191015762586872d), new NpgsqlTypes.NpgsqlPoint(x: 0.9884139972069422d, y: 0.4326741688758715d), new NpgsqlTypes.NpgsqlPoint(x: 0.15563020110252945d, y: 0.40104888119704085d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9919302523285303d, y: 0.6835097471176138d), new NpgsqlTypes.NpgsqlPoint(x: 0.736736931573718d, y: 0.06805942845330626d), new NpgsqlTypes.NpgsqlPoint(x: 0.0815079115866848d, y: 0.7793618067308551d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9106280081721575d, y: 0.04730129211086098d), new NpgsqlTypes.NpgsqlPoint(x: 0.48248287076010876d, y: 0.26199617418701626d), new NpgsqlTypes.NpgsqlPoint(x: 0.5404993847599808d, y: 0.9896949062419509d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.711029978768264d, y: 0.8943733423874716d), new NpgsqlTypes.NpgsqlPoint(x: 0.99881626761222d, y: 0.4645693863033252d), new NpgsqlTypes.NpgsqlPoint(x: 0.11166801625174816d, y: 0.28607498280915333d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8629162273411772d, y: 0.52690799306552d), new NpgsqlTypes.NpgsqlPoint(x: 0.33656272070430115d, y: 0.8909645452204237d), new NpgsqlTypes.NpgsqlPoint(x: 0.7886088095802112d, y: 0.916647513529376d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.060182410752124604d, y: 0.7249449962952595d), new NpgsqlTypes.NpgsqlPoint(x: 0.9345982921913595d, y: 0.33573402549798104d), new NpgsqlTypes.NpgsqlPoint(x: 0.3665988245012882d, y: 0.8290452003181547d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24416978561103597d, y: 0.6785565275399268d), new NpgsqlTypes.NpgsqlPoint(x: 0.8550939354524069d, y: 0.8606574407806257d), new NpgsqlTypes.NpgsqlPoint(x: 0.9028868296244625d, y: 0.801383511891942d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4315826592762533d, y: 0.48589058103625915d), new NpgsqlTypes.NpgsqlPoint(x: 0.1983319529902422d, y: 0.8691470427472885d), new NpgsqlTypes.NpgsqlPoint(x: 0.28584869616962894d, y: 0.29661438185364475d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8092599239983956d, y: 0.2887708554246078d), new NpgsqlTypes.NpgsqlPoint(x: 0.7629478853845452d, y: 0.10473488147022159d), new NpgsqlTypes.NpgsqlPoint(x: 0.23349171785484246d, y: 0.23451254682673894d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6848769276590907d, y: 0.7844012011123505d), new NpgsqlTypes.NpgsqlPoint(x: 0.8189424844863553d, y: 0.7275008628549919d), new NpgsqlTypes.NpgsqlPoint(x: 0.6922268512474955d, y: 0.8410653901794491d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4014545147690701d, y: 0.6870337405764698d), new NpgsqlTypes.NpgsqlPoint(x: 0.9952370788669462d, y: 0.14158638762066622d), new NpgsqlTypes.NpgsqlPoint(x: 0.6657137019522898d, y: 0.25666584796698333d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42927355168734105d, y: 0.73665936222291d), new NpgsqlTypes.NpgsqlPoint(x: 0.1675279931868826d, y: 0.42772904395048816d), new NpgsqlTypes.NpgsqlPoint(x: 0.0472213285854296d, y: 0.8214188285895905d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5861096017808886d, y: 0.6287660601186394d), new NpgsqlTypes.NpgsqlPoint(x: 0.8325960269117406d, y: 0.977785981108658d), new NpgsqlTypes.NpgsqlPoint(x: 0.786827150773582d, y: 0.18988347531168104d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7066927486315847d, y: 0.35355389575567053d), new NpgsqlTypes.NpgsqlPoint(x: 0.5903302125130947d, y: 0.10206365106547166d), new NpgsqlTypes.NpgsqlPoint(x: 0.8442507467218349d, y: 0.2378389876328033d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25284131278352795d, y: 0.5770085594638883d), new NpgsqlTypes.NpgsqlPoint(x: 0.987454123585208d, y: 0.06999967266811824d), new NpgsqlTypes.NpgsqlPoint(x: 0.6646118728463951d, y: 0.6957750758049657d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32381600606135097d, y: 0.6903042550733313d), new NpgsqlTypes.NpgsqlPoint(x: 0.5835827962431464d, y: 0.757221498995497d), new NpgsqlTypes.NpgsqlPoint(x: 0.19569733486579988d, y: 0.434762555202563d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42210694472201604d, y: 0.8359877059172668d), new NpgsqlTypes.NpgsqlPoint(x: 0.49651755568555933d, y: 0.8644834186640921d), new NpgsqlTypes.NpgsqlPoint(x: 0.09508934326065877d, y: 0.08061607543785254d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9305012850351937d, y: 0.6251927288917919d), new NpgsqlTypes.NpgsqlPoint(x: 0.04515790793730612d, y: 0.8797879270505193d), new NpgsqlTypes.NpgsqlPoint(x: 0.9602580905146695d, y: 0.5614458155983931d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39383398120687185d, y: 0.6071994973651147d), new NpgsqlTypes.NpgsqlPoint(x: 0.3748095548631757d, y: 0.7406723632911579d), new NpgsqlTypes.NpgsqlPoint(x: 0.1848564625880098d, y: 0.5457524691135308d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.318314222456894d, y: 0.5361454443428042d), new NpgsqlTypes.NpgsqlPoint(x: 0.6362700241702387d, y: 0.8884956435823305d), new NpgsqlTypes.NpgsqlPoint(x: 0.16182203966374076d, y: 0.4434165651580345d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5049751955415749d, y: 0.7438024202437743d), new NpgsqlTypes.NpgsqlPoint(x: 0.5735813124774655d, y: 0.31758296724986335d), new NpgsqlTypes.NpgsqlPoint(x: 0.691372305872341d, y: 0.3105201890382322d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.427761970326759d, y: 0.731258157836833d), new NpgsqlTypes.NpgsqlPoint(x: 0.8396596673067905d, y: 0.9509811547925101d), new NpgsqlTypes.NpgsqlPoint(x: 0.7507613439616647d, y: 0.28394440087131834d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38930269281250884d, y: 0.5323380198649147d), new NpgsqlTypes.NpgsqlPoint(x: 0.531810927622117d, y: 0.5491716158020593d), new NpgsqlTypes.NpgsqlPoint(x: 0.9608210221220319d, y: 0.1829813399562813d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6142539481287178d, y: 0.07075433782872143d), new NpgsqlTypes.NpgsqlPoint(x: 0.3465937477969685d, y: 0.33501806970127845d), new NpgsqlTypes.NpgsqlPoint(x: 0.7929441521587071d, y: 0.11954775035058363d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8948392739940334d, y: 0.9081055084611653d), new NpgsqlTypes.NpgsqlPoint(x: 0.8952220402984102d, y: 0.3487553716475127d), new NpgsqlTypes.NpgsqlPoint(x: 0.29747271489266736d, y: 0.06856792639836484d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29576561180058314d, y: 0.9888535878419501d), new NpgsqlTypes.NpgsqlPoint(x: 0.49163192840018066d, y: 0.08617123036219154d), new NpgsqlTypes.NpgsqlPoint(x: 0.7485216874665089d, y: 0.12936579021035532d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6175711114910681d, y: 0.19479032524116546d), new NpgsqlTypes.NpgsqlPoint(x: 0.2815960799848136d, y: 0.57296650664929d), new NpgsqlTypes.NpgsqlPoint(x: 0.3342315578802786d, y: 0.28981994584375104d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3140723610978148d, y: 0.8404540163867787d), new NpgsqlTypes.NpgsqlPoint(x: 0.9782659515083021d, y: 0.6432979362392723d), new NpgsqlTypes.NpgsqlPoint(x: 0.06420161140363423d, y: 0.2493792039414897d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.021568229159528274d, y: 0.48309155309095264d), new NpgsqlTypes.NpgsqlPoint(x: 0.13326938239750852d, y: 0.5641671819062636d), new NpgsqlTypes.NpgsqlPoint(x: 0.07199362179770252d, y: 0.8256385149227333d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.590023847722596d, y: 0.5660201926462202d), new NpgsqlTypes.NpgsqlPoint(x: 0.9049780139842318d, y: 0.09199865820385988d), new NpgsqlTypes.NpgsqlPoint(x: 0.023064337682960345d, y: 0.8228872056322988d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6902841670330144d, y: 0.9418245229056212d), new NpgsqlTypes.NpgsqlPoint(x: 0.4779727647035106d, y: 0.8835074310931386d), new NpgsqlTypes.NpgsqlPoint(x: 0.8279840983121749d, y: 0.9038395286171185d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.573075552951598d, y: 0.10478467465656094d), new NpgsqlTypes.NpgsqlPoint(x: 0.15775373548940197d, y: 0.10648671867229254d), new NpgsqlTypes.NpgsqlPoint(x: 0.6898003961074677d, y: 0.9597195745905721d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43984734341591425d, y: 0.656109577509528d), new NpgsqlTypes.NpgsqlPoint(x: 0.32178791673451557d, y: 0.7681189152236017d), new NpgsqlTypes.NpgsqlPoint(x: 0.8590081536329389d, y: 0.17897061238136136d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9938665669100779d, y: 0.039403452994154486d), new NpgsqlTypes.NpgsqlPoint(x: 0.5472013356088907d, y: 0.8663034928802986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5706661710781072d, y: 0.3848844923997954d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5100914239550748d, y: 0.6030632560536836d), new NpgsqlTypes.NpgsqlPoint(x: 0.261919410895186d, y: 0.8613585324338431d), new NpgsqlTypes.NpgsqlPoint(x: 0.707743244256366d, y: 0.05288797835372072d)), }, }, },
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6131269519153646d, y: 0.05924498109368925d), new NpgsqlTypes.NpgsqlPoint(x: 0.1581924241680347d, y: 0.8630752120264994d), new NpgsqlTypes.NpgsqlPoint(x: 0.7437171248416846d, y: 0.5471796597654861d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4888685946601049d, y: 0.16628425392751867d), new NpgsqlTypes.NpgsqlPoint(x: 0.8046152671097738d, y: 0.8469996911577828d), new NpgsqlTypes.NpgsqlPoint(x: 0.40608540186273d, y: 0.3177042148900082d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6661843369199035d, y: 0.7292633916376665d), new NpgsqlTypes.NpgsqlPoint(x: 0.06613907953053277d, y: 0.7314878686390143d), new NpgsqlTypes.NpgsqlPoint(x: 0.40744241597623554d, y: 0.37141921257180965d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09274976733637741d, y: 0.14936329385816116d), new NpgsqlTypes.NpgsqlPoint(x: 0.9255157710919139d, y: 0.8588333442481005d), new NpgsqlTypes.NpgsqlPoint(x: 0.8621430743763138d, y: 0.5618028175473624d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5294598146968561d, y: 0.3454801087554802d), new NpgsqlTypes.NpgsqlPoint(x: 0.9952454818997961d, y: 0.08675683373966847d), new NpgsqlTypes.NpgsqlPoint(x: 0.37413078361925933d, y: 0.7919936871925819d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.869923781711933d, y: 0.7077480808300347d), new NpgsqlTypes.NpgsqlPoint(x: 0.685954650163579d, y: 0.8968282449207435d), new NpgsqlTypes.NpgsqlPoint(x: 0.7076870132558372d, y: 0.7139646670829443d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3781415525162798d, y: 0.27377580801703216d), new NpgsqlTypes.NpgsqlPoint(x: 0.7397677506935975d, y: 0.22787069145141403d), new NpgsqlTypes.NpgsqlPoint(x: 0.3164656942633898d, y: 0.2000020057564844d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4341211436623652d, y: 0.7073849704561964d), new NpgsqlTypes.NpgsqlPoint(x: 0.3434374633730247d, y: 0.9999040868193515d), new NpgsqlTypes.NpgsqlPoint(x: 0.05405076051381086d, y: 0.740731250491698d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5639105840523178d, y: 0.687190416671123d), new NpgsqlTypes.NpgsqlPoint(x: 0.2576792339752628d, y: 0.7262465360077073d), new NpgsqlTypes.NpgsqlPoint(x: 0.6047137858195542d, y: 0.8385380876407071d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5801017361386364d, y: 0.8057700670743551d), new NpgsqlTypes.NpgsqlPoint(x: 0.7388543484807568d, y: 0.5002557532419898d), new NpgsqlTypes.NpgsqlPoint(x: 0.6571451592760914d, y: 0.964003551000472d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6878622606484075d, y: 0.5646205865371505d), new NpgsqlTypes.NpgsqlPoint(x: 0.42263655006150425d, y: 0.4548471686636647d), new NpgsqlTypes.NpgsqlPoint(x: 0.6957281612744138d, y: 0.07552419912916764d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7518429132234288d, y: 0.6656944725274493d), new NpgsqlTypes.NpgsqlPoint(x: 0.8672175943249801d, y: 0.31074372370116965d), new NpgsqlTypes.NpgsqlPoint(x: 0.02430908597702408d, y: 0.9610323960091975d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23246543908970918d, y: 0.545600282184823d), new NpgsqlTypes.NpgsqlPoint(x: 0.39574115917081965d, y: 0.4898042764052377d), new NpgsqlTypes.NpgsqlPoint(x: 0.8043066050352566d, y: 0.33272387746666754d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4413051782396049d, y: 0.2579622624457495d), new NpgsqlTypes.NpgsqlPoint(x: 0.21696536382989973d, y: 0.12801019031166572d), new NpgsqlTypes.NpgsqlPoint(x: 0.31922052753157215d, y: 0.4551410835228691d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3878409575796583d, y: 0.8089217827539148d), new NpgsqlTypes.NpgsqlPoint(x: 0.6401096441549303d, y: 0.5111812268354763d), new NpgsqlTypes.NpgsqlPoint(x: 0.10939706493822843d, y: 0.1426262615008278d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04587163706802633d, y: 0.5244256325959439d), new NpgsqlTypes.NpgsqlPoint(x: 0.7716147610777122d, y: 0.4185087486266468d), new NpgsqlTypes.NpgsqlPoint(x: 0.3604614558283563d, y: 0.7923891626163749d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.511510346601793d, y: 0.5907649087553684d), new NpgsqlTypes.NpgsqlPoint(x: 0.5843607781456437d, y: 0.7103208273552482d), new NpgsqlTypes.NpgsqlPoint(x: 0.7030987564077025d, y: 0.6646074212480892d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3921778776128978d, y: 0.0418267482090231d), new NpgsqlTypes.NpgsqlPoint(x: 0.12090636655473497d, y: 0.33420141449372565d), new NpgsqlTypes.NpgsqlPoint(x: 0.7854959308111213d, y: 0.8076674238847911d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8898926408875028d, y: 0.3212970141507482d), new NpgsqlTypes.NpgsqlPoint(x: 0.7127757634407547d, y: 0.5684515738338859d), new NpgsqlTypes.NpgsqlPoint(x: 0.2763871961805735d, y: 0.1454030047468361d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33143077700690515d, y: 0.8221895003865921d), new NpgsqlTypes.NpgsqlPoint(x: 0.4178611248879235d, y: 0.9985534326058476d), new NpgsqlTypes.NpgsqlPoint(x: 0.13507270928421333d, y: 0.7826243471673903d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6912275546116298d, y: 0.9775287621942877d), new NpgsqlTypes.NpgsqlPoint(x: 0.08443224571130792d, y: 0.6007282953170338d), new NpgsqlTypes.NpgsqlPoint(x: 0.6866405216665219d, y: 0.3796841632595831d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6307343153836283d, y: 0.41357018802290235d), new NpgsqlTypes.NpgsqlPoint(x: 0.8658773311387531d, y: 0.18815149933128306d), new NpgsqlTypes.NpgsqlPoint(x: 0.19796217316622788d, y: 0.9864807867438284d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29517898816690413d, y: 0.8927419263201299d), new NpgsqlTypes.NpgsqlPoint(x: 0.9842147936501477d, y: 0.6819703243009174d), new NpgsqlTypes.NpgsqlPoint(x: 0.9603174440669305d, y: 0.9996949827438452d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7251592205516311d, y: 0.6963249925578939d), new NpgsqlTypes.NpgsqlPoint(x: 0.8557285622239964d, y: 0.4760537363001355d), new NpgsqlTypes.NpgsqlPoint(x: 0.5363420577039063d, y: 0.7187825789104221d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3655604767766323d, y: 0.9148855435061101d), new NpgsqlTypes.NpgsqlPoint(x: 0.24516207508857546d, y: 0.22152989909945786d), new NpgsqlTypes.NpgsqlPoint(x: 0.2941627752349486d, y: 0.3903617394333415d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49150573122100283d, y: 0.21477657910575965d), new NpgsqlTypes.NpgsqlPoint(x: 0.05766383636292938d, y: 0.1828763677115297d), new NpgsqlTypes.NpgsqlPoint(x: 0.32205154477542663d, y: 0.2898495962924944d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35155582155654863d, y: 0.652876336474159d), new NpgsqlTypes.NpgsqlPoint(x: 0.3468567531864012d, y: 0.19691320643911636d), new NpgsqlTypes.NpgsqlPoint(x: 0.12205788197005518d, y: 0.9512205979634836d)), }, }, },
    ModelInner = new NpgsqlPathpathMMArrayD3E1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4018432542690298d, y: 0.8559832926517691d), new NpgsqlTypes.NpgsqlPoint(x: 0.7533552261297433d, y: 0.38353095683844995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9903984967667518d, y: 0.8696788249154691d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48941251807605457d, y: 0.5452199030224818d), new NpgsqlTypes.NpgsqlPoint(x: 0.36441638229919426d, y: 0.307349308463833d), new NpgsqlTypes.NpgsqlPoint(x: 0.6689633969677455d, y: 0.10109728220806724d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.163982087514148d, y: 0.05920719589866097d), new NpgsqlTypes.NpgsqlPoint(x: 0.31795881884176236d, y: 0.29155877269083674d), new NpgsqlTypes.NpgsqlPoint(x: 0.1407887176423277d, y: 0.46959742039315566d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6576465307057041d, y: 0.5311349758240745d), new NpgsqlTypes.NpgsqlPoint(x: 0.4252526346565523d, y: 0.9163698931099236d), new NpgsqlTypes.NpgsqlPoint(x: 0.9860125623248678d, y: 0.009942897835271691d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31934925660695934d, y: 0.7346407444256644d), new NpgsqlTypes.NpgsqlPoint(x: 0.38812443541704056d, y: 0.9563407403616673d), new NpgsqlTypes.NpgsqlPoint(x: 0.8647977649920278d, y: 0.8385905348608574d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0487868129555612d, y: 0.561376392767848d), new NpgsqlTypes.NpgsqlPoint(x: 0.47742680882057154d, y: 0.8123280840721024d), new NpgsqlTypes.NpgsqlPoint(x: 0.2920707943447519d, y: 0.6810262247099493d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22087946229644395d, y: 0.27342278316843815d), new NpgsqlTypes.NpgsqlPoint(x: 0.8821522933369661d, y: 0.9807586312147819d), new NpgsqlTypes.NpgsqlPoint(x: 0.34165027400451586d, y: 0.44253983054862356d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15343592251633442d, y: 0.41984160849216146d), new NpgsqlTypes.NpgsqlPoint(x: 0.020555805292006957d, y: 0.5380945165115825d), new NpgsqlTypes.NpgsqlPoint(x: 0.8963171949913601d, y: 0.0754537066103157d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19780690284568503d, y: 0.6415533298722674d), new NpgsqlTypes.NpgsqlPoint(x: 0.00889716758272796d, y: 0.827585036111559d), new NpgsqlTypes.NpgsqlPoint(x: 0.8101609592679776d, y: 0.04275808677453852d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1039481231296776d, y: 0.5005683557335331d), new NpgsqlTypes.NpgsqlPoint(x: 0.6495230474699409d, y: 0.4842209692614884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9999798345606752d, y: 0.1824524690231487d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4773214522514778d, y: 0.021294954620458717d), new NpgsqlTypes.NpgsqlPoint(x: 0.030439290421247267d, y: 0.5346161770003239d), new NpgsqlTypes.NpgsqlPoint(x: 0.8703999909050958d, y: 0.6421700811908083d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5859843493800754d, y: 0.30239068106830824d), new NpgsqlTypes.NpgsqlPoint(x: 0.261697928928607d, y: 0.5997914209777275d), new NpgsqlTypes.NpgsqlPoint(x: 0.6815779903381302d, y: 0.7146774214625208d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06537607509516807d, y: 0.3848352378189672d), new NpgsqlTypes.NpgsqlPoint(x: 0.3443024586442619d, y: 0.7304641866102267d), new NpgsqlTypes.NpgsqlPoint(x: 0.7513895785368304d, y: 0.38325869503484644d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6413418771252293d, y: 0.8409561931246229d), new NpgsqlTypes.NpgsqlPoint(x: 0.6280807111979042d, y: 0.3296393616360169d), new NpgsqlTypes.NpgsqlPoint(x: 0.053035601649271236d, y: 0.1577744284663687d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6385656783411453d, y: 0.22633305009433757d), new NpgsqlTypes.NpgsqlPoint(x: 0.06697533382380338d, y: 0.9061297171514712d), new NpgsqlTypes.NpgsqlPoint(x: 0.7295972635636256d, y: 0.30999242911400293d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024817490117426844d, y: 0.6959853425717647d), new NpgsqlTypes.NpgsqlPoint(x: 0.0457124974447648d, y: 0.5488184238088406d), new NpgsqlTypes.NpgsqlPoint(x: 0.6951947754414797d, y: 0.7648778955021118d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6672179046161801d, y: 0.2523343575700483d), new NpgsqlTypes.NpgsqlPoint(x: 0.7224349454182946d, y: 0.731210665086837d), new NpgsqlTypes.NpgsqlPoint(x: 0.8678829571073093d, y: 0.19823271091607186d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4387366471358173d, y: 0.7553513319019068d), new NpgsqlTypes.NpgsqlPoint(x: 0.7121274331413875d, y: 0.4329536506292646d), new NpgsqlTypes.NpgsqlPoint(x: 0.22987369758645304d, y: 0.15779769611259487d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4804588121526018d, y: 0.9094660230647459d), new NpgsqlTypes.NpgsqlPoint(x: 0.7246898996784651d, y: 0.4136795217977519d), new NpgsqlTypes.NpgsqlPoint(x: 0.3273302528599833d, y: 0.6766884418273748d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26994053487077774d, y: 0.3188721697679624d), new NpgsqlTypes.NpgsqlPoint(x: 0.13902260353759355d, y: 0.0699988122282651d), new NpgsqlTypes.NpgsqlPoint(x: 0.01726869363635275d, y: 0.9844196970465491d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01757741268573021d, y: 0.6659913663072901d), new NpgsqlTypes.NpgsqlPoint(x: 0.41474406622569104d, y: 0.07237777459100447d), new NpgsqlTypes.NpgsqlPoint(x: 0.8350316806903993d, y: 0.35198703395528763d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7571308708621696d, y: 0.42593325861050635d), new NpgsqlTypes.NpgsqlPoint(x: 0.3323030836108063d, y: 0.9838837191476686d), new NpgsqlTypes.NpgsqlPoint(x: 0.0169130478010866d, y: 0.4168216126313856d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9510017940974453d, y: 0.38316323954424836d), new NpgsqlTypes.NpgsqlPoint(x: 0.7741244067697244d, y: 0.08821790651003825d), new NpgsqlTypes.NpgsqlPoint(x: 0.2792529959787473d, y: 0.6566963418618601d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12428183262186843d, y: 0.3953363697466904d), new NpgsqlTypes.NpgsqlPoint(x: 0.8618893378516925d, y: 0.5160534822909645d), new NpgsqlTypes.NpgsqlPoint(x: 0.6095290901024415d, y: 0.8013112697984724d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2539604479495806d, y: 0.04600552038032313d), new NpgsqlTypes.NpgsqlPoint(x: 0.7438340853599157d, y: 0.8006635095942141d), new NpgsqlTypes.NpgsqlPoint(x: 0.36475955405985694d, y: 0.9241039737807523d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.630702026728914d, y: 0.3364055196211577d), new NpgsqlTypes.NpgsqlPoint(x: 0.06274415840526648d, y: 0.23689288114804774d), new NpgsqlTypes.NpgsqlPoint(x: 0.31135310606146493d, y: 0.2609781638961768d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23046878384333047d, y: 0.613213059365728d), new NpgsqlTypes.NpgsqlPoint(x: 0.49503278632408987d, y: 0.5650881941027627d), new NpgsqlTypes.NpgsqlPoint(x: 0.6956981666475599d, y: 0.7311776932207718d)), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3454762423329112d, y: 0.23393721216846908d), new NpgsqlTypes.NpgsqlPoint(x: 0.9259791583639403d, y: 0.77291355882356d), new NpgsqlTypes.NpgsqlPoint(x: 0.5583728878323405d, y: 0.21438342537021682d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.202729026165256d, y: 0.2884764399406008d), new NpgsqlTypes.NpgsqlPoint(x: 0.505913785290276d, y: 0.6147838209212775d), new NpgsqlTypes.NpgsqlPoint(x: 0.21006856025553566d, y: 0.09321911013385231d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46381538185015647d, y: 0.054024594328267894d), new NpgsqlTypes.NpgsqlPoint(x: 0.7216365108393885d, y: 0.5705355646964554d), new NpgsqlTypes.NpgsqlPoint(x: 0.5889344745213512d, y: 0.5179586054055327d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1572010942957741d, y: 0.9308770234619806d), new NpgsqlTypes.NpgsqlPoint(x: 0.9301512091164296d, y: 0.608106401043933d), new NpgsqlTypes.NpgsqlPoint(x: 0.05327735567276559d, y: 0.40152958676265893d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5228258818797076d, y: 0.3646649197476205d), new NpgsqlTypes.NpgsqlPoint(x: 0.055529396244696216d, y: 0.5820666743321232d), new NpgsqlTypes.NpgsqlPoint(x: 0.5097747693534662d, y: 0.46641363949706427d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.522786580973972d, y: 0.21016786173564084d), new NpgsqlTypes.NpgsqlPoint(x: 0.6403639875506525d, y: 0.5363036091905043d), new NpgsqlTypes.NpgsqlPoint(x: 0.5784499458624935d, y: 0.3541418342727458d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7827761437400049d, y: 0.5760142912916576d), new NpgsqlTypes.NpgsqlPoint(x: 0.08397280155579423d, y: 0.9058795040842754d), new NpgsqlTypes.NpgsqlPoint(x: 0.006791562449494193d, y: 0.32667084698901694d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4986138048707267d, y: 0.5037924309191338d), new NpgsqlTypes.NpgsqlPoint(x: 0.9498293211288509d, y: 0.42857367628015397d), new NpgsqlTypes.NpgsqlPoint(x: 0.7878068859304441d, y: 0.5952395062793896d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.704209538247913d, y: 0.18058988986740965d), new NpgsqlTypes.NpgsqlPoint(x: 0.6004445213030009d, y: 0.2504132799473565d), new NpgsqlTypes.NpgsqlPoint(x: 0.1777265831547752d, y: 0.8099771465616429d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8469791239470197d, y: 0.7388793781536442d), new NpgsqlTypes.NpgsqlPoint(x: 0.5186774082241455d, y: 0.5724179325866809d), new NpgsqlTypes.NpgsqlPoint(x: 0.26690961182004747d, y: 0.8944395229278377d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8783679902068112d, y: 0.13679457483981516d), new NpgsqlTypes.NpgsqlPoint(x: 0.8098950816752475d, y: 0.9987874062767683d), new NpgsqlTypes.NpgsqlPoint(x: 0.7733763962729561d, y: 0.21482824667131373d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1981939087128668d, y: 0.3085058135752392d), new NpgsqlTypes.NpgsqlPoint(x: 0.22226019986105106d, y: 0.08274073176683272d), new NpgsqlTypes.NpgsqlPoint(x: 0.5887923744739639d, y: 0.17041823739506257d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6552029122838808d, y: 0.16649643587537655d), new NpgsqlTypes.NpgsqlPoint(x: 0.38539956367122485d, y: 0.23712029474974472d), new NpgsqlTypes.NpgsqlPoint(x: 0.7794203416596539d, y: 0.412406755486994d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7773499720761752d, y: 0.0036696143430658967d), new NpgsqlTypes.NpgsqlPoint(x: 0.3590163000405169d, y: 0.6211773481431095d), new NpgsqlTypes.NpgsqlPoint(x: 0.6730193627381817d, y: 0.3646658547937516d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39682554678042725d, y: 0.034238279857293996d), new NpgsqlTypes.NpgsqlPoint(x: 0.952268404137382d, y: 0.13144875791547772d), new NpgsqlTypes.NpgsqlPoint(x: 0.6549646645440632d, y: 0.0012753147146744581d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.911596002002243d, y: 0.6310242644367566d), new NpgsqlTypes.NpgsqlPoint(x: 0.7551606736270343d, y: 0.5129110887541677d), new NpgsqlTypes.NpgsqlPoint(x: 0.6454567766253119d, y: 0.12028558057739391d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16652182182244823d, y: 0.646233162572454d), new NpgsqlTypes.NpgsqlPoint(x: 0.8369596840779205d, y: 0.5585168825401179d), new NpgsqlTypes.NpgsqlPoint(x: 0.9828668616300025d, y: 0.9048568400685162d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.966470374596307d, y: 0.13673310234416347d), new NpgsqlTypes.NpgsqlPoint(x: 0.3634775703156845d, y: 0.13097442294332473d), new NpgsqlTypes.NpgsqlPoint(x: 0.4184253069565762d, y: 0.0034255873838583417d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13470716582319409d, y: 0.9381678716763916d), new NpgsqlTypes.NpgsqlPoint(x: 0.9432404908186977d, y: 0.3216799096218653d), new NpgsqlTypes.NpgsqlPoint(x: 0.29610944849038046d, y: 0.9548455032304235d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4174314231335141d, y: 0.40664120517159164d), new NpgsqlTypes.NpgsqlPoint(x: 0.8857849278316197d, y: 0.48814306099582583d), new NpgsqlTypes.NpgsqlPoint(x: 0.09269883325414985d, y: 0.975582793021471d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6545474698056902d, y: 0.7608678356390505d), new NpgsqlTypes.NpgsqlPoint(x: 0.3381597803724532d, y: 0.49472727720240706d), new NpgsqlTypes.NpgsqlPoint(x: 0.9031358264222145d, y: 0.8401662220637968d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3795246740971673d, y: 0.11342884113237917d), new NpgsqlTypes.NpgsqlPoint(x: 0.159942964665452d, y: 0.24298826420473973d), new NpgsqlTypes.NpgsqlPoint(x: 0.7156717678396733d, y: 0.019845350752631497d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6688626725377241d, y: 0.1096310897177778d), new NpgsqlTypes.NpgsqlPoint(x: 0.8485403474893684d, y: 0.7969057973568284d), new NpgsqlTypes.NpgsqlPoint(x: 0.1227538327496891d, y: 0.8039873302737833d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6950429810330943d, y: 0.9929860617300467d), new NpgsqlTypes.NpgsqlPoint(x: 0.404296221799766d, y: 0.288747489384495d), new NpgsqlTypes.NpgsqlPoint(x: 0.4386549514461866d, y: 0.6353564571683238d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24661612919471299d, y: 0.1846660489426507d), new NpgsqlTypes.NpgsqlPoint(x: 0.6596282734104465d, y: 0.8527180696378533d), new NpgsqlTypes.NpgsqlPoint(x: 0.44136780284785404d, y: 0.7233169132723544d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4845193311277589d, y: 0.7067701323738265d), new NpgsqlTypes.NpgsqlPoint(x: 0.6203496336640977d, y: 0.9744067929203569d), new NpgsqlTypes.NpgsqlPoint(x: 0.4810184814663907d, y: 0.6353484930831771d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06898682088735864d, y: 0.44907150317253575d), new NpgsqlTypes.NpgsqlPoint(x: 0.0008124378417493361d, y: 0.521795998223848d), new NpgsqlTypes.NpgsqlPoint(x: 0.2061611791863326d, y: 0.6461312435320579d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8329505030616913d, y: 0.28854185671824517d), new NpgsqlTypes.NpgsqlPoint(x: 0.4747092101486692d, y: 0.32501984610161194d), new NpgsqlTypes.NpgsqlPoint(x: 0.7747504886356094d, y: 0.744970846943825d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2146437327054953d, y: 0.6644521499007334d), new NpgsqlTypes.NpgsqlPoint(x: 0.09600485125714386d, y: 0.6348708811626984d), new NpgsqlTypes.NpgsqlPoint(x: 0.34341417244004424d, y: 0.7086055548605946d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5479375927943033d, y: 0.3191824373844112d), new NpgsqlTypes.NpgsqlPoint(x: 0.14763377330427507d, y: 0.4403242989408349d), new NpgsqlTypes.NpgsqlPoint(x: 0.23153387920823765d, y: 0.58083547487392d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7976451262928542d, y: 0.20325616423290072d), new NpgsqlTypes.NpgsqlPoint(x: 0.44960018036558125d, y: 0.9085259351995597d), new NpgsqlTypes.NpgsqlPoint(x: 0.0913697210999137d, y: 0.45532005896381644d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2777265067888397d, y: 0.7331143432327261d), new NpgsqlTypes.NpgsqlPoint(x: 0.7203257596504036d, y: 0.9743604469634152d), new NpgsqlTypes.NpgsqlPoint(x: 0.2018017210851113d, y: 0.2941364976744626d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26057636543679175d, y: 0.5690302415875663d), new NpgsqlTypes.NpgsqlPoint(x: 0.11708071915156948d, y: 0.2299094730387794d), new NpgsqlTypes.NpgsqlPoint(x: 0.37749773268093534d, y: 0.5638834522646752d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8233690748414028d, y: 0.008482297257971005d), new NpgsqlTypes.NpgsqlPoint(x: 0.7244064281557793d, y: 0.6879034900710016d), new NpgsqlTypes.NpgsqlPoint(x: 0.35582204482802204d, y: 0.21476252456584943d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6751025432008881d, y: 0.027766705146855086d), new NpgsqlTypes.NpgsqlPoint(x: 0.08489499493842367d, y: 0.11458604235822412d), new NpgsqlTypes.NpgsqlPoint(x: 0.7942395249476483d, y: 0.998659573436666d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18192334476669292d, y: 0.12296916482460951d), new NpgsqlTypes.NpgsqlPoint(x: 0.984548304914217d, y: 0.13121714851277588d), new NpgsqlTypes.NpgsqlPoint(x: 0.9910716824291476d, y: 0.308754192306373d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02688185241004193d, y: 0.5523989973337763d), new NpgsqlTypes.NpgsqlPoint(x: 0.5838019127329945d, y: 0.24575622244277862d), new NpgsqlTypes.NpgsqlPoint(x: 0.9129840192910037d, y: 0.5891594375361883d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6233540232481701d, y: 0.0769661550152998d), new NpgsqlTypes.NpgsqlPoint(x: 0.4792299486253786d, y: 0.7285672725390876d), new NpgsqlTypes.NpgsqlPoint(x: 0.122431008860445d, y: 0.9774712356421527d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6857671486145513d, y: 0.8917850895767767d), new NpgsqlTypes.NpgsqlPoint(x: 0.8960085947578272d, y: 0.1847448481247157d), new NpgsqlTypes.NpgsqlPoint(x: 0.3994190596593623d, y: 0.8650891363393893d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6396009348708225d, y: 0.8296450301151602d), new NpgsqlTypes.NpgsqlPoint(x: 0.11964107395831569d, y: 0.8311758123923683d), new NpgsqlTypes.NpgsqlPoint(x: 0.9465108135909189d, y: 0.0775842487719085d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1059128505021425d, y: 0.18063487631847364d), new NpgsqlTypes.NpgsqlPoint(x: 0.5062078056058806d, y: 0.5998112170931245d), new NpgsqlTypes.NpgsqlPoint(x: 0.3541086267538579d, y: 0.4881298697916424d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26652699952333603d, y: 0.1773022369973648d), new NpgsqlTypes.NpgsqlPoint(x: 0.27614147073746786d, y: 0.5416159326010155d), new NpgsqlTypes.NpgsqlPoint(x: 0.1162780847697471d, y: 0.8607046719066255d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6963774547865437d, y: 0.6349834881330725d), new NpgsqlTypes.NpgsqlPoint(x: 0.6116309678670014d, y: 0.36038236986842853d), new NpgsqlTypes.NpgsqlPoint(x: 0.5171794321685272d, y: 0.006718000266592972d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6461088259509729d, y: 0.6767972979474902d), new NpgsqlTypes.NpgsqlPoint(x: 0.30744627535135205d, y: 0.9746445148961429d), new NpgsqlTypes.NpgsqlPoint(x: 0.6006334097640983d, y: 0.6907290302818002d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9870522361921007d, y: 0.6181345378521566d), new NpgsqlTypes.NpgsqlPoint(x: 0.1357034540819846d, y: 0.8720541685722522d), new NpgsqlTypes.NpgsqlPoint(x: 0.9057427159884214d, y: 0.9625181852682534d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5060159558604079d, y: 0.3735074744318184d), new NpgsqlTypes.NpgsqlPoint(x: 0.7710429191344986d, y: 0.4804781551041116d), new NpgsqlTypes.NpgsqlPoint(x: 0.5945157304519607d, y: 0.974768781837866d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5472318265129054d, y: 0.24553184695616648d), new NpgsqlTypes.NpgsqlPoint(x: 0.5585183571023793d, y: 0.31011556925593753d), new NpgsqlTypes.NpgsqlPoint(x: 0.19208700975241377d, y: 0.7486045317782489d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2623653348756405d, y: 0.4230879358337153d), new NpgsqlTypes.NpgsqlPoint(x: 0.001322844279077251d, y: 0.5282589952413266d), new NpgsqlTypes.NpgsqlPoint(x: 0.10802263303168003d, y: 0.082730272392873d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46909218904054606d, y: 0.17466071784595416d), new NpgsqlTypes.NpgsqlPoint(x: 0.3227962493492408d, y: 0.23019029815708525d), new NpgsqlTypes.NpgsqlPoint(x: 0.4328766540544363d, y: 0.4642920705478064d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4453550759478502d, y: 0.9438714320861455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7131639786598699d, y: 0.5415054237968555d), new NpgsqlTypes.NpgsqlPoint(x: 0.037661123154452136d, y: 0.8927292670655178d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9688584686449662d, y: 0.7267123568574406d), new NpgsqlTypes.NpgsqlPoint(x: 0.16797398807838237d, y: 0.5756166303223823d), new NpgsqlTypes.NpgsqlPoint(x: 0.20301793541801083d, y: 0.8596554128928242d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3455421898214974d, y: 0.37025241482679194d), new NpgsqlTypes.NpgsqlPoint(x: 0.7481621529988728d, y: 0.6948684786696705d), new NpgsqlTypes.NpgsqlPoint(x: 0.4671606814552378d, y: 0.29516891365718556d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07858233711419882d, y: 0.674886463330235d), new NpgsqlTypes.NpgsqlPoint(x: 0.026018877794922846d, y: 0.5942346515072381d), new NpgsqlTypes.NpgsqlPoint(x: 0.21650578438919266d, y: 0.1722167507325275d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2686096061693125d, y: 0.5444961278630709d), new NpgsqlTypes.NpgsqlPoint(x: 0.8237337789581806d, y: 0.07628422043904859d), new NpgsqlTypes.NpgsqlPoint(x: 0.00964798299634706d, y: 0.9282400728298669d)), }, }, },
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2905608601242591d, y: 0.8738534871264864d), new NpgsqlTypes.NpgsqlPoint(x: 0.11732029683992606d, y: 0.04958081693744942d), new NpgsqlTypes.NpgsqlPoint(x: 0.8043999802324052d, y: 0.9542916739268134d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18225669197586414d, y: 0.49846947271514697d), new NpgsqlTypes.NpgsqlPoint(x: 0.62997079530111d, y: 0.5385089025834675d), new NpgsqlTypes.NpgsqlPoint(x: 0.5709062426755612d, y: 0.07151861509990609d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7832014276941742d, y: 0.9895250229177738d), new NpgsqlTypes.NpgsqlPoint(x: 0.8802916771517688d, y: 0.5490546658842751d), new NpgsqlTypes.NpgsqlPoint(x: 0.7237019372122163d, y: 0.32735393319874106d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39149614294876967d, y: 0.28075812154695334d), new NpgsqlTypes.NpgsqlPoint(x: 0.32698167190764715d, y: 0.2557339746385503d), new NpgsqlTypes.NpgsqlPoint(x: 0.3171560648226486d, y: 0.8415479595380794d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9776423037034505d, y: 0.19555087583023256d), new NpgsqlTypes.NpgsqlPoint(x: 0.8082399374306884d, y: 0.6573935069189073d), new NpgsqlTypes.NpgsqlPoint(x: 0.6601075501359935d, y: 0.8512834616271104d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34759631179282d, y: 0.8304003741442967d), new NpgsqlTypes.NpgsqlPoint(x: 0.8112157446764446d, y: 0.07790878495116205d), new NpgsqlTypes.NpgsqlPoint(x: 0.06695748536003532d, y: 0.2838856766454976d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27753293064046003d, y: 0.01390982083358705d), new NpgsqlTypes.NpgsqlPoint(x: 0.9574965887769198d, y: 0.3172711197622573d), new NpgsqlTypes.NpgsqlPoint(x: 0.8588355301443562d, y: 0.8114914469017372d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35171010539982006d, y: 0.7767084928568659d), new NpgsqlTypes.NpgsqlPoint(x: 0.7552398338130446d, y: 0.7877019694016393d), new NpgsqlTypes.NpgsqlPoint(x: 0.4804078641115208d, y: 0.05070133676229316d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.348844410347239d, y: 0.8059227441554776d), new NpgsqlTypes.NpgsqlPoint(x: 0.18590401890151742d, y: 0.42212700881244125d), new NpgsqlTypes.NpgsqlPoint(x: 0.34916205682732826d, y: 0.1679070007511243d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46794544877146904d, y: 0.7820007635082316d), new NpgsqlTypes.NpgsqlPoint(x: 0.22595666351333688d, y: 0.03713560038069463d), new NpgsqlTypes.NpgsqlPoint(x: 0.34594135355495537d, y: 0.6375392191939079d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4426643579985403d, y: 0.08117533792998666d), new NpgsqlTypes.NpgsqlPoint(x: 0.6572762253448744d, y: 0.5163165393712267d), new NpgsqlTypes.NpgsqlPoint(x: 0.20250701664448068d, y: 0.6316569610470563d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5512021556703486d, y: 0.7932718369816814d), new NpgsqlTypes.NpgsqlPoint(x: 0.2662904283588564d, y: 0.3363396898087442d), new NpgsqlTypes.NpgsqlPoint(x: 0.5901595292542331d, y: 0.9191384391376632d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.693330330280977d, y: 0.13736951307534084d), new NpgsqlTypes.NpgsqlPoint(x: 0.41347254715134396d, y: 0.15801441602176747d), new NpgsqlTypes.NpgsqlPoint(x: 0.049056024241936336d, y: 0.49263232128050016d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5475610049370843d, y: 0.620071571982141d), new NpgsqlTypes.NpgsqlPoint(x: 0.8565252020187974d, y: 0.005740611989782929d), new NpgsqlTypes.NpgsqlPoint(x: 0.16898746769217565d, y: 0.22888198603010146d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34549553584887704d, y: 0.6489744006205368d), new NpgsqlTypes.NpgsqlPoint(x: 0.1576679136513044d, y: 0.38649089162900674d), new NpgsqlTypes.NpgsqlPoint(x: 0.8355522463580983d, y: 0.5464478244380419d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26470128314573205d, y: 0.022189800390862713d), new NpgsqlTypes.NpgsqlPoint(x: 0.8613596601100973d, y: 0.5411797788571417d), new NpgsqlTypes.NpgsqlPoint(x: 0.7800011829958267d, y: 0.5371494992157294d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3318340899961142d, y: 0.6754066011940506d), new NpgsqlTypes.NpgsqlPoint(x: 0.9260681884865692d, y: 0.3706408024681159d), new NpgsqlTypes.NpgsqlPoint(x: 0.6329877865560117d, y: 0.4959564392310519d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5988249321322227d, y: 0.9523732950658684d), new NpgsqlTypes.NpgsqlPoint(x: 0.8549541073304158d, y: 0.5269763001209464d), new NpgsqlTypes.NpgsqlPoint(x: 0.6101914801917387d, y: 0.4095108802910792d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6276651699985385d, y: 0.768802130648584d), new NpgsqlTypes.NpgsqlPoint(x: 0.7619920411397627d, y: 0.2195621678877976d), new NpgsqlTypes.NpgsqlPoint(x: 0.11463253135609108d, y: 0.7899605905054856d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7413090216841782d, y: 0.6535466159628728d), new NpgsqlTypes.NpgsqlPoint(x: 0.7261264688132364d, y: 0.5588583722533079d), new NpgsqlTypes.NpgsqlPoint(x: 0.43444923280856906d, y: 0.7271910728126707d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.050010968311427706d, y: 0.2568481182763884d), new NpgsqlTypes.NpgsqlPoint(x: 0.7570475067928684d, y: 0.8771127491059156d), new NpgsqlTypes.NpgsqlPoint(x: 0.4072410606592658d, y: 0.3458102917377367d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38284442183207623d, y: 0.07456892005286431d), new NpgsqlTypes.NpgsqlPoint(x: 0.07875793156060584d, y: 0.06125285985223117d), new NpgsqlTypes.NpgsqlPoint(x: 0.8902577793572028d, y: 0.0037337697056130104d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.152726646384581d, y: 0.9686232688754685d), new NpgsqlTypes.NpgsqlPoint(x: 0.8760357059438738d, y: 0.35080205424516187d), new NpgsqlTypes.NpgsqlPoint(x: 0.48740269395106683d, y: 0.9199380598416418d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43617622798028177d, y: 0.16580587153487747d), new NpgsqlTypes.NpgsqlPoint(x: 0.1807953660941558d, y: 0.8223503797691676d), new NpgsqlTypes.NpgsqlPoint(x: 0.2508139091790207d, y: 0.049991699935448275d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9314866571082306d, y: 0.3310839576274798d), new NpgsqlTypes.NpgsqlPoint(x: 0.8330096695047768d, y: 0.6058750242606683d), new NpgsqlTypes.NpgsqlPoint(x: 0.8747686820707825d, y: 0.7235434787224417d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6770505640669174d, y: 0.1157573294021832d), new NpgsqlTypes.NpgsqlPoint(x: 0.9183022464794358d, y: 0.7403413234952742d), new NpgsqlTypes.NpgsqlPoint(x: 0.3569663936529919d, y: 0.6036143502670942d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.016712340916908208d, y: 0.33425868510279355d), new NpgsqlTypes.NpgsqlPoint(x: 0.4936316002662462d, y: 0.3199715245432311d), new NpgsqlTypes.NpgsqlPoint(x: 0.7338412358443954d, y: 0.3250153433134646d)), }, }, },
    ModelInner = new NpgsqlPathpathMMArrayD3E1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5827270817633667d, y: 0.3799528229387099d), new NpgsqlTypes.NpgsqlPoint(x: 0.09210250179378576d, y: 0.7041553692127894d), new NpgsqlTypes.NpgsqlPoint(x: 0.7722343272881812d, y: 0.1189407521232787d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03693273792135321d, y: 0.48837792650393275d), new NpgsqlTypes.NpgsqlPoint(x: 0.18465734056343708d, y: 0.14780463616643924d), new NpgsqlTypes.NpgsqlPoint(x: 0.7782284149170138d, y: 0.006233229205558577d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14415860086533228d, y: 0.8445265200470211d), new NpgsqlTypes.NpgsqlPoint(x: 0.10462857525472624d, y: 0.9935421646298412d), new NpgsqlTypes.NpgsqlPoint(x: 0.6344245777666736d, y: 0.7728300158613639d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9975988646198105d, y: 0.7421503791026425d), new NpgsqlTypes.NpgsqlPoint(x: 0.7170811410392314d, y: 0.7455280873658856d), new NpgsqlTypes.NpgsqlPoint(x: 0.6064333253170388d, y: 0.5325004876963568d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006459885917942443d, y: 0.969151454274805d), new NpgsqlTypes.NpgsqlPoint(x: 0.8601534175764193d, y: 0.6620280510408547d), new NpgsqlTypes.NpgsqlPoint(x: 0.6044985569889154d, y: 0.3141886546052801d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11373168839003112d, y: 0.35862238984390105d), new NpgsqlTypes.NpgsqlPoint(x: 0.7969008584977149d, y: 0.556374252950618d), new NpgsqlTypes.NpgsqlPoint(x: 0.5388196052481296d, y: 0.5230946276878938d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7633814097430903d, y: 0.06361691428881477d), new NpgsqlTypes.NpgsqlPoint(x: 0.2922096103399455d, y: 0.6534203716579354d), new NpgsqlTypes.NpgsqlPoint(x: 0.1390991424031507d, y: 0.8248929268800593d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08803172584648611d, y: 0.6969658935048243d), new NpgsqlTypes.NpgsqlPoint(x: 0.9889700950888627d, y: 0.2701925449756476d), new NpgsqlTypes.NpgsqlPoint(x: 0.4487637552382697d, y: 0.8420402043736075d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7064749713206736d, y: 0.3055210172083853d), new NpgsqlTypes.NpgsqlPoint(x: 0.6811468092703008d, y: 0.22096055073214282d), new NpgsqlTypes.NpgsqlPoint(x: 0.7932308412366309d, y: 0.36543360426000837d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6968257428997319d, y: 0.2727154364284231d), new NpgsqlTypes.NpgsqlPoint(x: 0.5788738597154781d, y: 0.47288547188677676d), new NpgsqlTypes.NpgsqlPoint(x: 0.9751178265083198d, y: 0.337560296409416d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5671771213596914d, y: 0.6114385461845767d), new NpgsqlTypes.NpgsqlPoint(x: 0.8432492336857744d, y: 0.795157256824351d), new NpgsqlTypes.NpgsqlPoint(x: 0.8372955864313284d, y: 0.37925835134548247d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7633112399345668d, y: 0.8973516366610373d), new NpgsqlTypes.NpgsqlPoint(x: 0.8086987723700736d, y: 0.009430615784627117d), new NpgsqlTypes.NpgsqlPoint(x: 0.9667824925303357d, y: 0.09405690071250639d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6014210715423205d, y: 0.8944537031930051d), new NpgsqlTypes.NpgsqlPoint(x: 0.3356799596861667d, y: 0.9406065567464027d), new NpgsqlTypes.NpgsqlPoint(x: 0.8344974868824566d, y: 0.6385538775820717d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9174175120042779d, y: 0.5260468013094121d), new NpgsqlTypes.NpgsqlPoint(x: 0.3395328891147442d, y: 0.7288645777057456d), new NpgsqlTypes.NpgsqlPoint(x: 0.31954642512496534d, y: 0.3840894669836662d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6892136230002099d, y: 0.9517878559308325d), new NpgsqlTypes.NpgsqlPoint(x: 0.14911797140709704d, y: 0.6559327843141647d), new NpgsqlTypes.NpgsqlPoint(x: 0.6002233846531123d, y: 0.345979873255989d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26196627946307427d, y: 0.4888579925218852d), new NpgsqlTypes.NpgsqlPoint(x: 0.7285201977026678d, y: 0.761866064555214d), new NpgsqlTypes.NpgsqlPoint(x: 0.8637598440535339d, y: 0.8897015694765875d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9335121563211827d, y: 0.8652034509606349d), new NpgsqlTypes.NpgsqlPoint(x: 0.5383641977991848d, y: 0.8191637964140442d), new NpgsqlTypes.NpgsqlPoint(x: 0.33837034224260576d, y: 0.7457669603334123d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5433153361703307d, y: 0.9195809547639354d), new NpgsqlTypes.NpgsqlPoint(x: 0.6047639049742815d, y: 0.9170559587063118d), new NpgsqlTypes.NpgsqlPoint(x: 0.09388123484789046d, y: 0.44646861157536366d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9673507232808634d, y: 0.7069987928195641d), new NpgsqlTypes.NpgsqlPoint(x: 0.6534917808361518d, y: 0.6890588854275558d), new NpgsqlTypes.NpgsqlPoint(x: 0.5682079844476224d, y: 0.4316645545589255d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7156839261100627d, y: 0.3776789263510971d), new NpgsqlTypes.NpgsqlPoint(x: 0.5422022283740032d, y: 0.6720807769220833d), new NpgsqlTypes.NpgsqlPoint(x: 0.5233176355562358d, y: 0.11497160633635906d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48080081559317567d, y: 0.4455239490703833d), new NpgsqlTypes.NpgsqlPoint(x: 0.19110665652106607d, y: 0.46792080768164257d), new NpgsqlTypes.NpgsqlPoint(x: 0.8804509686295491d, y: 0.17136985714587472d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024540614937375915d, y: 0.9870819711381505d), new NpgsqlTypes.NpgsqlPoint(x: 0.45942266330290493d, y: 0.8457558810107264d), new NpgsqlTypes.NpgsqlPoint(x: 0.7672333383991697d, y: 0.102466990912914d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6946324036385152d, y: 0.05359145443222357d), new NpgsqlTypes.NpgsqlPoint(x: 0.1470895124573317d, y: 0.3056527408296644d), new NpgsqlTypes.NpgsqlPoint(x: 0.5419386936003879d, y: 0.1580341448242758d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31017893936113583d, y: 0.5525819205806377d), new NpgsqlTypes.NpgsqlPoint(x: 0.9310759554256264d, y: 0.5157317571690364d), new NpgsqlTypes.NpgsqlPoint(x: 0.9769158061741425d, y: 0.9155554667198587d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007058717573904527d, y: 0.6867359539559814d), new NpgsqlTypes.NpgsqlPoint(x: 0.9562933727990041d, y: 0.40404279460434145d), new NpgsqlTypes.NpgsqlPoint(x: 0.7074807245251238d, y: 0.23827729396281339d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9064221790898975d, y: 0.5874102130869384d), new NpgsqlTypes.NpgsqlPoint(x: 0.2832755490540634d, y: 0.5950184553461964d), new NpgsqlTypes.NpgsqlPoint(x: 0.033055643817666125d, y: 0.625241924790268d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7458858672187664d, y: 0.5793703537389066d), new NpgsqlTypes.NpgsqlPoint(x: 0.7920612310651358d, y: 0.8137523243563233d), new NpgsqlTypes.NpgsqlPoint(x: 0.3064725422294592d, y: 0.230996949201419d)), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8894632097222746d, y: 0.9288656902237166d), new NpgsqlTypes.NpgsqlPoint(x: 0.28992597937699305d, y: 0.6981645993848609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9663508606330418d, y: 0.8063179128346031d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8389139496857531d, y: 0.15025397863684586d), new NpgsqlTypes.NpgsqlPoint(x: 0.15813475968662016d, y: 0.25474950780920547d), new NpgsqlTypes.NpgsqlPoint(x: 0.2188803566004517d, y: 0.5769689293088195d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3306789938387985d, y: 0.39808364289682985d), new NpgsqlTypes.NpgsqlPoint(x: 0.9258408519170315d, y: 0.32351015474583844d), new NpgsqlTypes.NpgsqlPoint(x: 0.4456876328316257d, y: 0.8205634328638403d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8950496368611293d, y: 0.7419457055094041d), new NpgsqlTypes.NpgsqlPoint(x: 0.5694963139033576d, y: 0.6846088330188989d), new NpgsqlTypes.NpgsqlPoint(x: 0.2813833880568354d, y: 0.0916221920021707d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05218625165013613d, y: 0.46145879774768184d), new NpgsqlTypes.NpgsqlPoint(x: 0.11484541659439362d, y: 0.6798642569034087d), new NpgsqlTypes.NpgsqlPoint(x: 0.81822270671852d, y: 0.6575324466350703d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7049385141998513d, y: 0.739173697304439d), new NpgsqlTypes.NpgsqlPoint(x: 0.03878776161217845d, y: 0.20879820915770997d), new NpgsqlTypes.NpgsqlPoint(x: 0.8809646412213881d, y: 0.5927116326557346d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6388255014546315d, y: 0.270491374608152d), new NpgsqlTypes.NpgsqlPoint(x: 0.22848551842118014d, y: 0.8209847905855395d), new NpgsqlTypes.NpgsqlPoint(x: 0.38872624276777656d, y: 0.16203782370724806d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.026427334009510584d, y: 0.7726027065514827d), new NpgsqlTypes.NpgsqlPoint(x: 0.6449192933021649d, y: 0.2683112439274977d), new NpgsqlTypes.NpgsqlPoint(x: 0.5195653888892067d, y: 0.5383127827827233d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7284572562755778d, y: 0.4494768511586924d), new NpgsqlTypes.NpgsqlPoint(x: 0.8883103095188004d, y: 0.8252259501021647d), new NpgsqlTypes.NpgsqlPoint(x: 0.06522595813934295d, y: 0.8567960889161537d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.834133832728878d, y: 0.36421185378346155d), new NpgsqlTypes.NpgsqlPoint(x: 0.04981709527471767d, y: 0.29701444832503865d), new NpgsqlTypes.NpgsqlPoint(x: 0.1643266757458074d, y: 0.4405534558834885d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.616631092243528d, y: 0.5028790823744249d), new NpgsqlTypes.NpgsqlPoint(x: 0.8572733436813028d, y: 0.9586162104585325d), new NpgsqlTypes.NpgsqlPoint(x: 0.07263773638236981d, y: 0.3320289601966422d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36927225403127306d, y: 0.8161474728314536d), new NpgsqlTypes.NpgsqlPoint(x: 0.18123687240442732d, y: 0.8996760098123525d), new NpgsqlTypes.NpgsqlPoint(x: 0.16842251757893845d, y: 0.682363866671469d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8492026959321267d, y: 0.3258673482777825d), new NpgsqlTypes.NpgsqlPoint(x: 0.8118086474241459d, y: 0.727530324566338d), new NpgsqlTypes.NpgsqlPoint(x: 0.875969614545173d, y: 0.2774413049483512d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33954829802249387d, y: 0.1349239301156363d), new NpgsqlTypes.NpgsqlPoint(x: 0.5296173031699056d, y: 0.4857909979121774d), new NpgsqlTypes.NpgsqlPoint(x: 0.5013572027444336d, y: 0.9083356310902847d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20452545991093807d, y: 0.2523936658234668d), new NpgsqlTypes.NpgsqlPoint(x: 0.9105417281715132d, y: 0.37743028452450345d), new NpgsqlTypes.NpgsqlPoint(x: 0.82549209267291d, y: 0.7290030869214085d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8168916601673026d, y: 0.22684213055898328d), new NpgsqlTypes.NpgsqlPoint(x: 0.1652449670141406d, y: 0.2579403861080337d), new NpgsqlTypes.NpgsqlPoint(x: 0.6347372997120323d, y: 0.0452152713547922d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05782247258084827d, y: 0.5002828430911288d), new NpgsqlTypes.NpgsqlPoint(x: 0.7304076358050435d, y: 0.8204397328916455d), new NpgsqlTypes.NpgsqlPoint(x: 0.9479222366269998d, y: 0.09991279422951294d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8126921988621396d, y: 0.5026523698243412d), new NpgsqlTypes.NpgsqlPoint(x: 0.5833149766067778d, y: 0.5265106001945529d), new NpgsqlTypes.NpgsqlPoint(x: 0.2597997008560079d, y: 0.25330403478364594d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23793196473703837d, y: 0.3168201363740172d), new NpgsqlTypes.NpgsqlPoint(x: 0.36832638473078605d, y: 0.8642840431156539d), new NpgsqlTypes.NpgsqlPoint(x: 0.7073217363225335d, y: 0.5963986343513614d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09005966179696856d, y: 0.24174452478876363d), new NpgsqlTypes.NpgsqlPoint(x: 0.6347245527241454d, y: 0.7069835202146925d), new NpgsqlTypes.NpgsqlPoint(x: 0.6324644127926006d, y: 0.4791018659581999d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06953630586471604d, y: 0.15753660464527075d), new NpgsqlTypes.NpgsqlPoint(x: 0.8138099578104113d, y: 0.40262718901472017d), new NpgsqlTypes.NpgsqlPoint(x: 0.3125006468423427d, y: 0.08325038365377768d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5679620634292204d, y: 0.22768898546209348d), new NpgsqlTypes.NpgsqlPoint(x: 0.9380674469438609d, y: 0.2446511319319602d), new NpgsqlTypes.NpgsqlPoint(x: 0.8071597175074712d, y: 0.3227640809598121d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.990660216281603d, y: 0.8940263676968095d), new NpgsqlTypes.NpgsqlPoint(x: 0.41016320168339926d, y: 0.5050743896687082d), new NpgsqlTypes.NpgsqlPoint(x: 0.39695748704828515d, y: 0.00023327452866217513d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3606277601728315d, y: 0.1960425979891688d), new NpgsqlTypes.NpgsqlPoint(x: 0.3846052329343982d, y: 0.9631292244213114d), new NpgsqlTypes.NpgsqlPoint(x: 0.7631027303978668d, y: 0.7437561161887601d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8937215080700764d, y: 0.24383764395760177d), new NpgsqlTypes.NpgsqlPoint(x: 0.9241375042331079d, y: 0.0027679648782837907d), new NpgsqlTypes.NpgsqlPoint(x: 0.24791665431913845d, y: 0.5623616516662586d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6096251142839815d, y: 0.32033347243990884d), new NpgsqlTypes.NpgsqlPoint(x: 0.8180780236157851d, y: 0.8508229142606013d), new NpgsqlTypes.NpgsqlPoint(x: 0.5872216679460276d, y: 0.225629264152435d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.403539474110733d, y: 0.4020053607827836d), new NpgsqlTypes.NpgsqlPoint(x: 0.7132536608586469d, y: 0.09487503848856393d), new NpgsqlTypes.NpgsqlPoint(x: 0.6743873056516918d, y: 0.5099219281302296d)), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8402498228529182d, y: 0.23436812939268636d), new NpgsqlTypes.NpgsqlPoint(x: 0.3701314895702378d, y: 0.564815018201035d), new NpgsqlTypes.NpgsqlPoint(x: 0.2758669524908769d, y: 0.1960703982600136d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5214430346463133d, y: 0.4931848281011061d), new NpgsqlTypes.NpgsqlPoint(x: 0.6836381622108497d, y: 0.660270790826968d), new NpgsqlTypes.NpgsqlPoint(x: 0.3873797617535254d, y: 0.67191031913148d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07196867077601976d, y: 0.30436281610169824d), new NpgsqlTypes.NpgsqlPoint(x: 0.005478501644478051d, y: 0.25081214736704716d), new NpgsqlTypes.NpgsqlPoint(x: 0.8748370783939126d, y: 0.8893840247698749d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48446017765548866d, y: 0.6690978390596863d), new NpgsqlTypes.NpgsqlPoint(x: 0.10832220240834822d, y: 0.8467540582633792d), new NpgsqlTypes.NpgsqlPoint(x: 0.3334843062417838d, y: 0.8800801401564007d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03930374344941845d, y: 0.5270607914550821d), new NpgsqlTypes.NpgsqlPoint(x: 0.18617654909879167d, y: 0.21896456289053934d), new NpgsqlTypes.NpgsqlPoint(x: 0.0976511722443979d, y: 0.5890115341338512d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21005679376820052d, y: 0.29865639934732435d), new NpgsqlTypes.NpgsqlPoint(x: 0.9448957768055098d, y: 0.8007965428780892d), new NpgsqlTypes.NpgsqlPoint(x: 0.8359191083083513d, y: 0.7651485469240396d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06874241215039878d, y: 0.7511498676859821d), new NpgsqlTypes.NpgsqlPoint(x: 0.026548853417664997d, y: 0.9383450494219152d), new NpgsqlTypes.NpgsqlPoint(x: 0.4928490524135949d, y: 0.41084509208525455d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4414319177402585d, y: 0.24140775580389395d), new NpgsqlTypes.NpgsqlPoint(x: 0.023672573175954392d, y: 0.37928923227114775d), new NpgsqlTypes.NpgsqlPoint(x: 0.8474429488752773d, y: 0.45166315858716977d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07048661339295315d, y: 0.34959785899628615d), new NpgsqlTypes.NpgsqlPoint(x: 0.6372819274257573d, y: 0.798181765693753d), new NpgsqlTypes.NpgsqlPoint(x: 0.6028233632504534d, y: 0.419113589521809d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5756831373984173d, y: 0.811222278885349d), new NpgsqlTypes.NpgsqlPoint(x: 0.15017348281999288d, y: 0.5300026712529236d), new NpgsqlTypes.NpgsqlPoint(x: 0.9599787317288667d, y: 0.962487634201529d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8695489862689977d, y: 0.9809855503724215d), new NpgsqlTypes.NpgsqlPoint(x: 0.48119868895138873d, y: 0.35240756558259734d), new NpgsqlTypes.NpgsqlPoint(x: 0.7205764667199119d, y: 0.47213599068716416d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39538465088573727d, y: 0.4802588618017497d), new NpgsqlTypes.NpgsqlPoint(x: 0.12545062694048636d, y: 0.10722746774195047d), new NpgsqlTypes.NpgsqlPoint(x: 0.8444480551216127d, y: 0.999214267654266d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41998449263707804d, y: 0.25879947920853674d), new NpgsqlTypes.NpgsqlPoint(x: 0.5286013460512718d, y: 0.1633745727250231d), new NpgsqlTypes.NpgsqlPoint(x: 0.8502129525654243d, y: 0.14045521186766874d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.128526279071979d, y: 0.084970937767326d), new NpgsqlTypes.NpgsqlPoint(x: 0.3154273627621028d, y: 0.03539693862611604d), new NpgsqlTypes.NpgsqlPoint(x: 0.4332628930125467d, y: 0.5124478006301944d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7718599621843056d, y: 0.4657672389129853d), new NpgsqlTypes.NpgsqlPoint(x: 0.6201803294106802d, y: 0.7393318276827141d), new NpgsqlTypes.NpgsqlPoint(x: 0.8338976960014587d, y: 0.5949271067117284d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26389692857369107d, y: 0.5868647553257497d), new NpgsqlTypes.NpgsqlPoint(x: 0.773704278095399d, y: 0.3343702627777898d), new NpgsqlTypes.NpgsqlPoint(x: 0.43777448122014484d, y: 0.37867307480966406d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.027501860270151668d, y: 0.9462852985174087d), new NpgsqlTypes.NpgsqlPoint(x: 0.05471149997534974d, y: 0.958531254211765d), new NpgsqlTypes.NpgsqlPoint(x: 0.3264093696428201d, y: 0.6383841989387543d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44406220146014275d, y: 0.8743121269215663d), new NpgsqlTypes.NpgsqlPoint(x: 0.3548141962321899d, y: 0.8180457223935831d), new NpgsqlTypes.NpgsqlPoint(x: 0.3079252173085666d, y: 0.7926273515087363d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46096470627753416d, y: 0.6137647008572701d), new NpgsqlTypes.NpgsqlPoint(x: 0.49843982226648d, y: 0.7845178056637198d), new NpgsqlTypes.NpgsqlPoint(x: 0.6881586846220299d, y: 0.1504309515127491d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7745613793719238d, y: 0.08687466041310554d), new NpgsqlTypes.NpgsqlPoint(x: 0.3956637073314365d, y: 0.3208291112744035d), new NpgsqlTypes.NpgsqlPoint(x: 0.6181685822800517d, y: 0.4659641788579525d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5957524026046661d, y: 0.23933805274597797d), new NpgsqlTypes.NpgsqlPoint(x: 0.2745544197748122d, y: 0.5288015951227122d), new NpgsqlTypes.NpgsqlPoint(x: 0.8661005317870705d, y: 0.5513832716129821d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3878410413240563d, y: 0.4502225678050674d), new NpgsqlTypes.NpgsqlPoint(x: 0.30683524907976645d, y: 0.18183039257449707d), new NpgsqlTypes.NpgsqlPoint(x: 0.29858518904085296d, y: 0.8391148038625856d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6839567191841549d, y: 0.2924263272766079d), new NpgsqlTypes.NpgsqlPoint(x: 0.21480634840380175d, y: 0.3537387690776127d), new NpgsqlTypes.NpgsqlPoint(x: 0.517971741664828d, y: 0.10628163141715985d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39700987421399336d, y: 0.7612597840508486d), new NpgsqlTypes.NpgsqlPoint(x: 0.01768794254172279d, y: 0.19893031073617207d), new NpgsqlTypes.NpgsqlPoint(x: 0.5878392758392154d, y: 0.314633478329443d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5985209752587224d, y: 0.03269308928697523d), new NpgsqlTypes.NpgsqlPoint(x: 0.3759782833071119d, y: 0.09247460703723576d), new NpgsqlTypes.NpgsqlPoint(x: 0.6217332215493414d, y: 0.9441720086489245d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4164120936106174d, y: 0.9795629059653143d), new NpgsqlTypes.NpgsqlPoint(x: 0.7279143749842766d, y: 0.4688762200984371d), new NpgsqlTypes.NpgsqlPoint(x: 0.8332183445053044d, y: 0.11477271393018318d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3383126428640728d, y: 0.2601744622182669d), new NpgsqlTypes.NpgsqlPoint(x: 0.933100556890011d, y: 0.5289195070171169d), new NpgsqlTypes.NpgsqlPoint(x: 0.312972746093539d, y: 0.7454293567387182d)), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35375042103858156d, y: 0.10971195490328423d), new NpgsqlTypes.NpgsqlPoint(x: 0.8097419203871913d, y: 0.9694648186293368d), new NpgsqlTypes.NpgsqlPoint(x: 0.09480310246808388d, y: 0.06569378229081635d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2573527965449601d, y: 0.9819309633227958d), new NpgsqlTypes.NpgsqlPoint(x: 0.8732973027691783d, y: 0.04339854030216017d), new NpgsqlTypes.NpgsqlPoint(x: 0.5850150415076577d, y: 0.2748273726596252d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9570037111334638d, y: 0.8415601740835944d), new NpgsqlTypes.NpgsqlPoint(x: 0.32779273912179674d, y: 0.4594122491125445d), new NpgsqlTypes.NpgsqlPoint(x: 0.7439467631347413d, y: 0.5931275023761423d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7170162056691276d, y: 0.17624598897528299d), new NpgsqlTypes.NpgsqlPoint(x: 0.3700538778806598d, y: 0.16345761504902512d), new NpgsqlTypes.NpgsqlPoint(x: 0.20676750870309735d, y: 0.6733193499275423d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9322873447997362d, y: 0.3932334952590103d), new NpgsqlTypes.NpgsqlPoint(x: 0.18005230830527574d, y: 0.9858905564175643d), new NpgsqlTypes.NpgsqlPoint(x: 0.1400762728056304d, y: 0.9364757949455847d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20422934076477495d, y: 0.27958145753634145d), new NpgsqlTypes.NpgsqlPoint(x: 0.529266372366841d, y: 0.3548677747873208d), new NpgsqlTypes.NpgsqlPoint(x: 0.2049174600626953d, y: 0.48997943055795345d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5360686628034733d, y: 0.6458105569469257d), new NpgsqlTypes.NpgsqlPoint(x: 0.07754341821696609d, y: 0.12168402602920492d), new NpgsqlTypes.NpgsqlPoint(x: 0.5045209835578573d, y: 0.9404889238168135d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08691385387651185d, y: 0.2655215054011544d), new NpgsqlTypes.NpgsqlPoint(x: 0.2147186125366337d, y: 0.68521026656976d), new NpgsqlTypes.NpgsqlPoint(x: 0.7899832748657554d, y: 0.40578467138327556d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05659466095735999d, y: 0.07768606277543078d), new NpgsqlTypes.NpgsqlPoint(x: 0.3060139734385037d, y: 0.26750240519279456d), new NpgsqlTypes.NpgsqlPoint(x: 0.6078122706804153d, y: 0.6233094762382335d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18951770981027038d, y: 0.5322641363411049d), new NpgsqlTypes.NpgsqlPoint(x: 0.8494776634441328d, y: 0.4265574352288882d), new NpgsqlTypes.NpgsqlPoint(x: 0.9606906722626596d, y: 0.10448376793386271d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39284761017011927d, y: 0.6194375325799261d), new NpgsqlTypes.NpgsqlPoint(x: 0.5866934301198462d, y: 0.20403089345550574d), new NpgsqlTypes.NpgsqlPoint(x: 0.22331729129881783d, y: 0.8235681195039994d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3724137712268548d, y: 0.6591692186403882d), new NpgsqlTypes.NpgsqlPoint(x: 0.13195043019908625d, y: 0.6831843340319275d), new NpgsqlTypes.NpgsqlPoint(x: 0.6740483426474891d, y: 0.7969156589031499d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9303869915878991d, y: 0.3779766170901241d), new NpgsqlTypes.NpgsqlPoint(x: 0.5416368857302039d, y: 0.45468734268640365d), new NpgsqlTypes.NpgsqlPoint(x: 0.23599234229376687d, y: 0.3820826390385521d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6560746001584371d, y: 0.5348691795451516d), new NpgsqlTypes.NpgsqlPoint(x: 0.8125061189157737d, y: 0.5702954312148095d), new NpgsqlTypes.NpgsqlPoint(x: 0.5712238925571707d, y: 0.8104721493464588d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.692875213321609d, y: 0.8100624278579149d), new NpgsqlTypes.NpgsqlPoint(x: 0.15608367937725853d, y: 0.6723686767027781d), new NpgsqlTypes.NpgsqlPoint(x: 0.07001325591180096d, y: 0.14346298234375954d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9151808650807103d, y: 0.7867101229042113d), new NpgsqlTypes.NpgsqlPoint(x: 0.8673050853730897d, y: 0.5536649068212081d), new NpgsqlTypes.NpgsqlPoint(x: 0.55615629433613d, y: 0.3449010595952806d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15943682983062846d, y: 0.6697755211782452d), new NpgsqlTypes.NpgsqlPoint(x: 0.11060785489232794d, y: 0.4584818703490696d), new NpgsqlTypes.NpgsqlPoint(x: 0.4316575452263349d, y: 0.6383630610220988d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7997580402479165d, y: 0.412395846040739d), new NpgsqlTypes.NpgsqlPoint(x: 0.48157982742981553d, y: 0.5196954387637021d), new NpgsqlTypes.NpgsqlPoint(x: 0.916540713392521d, y: 0.3570268669557233d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7866990542022593d, y: 0.11851116580684473d), new NpgsqlTypes.NpgsqlPoint(x: 0.6706374212475172d, y: 0.8232840810833514d), new NpgsqlTypes.NpgsqlPoint(x: 0.6970448380600363d, y: 0.9681119723139723d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7980306175968995d, y: 0.30969153687563056d), new NpgsqlTypes.NpgsqlPoint(x: 0.23484979467131706d, y: 0.1516346490923638d), new NpgsqlTypes.NpgsqlPoint(x: 0.6025943629720724d, y: 0.417521114449494d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8005943931308981d, y: 0.014452364168139331d), new NpgsqlTypes.NpgsqlPoint(x: 0.7023963735836914d, y: 0.3267327585654405d), new NpgsqlTypes.NpgsqlPoint(x: 0.676435304819271d, y: 0.4744623379271188d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7694594427544504d, y: 0.8060742213370321d), new NpgsqlTypes.NpgsqlPoint(x: 0.3343772999008122d, y: 0.04908077784805587d), new NpgsqlTypes.NpgsqlPoint(x: 0.8483743167161376d, y: 0.9590419531829558d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4375141561018113d, y: 0.858088633914728d), new NpgsqlTypes.NpgsqlPoint(x: 0.6292985565816099d, y: 0.9916036144098397d), new NpgsqlTypes.NpgsqlPoint(x: 0.6464784607303914d, y: 0.661053177123606d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5264333210285534d, y: 0.18403569831683808d), new NpgsqlTypes.NpgsqlPoint(x: 0.5595081046464734d, y: 0.16726420768892425d), new NpgsqlTypes.NpgsqlPoint(x: 0.9212822196453583d, y: 0.9290131901943541d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5610300559860755d, y: 0.026439552879579775d), new NpgsqlTypes.NpgsqlPoint(x: 0.2060274407562337d, y: 0.1480885381447017d), new NpgsqlTypes.NpgsqlPoint(x: 0.1463350276968971d, y: 0.456070101302401d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11028220887216389d, y: 0.5342505339073136d), new NpgsqlTypes.NpgsqlPoint(x: 0.5261086807713815d, y: 0.3754056523355477d), new NpgsqlTypes.NpgsqlPoint(x: 0.38572605002142624d, y: 0.352074350110131d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8771879393035945d, y: 0.7348801910219132d), new NpgsqlTypes.NpgsqlPoint(x: 0.23484070032298465d, y: 0.8128390835931137d), new NpgsqlTypes.NpgsqlPoint(x: 0.8463879730033796d, y: 0.7849495837306941d)), }, }, },
    ModelInner = new NpgsqlPathpathMMArrayD3E1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22670911784706638d, y: 0.47374053318802123d), new NpgsqlTypes.NpgsqlPoint(x: 0.9635843084996129d, y: 0.769325961124952d), new NpgsqlTypes.NpgsqlPoint(x: 0.041490169771243646d, y: 0.8097477963459995d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16656708345441118d, y: 0.43661437159809313d), new NpgsqlTypes.NpgsqlPoint(x: 0.30812065925526255d, y: 0.8560236062771645d), new NpgsqlTypes.NpgsqlPoint(x: 0.08188895817474218d, y: 0.10214973801804361d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4743879739713188d, y: 0.7328208447506174d), new NpgsqlTypes.NpgsqlPoint(x: 0.6600212614718082d, y: 0.8972634078959801d), new NpgsqlTypes.NpgsqlPoint(x: 0.9334758566908047d, y: 0.20833016586880737d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4990124593134392d, y: 0.30673342119512503d), new NpgsqlTypes.NpgsqlPoint(x: 0.8578317073161629d, y: 0.024357725410200204d), new NpgsqlTypes.NpgsqlPoint(x: 0.7790051028185206d, y: 0.4297687578921414d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.927589305291315d, y: 0.09072015364593733d), new NpgsqlTypes.NpgsqlPoint(x: 0.6567004123677027d, y: 0.7030474444143326d), new NpgsqlTypes.NpgsqlPoint(x: 0.01888736230081678d, y: 0.2549331962137107d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8297084233428086d, y: 0.1003714972269788d), new NpgsqlTypes.NpgsqlPoint(x: 0.9128103444231337d, y: 0.23702758082620012d), new NpgsqlTypes.NpgsqlPoint(x: 0.8962211643767838d, y: 0.036906192477386024d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01540968192194414d, y: 0.23153158087273829d), new NpgsqlTypes.NpgsqlPoint(x: 0.0802034000036943d, y: 0.737547954735072d), new NpgsqlTypes.NpgsqlPoint(x: 0.14102477366615684d, y: 0.22161967855363074d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09949054188023498d, y: 0.6093919500841359d), new NpgsqlTypes.NpgsqlPoint(x: 0.9282025444384762d, y: 0.0996597832475371d), new NpgsqlTypes.NpgsqlPoint(x: 0.4649963048167718d, y: 0.7559615510056354d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6019304747703532d, y: 0.09161636614905577d), new NpgsqlTypes.NpgsqlPoint(x: 0.18697530845607901d, y: 0.8796724560028994d), new NpgsqlTypes.NpgsqlPoint(x: 0.0680455103232891d, y: 0.43575047841484926d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11977356192361588d, y: 0.7068036922247264d), new NpgsqlTypes.NpgsqlPoint(x: 0.05841913534145371d, y: 0.1377495478939229d), new NpgsqlTypes.NpgsqlPoint(x: 0.19014400498717732d, y: 0.5483888782521624d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6768784236502935d, y: 0.2774315878433743d), new NpgsqlTypes.NpgsqlPoint(x: 0.3775121502058528d, y: 0.8715773117812512d), new NpgsqlTypes.NpgsqlPoint(x: 0.3309021628332839d, y: 0.11595972749640615d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5641301707769313d, y: 0.27022575910508195d), new NpgsqlTypes.NpgsqlPoint(x: 0.6741570174326396d, y: 0.5825808899354996d), new NpgsqlTypes.NpgsqlPoint(x: 0.021929768712298237d, y: 0.5739394090040967d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3773431534942914d, y: 0.8406013049830354d), new NpgsqlTypes.NpgsqlPoint(x: 0.7447151159404392d, y: 0.3070008207316791d), new NpgsqlTypes.NpgsqlPoint(x: 0.1448056582121754d, y: 0.6318832829844573d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3955725338734938d, y: 0.665697386470032d), new NpgsqlTypes.NpgsqlPoint(x: 0.6167167651695764d, y: 0.6949306571661179d), new NpgsqlTypes.NpgsqlPoint(x: 0.561615948398043d, y: 0.5709895443814051d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21445115530175218d, y: 0.021888189482426545d), new NpgsqlTypes.NpgsqlPoint(x: 0.5956412695700644d, y: 0.9403463182867026d), new NpgsqlTypes.NpgsqlPoint(x: 0.009236502424572746d, y: 0.6985582790721581d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3981086401869611d, y: 0.01633430043671935d), new NpgsqlTypes.NpgsqlPoint(x: 0.5934941526080315d, y: 0.5087422611828124d), new NpgsqlTypes.NpgsqlPoint(x: 0.3048570094489065d, y: 0.29620359796345486d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.547146792492422d, y: 0.8844742344145501d), new NpgsqlTypes.NpgsqlPoint(x: 0.5036518808697052d, y: 0.001768111464962252d), new NpgsqlTypes.NpgsqlPoint(x: 0.8199362065737298d, y: 0.47682995010550344d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.036186707586422395d, y: 0.541490946607826d), new NpgsqlTypes.NpgsqlPoint(x: 0.54951921341237d, y: 0.058741595926860124d), new NpgsqlTypes.NpgsqlPoint(x: 0.5601518511380879d, y: 0.8957296939641584d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10723146858988453d, y: 0.3744215886482646d), new NpgsqlTypes.NpgsqlPoint(x: 0.9406762362540974d, y: 0.016126888075158274d), new NpgsqlTypes.NpgsqlPoint(x: 0.19159933244275051d, y: 0.2494072243486375d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17991526677848024d, y: 0.6093787795355757d), new NpgsqlTypes.NpgsqlPoint(x: 0.6951268727616519d, y: 0.5086075700545343d), new NpgsqlTypes.NpgsqlPoint(x: 0.24011355894247777d, y: 0.7675917502593544d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1275439180906247d, y: 0.13458135080056277d), new NpgsqlTypes.NpgsqlPoint(x: 0.9301987379814124d, y: 0.4737072157703007d), new NpgsqlTypes.NpgsqlPoint(x: 0.5463752435634287d, y: 0.023868893813733028d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39935196701045406d, y: 0.3592607280867792d), new NpgsqlTypes.NpgsqlPoint(x: 0.36113711426321427d, y: 0.015047798978405802d), new NpgsqlTypes.NpgsqlPoint(x: 0.7729330352009466d, y: 0.7808752933342055d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014402041676768729d, y: 0.047630626749512905d), new NpgsqlTypes.NpgsqlPoint(x: 0.8095945566981992d, y: 0.189185984516817d), new NpgsqlTypes.NpgsqlPoint(x: 0.8398859653172837d, y: 0.6935805273257643d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7250554719203859d, y: 0.25369008617155286d), new NpgsqlTypes.NpgsqlPoint(x: 0.35140992318534603d, y: 0.6996462836580905d), new NpgsqlTypes.NpgsqlPoint(x: 0.15342704854360023d, y: 0.3682549915210209d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5783113822590803d, y: 0.34359113834238386d), new NpgsqlTypes.NpgsqlPoint(x: 0.6543151950971529d, y: 0.15033987538402904d), new NpgsqlTypes.NpgsqlPoint(x: 0.8948578735466443d, y: 0.3562214338993466d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7540584773832986d, y: 0.24838894925314436d), new NpgsqlTypes.NpgsqlPoint(x: 0.23293674174986712d, y: 0.23916760867792353d), new NpgsqlTypes.NpgsqlPoint(x: 0.1678102197332232d, y: 0.9957241456231074d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5322602615399311d, y: 0.12605359861077647d), new NpgsqlTypes.NpgsqlPoint(x: 0.10976535723332781d, y: 0.7951486802318528d), new NpgsqlTypes.NpgsqlPoint(x: 0.9675445027231755d, y: 0.5386120722774264d)), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6391676636001951d, y: 0.8369078097085201d), new NpgsqlTypes.NpgsqlPoint(x: 0.018220571000608476d, y: 0.5581549981247567d), new NpgsqlTypes.NpgsqlPoint(x: 0.6706728812009002d, y: 0.4752086926125856d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6288576101285166d, y: 0.2610334849681004d), new NpgsqlTypes.NpgsqlPoint(x: 0.6637047672446165d, y: 0.620830584581775d), new NpgsqlTypes.NpgsqlPoint(x: 0.1995110550506295d, y: 0.39005744640178586d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3595479090375012d, y: 0.9872918257057435d), new NpgsqlTypes.NpgsqlPoint(x: 0.3952151763606325d, y: 0.1922353234827655d), new NpgsqlTypes.NpgsqlPoint(x: 0.5143142814879939d, y: 0.5251127136050423d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6679716140097345d, y: 0.7768029022953821d), new NpgsqlTypes.NpgsqlPoint(x: 0.011140164407623776d, y: 0.6388707488766922d), new NpgsqlTypes.NpgsqlPoint(x: 0.35242995480847417d, y: 0.009583385262191157d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6773992104899711d, y: 0.6029006696111264d), new NpgsqlTypes.NpgsqlPoint(x: 0.21773607813564122d, y: 0.22777275863319335d), new NpgsqlTypes.NpgsqlPoint(x: 0.07808149237345174d, y: 0.7266678231452202d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19652025499264458d, y: 0.9872397062630944d), new NpgsqlTypes.NpgsqlPoint(x: 0.005648590109390561d, y: 0.3279600335125866d), new NpgsqlTypes.NpgsqlPoint(x: 0.5146483353697554d, y: 0.688318752894989d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4171250502578294d, y: 0.27346260864370875d), new NpgsqlTypes.NpgsqlPoint(x: 0.2933962584860512d, y: 0.7048822744147322d), new NpgsqlTypes.NpgsqlPoint(x: 0.3277863647605388d, y: 0.9114097551671648d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.332724525029239d, y: 0.7269326118821946d), new NpgsqlTypes.NpgsqlPoint(x: 0.158286972638228d, y: 0.42076030372079576d), new NpgsqlTypes.NpgsqlPoint(x: 0.5020113334073528d, y: 0.6254329532679809d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3958931512179734d, y: 0.30182921456216805d), new NpgsqlTypes.NpgsqlPoint(x: 0.3319256120725519d, y: 0.22030684673709244d), new NpgsqlTypes.NpgsqlPoint(x: 0.3717409787667777d, y: 0.05712519627908097d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007617837642522773d, y: 0.49841265552248737d), new NpgsqlTypes.NpgsqlPoint(x: 0.4385713245352093d, y: 0.3824035926340643d), new NpgsqlTypes.NpgsqlPoint(x: 0.29731269874019217d, y: 0.19344157784662053d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16160860131100585d, y: 0.654694586785635d), new NpgsqlTypes.NpgsqlPoint(x: 0.3769800454578818d, y: 0.34860381797123985d), new NpgsqlTypes.NpgsqlPoint(x: 0.5622916845390274d, y: 0.2150773282713604d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18460871900853837d, y: 0.25633033325602916d), new NpgsqlTypes.NpgsqlPoint(x: 0.6341107422098086d, y: 0.11570176018179568d), new NpgsqlTypes.NpgsqlPoint(x: 0.3839329104466521d, y: 0.8052632379408788d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6521835219683527d, y: 0.6695425279612733d), new NpgsqlTypes.NpgsqlPoint(x: 0.6001509334046339d, y: 0.5841156834174206d), new NpgsqlTypes.NpgsqlPoint(x: 0.5938593650276495d, y: 0.10891880569437218d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.058968152986831d, y: 0.5784413487108926d), new NpgsqlTypes.NpgsqlPoint(x: 0.41313067309298745d, y: 0.7186866560490957d), new NpgsqlTypes.NpgsqlPoint(x: 0.45694636872254857d, y: 0.4937102845710424d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25048575927156813d, y: 0.360854247647031d), new NpgsqlTypes.NpgsqlPoint(x: 0.5285955770598068d, y: 0.30533731153136523d), new NpgsqlTypes.NpgsqlPoint(x: 0.09223814357183047d, y: 0.32311953102983937d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35714049721243213d, y: 0.6618748189132936d), new NpgsqlTypes.NpgsqlPoint(x: 0.25381929519755864d, y: 0.3289503711530475d), new NpgsqlTypes.NpgsqlPoint(x: 0.26236883432221814d, y: 0.7440390778173893d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37317268530898506d, y: 0.6428702140867226d), new NpgsqlTypes.NpgsqlPoint(x: 0.2521261028041849d, y: 0.46576583164734375d), new NpgsqlTypes.NpgsqlPoint(x: 0.19639524801940533d, y: 0.9392198219479917d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17393516820024013d, y: 0.5134266274833095d), new NpgsqlTypes.NpgsqlPoint(x: 0.6700979868285045d, y: 0.14246263188687214d), new NpgsqlTypes.NpgsqlPoint(x: 0.54212415633087d, y: 0.6228247813393296d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10356796835739213d, y: 0.5953782317588984d), new NpgsqlTypes.NpgsqlPoint(x: 0.4251872184484986d, y: 0.7506773594716526d), new NpgsqlTypes.NpgsqlPoint(x: 0.3298649520201864d, y: 0.18491219115194468d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1375628358751152d, y: 0.016797504410115405d), new NpgsqlTypes.NpgsqlPoint(x: 0.46003419252667954d, y: 0.47044295193550556d), new NpgsqlTypes.NpgsqlPoint(x: 0.09707034930195468d, y: 0.23912038705305227d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6147909238389121d, y: 0.30023158029385866d), new NpgsqlTypes.NpgsqlPoint(x: 0.001967876413623948d, y: 0.49254693450657583d), new NpgsqlTypes.NpgsqlPoint(x: 0.6031687157432375d, y: 0.25599402420782136d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8548222686552089d, y: 0.5151816766487124d), new NpgsqlTypes.NpgsqlPoint(x: 0.49526105974845824d, y: 0.9622221801352985d), new NpgsqlTypes.NpgsqlPoint(x: 0.2985361465798856d, y: 0.6584724570294489d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6416312555208132d, y: 0.6618099054629185d), new NpgsqlTypes.NpgsqlPoint(x: 0.5255759981695176d, y: 0.42786103679619625d), new NpgsqlTypes.NpgsqlPoint(x: 0.44987140509932977d, y: 0.16058806306437d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4035185683490339d, y: 0.818973016776765d), new NpgsqlTypes.NpgsqlPoint(x: 0.25419055251925915d, y: 0.9401650827960434d), new NpgsqlTypes.NpgsqlPoint(x: 0.9780009017857956d, y: 0.22106531105184102d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45273362734790334d, y: 0.606978292435021d), new NpgsqlTypes.NpgsqlPoint(x: 0.6061453133922536d, y: 0.7222518227573166d), new NpgsqlTypes.NpgsqlPoint(x: 0.2829912208509655d, y: 0.9903869476468792d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2985536316785845d, y: 0.5349602321213321d), new NpgsqlTypes.NpgsqlPoint(x: 0.3060967968551256d, y: 0.887937551443623d), new NpgsqlTypes.NpgsqlPoint(x: 0.16207715769835518d, y: 0.0675589019604369d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2479272762357514d, y: 0.5455596989436349d), new NpgsqlTypes.NpgsqlPoint(x: 0.3095150036928511d, y: 0.5133669479362996d), new NpgsqlTypes.NpgsqlPoint(x: 0.147170564535418d, y: 0.378196624665986d)), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38713443575994144d, y: 0.4335449987521163d), new NpgsqlTypes.NpgsqlPoint(x: 0.5642527426273194d, y: 0.7587321891417723d), new NpgsqlTypes.NpgsqlPoint(x: 0.1769319910171061d, y: 0.8172212339387842d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3300518500371947d, y: 0.07574959932119785d), new NpgsqlTypes.NpgsqlPoint(x: 0.10201859118848178d, y: 0.40333290073305117d), new NpgsqlTypes.NpgsqlPoint(x: 0.4782209830361752d, y: 0.17729231714358862d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3261005019229166d, y: 0.863174640369725d), new NpgsqlTypes.NpgsqlPoint(x: 0.8463350156709473d, y: 0.6707082985178388d), new NpgsqlTypes.NpgsqlPoint(x: 0.5821599965656467d, y: 0.18003345412426364d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40702523078984787d, y: 0.7316070287483243d), new NpgsqlTypes.NpgsqlPoint(x: 0.24991805951334667d, y: 0.8745819660003558d), new NpgsqlTypes.NpgsqlPoint(x: 0.5810678669798516d, y: 0.07141837507216542d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5900730472026916d, y: 0.2977826627731346d), new NpgsqlTypes.NpgsqlPoint(x: 0.6151430916248003d, y: 0.47254311515616876d), new NpgsqlTypes.NpgsqlPoint(x: 0.4661995126651378d, y: 0.2998962717931788d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38639485746638d, y: 0.19742820549593154d), new NpgsqlTypes.NpgsqlPoint(x: 0.763771364916271d, y: 0.4643315508834832d), new NpgsqlTypes.NpgsqlPoint(x: 0.32790290084593143d, y: 0.5512943548903182d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6071480117732001d, y: 0.5676485579019525d), new NpgsqlTypes.NpgsqlPoint(x: 0.9147419688473799d, y: 0.24546254167287285d), new NpgsqlTypes.NpgsqlPoint(x: 0.9548709369987854d, y: 0.03370261641162842d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.698946846722404d, y: 0.3866327671160602d), new NpgsqlTypes.NpgsqlPoint(x: 0.4167882147221099d, y: 0.039052259046433724d), new NpgsqlTypes.NpgsqlPoint(x: 0.43286614470395346d, y: 0.9989880060901023d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8421501447935746d, y: 0.515025554348521d), new NpgsqlTypes.NpgsqlPoint(x: 0.017680930236692705d, y: 0.6235031969747418d), new NpgsqlTypes.NpgsqlPoint(x: 0.003853202994796745d, y: 0.5503091800060333d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33381984079296967d, y: 0.9105293761555974d), new NpgsqlTypes.NpgsqlPoint(x: 0.07128136882962222d, y: 0.2365464980275046d), new NpgsqlTypes.NpgsqlPoint(x: 0.2815282990574852d, y: 0.8472002577565587d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3261220043566786d, y: 0.2943893118578472d), new NpgsqlTypes.NpgsqlPoint(x: 0.08592434331143828d, y: 0.17624371504815572d), new NpgsqlTypes.NpgsqlPoint(x: 0.20382989922326444d, y: 0.17621317739521325d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7533140255882117d, y: 0.9138933881386775d), new NpgsqlTypes.NpgsqlPoint(x: 0.7051455079903727d, y: 0.31205770396125265d), new NpgsqlTypes.NpgsqlPoint(x: 0.8823017550330764d, y: 0.8721640590177178d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25649365773520494d, y: 0.5450965870911089d), new NpgsqlTypes.NpgsqlPoint(x: 0.11239486631310547d, y: 0.12029269138877463d), new NpgsqlTypes.NpgsqlPoint(x: 0.6863994932822667d, y: 0.18662594453344272d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30004811126052355d, y: 0.21840467513915662d), new NpgsqlTypes.NpgsqlPoint(x: 0.841205073820968d, y: 0.7466194164005829d), new NpgsqlTypes.NpgsqlPoint(x: 0.7031498995869607d, y: 0.667182402863837d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7364764899620743d, y: 0.7078125983234342d), new NpgsqlTypes.NpgsqlPoint(x: 0.23216450969415725d, y: 0.015731059446091877d), new NpgsqlTypes.NpgsqlPoint(x: 0.07217954989178699d, y: 0.569419286126838d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9981966971134909d, y: 0.815219458880346d), new NpgsqlTypes.NpgsqlPoint(x: 0.38484358862798584d, y: 0.3371141077849332d), new NpgsqlTypes.NpgsqlPoint(x: 0.6160532089231979d, y: 0.23166022908655415d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8763979197922017d, y: 0.058879148874655285d), new NpgsqlTypes.NpgsqlPoint(x: 0.25298775020219444d, y: 0.4029258289971578d), new NpgsqlTypes.NpgsqlPoint(x: 0.6999408491696001d, y: 0.7690728428938697d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7396292222336156d, y: 0.18059515790567338d), new NpgsqlTypes.NpgsqlPoint(x: 0.6933366802913901d, y: 0.44454294807669525d), new NpgsqlTypes.NpgsqlPoint(x: 0.6201371951295944d, y: 0.617468155840311d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05670473056963965d, y: 0.4664102056737802d), new NpgsqlTypes.NpgsqlPoint(x: 0.26308168908008855d, y: 0.994625971722573d), new NpgsqlTypes.NpgsqlPoint(x: 0.4897274546696111d, y: 0.20616112743303272d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09572396998640587d, y: 0.659362126582108d), new NpgsqlTypes.NpgsqlPoint(x: 0.6418352567383357d, y: 0.3641203011805486d), new NpgsqlTypes.NpgsqlPoint(x: 0.5005719171077291d, y: 0.7336190998943757d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.835160391534869d, y: 0.5988236586386742d), new NpgsqlTypes.NpgsqlPoint(x: 0.5110892408826271d, y: 0.3061897591446474d), new NpgsqlTypes.NpgsqlPoint(x: 0.3720289556218187d, y: 0.6723398361649983d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.054811138050082975d, y: 0.1899999809449776d), new NpgsqlTypes.NpgsqlPoint(x: 0.7008715185128144d, y: 0.36913999807878883d), new NpgsqlTypes.NpgsqlPoint(x: 0.08168786789916838d, y: 0.3942224354306806d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01819645465575359d, y: 0.8510313138803404d), new NpgsqlTypes.NpgsqlPoint(x: 0.18121152338404356d, y: 0.7168357668563498d), new NpgsqlTypes.NpgsqlPoint(x: 0.9699760678386472d, y: 0.9945728744242534d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8785874260326211d, y: 0.9185678934108528d), new NpgsqlTypes.NpgsqlPoint(x: 0.7627215499775548d, y: 0.7112966162856414d), new NpgsqlTypes.NpgsqlPoint(x: 0.3224216802193449d, y: 0.374163814653362d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7610600003144059d, y: 0.20728252544257741d), new NpgsqlTypes.NpgsqlPoint(x: 0.8580593017059537d, y: 0.5057143510732578d), new NpgsqlTypes.NpgsqlPoint(x: 0.1814067109427766d, y: 0.2998529721839198d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8332213944136782d, y: 0.3610208839801171d), new NpgsqlTypes.NpgsqlPoint(x: 0.04414803623636698d, y: 0.6319056278585172d), new NpgsqlTypes.NpgsqlPoint(x: 0.48839085438843277d, y: 0.39324269128511735d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22204966261981196d, y: 0.9027941953729506d), new NpgsqlTypes.NpgsqlPoint(x: 0.14362861398458227d, y: 0.45284475444488725d), new NpgsqlTypes.NpgsqlPoint(x: 0.19583781436691827d, y: 0.08547015436198535d)), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1941056554199021d, y: 0.7651391365698865d), new NpgsqlTypes.NpgsqlPoint(x: 0.3638675552478211d, y: 0.35592069605496945d), new NpgsqlTypes.NpgsqlPoint(x: 0.9077304909516144d, y: 0.5066500721311189d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.055359553093893066d, y: 0.44447477841005145d), new NpgsqlTypes.NpgsqlPoint(x: 0.848559518419379d, y: 0.38213628415975975d), new NpgsqlTypes.NpgsqlPoint(x: 0.03866650095552604d, y: 0.6412990451529199d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3423455341463081d, y: 0.21187499954704525d), new NpgsqlTypes.NpgsqlPoint(x: 0.8851663632633714d, y: 0.8690738928375381d), new NpgsqlTypes.NpgsqlPoint(x: 0.3016819349027411d, y: 0.10399769389320246d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7315244022673179d, y: 0.28544760524247614d), new NpgsqlTypes.NpgsqlPoint(x: 0.3174659302515179d, y: 0.9900785891712597d), new NpgsqlTypes.NpgsqlPoint(x: 0.7864510102427325d, y: 0.8875719013187607d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10567493334981903d, y: 0.7086008917669161d), new NpgsqlTypes.NpgsqlPoint(x: 0.9124904678045418d, y: 0.7800848086029414d), new NpgsqlTypes.NpgsqlPoint(x: 0.981130914709665d, y: 0.7476245378919973d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2698862152539886d, y: 0.9201045781676175d), new NpgsqlTypes.NpgsqlPoint(x: 0.5856738403806475d, y: 0.49178733996277624d), new NpgsqlTypes.NpgsqlPoint(x: 0.10907640354107873d, y: 0.8633301538957017d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7233906783059347d, y: 0.2258305221193716d), new NpgsqlTypes.NpgsqlPoint(x: 0.9140011867133615d, y: 0.8272350290667901d), new NpgsqlTypes.NpgsqlPoint(x: 0.3904166576459335d, y: 0.3886040626921071d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7213322395644858d, y: 0.9774608149976161d), new NpgsqlTypes.NpgsqlPoint(x: 0.8518137239746307d, y: 0.5873560506502092d), new NpgsqlTypes.NpgsqlPoint(x: 0.6787101690865455d, y: 0.26020627261414564d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5695842699858608d, y: 0.7923632862898877d), new NpgsqlTypes.NpgsqlPoint(x: 0.0711706118611154d, y: 0.34689885304943d), new NpgsqlTypes.NpgsqlPoint(x: 0.26064791104267804d, y: 0.11481136577345319d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5507539761250178d, y: 0.01737115551340529d), new NpgsqlTypes.NpgsqlPoint(x: 0.04168945318518125d, y: 0.962500432200264d), new NpgsqlTypes.NpgsqlPoint(x: 0.0101680735200812d, y: 0.4091887119147215d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.408625169521434d, y: 0.7983959883091153d), new NpgsqlTypes.NpgsqlPoint(x: 0.9299147091550769d, y: 0.09858019582555322d), new NpgsqlTypes.NpgsqlPoint(x: 0.13090922121830872d, y: 0.7376220796712778d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19064835507105637d, y: 0.7820888276047235d), new NpgsqlTypes.NpgsqlPoint(x: 0.027156282553049027d, y: 0.9022694497755526d), new NpgsqlTypes.NpgsqlPoint(x: 0.9842939564566833d, y: 0.5237570620715417d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38566568018627034d, y: 0.5078894374923936d), new NpgsqlTypes.NpgsqlPoint(x: 0.4454161914301853d, y: 0.6674715128793418d), new NpgsqlTypes.NpgsqlPoint(x: 0.019273077080793066d, y: 0.6693288218585906d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1348268439243362d, y: 0.7402686837536803d), new NpgsqlTypes.NpgsqlPoint(x: 0.26422829647081947d, y: 0.9053815722863013d), new NpgsqlTypes.NpgsqlPoint(x: 0.92031580891311d, y: 0.4742073375367797d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6839528932714285d, y: 0.5010547353398979d), new NpgsqlTypes.NpgsqlPoint(x: 0.3795863420786114d, y: 0.8342125652329011d), new NpgsqlTypes.NpgsqlPoint(x: 0.5197712012131085d, y: 0.15174451047529747d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6935638973187799d, y: 0.8877537298185275d), new NpgsqlTypes.NpgsqlPoint(x: 0.445853904764274d, y: 0.46276598525809376d), new NpgsqlTypes.NpgsqlPoint(x: 0.5151720569575358d, y: 0.5567465926656573d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05617107750290595d, y: 0.7611415608569803d), new NpgsqlTypes.NpgsqlPoint(x: 0.8736683810246215d, y: 0.8890317363276466d), new NpgsqlTypes.NpgsqlPoint(x: 0.6760314193804046d, y: 0.5609437177210156d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23486254252416938d, y: 0.0523237126345838d), new NpgsqlTypes.NpgsqlPoint(x: 0.14867826852773025d, y: 0.9394927094864691d), new NpgsqlTypes.NpgsqlPoint(x: 0.49174681882681626d, y: 0.4638606692263768d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9091210210689834d, y: 0.7909061329279194d), new NpgsqlTypes.NpgsqlPoint(x: 0.18781503230306795d, y: 0.9621488372481988d), new NpgsqlTypes.NpgsqlPoint(x: 0.1801489128327064d, y: 0.42075796199872084d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48092668272837025d, y: 0.5548761009521767d), new NpgsqlTypes.NpgsqlPoint(x: 0.8640202010930462d, y: 0.6306726365024051d), new NpgsqlTypes.NpgsqlPoint(x: 0.8895519215800238d, y: 0.6612414940037334d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5224914156568732d, y: 0.8785846553249594d), new NpgsqlTypes.NpgsqlPoint(x: 0.027021340170264585d, y: 0.22104250605048403d), new NpgsqlTypes.NpgsqlPoint(x: 0.3238191336294748d, y: 0.8120718538519521d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33447479730783125d, y: 0.24646160727543875d), new NpgsqlTypes.NpgsqlPoint(x: 0.29221735900232026d, y: 0.9755295433710449d), new NpgsqlTypes.NpgsqlPoint(x: 0.17462261126091327d, y: 0.5753911855043559d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2758068407227634d, y: 0.12750779203941864d), new NpgsqlTypes.NpgsqlPoint(x: 0.9983866346814808d, y: 0.9913015763193894d), new NpgsqlTypes.NpgsqlPoint(x: 0.5876065367550017d, y: 0.34663997032045823d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21181976142196413d, y: 0.8557497637485664d), new NpgsqlTypes.NpgsqlPoint(x: 0.5721973512175741d, y: 0.4291248471013288d), new NpgsqlTypes.NpgsqlPoint(x: 0.8878687249286379d, y: 0.47083624373026256d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6765802560034219d, y: 0.8276216820533042d), new NpgsqlTypes.NpgsqlPoint(x: 0.24888241589325755d, y: 0.5618477200005348d), new NpgsqlTypes.NpgsqlPoint(x: 0.0009827321946819234d, y: 0.9127001220415945d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14160738769649484d, y: 0.3937339924026172d), new NpgsqlTypes.NpgsqlPoint(x: 0.13296984103652498d, y: 0.8591003332676793d), new NpgsqlTypes.NpgsqlPoint(x: 0.4494022436107986d, y: 0.16697223993154964d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2290881564425512d, y: 0.15200054958812792d), new NpgsqlTypes.NpgsqlPoint(x: 0.8994749344303389d, y: 0.6710387510607748d), new NpgsqlTypes.NpgsqlPoint(x: 0.4165591769415913d, y: 0.8941590043678912d)), }, }, },
    ModelInner = new NpgsqlPathpathMMArrayD3E1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2842506255611429d, y: 0.810355126392005d), new NpgsqlTypes.NpgsqlPoint(x: 0.879276703196381d, y: 0.30324063366799836d), new NpgsqlTypes.NpgsqlPoint(x: 0.32198828075463437d, y: 0.9125048285446546d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9400104163798462d, y: 0.13175156282363287d), new NpgsqlTypes.NpgsqlPoint(x: 0.14966573122668825d, y: 0.812199570734666d), new NpgsqlTypes.NpgsqlPoint(x: 0.8184792710947766d, y: 0.5766078157439456d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5941664603597947d, y: 0.42652875007369206d), new NpgsqlTypes.NpgsqlPoint(x: 0.5734330311723445d, y: 0.7276977760373501d), new NpgsqlTypes.NpgsqlPoint(x: 0.45316474822283204d, y: 0.018963829162287782d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12114556762214057d, y: 0.20711617233016844d), new NpgsqlTypes.NpgsqlPoint(x: 0.06494927112907567d, y: 0.5962802022716477d), new NpgsqlTypes.NpgsqlPoint(x: 0.486389055615005d, y: 0.010118408722898375d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5257726518814541d, y: 0.3138531808291162d), new NpgsqlTypes.NpgsqlPoint(x: 0.7205268922285677d, y: 0.6485319256403494d), new NpgsqlTypes.NpgsqlPoint(x: 0.16491490029187084d, y: 0.4047413396276537d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.052816580158644544d, y: 0.8028798574493741d), new NpgsqlTypes.NpgsqlPoint(x: 0.29397452145061653d, y: 0.2891827850973344d), new NpgsqlTypes.NpgsqlPoint(x: 0.9935945087392363d, y: 0.08595432346127507d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22507440407497137d, y: 0.7099322431672138d), new NpgsqlTypes.NpgsqlPoint(x: 0.34524525322715016d, y: 0.07471168415696072d), new NpgsqlTypes.NpgsqlPoint(x: 0.917873540817374d, y: 0.32709981047484404d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9521609818810456d, y: 0.5218962639975814d), new NpgsqlTypes.NpgsqlPoint(x: 0.07512070911054702d, y: 0.30100392359233097d), new NpgsqlTypes.NpgsqlPoint(x: 0.2297689660022254d, y: 0.2319965244794695d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8553486236532399d, y: 0.1180312990534218d), new NpgsqlTypes.NpgsqlPoint(x: 0.5539320624940723d, y: 0.4458745888612754d), new NpgsqlTypes.NpgsqlPoint(x: 0.06360288618913579d, y: 0.14032334442109584d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03384986593304862d, y: 0.9214001650869424d), new NpgsqlTypes.NpgsqlPoint(x: 0.5647647938671574d, y: 0.8065160082634109d), new NpgsqlTypes.NpgsqlPoint(x: 0.005954028433122427d, y: 0.4646947410480373d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4969931636346987d, y: 0.6886930967339485d), new NpgsqlTypes.NpgsqlPoint(x: 0.956706965654783d, y: 0.06346697455584138d), new NpgsqlTypes.NpgsqlPoint(x: 0.9675417724738651d, y: 0.5267764835665534d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42391331963089984d, y: 0.6850391133816632d), new NpgsqlTypes.NpgsqlPoint(x: 0.27240541250825234d, y: 0.6487237720990564d), new NpgsqlTypes.NpgsqlPoint(x: 0.6566406799145036d, y: 0.527148138924295d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7211654160580052d, y: 0.927380205037806d), new NpgsqlTypes.NpgsqlPoint(x: 0.9996761181940421d, y: 0.01809502002628871d), new NpgsqlTypes.NpgsqlPoint(x: 0.9009509415440281d, y: 0.25137170693401223d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9882016044505374d, y: 0.025190567130075503d), new NpgsqlTypes.NpgsqlPoint(x: 0.42606750241897473d, y: 0.9725614528332422d), new NpgsqlTypes.NpgsqlPoint(x: 0.1615898090292498d, y: 0.014042205638208238d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15451814204400827d, y: 0.5615200114321045d), new NpgsqlTypes.NpgsqlPoint(x: 0.4412514773039363d, y: 0.11490793715695724d), new NpgsqlTypes.NpgsqlPoint(x: 0.41623942028769667d, y: 0.5692644617544962d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5179936992505364d, y: 0.713548493432144d), new NpgsqlTypes.NpgsqlPoint(x: 0.9957117251955381d, y: 0.8756143436344176d), new NpgsqlTypes.NpgsqlPoint(x: 0.20738391794879785d, y: 0.5906965889747479d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7985829606582674d, y: 0.9214291894767852d), new NpgsqlTypes.NpgsqlPoint(x: 0.4631292736981061d, y: 0.8847774058413412d), new NpgsqlTypes.NpgsqlPoint(x: 0.05342957899378298d, y: 0.45471438453923063d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6937893625803296d, y: 0.7644390154527718d), new NpgsqlTypes.NpgsqlPoint(x: 0.45299210016001046d, y: 0.4322609507813855d), new NpgsqlTypes.NpgsqlPoint(x: 0.2481513233436312d, y: 0.08111291608925408d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8665127663366663d, y: 0.25505089926928104d), new NpgsqlTypes.NpgsqlPoint(x: 0.437430674554215d, y: 0.5438121367086073d), new NpgsqlTypes.NpgsqlPoint(x: 0.17176975361138047d, y: 0.7726113271551434d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.582832420943656d, y: 0.3262620617436591d), new NpgsqlTypes.NpgsqlPoint(x: 0.6429363520755259d, y: 0.4960006449505445d), new NpgsqlTypes.NpgsqlPoint(x: 0.06500318476275091d, y: 0.25022236767167316d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4542681939471571d, y: 0.37897625015577885d), new NpgsqlTypes.NpgsqlPoint(x: 0.464264348912375d, y: 0.8200593099399691d), new NpgsqlTypes.NpgsqlPoint(x: 0.22961736501730534d, y: 0.34016430140040943d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6933589426145221d, y: 0.23425215855103243d), new NpgsqlTypes.NpgsqlPoint(x: 0.025487566196397693d, y: 0.5155181057180321d), new NpgsqlTypes.NpgsqlPoint(x: 0.8824894892941094d, y: 0.13674486012792364d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9736911992361063d, y: 0.9734168714605204d), new NpgsqlTypes.NpgsqlPoint(x: 0.5577871805820642d, y: 0.3038108739002886d), new NpgsqlTypes.NpgsqlPoint(x: 0.9790028223222157d, y: 0.1672522926619785d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6356539717698908d, y: 0.7315943291798078d), new NpgsqlTypes.NpgsqlPoint(x: 0.1992232427845907d, y: 0.6385767564450799d), new NpgsqlTypes.NpgsqlPoint(x: 0.43040191562469265d, y: 0.01798231450495935d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24081958593368447d, y: 0.06889560304239362d), new NpgsqlTypes.NpgsqlPoint(x: 0.3712948448249147d, y: 0.582252674402327d), new NpgsqlTypes.NpgsqlPoint(x: 0.8455364786472143d, y: 0.12788925883654012d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27170111246339446d, y: 0.017487672207604943d), new NpgsqlTypes.NpgsqlPoint(x: 0.8720590823737436d, y: 0.766097797861769d), new NpgsqlTypes.NpgsqlPoint(x: 0.5293679711164985d, y: 0.8388444209717357d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5064548741693088d, y: 0.6303367910332798d), new NpgsqlTypes.NpgsqlPoint(x: 0.04715383583328381d, y: 0.14233664787938038d), new NpgsqlTypes.NpgsqlPoint(x: 0.7102242497839002d, y: 0.8947245744037431d)), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9008171150354437d, y: 0.04903177928206737d), new NpgsqlTypes.NpgsqlPoint(x: 0.5440593445096935d, y: 0.34415334584332125d), new NpgsqlTypes.NpgsqlPoint(x: 0.3857878123366133d, y: 0.17164176133150144d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9679955302111491d, y: 0.35273115900540675d), new NpgsqlTypes.NpgsqlPoint(x: 0.1244279737164593d, y: 0.696157889612005d), new NpgsqlTypes.NpgsqlPoint(x: 0.9477378930255013d, y: 0.7711679364958889d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9179306652506387d, y: 0.859913155583761d), new NpgsqlTypes.NpgsqlPoint(x: 0.9828538607526071d, y: 0.7195440877315402d), new NpgsqlTypes.NpgsqlPoint(x: 0.4656795005279867d, y: 0.6791428243497882d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21526749192104022d, y: 0.6357799766600011d), new NpgsqlTypes.NpgsqlPoint(x: 0.2273181120620723d, y: 0.3334915028736374d), new NpgsqlTypes.NpgsqlPoint(x: 0.1776901106036124d, y: 0.601741431188828d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8592614521187483d, y: 0.4472932641258568d), new NpgsqlTypes.NpgsqlPoint(x: 0.9134188456607117d, y: 0.03144242387593743d), new NpgsqlTypes.NpgsqlPoint(x: 0.1014896069409309d, y: 0.8227591046080637d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16777687220076154d, y: 0.16883851039368247d), new NpgsqlTypes.NpgsqlPoint(x: 0.5244665896442666d, y: 0.7923130997782858d), new NpgsqlTypes.NpgsqlPoint(x: 0.5173303370238574d, y: 0.9730808154013024d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9939839538743005d, y: 0.9520505415153171d), new NpgsqlTypes.NpgsqlPoint(x: 0.03254850367580464d, y: 0.4805693976935921d), new NpgsqlTypes.NpgsqlPoint(x: 0.20424585143660934d, y: 0.08112364108080328d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0762439038236511d, y: 0.08264845179788038d), new NpgsqlTypes.NpgsqlPoint(x: 0.6193230579883688d, y: 0.38382946082075087d), new NpgsqlTypes.NpgsqlPoint(x: 0.4866305520853498d, y: 0.3437547345879237d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41792758483694714d, y: 0.9378431073861012d), new NpgsqlTypes.NpgsqlPoint(x: 0.5386467273561701d, y: 0.12300895147366542d), new NpgsqlTypes.NpgsqlPoint(x: 0.6951460672671588d, y: 0.7715331874325742d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8504054103128111d, y: 0.7218259693975669d), new NpgsqlTypes.NpgsqlPoint(x: 0.7656482495576158d, y: 0.6525713966159717d), new NpgsqlTypes.NpgsqlPoint(x: 0.5460199396867014d, y: 0.5319319175128495d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11788736063908012d, y: 0.08648243523843913d), new NpgsqlTypes.NpgsqlPoint(x: 0.9997696065587959d, y: 0.5806858169059143d), new NpgsqlTypes.NpgsqlPoint(x: 0.4432838666816541d, y: 0.36263802870239426d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31380068320378973d, y: 0.6969129500511418d), new NpgsqlTypes.NpgsqlPoint(x: 0.0991130647938081d, y: 0.4271230690760983d), new NpgsqlTypes.NpgsqlPoint(x: 0.5924057763735372d, y: 0.26470427948219344d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3631087238199845d, y: 0.10324248248690615d), new NpgsqlTypes.NpgsqlPoint(x: 0.12303220225935785d, y: 0.720041253227584d), new NpgsqlTypes.NpgsqlPoint(x: 0.17891990607266772d, y: 0.11306253083027618d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4372817249648264d, y: 0.6521220283080287d), new NpgsqlTypes.NpgsqlPoint(x: 0.5281811670563835d, y: 0.11731317420890974d), new NpgsqlTypes.NpgsqlPoint(x: 0.4535871392705825d, y: 0.9632206541728345d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11670819609595051d, y: 0.9555464460813102d), new NpgsqlTypes.NpgsqlPoint(x: 0.7592918855862377d, y: 0.13285883466557313d), new NpgsqlTypes.NpgsqlPoint(x: 0.20146717411827508d, y: 0.5764138230197603d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6111531459585889d, y: 0.013814914633281994d), new NpgsqlTypes.NpgsqlPoint(x: 0.05977360711773272d, y: 0.36418136186983396d), new NpgsqlTypes.NpgsqlPoint(x: 0.30283639659159656d, y: 0.7084252408507794d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5519535740811574d, y: 0.26535943933945183d), new NpgsqlTypes.NpgsqlPoint(x: 0.41616884864797354d, y: 0.7670990041664593d), new NpgsqlTypes.NpgsqlPoint(x: 0.677899673717829d, y: 0.6094913954669519d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007518909673864593d, y: 0.1222119725041827d), new NpgsqlTypes.NpgsqlPoint(x: 0.4842214000298112d, y: 0.32148093056688454d), new NpgsqlTypes.NpgsqlPoint(x: 0.23621677355012172d, y: 0.7997316168621043d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3427877734780229d, y: 0.23885585564649325d), new NpgsqlTypes.NpgsqlPoint(x: 0.3933117166312611d, y: 0.26181763540324465d), new NpgsqlTypes.NpgsqlPoint(x: 0.8298591766164894d, y: 0.41009351129417315d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22085065949185645d, y: 0.09996267972255413d), new NpgsqlTypes.NpgsqlPoint(x: 0.02006704511080304d, y: 0.6706810439525005d), new NpgsqlTypes.NpgsqlPoint(x: 0.2777225606216379d, y: 0.11874666492036223d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5375733219990397d, y: 0.8547250817698148d), new NpgsqlTypes.NpgsqlPoint(x: 0.8701729925566055d, y: 0.6620896686116866d), new NpgsqlTypes.NpgsqlPoint(x: 0.4745459015100152d, y: 0.9403304975039383d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9163504626825228d, y: 0.9627620519186508d), new NpgsqlTypes.NpgsqlPoint(x: 0.8688897420031855d, y: 0.20108041619447303d), new NpgsqlTypes.NpgsqlPoint(x: 0.546649605538706d, y: 0.8429587279429308d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8261653685821861d, y: 0.9017521403408826d), new NpgsqlTypes.NpgsqlPoint(x: 0.48545479154803584d, y: 0.9808729479934201d), new NpgsqlTypes.NpgsqlPoint(x: 0.5205183707267133d, y: 0.7229131554798872d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8819362635648833d, y: 0.3823328741360076d), new NpgsqlTypes.NpgsqlPoint(x: 0.3172039778741802d, y: 0.505198034637862d), new NpgsqlTypes.NpgsqlPoint(x: 0.8228655354798705d, y: 0.2667865496341245d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8307431996252824d, y: 0.712102530220981d), new NpgsqlTypes.NpgsqlPoint(x: 0.8679544022455238d, y: 0.9055852048461788d), new NpgsqlTypes.NpgsqlPoint(x: 0.6567017989584122d, y: 0.013939602242827087d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24479290922949382d, y: 0.14180673485727335d), new NpgsqlTypes.NpgsqlPoint(x: 0.07337217430471477d, y: 0.4922038866854055d), new NpgsqlTypes.NpgsqlPoint(x: 0.9333615966520308d, y: 0.662209826168494d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.871782061981463d, y: 0.26069793492366267d), new NpgsqlTypes.NpgsqlPoint(x: 0.3789833576203483d, y: 0.5408697433029238d), new NpgsqlTypes.NpgsqlPoint(x: 0.29664384070014316d, y: 0.7260193964862495d)), }, }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5758193262455441d, y: 0.7091049158484495d), new NpgsqlTypes.NpgsqlPoint(x: 0.6874111615821321d, y: 0.33408818960630593d), new NpgsqlTypes.NpgsqlPoint(x: 0.08317909148813696d, y: 0.18766680328525065d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8828336516980337d, y: 0.06338669590450752d), new NpgsqlTypes.NpgsqlPoint(x: 0.47387086942495993d, y: 0.443664888083414d), new NpgsqlTypes.NpgsqlPoint(x: 0.5836742687740871d, y: 0.9565954245401941d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1268627711561391d, y: 0.9057481915822678d), new NpgsqlTypes.NpgsqlPoint(x: 0.43646597044906243d, y: 0.6279673494950906d), new NpgsqlTypes.NpgsqlPoint(x: 0.9193439707195669d, y: 0.46933822846624207d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6256878855243679d, y: 0.5685640209928504d), new NpgsqlTypes.NpgsqlPoint(x: 0.3447363418521189d, y: 0.24615260272875994d), new NpgsqlTypes.NpgsqlPoint(x: 0.14405371982464676d, y: 0.24784225753115752d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4389571241215051d, y: 0.6475654715862619d), new NpgsqlTypes.NpgsqlPoint(x: 0.8126361492368943d, y: 0.9839688187587303d), new NpgsqlTypes.NpgsqlPoint(x: 0.4370355190163675d, y: 0.2821149057008241d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8635318086092456d, y: 0.8807245191941215d), new NpgsqlTypes.NpgsqlPoint(x: 0.9819788915173506d, y: 0.22161331997891287d), new NpgsqlTypes.NpgsqlPoint(x: 0.7768164317454666d, y: 0.9503959062758314d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6751982655370908d, y: 0.8951787617613719d), new NpgsqlTypes.NpgsqlPoint(x: 0.3696579160164538d, y: 0.3692236747160268d), new NpgsqlTypes.NpgsqlPoint(x: 0.6311038342557745d, y: 0.9835328955197803d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14763141291257298d, y: 0.3198649298102144d), new NpgsqlTypes.NpgsqlPoint(x: 0.7726547296738239d, y: 0.583447529204315d), new NpgsqlTypes.NpgsqlPoint(x: 0.7749829014437745d, y: 0.7556034884481874d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9991319747756241d, y: 0.08070144500405241d), new NpgsqlTypes.NpgsqlPoint(x: 0.05358273718155904d, y: 0.17416963266586638d), new NpgsqlTypes.NpgsqlPoint(x: 0.7145910755135856d, y: 0.0880773326574471d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5008997175734768d, y: 0.5849254555909719d), new NpgsqlTypes.NpgsqlPoint(x: 0.34119583471329806d, y: 0.6274173998321203d), new NpgsqlTypes.NpgsqlPoint(x: 0.9414812596996343d, y: 0.35407611443403275d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8256997630596158d, y: 0.927230033188513d), new NpgsqlTypes.NpgsqlPoint(x: 0.061206968183692756d, y: 0.32104586038486593d), new NpgsqlTypes.NpgsqlPoint(x: 0.5056525794446681d, y: 0.6684315698035773d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8202410694094274d, y: 0.20871124308846645d), new NpgsqlTypes.NpgsqlPoint(x: 0.5027386353505668d, y: 0.06913378479828891d), new NpgsqlTypes.NpgsqlPoint(x: 0.6064571150739277d, y: 0.024476217159378533d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.058655263504516775d, y: 0.5566096031954547d), new NpgsqlTypes.NpgsqlPoint(x: 0.04764193348997292d, y: 0.8356356621654477d), new NpgsqlTypes.NpgsqlPoint(x: 0.9672903989529413d, y: 0.7706829556166477d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38696748466811304d, y: 0.6651931894591724d), new NpgsqlTypes.NpgsqlPoint(x: 0.9999229857194928d, y: 0.8294714210622892d), new NpgsqlTypes.NpgsqlPoint(x: 0.7755791352224025d, y: 0.9739874988973442d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3113207551873063d, y: 0.5226438212445197d), new NpgsqlTypes.NpgsqlPoint(x: 0.96091238772955d, y: 0.9675578207823706d), new NpgsqlTypes.NpgsqlPoint(x: 0.3214514579740395d, y: 0.5156487376026135d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09618283732426347d, y: 0.001403157889519946d), new NpgsqlTypes.NpgsqlPoint(x: 0.1994735785115933d, y: 0.3098165880879762d), new NpgsqlTypes.NpgsqlPoint(x: 0.7216108768687439d, y: 0.3148275038607198d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9048208692936307d, y: 0.5539421945032394d), new NpgsqlTypes.NpgsqlPoint(x: 0.47059015959275763d, y: 0.11569373279437034d), new NpgsqlTypes.NpgsqlPoint(x: 0.7400775314528862d, y: 0.5241026931527432d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5297372961415636d, y: 0.7101354744992842d), new NpgsqlTypes.NpgsqlPoint(x: 0.9273245717245839d, y: 0.8766244134590251d), new NpgsqlTypes.NpgsqlPoint(x: 0.5350447737820638d, y: 0.2945717200176752d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7019656941980394d, y: 0.15951634375493373d), new NpgsqlTypes.NpgsqlPoint(x: 0.12404128210280418d, y: 0.5902027388185783d), new NpgsqlTypes.NpgsqlPoint(x: 0.048266361781100886d, y: 0.636449566937593d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2078853421948642d, y: 0.48593641162900203d), new NpgsqlTypes.NpgsqlPoint(x: 0.21467733596621286d, y: 0.832875372968495d), new NpgsqlTypes.NpgsqlPoint(x: 0.5084878097479738d, y: 0.19087494645906766d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6896324325152134d, y: 0.9465328927049925d), new NpgsqlTypes.NpgsqlPoint(x: 0.8799505370803429d, y: 0.120369217600379d), new NpgsqlTypes.NpgsqlPoint(x: 0.5249519370838169d, y: 0.8809939827510646d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19342369710207985d, y: 0.42320008798842923d), new NpgsqlTypes.NpgsqlPoint(x: 0.5134813862484494d, y: 0.7734878390732234d), new NpgsqlTypes.NpgsqlPoint(x: 0.6136263110447387d, y: 0.011049035621936487d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42943747275958455d, y: 0.014613933708409688d), new NpgsqlTypes.NpgsqlPoint(x: 0.4541486839606055d, y: 0.13134877791716038d), new NpgsqlTypes.NpgsqlPoint(x: 0.5169089530283796d, y: 0.0767659539608806d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8665304991396683d, y: 0.8918914342949078d), new NpgsqlTypes.NpgsqlPoint(x: 0.6250028968724574d, y: 0.24305412771950852d), new NpgsqlTypes.NpgsqlPoint(x: 0.7587514592046809d, y: 0.9000189374429265d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.54376852078716d, y: 0.2988915086189633d), new NpgsqlTypes.NpgsqlPoint(x: 0.3675246473191822d, y: 0.7446292387681778d), new NpgsqlTypes.NpgsqlPoint(x: 0.2457253559106649d, y: 0.5856945045002555d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.010471457870132705d, y: 0.031356058490558114d), new NpgsqlTypes.NpgsqlPoint(x: 0.909625123246539d, y: 0.29418560533475824d), new NpgsqlTypes.NpgsqlPoint(x: 0.596008084158248d, y: 0.16788135165019535d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17484891919368806d, y: 0.5270685786747017d), new NpgsqlTypes.NpgsqlPoint(x: 0.7348480055626847d, y: 0.4022393136315674d), new NpgsqlTypes.NpgsqlPoint(x: 0.39852704948054474d, y: 0.6610951350193504d)), }, }, },
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2662506390562781d, y: 0.09842399281077452d), new NpgsqlTypes.NpgsqlPoint(x: 0.305611068262548d, y: 0.8502668257989063d), new NpgsqlTypes.NpgsqlPoint(x: 0.7660439924861344d, y: 0.9139689528803348d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.255929557028302d, y: 0.22136968369770338d), new NpgsqlTypes.NpgsqlPoint(x: 0.5434050566191536d, y: 0.1926074642437453d), new NpgsqlTypes.NpgsqlPoint(x: 0.9709382125482632d, y: 0.42082405117173494d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14101894787817504d, y: 0.7567766841604293d), new NpgsqlTypes.NpgsqlPoint(x: 0.5823309975861529d, y: 0.37698197688609825d), new NpgsqlTypes.NpgsqlPoint(x: 0.19109132631150405d, y: 0.19160913760851528d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6712028345949018d, y: 0.23011113775821423d), new NpgsqlTypes.NpgsqlPoint(x: 0.3075673024172376d, y: 0.9443250897171737d), new NpgsqlTypes.NpgsqlPoint(x: 0.3728605333167482d, y: 0.9083070424935987d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9533129949814175d, y: 0.3124480984012208d), new NpgsqlTypes.NpgsqlPoint(x: 0.47982763100828074d, y: 0.44289297140096284d), new NpgsqlTypes.NpgsqlPoint(x: 0.012407349688287383d, y: 0.965992317504538d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24857722704667118d, y: 0.6829348263775601d), new NpgsqlTypes.NpgsqlPoint(x: 0.21540221076571375d, y: 0.575190447874748d), new NpgsqlTypes.NpgsqlPoint(x: 0.11169915563409127d, y: 0.8927903693925358d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7775571426003037d, y: 0.527161904637386d), new NpgsqlTypes.NpgsqlPoint(x: 0.8042456168598002d, y: 0.946510429426726d), new NpgsqlTypes.NpgsqlPoint(x: 0.07501952088290675d, y: 0.7107639178028982d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14701231981545337d, y: 0.10244310322384342d), new NpgsqlTypes.NpgsqlPoint(x: 0.6890878863525395d, y: 0.7064399200857423d), new NpgsqlTypes.NpgsqlPoint(x: 0.30464764927793353d, y: 0.7021682994865758d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2634692261817039d, y: 0.5093699541064763d), new NpgsqlTypes.NpgsqlPoint(x: 0.08982191141890117d, y: 0.6952227327311522d), new NpgsqlTypes.NpgsqlPoint(x: 0.6954948807804598d, y: 0.571678701119329d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9994444310230317d, y: 0.2112092911888489d), new NpgsqlTypes.NpgsqlPoint(x: 0.5051356926963488d, y: 0.6370518967556006d), new NpgsqlTypes.NpgsqlPoint(x: 0.9693442611475822d, y: 0.6788512476179162d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12681079871519507d, y: 0.7377222069606061d), new NpgsqlTypes.NpgsqlPoint(x: 0.1935804619600192d, y: 0.8462790926964043d), new NpgsqlTypes.NpgsqlPoint(x: 0.05897787257165665d, y: 0.6085604124231565d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15472515399566344d, y: 0.5231295159471571d), new NpgsqlTypes.NpgsqlPoint(x: 0.9036648838732159d, y: 0.6849789958555387d), new NpgsqlTypes.NpgsqlPoint(x: 0.883584686817356d, y: 0.03197981686736828d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4982180208985827d, y: 0.6088612029378464d), new NpgsqlTypes.NpgsqlPoint(x: 0.3902418078705131d, y: 0.09386197769532134d), new NpgsqlTypes.NpgsqlPoint(x: 0.9644607011159037d, y: 0.6905119318990944d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6756201459644892d, y: 0.3291576286669624d), new NpgsqlTypes.NpgsqlPoint(x: 0.3549781915141511d, y: 0.522481106151186d), new NpgsqlTypes.NpgsqlPoint(x: 0.9657747815264706d, y: 0.09513401939776278d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5336413748076714d, y: 0.10011729559124549d), new NpgsqlTypes.NpgsqlPoint(x: 0.2545510567498087d, y: 0.13928264678932645d), new NpgsqlTypes.NpgsqlPoint(x: 0.46199771367975917d, y: 0.568573172909474d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.595109032740335d, y: 0.5617136495020849d), new NpgsqlTypes.NpgsqlPoint(x: 0.8631430051266361d, y: 0.3965161698183297d), new NpgsqlTypes.NpgsqlPoint(x: 0.3461979295714571d, y: 0.06756856268540645d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06717535797749519d, y: 0.5124491781257259d), new NpgsqlTypes.NpgsqlPoint(x: 0.6231281713121603d, y: 0.9251782977912684d), new NpgsqlTypes.NpgsqlPoint(x: 0.01715545634611415d, y: 0.24822600042987142d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8074168607423022d, y: 0.13341738253306779d), new NpgsqlTypes.NpgsqlPoint(x: 0.15064754139675574d, y: 0.7410378526618875d), new NpgsqlTypes.NpgsqlPoint(x: 0.3096074089335573d, y: 0.09040435635338562d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11328218569368076d, y: 0.08446668118093126d), new NpgsqlTypes.NpgsqlPoint(x: 0.7503033236490372d, y: 0.2330316866492873d), new NpgsqlTypes.NpgsqlPoint(x: 0.17641669143655025d, y: 0.9728047380656559d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05331425730537809d, y: 0.36344184066469243d), new NpgsqlTypes.NpgsqlPoint(x: 0.10164218398616576d, y: 0.3885578479639741d), new NpgsqlTypes.NpgsqlPoint(x: 0.4596922097907591d, y: 0.8418299767685195d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9450854565658787d, y: 0.08249601836460574d), new NpgsqlTypes.NpgsqlPoint(x: 0.830023525464956d, y: 0.6199370571329872d), new NpgsqlTypes.NpgsqlPoint(x: 0.41636236260548765d, y: 0.3887865521221774d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7162584098293396d, y: 0.2648162517469589d), new NpgsqlTypes.NpgsqlPoint(x: 0.33687205882386306d, y: 0.19053904498938845d), new NpgsqlTypes.NpgsqlPoint(x: 0.4888735960068624d, y: 0.3835366379758799d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7221909305947611d, y: 0.6486887078174394d), new NpgsqlTypes.NpgsqlPoint(x: 0.03869804356954143d, y: 0.6171302571904143d), new NpgsqlTypes.NpgsqlPoint(x: 0.8435070013590514d, y: 0.1280072719756562d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.840727069483079d, y: 0.8698266332293156d), new NpgsqlTypes.NpgsqlPoint(x: 0.7861464658827855d, y: 0.19522058555369515d), new NpgsqlTypes.NpgsqlPoint(x: 0.023920997671119104d, y: 0.04093922998390931d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9345934649458608d, y: 0.19729370241883804d), new NpgsqlTypes.NpgsqlPoint(x: 0.35566389322260705d, y: 0.9035341308215683d), new NpgsqlTypes.NpgsqlPoint(x: 0.4165126099928562d, y: 0.6803692843128655d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4901475034744016d, y: 0.2939201808910258d), new NpgsqlTypes.NpgsqlPoint(x: 0.04977267793535012d, y: 0.4672694487058421d), new NpgsqlTypes.NpgsqlPoint(x: 0.5555929589249856d, y: 0.6402981583328814d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21256307343970404d, y: 0.004864580190192536d), new NpgsqlTypes.NpgsqlPoint(x: 0.9704049089813661d, y: 0.8784604872677223d), new NpgsqlTypes.NpgsqlPoint(x: 0.5478743311470834d, y: 0.6382888637937746d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31741331428244823d, y: 0.2649708206142264d), new NpgsqlTypes.NpgsqlPoint(x: 0.6131130256340499d, y: 0.8513050690244582d), new NpgsqlTypes.NpgsqlPoint(x: 0.3616312665202751d, y: 0.6772516724598487d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30916954055911205d, y: 0.9493071798817692d), new NpgsqlTypes.NpgsqlPoint(x: 0.869608519829754d, y: 0.9167389592027092d), new NpgsqlTypes.NpgsqlPoint(x: 0.4540932728581559d, y: 0.8765893031654404d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3268597396879893d, y: 0.12263395523166354d), new NpgsqlTypes.NpgsqlPoint(x: 0.69441173994249d, y: 0.12629694763343846d), new NpgsqlTypes.NpgsqlPoint(x: 0.7022782912875232d, y: 0.24724530044076476d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2949468360011792d, y: 0.3122361129265635d), new NpgsqlTypes.NpgsqlPoint(x: 0.8564707356189366d, y: 0.3042695413448451d), new NpgsqlTypes.NpgsqlPoint(x: 0.9569757915277688d, y: 0.32405189850991734d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30203403520720606d, y: 0.5276789861458394d), new NpgsqlTypes.NpgsqlPoint(x: 0.287168362288316d, y: 0.4427331389374356d), new NpgsqlTypes.NpgsqlPoint(x: 0.6114226810770503d, y: 0.7230723701099463d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014775650020160347d, y: 0.1872566160918745d), new NpgsqlTypes.NpgsqlPoint(x: 0.013037291238804039d, y: 0.25043659119651884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9901886479366987d, y: 0.7389337768286313d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49392213723578593d, y: 0.3438838728930649d), new NpgsqlTypes.NpgsqlPoint(x: 0.9120459717371481d, y: 0.7531377040374325d), new NpgsqlTypes.NpgsqlPoint(x: 0.49041744173040647d, y: 0.27122021569433497d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004926440751910621d, y: 0.5886983403968153d), new NpgsqlTypes.NpgsqlPoint(x: 0.4905501614580037d, y: 0.8904687810056335d), new NpgsqlTypes.NpgsqlPoint(x: 0.9826795850881294d, y: 0.6212984677630394d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3362781887178894d, y: 0.6742271198475484d), new NpgsqlTypes.NpgsqlPoint(x: 0.38062802797668904d, y: 0.5903357615464876d), new NpgsqlTypes.NpgsqlPoint(x: 0.6874021304858368d, y: 0.6072773523488008d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5309875554279827d, y: 0.6546362292148761d), new NpgsqlTypes.NpgsqlPoint(x: 0.7029593489055496d, y: 0.6922090057616614d), new NpgsqlTypes.NpgsqlPoint(x: 0.588616426818169d, y: 0.9294738373256138d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9325246569159054d, y: 0.2787717047255044d), new NpgsqlTypes.NpgsqlPoint(x: 0.46146626558951354d, y: 0.5292246956226832d), new NpgsqlTypes.NpgsqlPoint(x: 0.046448972065620264d, y: 0.5571918440340929d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5346205851519289d, y: 0.9790519300352973d), new NpgsqlTypes.NpgsqlPoint(x: 0.24503015545311457d, y: 0.5516085076387683d), new NpgsqlTypes.NpgsqlPoint(x: 0.32367573277373984d, y: 0.026124419096686613d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4572977130286905d, y: 0.34114835743867444d), new NpgsqlTypes.NpgsqlPoint(x: 0.9796698408637364d, y: 0.7023035463173684d), new NpgsqlTypes.NpgsqlPoint(x: 0.3550038612793729d, y: 0.009209693511876171d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9707421496841582d, y: 0.24061793614543114d), new NpgsqlTypes.NpgsqlPoint(x: 0.10199770820194076d, y: 0.6317364095189887d), new NpgsqlTypes.NpgsqlPoint(x: 0.1276438992114971d, y: 0.3068806930960225d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3938751637729776d, y: 0.8592203064980141d), new NpgsqlTypes.NpgsqlPoint(x: 0.07617800055984236d, y: 0.23003146457782442d), new NpgsqlTypes.NpgsqlPoint(x: 0.30053486422422027d, y: 0.2750943935932485d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.853367076499931d, y: 0.8684955853214156d), new NpgsqlTypes.NpgsqlPoint(x: 0.8604952108340536d, y: 0.07783017557960525d), new NpgsqlTypes.NpgsqlPoint(x: 0.11874607750483401d, y: 0.9910849727175236d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5054506534277559d, y: 0.9289000577801976d), new NpgsqlTypes.NpgsqlPoint(x: 0.866930598277381d, y: 0.6386495624538662d), new NpgsqlTypes.NpgsqlPoint(x: 0.5655803844379335d, y: 0.08825498448395341d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17602431414624897d, y: 0.8756166746344536d), new NpgsqlTypes.NpgsqlPoint(x: 0.7998820370138742d, y: 0.028848979193433766d), new NpgsqlTypes.NpgsqlPoint(x: 0.5543663886949003d, y: 0.13375800263540216d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8826638051058531d, y: 0.4365688073874714d), new NpgsqlTypes.NpgsqlPoint(x: 0.8138218681627252d, y: 0.7103614894628884d), new NpgsqlTypes.NpgsqlPoint(x: 0.5754109655920232d, y: 0.9014755525248013d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7949983399589816d, y: 0.5505838239288119d), new NpgsqlTypes.NpgsqlPoint(x: 0.8702743890047046d, y: 0.9280980285787422d), new NpgsqlTypes.NpgsqlPoint(x: 0.5858346753273312d, y: 0.21633158627919813d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5295465171266285d, y: 0.08167389132874181d), new NpgsqlTypes.NpgsqlPoint(x: 0.21249224846516257d, y: 0.8263532402988191d), new NpgsqlTypes.NpgsqlPoint(x: 0.12120217667098987d, y: 0.13709085057079418d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6349326334001242d, y: 0.6647412529683046d), new NpgsqlTypes.NpgsqlPoint(x: 0.5043732936599001d, y: 0.21375856431418483d), new NpgsqlTypes.NpgsqlPoint(x: 0.47280516043469123d, y: 0.15051081015575318d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1477778294226504d, y: 0.20570492487537717d), new NpgsqlTypes.NpgsqlPoint(x: 0.47067503835425417d, y: 0.8727742716121082d), new NpgsqlTypes.NpgsqlPoint(x: 0.15555321319522775d, y: 0.8982899093334235d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8665772199387896d, y: 0.6589638527898151d), new NpgsqlTypes.NpgsqlPoint(x: 0.02158372514079432d, y: 0.27306411492042926d), new NpgsqlTypes.NpgsqlPoint(x: 0.18172145402922069d, y: 0.5793832307231208d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.619455012431031d, y: 0.2565372007682809d), new NpgsqlTypes.NpgsqlPoint(x: 0.9754917367193713d, y: 0.9089828553256619d), new NpgsqlTypes.NpgsqlPoint(x: 0.46918058186688716d, y: 0.8308934266738283d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9927206631052465d, y: 0.4077887907109262d), new NpgsqlTypes.NpgsqlPoint(x: 0.03754376927916159d, y: 0.6624353424980376d), new NpgsqlTypes.NpgsqlPoint(x: 0.5273198272801641d, y: 0.6963822023059327d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9220997709041415d, y: 0.7665725602259531d), new NpgsqlTypes.NpgsqlPoint(x: 0.653166202702851d, y: 0.5843682371417475d), new NpgsqlTypes.NpgsqlPoint(x: 0.6861644246988103d, y: 0.5771641935077615d)), }, }, },
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6423642650462233d, y: 0.39528478188460037d), new NpgsqlTypes.NpgsqlPoint(x: 0.17914794809152934d, y: 0.608864905544955d), new NpgsqlTypes.NpgsqlPoint(x: 0.6953224620054512d, y: 0.6675091739403749d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7556581595095805d, y: 0.016867973507759815d), new NpgsqlTypes.NpgsqlPoint(x: 0.5445161251767394d, y: 0.4224251066547896d), new NpgsqlTypes.NpgsqlPoint(x: 0.7556700405193818d, y: 0.3577362187197899d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9852806413382427d, y: 0.9868307196187598d), new NpgsqlTypes.NpgsqlPoint(x: 0.07706914286206046d, y: 0.3983407647221905d), new NpgsqlTypes.NpgsqlPoint(x: 0.5369735861364461d, y: 0.5004360537690257d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.944983213699009d, y: 0.08699289216331096d), new NpgsqlTypes.NpgsqlPoint(x: 0.12672456237471053d, y: 0.11167485757141438d), new NpgsqlTypes.NpgsqlPoint(x: 0.30947724654762865d, y: 0.8070043382330389d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.954848054275415d, y: 0.8202917593670671d), new NpgsqlTypes.NpgsqlPoint(x: 0.7053493959516731d, y: 0.81897879347574d), new NpgsqlTypes.NpgsqlPoint(x: 0.19359125182582615d, y: 0.5816212577371075d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5880091287012434d, y: 0.3054760286498749d), new NpgsqlTypes.NpgsqlPoint(x: 0.5138202646339972d, y: 0.6449191171423481d), new NpgsqlTypes.NpgsqlPoint(x: 0.7232459209145595d, y: 0.46652114919686194d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24094827916013262d, y: 0.16701572990001112d), new NpgsqlTypes.NpgsqlPoint(x: 0.43463398453090873d, y: 0.21152575441307875d), new NpgsqlTypes.NpgsqlPoint(x: 0.4954739556334261d, y: 0.08555614278528312d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17768496685044777d, y: 0.6269885935111345d), new NpgsqlTypes.NpgsqlPoint(x: 0.7398774152485765d, y: 0.10289705415864525d), new NpgsqlTypes.NpgsqlPoint(x: 0.5558293009297387d, y: 0.31441879931170047d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3062122413444287d, y: 0.5839627001984549d), new NpgsqlTypes.NpgsqlPoint(x: 0.14683795589971982d, y: 0.07619215629162646d), new NpgsqlTypes.NpgsqlPoint(x: 0.041039804171127736d, y: 0.5895423985672035d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19679108928442446d, y: 0.3979273091266937d), new NpgsqlTypes.NpgsqlPoint(x: 0.3170715098858453d, y: 0.20011547562051957d), new NpgsqlTypes.NpgsqlPoint(x: 0.8318678948964265d, y: 0.4534951133860312d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10431399364891103d, y: 0.4296182955082384d), new NpgsqlTypes.NpgsqlPoint(x: 0.5766411614322898d, y: 0.28047764691827226d), new NpgsqlTypes.NpgsqlPoint(x: 0.6190535036211287d, y: 0.38680952639535127d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.258626356179837d, y: 0.52019853312576d), new NpgsqlTypes.NpgsqlPoint(x: 0.4254325928683662d, y: 0.7992671758062089d), new NpgsqlTypes.NpgsqlPoint(x: 0.8762500793882473d, y: 0.5972403750755616d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.623583001992743d, y: 0.22718813356269074d), new NpgsqlTypes.NpgsqlPoint(x: 0.057976884151991426d, y: 0.3463167577036713d), new NpgsqlTypes.NpgsqlPoint(x: 0.16412323108539895d, y: 0.8653987993252256d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8482458936342627d, y: 0.05096947867371404d), new NpgsqlTypes.NpgsqlPoint(x: 0.12148119770859422d, y: 0.713389657539981d), new NpgsqlTypes.NpgsqlPoint(x: 0.6661512591983701d, y: 0.36798504424794654d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31519720229949644d, y: 0.007297979775224839d), new NpgsqlTypes.NpgsqlPoint(x: 0.6755065063201818d, y: 0.48991117903426307d), new NpgsqlTypes.NpgsqlPoint(x: 0.5719080736273845d, y: 0.1798511905805198d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7575146275140207d, y: 0.5646747159151425d), new NpgsqlTypes.NpgsqlPoint(x: 0.8763108352787496d, y: 0.4399040464913355d), new NpgsqlTypes.NpgsqlPoint(x: 0.12847317816709314d, y: 0.2761270840112816d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.021729586048811367d, y: 0.8169979467000165d), new NpgsqlTypes.NpgsqlPoint(x: 0.31941823919185397d, y: 0.9426039074900139d), new NpgsqlTypes.NpgsqlPoint(x: 0.8161417981413556d, y: 0.38090300755559403d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37394830673352963d, y: 0.7197954517639074d), new NpgsqlTypes.NpgsqlPoint(x: 0.31120095350363675d, y: 0.6203001853555649d), new NpgsqlTypes.NpgsqlPoint(x: 0.4944106460394697d, y: 0.7294365696484855d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19838289545141985d, y: 0.48862990801710315d), new NpgsqlTypes.NpgsqlPoint(x: 0.9309996767523252d, y: 0.08840106619239241d), new NpgsqlTypes.NpgsqlPoint(x: 0.5489394409613464d, y: 0.09255432586922396d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.254430602505186d, y: 0.08587707211648754d), new NpgsqlTypes.NpgsqlPoint(x: 0.19678110772665802d, y: 0.6605006957281351d), new NpgsqlTypes.NpgsqlPoint(x: 0.2446735727171322d, y: 0.6331250647425996d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2856285036821268d, y: 0.1433666761748119d), new NpgsqlTypes.NpgsqlPoint(x: 0.7488545002252891d, y: 0.21541726616588763d), new NpgsqlTypes.NpgsqlPoint(x: 0.7027033720814184d, y: 0.18922054872740057d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9468623735037687d, y: 0.8932925649701607d), new NpgsqlTypes.NpgsqlPoint(x: 0.3908846543157951d, y: 0.8395705466405964d), new NpgsqlTypes.NpgsqlPoint(x: 0.03746017103273913d, y: 0.6891498154806431d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3548297426613649d, y: 0.9683158561225716d), new NpgsqlTypes.NpgsqlPoint(x: 0.9466683817480335d, y: 0.6352323408386626d), new NpgsqlTypes.NpgsqlPoint(x: 0.8379200410315665d, y: 0.4442440587240696d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7200635921755335d, y: 0.01536988616252033d), new NpgsqlTypes.NpgsqlPoint(x: 0.5388105906960677d, y: 0.9988975491953308d), new NpgsqlTypes.NpgsqlPoint(x: 0.7420081946663774d, y: 0.19486823953745913d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7222456607338892d, y: 0.057674965321385274d), new NpgsqlTypes.NpgsqlPoint(x: 0.966348462009297d, y: 0.9450077058875507d), new NpgsqlTypes.NpgsqlPoint(x: 0.03908731467781423d, y: 0.18811542406754755d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9679710317061325d, y: 0.791330461647564d), new NpgsqlTypes.NpgsqlPoint(x: 0.6375454651422305d, y: 0.39453879269306347d), new NpgsqlTypes.NpgsqlPoint(x: 0.6808631937427437d, y: 0.48071338242309647d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7209862995454847d, y: 0.856702303323704d), new NpgsqlTypes.NpgsqlPoint(x: 0.9048199717079825d, y: 0.19144062047591248d), new NpgsqlTypes.NpgsqlPoint(x: 0.2141707031746325d, y: 0.31552991126674146d)), }, }, },
    ModelInner = new NpgsqlPathpathMMArrayD3E1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2650774481285988d, y: 0.5218962302270047d), new NpgsqlTypes.NpgsqlPoint(x: 0.43647481177087677d, y: 0.9647947787169472d), new NpgsqlTypes.NpgsqlPoint(x: 0.5581873851563485d, y: 0.3043947831529923d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18561023531556697d, y: 0.9802386311499107d), new NpgsqlTypes.NpgsqlPoint(x: 0.07367524588466745d, y: 0.2936556383131431d), new NpgsqlTypes.NpgsqlPoint(x: 0.6994681981515866d, y: 0.08710625770163827d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2959370115545057d, y: 0.33645576338376504d), new NpgsqlTypes.NpgsqlPoint(x: 0.4721838653964652d, y: 0.10665508927945277d), new NpgsqlTypes.NpgsqlPoint(x: 0.20179952234703225d, y: 0.45411816259294624d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7910698468103374d, y: 0.02639805247841087d), new NpgsqlTypes.NpgsqlPoint(x: 0.6520646654324375d, y: 0.6829299471821944d), new NpgsqlTypes.NpgsqlPoint(x: 0.9242245292347763d, y: 0.07189955456589847d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3150696935788939d, y: 0.8311216005394191d), new NpgsqlTypes.NpgsqlPoint(x: 0.9968578467507713d, y: 0.807221662834307d), new NpgsqlTypes.NpgsqlPoint(x: 0.7353538940305907d, y: 0.7099699510719476d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9532972330279136d, y: 0.9416297701347905d), new NpgsqlTypes.NpgsqlPoint(x: 0.3075689381822533d, y: 0.36301691964889304d), new NpgsqlTypes.NpgsqlPoint(x: 0.865002959872329d, y: 0.7930370807880462d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5413470049255359d, y: 0.682505278110996d), new NpgsqlTypes.NpgsqlPoint(x: 0.3280462340746263d, y: 0.9513308053948111d), new NpgsqlTypes.NpgsqlPoint(x: 0.9996342343412382d, y: 0.32497439324715405d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9255078188523285d, y: 0.3380681646288709d), new NpgsqlTypes.NpgsqlPoint(x: 0.9834076806926186d, y: 0.23383765641373777d), new NpgsqlTypes.NpgsqlPoint(x: 0.39498270722129647d, y: 0.6914466221261001d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.435822959598439d, y: 0.4725080983987696d), new NpgsqlTypes.NpgsqlPoint(x: 0.09533567167187273d, y: 0.3128894955705438d), new NpgsqlTypes.NpgsqlPoint(x: 0.531922712235272d, y: 0.7812252635655852d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23484130072840892d, y: 0.6025396750689441d), new NpgsqlTypes.NpgsqlPoint(x: 0.055473643693345176d, y: 0.515770795435097d), new NpgsqlTypes.NpgsqlPoint(x: 0.8689612199491031d, y: 0.1335514260755566d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9775854327908781d, y: 0.31846398025905964d), new NpgsqlTypes.NpgsqlPoint(x: 0.19074227237256636d, y: 0.25918004630522984d), new NpgsqlTypes.NpgsqlPoint(x: 0.8298891400523196d, y: 0.5575377939356293d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8354524003658742d, y: 0.94352775383312d), new NpgsqlTypes.NpgsqlPoint(x: 0.3713696045416035d, y: 0.9831175624075954d), new NpgsqlTypes.NpgsqlPoint(x: 0.29458321862509795d, y: 0.4824752700208008d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4887696368790595d, y: 0.37069035073049894d), new NpgsqlTypes.NpgsqlPoint(x: 0.06787270360340869d, y: 0.03618883127699668d), new NpgsqlTypes.NpgsqlPoint(x: 0.8507501052641447d, y: 0.6780614383906477d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13488027058293117d, y: 0.9488576448897031d), new NpgsqlTypes.NpgsqlPoint(x: 0.6406572079806674d, y: 0.08074126277170335d), new NpgsqlTypes.NpgsqlPoint(x: 0.9093099664959139d, y: 0.1355759340164009d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5261441283748746d, y: 0.5136945167906052d), new NpgsqlTypes.NpgsqlPoint(x: 0.7895080605698258d, y: 0.7287288470432134d), new NpgsqlTypes.NpgsqlPoint(x: 0.9491697997553001d, y: 0.3618085575088772d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7832118388173335d, y: 0.1749777671528332d), new NpgsqlTypes.NpgsqlPoint(x: 0.9551530464184864d, y: 0.017577085203836162d), new NpgsqlTypes.NpgsqlPoint(x: 0.14765044459845478d, y: 0.3923640257661293d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40651290969659193d, y: 0.6052559357811704d), new NpgsqlTypes.NpgsqlPoint(x: 0.7230319280857687d, y: 0.4105155977980265d), new NpgsqlTypes.NpgsqlPoint(x: 0.3147923252165865d, y: 0.06836067959952763d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3637851112261934d, y: 0.4379045453119217d), new NpgsqlTypes.NpgsqlPoint(x: 0.1636352148295488d, y: 0.7658305473745418d), new NpgsqlTypes.NpgsqlPoint(x: 0.8154656292683046d, y: 0.3294399680828459d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6896656493388008d, y: 0.6833953983453268d), new NpgsqlTypes.NpgsqlPoint(x: 0.08508160558440347d, y: 0.28629198254340515d), new NpgsqlTypes.NpgsqlPoint(x: 0.9106207274049399d, y: 0.7295225429159982d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7242351480319054d, y: 0.19927211468832928d), new NpgsqlTypes.NpgsqlPoint(x: 0.720930193797837d, y: 0.5440276872009756d), new NpgsqlTypes.NpgsqlPoint(x: 0.20957552259349332d, y: 0.9616480017729614d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13435363659290644d, y: 0.4388743262774727d), new NpgsqlTypes.NpgsqlPoint(x: 0.683468179701637d, y: 0.6780553929138976d), new NpgsqlTypes.NpgsqlPoint(x: 0.6443326480230176d, y: 0.44407160243078303d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10983315074114541d, y: 0.9527478958390845d), new NpgsqlTypes.NpgsqlPoint(x: 0.3904181090126744d, y: 0.5939348306022598d), new NpgsqlTypes.NpgsqlPoint(x: 0.19081355255208443d, y: 0.15777602068436025d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8318344834611243d, y: 0.6486405571480357d), new NpgsqlTypes.NpgsqlPoint(x: 0.6813371314626431d, y: 0.8892967085040111d), new NpgsqlTypes.NpgsqlPoint(x: 0.6708128521130158d, y: 0.42348314230014217d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22016494681958654d, y: 0.733959787682538d), new NpgsqlTypes.NpgsqlPoint(x: 0.03538736954864263d, y: 0.19668322980218356d), new NpgsqlTypes.NpgsqlPoint(x: 0.9707570111495928d, y: 0.7470281958911322d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25213460811984556d, y: 0.5530779357723978d), new NpgsqlTypes.NpgsqlPoint(x: 0.8222267805714434d, y: 0.9036765396145708d), new NpgsqlTypes.NpgsqlPoint(x: 0.934015050687431d, y: 0.8660157620605015d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.033467556734255166d, y: 0.4644384710247236d), new NpgsqlTypes.NpgsqlPoint(x: 0.02058235676498965d, y: 0.8460881675083943d), new NpgsqlTypes.NpgsqlPoint(x: 0.01202412884463977d, y: 0.9105654543145006d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8298592957213128d, y: 0.36232387265216737d), new NpgsqlTypes.NpgsqlPoint(x: 0.3733016176254679d, y: 0.6901795429904984d), new NpgsqlTypes.NpgsqlPoint(x: 0.8062131114258527d, y: 0.28846812501619534d)), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8353984399813634d, y: 0.2999520419221866d), new NpgsqlTypes.NpgsqlPoint(x: 0.3320167886351749d, y: 0.8227960870664666d), new NpgsqlTypes.NpgsqlPoint(x: 0.3723910338426435d, y: 0.5185395676554239d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5272502087555331d, y: 0.08880114892916302d), new NpgsqlTypes.NpgsqlPoint(x: 0.7137977737252619d, y: 0.39275935367254466d), new NpgsqlTypes.NpgsqlPoint(x: 0.6199094691407974d, y: 0.04107339220515671d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13226967275903234d, y: 0.9835387230095155d), new NpgsqlTypes.NpgsqlPoint(x: 0.746894521471298d, y: 0.6857399936426953d), new NpgsqlTypes.NpgsqlPoint(x: 0.26183333845821355d, y: 0.9274673065662902d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3082187003722737d, y: 0.1706728500396799d), new NpgsqlTypes.NpgsqlPoint(x: 0.9343681175669326d, y: 0.3300949543725126d), new NpgsqlTypes.NpgsqlPoint(x: 0.8580570554906485d, y: 0.47385721741244635d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9776068714837473d, y: 0.26192708628634165d), new NpgsqlTypes.NpgsqlPoint(x: 0.5221230007921779d, y: 0.010645843582163472d), new NpgsqlTypes.NpgsqlPoint(x: 0.8618708342039059d, y: 0.5606154764170431d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9910361291277973d, y: 0.4600090756556594d), new NpgsqlTypes.NpgsqlPoint(x: 0.310804337552545d, y: 0.2037241937806784d), new NpgsqlTypes.NpgsqlPoint(x: 0.9382046793213402d, y: 0.21741697207538035d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6523972126361332d, y: 0.5464885888056576d), new NpgsqlTypes.NpgsqlPoint(x: 0.510694772348356d, y: 0.6918921327494032d), new NpgsqlTypes.NpgsqlPoint(x: 0.7869794123301445d, y: 0.6040220902513151d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.669922702510627d, y: 0.16968579149453578d), new NpgsqlTypes.NpgsqlPoint(x: 0.926939446994174d, y: 0.795246822174922d), new NpgsqlTypes.NpgsqlPoint(x: 0.32005140959102196d, y: 0.9842617693621779d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2845534543886469d, y: 0.649017496922578d), new NpgsqlTypes.NpgsqlPoint(x: 0.12651169279930996d, y: 0.05615242077780169d), new NpgsqlTypes.NpgsqlPoint(x: 0.03968359709633695d, y: 0.413072820841315d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9936182779479348d, y: 0.0818014672377837d), new NpgsqlTypes.NpgsqlPoint(x: 0.5396390870958058d, y: 0.5136492986332294d), new NpgsqlTypes.NpgsqlPoint(x: 0.5819673974618792d, y: 0.10032868394870953d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16418921358009153d, y: 0.1254886513665946d), new NpgsqlTypes.NpgsqlPoint(x: 0.37773083969121646d, y: 0.5525447766495182d), new NpgsqlTypes.NpgsqlPoint(x: 0.22359048969763384d, y: 0.22436029265012336d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26243857851903507d, y: 0.9672410804979935d), new NpgsqlTypes.NpgsqlPoint(x: 0.6987007007072081d, y: 0.7088127832125045d), new NpgsqlTypes.NpgsqlPoint(x: 0.3719051053247696d, y: 0.5305128313823545d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2105197149446565d, y: 0.4384772164270043d), new NpgsqlTypes.NpgsqlPoint(x: 0.819820131346323d, y: 0.736450263380828d), new NpgsqlTypes.NpgsqlPoint(x: 0.49504188238172253d, y: 0.01169585387853489d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8041847239403206d, y: 0.12833081419510195d), new NpgsqlTypes.NpgsqlPoint(x: 0.22267781625890237d, y: 0.12062852542817348d), new NpgsqlTypes.NpgsqlPoint(x: 0.03148673548006309d, y: 0.7919262949806188d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46572559558861293d, y: 0.19093195508663385d), new NpgsqlTypes.NpgsqlPoint(x: 0.44317383189935955d, y: 0.8941261784484225d), new NpgsqlTypes.NpgsqlPoint(x: 0.6459921774359538d, y: 0.16396678486632477d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.349097211473134d, y: 0.9552783635421533d), new NpgsqlTypes.NpgsqlPoint(x: 0.9311530030773315d, y: 0.45390117563927224d), new NpgsqlTypes.NpgsqlPoint(x: 0.9200932478451997d, y: 0.957812037785091d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5376627915916059d, y: 0.3015507267811184d), new NpgsqlTypes.NpgsqlPoint(x: 0.7397018597189399d, y: 0.30769553272665506d), new NpgsqlTypes.NpgsqlPoint(x: 0.966409104881467d, y: 0.02449026324145831d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7038521927574701d, y: 0.02937442393451095d), new NpgsqlTypes.NpgsqlPoint(x: 0.6626834981825633d, y: 0.4019241757877656d), new NpgsqlTypes.NpgsqlPoint(x: 0.44458956859241516d, y: 0.9488422378390675d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09717277626115017d, y: 0.10547148509421234d), new NpgsqlTypes.NpgsqlPoint(x: 0.16867471495458441d, y: 0.045922527692097925d), new NpgsqlTypes.NpgsqlPoint(x: 0.341859450921153d, y: 0.4539214969795303d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19668598950888305d, y: 0.43341411841587385d), new NpgsqlTypes.NpgsqlPoint(x: 0.6012552915429048d, y: 0.9956769465732263d), new NpgsqlTypes.NpgsqlPoint(x: 0.422660808136628d, y: 0.5412836147181933d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4510400595634161d, y: 0.1532020951351033d), new NpgsqlTypes.NpgsqlPoint(x: 0.3209302567740855d, y: 0.09504044343504336d), new NpgsqlTypes.NpgsqlPoint(x: 0.6915858368267318d, y: 0.923891580867235d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46258442781398057d, y: 0.659972025656777d), new NpgsqlTypes.NpgsqlPoint(x: 0.30953474608831244d, y: 0.8700601947710556d), new NpgsqlTypes.NpgsqlPoint(x: 0.3998156905669993d, y: 0.1299683212178998d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1942490088400166d, y: 0.4361280595434074d), new NpgsqlTypes.NpgsqlPoint(x: 0.8115236962035934d, y: 0.6256743981508448d), new NpgsqlTypes.NpgsqlPoint(x: 0.6378118168348146d, y: 0.7209896172053923d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0497200189930781d, y: 0.8197789310735654d), new NpgsqlTypes.NpgsqlPoint(x: 0.17701871606252506d, y: 0.5124938185552322d), new NpgsqlTypes.NpgsqlPoint(x: 0.4842067865574191d, y: 0.1926635666675368d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3981450034044769d, y: 0.2349557023261879d), new NpgsqlTypes.NpgsqlPoint(x: 0.15937947000317332d, y: 0.49311461588781136d), new NpgsqlTypes.NpgsqlPoint(x: 0.3517148991336242d, y: 0.4812646531636736d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9149276699125513d, y: 0.024261217396815304d), new NpgsqlTypes.NpgsqlPoint(x: 0.023811218516250454d, y: 0.14877165290464056d), new NpgsqlTypes.NpgsqlPoint(x: 0.14940996332914136d, y: 0.5309665678489991d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.037503627627843095d, y: 0.7794334255724809d), new NpgsqlTypes.NpgsqlPoint(x: 0.3039946586797603d, y: 0.6115570757418455d), new NpgsqlTypes.NpgsqlPoint(x: 0.4380988302861387d, y: 0.7433341720724639d)), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7911392468578414d, y: 0.23469509057569915d), new NpgsqlTypes.NpgsqlPoint(x: 0.038643156000713885d, y: 0.6432471560269284d), new NpgsqlTypes.NpgsqlPoint(x: 0.6186772560963697d, y: 0.05638235670242908d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2423458749174371d, y: 0.39211131662974197d), new NpgsqlTypes.NpgsqlPoint(x: 0.47056287840142097d, y: 0.728331519262386d), new NpgsqlTypes.NpgsqlPoint(x: 0.8973329913205286d, y: 0.12919717419295063d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03814412062556338d, y: 0.09891013712022656d), new NpgsqlTypes.NpgsqlPoint(x: 0.15938613995519946d, y: 0.5486020264361943d), new NpgsqlTypes.NpgsqlPoint(x: 0.6572114133652867d, y: 0.05451364672826531d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6308365485438107d, y: 0.16977055853909684d), new NpgsqlTypes.NpgsqlPoint(x: 0.5278229566373338d, y: 0.6463284969661491d), new NpgsqlTypes.NpgsqlPoint(x: 0.1308616585365231d, y: 0.37331974954020364d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7738320284119933d, y: 0.7814071202525279d), new NpgsqlTypes.NpgsqlPoint(x: 0.033819261464238304d, y: 0.11686463084994703d), new NpgsqlTypes.NpgsqlPoint(x: 0.31787601409401844d, y: 0.03882987150009054d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2493643907209281d, y: 0.6594019902997864d), new NpgsqlTypes.NpgsqlPoint(x: 0.022321825171790044d, y: 0.02390648592309008d), new NpgsqlTypes.NpgsqlPoint(x: 0.0840284314152766d, y: 0.5852276285009061d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5416643753885094d, y: 0.669751835564623d), new NpgsqlTypes.NpgsqlPoint(x: 0.8209849560624606d, y: 0.13040801103554156d), new NpgsqlTypes.NpgsqlPoint(x: 0.7337349728087555d, y: 0.8259986111328755d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14226230621201175d, y: 0.39160275697414937d), new NpgsqlTypes.NpgsqlPoint(x: 0.18010052627986106d, y: 0.804405073355611d), new NpgsqlTypes.NpgsqlPoint(x: 0.9604818946935836d, y: 0.9784286831725346d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3135398401336079d, y: 0.3353509583189046d), new NpgsqlTypes.NpgsqlPoint(x: 0.11516959204962118d, y: 0.5023375021349141d), new NpgsqlTypes.NpgsqlPoint(x: 0.782208589105797d, y: 0.9660240805733058d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19110369542315753d, y: 0.033587269390778496d), new NpgsqlTypes.NpgsqlPoint(x: 0.5894576060732399d, y: 0.21303013557567518d), new NpgsqlTypes.NpgsqlPoint(x: 0.15812881858535144d, y: 0.5586309200943449d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43289207914358596d, y: 0.39754722248156626d), new NpgsqlTypes.NpgsqlPoint(x: 0.30497900862731375d, y: 0.001542680547312103d), new NpgsqlTypes.NpgsqlPoint(x: 0.8783526720878497d, y: 0.9480475805539518d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4587538446686884d, y: 0.7674534812983113d), new NpgsqlTypes.NpgsqlPoint(x: 0.27909267633506596d, y: 0.20868895350831185d), new NpgsqlTypes.NpgsqlPoint(x: 0.11089936986992133d, y: 0.16557173329152985d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6417848768102097d, y: 0.29242285939072366d), new NpgsqlTypes.NpgsqlPoint(x: 0.12157268116700182d, y: 0.8527554474003668d), new NpgsqlTypes.NpgsqlPoint(x: 0.8678480071609784d, y: 0.5034888092419781d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27519888239119605d, y: 0.20798547694801528d), new NpgsqlTypes.NpgsqlPoint(x: 0.9728995689253432d, y: 0.5696172944644543d), new NpgsqlTypes.NpgsqlPoint(x: 0.33094111713789665d, y: 0.8739227672247056d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.044095120331199555d, y: 0.749275830627916d), new NpgsqlTypes.NpgsqlPoint(x: 0.8671331910350135d, y: 0.24200064664306808d), new NpgsqlTypes.NpgsqlPoint(x: 0.43569204632569725d, y: 0.298311280419997d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17726395299075814d, y: 0.3162910062958635d), new NpgsqlTypes.NpgsqlPoint(x: 0.13703624197036057d, y: 0.5497267667150636d), new NpgsqlTypes.NpgsqlPoint(x: 0.5606774253948332d, y: 0.16543040271170617d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29904273633800904d, y: 0.09971048871766386d), new NpgsqlTypes.NpgsqlPoint(x: 0.58818283622413d, y: 0.2662603809212304d), new NpgsqlTypes.NpgsqlPoint(x: 0.2506788321355129d, y: 0.9795189368364852d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7665482335221028d, y: 0.4825853661018501d), new NpgsqlTypes.NpgsqlPoint(x: 0.06874437555503221d, y: 0.538719252197956d), new NpgsqlTypes.NpgsqlPoint(x: 0.9290728887768079d, y: 0.039579765144436285d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4091940377044684d, y: 0.9660492525892032d), new NpgsqlTypes.NpgsqlPoint(x: 0.3102472984826733d, y: 0.6277927070792746d), new NpgsqlTypes.NpgsqlPoint(x: 0.551178456818438d, y: 0.803781697350052d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9284968237442347d, y: 0.4730194843474187d), new NpgsqlTypes.NpgsqlPoint(x: 0.7159333096729438d, y: 0.5496111347701325d), new NpgsqlTypes.NpgsqlPoint(x: 0.8219400622520298d, y: 0.6738250565558561d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3024455812117811d, y: 0.8735311977895869d), new NpgsqlTypes.NpgsqlPoint(x: 0.6833088213495788d, y: 0.13051426037210967d), new NpgsqlTypes.NpgsqlPoint(x: 0.546983761280775d, y: 0.6730577808778717d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6854827969161542d, y: 0.6528652927273503d), new NpgsqlTypes.NpgsqlPoint(x: 0.46884752186402756d, y: 0.6688983838460152d), new NpgsqlTypes.NpgsqlPoint(x: 0.12704862359632652d, y: 0.7313015564105696d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5108494841183977d, y: 0.22294283776624058d), new NpgsqlTypes.NpgsqlPoint(x: 0.4659359579349768d, y: 0.1569527796659328d), new NpgsqlTypes.NpgsqlPoint(x: 0.4622920280950966d, y: 0.8940072355287277d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39789101081041567d, y: 0.04279623360720741d), new NpgsqlTypes.NpgsqlPoint(x: 0.6059835147363061d, y: 0.008889163319446447d), new NpgsqlTypes.NpgsqlPoint(x: 0.6908007549185886d, y: 0.593222646294529d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11110839513118542d, y: 0.2866039732736607d), new NpgsqlTypes.NpgsqlPoint(x: 0.4001096503233609d, y: 0.8398915432876931d), new NpgsqlTypes.NpgsqlPoint(x: 0.6034784631614369d, y: 0.2035526712221355d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9261125027006877d, y: 0.5301957553967958d), new NpgsqlTypes.NpgsqlPoint(x: 0.2724547674994785d, y: 0.8434760958033684d), new NpgsqlTypes.NpgsqlPoint(x: 0.0011333588357361757d, y: 0.8293376268188016d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1698649599921198d, y: 0.5840337546096664d), new NpgsqlTypes.NpgsqlPoint(x: 0.003463850795250356d, y: 0.4863547455651872d), new NpgsqlTypes.NpgsqlPoint(x: 0.33241933856453665d, y: 0.011952820319753865d)), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18146658958690842d, y: 0.51201692554368d), new NpgsqlTypes.NpgsqlPoint(x: 0.6462451634379172d, y: 0.7920837141289352d), new NpgsqlTypes.NpgsqlPoint(x: 0.65489561498422d, y: 0.5592039440193598d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6108110681696346d, y: 0.8702619386924503d), new NpgsqlTypes.NpgsqlPoint(x: 0.19369021295691402d, y: 0.05516605985618983d), new NpgsqlTypes.NpgsqlPoint(x: 0.9362592678705266d, y: 0.5025399107652578d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08309234904992491d, y: 0.16311746368616797d), new NpgsqlTypes.NpgsqlPoint(x: 0.3799620248596053d, y: 0.32016164541904d), new NpgsqlTypes.NpgsqlPoint(x: 0.8367893551277977d, y: 0.1940557767147485d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4952967259946368d, y: 0.7756732666109786d), new NpgsqlTypes.NpgsqlPoint(x: 0.9875934888788733d, y: 0.5669557058131678d), new NpgsqlTypes.NpgsqlPoint(x: 0.5845018091834029d, y: 0.9521910719917951d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9650738874383036d, y: 0.975823715098389d), new NpgsqlTypes.NpgsqlPoint(x: 0.5320482574641098d, y: 0.6372623892345319d), new NpgsqlTypes.NpgsqlPoint(x: 0.6224971585652155d, y: 0.9232594017227351d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5213272881314844d, y: 0.39051862236935064d), new NpgsqlTypes.NpgsqlPoint(x: 0.721208563020007d, y: 0.44975572949998d), new NpgsqlTypes.NpgsqlPoint(x: 0.9801968584750675d, y: 0.35555118193446567d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024801199394476336d, y: 0.8642971502111105d), new NpgsqlTypes.NpgsqlPoint(x: 0.18658623655513285d, y: 0.12757953253436416d), new NpgsqlTypes.NpgsqlPoint(x: 0.31110072384694865d, y: 0.8278464451741545d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9558617830226963d, y: 0.6960544640669609d), new NpgsqlTypes.NpgsqlPoint(x: 0.1633172958541762d, y: 0.07518410851610058d), new NpgsqlTypes.NpgsqlPoint(x: 0.6913912760604419d, y: 0.7365154939318892d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.176617496315d, y: 0.565592990133966d), new NpgsqlTypes.NpgsqlPoint(x: 0.7118250266648705d, y: 0.7378141126947771d), new NpgsqlTypes.NpgsqlPoint(x: 0.3652861127488167d, y: 0.11655555668413664d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.165911639029381d, y: 0.8438728240538286d), new NpgsqlTypes.NpgsqlPoint(x: 0.08199093563104876d, y: 0.9209901019907512d), new NpgsqlTypes.NpgsqlPoint(x: 0.21681485567332415d, y: 0.17199051299906776d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5871362858579146d, y: 0.4110476698868407d), new NpgsqlTypes.NpgsqlPoint(x: 0.022621544548549588d, y: 0.5711023400728656d), new NpgsqlTypes.NpgsqlPoint(x: 0.7100278619606702d, y: 0.8954728253178695d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9287699248250179d, y: 0.9584895070822674d), new NpgsqlTypes.NpgsqlPoint(x: 0.7574443258544822d, y: 0.5934645992018593d), new NpgsqlTypes.NpgsqlPoint(x: 0.3842313567109942d, y: 0.8093337131105502d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6514526099628644d, y: 0.07583755786397006d), new NpgsqlTypes.NpgsqlPoint(x: 0.17907453544034113d, y: 0.10460306183316803d), new NpgsqlTypes.NpgsqlPoint(x: 0.15455365164257817d, y: 0.5722086890947615d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6107203549884622d, y: 0.4869273704683448d), new NpgsqlTypes.NpgsqlPoint(x: 0.587669651604706d, y: 0.5418139448431409d), new NpgsqlTypes.NpgsqlPoint(x: 0.7791758080039124d, y: 0.890466309517528d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2611478767372609d, y: 0.34903781426175684d), new NpgsqlTypes.NpgsqlPoint(x: 0.1822921994353046d, y: 0.2627622411739293d), new NpgsqlTypes.NpgsqlPoint(x: 0.5750397266653318d, y: 0.7114984951987837d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1474560881663971d, y: 0.9405597816729923d), new NpgsqlTypes.NpgsqlPoint(x: 0.7070663618312646d, y: 0.5547786908076152d), new NpgsqlTypes.NpgsqlPoint(x: 0.5954720012599123d, y: 0.8830396977201164d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8878645048777559d, y: 0.3860541085128143d), new NpgsqlTypes.NpgsqlPoint(x: 0.2669775816793827d, y: 0.7356925020857612d), new NpgsqlTypes.NpgsqlPoint(x: 0.16550972133534425d, y: 0.004297616732018561d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8632708159080689d, y: 0.38213616583661913d), new NpgsqlTypes.NpgsqlPoint(x: 0.1335577987072888d, y: 0.6298820355637343d), new NpgsqlTypes.NpgsqlPoint(x: 0.030464400436452155d, y: 0.5076597770768269d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4349865902232154d, y: 0.33031718390430076d), new NpgsqlTypes.NpgsqlPoint(x: 0.13098858083994458d, y: 0.25972849829021716d), new NpgsqlTypes.NpgsqlPoint(x: 0.6116778794364182d, y: 0.9399398644899032d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3116505518148399d, y: 0.15338335602440745d), new NpgsqlTypes.NpgsqlPoint(x: 0.17418263616969043d, y: 0.8915772903762247d), new NpgsqlTypes.NpgsqlPoint(x: 0.15475783869600246d, y: 0.9162412779520782d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13456022418146096d, y: 0.8826043157184438d), new NpgsqlTypes.NpgsqlPoint(x: 0.213694838479895d, y: 0.7252566119108057d), new NpgsqlTypes.NpgsqlPoint(x: 0.20472543079245864d, y: 0.8974906709884932d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9619578079534818d, y: 0.1816275012944829d), new NpgsqlTypes.NpgsqlPoint(x: 0.35675801024733267d, y: 0.28440267601823577d), new NpgsqlTypes.NpgsqlPoint(x: 0.9450562552244924d, y: 0.5113857792988021d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9169511892643176d, y: 0.30840944621129096d), new NpgsqlTypes.NpgsqlPoint(x: 0.9300595507481666d, y: 0.36866776198181483d), new NpgsqlTypes.NpgsqlPoint(x: 0.4354727397287488d, y: 0.9226457229470194d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0030294893468362227d, y: 0.6840295090023449d), new NpgsqlTypes.NpgsqlPoint(x: 0.3700524146155111d, y: 0.612536577334335d), new NpgsqlTypes.NpgsqlPoint(x: 0.7973177820799949d, y: 0.9785462950511454d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4943221265756661d, y: 0.8567927937173794d), new NpgsqlTypes.NpgsqlPoint(x: 0.5022802410556879d, y: 0.721429879103321d), new NpgsqlTypes.NpgsqlPoint(x: 0.18690235531126864d, y: 0.7599524565938561d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14205120363914814d, y: 0.3277661114493814d), new NpgsqlTypes.NpgsqlPoint(x: 0.28632037044001535d, y: 0.8409177229628996d), new NpgsqlTypes.NpgsqlPoint(x: 0.716813667302962d, y: 0.1979514854642377d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7272542018209543d, y: 0.5787078997673348d), new NpgsqlTypes.NpgsqlPoint(x: 0.5492756936611608d, y: 0.35566447382291666d), new NpgsqlTypes.NpgsqlPoint(x: 0.717393446152564d, y: 0.4221834378615509d)), }, }, },
    ModelInner = new NpgsqlPathpathMMArrayD3E1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11281445118927957d, y: 0.3033414795115953d), new NpgsqlTypes.NpgsqlPoint(x: 0.30053664178431083d, y: 0.4394752696721591d), new NpgsqlTypes.NpgsqlPoint(x: 0.033103751173743756d, y: 0.34377469512529246d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02393529973402364d, y: 0.9542741765224052d), new NpgsqlTypes.NpgsqlPoint(x: 0.46699738664113566d, y: 0.31256738352731506d), new NpgsqlTypes.NpgsqlPoint(x: 0.06883785571183576d, y: 0.5294595302288931d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6794422502473805d, y: 0.44732744462787744d), new NpgsqlTypes.NpgsqlPoint(x: 0.45872236128167576d, y: 0.005559909083998504d), new NpgsqlTypes.NpgsqlPoint(x: 0.40184898784508305d, y: 0.8035876526916426d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012601447329215754d, y: 0.4946932582194987d), new NpgsqlTypes.NpgsqlPoint(x: 0.5079995909034023d, y: 0.45261830421505633d), new NpgsqlTypes.NpgsqlPoint(x: 0.898857569833845d, y: 0.45136692821394586d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8120827868285729d, y: 0.33776234269722105d), new NpgsqlTypes.NpgsqlPoint(x: 0.3058565832952316d, y: 0.7497904452644251d), new NpgsqlTypes.NpgsqlPoint(x: 0.3536568451424619d, y: 0.2331304351227962d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0556706941230114d, y: 0.07501663083569488d), new NpgsqlTypes.NpgsqlPoint(x: 0.15171267096813112d, y: 0.07384419579743162d), new NpgsqlTypes.NpgsqlPoint(x: 0.8735022233349308d, y: 0.9755132308044043d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6428406989534612d, y: 0.5021486305773002d), new NpgsqlTypes.NpgsqlPoint(x: 0.5488418661797141d, y: 0.585530293756153d), new NpgsqlTypes.NpgsqlPoint(x: 0.42593244780431716d, y: 0.5194600815649009d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2106171191271876d, y: 0.29329542873746217d), new NpgsqlTypes.NpgsqlPoint(x: 0.6876899546204225d, y: 0.19377209727981326d), new NpgsqlTypes.NpgsqlPoint(x: 0.28793455184102856d, y: 0.5236060760678971d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8144348863865408d, y: 0.7049622745190292d), new NpgsqlTypes.NpgsqlPoint(x: 0.3959891199617107d, y: 0.09142027339282144d), new NpgsqlTypes.NpgsqlPoint(x: 0.05005101263016187d, y: 0.4009413501416098d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.186664061147638d, y: 0.05697224760088515d), new NpgsqlTypes.NpgsqlPoint(x: 0.1008053102388573d, y: 0.016295558629588314d), new NpgsqlTypes.NpgsqlPoint(x: 0.26321931823129796d, y: 0.3958603071373734d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7062510965081182d, y: 0.552097793813405d), new NpgsqlTypes.NpgsqlPoint(x: 0.8158530812918435d, y: 0.05406871583370698d), new NpgsqlTypes.NpgsqlPoint(x: 0.9014927367875507d, y: 0.9519140185667277d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2928692255422951d, y: 0.2907553040375451d), new NpgsqlTypes.NpgsqlPoint(x: 0.13615306233336666d, y: 0.04149779905921702d), new NpgsqlTypes.NpgsqlPoint(x: 0.9207904288859269d, y: 0.07040964171622677d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3890020151793059d, y: 0.07393104108998327d), new NpgsqlTypes.NpgsqlPoint(x: 0.07034540799693423d, y: 0.5002148800089704d), new NpgsqlTypes.NpgsqlPoint(x: 0.31486405696169284d, y: 0.40935990305470127d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3790561258550127d, y: 0.5284711658526703d), new NpgsqlTypes.NpgsqlPoint(x: 0.8545765443573081d, y: 0.4093300438542702d), new NpgsqlTypes.NpgsqlPoint(x: 0.3780127851171574d, y: 0.40018604168644045d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3193262961614707d, y: 0.679093647333275d), new NpgsqlTypes.NpgsqlPoint(x: 0.4313911207947072d, y: 0.7061427573337228d), new NpgsqlTypes.NpgsqlPoint(x: 0.4321433568010711d, y: 0.9646890714760857d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7611966335726654d, y: 0.31808103616296d), new NpgsqlTypes.NpgsqlPoint(x: 0.05260696319443492d, y: 0.711003550252382d), new NpgsqlTypes.NpgsqlPoint(x: 0.3663696782362852d, y: 0.5189463994459963d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7666012418448092d, y: 0.0970211964950074d), new NpgsqlTypes.NpgsqlPoint(x: 0.5432012101383281d, y: 0.9194341429598085d), new NpgsqlTypes.NpgsqlPoint(x: 0.46341221489829354d, y: 0.8960990852441968d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1152756982159523d, y: 0.576608835683563d), new NpgsqlTypes.NpgsqlPoint(x: 0.6551669634825168d, y: 0.5546821845186514d), new NpgsqlTypes.NpgsqlPoint(x: 0.330555931572347d, y: 0.35650431908384783d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2341601522390644d, y: 0.8206970869110947d), new NpgsqlTypes.NpgsqlPoint(x: 0.5850136781231167d, y: 0.5157253841837416d), new NpgsqlTypes.NpgsqlPoint(x: 0.5570854868087556d, y: 0.16437047974798202d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7748953651236004d, y: 0.7637402606505458d), new NpgsqlTypes.NpgsqlPoint(x: 0.5949766601439137d, y: 0.35490392696873696d), new NpgsqlTypes.NpgsqlPoint(x: 0.008737477291891893d, y: 0.23642830751874666d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37076056100972277d, y: 0.3037597150517197d), new NpgsqlTypes.NpgsqlPoint(x: 0.5346686614273972d, y: 0.06752590916127132d), new NpgsqlTypes.NpgsqlPoint(x: 0.6673136253928621d, y: 0.1630023532742042d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30356892911257904d, y: 0.3692222094765891d), new NpgsqlTypes.NpgsqlPoint(x: 0.22092413832033686d, y: 0.4320279593057429d), new NpgsqlTypes.NpgsqlPoint(x: 0.8021247046718477d, y: 0.5766206976989013d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25009704256804355d, y: 0.9039648063048508d), new NpgsqlTypes.NpgsqlPoint(x: 0.1946541001752533d, y: 0.4034520636359199d), new NpgsqlTypes.NpgsqlPoint(x: 0.8397709251623949d, y: 0.7917588270675243d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3488626549046224d, y: 0.6631718901861349d), new NpgsqlTypes.NpgsqlPoint(x: 0.6493161679459903d, y: 0.7941324362593463d), new NpgsqlTypes.NpgsqlPoint(x: 0.06890134538359782d, y: 0.6141561293076968d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9461519271311681d, y: 0.0454542546685176d), new NpgsqlTypes.NpgsqlPoint(x: 0.4458411716892664d, y: 0.7948164203412161d), new NpgsqlTypes.NpgsqlPoint(x: 0.4712408074614238d, y: 0.27983826868191364d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3059120610179331d, y: 0.8465340489700394d), new NpgsqlTypes.NpgsqlPoint(x: 0.6914729977182353d, y: 0.5622463567767088d), new NpgsqlTypes.NpgsqlPoint(x: 0.6653247151289402d, y: 0.76459491118453d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6077675634025611d, y: 0.24773379068897372d), new NpgsqlTypes.NpgsqlPoint(x: 0.8531847876940745d, y: 0.9931083350464078d), new NpgsqlTypes.NpgsqlPoint(x: 0.1992984707658335d, y: 0.5132354532875726d)), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12903459885788504d, y: 0.5591675506475501d), new NpgsqlTypes.NpgsqlPoint(x: 0.17056083274784828d, y: 0.2078990422592386d), new NpgsqlTypes.NpgsqlPoint(x: 0.5337673619971136d, y: 0.04354253074086589d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8750444036148638d, y: 0.14034739763542803d), new NpgsqlTypes.NpgsqlPoint(x: 0.012830334546997557d, y: 0.5012981372240419d), new NpgsqlTypes.NpgsqlPoint(x: 0.6517553677129153d, y: 0.7339967784486211d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7532456372469402d, y: 0.8177666355957078d), new NpgsqlTypes.NpgsqlPoint(x: 0.9401138681253207d, y: 0.8944123533539831d), new NpgsqlTypes.NpgsqlPoint(x: 0.23602259035611606d, y: 0.8106123571426577d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10861301594123107d, y: 0.9699770461962038d), new NpgsqlTypes.NpgsqlPoint(x: 0.1342420649706323d, y: 0.1589267427840395d), new NpgsqlTypes.NpgsqlPoint(x: 0.15575053444755593d, y: 0.7601970745077659d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12540338227743164d, y: 0.049763884324865115d), new NpgsqlTypes.NpgsqlPoint(x: 0.20620221453561605d, y: 0.8690843280761976d), new NpgsqlTypes.NpgsqlPoint(x: 0.4796182092123712d, y: 0.38817051025160265d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4371676088236859d, y: 0.1269676510673423d), new NpgsqlTypes.NpgsqlPoint(x: 0.8040217319566555d, y: 0.07082799826080621d), new NpgsqlTypes.NpgsqlPoint(x: 0.6635462902044507d, y: 0.763019005315355d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.916124448014048d, y: 0.8672008223026493d), new NpgsqlTypes.NpgsqlPoint(x: 0.567131185833312d, y: 0.2074009673376107d), new NpgsqlTypes.NpgsqlPoint(x: 0.27505774027191565d, y: 0.49348223440486305d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8267295971369375d, y: 0.8696687552501295d), new NpgsqlTypes.NpgsqlPoint(x: 0.10683753588694167d, y: 0.8586894435861633d), new NpgsqlTypes.NpgsqlPoint(x: 0.4344546400782324d, y: 0.149466214666095d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41321696399222485d, y: 0.04246323067050872d), new NpgsqlTypes.NpgsqlPoint(x: 0.8733813098368569d, y: 0.2975854998138413d), new NpgsqlTypes.NpgsqlPoint(x: 0.3986046603648673d, y: 0.005070241749331905d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5815710107734644d, y: 0.30189596014928066d), new NpgsqlTypes.NpgsqlPoint(x: 0.6647909599788325d, y: 0.8288986605697887d), new NpgsqlTypes.NpgsqlPoint(x: 0.26473353769430363d, y: 0.08697583110257667d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6270569618532884d, y: 0.481654152385503d), new NpgsqlTypes.NpgsqlPoint(x: 0.8069711583194394d, y: 0.3832117533695676d), new NpgsqlTypes.NpgsqlPoint(x: 0.7418789916487954d, y: 0.0031641401318216467d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4468554102886053d, y: 0.4576257029166374d), new NpgsqlTypes.NpgsqlPoint(x: 0.7946032256627934d, y: 0.7015791317893217d), new NpgsqlTypes.NpgsqlPoint(x: 0.5117235031443301d, y: 0.4539280545896033d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3516681774451078d, y: 0.430225423653784d), new NpgsqlTypes.NpgsqlPoint(x: 0.34747249002321356d, y: 0.8669198232744297d), new NpgsqlTypes.NpgsqlPoint(x: 0.6048301772419168d, y: 0.29829335651136124d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8112414305110722d, y: 0.4490043297096462d), new NpgsqlTypes.NpgsqlPoint(x: 0.9372045931404124d, y: 0.7519195835196538d), new NpgsqlTypes.NpgsqlPoint(x: 0.5933365510371451d, y: 0.6133191836756164d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12624091605045584d, y: 0.5717943210745258d), new NpgsqlTypes.NpgsqlPoint(x: 0.35237076525250055d, y: 0.2284282108929554d), new NpgsqlTypes.NpgsqlPoint(x: 0.1265262803711772d, y: 0.666951140645267d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09994863568970991d, y: 0.3041485721437819d), new NpgsqlTypes.NpgsqlPoint(x: 0.9873482802826783d, y: 0.03320930259992272d), new NpgsqlTypes.NpgsqlPoint(x: 0.054506984854231555d, y: 0.34800554240808756d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.512594566385504d, y: 0.6313620935897799d), new NpgsqlTypes.NpgsqlPoint(x: 0.6395026589658337d, y: 0.9010524366835203d), new NpgsqlTypes.NpgsqlPoint(x: 0.4134903342223586d, y: 0.354683746445161d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7493332828147902d, y: 0.048578209913781145d), new NpgsqlTypes.NpgsqlPoint(x: 0.4132359662106416d, y: 0.3579579922599727d), new NpgsqlTypes.NpgsqlPoint(x: 0.5700310596327857d, y: 0.30227767444783626d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1215357552472709d, y: 0.29877623940824993d), new NpgsqlTypes.NpgsqlPoint(x: 0.7265451054738341d, y: 0.4107363934305779d), new NpgsqlTypes.NpgsqlPoint(x: 0.48516102916325876d, y: 0.2497520232115611d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11521783853462475d, y: 0.7513667388012942d), new NpgsqlTypes.NpgsqlPoint(x: 0.3478050913751498d, y: 0.2870213264887389d), new NpgsqlTypes.NpgsqlPoint(x: 0.5025265560656678d, y: 0.4449369278844705d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7711585686120859d, y: 0.7708615587698239d), new NpgsqlTypes.NpgsqlPoint(x: 0.21181779220738606d, y: 0.25256895144878855d), new NpgsqlTypes.NpgsqlPoint(x: 0.18218600632640947d, y: 0.519836332985858d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15895935807096395d, y: 0.3344613971376691d), new NpgsqlTypes.NpgsqlPoint(x: 0.8515587066296946d, y: 0.6773926496364018d), new NpgsqlTypes.NpgsqlPoint(x: 0.944502557592404d, y: 0.603898345156011d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04579584105462586d, y: 0.2688544661814677d), new NpgsqlTypes.NpgsqlPoint(x: 0.19752999846814612d, y: 0.7729947216041838d), new NpgsqlTypes.NpgsqlPoint(x: 0.6678819990862106d, y: 0.051831641638397485d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9190292084899668d, y: 0.6018753907165915d), new NpgsqlTypes.NpgsqlPoint(x: 0.2099024152122415d, y: 0.4751221297066207d), new NpgsqlTypes.NpgsqlPoint(x: 0.726884413042318d, y: 0.1544178127667688d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33452704055913296d, y: 0.5168809831483011d), new NpgsqlTypes.NpgsqlPoint(x: 0.948994347624985d, y: 0.050525682942832106d), new NpgsqlTypes.NpgsqlPoint(x: 0.8446756173473959d, y: 0.7835566982647411d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15543009273932595d, y: 0.5311046961396705d), new NpgsqlTypes.NpgsqlPoint(x: 0.840620052764341d, y: 0.5928318339089959d), new NpgsqlTypes.NpgsqlPoint(x: 0.7167797805771327d, y: 0.5435268739841465d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04251613511821151d, y: 0.7034489880437919d), new NpgsqlTypes.NpgsqlPoint(x: 0.5568530354994825d, y: 0.026915956122846918d), new NpgsqlTypes.NpgsqlPoint(x: 0.38954261074199836d, y: 0.16763912896355926d)), }, }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07859367744044343d, y: 0.9411796073674689d), new NpgsqlTypes.NpgsqlPoint(x: 0.1643266849665762d, y: 0.5645907547275761d), new NpgsqlTypes.NpgsqlPoint(x: 0.8550717395772148d, y: 0.7161975115713646d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20220667547944626d, y: 0.8817782310494561d), new NpgsqlTypes.NpgsqlPoint(x: 0.7136104314837667d, y: 0.6169940516456837d), new NpgsqlTypes.NpgsqlPoint(x: 0.8002981702011146d, y: 0.9759515135515436d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4367397073653718d, y: 0.5051467187710408d), new NpgsqlTypes.NpgsqlPoint(x: 0.17440064221515938d, y: 0.01306281646722851d), new NpgsqlTypes.NpgsqlPoint(x: 0.056641051182737656d, y: 0.3421917562225405d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14703186868900964d, y: 0.9168962019615926d), new NpgsqlTypes.NpgsqlPoint(x: 0.47669273270438495d, y: 0.6777533942186217d), new NpgsqlTypes.NpgsqlPoint(x: 0.2594802477603618d, y: 0.44735165001608423d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23620556776762436d, y: 0.3801181699517667d), new NpgsqlTypes.NpgsqlPoint(x: 0.681980561196828d, y: 0.9671741437970912d), new NpgsqlTypes.NpgsqlPoint(x: 0.9845354026291736d, y: 0.9137544078581032d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6565480470191668d, y: 0.09534005065411744d), new NpgsqlTypes.NpgsqlPoint(x: 0.8802978060990968d, y: 0.4241212936190587d), new NpgsqlTypes.NpgsqlPoint(x: 0.8818509327596168d, y: 0.7291230235788331d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8765567757214964d, y: 0.18675894238090152d), new NpgsqlTypes.NpgsqlPoint(x: 0.6937945531881857d, y: 0.9525815043044915d), new NpgsqlTypes.NpgsqlPoint(x: 0.9587108050086312d, y: 0.6156395465202357d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07101046951842405d, y: 0.9537855178620176d), new NpgsqlTypes.NpgsqlPoint(x: 0.9903880656990414d, y: 0.7228962601868358d), new NpgsqlTypes.NpgsqlPoint(x: 0.6238901967245498d, y: 0.20705470689961591d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31663030300001693d, y: 0.40048161959347606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5487657125328895d, y: 0.8169578029701187d), new NpgsqlTypes.NpgsqlPoint(x: 0.49450955318293066d, y: 0.4867743062608988d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3966713758214443d, y: 0.08987904886373099d), new NpgsqlTypes.NpgsqlPoint(x: 0.6547935980370124d, y: 0.6448577978215821d), new NpgsqlTypes.NpgsqlPoint(x: 0.2484074899802955d, y: 0.5341419946629619d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5656425199095904d, y: 0.6466209468602473d), new NpgsqlTypes.NpgsqlPoint(x: 0.1084641242378962d, y: 0.6040743154419774d), new NpgsqlTypes.NpgsqlPoint(x: 0.768425330515201d, y: 0.5792815682528432d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2925766142951104d, y: 0.5838583069541327d), new NpgsqlTypes.NpgsqlPoint(x: 0.6842343112873036d, y: 0.3428889410530721d), new NpgsqlTypes.NpgsqlPoint(x: 0.8583448904447705d, y: 0.25489141121866377d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6058178662165583d, y: 0.40128894192113784d), new NpgsqlTypes.NpgsqlPoint(x: 0.9932669649284547d, y: 0.2552171243679682d), new NpgsqlTypes.NpgsqlPoint(x: 0.3063004158663081d, y: 0.8069672601815089d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0286019707863987d, y: 0.615769836969268d), new NpgsqlTypes.NpgsqlPoint(x: 0.4218491263488314d, y: 0.8359048292134195d), new NpgsqlTypes.NpgsqlPoint(x: 0.8481597794150133d, y: 0.5584834122168625d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7687620165473626d, y: 0.017956635372265994d), new NpgsqlTypes.NpgsqlPoint(x: 0.3362804005294885d, y: 0.8571648410237404d), new NpgsqlTypes.NpgsqlPoint(x: 0.6396949778018524d, y: 0.45360730767554935d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31006064761634256d, y: 0.8790552550529885d), new NpgsqlTypes.NpgsqlPoint(x: 0.32625019983919845d, y: 0.5719736480318084d), new NpgsqlTypes.NpgsqlPoint(x: 0.824635232531152d, y: 0.36769464909146843d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22461797172746367d, y: 0.049929715505641514d), new NpgsqlTypes.NpgsqlPoint(x: 0.14325564969426796d, y: 0.944509003619809d), new NpgsqlTypes.NpgsqlPoint(x: 0.22654706877953468d, y: 0.3114577271970087d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6361398092095801d, y: 0.7901856781378479d), new NpgsqlTypes.NpgsqlPoint(x: 0.439490242314712d, y: 0.4872768097210153d), new NpgsqlTypes.NpgsqlPoint(x: 0.9836564998946211d, y: 0.6036209514900307d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08460940150189578d, y: 0.3311338929374563d), new NpgsqlTypes.NpgsqlPoint(x: 0.5440726785287551d, y: 0.16654376079905153d), new NpgsqlTypes.NpgsqlPoint(x: 0.7418158304381325d, y: 0.048418346599817474d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.686107349477477d, y: 0.2768605068472827d), new NpgsqlTypes.NpgsqlPoint(x: 0.7140974660039472d, y: 0.7228004696793824d), new NpgsqlTypes.NpgsqlPoint(x: 0.11852090799189763d, y: 0.017129498330599735d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.84254667829668d, y: 0.7131968844946343d), new NpgsqlTypes.NpgsqlPoint(x: 0.8381511950758702d, y: 0.09939412250752389d), new NpgsqlTypes.NpgsqlPoint(x: 0.6206838003997309d, y: 0.9517466715858612d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5296318058954237d, y: 0.8916191306344562d), new NpgsqlTypes.NpgsqlPoint(x: 0.5512354982588672d, y: 0.9041468993518187d), new NpgsqlTypes.NpgsqlPoint(x: 0.716174368707263d, y: 0.05987867263695967d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7960524710308626d, y: 0.24896940782461197d), new NpgsqlTypes.NpgsqlPoint(x: 0.3636691200050022d, y: 0.436933036721469d), new NpgsqlTypes.NpgsqlPoint(x: 0.04718556496920545d, y: 0.9254842168719123d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9165037349853475d, y: 0.04712672242454641d), new NpgsqlTypes.NpgsqlPoint(x: 0.6820505114456162d, y: 0.7914883942382721d), new NpgsqlTypes.NpgsqlPoint(x: 0.7427390221622919d, y: 0.9325305314814324d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5292270695522934d, y: 0.8462540358678966d), new NpgsqlTypes.NpgsqlPoint(x: 0.7678467381466184d, y: 0.07420515830932439d), new NpgsqlTypes.NpgsqlPoint(x: 0.04232141186712379d, y: 0.27675590103877046d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.011176427177562509d, y: 0.23513855095873326d), new NpgsqlTypes.NpgsqlPoint(x: 0.435658708329812d, y: 0.7160769919698798d), new NpgsqlTypes.NpgsqlPoint(x: 0.22754472769362322d, y: 0.8941429259972673d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6820077178923063d, y: 0.5846500598679263d), new NpgsqlTypes.NpgsqlPoint(x: 0.8395598977118154d, y: 0.9602573224812204d), new NpgsqlTypes.NpgsqlPoint(x: 0.7130906176547361d, y: 0.9384917171222649d)), }, }, },
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8072763449717933d, y: 0.022357174450581385d), new NpgsqlTypes.NpgsqlPoint(x: 0.593680330774149d, y: 0.581998548530966d), new NpgsqlTypes.NpgsqlPoint(x: 0.42514881466708954d, y: 0.4265298674376877d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9986258912842737d, y: 0.5611544771522149d), new NpgsqlTypes.NpgsqlPoint(x: 0.5464430490513995d, y: 0.4330447772251207d), new NpgsqlTypes.NpgsqlPoint(x: 0.7756947149345143d, y: 0.15566823961958975d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8814548017530711d, y: 0.3687791218026719d), new NpgsqlTypes.NpgsqlPoint(x: 0.22184462360645663d, y: 0.5609848421233038d), new NpgsqlTypes.NpgsqlPoint(x: 0.05646959243272465d, y: 0.7635549952479259d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3085685989130098d, y: 0.7669409338671701d), new NpgsqlTypes.NpgsqlPoint(x: 0.5443700547557029d, y: 0.9016402037776435d), new NpgsqlTypes.NpgsqlPoint(x: 0.5499374302573715d, y: 0.8153372667303002d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18658406713195352d, y: 0.6220153616311422d), new NpgsqlTypes.NpgsqlPoint(x: 0.580659962706911d, y: 0.41024734332523816d), new NpgsqlTypes.NpgsqlPoint(x: 0.05736012038425109d, y: 0.3885708150587781d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6232127574944707d, y: 0.7529526118045496d), new NpgsqlTypes.NpgsqlPoint(x: 0.10087125936869379d, y: 0.31927640694500037d), new NpgsqlTypes.NpgsqlPoint(x: 0.6662987754384772d, y: 0.5554238182986126d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9500379944871885d, y: 0.9415934222041693d), new NpgsqlTypes.NpgsqlPoint(x: 0.24057671245810597d, y: 0.09379492638101972d), new NpgsqlTypes.NpgsqlPoint(x: 0.9618060872010497d, y: 0.7097956167174879d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14492456812961263d, y: 0.5463498683931277d), new NpgsqlTypes.NpgsqlPoint(x: 0.8063784730948906d, y: 0.49571897274757737d), new NpgsqlTypes.NpgsqlPoint(x: 0.5996863042169911d, y: 0.710788584519477d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3763282464616807d, y: 0.9758434843062248d), new NpgsqlTypes.NpgsqlPoint(x: 0.8068119682757644d, y: 0.8398325476552848d), new NpgsqlTypes.NpgsqlPoint(x: 0.43224745551025756d, y: 0.98770513433817d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12489481875622432d, y: 0.5113612707671856d), new NpgsqlTypes.NpgsqlPoint(x: 0.7561942443784732d, y: 0.7579399871671767d), new NpgsqlTypes.NpgsqlPoint(x: 0.7507780160301379d, y: 0.14759897802534316d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43307453215848335d, y: 0.5325635693452638d), new NpgsqlTypes.NpgsqlPoint(x: 0.4691577900674617d, y: 0.04193388411161969d), new NpgsqlTypes.NpgsqlPoint(x: 0.35298473592797297d, y: 0.4405294754539759d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9408019182479308d, y: 0.5669609648009067d), new NpgsqlTypes.NpgsqlPoint(x: 0.7910104006153358d, y: 0.9143574733892867d), new NpgsqlTypes.NpgsqlPoint(x: 0.4962324220550951d, y: 0.10728618203219387d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3660049557268489d, y: 0.7895063392462083d), new NpgsqlTypes.NpgsqlPoint(x: 0.24763021659233786d, y: 0.41455675598145936d), new NpgsqlTypes.NpgsqlPoint(x: 0.6172306841450176d, y: 0.9759806848018514d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36685046827645995d, y: 0.7881906426922449d), new NpgsqlTypes.NpgsqlPoint(x: 0.10430433644729187d, y: 0.21644659709882175d), new NpgsqlTypes.NpgsqlPoint(x: 0.7881288987121365d, y: 0.7155847362782763d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.021577155529941217d, y: 0.518817858843801d), new NpgsqlTypes.NpgsqlPoint(x: 0.704502095241203d, y: 0.9020973127179881d), new NpgsqlTypes.NpgsqlPoint(x: 0.7460133435684884d, y: 0.22087711992232906d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6719275160456419d, y: 0.1693384183253538d), new NpgsqlTypes.NpgsqlPoint(x: 0.6917085216419442d, y: 0.22983704649778502d), new NpgsqlTypes.NpgsqlPoint(x: 0.7130956286313419d, y: 0.3429898509411463d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2727903203365848d, y: 0.35833009856331755d), new NpgsqlTypes.NpgsqlPoint(x: 0.18802169751925402d, y: 0.4448423054913385d), new NpgsqlTypes.NpgsqlPoint(x: 0.6934711119167896d, y: 0.12352957621034377d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5112007905233834d, y: 0.4348285201505444d), new NpgsqlTypes.NpgsqlPoint(x: 0.6600397801292651d, y: 0.04483383971314925d), new NpgsqlTypes.NpgsqlPoint(x: 0.2643411888449775d, y: 0.5669220537358023d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7859786744096738d, y: 0.18574370598181122d), new NpgsqlTypes.NpgsqlPoint(x: 0.8751439532551696d, y: 0.43041093090904303d), new NpgsqlTypes.NpgsqlPoint(x: 0.8699636490112047d, y: 0.7593859973123942d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2333248953105994d, y: 0.15045386854952358d), new NpgsqlTypes.NpgsqlPoint(x: 0.8442069276039346d, y: 0.02818492835795905d), new NpgsqlTypes.NpgsqlPoint(x: 0.3003327122654068d, y: 0.09851593049451812d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05273948400468753d, y: 0.6955781582701914d), new NpgsqlTypes.NpgsqlPoint(x: 0.5395129849451393d, y: 0.8369515951142913d), new NpgsqlTypes.NpgsqlPoint(x: 0.9765733790923536d, y: 0.9569266741563456d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7272502169052893d, y: 0.509206268033902d), new NpgsqlTypes.NpgsqlPoint(x: 0.7836847510692312d, y: 0.10384968932928595d), new NpgsqlTypes.NpgsqlPoint(x: 0.7500420012728228d, y: 0.40911170149321163d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8142892237193716d, y: 0.21554218234021338d), new NpgsqlTypes.NpgsqlPoint(x: 0.21520691885094512d, y: 0.8505161751152408d), new NpgsqlTypes.NpgsqlPoint(x: 0.7395056611106844d, y: 0.4646780668058609d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4877703247516465d, y: 0.6311704675232231d), new NpgsqlTypes.NpgsqlPoint(x: 0.08612241166629808d, y: 0.9202696691575604d), new NpgsqlTypes.NpgsqlPoint(x: 0.5122196968212323d, y: 0.6161580098963942d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6183016791092774d, y: 0.09392479955181654d), new NpgsqlTypes.NpgsqlPoint(x: 0.9757133016666566d, y: 0.015992999405611275d), new NpgsqlTypes.NpgsqlPoint(x: 0.7872475214795096d, y: 0.29666609572822755d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7263818718534876d, y: 0.1362803478003075d), new NpgsqlTypes.NpgsqlPoint(x: 0.24573167277804664d, y: 0.26334178467392766d), new NpgsqlTypes.NpgsqlPoint(x: 0.41513011829195834d, y: 0.7907885949307478d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9605136524791436d, y: 0.510370813810997d), new NpgsqlTypes.NpgsqlPoint(x: 0.5814780263801846d, y: 0.09355532705480374d), new NpgsqlTypes.NpgsqlPoint(x: 0.3862985067356238d, y: 0.023872473266012162d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27073342337679485d, y: 0.5235290131753615d), new NpgsqlTypes.NpgsqlPoint(x: 0.46010597592192937d, y: 0.38966944509955825d), new NpgsqlTypes.NpgsqlPoint(x: 0.907152500319287d, y: 0.683194534002448d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7836865156519331d, y: 0.7830804301809369d), new NpgsqlTypes.NpgsqlPoint(x: 0.7748526113439889d, y: 0.018910456404255482d), new NpgsqlTypes.NpgsqlPoint(x: 0.33439842600272107d, y: 0.3969606076554878d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.519405472331077d, y: 0.6365525093709206d), new NpgsqlTypes.NpgsqlPoint(x: 0.6278005542418087d, y: 0.019540411359334153d), new NpgsqlTypes.NpgsqlPoint(x: 0.22810655009827652d, y: 0.009725862595267198d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6006342975410726d, y: 0.09479796629547255d), new NpgsqlTypes.NpgsqlPoint(x: 0.05405063168240598d, y: 0.0018630880817918083d), new NpgsqlTypes.NpgsqlPoint(x: 0.18146758166278976d, y: 0.20425642328663307d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23051239987252148d, y: 0.012632749371806362d), new NpgsqlTypes.NpgsqlPoint(x: 0.501209804684115d, y: 0.9335695214791816d), new NpgsqlTypes.NpgsqlPoint(x: 0.5699417467483885d, y: 0.08815296337990597d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.023946879447022562d, y: 0.4816116354196356d), new NpgsqlTypes.NpgsqlPoint(x: 0.964075304664468d, y: 0.421921685475964d), new NpgsqlTypes.NpgsqlPoint(x: 0.7033231739970656d, y: 0.2150490540868757d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9805891553675689d, y: 0.25319362805958334d), new NpgsqlTypes.NpgsqlPoint(x: 0.1901740221209416d, y: 0.12495869306737983d), new NpgsqlTypes.NpgsqlPoint(x: 0.18340615224706291d, y: 0.8864722393374105d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7022046840239569d, y: 0.7336569882779389d), new NpgsqlTypes.NpgsqlPoint(x: 0.8240658046334607d, y: 0.8700923470515736d), new NpgsqlTypes.NpgsqlPoint(x: 0.2107753808428755d, y: 0.7908829698210657d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5678120069202258d, y: 0.8246538786032518d), new NpgsqlTypes.NpgsqlPoint(x: 0.6241795301609818d, y: 0.13725115603116533d), new NpgsqlTypes.NpgsqlPoint(x: 0.5044304301807727d, y: 0.2894914215625851d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5159046508628025d, y: 0.24159915768245044d), new NpgsqlTypes.NpgsqlPoint(x: 0.08118453958821725d, y: 0.05863537077615044d), new NpgsqlTypes.NpgsqlPoint(x: 0.4513086513902824d, y: 0.8151764734034048d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11795216306767853d, y: 0.6889709975946836d), new NpgsqlTypes.NpgsqlPoint(x: 0.44261429009821185d, y: 0.05694164923147271d), new NpgsqlTypes.NpgsqlPoint(x: 0.3866946438311488d, y: 0.18248503029540708d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11844288904694122d, y: 0.7717586731968443d), new NpgsqlTypes.NpgsqlPoint(x: 0.917780954072991d, y: 0.5305557004600788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7475213352676908d, y: 0.4900688375453943d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4396274464103085d, y: 0.33879619867138955d), new NpgsqlTypes.NpgsqlPoint(x: 0.11584270277823416d, y: 0.7030534503428677d), new NpgsqlTypes.NpgsqlPoint(x: 0.3005790961807163d, y: 0.9161161597379702d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5888157970780125d, y: 0.3364750023984536d), new NpgsqlTypes.NpgsqlPoint(x: 0.09767207612232154d, y: 0.2830187857515486d), new NpgsqlTypes.NpgsqlPoint(x: 0.8306254092629733d, y: 0.050586135832468515d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9470726630523525d, y: 0.08390710507549248d), new NpgsqlTypes.NpgsqlPoint(x: 0.2949071019548477d, y: 0.19212017785671764d), new NpgsqlTypes.NpgsqlPoint(x: 0.6014899847965594d, y: 0.745374494170192d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9405503477265938d, y: 0.651433368667788d), new NpgsqlTypes.NpgsqlPoint(x: 0.18496109526693927d, y: 0.6888552600120557d), new NpgsqlTypes.NpgsqlPoint(x: 0.05650285132346211d, y: 0.3321932146741302d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11766762216470106d, y: 0.07272555917912871d), new NpgsqlTypes.NpgsqlPoint(x: 0.8475015202965919d, y: 0.20781127592750137d), new NpgsqlTypes.NpgsqlPoint(x: 0.31956552450989817d, y: 0.4864192410719683d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49130078652875653d, y: 0.27151325181632013d), new NpgsqlTypes.NpgsqlPoint(x: 0.7896499576056294d, y: 0.5860932086821454d), new NpgsqlTypes.NpgsqlPoint(x: 0.9270858463002553d, y: 0.8367617015823194d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5025017472682992d, y: 0.2040284262849562d), new NpgsqlTypes.NpgsqlPoint(x: 0.7071503250310115d, y: 0.5360587387865658d), new NpgsqlTypes.NpgsqlPoint(x: 0.42285432180455895d, y: 0.8862920109689285d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21115157562604103d, y: 0.760395000695896d), new NpgsqlTypes.NpgsqlPoint(x: 0.40595628401334605d, y: 0.12320965560108732d), new NpgsqlTypes.NpgsqlPoint(x: 0.8559078802732083d, y: 0.670419067523237d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16226440546219634d, y: 0.44135918554867526d), new NpgsqlTypes.NpgsqlPoint(x: 0.44857447984641907d, y: 0.4561277830678674d), new NpgsqlTypes.NpgsqlPoint(x: 0.3331055885998174d, y: 0.895755280531048d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5705979635088853d, y: 0.4633288398288128d), new NpgsqlTypes.NpgsqlPoint(x: 0.5616020356023154d, y: 0.11095051154841051d), new NpgsqlTypes.NpgsqlPoint(x: 0.7703961168404302d, y: 0.17523657675099247d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24810137127558995d, y: 0.4998899379887002d), new NpgsqlTypes.NpgsqlPoint(x: 0.2649356410020073d, y: 0.5350135713624128d), new NpgsqlTypes.NpgsqlPoint(x: 0.3808658297341969d, y: 0.6286218329713131d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01727933656891989d, y: 0.6158946272091573d), new NpgsqlTypes.NpgsqlPoint(x: 0.2473213156282561d, y: 0.15135588497247487d), new NpgsqlTypes.NpgsqlPoint(x: 0.967040338537986d, y: 0.4302188856714403d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8633414213691062d, y: 0.36010764922872296d), new NpgsqlTypes.NpgsqlPoint(x: 0.6279931230492314d, y: 0.877379629656365d), new NpgsqlTypes.NpgsqlPoint(x: 0.5674648027711133d, y: 0.22768811427589786d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1660044048590531d, y: 0.04540585654235019d), new NpgsqlTypes.NpgsqlPoint(x: 0.08858774545505266d, y: 0.11517590376989328d), new NpgsqlTypes.NpgsqlPoint(x: 0.5550642067257614d, y: 0.21923086815874515d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6078684785314281d, y: 0.7689110794948691d), new NpgsqlTypes.NpgsqlPoint(x: 0.01330929513959822d, y: 0.5672238491672347d), new NpgsqlTypes.NpgsqlPoint(x: 0.2741000929243269d, y: 0.27535718751477256d)), }, }, },
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.850219896716816d, y: 0.7485058852583746d), new NpgsqlTypes.NpgsqlPoint(x: 0.8337972455946735d, y: 0.6068033349122406d), new NpgsqlTypes.NpgsqlPoint(x: 0.0943246098312559d, y: 0.17606347758723484d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8861450910432521d, y: 0.6447365759720363d), new NpgsqlTypes.NpgsqlPoint(x: 0.6824379336363581d, y: 0.10772781881882598d), new NpgsqlTypes.NpgsqlPoint(x: 0.7468477900724727d, y: 0.20157797141332112d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26774878644041666d, y: 0.9387443337357096d), new NpgsqlTypes.NpgsqlPoint(x: 0.3947490461525519d, y: 0.08535869732722123d), new NpgsqlTypes.NpgsqlPoint(x: 0.9735122069165829d, y: 0.1065656766142733d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6058936579080473d, y: 0.4571256604855436d), new NpgsqlTypes.NpgsqlPoint(x: 0.9459480542616047d, y: 0.4423706689395037d), new NpgsqlTypes.NpgsqlPoint(x: 0.023821855112345802d, y: 0.7011703101541955d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2915822778201279d, y: 0.41466980381847685d), new NpgsqlTypes.NpgsqlPoint(x: 0.7573867801831934d, y: 0.8763807116190478d), new NpgsqlTypes.NpgsqlPoint(x: 0.05430567298628819d, y: 0.8253290409707958d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14005702179474488d, y: 0.7252285174795122d), new NpgsqlTypes.NpgsqlPoint(x: 0.6137026912615174d, y: 0.0935239040243232d), new NpgsqlTypes.NpgsqlPoint(x: 0.5680940173552571d, y: 0.9533514261301087d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8004225424577572d, y: 0.8296026080038741d), new NpgsqlTypes.NpgsqlPoint(x: 0.8594992283335764d, y: 0.7705075442720951d), new NpgsqlTypes.NpgsqlPoint(x: 0.21816612512220412d, y: 0.7603140796834246d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7690650540560153d, y: 0.4282005135989384d), new NpgsqlTypes.NpgsqlPoint(x: 0.6544120602289991d, y: 0.0025337954366424498d), new NpgsqlTypes.NpgsqlPoint(x: 0.09827563955466911d, y: 0.2608521469762012d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05956147948365098d, y: 0.347374486181523d), new NpgsqlTypes.NpgsqlPoint(x: 0.5567799707908514d, y: 0.5186252286762503d), new NpgsqlTypes.NpgsqlPoint(x: 0.2623148091890656d, y: 0.4043240957331583d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9255701440041042d, y: 0.9292789093654562d), new NpgsqlTypes.NpgsqlPoint(x: 0.41901395794776064d, y: 0.5662562885963522d), new NpgsqlTypes.NpgsqlPoint(x: 0.9219973048935318d, y: 0.8487934894041754d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49088588310123193d, y: 0.32708770106951524d), new NpgsqlTypes.NpgsqlPoint(x: 0.8839530664750644d, y: 0.8971454115752985d), new NpgsqlTypes.NpgsqlPoint(x: 0.36504791388211155d, y: 0.6968757228942144d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9568992389087297d, y: 0.7952423033700703d), new NpgsqlTypes.NpgsqlPoint(x: 0.5704487055208587d, y: 0.972996605875458d), new NpgsqlTypes.NpgsqlPoint(x: 0.07843198228930703d, y: 0.47495345555983126d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.183045159981286d, y: 0.3147409126926527d), new NpgsqlTypes.NpgsqlPoint(x: 0.892926523470357d, y: 0.9693232286610937d), new NpgsqlTypes.NpgsqlPoint(x: 0.10814407032459317d, y: 0.15224007249983218d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46792659662081226d, y: 0.19814707681295662d), new NpgsqlTypes.NpgsqlPoint(x: 0.43956473445439614d, y: 0.2184035228764174d), new NpgsqlTypes.NpgsqlPoint(x: 0.3653523083589658d, y: 0.7733344518104357d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08136891551521408d, y: 0.9150324479063311d), new NpgsqlTypes.NpgsqlPoint(x: 0.6670559743522312d, y: 0.9469403069011887d), new NpgsqlTypes.NpgsqlPoint(x: 0.3148249960424462d, y: 0.11495904005437885d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7042098645352495d, y: 0.44707586904615215d), new NpgsqlTypes.NpgsqlPoint(x: 0.30053165084579314d, y: 0.6406255360450341d), new NpgsqlTypes.NpgsqlPoint(x: 0.20030991220175587d, y: 0.9982191837925914d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5600048529133204d, y: 0.46530729130145654d), new NpgsqlTypes.NpgsqlPoint(x: 0.03545349060101688d, y: 0.3247506296460325d), new NpgsqlTypes.NpgsqlPoint(x: 0.8550268174243986d, y: 0.4473176063869063d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07737703849055899d, y: 0.1282339617462559d), new NpgsqlTypes.NpgsqlPoint(x: 0.2357725969983312d, y: 0.025713474167072703d), new NpgsqlTypes.NpgsqlPoint(x: 0.6298060396256621d, y: 0.8964581602300764d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8011745061259485d, y: 0.5693328877847204d), new NpgsqlTypes.NpgsqlPoint(x: 0.6819147895935126d, y: 0.6971795352557255d), new NpgsqlTypes.NpgsqlPoint(x: 0.4840341291253507d, y: 0.46446428991978217d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8706610189614662d, y: 0.5768458502572503d), new NpgsqlTypes.NpgsqlPoint(x: 0.23273691498739324d, y: 0.9431235444220348d), new NpgsqlTypes.NpgsqlPoint(x: 0.7185735735536732d, y: 0.2624127188749187d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25151264780593563d, y: 0.07816374215860122d), new NpgsqlTypes.NpgsqlPoint(x: 0.24815137329109704d, y: 0.6542211375071669d), new NpgsqlTypes.NpgsqlPoint(x: 0.05184018309750449d, y: 0.21526756593088425d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11313481999285635d, y: 0.308427757674132d), new NpgsqlTypes.NpgsqlPoint(x: 0.7159722017797612d, y: 0.9639211082607437d), new NpgsqlTypes.NpgsqlPoint(x: 0.0586318698383147d, y: 0.21041784695266796d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.665522039326681d, y: 0.9303823727263487d), new NpgsqlTypes.NpgsqlPoint(x: 0.20840945479085804d, y: 0.6919209841391204d), new NpgsqlTypes.NpgsqlPoint(x: 0.973278358817825d, y: 0.7620722866969868d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.208241365802862d, y: 0.6597859554235713d), new NpgsqlTypes.NpgsqlPoint(x: 0.9061674055331903d, y: 0.5648670742898132d), new NpgsqlTypes.NpgsqlPoint(x: 0.962273518522831d, y: 0.8545698112000917d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16344458828450248d, y: 0.4267867085789878d), new NpgsqlTypes.NpgsqlPoint(x: 0.2876792535312872d, y: 0.10997096030011799d), new NpgsqlTypes.NpgsqlPoint(x: 0.17967128798676535d, y: 0.9860453391107864d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9917507067324122d, y: 0.7299646512642737d), new NpgsqlTypes.NpgsqlPoint(x: 0.2788884475501898d, y: 0.7651471587763735d), new NpgsqlTypes.NpgsqlPoint(x: 0.12786806411155938d, y: 0.43569278399808864d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9042445830081738d, y: 0.16318690759753496d), new NpgsqlTypes.NpgsqlPoint(x: 0.6756877763603176d, y: 0.8132546999141773d), new NpgsqlTypes.NpgsqlPoint(x: 0.4271841328170233d, y: 0.09182112458651837d)), }, }, },
    ModelInner = new NpgsqlPathpathMMArrayD3E1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.594204671855645d, y: 0.901383527377333d), new NpgsqlTypes.NpgsqlPoint(x: 0.5028881221487941d, y: 0.6777909076741456d), new NpgsqlTypes.NpgsqlPoint(x: 0.8132400627610346d, y: 0.6495096092709018d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6923644635213213d, y: 0.5043514853646754d), new NpgsqlTypes.NpgsqlPoint(x: 0.32951619098810847d, y: 0.5316189217359606d), new NpgsqlTypes.NpgsqlPoint(x: 0.4554683561177003d, y: 0.11953184192865796d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4008377714521758d, y: 0.7658518772801591d), new NpgsqlTypes.NpgsqlPoint(x: 0.24523449639282324d, y: 0.42635350838625496d), new NpgsqlTypes.NpgsqlPoint(x: 0.09436433735024552d, y: 0.07330989991466519d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8500794721175154d, y: 0.852814223861816d), new NpgsqlTypes.NpgsqlPoint(x: 0.17865444525145402d, y: 0.15460706714237993d), new NpgsqlTypes.NpgsqlPoint(x: 0.11487831016178451d, y: 0.7967577256948933d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1388195858568274d, y: 0.001690827256169869d), new NpgsqlTypes.NpgsqlPoint(x: 0.06638206523795387d, y: 0.20531903206112867d), new NpgsqlTypes.NpgsqlPoint(x: 0.14891434849042606d, y: 0.5424114815540534d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2957940926326825d, y: 0.41245557865324634d), new NpgsqlTypes.NpgsqlPoint(x: 0.8204746543097923d, y: 0.7553583320987612d), new NpgsqlTypes.NpgsqlPoint(x: 0.7752865049097267d, y: 0.4215330452022127d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41366200612297566d, y: 0.4529174568368871d), new NpgsqlTypes.NpgsqlPoint(x: 0.025835605701703068d, y: 0.3591136147459867d), new NpgsqlTypes.NpgsqlPoint(x: 0.6677456888484921d, y: 0.8306748939732018d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4594953106950739d, y: 0.3783825935683629d), new NpgsqlTypes.NpgsqlPoint(x: 0.05562579804779988d, y: 0.8886769253734437d), new NpgsqlTypes.NpgsqlPoint(x: 0.8036374142523376d, y: 0.9368778422035464d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8140878718531869d, y: 0.7511149014080847d), new NpgsqlTypes.NpgsqlPoint(x: 0.45930699909876604d, y: 0.6505722277043351d), new NpgsqlTypes.NpgsqlPoint(x: 0.9618714723049584d, y: 0.9039521518061411d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2552115189013874d, y: 0.48508016672002296d), new NpgsqlTypes.NpgsqlPoint(x: 0.9873077507185702d, y: 0.5144569066611836d), new NpgsqlTypes.NpgsqlPoint(x: 0.5880641523669882d, y: 0.9400582978378503d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41800995101153526d, y: 0.5623019358593969d), new NpgsqlTypes.NpgsqlPoint(x: 0.20283167544419056d, y: 0.1980913381835674d), new NpgsqlTypes.NpgsqlPoint(x: 0.6252245876668079d, y: 0.024799474488846007d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9715299075170033d, y: 0.18802187360055855d), new NpgsqlTypes.NpgsqlPoint(x: 0.7158196941345399d, y: 0.1610237089083899d), new NpgsqlTypes.NpgsqlPoint(x: 0.6657558664293984d, y: 0.14637038711198558d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2843260408106014d, y: 0.9747419255655532d), new NpgsqlTypes.NpgsqlPoint(x: 0.914303503595376d, y: 0.4409297460819772d), new NpgsqlTypes.NpgsqlPoint(x: 0.4357412094436608d, y: 0.990361827850406d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5438262757143227d, y: 0.5073910261937475d), new NpgsqlTypes.NpgsqlPoint(x: 0.3414118472575961d, y: 0.2512417269449563d), new NpgsqlTypes.NpgsqlPoint(x: 0.33117010900538746d, y: 0.03450521413735397d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8752641680606995d, y: 0.4498494952680119d), new NpgsqlTypes.NpgsqlPoint(x: 0.5268944182655263d, y: 0.5837406795458869d), new NpgsqlTypes.NpgsqlPoint(x: 0.8557132630281339d, y: 0.026235733713243392d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11145995246685536d, y: 0.7775792231611662d), new NpgsqlTypes.NpgsqlPoint(x: 0.8024421197039528d, y: 0.6195963415811842d), new NpgsqlTypes.NpgsqlPoint(x: 0.4001683091498539d, y: 0.27407479717567007d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8752908972695844d, y: 0.4281559194330047d), new NpgsqlTypes.NpgsqlPoint(x: 0.7685116928256078d, y: 0.20961372296965763d), new NpgsqlTypes.NpgsqlPoint(x: 0.6140334443031529d, y: 0.20116325955868608d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8242806855804706d, y: 0.820553943837696d), new NpgsqlTypes.NpgsqlPoint(x: 0.9564925917508512d, y: 0.01868754291086816d), new NpgsqlTypes.NpgsqlPoint(x: 0.9089814336997573d, y: 0.8811095683957445d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9814668960797021d, y: 0.9789102605500637d), new NpgsqlTypes.NpgsqlPoint(x: 0.43040878336515054d, y: 0.21573237012117474d), new NpgsqlTypes.NpgsqlPoint(x: 0.08932436610701366d, y: 0.7503842476714577d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.009511276017730164d, y: 0.37394886611851363d), new NpgsqlTypes.NpgsqlPoint(x: 0.5530206594915368d, y: 0.16849385632876546d), new NpgsqlTypes.NpgsqlPoint(x: 0.13923714278397414d, y: 0.16610017236238683d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41673376036286636d, y: 0.4270443637910485d), new NpgsqlTypes.NpgsqlPoint(x: 0.6993266087493809d, y: 0.6163067925897996d), new NpgsqlTypes.NpgsqlPoint(x: 0.5400131340029791d, y: 0.8787607962954646d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9131604679491563d, y: 0.7977159110351232d), new NpgsqlTypes.NpgsqlPoint(x: 0.4635855030907864d, y: 0.7669498542428896d), new NpgsqlTypes.NpgsqlPoint(x: 0.7843512797354284d, y: 0.4836662749024966d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2911540759882866d, y: 0.9114049297608515d), new NpgsqlTypes.NpgsqlPoint(x: 0.2287095531525014d, y: 0.029208794603132415d), new NpgsqlTypes.NpgsqlPoint(x: 0.12693397953530694d, y: 0.32372118365056335d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6873428588964139d, y: 0.6921317182310929d), new NpgsqlTypes.NpgsqlPoint(x: 0.51937337152011d, y: 0.7380303476214146d), new NpgsqlTypes.NpgsqlPoint(x: 0.7999582632794806d, y: 0.12780683571944396d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31225562984308275d, y: 0.8413037044725529d), new NpgsqlTypes.NpgsqlPoint(x: 0.6790179859516565d, y: 0.6726744164491867d), new NpgsqlTypes.NpgsqlPoint(x: 0.08704795582272029d, y: 0.5311980889800207d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3303600532431671d, y: 0.5744907499398167d), new NpgsqlTypes.NpgsqlPoint(x: 0.7598249535551277d, y: 0.29205590710525187d), new NpgsqlTypes.NpgsqlPoint(x: 0.6111320777084815d, y: 0.7041935109369237d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10904820606843624d, y: 0.44079938032863286d), new NpgsqlTypes.NpgsqlPoint(x: 0.15424523007055546d, y: 0.5224331771684584d), new NpgsqlTypes.NpgsqlPoint(x: 0.6815893789707307d, y: 0.07339466567627528d)), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6081111471428691d, y: 0.7553801799529115d), new NpgsqlTypes.NpgsqlPoint(x: 0.8467811630745824d, y: 0.9539629520732925d), new NpgsqlTypes.NpgsqlPoint(x: 0.3466512102760718d, y: 0.78001040396927d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8279332740053778d, y: 0.5673407377236855d), new NpgsqlTypes.NpgsqlPoint(x: 0.5922704258927659d, y: 0.308604897937809d), new NpgsqlTypes.NpgsqlPoint(x: 0.08968938734461929d, y: 0.07271326381510834d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9245879242233667d, y: 0.20792999209728813d), new NpgsqlTypes.NpgsqlPoint(x: 0.1594762023967834d, y: 0.7086766098554437d), new NpgsqlTypes.NpgsqlPoint(x: 0.036600646208323706d, y: 0.7894187080457724d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7680798154314915d, y: 0.7255935537965125d), new NpgsqlTypes.NpgsqlPoint(x: 0.35589215684896913d, y: 0.3469871277604256d), new NpgsqlTypes.NpgsqlPoint(x: 0.30268190866364386d, y: 0.7965607824897311d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5688061245136701d, y: 0.13001770347857566d), new NpgsqlTypes.NpgsqlPoint(x: 0.5118246011610833d, y: 0.615537964294613d), new NpgsqlTypes.NpgsqlPoint(x: 0.025978352634970836d, y: 0.7028926838148928d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.359073275851156d, y: 0.33076217477202274d), new NpgsqlTypes.NpgsqlPoint(x: 0.42730377202492875d, y: 0.941581917801398d), new NpgsqlTypes.NpgsqlPoint(x: 0.986843644067147d, y: 0.5113541559160963d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30354839732218364d, y: 0.49074648992604053d), new NpgsqlTypes.NpgsqlPoint(x: 0.6311787682760306d, y: 0.8267197836606018d), new NpgsqlTypes.NpgsqlPoint(x: 0.10248695322618151d, y: 0.05070570995060508d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4852918547576689d, y: 0.5878732732580619d), new NpgsqlTypes.NpgsqlPoint(x: 0.6619657376030197d, y: 0.030290926172920618d), new NpgsqlTypes.NpgsqlPoint(x: 0.7568561090517901d, y: 0.32162436111823633d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.710222451448688d, y: 0.8736926397073668d), new NpgsqlTypes.NpgsqlPoint(x: 0.10106739705813661d, y: 0.3571951903579512d), new NpgsqlTypes.NpgsqlPoint(x: 0.5673664593968861d, y: 0.15688494266525888d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2595276835676128d, y: 0.0759243146275751d), new NpgsqlTypes.NpgsqlPoint(x: 0.22469003957958222d, y: 0.6646851244748568d), new NpgsqlTypes.NpgsqlPoint(x: 0.7005888235163933d, y: 0.7378033305183266d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7161468764652438d, y: 0.9444772544669211d), new NpgsqlTypes.NpgsqlPoint(x: 0.6637124299235816d, y: 0.7951484001854341d), new NpgsqlTypes.NpgsqlPoint(x: 0.5275086950015924d, y: 0.028866783890381997d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04202600811608925d, y: 0.3269058986652559d), new NpgsqlTypes.NpgsqlPoint(x: 0.604650834078937d, y: 0.5237964467249535d), new NpgsqlTypes.NpgsqlPoint(x: 0.3479657021083805d, y: 0.8224866339312379d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2713300533291175d, y: 0.7341509218320584d), new NpgsqlTypes.NpgsqlPoint(x: 0.7888274200889254d, y: 0.05889401793810933d), new NpgsqlTypes.NpgsqlPoint(x: 0.46412443739108533d, y: 0.895055335468926d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6884291840970768d, y: 0.032670698824497024d), new NpgsqlTypes.NpgsqlPoint(x: 0.49804379782824837d, y: 0.9741188840702919d), new NpgsqlTypes.NpgsqlPoint(x: 0.6101842628032095d, y: 0.7654813089802811d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23105223956250043d, y: 0.017985694346796866d), new NpgsqlTypes.NpgsqlPoint(x: 0.027591195077636965d, y: 0.8950921024881563d), new NpgsqlTypes.NpgsqlPoint(x: 0.7133416353851497d, y: 0.3886168358584633d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25945737036382066d, y: 0.022091560300736335d), new NpgsqlTypes.NpgsqlPoint(x: 0.34860559883873943d, y: 0.24951101358536054d), new NpgsqlTypes.NpgsqlPoint(x: 0.11384988029504439d, y: 0.6694677769667214d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8082742303927528d, y: 0.07335880002047623d), new NpgsqlTypes.NpgsqlPoint(x: 0.7724065693857411d, y: 0.25521779983469073d), new NpgsqlTypes.NpgsqlPoint(x: 0.5094321492191848d, y: 0.4757170758870072d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24596732300464597d, y: 0.9882633387545618d), new NpgsqlTypes.NpgsqlPoint(x: 0.28883707011965876d, y: 0.5202762592031334d), new NpgsqlTypes.NpgsqlPoint(x: 0.48205436187782214d, y: 0.29059524877872556d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27339887073981217d, y: 0.1263005710255357d), new NpgsqlTypes.NpgsqlPoint(x: 0.12721648393545137d, y: 0.18543520703915883d), new NpgsqlTypes.NpgsqlPoint(x: 0.4446309693261917d, y: 0.18180018535801168d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.023970466548025815d, y: 0.35488529545918235d), new NpgsqlTypes.NpgsqlPoint(x: 0.6554139258071806d, y: 0.8790348614801052d), new NpgsqlTypes.NpgsqlPoint(x: 0.08511863606819592d, y: 0.6438936005982259d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2011716153374178d, y: 0.3481951546335551d), new NpgsqlTypes.NpgsqlPoint(x: 0.40923504810275424d, y: 0.6560914507946476d), new NpgsqlTypes.NpgsqlPoint(x: 0.635930130918093d, y: 0.08526753760958417d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29670838014315315d, y: 0.7061992985758078d), new NpgsqlTypes.NpgsqlPoint(x: 0.49301611656355615d, y: 0.2234009511582572d), new NpgsqlTypes.NpgsqlPoint(x: 0.10377092147179512d, y: 0.4042026174034107d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9257958985139715d, y: 0.8312065754869423d), new NpgsqlTypes.NpgsqlPoint(x: 0.8774068325610445d, y: 0.8678375755386638d), new NpgsqlTypes.NpgsqlPoint(x: 0.6722265339907073d, y: 0.42737405638916237d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2707123231180183d, y: 0.20990972940385288d), new NpgsqlTypes.NpgsqlPoint(x: 0.6007621446567897d, y: 0.2645398139824414d), new NpgsqlTypes.NpgsqlPoint(x: 0.83724765192629d, y: 0.031226024310387013d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18286903915172448d, y: 0.7808916001188845d), new NpgsqlTypes.NpgsqlPoint(x: 0.1751419352771526d, y: 0.530975795437771d), new NpgsqlTypes.NpgsqlPoint(x: 0.041094182780176625d, y: 0.4346155667974355d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5136087799699535d, y: 0.20537191000920985d), new NpgsqlTypes.NpgsqlPoint(x: 0.014504511958535748d, y: 0.03970287330272537d), new NpgsqlTypes.NpgsqlPoint(x: 0.7606087115227974d, y: 0.3402246240762077d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06003985402286527d, y: 0.061813806172663965d), new NpgsqlTypes.NpgsqlPoint(x: 0.3195303553551979d, y: 0.07120783462909575d), new NpgsqlTypes.NpgsqlPoint(x: 0.3221938117945735d, y: 0.059624555273511404d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4320864157509299d, y: 0.6087053884301639d), new NpgsqlTypes.NpgsqlPoint(x: 0.07599341097140178d, y: 0.3096274615382668d), new NpgsqlTypes.NpgsqlPoint(x: 0.7644874796601917d, y: 0.8267762780524837d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5623852577875944d, y: 0.6593585679409233d), new NpgsqlTypes.NpgsqlPoint(x: 0.4240215422409993d, y: 0.33198727695470565d), new NpgsqlTypes.NpgsqlPoint(x: 0.7813788561648778d, y: 0.6414645041681597d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7767037375469344d, y: 0.1772779508218849d), new NpgsqlTypes.NpgsqlPoint(x: 0.8167865599998014d, y: 0.1552724650476388d), new NpgsqlTypes.NpgsqlPoint(x: 0.9414550075702725d, y: 0.7573959724298119d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06698685641753999d, y: 0.5362673571540686d), new NpgsqlTypes.NpgsqlPoint(x: 0.82539484278441d, y: 0.7194774109449701d), new NpgsqlTypes.NpgsqlPoint(x: 0.5010043528630835d, y: 0.890569979350707d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9403997516723823d, y: 0.6292584831408778d), new NpgsqlTypes.NpgsqlPoint(x: 0.06652534992256343d, y: 0.122575294164041d), new NpgsqlTypes.NpgsqlPoint(x: 0.7852769882658206d, y: 0.7014272998684652d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4625238406365022d, y: 0.5281645206067276d), new NpgsqlTypes.NpgsqlPoint(x: 0.24355709961674987d, y: 0.28146807563003207d), new NpgsqlTypes.NpgsqlPoint(x: 0.5840610365172443d, y: 0.07580338925283037d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5348654480636473d, y: 0.8084132167375876d), new NpgsqlTypes.NpgsqlPoint(x: 0.49988194885485926d, y: 0.27669373122473295d), new NpgsqlTypes.NpgsqlPoint(x: 0.3525642413187907d, y: 0.32930729807263504d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.043480343981060265d, y: 0.4173030833264151d), new NpgsqlTypes.NpgsqlPoint(x: 0.9200101535402707d, y: 0.15756065295323685d), new NpgsqlTypes.NpgsqlPoint(x: 0.7591038734832961d, y: 0.8992117772159407d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6048723212496059d, y: 0.6302974608072797d), new NpgsqlTypes.NpgsqlPoint(x: 0.8202552921633277d, y: 0.823695437010636d), new NpgsqlTypes.NpgsqlPoint(x: 0.37466161896442507d, y: 0.44060169071118105d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.774041412586977d, y: 0.43800708793726995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9524350326261055d, y: 0.9866835510423619d), new NpgsqlTypes.NpgsqlPoint(x: 0.706855379964913d, y: 0.23730949202917184d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22376631768014388d, y: 0.8242018247242817d), new NpgsqlTypes.NpgsqlPoint(x: 0.3732760362960308d, y: 0.5182910821838256d), new NpgsqlTypes.NpgsqlPoint(x: 0.810624451740363d, y: 0.7125530367997341d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37591353503976177d, y: 0.5676929927417843d), new NpgsqlTypes.NpgsqlPoint(x: 0.6228059999988854d, y: 0.15893105369023786d), new NpgsqlTypes.NpgsqlPoint(x: 0.23977014026794996d, y: 0.24164995439845727d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7095513618377198d, y: 0.7472721513562963d), new NpgsqlTypes.NpgsqlPoint(x: 0.16964953180864328d, y: 0.028305794392974204d), new NpgsqlTypes.NpgsqlPoint(x: 0.30838320292929644d, y: 0.47023999024537666d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49008889585988835d, y: 0.4496886777101534d), new NpgsqlTypes.NpgsqlPoint(x: 0.06863465744548769d, y: 0.6583176862794596d), new NpgsqlTypes.NpgsqlPoint(x: 0.7569066292740879d, y: 0.47931732793368165d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5338914308453815d, y: 0.3241421722906951d), new NpgsqlTypes.NpgsqlPoint(x: 0.348101468961346d, y: 0.4559797499549826d), new NpgsqlTypes.NpgsqlPoint(x: 0.706204540779298d, y: 0.9834781066344118d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.619047743265356d, y: 0.9627587284419233d), new NpgsqlTypes.NpgsqlPoint(x: 0.34124861899796466d, y: 0.5848692101751426d), new NpgsqlTypes.NpgsqlPoint(x: 0.05428476711201613d, y: 0.9987558782833295d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.037988248224251175d, y: 0.33026322301707367d), new NpgsqlTypes.NpgsqlPoint(x: 0.720909212879475d, y: 0.8061637668768286d), new NpgsqlTypes.NpgsqlPoint(x: 0.09760681837701235d, y: 0.7792434040448719d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6347940675438238d, y: 0.9473975722768019d), new NpgsqlTypes.NpgsqlPoint(x: 0.11586583397225947d, y: 0.16448153427050693d), new NpgsqlTypes.NpgsqlPoint(x: 0.04161382278990988d, y: 0.7185927814304887d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03643543613928135d, y: 0.012825874783434554d), new NpgsqlTypes.NpgsqlPoint(x: 0.6961913020702959d, y: 0.5621362051331161d), new NpgsqlTypes.NpgsqlPoint(x: 0.2933381167839383d, y: 0.2065974818311087d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7656273545872724d, y: 0.015908266924525738d), new NpgsqlTypes.NpgsqlPoint(x: 0.16382664372904043d, y: 0.012875327506773893d), new NpgsqlTypes.NpgsqlPoint(x: 0.1465877532241351d, y: 0.4724083112241526d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2467611569961986d, y: 0.3694806838836374d), new NpgsqlTypes.NpgsqlPoint(x: 0.20327435355800094d, y: 0.8042147509650893d), new NpgsqlTypes.NpgsqlPoint(x: 0.49485846782091625d, y: 0.14875451972000353d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05286189708015854d, y: 0.6594173865858888d), new NpgsqlTypes.NpgsqlPoint(x: 0.3041335337908647d, y: 0.33971782433635045d), new NpgsqlTypes.NpgsqlPoint(x: 0.17306775879508784d, y: 0.582405642854824d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0995308225874818d, y: 0.7143086749972629d), new NpgsqlTypes.NpgsqlPoint(x: 0.2535429615886098d, y: 0.44501287099303055d), new NpgsqlTypes.NpgsqlPoint(x: 0.28887227133516213d, y: 0.5710152975053251d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.982157030109572d, y: 0.781133165386411d), new NpgsqlTypes.NpgsqlPoint(x: 0.0278397320381909d, y: 0.3161514896858174d), new NpgsqlTypes.NpgsqlPoint(x: 0.12590005518090852d, y: 0.17819015200611898d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8032780583640249d, y: 0.8246744631734781d), new NpgsqlTypes.NpgsqlPoint(x: 0.7220835363698345d, y: 0.6846602808188857d), new NpgsqlTypes.NpgsqlPoint(x: 0.5402604916084922d, y: 0.6737344592066948d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08056473332714453d, y: 0.019808073910068003d), new NpgsqlTypes.NpgsqlPoint(x: 0.5852180480670011d, y: 0.9966866151115791d), new NpgsqlTypes.NpgsqlPoint(x: 0.01603694373987452d, y: 0.6993346929814825d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36018899907024005d, y: 0.9142338035554666d), new NpgsqlTypes.NpgsqlPoint(x: 0.8965025605328087d, y: 0.9695912132727231d), new NpgsqlTypes.NpgsqlPoint(x: 0.8539545132008614d, y: 0.00108038178836678d)), }, }, },
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4624002464637835d, y: 0.1801604851401264d), new NpgsqlTypes.NpgsqlPoint(x: 0.2725681820210599d, y: 0.16557275424518225d), new NpgsqlTypes.NpgsqlPoint(x: 0.48314203034833925d, y: 0.393644911120164d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11401271047093342d, y: 0.9423660882085536d), new NpgsqlTypes.NpgsqlPoint(x: 0.19973755993265074d, y: 0.6343311025406115d), new NpgsqlTypes.NpgsqlPoint(x: 0.10194078523729644d, y: 0.34047679212893467d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3151869331860737d, y: 0.16676978184865643d), new NpgsqlTypes.NpgsqlPoint(x: 0.37573128659348176d, y: 0.09567157228770296d), new NpgsqlTypes.NpgsqlPoint(x: 0.6297873675835095d, y: 0.8696377661192796d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05834508406754946d, y: 0.47183484172982293d), new NpgsqlTypes.NpgsqlPoint(x: 0.33513372072721936d, y: 0.26225546772160213d), new NpgsqlTypes.NpgsqlPoint(x: 0.8057479127604714d, y: 0.0500869553570229d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23750318487254662d, y: 0.2997092282575208d), new NpgsqlTypes.NpgsqlPoint(x: 0.6108695695653165d, y: 0.25668760240358135d), new NpgsqlTypes.NpgsqlPoint(x: 0.8810332291983024d, y: 0.9057096691616042d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8426674454309067d, y: 0.8346241634137539d), new NpgsqlTypes.NpgsqlPoint(x: 0.006606899027208013d, y: 0.6909663740436395d), new NpgsqlTypes.NpgsqlPoint(x: 0.8764635596227606d, y: 0.601591720110874d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9322815784877942d, y: 0.4163686945041085d), new NpgsqlTypes.NpgsqlPoint(x: 0.6466121451639956d, y: 0.27859684147990815d), new NpgsqlTypes.NpgsqlPoint(x: 0.2753690822375735d, y: 0.486457932935107d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5631347475269595d, y: 0.01014084797874304d), new NpgsqlTypes.NpgsqlPoint(x: 0.8116166752307402d, y: 0.10345648245415329d), new NpgsqlTypes.NpgsqlPoint(x: 0.9961373046672786d, y: 0.6422259490773714d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9329317668456097d, y: 0.06862371204434181d), new NpgsqlTypes.NpgsqlPoint(x: 0.5433392764361106d, y: 0.01486320770022953d), new NpgsqlTypes.NpgsqlPoint(x: 0.7788244729183252d, y: 0.26345028469592147d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7246276580764838d, y: 0.9509235847258821d), new NpgsqlTypes.NpgsqlPoint(x: 0.9784630454894099d, y: 0.8066617417745441d), new NpgsqlTypes.NpgsqlPoint(x: 0.5255899929899959d, y: 0.191244167478555d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19539969499962462d, y: 0.08356299501500475d), new NpgsqlTypes.NpgsqlPoint(x: 0.7379737017800166d, y: 0.21193141013926564d), new NpgsqlTypes.NpgsqlPoint(x: 0.3263657664084909d, y: 0.052571201070385265d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25716685436878883d, y: 0.0037015692993543903d), new NpgsqlTypes.NpgsqlPoint(x: 0.9117278346051101d, y: 0.7556291299148026d), new NpgsqlTypes.NpgsqlPoint(x: 0.057457944433237484d, y: 0.4545655099962389d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45862516799734065d, y: 0.10041659207256293d), new NpgsqlTypes.NpgsqlPoint(x: 0.5005136149603475d, y: 0.24335498870328476d), new NpgsqlTypes.NpgsqlPoint(x: 0.7316159306356599d, y: 0.19770837020844512d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4284295552426255d, y: 0.79920099196426d), new NpgsqlTypes.NpgsqlPoint(x: 0.852352698272196d, y: 0.26259263060872395d), new NpgsqlTypes.NpgsqlPoint(x: 0.869321689041999d, y: 0.2837170402435113d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4810116435172578d, y: 0.9344529489740004d), new NpgsqlTypes.NpgsqlPoint(x: 0.40643530328423993d, y: 0.3592025341095183d), new NpgsqlTypes.NpgsqlPoint(x: 0.7701540180400841d, y: 0.09313844946898453d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47320856094446906d, y: 0.03641555473665525d), new NpgsqlTypes.NpgsqlPoint(x: 0.3711054393093238d, y: 0.7906928891195122d), new NpgsqlTypes.NpgsqlPoint(x: 0.8312741363266192d, y: 0.9330749071062113d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9416271720580792d, y: 0.07495454723436246d), new NpgsqlTypes.NpgsqlPoint(x: 0.9407865139747376d, y: 0.8198271308706507d), new NpgsqlTypes.NpgsqlPoint(x: 0.621195338888556d, y: 0.4730441610046622d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9118644416780101d, y: 0.9680739827477653d), new NpgsqlTypes.NpgsqlPoint(x: 0.6993046606355469d, y: 0.02728736971699386d), new NpgsqlTypes.NpgsqlPoint(x: 0.2715764695111035d, y: 0.0860049646030826d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.917839860760199d, y: 0.806647911001697d), new NpgsqlTypes.NpgsqlPoint(x: 0.5760402828171967d, y: 0.1877078704008841d), new NpgsqlTypes.NpgsqlPoint(x: 0.7949484172314514d, y: 0.22070677716633347d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24243185037619608d, y: 0.14962942692892744d), new NpgsqlTypes.NpgsqlPoint(x: 0.5971468080145462d, y: 0.5827419501165577d), new NpgsqlTypes.NpgsqlPoint(x: 0.2580473882649663d, y: 0.8399400654583248d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7026217189180379d, y: 0.045411091142340654d), new NpgsqlTypes.NpgsqlPoint(x: 0.6013989165827751d, y: 0.4990746448272978d), new NpgsqlTypes.NpgsqlPoint(x: 0.5188720996108566d, y: 0.8371684865606739d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13043576000571644d, y: 0.7595507158659877d), new NpgsqlTypes.NpgsqlPoint(x: 0.5277792987766982d, y: 0.8653690412398962d), new NpgsqlTypes.NpgsqlPoint(x: 0.5731422477563042d, y: 0.4624756845471987d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08786643186012266d, y: 0.8582891937451403d), new NpgsqlTypes.NpgsqlPoint(x: 0.7240023069240813d, y: 0.47969560916273546d), new NpgsqlTypes.NpgsqlPoint(x: 0.32282011498424856d, y: 0.7049999463189688d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10246726550134921d, y: 0.1361050929211235d), new NpgsqlTypes.NpgsqlPoint(x: 0.3237325540731726d, y: 0.38421111445425915d), new NpgsqlTypes.NpgsqlPoint(x: 0.7734524335775077d, y: 0.8637250206274486d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03610692148656647d, y: 0.42497958694045224d), new NpgsqlTypes.NpgsqlPoint(x: 0.9518044391758822d, y: 0.10287523464809911d), new NpgsqlTypes.NpgsqlPoint(x: 0.8946078178822684d, y: 0.9040503993442033d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6051217684339802d, y: 0.5799883529280336d), new NpgsqlTypes.NpgsqlPoint(x: 0.38639813057575434d, y: 0.09372752771137038d), new NpgsqlTypes.NpgsqlPoint(x: 0.8262462809700826d, y: 0.12267733537138492d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6702598641057809d, y: 0.06727861118347933d), new NpgsqlTypes.NpgsqlPoint(x: 0.6399753120966564d, y: 0.4214432798450417d), new NpgsqlTypes.NpgsqlPoint(x: 0.21476606278255927d, y: 0.5729326957606942d)), }, }, },
    ModelInner = new NpgsqlPathpathMMArrayD3E1MI
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9717484675328866d, y: 0.9711739165652759d), new NpgsqlTypes.NpgsqlPoint(x: 0.951690219113038d, y: 0.6185017812697015d), new NpgsqlTypes.NpgsqlPoint(x: 0.603254525641631d, y: 0.4776340187457818d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9305228215030512d, y: 0.7732183513611977d), new NpgsqlTypes.NpgsqlPoint(x: 0.8673401698237628d, y: 0.5587624310709491d), new NpgsqlTypes.NpgsqlPoint(x: 0.16044465327736213d, y: 0.3894487861905569d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9664741655446349d, y: 0.764390106084885d), new NpgsqlTypes.NpgsqlPoint(x: 0.09129201304819978d, y: 0.23221429705833108d), new NpgsqlTypes.NpgsqlPoint(x: 0.03354433631495235d, y: 0.9646502200117317d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6351305754484512d, y: 0.6243259258696419d), new NpgsqlTypes.NpgsqlPoint(x: 0.845456339983254d, y: 0.9500918118210786d), new NpgsqlTypes.NpgsqlPoint(x: 0.609486744800431d, y: 0.28108829668508983d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02132542637670576d, y: 0.8951499087400626d), new NpgsqlTypes.NpgsqlPoint(x: 0.8910454258690375d, y: 0.5721090445624728d), new NpgsqlTypes.NpgsqlPoint(x: 0.36945285617827495d, y: 0.3923786581646277d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5395532751164075d, y: 0.2345562491456894d), new NpgsqlTypes.NpgsqlPoint(x: 0.2008846136988477d, y: 0.37651741677114525d), new NpgsqlTypes.NpgsqlPoint(x: 0.70344644509823d, y: 0.9269333357059043d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3808144944183566d, y: 0.9441148781804558d), new NpgsqlTypes.NpgsqlPoint(x: 0.8036021333363939d, y: 0.525263171309243d), new NpgsqlTypes.NpgsqlPoint(x: 0.11714632740646813d, y: 0.4815086208114453d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14765887532727207d, y: 0.9900245447771591d), new NpgsqlTypes.NpgsqlPoint(x: 0.00268092964316613d, y: 0.9291947555934466d), new NpgsqlTypes.NpgsqlPoint(x: 0.2700006450405614d, y: 0.43635191515285265d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04125976510424123d, y: 0.7086718542209615d), new NpgsqlTypes.NpgsqlPoint(x: 0.7088435173400811d, y: 0.7502916360489365d), new NpgsqlTypes.NpgsqlPoint(x: 0.21230243992645215d, y: 0.674901862815897d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7002086666925361d, y: 0.4617657111147072d), new NpgsqlTypes.NpgsqlPoint(x: 0.9349971508048963d, y: 0.522599106702079d), new NpgsqlTypes.NpgsqlPoint(x: 0.8280354675580524d, y: 0.6304829992907275d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9268520259766997d, y: 0.0531571762017069d), new NpgsqlTypes.NpgsqlPoint(x: 0.020692622036775132d, y: 0.9144231335227117d), new NpgsqlTypes.NpgsqlPoint(x: 0.8153391983545981d, y: 0.8882277659222242d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4406198468768803d, y: 0.6974710193603026d), new NpgsqlTypes.NpgsqlPoint(x: 0.7134736640336258d, y: 0.7635355219044255d), new NpgsqlTypes.NpgsqlPoint(x: 0.6119255378821592d, y: 0.6081706428102024d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9276156401080878d, y: 0.4245521945095567d), new NpgsqlTypes.NpgsqlPoint(x: 0.9417657518701144d, y: 0.7170688512439991d), new NpgsqlTypes.NpgsqlPoint(x: 0.46077221466047924d, y: 0.28485472831951664d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5986513223144195d, y: 0.9487753651838792d), new NpgsqlTypes.NpgsqlPoint(x: 0.049712879680062105d, y: 0.8374536229713583d), new NpgsqlTypes.NpgsqlPoint(x: 0.8240150896826439d, y: 0.8185251102181359d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9966820533471267d, y: 0.4801835800637697d), new NpgsqlTypes.NpgsqlPoint(x: 0.33136231379439474d, y: 0.1420344955493531d), new NpgsqlTypes.NpgsqlPoint(x: 0.9274540517206672d, y: 0.2703332660680069d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5012570641514822d, y: 0.03964046827079193d), new NpgsqlTypes.NpgsqlPoint(x: 0.8056909255056042d, y: 0.4163101720539433d), new NpgsqlTypes.NpgsqlPoint(x: 0.48427139917875184d, y: 0.290370088742556d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29289683514986875d, y: 0.8863904559689896d), new NpgsqlTypes.NpgsqlPoint(x: 0.9222464056871352d, y: 0.9164233904618483d), new NpgsqlTypes.NpgsqlPoint(x: 0.44063552907367853d, y: 0.7427876214099991d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2619532123451712d, y: 0.14521538454958272d), new NpgsqlTypes.NpgsqlPoint(x: 0.32531008855952437d, y: 0.3815897601168773d), new NpgsqlTypes.NpgsqlPoint(x: 0.6621079935946594d, y: 0.1772547529349523d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9709042273168308d, y: 0.2587412391258571d), new NpgsqlTypes.NpgsqlPoint(x: 0.9137316969074395d, y: 0.09181878416955536d), new NpgsqlTypes.NpgsqlPoint(x: 0.8901457699596899d, y: 0.07616233844099185d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9910949583025377d, y: 0.11147055881278012d), new NpgsqlTypes.NpgsqlPoint(x: 0.93976663308379d, y: 0.8108464997588753d), new NpgsqlTypes.NpgsqlPoint(x: 0.9355661625126429d, y: 0.5146556443318147d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7050897408337025d, y: 0.08686516543800671d), new NpgsqlTypes.NpgsqlPoint(x: 0.16572564370550757d, y: 0.9979109225128887d), new NpgsqlTypes.NpgsqlPoint(x: 0.29838068009724195d, y: 0.9873940459035863d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6850392816897724d, y: 0.016555381894713395d), new NpgsqlTypes.NpgsqlPoint(x: 0.5023777493536986d, y: 0.4009268761879453d), new NpgsqlTypes.NpgsqlPoint(x: 0.5514534384415455d, y: 0.8002945691193835d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4737917542585376d, y: 0.5433644827714401d), new NpgsqlTypes.NpgsqlPoint(x: 0.42923949196394606d, y: 0.6866408053337385d), new NpgsqlTypes.NpgsqlPoint(x: 0.7001351899994614d, y: 0.8857125763946205d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9872046390587886d, y: 0.4865062599347463d), new NpgsqlTypes.NpgsqlPoint(x: 0.11264467327918837d, y: 0.38688806415730204d), new NpgsqlTypes.NpgsqlPoint(x: 0.49899739568121904d, y: 0.3850857538148067d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29278136225690565d, y: 0.3903095137901733d), new NpgsqlTypes.NpgsqlPoint(x: 0.38876340453822966d, y: 0.6516940371790032d), new NpgsqlTypes.NpgsqlPoint(x: 0.45826923734291314d, y: 0.8507568984124536d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0739659750289452d, y: 0.15291689367488803d), new NpgsqlTypes.NpgsqlPoint(x: 0.8403723638834325d, y: 0.7693577094225778d), new NpgsqlTypes.NpgsqlPoint(x: 0.10830964700552037d, y: 0.3982666354345027d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8687326322069974d, y: 0.21241882026046766d), new NpgsqlTypes.NpgsqlPoint(x: 0.13813204249971955d, y: 0.5652186063608803d), new NpgsqlTypes.NpgsqlPoint(x: 0.5465506010170527d, y: 0.8227718416875768d)), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31976504228905955d, y: 0.39615790287610175d), new NpgsqlTypes.NpgsqlPoint(x: 0.41557879384363805d, y: 0.5812381419818227d), new NpgsqlTypes.NpgsqlPoint(x: 0.8381697930359335d, y: 0.04354575037292219d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32496904617043043d, y: 0.03430984345769539d), new NpgsqlTypes.NpgsqlPoint(x: 0.05546956304192796d, y: 0.0019082982515985503d), new NpgsqlTypes.NpgsqlPoint(x: 0.3400943132933477d, y: 0.11353821197550973d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3133900223280395d, y: 0.1611712238408176d), new NpgsqlTypes.NpgsqlPoint(x: 0.30086120561919294d, y: 0.9481148493370265d), new NpgsqlTypes.NpgsqlPoint(x: 0.8109820520457686d, y: 0.30891202575371257d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43740121993461356d, y: 0.23810712425698366d), new NpgsqlTypes.NpgsqlPoint(x: 0.5740907584325999d, y: 0.4448119907413981d), new NpgsqlTypes.NpgsqlPoint(x: 0.982978394127277d, y: 0.5910316195126242d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4997522264855221d, y: 0.06259265193022034d), new NpgsqlTypes.NpgsqlPoint(x: 0.5692120688646372d, y: 0.3903954387062306d), new NpgsqlTypes.NpgsqlPoint(x: 0.8187404911420141d, y: 0.2753985442830864d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32574962571403243d, y: 0.33661327657340434d), new NpgsqlTypes.NpgsqlPoint(x: 0.4466171465142884d, y: 0.8473866327899232d), new NpgsqlTypes.NpgsqlPoint(x: 0.5245577792834089d, y: 0.9177426146306632d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8389244267053018d, y: 0.27407406711341975d), new NpgsqlTypes.NpgsqlPoint(x: 0.6289538524749757d, y: 0.6123460789605745d), new NpgsqlTypes.NpgsqlPoint(x: 0.3318556599047231d, y: 0.48080538323878874d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37756765471291276d, y: 0.9750687402313434d), new NpgsqlTypes.NpgsqlPoint(x: 0.6310376028196514d, y: 0.47010053635678994d), new NpgsqlTypes.NpgsqlPoint(x: 0.5023519537268479d, y: 0.5051255029749923d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4512080611653657d, y: 0.6783146334488335d), new NpgsqlTypes.NpgsqlPoint(x: 0.8193521086526661d, y: 0.7156657011586424d), new NpgsqlTypes.NpgsqlPoint(x: 0.40154830757896975d, y: 0.5127996326057482d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9766336317966258d, y: 0.8216028282624215d), new NpgsqlTypes.NpgsqlPoint(x: 0.7895733562810416d, y: 0.2487021081518903d), new NpgsqlTypes.NpgsqlPoint(x: 0.7291644748414985d, y: 0.09132148588912947d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5950770899567989d, y: 0.860314877130835d), new NpgsqlTypes.NpgsqlPoint(x: 0.9738221787192854d, y: 0.30207577870595526d), new NpgsqlTypes.NpgsqlPoint(x: 0.5827418880107369d, y: 0.49045122766339877d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43743099359358384d, y: 0.9638917442438584d), new NpgsqlTypes.NpgsqlPoint(x: 0.39978952958611624d, y: 0.9189516711105434d), new NpgsqlTypes.NpgsqlPoint(x: 0.4190870354798045d, y: 0.02211942058300609d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6651650715721096d, y: 0.2796518779992886d), new NpgsqlTypes.NpgsqlPoint(x: 0.6022787943076156d, y: 0.9505314546108605d), new NpgsqlTypes.NpgsqlPoint(x: 0.8166636293008588d, y: 0.28746950316708275d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08834385540522083d, y: 0.5031493120771162d), new NpgsqlTypes.NpgsqlPoint(x: 0.8734491088575194d, y: 0.9616531399320873d), new NpgsqlTypes.NpgsqlPoint(x: 0.3220788396404426d, y: 0.49038770460604264d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10239037753988123d, y: 0.6299464694031324d), new NpgsqlTypes.NpgsqlPoint(x: 0.18664386689489554d, y: 0.343765787908232d), new NpgsqlTypes.NpgsqlPoint(x: 0.7827179079175899d, y: 0.5764918214725823d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5203842636420578d, y: 0.08892915613805852d), new NpgsqlTypes.NpgsqlPoint(x: 0.695098988153077d, y: 0.7922663392753025d), new NpgsqlTypes.NpgsqlPoint(x: 0.7391214805934486d, y: 0.620293504932574d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14315852175939703d, y: 0.5441235105138296d), new NpgsqlTypes.NpgsqlPoint(x: 0.8631106971736974d, y: 0.29430704285503984d), new NpgsqlTypes.NpgsqlPoint(x: 0.1309417795557889d, y: 0.9858802940032995d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5926303828028604d, y: 0.8818982712003299d), new NpgsqlTypes.NpgsqlPoint(x: 0.28852273302667575d, y: 0.790293519267469d), new NpgsqlTypes.NpgsqlPoint(x: 0.0753166066538643d, y: 0.8515132926140191d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24474944784202723d, y: 0.6422480924137087d), new NpgsqlTypes.NpgsqlPoint(x: 0.9281536913457603d, y: 0.8682805031940714d), new NpgsqlTypes.NpgsqlPoint(x: 0.8144666772421972d, y: 0.23024928148275514d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30036082086981797d, y: 0.8983561066138214d), new NpgsqlTypes.NpgsqlPoint(x: 0.10711758663680315d, y: 0.8337555312154421d), new NpgsqlTypes.NpgsqlPoint(x: 0.9619305624011577d, y: 0.4146093173769929d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7978134192075774d, y: 0.7434410004077742d), new NpgsqlTypes.NpgsqlPoint(x: 0.866228140495354d, y: 0.6593795612370187d), new NpgsqlTypes.NpgsqlPoint(x: 0.9236901801894775d, y: 0.3405324575495997d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1050570183556262d, y: 0.5600475809696046d), new NpgsqlTypes.NpgsqlPoint(x: 0.9619579784232594d, y: 0.8572419427619598d), new NpgsqlTypes.NpgsqlPoint(x: 0.04940322847930867d, y: 0.07529817768617297d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3203400012201427d, y: 0.9151167943494944d), new NpgsqlTypes.NpgsqlPoint(x: 0.652153095037785d, y: 0.5809717714284686d), new NpgsqlTypes.NpgsqlPoint(x: 0.12644031364944142d, y: 0.5874195091767637d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7849274801872878d, y: 0.12450860566103894d), new NpgsqlTypes.NpgsqlPoint(x: 0.2502598710860525d, y: 0.5524524583317374d), new NpgsqlTypes.NpgsqlPoint(x: 0.5454095427545449d, y: 0.047658980759776925d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19713695110872642d, y: 0.8365090493807616d), new NpgsqlTypes.NpgsqlPoint(x: 0.8848286417367688d, y: 0.548224179941659d), new NpgsqlTypes.NpgsqlPoint(x: 0.685058566876037d, y: 0.7783339851073982d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7015544291530788d, y: 0.7849904651442878d), new NpgsqlTypes.NpgsqlPoint(x: 0.6898440051350767d, y: 0.7407414453708827d), new NpgsqlTypes.NpgsqlPoint(x: 0.39381792517068304d, y: 0.3895058299151887d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09521486707153093d, y: 0.9787156537763748d), new NpgsqlTypes.NpgsqlPoint(x: 0.7870964962874945d, y: 0.9353862013028784d), new NpgsqlTypes.NpgsqlPoint(x: 0.7671419607959941d, y: 0.3399403561512041d)), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2649752316908828d, y: 0.6373140274467007d), new NpgsqlTypes.NpgsqlPoint(x: 0.7660204467627996d, y: 0.5266422850817175d), new NpgsqlTypes.NpgsqlPoint(x: 0.15772862415301458d, y: 0.4695602454540452d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3688741488605496d, y: 0.7646144832797883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6679173408768836d, y: 0.8253072301173832d), new NpgsqlTypes.NpgsqlPoint(x: 0.2623568683711377d, y: 0.09676998504470757d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48555722373025756d, y: 0.8516575156599103d), new NpgsqlTypes.NpgsqlPoint(x: 0.39684920882778385d, y: 0.49935626163566327d), new NpgsqlTypes.NpgsqlPoint(x: 0.3444085546200303d, y: 0.992991631149952d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19275898452015128d, y: 0.4850396072585633d), new NpgsqlTypes.NpgsqlPoint(x: 0.3986113990475525d, y: 0.5292693128477169d), new NpgsqlTypes.NpgsqlPoint(x: 0.7299881477798171d, y: 0.9213141804274974d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8737740830076486d, y: 0.5537251977769604d), new NpgsqlTypes.NpgsqlPoint(x: 0.7127773445784035d, y: 0.29543499272479146d), new NpgsqlTypes.NpgsqlPoint(x: 0.2728885298049657d, y: 0.6618080899339204d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11004776296955288d, y: 0.7784050729745802d), new NpgsqlTypes.NpgsqlPoint(x: 0.642145928171786d, y: 0.1552452134232265d), new NpgsqlTypes.NpgsqlPoint(x: 0.3643501793650843d, y: 0.48423089177621614d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.010570646161650377d, y: 0.9976184087113363d), new NpgsqlTypes.NpgsqlPoint(x: 0.4503357726304166d, y: 0.09037580133922174d), new NpgsqlTypes.NpgsqlPoint(x: 0.6445509363723785d, y: 0.2987123749719296d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08702831438735492d, y: 0.9882952626804833d), new NpgsqlTypes.NpgsqlPoint(x: 0.3433917778645271d, y: 0.728863360951321d), new NpgsqlTypes.NpgsqlPoint(x: 0.012367747485571678d, y: 0.060507696737610916d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12408340931154571d, y: 0.9599081517806995d), new NpgsqlTypes.NpgsqlPoint(x: 0.5426858552118606d, y: 0.8664635260301239d), new NpgsqlTypes.NpgsqlPoint(x: 0.41394821336225396d, y: 0.9597446535729667d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9308476505272769d, y: 0.8273622764800177d), new NpgsqlTypes.NpgsqlPoint(x: 0.8483300008372969d, y: 0.5457105119618058d), new NpgsqlTypes.NpgsqlPoint(x: 0.229706034750916d, y: 0.46854136584195116d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2614786814831034d, y: 0.4033141086987233d), new NpgsqlTypes.NpgsqlPoint(x: 0.1512065758559441d, y: 0.8788730208794431d), new NpgsqlTypes.NpgsqlPoint(x: 0.4104197285164062d, y: 0.6290837074832359d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4372433318044052d, y: 0.48917630386729816d), new NpgsqlTypes.NpgsqlPoint(x: 0.5649627083935166d, y: 0.7216492997932019d), new NpgsqlTypes.NpgsqlPoint(x: 0.992963192082299d, y: 0.061585178911655714d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40438482444308643d, y: 0.4263751618381544d), new NpgsqlTypes.NpgsqlPoint(x: 0.5494021356844422d, y: 0.8349474022996604d), new NpgsqlTypes.NpgsqlPoint(x: 0.1728592234403018d, y: 0.22318175035530963d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7180888125236848d, y: 0.16484064706481905d), new NpgsqlTypes.NpgsqlPoint(x: 0.7493863877320727d, y: 0.04319713583837015d), new NpgsqlTypes.NpgsqlPoint(x: 0.31345294234584553d, y: 0.11690328381866144d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9609740577002955d, y: 0.3194669205993218d), new NpgsqlTypes.NpgsqlPoint(x: 0.12118118294519453d, y: 0.9103165617633013d), new NpgsqlTypes.NpgsqlPoint(x: 0.10030718588949283d, y: 0.8728264492706284d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9383688928846499d, y: 0.6491971901099975d), new NpgsqlTypes.NpgsqlPoint(x: 0.04143597484949513d, y: 0.9367457216169626d), new NpgsqlTypes.NpgsqlPoint(x: 0.436202201264259d, y: 0.21699065944055018d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4326349878275796d, y: 0.378756910749648d), new NpgsqlTypes.NpgsqlPoint(x: 0.08627353613143462d, y: 0.32887705561067515d), new NpgsqlTypes.NpgsqlPoint(x: 0.05382019755271228d, y: 0.6911405175509582d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47776272449048485d, y: 0.45338383862642095d), new NpgsqlTypes.NpgsqlPoint(x: 0.6172437623915601d, y: 0.06701586528171921d), new NpgsqlTypes.NpgsqlPoint(x: 0.842168230692214d, y: 0.0061818488035769725d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9212702177536034d, y: 0.033434937068774984d), new NpgsqlTypes.NpgsqlPoint(x: 0.24174903625672828d, y: 0.12200279066981923d), new NpgsqlTypes.NpgsqlPoint(x: 0.548889294186333d, y: 0.7159164196491408d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8810310323963431d, y: 0.1701064692244314d), new NpgsqlTypes.NpgsqlPoint(x: 0.45357413534755553d, y: 0.24023270064203317d), new NpgsqlTypes.NpgsqlPoint(x: 0.2960023124372595d, y: 0.9607728673981023d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.051257511922128685d, y: 0.17777300334179302d), new NpgsqlTypes.NpgsqlPoint(x: 0.5312424339826871d, y: 0.8882798060563153d), new NpgsqlTypes.NpgsqlPoint(x: 0.2612532373079428d, y: 0.9518447091734998d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5988045685777756d, y: 0.23019217811249548d), new NpgsqlTypes.NpgsqlPoint(x: 0.2918298683769379d, y: 0.33177556369150785d), new NpgsqlTypes.NpgsqlPoint(x: 0.7177291173928428d, y: 0.7976545664143262d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.310785152351124d, y: 0.40526789073723235d), new NpgsqlTypes.NpgsqlPoint(x: 0.42882275592588204d, y: 0.6931225841459852d), new NpgsqlTypes.NpgsqlPoint(x: 0.30375202666809153d, y: 0.8150085264149625d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20440498897527437d, y: 0.17177602228114297d), new NpgsqlTypes.NpgsqlPoint(x: 0.07624437011467433d, y: 0.8267831737032921d), new NpgsqlTypes.NpgsqlPoint(x: 0.5959443949227484d, y: 0.1065412418113969d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03444370903331739d, y: 0.17663221134111717d), new NpgsqlTypes.NpgsqlPoint(x: 0.055264118585789834d, y: 0.173397701303172d), new NpgsqlTypes.NpgsqlPoint(x: 0.4369787903400988d, y: 0.29683723561912d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7422980938020335d, y: 0.29507633613340656d), new NpgsqlTypes.NpgsqlPoint(x: 0.9930048158256884d, y: 0.8852130384186868d), new NpgsqlTypes.NpgsqlPoint(x: 0.4952841570741373d, y: 0.030408741963578123d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1773592932796918d, y: 0.7377401029040443d), new NpgsqlTypes.NpgsqlPoint(x: 0.03532969576742606d, y: 0.08340407223816737d), new NpgsqlTypes.NpgsqlPoint(x: 0.7544708970391877d, y: 0.6535760203293016d)), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4833052781989339d, y: 0.9144279254832164d), new NpgsqlTypes.NpgsqlPoint(x: 0.24962685388110906d, y: 0.1039326474657839d), new NpgsqlTypes.NpgsqlPoint(x: 0.8391199675857772d, y: 0.497785075774969d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8547704764986723d, y: 0.28409412631595854d), new NpgsqlTypes.NpgsqlPoint(x: 0.8958847338633038d, y: 0.6069737945771797d), new NpgsqlTypes.NpgsqlPoint(x: 0.95145562276537d, y: 0.31891737327649394d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23031019512688766d, y: 0.8388043351947366d), new NpgsqlTypes.NpgsqlPoint(x: 0.22173258969684084d, y: 0.024544032515086855d), new NpgsqlTypes.NpgsqlPoint(x: 0.9040300490948532d, y: 0.848003333537392d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9799053373550046d, y: 0.3358715356965438d), new NpgsqlTypes.NpgsqlPoint(x: 0.3330942434210824d, y: 0.8632490090442231d), new NpgsqlTypes.NpgsqlPoint(x: 0.8428702001060661d, y: 0.20833861388186048d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44694024799407717d, y: 0.8376341582816368d), new NpgsqlTypes.NpgsqlPoint(x: 0.6215110851912551d, y: 0.7333130383881468d), new NpgsqlTypes.NpgsqlPoint(x: 0.5852181924039197d, y: 0.7872877887197502d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5510666719919594d, y: 0.3413124738513752d), new NpgsqlTypes.NpgsqlPoint(x: 0.027279570669480724d, y: 0.09699260599152693d), new NpgsqlTypes.NpgsqlPoint(x: 0.7734623476307565d, y: 0.44025083866125025d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5514661961190599d, y: 0.637778679519225d), new NpgsqlTypes.NpgsqlPoint(x: 0.9143915924429453d, y: 0.8671855696317415d), new NpgsqlTypes.NpgsqlPoint(x: 0.8584317471553881d, y: 0.19308187006322952d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3323035062727623d, y: 0.2185327634099391d), new NpgsqlTypes.NpgsqlPoint(x: 0.9319907552128691d, y: 0.25995700349611595d), new NpgsqlTypes.NpgsqlPoint(x: 0.6567936816866281d, y: 0.10051353508152283d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07591993909410588d, y: 0.5662832202344918d), new NpgsqlTypes.NpgsqlPoint(x: 0.12585186534279946d, y: 0.6288543068010245d), new NpgsqlTypes.NpgsqlPoint(x: 0.12791323158277246d, y: 0.5194444218513338d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6074704466320149d, y: 0.19565520153627047d), new NpgsqlTypes.NpgsqlPoint(x: 0.059090461660787796d, y: 0.29985757066653707d), new NpgsqlTypes.NpgsqlPoint(x: 0.773343743785076d, y: 0.5998206570057517d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5007696205943223d, y: 0.6222116986654863d), new NpgsqlTypes.NpgsqlPoint(x: 0.5760356741764268d, y: 0.7397741148455212d), new NpgsqlTypes.NpgsqlPoint(x: 0.2636042407470185d, y: 0.1678504257032838d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48201107885098815d, y: 0.8732471517783172d), new NpgsqlTypes.NpgsqlPoint(x: 0.40760417448673436d, y: 0.42159382454131233d), new NpgsqlTypes.NpgsqlPoint(x: 0.5369998286337788d, y: 0.10437689182002874d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44776085015801625d, y: 0.2187637655262985d), new NpgsqlTypes.NpgsqlPoint(x: 0.4346435523032197d, y: 0.1989386940522081d), new NpgsqlTypes.NpgsqlPoint(x: 0.861939410141525d, y: 0.22078191045816997d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34962976803972023d, y: 0.9206978459961149d), new NpgsqlTypes.NpgsqlPoint(x: 0.45491814256452656d, y: 0.40483780503198175d), new NpgsqlTypes.NpgsqlPoint(x: 0.01080364471329709d, y: 0.3320390667413651d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23356097190342306d, y: 0.20150981316734007d), new NpgsqlTypes.NpgsqlPoint(x: 0.9173457491788377d, y: 0.33243043722167664d), new NpgsqlTypes.NpgsqlPoint(x: 0.7993602782758021d, y: 0.7006578329221991d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.039683515859778584d, y: 0.5297507381908506d), new NpgsqlTypes.NpgsqlPoint(x: 0.9360402554946946d, y: 0.41185963719434493d), new NpgsqlTypes.NpgsqlPoint(x: 0.8739768635208767d, y: 0.2869115715395978d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.508034660968205d, y: 0.19375328234186617d), new NpgsqlTypes.NpgsqlPoint(x: 0.4972976714494869d, y: 0.3286703174032757d), new NpgsqlTypes.NpgsqlPoint(x: 0.8310331552509624d, y: 0.3415010064995724d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6403909234784863d, y: 0.1946697647522464d), new NpgsqlTypes.NpgsqlPoint(x: 0.7774018601767839d, y: 0.2373499302462181d), new NpgsqlTypes.NpgsqlPoint(x: 0.021881981998094435d, y: 0.055462852922999684d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8702032805770851d, y: 0.08366465536250456d), new NpgsqlTypes.NpgsqlPoint(x: 0.7775243564470845d, y: 0.12252583878811085d), new NpgsqlTypes.NpgsqlPoint(x: 0.9435814989618415d, y: 0.013166159708824843d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3989530961867478d, y: 0.5374742897197007d), new NpgsqlTypes.NpgsqlPoint(x: 0.574526284852557d, y: 0.8703404804778838d), new NpgsqlTypes.NpgsqlPoint(x: 0.8454405865524072d, y: 0.552807294709435d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4837526884338389d, y: 0.2620875296400056d), new NpgsqlTypes.NpgsqlPoint(x: 0.7705807219021942d, y: 0.565425584758955d), new NpgsqlTypes.NpgsqlPoint(x: 0.5557336860553754d, y: 0.40723258961889164d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6659314179710822d, y: 0.6326344264689195d), new NpgsqlTypes.NpgsqlPoint(x: 0.5760100992779785d, y: 0.5950567538151108d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455676736603402d, y: 0.5328577685233289d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7913596272518724d, y: 0.7766523859108451d), new NpgsqlTypes.NpgsqlPoint(x: 0.7825441324276883d, y: 0.48856271100493653d), new NpgsqlTypes.NpgsqlPoint(x: 0.2162225589792317d, y: 0.5625812905686709d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7069773741278049d, y: 0.9378243971904706d), new NpgsqlTypes.NpgsqlPoint(x: 0.13918098532289114d, y: 0.9603898139506306d), new NpgsqlTypes.NpgsqlPoint(x: 0.5556135075540973d, y: 0.35094493542676997d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5185948906296993d, y: 0.9409364982568478d), new NpgsqlTypes.NpgsqlPoint(x: 0.6580821186648346d, y: 0.4655880152818862d), new NpgsqlTypes.NpgsqlPoint(x: 0.6102284699841897d, y: 0.5826139660802907d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2712687565990768d, y: 0.3807787911076398d), new NpgsqlTypes.NpgsqlPoint(x: 0.3522912334197298d, y: 0.26625187896191493d), new NpgsqlTypes.NpgsqlPoint(x: 0.9920124152153619d, y: 0.8085254681932336d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6627416949656224d, y: 0.8991182235367678d), new NpgsqlTypes.NpgsqlPoint(x: 0.7471279686679945d, y: 0.4200818773928371d), new NpgsqlTypes.NpgsqlPoint(x: 0.3181272347719637d, y: 0.012733190998363564d)), }, }, },
    ModelInner = new NpgsqlPathpathMMArrayD3E1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3816796097309386d, y: 0.33292841156470765d), new NpgsqlTypes.NpgsqlPoint(x: 0.19698667800972136d, y: 0.5567107886225117d), new NpgsqlTypes.NpgsqlPoint(x: 0.45100232296448084d, y: 0.6449162901990729d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23701799462642492d, y: 0.8979098562653309d), new NpgsqlTypes.NpgsqlPoint(x: 0.7127872023850352d, y: 0.3599577514475567d), new NpgsqlTypes.NpgsqlPoint(x: 0.46475048348136017d, y: 0.8619575951701759d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2631356175505075d, y: 0.021522951140830582d), new NpgsqlTypes.NpgsqlPoint(x: 0.7336920551413602d, y: 0.9273437257700705d), new NpgsqlTypes.NpgsqlPoint(x: 0.9710783182799794d, y: 0.8027209812509839d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24256422902655084d, y: 0.6315885040753813d), new NpgsqlTypes.NpgsqlPoint(x: 0.3370585888783685d, y: 0.7367679279963973d), new NpgsqlTypes.NpgsqlPoint(x: 0.3781990211225089d, y: 0.6921995218429499d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09715917546610942d, y: 0.4195124042558769d), new NpgsqlTypes.NpgsqlPoint(x: 0.4594207505426169d, y: 0.2816101219063577d), new NpgsqlTypes.NpgsqlPoint(x: 0.6257907303198301d, y: 0.4066651811904515d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4351739182083896d, y: 0.7561021789617786d), new NpgsqlTypes.NpgsqlPoint(x: 0.6786716369818592d, y: 0.17126732886316065d), new NpgsqlTypes.NpgsqlPoint(x: 0.4276074345923372d, y: 0.6557227310867755d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4118805252764286d, y: 0.6791285322127056d), new NpgsqlTypes.NpgsqlPoint(x: 0.4183142825097602d, y: 0.40261177138832094d), new NpgsqlTypes.NpgsqlPoint(x: 0.8601725813859158d, y: 0.7156134575627638d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4191279722291258d, y: 0.0330416742223365d), new NpgsqlTypes.NpgsqlPoint(x: 0.032732278303606366d, y: 0.2571549072202167d), new NpgsqlTypes.NpgsqlPoint(x: 0.8543969945350564d, y: 0.23678625373895146d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9792689038470741d, y: 0.7108164398567933d), new NpgsqlTypes.NpgsqlPoint(x: 0.6689871693709232d, y: 0.6848630726498973d), new NpgsqlTypes.NpgsqlPoint(x: 0.17202811705994792d, y: 0.4063095172298582d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17326085742543063d, y: 0.5381912168460983d), new NpgsqlTypes.NpgsqlPoint(x: 0.7396520024425342d, y: 0.4770781616342833d), new NpgsqlTypes.NpgsqlPoint(x: 0.3691159629419791d, y: 0.49111864320794163d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9307382855231943d, y: 0.5633673395116984d), new NpgsqlTypes.NpgsqlPoint(x: 0.5749073708242557d, y: 0.11669119284288587d), new NpgsqlTypes.NpgsqlPoint(x: 0.8677876115714204d, y: 0.8445385893041921d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.394404206983621d, y: 0.5034848165081127d), new NpgsqlTypes.NpgsqlPoint(x: 0.20798255605464688d, y: 0.673996010003398d), new NpgsqlTypes.NpgsqlPoint(x: 0.46589861553891354d, y: 0.34293869805157684d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33616935546441207d, y: 0.3788290125426189d), new NpgsqlTypes.NpgsqlPoint(x: 0.6866643722059722d, y: 0.3037215809947784d), new NpgsqlTypes.NpgsqlPoint(x: 0.8919434973996407d, y: 0.26038862320541123d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6758862505072782d, y: 0.7370579832194928d), new NpgsqlTypes.NpgsqlPoint(x: 0.5589158181291508d, y: 0.8073658883727916d), new NpgsqlTypes.NpgsqlPoint(x: 0.9323217445130944d, y: 0.7132886405445842d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9380050696725951d, y: 0.4214673340816598d), new NpgsqlTypes.NpgsqlPoint(x: 0.5769089157142602d, y: 0.22996570214570633d), new NpgsqlTypes.NpgsqlPoint(x: 0.6172404004834667d, y: 0.9989797825656678d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19825581965905548d, y: 0.6670944558672968d), new NpgsqlTypes.NpgsqlPoint(x: 0.6103787344482479d, y: 0.03513032253102821d), new NpgsqlTypes.NpgsqlPoint(x: 0.07010124103392212d, y: 0.2777713709530434d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5931605272936352d, y: 0.5888841945359474d), new NpgsqlTypes.NpgsqlPoint(x: 0.9507458712212241d, y: 0.5683563397896068d), new NpgsqlTypes.NpgsqlPoint(x: 0.1590402512387229d, y: 0.7526859888284404d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5999139956530772d, y: 0.220632348570577d), new NpgsqlTypes.NpgsqlPoint(x: 0.3199608896427919d, y: 0.06160032161810858d), new NpgsqlTypes.NpgsqlPoint(x: 0.9220319713053243d, y: 0.6141402696689854d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9887526769740053d, y: 0.09332795911441838d), new NpgsqlTypes.NpgsqlPoint(x: 0.5622981417211879d, y: 0.09444285742717218d), new NpgsqlTypes.NpgsqlPoint(x: 0.06708736959080053d, y: 0.5904298480493684d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6689020078982986d, y: 0.9092263153593486d), new NpgsqlTypes.NpgsqlPoint(x: 0.8620457770308801d, y: 0.7959062015044859d), new NpgsqlTypes.NpgsqlPoint(x: 0.27772278653397553d, y: 0.7073547996752483d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3857801412352957d, y: 0.08285049522543197d), new NpgsqlTypes.NpgsqlPoint(x: 0.9112918618841594d, y: 0.7664013070489786d), new NpgsqlTypes.NpgsqlPoint(x: 0.6040608355966398d, y: 0.09678922850482885d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17003595499953916d, y: 0.10609584207341682d), new NpgsqlTypes.NpgsqlPoint(x: 0.49623484712171717d, y: 0.7175222667190504d), new NpgsqlTypes.NpgsqlPoint(x: 0.21558826454402802d, y: 0.19926853247918097d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7557285171993215d, y: 0.23316237636360826d), new NpgsqlTypes.NpgsqlPoint(x: 0.8696041698912134d, y: 0.7551049185470605d), new NpgsqlTypes.NpgsqlPoint(x: 0.7573424362222928d, y: 0.029793796597362365d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8588070266827139d, y: 0.05750774323978092d), new NpgsqlTypes.NpgsqlPoint(x: 0.4241904666270536d, y: 0.22404257722867138d), new NpgsqlTypes.NpgsqlPoint(x: 0.9994408402901303d, y: 0.5031570702232917d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19284930550096502d, y: 0.11255196305673587d), new NpgsqlTypes.NpgsqlPoint(x: 0.5223911232115774d, y: 0.4456884618664442d), new NpgsqlTypes.NpgsqlPoint(x: 0.898725122615648d, y: 0.029605809913199055d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7808351292191451d, y: 0.4253285070062711d), new NpgsqlTypes.NpgsqlPoint(x: 0.5170470468643452d, y: 0.7699681277275822d), new NpgsqlTypes.NpgsqlPoint(x: 0.08533271561160782d, y: 0.9087904900453567d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.000584750886085339d, y: 0.4640453094629443d), new NpgsqlTypes.NpgsqlPoint(x: 0.5431294544096679d, y: 0.5351534426232811d), new NpgsqlTypes.NpgsqlPoint(x: 0.3695623287167088d, y: 0.8086203106417091d)), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30031750515688405d, y: 0.8712272923893896d), new NpgsqlTypes.NpgsqlPoint(x: 0.34894257923636973d, y: 0.9952397117527296d), new NpgsqlTypes.NpgsqlPoint(x: 0.3402913153921119d, y: 0.20144855790232863d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2135480077782349d, y: 0.6936196560119079d), new NpgsqlTypes.NpgsqlPoint(x: 0.27153041273491185d, y: 0.8743986950592222d), new NpgsqlTypes.NpgsqlPoint(x: 0.1195005778902627d, y: 0.6859721553021279d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7232004790509012d, y: 0.005948901391979455d), new NpgsqlTypes.NpgsqlPoint(x: 0.30856344368757826d, y: 0.982449669832339d), new NpgsqlTypes.NpgsqlPoint(x: 0.41883698738966046d, y: 0.1723392584825516d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23384357127374011d, y: 0.5549623625462613d), new NpgsqlTypes.NpgsqlPoint(x: 0.7157841222246347d, y: 0.15912785091877912d), new NpgsqlTypes.NpgsqlPoint(x: 0.23150531071184388d, y: 0.4279448583249894d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3366046359958784d, y: 0.20055741749224576d), new NpgsqlTypes.NpgsqlPoint(x: 0.09142928091113545d, y: 0.2604263506627983d), new NpgsqlTypes.NpgsqlPoint(x: 0.13984083944685255d, y: 0.8557579335053507d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04299484259848774d, y: 0.1749902546668859d), new NpgsqlTypes.NpgsqlPoint(x: 0.5120102432717093d, y: 0.5906668917690747d), new NpgsqlTypes.NpgsqlPoint(x: 0.890048544401978d, y: 0.02338796272827537d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3265653703215874d, y: 0.2271515145235693d), new NpgsqlTypes.NpgsqlPoint(x: 0.34199430677223375d, y: 0.4368542490778432d), new NpgsqlTypes.NpgsqlPoint(x: 0.03943923671019656d, y: 0.49841543370873076d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30884511353627864d, y: 0.3632205410331967d), new NpgsqlTypes.NpgsqlPoint(x: 0.39425802208342786d, y: 0.4963477473924155d), new NpgsqlTypes.NpgsqlPoint(x: 0.30240700300719314d, y: 0.04524472904801424d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47584596928889145d, y: 0.8627126113334487d), new NpgsqlTypes.NpgsqlPoint(x: 0.31834578142025083d, y: 0.8165709969013542d), new NpgsqlTypes.NpgsqlPoint(x: 0.14447874097034452d, y: 0.9401895368828194d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33619605054378143d, y: 0.71163235945111d), new NpgsqlTypes.NpgsqlPoint(x: 0.5156581532242723d, y: 0.3384132190451401d), new NpgsqlTypes.NpgsqlPoint(x: 0.7484144955965696d, y: 0.9914550216672126d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06133933823022786d, y: 0.13758424798398527d), new NpgsqlTypes.NpgsqlPoint(x: 0.12022742740113856d, y: 0.4415670462765936d), new NpgsqlTypes.NpgsqlPoint(x: 0.42153604294204905d, y: 0.35252565946243397d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5635882146175729d, y: 0.41846406620162435d), new NpgsqlTypes.NpgsqlPoint(x: 0.5206315891188723d, y: 0.048779030674929724d), new NpgsqlTypes.NpgsqlPoint(x: 0.764846350899159d, y: 0.3881236410230293d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5346042538445893d, y: 0.8587062537185063d), new NpgsqlTypes.NpgsqlPoint(x: 0.24784196502051703d, y: 0.02457232720066871d), new NpgsqlTypes.NpgsqlPoint(x: 0.9170413913141706d, y: 0.071646241449142d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6800135029148238d, y: 0.6147629180430989d), new NpgsqlTypes.NpgsqlPoint(x: 0.2297815155177847d, y: 0.3601599930171263d), new NpgsqlTypes.NpgsqlPoint(x: 0.09141506304051239d, y: 0.17175467026278413d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4792456974439423d, y: 0.2542262566717247d), new NpgsqlTypes.NpgsqlPoint(x: 0.20798145351615127d, y: 0.587035456372373d), new NpgsqlTypes.NpgsqlPoint(x: 0.7572656884611458d, y: 0.9696328537347899d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6587556964845267d, y: 0.7094178464843274d), new NpgsqlTypes.NpgsqlPoint(x: 0.303406965293307d, y: 0.06909115085675277d), new NpgsqlTypes.NpgsqlPoint(x: 0.5471758870974632d, y: 0.6925597525454638d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3010877955587079d, y: 0.09410341393833177d), new NpgsqlTypes.NpgsqlPoint(x: 0.9606658200166039d, y: 0.7632776278270503d), new NpgsqlTypes.NpgsqlPoint(x: 0.5060947655165074d, y: 0.9850107006181839d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.511788425828945d, y: 0.8529039998891789d), new NpgsqlTypes.NpgsqlPoint(x: 0.8981588030193638d, y: 0.5856159816006639d), new NpgsqlTypes.NpgsqlPoint(x: 0.7073621454309299d, y: 0.603690744332058d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9753229115326375d, y: 0.5216423529124572d), new NpgsqlTypes.NpgsqlPoint(x: 0.12206800137172269d, y: 0.18650408372467775d), new NpgsqlTypes.NpgsqlPoint(x: 0.23774748072713647d, y: 0.3355702482291806d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7444402350329394d, y: 0.9969901359381806d), new NpgsqlTypes.NpgsqlPoint(x: 0.3317182293490065d, y: 0.020433285758546527d), new NpgsqlTypes.NpgsqlPoint(x: 0.029549999381020098d, y: 0.2644938500794253d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20760833474197926d, y: 0.4297648493016134d), new NpgsqlTypes.NpgsqlPoint(x: 0.7203606868728294d, y: 0.1075117878539128d), new NpgsqlTypes.NpgsqlPoint(x: 0.11823158623706065d, y: 0.38967375227133383d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32445044975992343d, y: 0.3778959366426632d), new NpgsqlTypes.NpgsqlPoint(x: 0.755586719546974d, y: 0.5293653586597679d), new NpgsqlTypes.NpgsqlPoint(x: 0.19102965042601283d, y: 0.6465715833942237d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24982274773595792d, y: 0.2151918734012861d), new NpgsqlTypes.NpgsqlPoint(x: 0.05909352716635796d, y: 0.8392668304648281d), new NpgsqlTypes.NpgsqlPoint(x: 0.7279014602400348d, y: 0.9348944713209495d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22798514406860204d, y: 0.36395453080095885d), new NpgsqlTypes.NpgsqlPoint(x: 0.518106044410047d, y: 0.9918925403229342d), new NpgsqlTypes.NpgsqlPoint(x: 0.7647419040501867d, y: 0.6946139539774508d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09249430568257166d, y: 0.291634492621345d), new NpgsqlTypes.NpgsqlPoint(x: 0.5310142006658045d, y: 0.8295332331286611d), new NpgsqlTypes.NpgsqlPoint(x: 0.03369888710044544d, y: 0.02339096317719702d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.062337969072722044d, y: 0.884268082002017d), new NpgsqlTypes.NpgsqlPoint(x: 0.03965176511365098d, y: 0.3051021441545666d), new NpgsqlTypes.NpgsqlPoint(x: 0.7685639553097819d, y: 0.3305895058105629d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10034040403756506d, y: 0.20456168099574956d), new NpgsqlTypes.NpgsqlPoint(x: 0.16329300430766736d, y: 0.90184068047646d), new NpgsqlTypes.NpgsqlPoint(x: 0.866688719245575d, y: 0.8668868824440511d)), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1371035223698438d, y: 0.3547268670238597d), new NpgsqlTypes.NpgsqlPoint(x: 0.8262361023655627d, y: 0.2634948934045649d), new NpgsqlTypes.NpgsqlPoint(x: 0.6530971679960332d, y: 0.34038165641719154d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7481753191011392d, y: 0.93040810897688d), new NpgsqlTypes.NpgsqlPoint(x: 0.6323327687813772d, y: 0.9884710328568651d), new NpgsqlTypes.NpgsqlPoint(x: 0.36197069385958613d, y: 0.20547854556374545d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39895009698713546d, y: 0.4710691186780689d), new NpgsqlTypes.NpgsqlPoint(x: 0.4315410992665718d, y: 0.16002195800473962d), new NpgsqlTypes.NpgsqlPoint(x: 0.577634303256138d, y: 0.7153608169657424d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08278972628252101d, y: 0.9871196320166281d), new NpgsqlTypes.NpgsqlPoint(x: 0.9031021158630917d, y: 0.27578716865655717d), new NpgsqlTypes.NpgsqlPoint(x: 0.85672027171691d, y: 0.020686406477507968d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9827214932248562d, y: 0.27992523014380766d), new NpgsqlTypes.NpgsqlPoint(x: 0.1712314981085381d, y: 0.6617723217801572d), new NpgsqlTypes.NpgsqlPoint(x: 0.6087765660048068d, y: 0.8379171632242993d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9374506352753411d, y: 0.58929514237448d), new NpgsqlTypes.NpgsqlPoint(x: 0.25759881752590474d, y: 0.18733090098149674d), new NpgsqlTypes.NpgsqlPoint(x: 0.7067835760067224d, y: 0.40681616791970265d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2373405063292754d, y: 0.8670355227763376d), new NpgsqlTypes.NpgsqlPoint(x: 0.2225452482080148d, y: 0.9885740919423337d), new NpgsqlTypes.NpgsqlPoint(x: 0.3121996008774769d, y: 0.7736186887775934d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8336158946389854d, y: 0.1739387788309883d), new NpgsqlTypes.NpgsqlPoint(x: 0.3793092251460577d, y: 0.4142624669831103d), new NpgsqlTypes.NpgsqlPoint(x: 0.434924005446102d, y: 0.3761032891418423d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33386606413861486d, y: 0.6831975847724858d), new NpgsqlTypes.NpgsqlPoint(x: 0.5737175856558192d, y: 0.4648040725973247d), new NpgsqlTypes.NpgsqlPoint(x: 0.40143273425804993d, y: 0.25944775003277687d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7063245311589317d, y: 0.45032827826319777d), new NpgsqlTypes.NpgsqlPoint(x: 0.09873080844655335d, y: 0.7505734553914181d), new NpgsqlTypes.NpgsqlPoint(x: 0.6581254835068681d, y: 0.4927608262092634d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06718463807874908d, y: 0.9953723454501469d), new NpgsqlTypes.NpgsqlPoint(x: 0.8542241790326176d, y: 0.4015557348008044d), new NpgsqlTypes.NpgsqlPoint(x: 0.36288118240201506d, y: 0.34794143170821645d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.976786405752476d, y: 0.14808420671240852d), new NpgsqlTypes.NpgsqlPoint(x: 0.19232190969181084d, y: 0.5224900473137835d), new NpgsqlTypes.NpgsqlPoint(x: 0.5560138929834066d, y: 0.090904835383529d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9725065965840273d, y: 0.42010650467823274d), new NpgsqlTypes.NpgsqlPoint(x: 0.964723517897152d, y: 0.6421760711047746d), new NpgsqlTypes.NpgsqlPoint(x: 0.962309022141728d, y: 0.6048702460461522d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4286409585714298d, y: 0.016180295149271218d), new NpgsqlTypes.NpgsqlPoint(x: 0.5173154980010919d, y: 0.4055022111842128d), new NpgsqlTypes.NpgsqlPoint(x: 0.6972951398518047d, y: 0.04188358469694664d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6278221969135087d, y: 0.26672041452618656d), new NpgsqlTypes.NpgsqlPoint(x: 0.9646583896305198d, y: 0.08183370926614919d), new NpgsqlTypes.NpgsqlPoint(x: 0.5489716481861985d, y: 0.30105184033480337d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8591467178109149d, y: 0.5045030606293307d), new NpgsqlTypes.NpgsqlPoint(x: 0.5612721435455422d, y: 0.6095456330103429d), new NpgsqlTypes.NpgsqlPoint(x: 0.4572982927079672d, y: 0.5246930323506328d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9989186263804569d, y: 0.40655616754988766d), new NpgsqlTypes.NpgsqlPoint(x: 0.4482028552992886d, y: 0.7652360287549138d), new NpgsqlTypes.NpgsqlPoint(x: 0.8530000256761568d, y: 0.475788775363599d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6952765219489303d, y: 0.15877235469846185d), new NpgsqlTypes.NpgsqlPoint(x: 0.2552749673911171d, y: 0.33626226785337987d), new NpgsqlTypes.NpgsqlPoint(x: 0.24005030933708082d, y: 0.41762908368486207d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.059621574454480575d, y: 0.21897842171479742d), new NpgsqlTypes.NpgsqlPoint(x: 0.7351720327055967d, y: 0.6164580323598404d), new NpgsqlTypes.NpgsqlPoint(x: 0.7239753007633544d, y: 0.671556745852623d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8184570484763977d, y: 0.4940498595394194d), new NpgsqlTypes.NpgsqlPoint(x: 0.4306479677248125d, y: 0.7951579140844978d), new NpgsqlTypes.NpgsqlPoint(x: 0.3289899697725559d, y: 0.937810358293747d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8334388832357181d, y: 0.637741755107704d), new NpgsqlTypes.NpgsqlPoint(x: 0.49693797108049353d, y: 0.7865833526316915d), new NpgsqlTypes.NpgsqlPoint(x: 0.6877167357373819d, y: 0.4867729944112341d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03054811592325757d, y: 0.25731070940945044d), new NpgsqlTypes.NpgsqlPoint(x: 0.17445877074849359d, y: 0.4940324194401119d), new NpgsqlTypes.NpgsqlPoint(x: 0.923801757938353d, y: 0.7047245083927727d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27369556638956616d, y: 0.6307196559624344d), new NpgsqlTypes.NpgsqlPoint(x: 0.7953407982588456d, y: 0.47526645000127354d), new NpgsqlTypes.NpgsqlPoint(x: 0.6361997699623367d, y: 0.7413462914892839d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0015925254189811389d, y: 0.3492622761542755d), new NpgsqlTypes.NpgsqlPoint(x: 0.11659572499071236d, y: 0.888634523711844d), new NpgsqlTypes.NpgsqlPoint(x: 0.5219105175771601d, y: 0.8152950233202917d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7985274653172546d, y: 0.8836968203663266d), new NpgsqlTypes.NpgsqlPoint(x: 0.43803309155632586d, y: 0.43098361651986683d), new NpgsqlTypes.NpgsqlPoint(x: 0.5510428874511817d, y: 0.7271800607237048d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9079075173979999d, y: 0.5410102273998025d), new NpgsqlTypes.NpgsqlPoint(x: 0.676772535757131d, y: 0.9704459983964038d), new NpgsqlTypes.NpgsqlPoint(x: 0.4113633574602843d, y: 0.05313541480450279d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007931038983290173d, y: 0.9901470772595291d), new NpgsqlTypes.NpgsqlPoint(x: 0.7358666349176203d, y: 0.7488232593827167d), new NpgsqlTypes.NpgsqlPoint(x: 0.04813059901451222d, y: 0.09115174470039966d)), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9413134368736592d, y: 0.11301978945766811d), new NpgsqlTypes.NpgsqlPoint(x: 0.18024705469030244d, y: 0.12818489444113068d), new NpgsqlTypes.NpgsqlPoint(x: 0.2571504835785067d, y: 0.24518135062656077d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6481398928534255d, y: 0.7632428267509445d), new NpgsqlTypes.NpgsqlPoint(x: 0.9969104373348013d, y: 0.5020558920288632d), new NpgsqlTypes.NpgsqlPoint(x: 0.8079545971518208d, y: 0.058778405850421045d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9412645225564599d, y: 0.2118238010573542d), new NpgsqlTypes.NpgsqlPoint(x: 0.9257950650787347d, y: 0.9885239768093805d), new NpgsqlTypes.NpgsqlPoint(x: 0.6358395731724413d, y: 0.7322528752624992d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5608194036276102d, y: 0.24965905577256442d), new NpgsqlTypes.NpgsqlPoint(x: 0.8499060524603894d, y: 0.3515150459230191d), new NpgsqlTypes.NpgsqlPoint(x: 0.43581284996126934d, y: 0.5837401430578615d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8089561420425747d, y: 0.7287865001074401d), new NpgsqlTypes.NpgsqlPoint(x: 0.6726362760100125d, y: 0.1426300417268146d), new NpgsqlTypes.NpgsqlPoint(x: 0.6339306955067097d, y: 0.9229662840095009d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6914868643120377d, y: 0.0773439722702226d), new NpgsqlTypes.NpgsqlPoint(x: 0.5810472894783292d, y: 0.024104766302589953d), new NpgsqlTypes.NpgsqlPoint(x: 0.044039727299929665d, y: 0.45496531671685814d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.285964120270526d, y: 0.6576859976483345d), new NpgsqlTypes.NpgsqlPoint(x: 0.3543521318037606d, y: 0.9952569514085469d), new NpgsqlTypes.NpgsqlPoint(x: 0.7792492546704745d, y: 0.864977326932323d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6582565345880025d, y: 0.624585961994526d), new NpgsqlTypes.NpgsqlPoint(x: 0.4263673287667702d, y: 0.8653754709189292d), new NpgsqlTypes.NpgsqlPoint(x: 0.02690594183688655d, y: 0.35446873496430076d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8776160045453565d, y: 0.34379101783165544d), new NpgsqlTypes.NpgsqlPoint(x: 0.8114062750790425d, y: 0.6117198024100952d), new NpgsqlTypes.NpgsqlPoint(x: 0.7037163067912175d, y: 0.10653853510448918d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20177125446830313d, y: 0.47250555134857974d), new NpgsqlTypes.NpgsqlPoint(x: 0.39042505676699446d, y: 0.675837921171688d), new NpgsqlTypes.NpgsqlPoint(x: 0.9196497757083073d, y: 0.9350571858963247d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11967595583764112d, y: 0.585700657296742d), new NpgsqlTypes.NpgsqlPoint(x: 0.14423746291679973d, y: 0.3247147912106144d), new NpgsqlTypes.NpgsqlPoint(x: 0.07871918335723693d, y: 0.6632132232426688d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9970135568027485d, y: 0.9834381525026533d), new NpgsqlTypes.NpgsqlPoint(x: 0.35842243615817226d, y: 0.15295706603441717d), new NpgsqlTypes.NpgsqlPoint(x: 0.9971731901478794d, y: 0.942512633197953d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8263186693769276d, y: 0.4036069045197881d), new NpgsqlTypes.NpgsqlPoint(x: 0.5871596425034139d, y: 0.7981956829070599d), new NpgsqlTypes.NpgsqlPoint(x: 0.09464174253058832d, y: 0.44539991042183424d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.720834892256805d, y: 0.691827116342798d), new NpgsqlTypes.NpgsqlPoint(x: 0.6791224879007856d, y: 0.612692803964014d), new NpgsqlTypes.NpgsqlPoint(x: 0.49619314766911715d, y: 0.42627924313546073d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.843041121960228d, y: 0.11529251806075946d), new NpgsqlTypes.NpgsqlPoint(x: 0.9611743755608696d, y: 0.6996123506595098d), new NpgsqlTypes.NpgsqlPoint(x: 0.47070044430416236d, y: 0.45217194031134755d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6020480552739294d, y: 0.8877121681576564d), new NpgsqlTypes.NpgsqlPoint(x: 0.753816987106316d, y: 0.7586451999479594d), new NpgsqlTypes.NpgsqlPoint(x: 0.28171786912795704d, y: 0.282254350690053d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05551680900193423d, y: 0.4531346063561942d), new NpgsqlTypes.NpgsqlPoint(x: 0.7667154796955751d, y: 0.8989414041374082d), new NpgsqlTypes.NpgsqlPoint(x: 0.20613625088949405d, y: 0.7463152162863266d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33184592834244786d, y: 0.5727630083301337d), new NpgsqlTypes.NpgsqlPoint(x: 0.24227700272552222d, y: 0.4966097945432004d), new NpgsqlTypes.NpgsqlPoint(x: 0.424406190071576d, y: 0.21187077429522938d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10702373969608936d, y: 0.08332469261627506d), new NpgsqlTypes.NpgsqlPoint(x: 0.5123460665776134d, y: 0.7398463529471058d), new NpgsqlTypes.NpgsqlPoint(x: 0.7897688363811308d, y: 0.644245946544074d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7806082223501809d, y: 0.08828806694068503d), new NpgsqlTypes.NpgsqlPoint(x: 0.4737938055293003d, y: 0.48103036398079335d), new NpgsqlTypes.NpgsqlPoint(x: 0.7656206749875095d, y: 0.9182500486664327d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1588785124307328d, y: 0.9735959267085006d), new NpgsqlTypes.NpgsqlPoint(x: 0.388888745699303d, y: 0.8488214240755484d), new NpgsqlTypes.NpgsqlPoint(x: 0.7678861117568332d, y: 0.7221594742002962d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7869906539102384d, y: 0.7620439806308191d), new NpgsqlTypes.NpgsqlPoint(x: 0.5103186366394968d, y: 0.8087251974617092d), new NpgsqlTypes.NpgsqlPoint(x: 0.42527306991169855d, y: 0.8717628642769069d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28337018205999764d, y: 0.09786044709248876d), new NpgsqlTypes.NpgsqlPoint(x: 0.9989184932908479d, y: 0.26513222477804865d), new NpgsqlTypes.NpgsqlPoint(x: 0.14027831141430536d, y: 0.8760950896208345d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24137975580470616d, y: 0.23519017904456196d), new NpgsqlTypes.NpgsqlPoint(x: 0.4699539136741735d, y: 0.4994668674653392d), new NpgsqlTypes.NpgsqlPoint(x: 0.39243157065106415d, y: 0.7101382334257501d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7372301305539216d, y: 0.9585759679024164d), new NpgsqlTypes.NpgsqlPoint(x: 0.00969975923363331d, y: 0.11400656502227502d), new NpgsqlTypes.NpgsqlPoint(x: 0.24883484106056064d, y: 0.1156300975996174d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6732264472282005d, y: 0.9404202033648593d), new NpgsqlTypes.NpgsqlPoint(x: 0.588954775219525d, y: 0.661896606422497d), new NpgsqlTypes.NpgsqlPoint(x: 0.952125308241176d, y: 0.20178743638350372d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8887791304291823d, y: 0.9428533470754613d), new NpgsqlTypes.NpgsqlPoint(x: 0.8755561936114743d, y: 0.49201817438187356d), new NpgsqlTypes.NpgsqlPoint(x: 0.9319117991094885d, y: 0.5507406402121479d)), }, }, },
    ModelInner = new NpgsqlPathpathMMArrayD3E1MI
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5926047106411066d, y: 0.6478780336421575d), new NpgsqlTypes.NpgsqlPoint(x: 0.5146648282223579d, y: 0.024517801874220257d), new NpgsqlTypes.NpgsqlPoint(x: 0.7553713759781949d, y: 0.8935528425448641d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015903860617130672d, y: 0.08893743720722336d), new NpgsqlTypes.NpgsqlPoint(x: 0.6838681220483183d, y: 0.9914001460093096d), new NpgsqlTypes.NpgsqlPoint(x: 0.6320826146889258d, y: 0.8150851166013263d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5644110194069556d, y: 0.9211828339205197d), new NpgsqlTypes.NpgsqlPoint(x: 0.47909559057278905d, y: 0.5988283417780854d), new NpgsqlTypes.NpgsqlPoint(x: 0.7574403285963873d, y: 0.1701444911020169d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0536709714176935d, y: 0.5599351251228774d), new NpgsqlTypes.NpgsqlPoint(x: 0.19595501026463946d, y: 0.7600500267197694d), new NpgsqlTypes.NpgsqlPoint(x: 0.32954914338311925d, y: 0.2234879135650275d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.768070228216052d, y: 0.8206008501858039d), new NpgsqlTypes.NpgsqlPoint(x: 0.6348206253365037d, y: 0.3932311245626615d), new NpgsqlTypes.NpgsqlPoint(x: 0.31382807599347273d, y: 0.04483541845818895d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9101914755680228d, y: 0.5214357434304813d), new NpgsqlTypes.NpgsqlPoint(x: 0.2936125794422523d, y: 0.07307220368238221d), new NpgsqlTypes.NpgsqlPoint(x: 0.11802636288958668d, y: 0.38355400137702944d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9476648915445989d, y: 0.4407308428769714d), new NpgsqlTypes.NpgsqlPoint(x: 0.5384354685382049d, y: 0.9996920021499519d), new NpgsqlTypes.NpgsqlPoint(x: 0.3342597397677266d, y: 0.3599378268036155d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2680873269152356d, y: 0.6346018603324867d), new NpgsqlTypes.NpgsqlPoint(x: 0.8913155272195546d, y: 0.3719956042932463d), new NpgsqlTypes.NpgsqlPoint(x: 0.31053932433097453d, y: 0.5720642188718971d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8942205506625138d, y: 0.2122437589128645d), new NpgsqlTypes.NpgsqlPoint(x: 0.7896542411641867d, y: 0.6401092153637615d), new NpgsqlTypes.NpgsqlPoint(x: 0.7711737431396508d, y: 0.9335830054570555d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9718485606790255d, y: 0.31204933990155537d), new NpgsqlTypes.NpgsqlPoint(x: 0.09817744400852602d, y: 0.6856556308785706d), new NpgsqlTypes.NpgsqlPoint(x: 0.9800625591904152d, y: 0.7107233905341696d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39653420169711195d, y: 0.58814701064691d), new NpgsqlTypes.NpgsqlPoint(x: 0.34279075087074506d, y: 0.6903850535342009d), new NpgsqlTypes.NpgsqlPoint(x: 0.352372963589231d, y: 0.26808300792780726d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7681730263069214d, y: 0.5011439441502311d), new NpgsqlTypes.NpgsqlPoint(x: 0.3204942487436252d, y: 0.39425593802857983d), new NpgsqlTypes.NpgsqlPoint(x: 0.37037878886529485d, y: 0.6990672276577325d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5494994101978584d, y: 0.829360252400708d), new NpgsqlTypes.NpgsqlPoint(x: 0.15010416539881333d, y: 0.6634361677837204d), new NpgsqlTypes.NpgsqlPoint(x: 0.5277021257931745d, y: 0.006905258880096077d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8529631278826169d, y: 0.23544824470575687d), new NpgsqlTypes.NpgsqlPoint(x: 0.7246307040521685d, y: 0.5819030460149617d), new NpgsqlTypes.NpgsqlPoint(x: 0.6881023606753932d, y: 0.5182340897251374d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6860991451289643d, y: 0.7530538228353091d), new NpgsqlTypes.NpgsqlPoint(x: 0.00959668282895998d, y: 0.8703721829253668d), new NpgsqlTypes.NpgsqlPoint(x: 0.23928956838413806d, y: 0.9472551878565726d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20236531283359482d, y: 0.20560120970590257d), new NpgsqlTypes.NpgsqlPoint(x: 0.57770522659249d, y: 0.6379510833556474d), new NpgsqlTypes.NpgsqlPoint(x: 0.9363220766001231d, y: 0.9744394110616492d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10806680152718195d, y: 0.4269941514226887d), new NpgsqlTypes.NpgsqlPoint(x: 0.23398417255906423d, y: 0.885236840688322d), new NpgsqlTypes.NpgsqlPoint(x: 0.8199510067648497d, y: 0.18439967368577515d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5825813093447479d, y: 0.9448322734506481d), new NpgsqlTypes.NpgsqlPoint(x: 0.2350951963343153d, y: 0.0837057339848215d), new NpgsqlTypes.NpgsqlPoint(x: 0.8925937415149995d, y: 0.7315537456348195d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8398786821376312d, y: 0.29561685937720505d), new NpgsqlTypes.NpgsqlPoint(x: 0.44253380294093425d, y: 0.3012267434201774d), new NpgsqlTypes.NpgsqlPoint(x: 0.4533821816058058d, y: 0.8810569045137939d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6863174306785292d, y: 0.16524168666431105d), new NpgsqlTypes.NpgsqlPoint(x: 0.8202450193152712d, y: 0.09594205871988626d), new NpgsqlTypes.NpgsqlPoint(x: 0.5135053953845818d, y: 0.8058310301477317d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9650358832380375d, y: 0.7917879288188882d), new NpgsqlTypes.NpgsqlPoint(x: 0.0024133520437481515d, y: 0.2649403747249638d), new NpgsqlTypes.NpgsqlPoint(x: 0.8994316885900568d, y: 0.3683284393344298d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8809146330906085d, y: 0.524600476798389d), new NpgsqlTypes.NpgsqlPoint(x: 0.9976419658965611d, y: 0.1541182208321079d), new NpgsqlTypes.NpgsqlPoint(x: 0.6591625834584064d, y: 0.17011204558956616d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.534549505200161d, y: 0.6850135126670792d), new NpgsqlTypes.NpgsqlPoint(x: 0.9963431243917253d, y: 0.9316242386483409d), new NpgsqlTypes.NpgsqlPoint(x: 0.7212408486498645d, y: 0.5633154528946512d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.667260738844095d, y: 0.5889757469262387d), new NpgsqlTypes.NpgsqlPoint(x: 0.1800296960863339d, y: 0.15652071370832166d), new NpgsqlTypes.NpgsqlPoint(x: 0.043628297120685056d, y: 0.7950455778515041d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8296089320839213d, y: 0.6791756411071577d), new NpgsqlTypes.NpgsqlPoint(x: 0.06115212370419543d, y: 0.030586720295749714d), new NpgsqlTypes.NpgsqlPoint(x: 0.25100553932591874d, y: 0.7564292901345835d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7364941203533382d, y: 0.9952787575134d), new NpgsqlTypes.NpgsqlPoint(x: 0.8296432235560679d, y: 0.2923336524078519d), new NpgsqlTypes.NpgsqlPoint(x: 0.44303676772299005d, y: 0.7464538120513012d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43007846302196484d, y: 0.24391619723502211d), new NpgsqlTypes.NpgsqlPoint(x: 0.7004351786051374d, y: 0.6372621418654018d), new NpgsqlTypes.NpgsqlPoint(x: 0.7855898585893125d, y: 0.8125343053367264d)), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06372187631164339d, y: 0.7399000711299785d), new NpgsqlTypes.NpgsqlPoint(x: 0.20188392014030454d, y: 0.3355304122747702d), new NpgsqlTypes.NpgsqlPoint(x: 0.359614883008299d, y: 0.6430367774506154d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44142616341522267d, y: 0.14738494293140325d), new NpgsqlTypes.NpgsqlPoint(x: 0.8983901295166018d, y: 0.9572485302722573d), new NpgsqlTypes.NpgsqlPoint(x: 0.19614056476156483d, y: 0.6691836391503753d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5891746564620981d, y: 0.6141206679302251d), new NpgsqlTypes.NpgsqlPoint(x: 0.5040087387662868d, y: 0.07403973399470554d), new NpgsqlTypes.NpgsqlPoint(x: 0.17182885116260416d, y: 0.5513800531679348d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5527912749216372d, y: 0.6697548245145966d), new NpgsqlTypes.NpgsqlPoint(x: 0.1935717684437327d, y: 0.851378652212075d), new NpgsqlTypes.NpgsqlPoint(x: 0.34470314996497864d, y: 0.44706237805895377d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8126549249873554d, y: 0.2206503564419231d), new NpgsqlTypes.NpgsqlPoint(x: 0.9365091209646494d, y: 0.4413587581555797d), new NpgsqlTypes.NpgsqlPoint(x: 0.865740026170239d, y: 0.962382666727052d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08194955831427875d, y: 0.054899330884041975d), new NpgsqlTypes.NpgsqlPoint(x: 0.510914992813113d, y: 0.7152015844127787d), new NpgsqlTypes.NpgsqlPoint(x: 0.3033620314072064d, y: 0.6876476464856988d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5974108776490585d, y: 0.7117649184842907d), new NpgsqlTypes.NpgsqlPoint(x: 0.6419458507936964d, y: 0.3372577371727654d), new NpgsqlTypes.NpgsqlPoint(x: 0.41510244975604094d, y: 0.8545569694906006d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2901557320950158d, y: 0.7097843544324648d), new NpgsqlTypes.NpgsqlPoint(x: 0.47733213540207564d, y: 0.42889706898757374d), new NpgsqlTypes.NpgsqlPoint(x: 0.8384740731042079d, y: 0.48893405187027206d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6473685735163387d, y: 0.9682550820744397d), new NpgsqlTypes.NpgsqlPoint(x: 0.040422050651897745d, y: 0.35662207294943427d), new NpgsqlTypes.NpgsqlPoint(x: 0.8280940550763486d, y: 0.11405027213721297d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3676774134803359d, y: 0.4596993497100087d), new NpgsqlTypes.NpgsqlPoint(x: 0.2366839447608846d, y: 0.7237624298649646d), new NpgsqlTypes.NpgsqlPoint(x: 0.3427644172742783d, y: 0.8417323754537833d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09613627746360554d, y: 0.5786029935951454d), new NpgsqlTypes.NpgsqlPoint(x: 0.5648462497984179d, y: 0.14713866510934326d), new NpgsqlTypes.NpgsqlPoint(x: 0.5059804235183438d, y: 0.1456019622156034d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.874667770696927d, y: 0.8321375134540548d), new NpgsqlTypes.NpgsqlPoint(x: 0.8824666254739678d, y: 0.9809808499421552d), new NpgsqlTypes.NpgsqlPoint(x: 0.6265628404770073d, y: 0.39530714134523337d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13259193709683792d, y: 0.25150241265001017d), new NpgsqlTypes.NpgsqlPoint(x: 0.8344036786458076d, y: 0.04425648909790447d), new NpgsqlTypes.NpgsqlPoint(x: 0.4429134596721892d, y: 0.973530567542189d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9721401281964797d, y: 0.1630475191478371d), new NpgsqlTypes.NpgsqlPoint(x: 0.7409215813697912d, y: 0.36962289214168365d), new NpgsqlTypes.NpgsqlPoint(x: 0.41641492360310106d, y: 0.9660753542204308d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6268997031960925d, y: 0.4245295678126422d), new NpgsqlTypes.NpgsqlPoint(x: 0.8853358955761972d, y: 0.9844437075857989d), new NpgsqlTypes.NpgsqlPoint(x: 0.9949294673683192d, y: 0.4490874828557272d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2921143032325312d, y: 0.7461677196856811d), new NpgsqlTypes.NpgsqlPoint(x: 0.699455246582998d, y: 0.5411415036495105d), new NpgsqlTypes.NpgsqlPoint(x: 0.1985885964303329d, y: 0.3077480973005585d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19559858921563122d, y: 0.7582095007486953d), new NpgsqlTypes.NpgsqlPoint(x: 0.737065095861051d, y: 0.9854349041181921d), new NpgsqlTypes.NpgsqlPoint(x: 0.043612233203640605d, y: 0.703417486543137d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.045822119802730876d, y: 0.7875873024971252d), new NpgsqlTypes.NpgsqlPoint(x: 0.4655210609768643d, y: 0.17781757541183274d), new NpgsqlTypes.NpgsqlPoint(x: 0.5100162230107786d, y: 0.5278787644915288d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5420512752090249d, y: 0.6538615558908144d), new NpgsqlTypes.NpgsqlPoint(x: 0.933106775706017d, y: 0.5880758421235918d), new NpgsqlTypes.NpgsqlPoint(x: 0.19873505453245566d, y: 0.6427490678654335d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9495575319286813d, y: 0.99763668321549d), new NpgsqlTypes.NpgsqlPoint(x: 0.5852649628357871d, y: 0.6004805221559011d), new NpgsqlTypes.NpgsqlPoint(x: 0.7133521403163601d, y: 0.443610983226587d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1311999341310247d, y: 0.6496816525445189d), new NpgsqlTypes.NpgsqlPoint(x: 0.4619599498325583d, y: 0.19223752638930625d), new NpgsqlTypes.NpgsqlPoint(x: 0.424338803785141d, y: 0.8992123904061334d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2197168511340135d, y: 0.8225053499925585d), new NpgsqlTypes.NpgsqlPoint(x: 0.8237740363908328d, y: 0.5296720272097696d), new NpgsqlTypes.NpgsqlPoint(x: 0.8993072895007049d, y: 0.39458455236338075d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.018105083045481307d, y: 0.13679538578800465d), new NpgsqlTypes.NpgsqlPoint(x: 0.3533371971201529d, y: 0.47562930715917384d), new NpgsqlTypes.NpgsqlPoint(x: 0.9860427576220379d, y: 0.22146035917071505d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8028499203325098d, y: 0.001373163147361467d), new NpgsqlTypes.NpgsqlPoint(x: 0.17902355361563105d, y: 0.18038478192049034d), new NpgsqlTypes.NpgsqlPoint(x: 0.3390424371262254d, y: 0.3813648703341137d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44895299790778753d, y: 0.10145484142858918d), new NpgsqlTypes.NpgsqlPoint(x: 0.3192122280862316d, y: 0.8037245391091449d), new NpgsqlTypes.NpgsqlPoint(x: 0.15790261390588078d, y: 0.26973343443536413d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23276222616830688d, y: 0.9520032547348568d), new NpgsqlTypes.NpgsqlPoint(x: 0.42575568750446524d, y: 0.08404975847737972d), new NpgsqlTypes.NpgsqlPoint(x: 0.9588225098397145d, y: 0.7639355494597686d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9360547246577368d, y: 0.07980152102234495d), new NpgsqlTypes.NpgsqlPoint(x: 0.2583308241924652d, y: 0.14553660091457388d), new NpgsqlTypes.NpgsqlPoint(x: 0.10065017051770642d, y: 0.9595525357125074d)), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD3E1M
{
    Id = 166,
    Value = 
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2225465571966766d, y: 0.47270995374300484d), new NpgsqlTypes.NpgsqlPoint(x: 0.6342376539696106d, y: 0.8637619874940027d), new NpgsqlTypes.NpgsqlPoint(x: 0.427924743535413d, y: 0.03257602655255587d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9671518386536628d, y: 0.19022156529355638d), new NpgsqlTypes.NpgsqlPoint(x: 0.5521812038125483d, y: 0.5082879629827215d), new NpgsqlTypes.NpgsqlPoint(x: 0.6699637099041154d, y: 0.15205557702660022d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3639787337992817d, y: 0.8661598622504592d), new NpgsqlTypes.NpgsqlPoint(x: 0.2974686827971268d, y: 0.8734942782779882d), new NpgsqlTypes.NpgsqlPoint(x: 0.11011499824410986d, y: 0.34925550640457637d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11958567744376158d, y: 0.3782210662990316d), new NpgsqlTypes.NpgsqlPoint(x: 0.07340388721821511d, y: 0.7818532604153795d), new NpgsqlTypes.NpgsqlPoint(x: 0.07865221793766686d, y: 0.7574881228564547d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3855266188800326d, y: 0.49470522107053294d), new NpgsqlTypes.NpgsqlPoint(x: 0.33185897908632345d, y: 0.691673213030684d), new NpgsqlTypes.NpgsqlPoint(x: 0.9776903194876981d, y: 0.6789556417720021d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5470805579870404d, y: 0.8209693661024408d), new NpgsqlTypes.NpgsqlPoint(x: 0.3982408344345859d, y: 0.10367420629792068d), new NpgsqlTypes.NpgsqlPoint(x: 0.6857789608753342d, y: 0.8684671198125322d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6357942721997817d, y: 0.18170711193247147d), new NpgsqlTypes.NpgsqlPoint(x: 0.5431726438356368d, y: 0.4517242296575469d), new NpgsqlTypes.NpgsqlPoint(x: 0.06761762158556128d, y: 0.14722805719291943d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8520898891426447d, y: 0.39003106259568154d), new NpgsqlTypes.NpgsqlPoint(x: 0.7761905925597968d, y: 0.5356219408079589d), new NpgsqlTypes.NpgsqlPoint(x: 0.04844945155080882d, y: 0.6147065031684188d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3973145153954498d, y: 0.2016335928191998d), new NpgsqlTypes.NpgsqlPoint(x: 0.5621587085429923d, y: 0.7024036407279053d), new NpgsqlTypes.NpgsqlPoint(x: 0.5302324635977711d, y: 0.7844281380184556d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01948986048818324d, y: 0.485873824763547d), new NpgsqlTypes.NpgsqlPoint(x: 0.8731119434973343d, y: 0.4627928975565072d), new NpgsqlTypes.NpgsqlPoint(x: 0.9558694771904973d, y: 0.806395166701684d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8065403240329201d, y: 0.005856064417983697d), new NpgsqlTypes.NpgsqlPoint(x: 0.3665654772458685d, y: 0.1546260380569131d), new NpgsqlTypes.NpgsqlPoint(x: 0.9425513163026216d, y: 0.9159048242242688d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5727735690533745d, y: 0.34042774064488235d), new NpgsqlTypes.NpgsqlPoint(x: 0.003472889739539964d, y: 0.539217939213751d), new NpgsqlTypes.NpgsqlPoint(x: 0.820461594953383d, y: 0.5948594444013423d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17531601156256915d, y: 0.003162464002394727d), new NpgsqlTypes.NpgsqlPoint(x: 0.08124346842935548d, y: 0.07283230627833182d), new NpgsqlTypes.NpgsqlPoint(x: 0.9448932329732475d, y: 0.9528109010289116d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4558346390103092d, y: 0.6044192172736685d), new NpgsqlTypes.NpgsqlPoint(x: 0.2459451864797002d, y: 0.6975621615858155d), new NpgsqlTypes.NpgsqlPoint(x: 0.5862190053128411d, y: 0.8555325878524631d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6970778310806912d, y: 0.6711865677517457d), new NpgsqlTypes.NpgsqlPoint(x: 0.2704105990774207d, y: 0.553481947689238d), new NpgsqlTypes.NpgsqlPoint(x: 0.9684403680003586d, y: 0.5172201482399671d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6158146009532134d, y: 0.1669864761213109d), new NpgsqlTypes.NpgsqlPoint(x: 0.7070832620825861d, y: 0.5357240152016826d), new NpgsqlTypes.NpgsqlPoint(x: 0.4591339126889097d, y: 0.34551284971930185d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012594648066648562d, y: 0.19153995352460285d), new NpgsqlTypes.NpgsqlPoint(x: 0.40593154833658907d, y: 0.8638185452928537d), new NpgsqlTypes.NpgsqlPoint(x: 0.24351297072960232d, y: 0.8175307312838193d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6707419854932012d, y: 0.8256661502277782d), new NpgsqlTypes.NpgsqlPoint(x: 0.8675078436599839d, y: 0.3831748059829725d), new NpgsqlTypes.NpgsqlPoint(x: 0.12468020958508408d, y: 0.6024054775437786d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9910323845049073d, y: 0.5831078192863876d), new NpgsqlTypes.NpgsqlPoint(x: 0.3454035956410222d, y: 0.14210804895003426d), new NpgsqlTypes.NpgsqlPoint(x: 0.0016907682677659297d, y: 0.6602283343904278d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9111846375038795d, y: 0.272255996184689d), new NpgsqlTypes.NpgsqlPoint(x: 0.21038032177230748d, y: 0.8669360752896064d), new NpgsqlTypes.NpgsqlPoint(x: 0.5382994349370088d, y: 0.04765268116491295d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.916538321958941d, y: 0.3195005009425669d), new NpgsqlTypes.NpgsqlPoint(x: 0.2194213282150007d, y: 0.6929254261369782d), new NpgsqlTypes.NpgsqlPoint(x: 0.4791461069709816d, y: 0.05245845880723832d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26583884550578385d, y: 0.749914868698491d), new NpgsqlTypes.NpgsqlPoint(x: 0.09350509111952954d, y: 0.8157786242417585d), new NpgsqlTypes.NpgsqlPoint(x: 0.7469087496066465d, y: 0.3506603362952372d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6678485461885018d, y: 0.1285034094322549d), new NpgsqlTypes.NpgsqlPoint(x: 0.497277522037179d, y: 0.07408735631723895d), new NpgsqlTypes.NpgsqlPoint(x: 0.5722475122584096d, y: 0.7224504329644734d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7263867793618607d, y: 0.6930498712628584d), new NpgsqlTypes.NpgsqlPoint(x: 0.41928903009435303d, y: 0.708578711787119d), new NpgsqlTypes.NpgsqlPoint(x: 0.2033463251377723d, y: 0.18481758146889715d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6255131166721631d, y: 0.12855240136692514d), new NpgsqlTypes.NpgsqlPoint(x: 0.043948958256762705d, y: 0.6741840324132642d), new NpgsqlTypes.NpgsqlPoint(x: 0.9124503975966552d, y: 0.12692913988851573d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38817548260358903d, y: 0.25784251444402684d), new NpgsqlTypes.NpgsqlPoint(x: 0.07449938991561267d, y: 0.4333118339551928d), new NpgsqlTypes.NpgsqlPoint(x: 0.881256785629499d, y: 0.9301008207622802d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30876277664314944d, y: 0.5734471657274692d), new NpgsqlTypes.NpgsqlPoint(x: 0.42582720925111306d, y: 0.5034460457193395d), new NpgsqlTypes.NpgsqlPoint(x: 0.43575640641799485d, y: 0.18177847940530012d)), }, }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd3e1mi(
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd3e1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
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

                changedRows =  ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd3e1mi_id
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd3e1mi_id", 
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
                changedRows =  ((INpgsqlPathMArraypathMMArrayD3)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathMArraypathMMArrayD3)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd3e1mi_id
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
    npgsqlpathpathmmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
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
                NpgsqlTypes.NpgsqlPath[,,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD3)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28143146607435854d, y: 0.010756047277640457d), new NpgsqlTypes.NpgsqlPoint(x: 0.5002221958340397d, y: 0.6231930927387598d), new NpgsqlTypes.NpgsqlPoint(x: 0.34929600721043175d, y: 0.20437994203828413d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42170264814464675d, y: 0.9518733192976732d), new NpgsqlTypes.NpgsqlPoint(x: 0.05041688098945929d, y: 0.31818083184322077d), new NpgsqlTypes.NpgsqlPoint(x: 0.775296098700866d, y: 0.3587017358254152d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3438869883133021d, y: 0.4662214009449688d), new NpgsqlTypes.NpgsqlPoint(x: 0.6681039766144102d, y: 0.23326991234897076d), new NpgsqlTypes.NpgsqlPoint(x: 0.7549554575307524d, y: 0.6333336589398124d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06678380584234522d, y: 0.021354360260871008d), new NpgsqlTypes.NpgsqlPoint(x: 0.6100598334069836d, y: 0.7022993546010816d), new NpgsqlTypes.NpgsqlPoint(x: 0.48696946927412144d, y: 0.5056841792342321d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3284888372340903d, y: 0.06432298886836096d), new NpgsqlTypes.NpgsqlPoint(x: 0.4397770474753383d, y: 0.24915140194265673d), new NpgsqlTypes.NpgsqlPoint(x: 0.8333206281201082d, y: 0.9059130703384126d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33173916559488403d, y: 0.6088425546272261d), new NpgsqlTypes.NpgsqlPoint(x: 0.20679437013516433d, y: 0.5283215478747202d), new NpgsqlTypes.NpgsqlPoint(x: 0.35867177311161036d, y: 0.512959952373532d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4432556875769197d, y: 0.4607787038464637d), new NpgsqlTypes.NpgsqlPoint(x: 0.7590485076824235d, y: 0.9772435731493212d), new NpgsqlTypes.NpgsqlPoint(x: 0.7297160661470978d, y: 0.23692592731845508d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7627875217214002d, y: 0.5684286937879964d), new NpgsqlTypes.NpgsqlPoint(x: 0.32510132224579624d, y: 0.25940979063657543d), new NpgsqlTypes.NpgsqlPoint(x: 0.782457500107036d, y: 0.8068350307827655d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2259499839992415d, y: 0.045462224828744624d), new NpgsqlTypes.NpgsqlPoint(x: 0.8509830737067559d, y: 0.8886814783327027d), new NpgsqlTypes.NpgsqlPoint(x: 0.5986964081114592d, y: 0.8524241248443032d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41808039376930595d, y: 0.6023941646545327d), new NpgsqlTypes.NpgsqlPoint(x: 0.29492173288207435d, y: 0.9674910268974084d), new NpgsqlTypes.NpgsqlPoint(x: 0.17881428086286877d, y: 0.7695679140019842d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19382124775683784d, y: 0.4916156350877827d), new NpgsqlTypes.NpgsqlPoint(x: 0.19133735310476252d, y: 0.41503689771822017d), new NpgsqlTypes.NpgsqlPoint(x: 0.43655216753002213d, y: 0.35706745912045745d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24568360094422126d, y: 0.2897211415697307d), new NpgsqlTypes.NpgsqlPoint(x: 0.12376374878956142d, y: 0.6270472560387577d), new NpgsqlTypes.NpgsqlPoint(x: 0.2522933373749434d, y: 0.8042539651129716d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24519797234141305d, y: 0.4053875347199515d), new NpgsqlTypes.NpgsqlPoint(x: 0.6403399987089546d, y: 0.6343592761050791d), new NpgsqlTypes.NpgsqlPoint(x: 0.8357307637189205d, y: 0.7357416361473756d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2724547283956449d, y: 0.9997944879966704d), new NpgsqlTypes.NpgsqlPoint(x: 0.01103884263795396d, y: 0.08142985267993408d), new NpgsqlTypes.NpgsqlPoint(x: 0.36051018431596793d, y: 0.19821194104846662d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33535082540066974d, y: 0.8271851200217377d), new NpgsqlTypes.NpgsqlPoint(x: 0.5515484759447576d, y: 0.48355672081560375d), new NpgsqlTypes.NpgsqlPoint(x: 0.8810658993559776d, y: 0.974228524971523d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6869122489693817d, y: 0.9584820107367106d), new NpgsqlTypes.NpgsqlPoint(x: 0.8886294404492959d, y: 0.01128744319646413d), new NpgsqlTypes.NpgsqlPoint(x: 0.9191913489316623d, y: 0.5503573393170176d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24370724486380457d, y: 0.5964863463181086d), new NpgsqlTypes.NpgsqlPoint(x: 0.08269862770958702d, y: 0.19488507975863034d), new NpgsqlTypes.NpgsqlPoint(x: 0.19420580491183848d, y: 0.7238839624217775d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2725237892970298d, y: 0.30794057529649244d), new NpgsqlTypes.NpgsqlPoint(x: 0.405392498705788d, y: 0.11038489531216411d), new NpgsqlTypes.NpgsqlPoint(x: 0.17603248693406048d, y: 0.9507769914573396d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024452459199897025d, y: 0.658245181998308d), new NpgsqlTypes.NpgsqlPoint(x: 0.5960118994295807d, y: 0.28888223407101143d), new NpgsqlTypes.NpgsqlPoint(x: 0.06679125417850129d, y: 0.5647520884588683d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3792364941912606d, y: 0.6671892205820111d), new NpgsqlTypes.NpgsqlPoint(x: 0.8180922388707608d, y: 0.03653400697349929d), new NpgsqlTypes.NpgsqlPoint(x: 0.3595585584928077d, y: 0.3900448839073839d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9729657004743565d, y: 0.3089677188256267d), new NpgsqlTypes.NpgsqlPoint(x: 0.7233258471747523d, y: 0.19815747777024684d), new NpgsqlTypes.NpgsqlPoint(x: 0.6607332958984167d, y: 0.5040332734046108d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8436189183966517d, y: 0.48960814443059586d), new NpgsqlTypes.NpgsqlPoint(x: 0.14560173061586235d, y: 0.6443318376394966d), new NpgsqlTypes.NpgsqlPoint(x: 0.5484113084809691d, y: 0.0006380157769507733d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.785732528875523d, y: 0.9705236397161134d), new NpgsqlTypes.NpgsqlPoint(x: 0.12385463467448798d, y: 0.5583362775398131d), new NpgsqlTypes.NpgsqlPoint(x: 0.788629785338016d, y: 0.6884343511215546d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44801864370926614d, y: 0.9711761740737156d), new NpgsqlTypes.NpgsqlPoint(x: 0.9919279317957006d, y: 0.2962404611310241d), new NpgsqlTypes.NpgsqlPoint(x: 0.34016209127554464d, y: 0.8205334484591218d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6876594113201503d, y: 0.472849168537105d), new NpgsqlTypes.NpgsqlPoint(x: 0.4333611485264558d, y: 0.5266612604098436d), new NpgsqlTypes.NpgsqlPoint(x: 0.04440267200814563d, y: 0.6359653389957493d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7945972025704022d, y: 0.17337441684349175d), new NpgsqlTypes.NpgsqlPoint(x: 0.498853435208763d, y: 0.5052396616696269d), new NpgsqlTypes.NpgsqlPoint(x: 0.8790275290359856d, y: 0.1373128481167769d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8641161345143326d, y: 0.8952717481062611d), new NpgsqlTypes.NpgsqlPoint(x: 0.48163744638881756d, y: 0.6306896055407653d), new NpgsqlTypes.NpgsqlPoint(x: 0.3500911534120752d, y: 0.24965209542208022d)), }, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD3)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPath[,,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD3)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3621527578414774d, y: 0.6700465348177397d), new NpgsqlTypes.NpgsqlPoint(x: 0.5539180520875117d, y: 0.007564278892389531d), new NpgsqlTypes.NpgsqlPoint(x: 0.4679523994592455d, y: 0.23362481486112519d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.550966948535055d, y: 0.11809496618691784d), new NpgsqlTypes.NpgsqlPoint(x: 0.26161462778301825d, y: 0.09885255422240813d), new NpgsqlTypes.NpgsqlPoint(x: 0.6389948037384271d, y: 0.1442891333432964d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9208568740890463d, y: 0.6460543892198596d), new NpgsqlTypes.NpgsqlPoint(x: 0.24505576166701404d, y: 0.9364649626038566d), new NpgsqlTypes.NpgsqlPoint(x: 0.5484601089940572d, y: 0.9438388588069144d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9809108080034521d, y: 0.501823770498509d), new NpgsqlTypes.NpgsqlPoint(x: 0.0013616521159991457d, y: 0.8925655267243119d), new NpgsqlTypes.NpgsqlPoint(x: 0.2241802353565342d, y: 0.1814889865664171d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6931467279707214d, y: 0.570948831130915d), new NpgsqlTypes.NpgsqlPoint(x: 0.8241231486322572d, y: 0.7224921841028585d), new NpgsqlTypes.NpgsqlPoint(x: 0.5173499760736233d, y: 0.027207825782829764d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27420138461703547d, y: 0.09261833534277875d), new NpgsqlTypes.NpgsqlPoint(x: 0.3635811922485963d, y: 0.6293323465372196d), new NpgsqlTypes.NpgsqlPoint(x: 0.18566088407217152d, y: 0.4089248892196845d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9791638506748948d, y: 0.5815458405051117d), new NpgsqlTypes.NpgsqlPoint(x: 0.007410204678079291d, y: 0.6436536445732475d), new NpgsqlTypes.NpgsqlPoint(x: 0.7562119371815833d, y: 0.13861211133867235d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39760131460713877d, y: 0.8951236678318213d), new NpgsqlTypes.NpgsqlPoint(x: 0.24366654398396226d, y: 0.6222803261527301d), new NpgsqlTypes.NpgsqlPoint(x: 0.6761887007174576d, y: 0.8179924273715304d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8866583891820486d, y: 0.3939836731825883d), new NpgsqlTypes.NpgsqlPoint(x: 0.15140841550721407d, y: 0.7051532473885775d), new NpgsqlTypes.NpgsqlPoint(x: 0.7473975721507063d, y: 0.7507419600232498d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7578952972760509d, y: 0.7524087767490396d), new NpgsqlTypes.NpgsqlPoint(x: 0.8945273421638016d, y: 0.6598821442506053d), new NpgsqlTypes.NpgsqlPoint(x: 0.43435917974039284d, y: 0.21312082652388253d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6609609007793532d, y: 0.39253245434343054d), new NpgsqlTypes.NpgsqlPoint(x: 0.37832668046905893d, y: 0.0732127012720305d), new NpgsqlTypes.NpgsqlPoint(x: 0.06574583542418522d, y: 0.9740793714971675d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25318187585834984d, y: 0.5104978029330274d), new NpgsqlTypes.NpgsqlPoint(x: 0.1604252363731664d, y: 0.4722252259907418d), new NpgsqlTypes.NpgsqlPoint(x: 0.46110121391220615d, y: 0.4044424998271652d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5451385806765613d, y: 0.20870246744038967d), new NpgsqlTypes.NpgsqlPoint(x: 0.6004496409551663d, y: 0.33706248351994184d), new NpgsqlTypes.NpgsqlPoint(x: 0.26480477476320086d, y: 0.29260953329128636d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06935520705041187d, y: 0.9866508254322538d), new NpgsqlTypes.NpgsqlPoint(x: 0.43173426259863024d, y: 0.14240851914109554d), new NpgsqlTypes.NpgsqlPoint(x: 0.05467182863613396d, y: 0.4308699280632151d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4739667321988488d, y: 0.7287783807575148d), new NpgsqlTypes.NpgsqlPoint(x: 0.6607434785910855d, y: 0.0035256552132942875d), new NpgsqlTypes.NpgsqlPoint(x: 0.0879388571106573d, y: 0.46808988750671543d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04328870797159423d, y: 0.4469944837683618d), new NpgsqlTypes.NpgsqlPoint(x: 0.8345904376308408d, y: 0.1057434655794296d), new NpgsqlTypes.NpgsqlPoint(x: 0.31961951998652915d, y: 0.0009540884028409469d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4549945988174502d, y: 0.8114487092484851d), new NpgsqlTypes.NpgsqlPoint(x: 0.22390575093129916d, y: 0.7410059868475669d), new NpgsqlTypes.NpgsqlPoint(x: 0.9586407376093218d, y: 0.9816353868965522d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.754284158772406d, y: 0.8545207219406141d), new NpgsqlTypes.NpgsqlPoint(x: 0.9710518683865016d, y: 0.588351048131504d), new NpgsqlTypes.NpgsqlPoint(x: 0.13816636205162813d, y: 0.678769886883405d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42121638871417233d, y: 0.012245971643451092d), new NpgsqlTypes.NpgsqlPoint(x: 0.18470064843860512d, y: 0.6719436829600615d), new NpgsqlTypes.NpgsqlPoint(x: 0.7702398907485807d, y: 0.2554999345168595d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22128698802411007d, y: 0.6531111502766881d), new NpgsqlTypes.NpgsqlPoint(x: 0.9744553624742407d, y: 0.07946377334727206d), new NpgsqlTypes.NpgsqlPoint(x: 0.8457410728902063d, y: 0.12924277000292517d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7822286160637627d, y: 0.49991429923047515d), new NpgsqlTypes.NpgsqlPoint(x: 0.46356487772446897d, y: 0.8062881507630052d), new NpgsqlTypes.NpgsqlPoint(x: 0.04241521398924142d, y: 0.6461887229381195d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8966590919572702d, y: 0.9834126983923546d), new NpgsqlTypes.NpgsqlPoint(x: 0.6358726637368026d, y: 0.7343095711892268d), new NpgsqlTypes.NpgsqlPoint(x: 0.8721193715760117d, y: 0.07017333047897756d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.996727202066098d, y: 0.3934617921295426d), new NpgsqlTypes.NpgsqlPoint(x: 0.4553763117510172d, y: 0.6531443106979117d), new NpgsqlTypes.NpgsqlPoint(x: 0.1623122571841883d, y: 0.33994566823459227d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7060478290834118d, y: 0.7857474902298692d), new NpgsqlTypes.NpgsqlPoint(x: 0.6428936278350482d, y: 0.6856421192272735d), new NpgsqlTypes.NpgsqlPoint(x: 0.9272487357328189d, y: 0.28378362758253584d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29717616118415513d, y: 0.91103016093123d), new NpgsqlTypes.NpgsqlPoint(x: 0.8888046463065735d, y: 0.2739955458604688d), new NpgsqlTypes.NpgsqlPoint(x: 0.17480311344462296d, y: 0.6805710227205855d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22854804938709705d, y: 0.3539823775713572d), new NpgsqlTypes.NpgsqlPoint(x: 0.07506275964543807d, y: 0.2988574529836676d), new NpgsqlTypes.NpgsqlPoint(x: 0.27199007192032876d, y: 0.12408124492930195d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3941780049988921d, y: 0.4858631998123265d), new NpgsqlTypes.NpgsqlPoint(x: 0.08952127761364281d, y: 0.7596303192412892d), new NpgsqlTypes.NpgsqlPoint(x: 0.3043391926866932d, y: 0.6246034346002213d)), }, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD3)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd3e1mi_id
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
    npgsqlpathpathmmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd3e1mi_id", 
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
                NpgsqlTypes.NpgsqlPath[,,] nullable = null;
                nullable =  ((INpgsqlPathMArraypathMMArrayD3)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,,] { { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44169823820570076d, y: 0.05980789049672963d), new NpgsqlTypes.NpgsqlPoint(x: 0.516401045776469d, y: 0.1581819420293783d), new NpgsqlTypes.NpgsqlPoint(x: 0.5066364460223247d, y: 0.6393367587568785d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3431565051458494d, y: 0.47599719747121516d), new NpgsqlTypes.NpgsqlPoint(x: 0.31552551547430474d, y: 0.20550215183930953d), new NpgsqlTypes.NpgsqlPoint(x: 0.5136914403982789d, y: 0.22870566053264885d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.649410681184525d, y: 0.8759407463686075d), new NpgsqlTypes.NpgsqlPoint(x: 0.6880472188819448d, y: 0.037244867014821326d), new NpgsqlTypes.NpgsqlPoint(x: 0.8166458981367276d, y: 0.39757139467760927d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0916793117868151d, y: 0.2731887347579113d), new NpgsqlTypes.NpgsqlPoint(x: 0.20283879868845045d, y: 0.6495057578440196d), new NpgsqlTypes.NpgsqlPoint(x: 0.27135129875743d, y: 0.6396739751276075d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48385584294604234d, y: 0.43376997072910795d), new NpgsqlTypes.NpgsqlPoint(x: 0.39267886307968913d, y: 0.8155451655491394d), new NpgsqlTypes.NpgsqlPoint(x: 0.08799873959926918d, y: 0.921288679543806d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6843170032384582d, y: 0.1254499136783097d), new NpgsqlTypes.NpgsqlPoint(x: 0.17953037520020598d, y: 0.4076360031459171d), new NpgsqlTypes.NpgsqlPoint(x: 0.43265459910865944d, y: 0.12232969349371925d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15277032001609803d, y: 0.7450225369676965d), new NpgsqlTypes.NpgsqlPoint(x: 0.11650045257992003d, y: 0.2733622560011165d), new NpgsqlTypes.NpgsqlPoint(x: 0.21008299124118313d, y: 0.29600643295186524d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.903147439360496d, y: 0.5517164587933284d), new NpgsqlTypes.NpgsqlPoint(x: 0.2945157395381357d, y: 0.5604049792666097d), new NpgsqlTypes.NpgsqlPoint(x: 0.46108517348374156d, y: 0.5633560666733326d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11769027572725588d, y: 0.6119941774910684d), new NpgsqlTypes.NpgsqlPoint(x: 0.826088851417683d, y: 0.5644264177024126d), new NpgsqlTypes.NpgsqlPoint(x: 0.20262412506708327d, y: 0.9428519151337422d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8520794311277616d, y: 0.18899570495754425d), new NpgsqlTypes.NpgsqlPoint(x: 0.49438885499102114d, y: 0.5540375166901018d), new NpgsqlTypes.NpgsqlPoint(x: 0.5532529156046603d, y: 0.8273981769772711d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8475772033375825d, y: 0.7326722006319272d), new NpgsqlTypes.NpgsqlPoint(x: 0.6582858163492157d, y: 0.287582193325409d), new NpgsqlTypes.NpgsqlPoint(x: 0.17850134502364734d, y: 0.5261247320206628d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.446211942724962d, y: 0.0515822656968592d), new NpgsqlTypes.NpgsqlPoint(x: 0.13234744580274815d, y: 0.8775900565104662d), new NpgsqlTypes.NpgsqlPoint(x: 0.4739971901347413d, y: 0.8759504568110364d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2841094147833596d, y: 0.6911706692058508d), new NpgsqlTypes.NpgsqlPoint(x: 0.11574262284649472d, y: 0.9234914207580301d), new NpgsqlTypes.NpgsqlPoint(x: 0.48872990366802915d, y: 0.1643076312074756d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6890750047986974d, y: 0.42633382557084665d), new NpgsqlTypes.NpgsqlPoint(x: 0.3768966605692188d, y: 0.9054933375736824d), new NpgsqlTypes.NpgsqlPoint(x: 0.23233675384092223d, y: 0.9571922609919118d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08574558987657055d, y: 0.9323602624876968d), new NpgsqlTypes.NpgsqlPoint(x: 0.3489291634419993d, y: 0.5024247764951233d), new NpgsqlTypes.NpgsqlPoint(x: 0.24719834880972302d, y: 0.9120705357064175d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18142740608376584d, y: 0.6037744147191096d), new NpgsqlTypes.NpgsqlPoint(x: 0.5775215336361889d, y: 0.8455238053300198d), new NpgsqlTypes.NpgsqlPoint(x: 0.08491295585194503d, y: 0.6389089735292622d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4508298679218996d, y: 0.34431377991480794d), new NpgsqlTypes.NpgsqlPoint(x: 0.020912063830642813d, y: 0.4978001433394762d), new NpgsqlTypes.NpgsqlPoint(x: 0.6530858556464209d, y: 0.7057596206258303d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39564739837261964d, y: 0.17818309446238434d), new NpgsqlTypes.NpgsqlPoint(x: 0.20895170968358834d, y: 0.9320626769830482d), new NpgsqlTypes.NpgsqlPoint(x: 0.6604248620485315d, y: 0.36350357541455336d)), }, }, { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6615854378252646d, y: 0.9958323135256372d), new NpgsqlTypes.NpgsqlPoint(x: 0.783634380467075d, y: 0.703501726990607d), new NpgsqlTypes.NpgsqlPoint(x: 0.8802804430452748d, y: 0.7543548802844631d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9458877574183888d, y: 0.7988171347887939d), new NpgsqlTypes.NpgsqlPoint(x: 0.2104250520315959d, y: 0.7858254782268886d), new NpgsqlTypes.NpgsqlPoint(x: 0.04572977179363713d, y: 0.6718158037407465d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.543747604048682d, y: 0.2745715645119816d), new NpgsqlTypes.NpgsqlPoint(x: 0.6801420686921864d, y: 0.6856761389737606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5375507374330812d, y: 0.39098651052401956d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34519969628199954d, y: 0.8320134123267656d), new NpgsqlTypes.NpgsqlPoint(x: 0.4102978937418056d, y: 0.8903570383999195d), new NpgsqlTypes.NpgsqlPoint(x: 0.4081440520568228d, y: 0.3203616305491793d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6812818535782486d, y: 0.17677209232779123d), new NpgsqlTypes.NpgsqlPoint(x: 0.17329352950497712d, y: 0.2570504339960009d), new NpgsqlTypes.NpgsqlPoint(x: 0.023672510316804174d, y: 0.7773404135246004d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08192382851378888d, y: 0.7909091028296621d), new NpgsqlTypes.NpgsqlPoint(x: 0.750688012962843d, y: 0.4294821828109543d), new NpgsqlTypes.NpgsqlPoint(x: 0.11212493652101674d, y: 0.9861470721000797d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3708463731731806d, y: 0.4519941083803328d), new NpgsqlTypes.NpgsqlPoint(x: 0.1680836091331317d, y: 0.26599206694013067d), new NpgsqlTypes.NpgsqlPoint(x: 0.8724192024372095d, y: 0.5355842534467985d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8207479299253216d, y: 0.46082208579463346d), new NpgsqlTypes.NpgsqlPoint(x: 0.7546987538851605d, y: 0.9349774027937672d), new NpgsqlTypes.NpgsqlPoint(x: 0.06902534906415514d, y: 0.07291307644636658d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7406554034105044d, y: 0.06946503626481915d), new NpgsqlTypes.NpgsqlPoint(x: 0.7983828183746848d, y: 0.94751062013509d), new NpgsqlTypes.NpgsqlPoint(x: 0.8974844916666614d, y: 0.7009002321170537d)), }, }, }));
                nullable =  ((INpgsqlPathMArraypathMMArrayD3)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[,,] nullable = null;
                nullable = await ((INpgsqlPathMArraypathMMArrayD3)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathMArraypathMMArrayD3)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD3E1M> models = null;

                models =  ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD3E1M> models = null;

                models = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathMArraypathMMArrayD3)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD3E1M), typeof(FlatNpgsqlPathpathMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                await ((INpgsqlPathMArraypathMMArrayD3)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                ((INpgsqlPathMArraypathMMArrayD3)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathMArraypathMMArrayD3)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathMArraypathMMArrayD3)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd3e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd3e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD3)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD3)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD3E1M), typeof(FlatNpgsqlPathpathMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                await ((INpgsqlPathMArraypathMMArrayD3)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                ((INpgsqlPathMArraypathMMArrayD3)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathMArraypathMMArrayD3)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD3)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd3e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd3e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD3)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathMArraypathMMArrayD3)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD3E1M), typeof(FlatNpgsqlPathpathMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                await((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
FROM public.npgsqlpathpathmmarrayd3e1m m
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                await ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
FROM public.npgsqlpathpathmmarrayd3e1m m
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                await ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
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
FROM public.npgsqlpathpathmmarrayd3e1m m
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                 ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
FROM public.npgsqlpathpathmmarrayd3e1m m
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                 ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
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
FROM public.npgsqlpathpathmmarrayd3e1m m
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd3e1m m
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                await ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd3e1m m
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd3e1m m
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                 ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd3e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd3e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[21],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD3E1M), typeof(FlatNpgsqlPathpathMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                await((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd3e1m m
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                await ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 93, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd3e1m m
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                await ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 117, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd3e1m m
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                 ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 47, query1, 73, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd3e1m m
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                 ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatch(connection, 137, query1, 35, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd3e1m m
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 150, query1, 31, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[29],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd3e1m m
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                await ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 14, query1, 111, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd3e1m m
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatch(connection, 38, query1, 35, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(models[27],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd3e1m m
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
FROM public.npgsqlpathpathmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD3E1M>();
                 ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionDynQuerySelectModelBatch(connection, 47, query1, 80, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD3E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd3e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd3e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionSTSelectModelBatchAsync(connection, 104, 73))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[19],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD3)this).DbConnectionSTSelectModelBatch(connection, 41, 119))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPathpathMMArrayD3E1M.AssertModel(models[8],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathMArraypathMMArrayD3)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathMArraypathMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 91);
                var models = await ((INpgsqlPathMArraypathMMArrayD3)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[19], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[1],_testData[20], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[2],_testData[21], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[3],_testData[22], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[4],_testData[23], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[5],_testData[24], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[6],_testData[25], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[7],_testData[26], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[8],_testData[27], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[9],_testData[28], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[10],_testData[29], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[11],_testData[30], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[12],_testData[31], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[13],_testData[32], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[14],_testData[33], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathMArraypathMMArrayD3)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathMArraypathMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 80);
                var models =  ((INpgsqlPathMArraypathMMArrayD3)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[0],_testData[16], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[1],_testData[17], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[2],_testData[18], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[3],_testData[19], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[4],_testData[20], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[5],_testData[21], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[6],_testData[22], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[7],_testData[23], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[8],_testData[24], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[9],_testData[25], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[10],_testData[26], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[11],_testData[27], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[12],_testData[28], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[13],_testData[29], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[14],_testData[30], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[15],_testData[31], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[16],_testData[32], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[17],_testData[33], false);
                NpgsqlPathpathMMArrayD3E1M.AssertModel(models[18],_testData[34], false);
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
FROM public.binary_npgsqlpathpathmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD3E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD3E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD3)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD3)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD3E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD3)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD3)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD3E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD3)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD3)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD3E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD3)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD3)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd3e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD3E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD3E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD3)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD3)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD3E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD3)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD3)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD3E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD3)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD3)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD3E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD3)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD3)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd3e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathmmarrayd3e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathMMArrayD3E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3))]
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
FROM public.binary_npgsqlpathpathmmarrayd3e1m m
LEFT JOIN public.binary_npgsqlpathpathmmarrayd3e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd3e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD3E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD3)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD3)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD3E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD3E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD3)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD3)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD3E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd3e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathmmarrayd3e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models =  ((INpgsqlPathMArraypathMMArrayD3)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathMArraypathMMArrayD3)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD3E1MIWA), typeof(NpgsqlPathpathMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD3E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD3)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD3E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD3)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathMArraypathMMArrayD3)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd3e1mi
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
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD3)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd3e1mi
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
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD3E1MIWA), typeof(NpgsqlPathpathMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD3E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD3)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD3E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD3)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD3)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd3e1mi
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
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD3)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd3e1mi
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
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD3E1MI), typeof(NpgsqlPathpathMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathMMArrayD3E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD3E1MI>();
                await ((INpgsqlPathMArraypathMMArrayD3)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD3E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD3E1MI>();
                ((INpgsqlPathMArraypathMMArrayD3)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd3e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathMArraypathMMArrayD3)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD3)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD3E1MIWA), typeof(NpgsqlPathpathMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD3E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD3)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD3E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD3)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd3e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD3))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD3)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD3)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

