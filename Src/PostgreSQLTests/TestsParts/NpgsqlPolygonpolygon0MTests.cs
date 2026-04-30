

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
    internal partial interface INpgsqlPolygonSingleTypepolygon
    {
    }
    
    internal partial class NpgsqlPolygonSingleTypepolygon : INpgsqlPolygonSingleTypepolygon
    {


#region TestData

        private readonly NpgsqlPolygonpolygon0M[] _testData = new NpgsqlPolygonpolygon0M[]
        {
            new NpgsqlPolygonpolygon0M
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1488243502583555d, y: 0.7271294528720949d), new NpgsqlTypes.NpgsqlPoint(x: 0.3765235761303194d, y: 0.6786306184986963d), new NpgsqlTypes.NpgsqlPoint(x: 0.46778620505752677d, y: 0.773769604932416d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07857255802594076d, y: 0.07415470180369788d), new NpgsqlTypes.NpgsqlPoint(x: 0.17890447421698052d, y: 0.5289457180077679d), new NpgsqlTypes.NpgsqlPoint(x: 0.7713728902142188d, y: 0.5236255896849368d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20130995814924757d, y: 0.591729132933246d), new NpgsqlTypes.NpgsqlPoint(x: 0.29932046351579655d, y: 0.8293278627708518d), new NpgsqlTypes.NpgsqlPoint(x: 0.8309524084453725d, y: 0.6351892236217032d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7889309086623513d, y: 0.4012097327487286d), new NpgsqlTypes.NpgsqlPoint(x: 0.14266817577019775d, y: 0.4052636422841466d), new NpgsqlTypes.NpgsqlPoint(x: 0.620752887384355d, y: 0.13015735144488072d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3325716949058076d, y: 0.6296100111034869d), new NpgsqlTypes.NpgsqlPoint(x: 0.5799877909824307d, y: 0.24957466465496103d), new NpgsqlTypes.NpgsqlPoint(x: 0.9798921270876552d, y: 0.7122695752621824d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9794519977852651d, y: 0.16668107686837708d), new NpgsqlTypes.NpgsqlPoint(x: 0.40683086225758236d, y: 0.36967196814774106d), new NpgsqlTypes.NpgsqlPoint(x: 0.5506264575269065d, y: 0.7556565975736046d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9296059753633313d, y: 0.96183741535481d), new NpgsqlTypes.NpgsqlPoint(x: 0.8236470338091888d, y: 0.7345578175041028d), new NpgsqlTypes.NpgsqlPoint(x: 0.4553802152581252d, y: 0.6973951536447385d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9783194731074515d, y: 0.2760826261442999d), new NpgsqlTypes.NpgsqlPoint(x: 0.4178876897496613d, y: 0.07977577207840092d), new NpgsqlTypes.NpgsqlPoint(x: 0.535292233756321d, y: 0.10022964303078119d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43984459244783314d, y: 0.9432521299115716d), new NpgsqlTypes.NpgsqlPoint(x: 0.26346979436605933d, y: 0.8392274141511022d), new NpgsqlTypes.NpgsqlPoint(x: 0.7053377722046726d, y: 0.5673769762345832d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5415481260621727d, y: 0.5401623668592578d), new NpgsqlTypes.NpgsqlPoint(x: 0.5589530885475551d, y: 0.29633932626594006d), new NpgsqlTypes.NpgsqlPoint(x: 0.4983622735781581d, y: 0.46643487663449223d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14521712536079456d, y: 0.5657775536512011d), new NpgsqlTypes.NpgsqlPoint(x: 0.9222194569096281d, y: 0.34523143010557933d), new NpgsqlTypes.NpgsqlPoint(x: 0.6702318465439422d, y: 0.7096775750747193d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7109702295795192d, y: 0.4851204037530221d), new NpgsqlTypes.NpgsqlPoint(x: 0.07778634654453276d, y: 0.4607061399687876d), new NpgsqlTypes.NpgsqlPoint(x: 0.34034162690599756d, y: 0.6439545294244445d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14739380350357345d, y: 0.8318589825407592d), new NpgsqlTypes.NpgsqlPoint(x: 0.9864522709892708d, y: 0.18138165053951816d), new NpgsqlTypes.NpgsqlPoint(x: 0.301730568612644d, y: 0.26393840765627374d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.99338337826293d, y: 0.5395501732117145d), new NpgsqlTypes.NpgsqlPoint(x: 0.9540915965202826d, y: 0.06623581977769388d), new NpgsqlTypes.NpgsqlPoint(x: 0.18957148161931803d, y: 0.555527607930171d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6328362750141585d, y: 0.5401207891417602d), new NpgsqlTypes.NpgsqlPoint(x: 0.44581803280637367d, y: 0.40114896324936766d), new NpgsqlTypes.NpgsqlPoint(x: 0.44441775606652645d, y: 0.1654435972027839d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5374522405451017d, y: 0.21058711087414084d), new NpgsqlTypes.NpgsqlPoint(x: 0.04584678146019461d, y: 0.2470802732243662d), new NpgsqlTypes.NpgsqlPoint(x: 0.40185905048762327d, y: 0.9547013012258199d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2581114246007148d, y: 0.48890196809414277d), new NpgsqlTypes.NpgsqlPoint(x: 0.12969211458198326d, y: 0.460812005338071d), new NpgsqlTypes.NpgsqlPoint(x: 0.27730474866604427d, y: 0.7416688400066335d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9992363380877989d, y: 0.43446472985138185d), new NpgsqlTypes.NpgsqlPoint(x: 0.4970670717844309d, y: 0.5069089812034174d), new NpgsqlTypes.NpgsqlPoint(x: 0.26484314779334406d, y: 0.5964915400807773d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5605959954779759d, y: 0.14058722246517263d), new NpgsqlTypes.NpgsqlPoint(x: 0.5019816575556576d, y: 0.37681382814787023d), new NpgsqlTypes.NpgsqlPoint(x: 0.016867343949891866d, y: 0.8240836260436863d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31363157841725464d, y: 0.2943726795391888d), new NpgsqlTypes.NpgsqlPoint(x: 0.06130344059326476d, y: 0.6139761778224475d), new NpgsqlTypes.NpgsqlPoint(x: 0.49454950924813224d, y: 0.34129250971816705d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2715430250557007d, y: 0.11940948084130576d), new NpgsqlTypes.NpgsqlPoint(x: 0.5934766644589193d, y: 0.9833168492205054d), new NpgsqlTypes.NpgsqlPoint(x: 0.601998327257617d, y: 0.39101491111113784d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11537519075024616d, y: 0.2819739154930022d), new NpgsqlTypes.NpgsqlPoint(x: 0.8528822990684319d, y: 0.7487487355909076d), new NpgsqlTypes.NpgsqlPoint(x: 0.271716913937056d, y: 0.9146398906414426d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7201296626985215d, y: 0.8265567995025946d), new NpgsqlTypes.NpgsqlPoint(x: 0.83089888570055d, y: 0.7774972940661306d), new NpgsqlTypes.NpgsqlPoint(x: 0.8564540779705255d, y: 0.7836869154477304d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.028057372311227402d, y: 0.47680722730401326d), new NpgsqlTypes.NpgsqlPoint(x: 0.6898259752097798d, y: 0.7159576932063679d), new NpgsqlTypes.NpgsqlPoint(x: 0.7764231211069257d, y: 0.4573435436704203d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9736236259205799d, y: 0.7985900545549892d), new NpgsqlTypes.NpgsqlPoint(x: 0.7668579916856233d, y: 0.5084748984498191d), new NpgsqlTypes.NpgsqlPoint(x: 0.9259404217478665d, y: 0.6421151249251728d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8930020454922659d, y: 0.0003585434412747279d), new NpgsqlTypes.NpgsqlPoint(x: 0.9922392892981555d, y: 0.4242704858708112d), new NpgsqlTypes.NpgsqlPoint(x: 0.2948319121537959d, y: 0.16433133839753422d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6749546687529968d, y: 0.7521807108655509d), new NpgsqlTypes.NpgsqlPoint(x: 0.45007938533562d, y: 0.7143314317128444d), new NpgsqlTypes.NpgsqlPoint(x: 0.46662146691721884d, y: 0.20390652469453663d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3880089898936686d, y: 0.8499907237391864d), new NpgsqlTypes.NpgsqlPoint(x: 0.33795762337776136d, y: 0.20345695178309386d), new NpgsqlTypes.NpgsqlPoint(x: 0.8467043737663393d, y: 0.06642393124557022d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8020295851871857d, y: 0.08972577921568425d), new NpgsqlTypes.NpgsqlPoint(x: 0.5338090299855354d, y: 0.346224974268283d), new NpgsqlTypes.NpgsqlPoint(x: 0.7159234190418664d, y: 0.7202466203070971d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.202746634092842d, y: 0.9114442205770565d), new NpgsqlTypes.NpgsqlPoint(x: 0.18478427200766312d, y: 0.16532950774798683d), new NpgsqlTypes.NpgsqlPoint(x: 0.06751671302358486d, y: 0.1388144092120046d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5980117106544915d, y: 0.2520660511213729d), new NpgsqlTypes.NpgsqlPoint(x: 0.08293681995690882d, y: 0.41712404721292606d), new NpgsqlTypes.NpgsqlPoint(x: 0.42708679750221146d, y: 0.3297026868441354d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02240871132290856d, y: 0.3423262869076127d), new NpgsqlTypes.NpgsqlPoint(x: 0.6983860181745823d, y: 0.1237660014261559d), new NpgsqlTypes.NpgsqlPoint(x: 0.4946156417356954d, y: 0.6689223683816123d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3261142076508827d, y: 0.10151357901453195d), new NpgsqlTypes.NpgsqlPoint(x: 0.2185546794023635d, y: 0.9281189899039812d), new NpgsqlTypes.NpgsqlPoint(x: 0.23637100943010492d, y: 0.6889371209390456d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4216590867724126d, y: 0.9339845538230768d), new NpgsqlTypes.NpgsqlPoint(x: 0.70871719221046d, y: 0.4446040582483095d), new NpgsqlTypes.NpgsqlPoint(x: 0.5383324161957443d, y: 0.9305107039940933d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.93600167399644d, y: 0.9575517599907857d), new NpgsqlTypes.NpgsqlPoint(x: 0.0873939064473932d, y: 0.026037033864447445d), new NpgsqlTypes.NpgsqlPoint(x: 0.7042189910467427d, y: 0.5753845717913167d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7636721888669893d, y: 0.22598174455171804d), new NpgsqlTypes.NpgsqlPoint(x: 0.5933513529376561d, y: 0.3006065485297398d), new NpgsqlTypes.NpgsqlPoint(x: 0.17005839826726354d, y: 0.968143989998302d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9556860172135984d, y: 0.8764902119459627d), new NpgsqlTypes.NpgsqlPoint(x: 0.027697570774365965d, y: 0.8680495023717647d), new NpgsqlTypes.NpgsqlPoint(x: 0.8936853074687251d, y: 0.7016263121406078d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5361896737376451d, y: 0.8213532353965384d), new NpgsqlTypes.NpgsqlPoint(x: 0.4908410696986888d, y: 0.9484789270488914d), new NpgsqlTypes.NpgsqlPoint(x: 0.8671645898984867d, y: 0.25901314331521996d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9121022545129751d, y: 0.9430755526380806d), new NpgsqlTypes.NpgsqlPoint(x: 0.2669346014013614d, y: 0.6427789005115873d), new NpgsqlTypes.NpgsqlPoint(x: 0.526347440089014d, y: 0.7193415786954607d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42306556492260583d, y: 0.8056707278717659d), new NpgsqlTypes.NpgsqlPoint(x: 0.5255745284149311d, y: 0.7969955540458713d), new NpgsqlTypes.NpgsqlPoint(x: 0.9040681296004918d, y: 0.19698054590001368d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8080451096127217d, y: 0.6606005678566904d), new NpgsqlTypes.NpgsqlPoint(x: 0.5236432263325083d, y: 0.14946655267536602d), new NpgsqlTypes.NpgsqlPoint(x: 0.48554055256218553d, y: 0.5782223551930122d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.056061100831860666d, y: 0.8939881533062202d), new NpgsqlTypes.NpgsqlPoint(x: 0.9199565633551177d, y: 0.7770432203454651d), new NpgsqlTypes.NpgsqlPoint(x: 0.8863996635496534d, y: 0.5928373175266413d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7738462949257809d, y: 0.24530928553493814d), new NpgsqlTypes.NpgsqlPoint(x: 0.8669380255433166d, y: 0.1621724900200887d), new NpgsqlTypes.NpgsqlPoint(x: 0.39147752837796d, y: 0.6166279541358805d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6229009779758907d, y: 0.8387208273690995d), new NpgsqlTypes.NpgsqlPoint(x: 0.7148620487003596d, y: 0.658224759232204d), new NpgsqlTypes.NpgsqlPoint(x: 0.9261808446299524d, y: 0.5772310678939709d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24027609654668802d, y: 0.05673614002140792d), new NpgsqlTypes.NpgsqlPoint(x: 0.6941539293547808d, y: 0.20504203931878062d), new NpgsqlTypes.NpgsqlPoint(x: 0.1784292794943444d, y: 0.42106865571344354d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.962455946174163d, y: 0.19207320208357925d), new NpgsqlTypes.NpgsqlPoint(x: 0.11939573435310025d, y: 0.4155332590488523d), new NpgsqlTypes.NpgsqlPoint(x: 0.9594343923479488d, y: 0.025513757706476348d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8481489968090576d, y: 0.028555122100105357d), new NpgsqlTypes.NpgsqlPoint(x: 0.7748840570596157d, y: 0.745497904556641d), new NpgsqlTypes.NpgsqlPoint(x: 0.773015207261952d, y: 0.6958888633209334d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.722437603074407d, y: 0.034340908955920124d), new NpgsqlTypes.NpgsqlPoint(x: 0.969519292975657d, y: 0.5597403105210145d), new NpgsqlTypes.NpgsqlPoint(x: 0.6943533414122035d, y: 0.7490761535505974d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8964987697540544d, y: 0.6649408501196306d), new NpgsqlTypes.NpgsqlPoint(x: 0.735938264003844d, y: 0.9714230440981535d), new NpgsqlTypes.NpgsqlPoint(x: 0.007069450022561097d, y: 0.18138801781135494d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8391066665905705d, y: 0.7457786510814929d), new NpgsqlTypes.NpgsqlPoint(x: 0.19100678764038037d, y: 0.8682832479002052d), new NpgsqlTypes.NpgsqlPoint(x: 0.8629304226537585d, y: 0.968163795840826d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2346146960459582d, y: 0.8964834388721623d), new NpgsqlTypes.NpgsqlPoint(x: 0.00022364107447414572d, y: 0.21468678410898534d), new NpgsqlTypes.NpgsqlPoint(x: 0.7245471471191279d, y: 0.6725238837248356d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2958969985025721d, y: 0.960207073076677d), new NpgsqlTypes.NpgsqlPoint(x: 0.8035413612224619d, y: 0.25712030018459964d), new NpgsqlTypes.NpgsqlPoint(x: 0.09088600626941667d, y: 0.22991725641765715d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8649661860198526d, y: 0.4802376528281568d), new NpgsqlTypes.NpgsqlPoint(x: 0.4142623054592728d, y: 0.11909102126935567d), new NpgsqlTypes.NpgsqlPoint(x: 0.2360356040168592d, y: 0.07228742876023664d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.276096284380138d, y: 0.35802502215110066d), new NpgsqlTypes.NpgsqlPoint(x: 0.15722481191731874d, y: 0.7356391019208057d), new NpgsqlTypes.NpgsqlPoint(x: 0.31103555063536303d, y: 0.9241887088989437d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3383718622706071d, y: 0.21220180873951455d), new NpgsqlTypes.NpgsqlPoint(x: 0.909645963385416d, y: 0.5709628088573443d), new NpgsqlTypes.NpgsqlPoint(x: 0.08612656574995314d, y: 0.6933610995932544d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5178653444427099d, y: 0.6882156128579199d), new NpgsqlTypes.NpgsqlPoint(x: 0.26469230430455337d, y: 0.7661835331628609d), new NpgsqlTypes.NpgsqlPoint(x: 0.5822776303004955d, y: 0.6943241980576665d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8411347306152247d, y: 0.12856256152562107d), new NpgsqlTypes.NpgsqlPoint(x: 0.13016422201830002d, y: 0.4795259786470778d), new NpgsqlTypes.NpgsqlPoint(x: 0.22648653912255035d, y: 0.8998560744063921d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32992977546394764d, y: 0.24722704752318325d), new NpgsqlTypes.NpgsqlPoint(x: 0.5964285356782918d, y: 0.8448207214397373d), new NpgsqlTypes.NpgsqlPoint(x: 0.1220290345768581d, y: 0.6901977522703215d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8925294272788517d, y: 0.29671924400406724d), new NpgsqlTypes.NpgsqlPoint(x: 0.8189615568117627d, y: 0.5434458177841369d), new NpgsqlTypes.NpgsqlPoint(x: 0.9258705927546786d, y: 0.7344443692043863d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2588321732854407d, y: 0.635719272714895d), new NpgsqlTypes.NpgsqlPoint(x: 0.44755997834883754d, y: 0.2940735550020198d), new NpgsqlTypes.NpgsqlPoint(x: 0.4428583394335387d, y: 0.3018340698444123d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08881600828619152d, y: 0.8147400874486564d), new NpgsqlTypes.NpgsqlPoint(x: 0.32889827664109095d, y: 0.1430091242030218d), new NpgsqlTypes.NpgsqlPoint(x: 0.07143528834137747d, y: 0.9014579723771868d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7987326891429253d, y: 0.48145195908465976d), new NpgsqlTypes.NpgsqlPoint(x: 0.8467779268813068d, y: 0.28087015561970474d), new NpgsqlTypes.NpgsqlPoint(x: 0.1369713132491256d, y: 0.8032211291353176d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7612895943378227d, y: 0.5739059019774272d), new NpgsqlTypes.NpgsqlPoint(x: 0.5759766126035636d, y: 0.1498216014885836d), new NpgsqlTypes.NpgsqlPoint(x: 0.13350724511249135d, y: 0.6171589901704204d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29579676546913614d, y: 0.8208350883682758d), new NpgsqlTypes.NpgsqlPoint(x: 0.468351234796056d, y: 0.4780246377488737d), new NpgsqlTypes.NpgsqlPoint(x: 0.043034931758850425d, y: 0.9260637930727454d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.893370955940728d, y: 0.03980662024429771d), new NpgsqlTypes.NpgsqlPoint(x: 0.8369856793863701d, y: 0.9564134346839994d), new NpgsqlTypes.NpgsqlPoint(x: 0.8023999789628827d, y: 0.64630847168661d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7108241650521876d, y: 0.1700314828790792d), new NpgsqlTypes.NpgsqlPoint(x: 0.5671606889504036d, y: 0.00798603406140852d), new NpgsqlTypes.NpgsqlPoint(x: 0.032127854705672365d, y: 0.04910592723559626d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42610496043985824d, y: 0.8270246532480358d), new NpgsqlTypes.NpgsqlPoint(x: 0.664165957815484d, y: 0.759589386561182d), new NpgsqlTypes.NpgsqlPoint(x: 0.32009813610285154d, y: 0.22502648391543945d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14364248755606135d, y: 0.8989869315174929d), new NpgsqlTypes.NpgsqlPoint(x: 0.9592678924815057d, y: 0.11797784833486458d), new NpgsqlTypes.NpgsqlPoint(x: 0.4342280775127454d, y: 0.6045814184631229d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45999456632994773d, y: 0.029218868303003465d), new NpgsqlTypes.NpgsqlPoint(x: 0.40103309238518015d, y: 0.4545324863247947d), new NpgsqlTypes.NpgsqlPoint(x: 0.4553383587354727d, y: 0.5788101692159944d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6295729121761624d, y: 0.5252200458421868d), new NpgsqlTypes.NpgsqlPoint(x: 0.4356902856022873d, y: 0.9621631530774807d), new NpgsqlTypes.NpgsqlPoint(x: 0.7525114546214272d, y: 0.21783965616012413d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.017019185081928456d, y: 0.8707663734570097d), new NpgsqlTypes.NpgsqlPoint(x: 0.6846793325884912d, y: 0.005729528428238817d), new NpgsqlTypes.NpgsqlPoint(x: 0.1895737966878972d, y: 0.030432572474420883d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 152,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4165130599736051d, y: 0.7723018929107274d), new NpgsqlTypes.NpgsqlPoint(x: 0.01526143995814111d, y: 0.3425098867353926d), new NpgsqlTypes.NpgsqlPoint(x: 0.6494610570680636d, y: 0.1845391481926838d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6928241521884663d, y: 0.8420703358240309d), new NpgsqlTypes.NpgsqlPoint(x: 0.8185033461189962d, y: 0.9903457120329426d), new NpgsqlTypes.NpgsqlPoint(x: 0.3280965245294679d, y: 0.634591991111133d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 157,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12788800217486662d, y: 0.11022960889558431d), new NpgsqlTypes.NpgsqlPoint(x: 0.8797993457323025d, y: 0.6167986719174645d), new NpgsqlTypes.NpgsqlPoint(x: 0.9770377868391699d, y: 0.5770748107436597d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8817709212678135d, y: 0.1221861724575346d), new NpgsqlTypes.NpgsqlPoint(x: 0.8251426613492906d, y: 0.45070871014698155d), new NpgsqlTypes.NpgsqlPoint(x: 0.6016177974759489d, y: 0.908905347151417d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8406940366122336d, y: 0.7230394756702488d), new NpgsqlTypes.NpgsqlPoint(x: 0.4041459318219618d, y: 0.6715257358488967d), new NpgsqlTypes.NpgsqlPoint(x: 0.21843737625545923d, y: 0.23701541101803203d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 162,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6464420583601787d, y: 0.578766616826311d), new NpgsqlTypes.NpgsqlPoint(x: 0.13494418441267375d, y: 0.3500602013306582d), new NpgsqlTypes.NpgsqlPoint(x: 0.6663486537561685d, y: 0.6209861471705669d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20693995383250696d, y: 0.6447666617266381d), new NpgsqlTypes.NpgsqlPoint(x: 0.193679495541633d, y: 0.7948725718204089d), new NpgsqlTypes.NpgsqlPoint(x: 0.9249610274897021d, y: 0.0036931366895293083d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 170,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7764785941520207d, y: 0.6322583134697929d), new NpgsqlTypes.NpgsqlPoint(x: 0.15507966054890432d, y: 0.5458321236566682d), new NpgsqlTypes.NpgsqlPoint(x: 0.5559806338461516d, y: 0.291125571546207d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7846503589745569d, y: 0.131738612878872d), new NpgsqlTypes.NpgsqlPoint(x: 0.8911645668509655d, y: 0.760125984064843d), new NpgsqlTypes.NpgsqlPoint(x: 0.06270801941569071d, y: 0.9253525418764176d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4295284151428086d, y: 0.030492352355105057d), new NpgsqlTypes.NpgsqlPoint(x: 0.30293825620202475d, y: 0.44867397415146315d), new NpgsqlTypes.NpgsqlPoint(x: 0.22722543864928701d, y: 0.2286950503361589d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 179,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2808000994293952d, y: 0.6525292312459335d), new NpgsqlTypes.NpgsqlPoint(x: 0.850377120659646d, y: 0.24365105094358253d), new NpgsqlTypes.NpgsqlPoint(x: 0.6791316864635702d, y: 0.9646903951185829d)),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16))]
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

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
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
                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11537519075024616d, y: 0.2819739154930022d), new NpgsqlTypes.NpgsqlPoint(x: 0.8528822990684319d, y: 0.7487487355909076d), new NpgsqlTypes.NpgsqlPoint(x: 0.271716913937056d, y: 0.9146398906414426d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.028057372311227402d, y: 0.47680722730401326d), new NpgsqlTypes.NpgsqlPoint(x: 0.6898259752097798d, y: 0.7159576932063679d), new NpgsqlTypes.NpgsqlPoint(x: 0.7764231211069257d, y: 0.4573435436704203d))));
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygon0M> models = null;

                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygon0M> models = null;

                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpolygonpolygon0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPolygon), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpolygonpolygon0mi_id", 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 81;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[34], false);
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
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[34], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 151, query1, 146, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 36, query1, 75, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 36, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatch(connection, 7, query1, 146, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 89, query1, 75, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 7, query1, 162, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatch(connection, 120, query1, 130, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygon0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 83, query1, 57, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPolygonpolygon0M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatchAsync(connection, 7, 66))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[34], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatch(connection, 130, 162))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 151);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[30], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[31], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[32], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[33], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 102);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[29], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[30], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[31], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[32], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[33], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[34], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1488243502583555d, y: 0.7271294528720949d), new NpgsqlTypes.NpgsqlPoint(x: 0.3765235761303194d, y: 0.6786306184986963d), new NpgsqlTypes.NpgsqlPoint(x: 0.46778620505752677d, y: 0.773769604932416d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07857255802594076d, y: 0.07415470180369788d), new NpgsqlTypes.NpgsqlPoint(x: 0.17890447421698052d, y: 0.5289457180077679d), new NpgsqlTypes.NpgsqlPoint(x: 0.7713728902142188d, y: 0.5236255896849368d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20130995814924757d, y: 0.591729132933246d), new NpgsqlTypes.NpgsqlPoint(x: 0.29932046351579655d, y: 0.8293278627708518d), new NpgsqlTypes.NpgsqlPoint(x: 0.8309524084453725d, y: 0.6351892236217032d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7889309086623513d, y: 0.4012097327487286d), new NpgsqlTypes.NpgsqlPoint(x: 0.14266817577019775d, y: 0.4052636422841466d), new NpgsqlTypes.NpgsqlPoint(x: 0.620752887384355d, y: 0.13015735144488072d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3325716949058076d, y: 0.6296100111034869d), new NpgsqlTypes.NpgsqlPoint(x: 0.5799877909824307d, y: 0.24957466465496103d), new NpgsqlTypes.NpgsqlPoint(x: 0.9798921270876552d, y: 0.7122695752621824d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9794519977852651d, y: 0.16668107686837708d), new NpgsqlTypes.NpgsqlPoint(x: 0.40683086225758236d, y: 0.36967196814774106d), new NpgsqlTypes.NpgsqlPoint(x: 0.5506264575269065d, y: 0.7556565975736046d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9296059753633313d, y: 0.96183741535481d), new NpgsqlTypes.NpgsqlPoint(x: 0.8236470338091888d, y: 0.7345578175041028d), new NpgsqlTypes.NpgsqlPoint(x: 0.4553802152581252d, y: 0.6973951536447385d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9783194731074515d, y: 0.2760826261442999d), new NpgsqlTypes.NpgsqlPoint(x: 0.4178876897496613d, y: 0.07977577207840092d), new NpgsqlTypes.NpgsqlPoint(x: 0.535292233756321d, y: 0.10022964303078119d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43984459244783314d, y: 0.9432521299115716d), new NpgsqlTypes.NpgsqlPoint(x: 0.26346979436605933d, y: 0.8392274141511022d), new NpgsqlTypes.NpgsqlPoint(x: 0.7053377722046726d, y: 0.5673769762345832d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5415481260621727d, y: 0.5401623668592578d), new NpgsqlTypes.NpgsqlPoint(x: 0.5589530885475551d, y: 0.29633932626594006d), new NpgsqlTypes.NpgsqlPoint(x: 0.4983622735781581d, y: 0.46643487663449223d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14521712536079456d, y: 0.5657775536512011d), new NpgsqlTypes.NpgsqlPoint(x: 0.9222194569096281d, y: 0.34523143010557933d), new NpgsqlTypes.NpgsqlPoint(x: 0.6702318465439422d, y: 0.7096775750747193d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7109702295795192d, y: 0.4851204037530221d), new NpgsqlTypes.NpgsqlPoint(x: 0.07778634654453276d, y: 0.4607061399687876d), new NpgsqlTypes.NpgsqlPoint(x: 0.34034162690599756d, y: 0.6439545294244445d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14739380350357345d, y: 0.8318589825407592d), new NpgsqlTypes.NpgsqlPoint(x: 0.9864522709892708d, y: 0.18138165053951816d), new NpgsqlTypes.NpgsqlPoint(x: 0.301730568612644d, y: 0.26393840765627374d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.99338337826293d, y: 0.5395501732117145d), new NpgsqlTypes.NpgsqlPoint(x: 0.9540915965202826d, y: 0.06623581977769388d), new NpgsqlTypes.NpgsqlPoint(x: 0.18957148161931803d, y: 0.555527607930171d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6328362750141585d, y: 0.5401207891417602d), new NpgsqlTypes.NpgsqlPoint(x: 0.44581803280637367d, y: 0.40114896324936766d), new NpgsqlTypes.NpgsqlPoint(x: 0.44441775606652645d, y: 0.1654435972027839d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5374522405451017d, y: 0.21058711087414084d), new NpgsqlTypes.NpgsqlPoint(x: 0.04584678146019461d, y: 0.2470802732243662d), new NpgsqlTypes.NpgsqlPoint(x: 0.40185905048762327d, y: 0.9547013012258199d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2581114246007148d, y: 0.48890196809414277d), new NpgsqlTypes.NpgsqlPoint(x: 0.12969211458198326d, y: 0.460812005338071d), new NpgsqlTypes.NpgsqlPoint(x: 0.27730474866604427d, y: 0.7416688400066335d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9992363380877989d, y: 0.43446472985138185d), new NpgsqlTypes.NpgsqlPoint(x: 0.4970670717844309d, y: 0.5069089812034174d), new NpgsqlTypes.NpgsqlPoint(x: 0.26484314779334406d, y: 0.5964915400807773d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5605959954779759d, y: 0.14058722246517263d), new NpgsqlTypes.NpgsqlPoint(x: 0.5019816575556576d, y: 0.37681382814787023d), new NpgsqlTypes.NpgsqlPoint(x: 0.016867343949891866d, y: 0.8240836260436863d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31363157841725464d, y: 0.2943726795391888d), new NpgsqlTypes.NpgsqlPoint(x: 0.06130344059326476d, y: 0.6139761778224475d), new NpgsqlTypes.NpgsqlPoint(x: 0.49454950924813224d, y: 0.34129250971816705d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2715430250557007d, y: 0.11940948084130576d), new NpgsqlTypes.NpgsqlPoint(x: 0.5934766644589193d, y: 0.9833168492205054d), new NpgsqlTypes.NpgsqlPoint(x: 0.601998327257617d, y: 0.39101491111113784d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11537519075024616d, y: 0.2819739154930022d), new NpgsqlTypes.NpgsqlPoint(x: 0.8528822990684319d, y: 0.7487487355909076d), new NpgsqlTypes.NpgsqlPoint(x: 0.271716913937056d, y: 0.9146398906414426d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7201296626985215d, y: 0.8265567995025946d), new NpgsqlTypes.NpgsqlPoint(x: 0.83089888570055d, y: 0.7774972940661306d), new NpgsqlTypes.NpgsqlPoint(x: 0.8564540779705255d, y: 0.7836869154477304d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.028057372311227402d, y: 0.47680722730401326d), new NpgsqlTypes.NpgsqlPoint(x: 0.6898259752097798d, y: 0.7159576932063679d), new NpgsqlTypes.NpgsqlPoint(x: 0.7764231211069257d, y: 0.4573435436704203d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9736236259205799d, y: 0.7985900545549892d), new NpgsqlTypes.NpgsqlPoint(x: 0.7668579916856233d, y: 0.5084748984498191d), new NpgsqlTypes.NpgsqlPoint(x: 0.9259404217478665d, y: 0.6421151249251728d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8930020454922659d, y: 0.0003585434412747279d), new NpgsqlTypes.NpgsqlPoint(x: 0.9922392892981555d, y: 0.4242704858708112d), new NpgsqlTypes.NpgsqlPoint(x: 0.2948319121537959d, y: 0.16433133839753422d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6749546687529968d, y: 0.7521807108655509d), new NpgsqlTypes.NpgsqlPoint(x: 0.45007938533562d, y: 0.7143314317128444d), new NpgsqlTypes.NpgsqlPoint(x: 0.46662146691721884d, y: 0.20390652469453663d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3880089898936686d, y: 0.8499907237391864d), new NpgsqlTypes.NpgsqlPoint(x: 0.33795762337776136d, y: 0.20345695178309386d), new NpgsqlTypes.NpgsqlPoint(x: 0.8467043737663393d, y: 0.06642393124557022d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8020295851871857d, y: 0.08972577921568425d), new NpgsqlTypes.NpgsqlPoint(x: 0.5338090299855354d, y: 0.346224974268283d), new NpgsqlTypes.NpgsqlPoint(x: 0.7159234190418664d, y: 0.7202466203070971d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.202746634092842d, y: 0.9114442205770565d), new NpgsqlTypes.NpgsqlPoint(x: 0.18478427200766312d, y: 0.16532950774798683d), new NpgsqlTypes.NpgsqlPoint(x: 0.06751671302358486d, y: 0.1388144092120046d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5980117106544915d, y: 0.2520660511213729d), new NpgsqlTypes.NpgsqlPoint(x: 0.08293681995690882d, y: 0.41712404721292606d), new NpgsqlTypes.NpgsqlPoint(x: 0.42708679750221146d, y: 0.3297026868441354d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02240871132290856d, y: 0.3423262869076127d), new NpgsqlTypes.NpgsqlPoint(x: 0.6983860181745823d, y: 0.1237660014261559d), new NpgsqlTypes.NpgsqlPoint(x: 0.4946156417356954d, y: 0.6689223683816123d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3261142076508827d, y: 0.10151357901453195d), new NpgsqlTypes.NpgsqlPoint(x: 0.2185546794023635d, y: 0.9281189899039812d), new NpgsqlTypes.NpgsqlPoint(x: 0.23637100943010492d, y: 0.6889371209390456d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4216590867724126d, y: 0.9339845538230768d), new NpgsqlTypes.NpgsqlPoint(x: 0.70871719221046d, y: 0.4446040582483095d), new NpgsqlTypes.NpgsqlPoint(x: 0.5383324161957443d, y: 0.9305107039940933d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.93600167399644d, y: 0.9575517599907857d), new NpgsqlTypes.NpgsqlPoint(x: 0.0873939064473932d, y: 0.026037033864447445d), new NpgsqlTypes.NpgsqlPoint(x: 0.7042189910467427d, y: 0.5753845717913167d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7636721888669893d, y: 0.22598174455171804d), new NpgsqlTypes.NpgsqlPoint(x: 0.5933513529376561d, y: 0.3006065485297398d), new NpgsqlTypes.NpgsqlPoint(x: 0.17005839826726354d, y: 0.968143989998302d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9556860172135984d, y: 0.8764902119459627d), new NpgsqlTypes.NpgsqlPoint(x: 0.027697570774365965d, y: 0.8680495023717647d), new NpgsqlTypes.NpgsqlPoint(x: 0.8936853074687251d, y: 0.7016263121406078d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5361896737376451d, y: 0.8213532353965384d), new NpgsqlTypes.NpgsqlPoint(x: 0.4908410696986888d, y: 0.9484789270488914d), new NpgsqlTypes.NpgsqlPoint(x: 0.8671645898984867d, y: 0.25901314331521996d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9121022545129751d, y: 0.9430755526380806d), new NpgsqlTypes.NpgsqlPoint(x: 0.2669346014013614d, y: 0.6427789005115873d), new NpgsqlTypes.NpgsqlPoint(x: 0.526347440089014d, y: 0.7193415786954607d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42306556492260583d, y: 0.8056707278717659d), new NpgsqlTypes.NpgsqlPoint(x: 0.5255745284149311d, y: 0.7969955540458713d), new NpgsqlTypes.NpgsqlPoint(x: 0.9040681296004918d, y: 0.19698054590001368d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8080451096127217d, y: 0.6606005678566904d), new NpgsqlTypes.NpgsqlPoint(x: 0.5236432263325083d, y: 0.14946655267536602d), new NpgsqlTypes.NpgsqlPoint(x: 0.48554055256218553d, y: 0.5782223551930122d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.056061100831860666d, y: 0.8939881533062202d), new NpgsqlTypes.NpgsqlPoint(x: 0.9199565633551177d, y: 0.7770432203454651d), new NpgsqlTypes.NpgsqlPoint(x: 0.8863996635496534d, y: 0.5928373175266413d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7738462949257809d, y: 0.24530928553493814d), new NpgsqlTypes.NpgsqlPoint(x: 0.8669380255433166d, y: 0.1621724900200887d), new NpgsqlTypes.NpgsqlPoint(x: 0.39147752837796d, y: 0.6166279541358805d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6229009779758907d, y: 0.8387208273690995d), new NpgsqlTypes.NpgsqlPoint(x: 0.7148620487003596d, y: 0.658224759232204d), new NpgsqlTypes.NpgsqlPoint(x: 0.9261808446299524d, y: 0.5772310678939709d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24027609654668802d, y: 0.05673614002140792d), new NpgsqlTypes.NpgsqlPoint(x: 0.6941539293547808d, y: 0.20504203931878062d), new NpgsqlTypes.NpgsqlPoint(x: 0.1784292794943444d, y: 0.42106865571344354d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.962455946174163d, y: 0.19207320208357925d), new NpgsqlTypes.NpgsqlPoint(x: 0.11939573435310025d, y: 0.4155332590488523d), new NpgsqlTypes.NpgsqlPoint(x: 0.9594343923479488d, y: 0.025513757706476348d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8481489968090576d, y: 0.028555122100105357d), new NpgsqlTypes.NpgsqlPoint(x: 0.7748840570596157d, y: 0.745497904556641d), new NpgsqlTypes.NpgsqlPoint(x: 0.773015207261952d, y: 0.6958888633209334d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.722437603074407d, y: 0.034340908955920124d), new NpgsqlTypes.NpgsqlPoint(x: 0.969519292975657d, y: 0.5597403105210145d), new NpgsqlTypes.NpgsqlPoint(x: 0.6943533414122035d, y: 0.7490761535505974d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8964987697540544d, y: 0.6649408501196306d), new NpgsqlTypes.NpgsqlPoint(x: 0.735938264003844d, y: 0.9714230440981535d), new NpgsqlTypes.NpgsqlPoint(x: 0.007069450022561097d, y: 0.18138801781135494d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8391066665905705d, y: 0.7457786510814929d), new NpgsqlTypes.NpgsqlPoint(x: 0.19100678764038037d, y: 0.8682832479002052d), new NpgsqlTypes.NpgsqlPoint(x: 0.8629304226537585d, y: 0.968163795840826d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2346146960459582d, y: 0.8964834388721623d), new NpgsqlTypes.NpgsqlPoint(x: 0.00022364107447414572d, y: 0.21468678410898534d), new NpgsqlTypes.NpgsqlPoint(x: 0.7245471471191279d, y: 0.6725238837248356d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2958969985025721d, y: 0.960207073076677d), new NpgsqlTypes.NpgsqlPoint(x: 0.8035413612224619d, y: 0.25712030018459964d), new NpgsqlTypes.NpgsqlPoint(x: 0.09088600626941667d, y: 0.22991725641765715d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8649661860198526d, y: 0.4802376528281568d), new NpgsqlTypes.NpgsqlPoint(x: 0.4142623054592728d, y: 0.11909102126935567d), new NpgsqlTypes.NpgsqlPoint(x: 0.2360356040168592d, y: 0.07228742876023664d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.276096284380138d, y: 0.35802502215110066d), new NpgsqlTypes.NpgsqlPoint(x: 0.15722481191731874d, y: 0.7356391019208057d), new NpgsqlTypes.NpgsqlPoint(x: 0.31103555063536303d, y: 0.9241887088989437d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3383718622706071d, y: 0.21220180873951455d), new NpgsqlTypes.NpgsqlPoint(x: 0.909645963385416d, y: 0.5709628088573443d), new NpgsqlTypes.NpgsqlPoint(x: 0.08612656574995314d, y: 0.6933610995932544d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5178653444427099d, y: 0.6882156128579199d), new NpgsqlTypes.NpgsqlPoint(x: 0.26469230430455337d, y: 0.7661835331628609d), new NpgsqlTypes.NpgsqlPoint(x: 0.5822776303004955d, y: 0.6943241980576665d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8411347306152247d, y: 0.12856256152562107d), new NpgsqlTypes.NpgsqlPoint(x: 0.13016422201830002d, y: 0.4795259786470778d), new NpgsqlTypes.NpgsqlPoint(x: 0.22648653912255035d, y: 0.8998560744063921d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32992977546394764d, y: 0.24722704752318325d), new NpgsqlTypes.NpgsqlPoint(x: 0.5964285356782918d, y: 0.8448207214397373d), new NpgsqlTypes.NpgsqlPoint(x: 0.1220290345768581d, y: 0.6901977522703215d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8925294272788517d, y: 0.29671924400406724d), new NpgsqlTypes.NpgsqlPoint(x: 0.8189615568117627d, y: 0.5434458177841369d), new NpgsqlTypes.NpgsqlPoint(x: 0.9258705927546786d, y: 0.7344443692043863d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2588321732854407d, y: 0.635719272714895d), new NpgsqlTypes.NpgsqlPoint(x: 0.44755997834883754d, y: 0.2940735550020198d), new NpgsqlTypes.NpgsqlPoint(x: 0.4428583394335387d, y: 0.3018340698444123d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08881600828619152d, y: 0.8147400874486564d), new NpgsqlTypes.NpgsqlPoint(x: 0.32889827664109095d, y: 0.1430091242030218d), new NpgsqlTypes.NpgsqlPoint(x: 0.07143528834137747d, y: 0.9014579723771868d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7987326891429253d, y: 0.48145195908465976d), new NpgsqlTypes.NpgsqlPoint(x: 0.8467779268813068d, y: 0.28087015561970474d), new NpgsqlTypes.NpgsqlPoint(x: 0.1369713132491256d, y: 0.8032211291353176d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7612895943378227d, y: 0.5739059019774272d), new NpgsqlTypes.NpgsqlPoint(x: 0.5759766126035636d, y: 0.1498216014885836d), new NpgsqlTypes.NpgsqlPoint(x: 0.13350724511249135d, y: 0.6171589901704204d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29579676546913614d, y: 0.8208350883682758d), new NpgsqlTypes.NpgsqlPoint(x: 0.468351234796056d, y: 0.4780246377488737d), new NpgsqlTypes.NpgsqlPoint(x: 0.043034931758850425d, y: 0.9260637930727454d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.893370955940728d, y: 0.03980662024429771d), new NpgsqlTypes.NpgsqlPoint(x: 0.8369856793863701d, y: 0.9564134346839994d), new NpgsqlTypes.NpgsqlPoint(x: 0.8023999789628827d, y: 0.64630847168661d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7108241650521876d, y: 0.1700314828790792d), new NpgsqlTypes.NpgsqlPoint(x: 0.5671606889504036d, y: 0.00798603406140852d), new NpgsqlTypes.NpgsqlPoint(x: 0.032127854705672365d, y: 0.04910592723559626d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42610496043985824d, y: 0.8270246532480358d), new NpgsqlTypes.NpgsqlPoint(x: 0.664165957815484d, y: 0.759589386561182d), new NpgsqlTypes.NpgsqlPoint(x: 0.32009813610285154d, y: 0.22502648391543945d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14364248755606135d, y: 0.8989869315174929d), new NpgsqlTypes.NpgsqlPoint(x: 0.9592678924815057d, y: 0.11797784833486458d), new NpgsqlTypes.NpgsqlPoint(x: 0.4342280775127454d, y: 0.6045814184631229d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45999456632994773d, y: 0.029218868303003465d), new NpgsqlTypes.NpgsqlPoint(x: 0.40103309238518015d, y: 0.4545324863247947d), new NpgsqlTypes.NpgsqlPoint(x: 0.4553383587354727d, y: 0.5788101692159944d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6295729121761624d, y: 0.5252200458421868d), new NpgsqlTypes.NpgsqlPoint(x: 0.4356902856022873d, y: 0.9621631530774807d), new NpgsqlTypes.NpgsqlPoint(x: 0.7525114546214272d, y: 0.21783965616012413d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.017019185081928456d, y: 0.8707663734570097d), new NpgsqlTypes.NpgsqlPoint(x: 0.6846793325884912d, y: 0.005729528428238817d), new NpgsqlTypes.NpgsqlPoint(x: 0.1895737966878972d, y: 0.030432572474420883d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4165130599736051d, y: 0.7723018929107274d), new NpgsqlTypes.NpgsqlPoint(x: 0.01526143995814111d, y: 0.3425098867353926d), new NpgsqlTypes.NpgsqlPoint(x: 0.6494610570680636d, y: 0.1845391481926838d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6928241521884663d, y: 0.8420703358240309d), new NpgsqlTypes.NpgsqlPoint(x: 0.8185033461189962d, y: 0.9903457120329426d), new NpgsqlTypes.NpgsqlPoint(x: 0.3280965245294679d, y: 0.634591991111133d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12788800217486662d, y: 0.11022960889558431d), new NpgsqlTypes.NpgsqlPoint(x: 0.8797993457323025d, y: 0.6167986719174645d), new NpgsqlTypes.NpgsqlPoint(x: 0.9770377868391699d, y: 0.5770748107436597d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8817709212678135d, y: 0.1221861724575346d), new NpgsqlTypes.NpgsqlPoint(x: 0.8251426613492906d, y: 0.45070871014698155d), new NpgsqlTypes.NpgsqlPoint(x: 0.6016177974759489d, y: 0.908905347151417d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8406940366122336d, y: 0.7230394756702488d), new NpgsqlTypes.NpgsqlPoint(x: 0.4041459318219618d, y: 0.6715257358488967d), new NpgsqlTypes.NpgsqlPoint(x: 0.21843737625545923d, y: 0.23701541101803203d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6464420583601787d, y: 0.578766616826311d), new NpgsqlTypes.NpgsqlPoint(x: 0.13494418441267375d, y: 0.3500602013306582d), new NpgsqlTypes.NpgsqlPoint(x: 0.6663486537561685d, y: 0.6209861471705669d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20693995383250696d, y: 0.6447666617266381d), new NpgsqlTypes.NpgsqlPoint(x: 0.193679495541633d, y: 0.7948725718204089d), new NpgsqlTypes.NpgsqlPoint(x: 0.9249610274897021d, y: 0.0036931366895293083d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7764785941520207d, y: 0.6322583134697929d), new NpgsqlTypes.NpgsqlPoint(x: 0.15507966054890432d, y: 0.5458321236566682d), new NpgsqlTypes.NpgsqlPoint(x: 0.5559806338461516d, y: 0.291125571546207d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7846503589745569d, y: 0.131738612878872d), new NpgsqlTypes.NpgsqlPoint(x: 0.8911645668509655d, y: 0.760125984064843d), new NpgsqlTypes.NpgsqlPoint(x: 0.06270801941569071d, y: 0.9253525418764176d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4295284151428086d, y: 0.030492352355105057d), new NpgsqlTypes.NpgsqlPoint(x: 0.30293825620202475d, y: 0.44867397415146315d), new NpgsqlTypes.NpgsqlPoint(x: 0.22722543864928701d, y: 0.2286950503361589d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2808000994293952d, y: 0.6525292312459335d), new NpgsqlTypes.NpgsqlPoint(x: 0.850377120659646d, y: 0.24365105094358253d), new NpgsqlTypes.NpgsqlPoint(x: 0.6791316864635702d, y: 0.9646903951185829d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1488243502583555d, y: 0.7271294528720949d), new NpgsqlTypes.NpgsqlPoint(x: 0.3765235761303194d, y: 0.6786306184986963d), new NpgsqlTypes.NpgsqlPoint(x: 0.46778620505752677d, y: 0.773769604932416d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07857255802594076d, y: 0.07415470180369788d), new NpgsqlTypes.NpgsqlPoint(x: 0.17890447421698052d, y: 0.5289457180077679d), new NpgsqlTypes.NpgsqlPoint(x: 0.7713728902142188d, y: 0.5236255896849368d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20130995814924757d, y: 0.591729132933246d), new NpgsqlTypes.NpgsqlPoint(x: 0.29932046351579655d, y: 0.8293278627708518d), new NpgsqlTypes.NpgsqlPoint(x: 0.8309524084453725d, y: 0.6351892236217032d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7889309086623513d, y: 0.4012097327487286d), new NpgsqlTypes.NpgsqlPoint(x: 0.14266817577019775d, y: 0.4052636422841466d), new NpgsqlTypes.NpgsqlPoint(x: 0.620752887384355d, y: 0.13015735144488072d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3325716949058076d, y: 0.6296100111034869d), new NpgsqlTypes.NpgsqlPoint(x: 0.5799877909824307d, y: 0.24957466465496103d), new NpgsqlTypes.NpgsqlPoint(x: 0.9798921270876552d, y: 0.7122695752621824d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9794519977852651d, y: 0.16668107686837708d), new NpgsqlTypes.NpgsqlPoint(x: 0.40683086225758236d, y: 0.36967196814774106d), new NpgsqlTypes.NpgsqlPoint(x: 0.5506264575269065d, y: 0.7556565975736046d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9296059753633313d, y: 0.96183741535481d), new NpgsqlTypes.NpgsqlPoint(x: 0.8236470338091888d, y: 0.7345578175041028d), new NpgsqlTypes.NpgsqlPoint(x: 0.4553802152581252d, y: 0.6973951536447385d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9783194731074515d, y: 0.2760826261442999d), new NpgsqlTypes.NpgsqlPoint(x: 0.4178876897496613d, y: 0.07977577207840092d), new NpgsqlTypes.NpgsqlPoint(x: 0.535292233756321d, y: 0.10022964303078119d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43984459244783314d, y: 0.9432521299115716d), new NpgsqlTypes.NpgsqlPoint(x: 0.26346979436605933d, y: 0.8392274141511022d), new NpgsqlTypes.NpgsqlPoint(x: 0.7053377722046726d, y: 0.5673769762345832d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5415481260621727d, y: 0.5401623668592578d), new NpgsqlTypes.NpgsqlPoint(x: 0.5589530885475551d, y: 0.29633932626594006d), new NpgsqlTypes.NpgsqlPoint(x: 0.4983622735781581d, y: 0.46643487663449223d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14521712536079456d, y: 0.5657775536512011d), new NpgsqlTypes.NpgsqlPoint(x: 0.9222194569096281d, y: 0.34523143010557933d), new NpgsqlTypes.NpgsqlPoint(x: 0.6702318465439422d, y: 0.7096775750747193d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7109702295795192d, y: 0.4851204037530221d), new NpgsqlTypes.NpgsqlPoint(x: 0.07778634654453276d, y: 0.4607061399687876d), new NpgsqlTypes.NpgsqlPoint(x: 0.34034162690599756d, y: 0.6439545294244445d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14739380350357345d, y: 0.8318589825407592d), new NpgsqlTypes.NpgsqlPoint(x: 0.9864522709892708d, y: 0.18138165053951816d), new NpgsqlTypes.NpgsqlPoint(x: 0.301730568612644d, y: 0.26393840765627374d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.99338337826293d, y: 0.5395501732117145d), new NpgsqlTypes.NpgsqlPoint(x: 0.9540915965202826d, y: 0.06623581977769388d), new NpgsqlTypes.NpgsqlPoint(x: 0.18957148161931803d, y: 0.555527607930171d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6328362750141585d, y: 0.5401207891417602d), new NpgsqlTypes.NpgsqlPoint(x: 0.44581803280637367d, y: 0.40114896324936766d), new NpgsqlTypes.NpgsqlPoint(x: 0.44441775606652645d, y: 0.1654435972027839d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5374522405451017d, y: 0.21058711087414084d), new NpgsqlTypes.NpgsqlPoint(x: 0.04584678146019461d, y: 0.2470802732243662d), new NpgsqlTypes.NpgsqlPoint(x: 0.40185905048762327d, y: 0.9547013012258199d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2581114246007148d, y: 0.48890196809414277d), new NpgsqlTypes.NpgsqlPoint(x: 0.12969211458198326d, y: 0.460812005338071d), new NpgsqlTypes.NpgsqlPoint(x: 0.27730474866604427d, y: 0.7416688400066335d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9992363380877989d, y: 0.43446472985138185d), new NpgsqlTypes.NpgsqlPoint(x: 0.4970670717844309d, y: 0.5069089812034174d), new NpgsqlTypes.NpgsqlPoint(x: 0.26484314779334406d, y: 0.5964915400807773d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5605959954779759d, y: 0.14058722246517263d), new NpgsqlTypes.NpgsqlPoint(x: 0.5019816575556576d, y: 0.37681382814787023d), new NpgsqlTypes.NpgsqlPoint(x: 0.016867343949891866d, y: 0.8240836260436863d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31363157841725464d, y: 0.2943726795391888d), new NpgsqlTypes.NpgsqlPoint(x: 0.06130344059326476d, y: 0.6139761778224475d), new NpgsqlTypes.NpgsqlPoint(x: 0.49454950924813224d, y: 0.34129250971816705d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2715430250557007d, y: 0.11940948084130576d), new NpgsqlTypes.NpgsqlPoint(x: 0.5934766644589193d, y: 0.9833168492205054d), new NpgsqlTypes.NpgsqlPoint(x: 0.601998327257617d, y: 0.39101491111113784d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11537519075024616d, y: 0.2819739154930022d), new NpgsqlTypes.NpgsqlPoint(x: 0.8528822990684319d, y: 0.7487487355909076d), new NpgsqlTypes.NpgsqlPoint(x: 0.271716913937056d, y: 0.9146398906414426d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7201296626985215d, y: 0.8265567995025946d), new NpgsqlTypes.NpgsqlPoint(x: 0.83089888570055d, y: 0.7774972940661306d), new NpgsqlTypes.NpgsqlPoint(x: 0.8564540779705255d, y: 0.7836869154477304d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.028057372311227402d, y: 0.47680722730401326d), new NpgsqlTypes.NpgsqlPoint(x: 0.6898259752097798d, y: 0.7159576932063679d), new NpgsqlTypes.NpgsqlPoint(x: 0.7764231211069257d, y: 0.4573435436704203d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9736236259205799d, y: 0.7985900545549892d), new NpgsqlTypes.NpgsqlPoint(x: 0.7668579916856233d, y: 0.5084748984498191d), new NpgsqlTypes.NpgsqlPoint(x: 0.9259404217478665d, y: 0.6421151249251728d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8930020454922659d, y: 0.0003585434412747279d), new NpgsqlTypes.NpgsqlPoint(x: 0.9922392892981555d, y: 0.4242704858708112d), new NpgsqlTypes.NpgsqlPoint(x: 0.2948319121537959d, y: 0.16433133839753422d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6749546687529968d, y: 0.7521807108655509d), new NpgsqlTypes.NpgsqlPoint(x: 0.45007938533562d, y: 0.7143314317128444d), new NpgsqlTypes.NpgsqlPoint(x: 0.46662146691721884d, y: 0.20390652469453663d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3880089898936686d, y: 0.8499907237391864d), new NpgsqlTypes.NpgsqlPoint(x: 0.33795762337776136d, y: 0.20345695178309386d), new NpgsqlTypes.NpgsqlPoint(x: 0.8467043737663393d, y: 0.06642393124557022d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8020295851871857d, y: 0.08972577921568425d), new NpgsqlTypes.NpgsqlPoint(x: 0.5338090299855354d, y: 0.346224974268283d), new NpgsqlTypes.NpgsqlPoint(x: 0.7159234190418664d, y: 0.7202466203070971d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.202746634092842d, y: 0.9114442205770565d), new NpgsqlTypes.NpgsqlPoint(x: 0.18478427200766312d, y: 0.16532950774798683d), new NpgsqlTypes.NpgsqlPoint(x: 0.06751671302358486d, y: 0.1388144092120046d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5980117106544915d, y: 0.2520660511213729d), new NpgsqlTypes.NpgsqlPoint(x: 0.08293681995690882d, y: 0.41712404721292606d), new NpgsqlTypes.NpgsqlPoint(x: 0.42708679750221146d, y: 0.3297026868441354d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02240871132290856d, y: 0.3423262869076127d), new NpgsqlTypes.NpgsqlPoint(x: 0.6983860181745823d, y: 0.1237660014261559d), new NpgsqlTypes.NpgsqlPoint(x: 0.4946156417356954d, y: 0.6689223683816123d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3261142076508827d, y: 0.10151357901453195d), new NpgsqlTypes.NpgsqlPoint(x: 0.2185546794023635d, y: 0.9281189899039812d), new NpgsqlTypes.NpgsqlPoint(x: 0.23637100943010492d, y: 0.6889371209390456d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4216590867724126d, y: 0.9339845538230768d), new NpgsqlTypes.NpgsqlPoint(x: 0.70871719221046d, y: 0.4446040582483095d), new NpgsqlTypes.NpgsqlPoint(x: 0.5383324161957443d, y: 0.9305107039940933d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.93600167399644d, y: 0.9575517599907857d), new NpgsqlTypes.NpgsqlPoint(x: 0.0873939064473932d, y: 0.026037033864447445d), new NpgsqlTypes.NpgsqlPoint(x: 0.7042189910467427d, y: 0.5753845717913167d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7636721888669893d, y: 0.22598174455171804d), new NpgsqlTypes.NpgsqlPoint(x: 0.5933513529376561d, y: 0.3006065485297398d), new NpgsqlTypes.NpgsqlPoint(x: 0.17005839826726354d, y: 0.968143989998302d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9556860172135984d, y: 0.8764902119459627d), new NpgsqlTypes.NpgsqlPoint(x: 0.027697570774365965d, y: 0.8680495023717647d), new NpgsqlTypes.NpgsqlPoint(x: 0.8936853074687251d, y: 0.7016263121406078d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5361896737376451d, y: 0.8213532353965384d), new NpgsqlTypes.NpgsqlPoint(x: 0.4908410696986888d, y: 0.9484789270488914d), new NpgsqlTypes.NpgsqlPoint(x: 0.8671645898984867d, y: 0.25901314331521996d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9121022545129751d, y: 0.9430755526380806d), new NpgsqlTypes.NpgsqlPoint(x: 0.2669346014013614d, y: 0.6427789005115873d), new NpgsqlTypes.NpgsqlPoint(x: 0.526347440089014d, y: 0.7193415786954607d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42306556492260583d, y: 0.8056707278717659d), new NpgsqlTypes.NpgsqlPoint(x: 0.5255745284149311d, y: 0.7969955540458713d), new NpgsqlTypes.NpgsqlPoint(x: 0.9040681296004918d, y: 0.19698054590001368d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8080451096127217d, y: 0.6606005678566904d), new NpgsqlTypes.NpgsqlPoint(x: 0.5236432263325083d, y: 0.14946655267536602d), new NpgsqlTypes.NpgsqlPoint(x: 0.48554055256218553d, y: 0.5782223551930122d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.056061100831860666d, y: 0.8939881533062202d), new NpgsqlTypes.NpgsqlPoint(x: 0.9199565633551177d, y: 0.7770432203454651d), new NpgsqlTypes.NpgsqlPoint(x: 0.8863996635496534d, y: 0.5928373175266413d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7738462949257809d, y: 0.24530928553493814d), new NpgsqlTypes.NpgsqlPoint(x: 0.8669380255433166d, y: 0.1621724900200887d), new NpgsqlTypes.NpgsqlPoint(x: 0.39147752837796d, y: 0.6166279541358805d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6229009779758907d, y: 0.8387208273690995d), new NpgsqlTypes.NpgsqlPoint(x: 0.7148620487003596d, y: 0.658224759232204d), new NpgsqlTypes.NpgsqlPoint(x: 0.9261808446299524d, y: 0.5772310678939709d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24027609654668802d, y: 0.05673614002140792d), new NpgsqlTypes.NpgsqlPoint(x: 0.6941539293547808d, y: 0.20504203931878062d), new NpgsqlTypes.NpgsqlPoint(x: 0.1784292794943444d, y: 0.42106865571344354d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.962455946174163d, y: 0.19207320208357925d), new NpgsqlTypes.NpgsqlPoint(x: 0.11939573435310025d, y: 0.4155332590488523d), new NpgsqlTypes.NpgsqlPoint(x: 0.9594343923479488d, y: 0.025513757706476348d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8481489968090576d, y: 0.028555122100105357d), new NpgsqlTypes.NpgsqlPoint(x: 0.7748840570596157d, y: 0.745497904556641d), new NpgsqlTypes.NpgsqlPoint(x: 0.773015207261952d, y: 0.6958888633209334d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.722437603074407d, y: 0.034340908955920124d), new NpgsqlTypes.NpgsqlPoint(x: 0.969519292975657d, y: 0.5597403105210145d), new NpgsqlTypes.NpgsqlPoint(x: 0.6943533414122035d, y: 0.7490761535505974d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8964987697540544d, y: 0.6649408501196306d), new NpgsqlTypes.NpgsqlPoint(x: 0.735938264003844d, y: 0.9714230440981535d), new NpgsqlTypes.NpgsqlPoint(x: 0.007069450022561097d, y: 0.18138801781135494d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8391066665905705d, y: 0.7457786510814929d), new NpgsqlTypes.NpgsqlPoint(x: 0.19100678764038037d, y: 0.8682832479002052d), new NpgsqlTypes.NpgsqlPoint(x: 0.8629304226537585d, y: 0.968163795840826d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2346146960459582d, y: 0.8964834388721623d), new NpgsqlTypes.NpgsqlPoint(x: 0.00022364107447414572d, y: 0.21468678410898534d), new NpgsqlTypes.NpgsqlPoint(x: 0.7245471471191279d, y: 0.6725238837248356d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2958969985025721d, y: 0.960207073076677d), new NpgsqlTypes.NpgsqlPoint(x: 0.8035413612224619d, y: 0.25712030018459964d), new NpgsqlTypes.NpgsqlPoint(x: 0.09088600626941667d, y: 0.22991725641765715d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8649661860198526d, y: 0.4802376528281568d), new NpgsqlTypes.NpgsqlPoint(x: 0.4142623054592728d, y: 0.11909102126935567d), new NpgsqlTypes.NpgsqlPoint(x: 0.2360356040168592d, y: 0.07228742876023664d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.276096284380138d, y: 0.35802502215110066d), new NpgsqlTypes.NpgsqlPoint(x: 0.15722481191731874d, y: 0.7356391019208057d), new NpgsqlTypes.NpgsqlPoint(x: 0.31103555063536303d, y: 0.9241887088989437d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3383718622706071d, y: 0.21220180873951455d), new NpgsqlTypes.NpgsqlPoint(x: 0.909645963385416d, y: 0.5709628088573443d), new NpgsqlTypes.NpgsqlPoint(x: 0.08612656574995314d, y: 0.6933610995932544d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5178653444427099d, y: 0.6882156128579199d), new NpgsqlTypes.NpgsqlPoint(x: 0.26469230430455337d, y: 0.7661835331628609d), new NpgsqlTypes.NpgsqlPoint(x: 0.5822776303004955d, y: 0.6943241980576665d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8411347306152247d, y: 0.12856256152562107d), new NpgsqlTypes.NpgsqlPoint(x: 0.13016422201830002d, y: 0.4795259786470778d), new NpgsqlTypes.NpgsqlPoint(x: 0.22648653912255035d, y: 0.8998560744063921d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32992977546394764d, y: 0.24722704752318325d), new NpgsqlTypes.NpgsqlPoint(x: 0.5964285356782918d, y: 0.8448207214397373d), new NpgsqlTypes.NpgsqlPoint(x: 0.1220290345768581d, y: 0.6901977522703215d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8925294272788517d, y: 0.29671924400406724d), new NpgsqlTypes.NpgsqlPoint(x: 0.8189615568117627d, y: 0.5434458177841369d), new NpgsqlTypes.NpgsqlPoint(x: 0.9258705927546786d, y: 0.7344443692043863d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2588321732854407d, y: 0.635719272714895d), new NpgsqlTypes.NpgsqlPoint(x: 0.44755997834883754d, y: 0.2940735550020198d), new NpgsqlTypes.NpgsqlPoint(x: 0.4428583394335387d, y: 0.3018340698444123d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08881600828619152d, y: 0.8147400874486564d), new NpgsqlTypes.NpgsqlPoint(x: 0.32889827664109095d, y: 0.1430091242030218d), new NpgsqlTypes.NpgsqlPoint(x: 0.07143528834137747d, y: 0.9014579723771868d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7987326891429253d, y: 0.48145195908465976d), new NpgsqlTypes.NpgsqlPoint(x: 0.8467779268813068d, y: 0.28087015561970474d), new NpgsqlTypes.NpgsqlPoint(x: 0.1369713132491256d, y: 0.8032211291353176d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7612895943378227d, y: 0.5739059019774272d), new NpgsqlTypes.NpgsqlPoint(x: 0.5759766126035636d, y: 0.1498216014885836d), new NpgsqlTypes.NpgsqlPoint(x: 0.13350724511249135d, y: 0.6171589901704204d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29579676546913614d, y: 0.8208350883682758d), new NpgsqlTypes.NpgsqlPoint(x: 0.468351234796056d, y: 0.4780246377488737d), new NpgsqlTypes.NpgsqlPoint(x: 0.043034931758850425d, y: 0.9260637930727454d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.893370955940728d, y: 0.03980662024429771d), new NpgsqlTypes.NpgsqlPoint(x: 0.8369856793863701d, y: 0.9564134346839994d), new NpgsqlTypes.NpgsqlPoint(x: 0.8023999789628827d, y: 0.64630847168661d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7108241650521876d, y: 0.1700314828790792d), new NpgsqlTypes.NpgsqlPoint(x: 0.5671606889504036d, y: 0.00798603406140852d), new NpgsqlTypes.NpgsqlPoint(x: 0.032127854705672365d, y: 0.04910592723559626d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42610496043985824d, y: 0.8270246532480358d), new NpgsqlTypes.NpgsqlPoint(x: 0.664165957815484d, y: 0.759589386561182d), new NpgsqlTypes.NpgsqlPoint(x: 0.32009813610285154d, y: 0.22502648391543945d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14364248755606135d, y: 0.8989869315174929d), new NpgsqlTypes.NpgsqlPoint(x: 0.9592678924815057d, y: 0.11797784833486458d), new NpgsqlTypes.NpgsqlPoint(x: 0.4342280775127454d, y: 0.6045814184631229d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45999456632994773d, y: 0.029218868303003465d), new NpgsqlTypes.NpgsqlPoint(x: 0.40103309238518015d, y: 0.4545324863247947d), new NpgsqlTypes.NpgsqlPoint(x: 0.4553383587354727d, y: 0.5788101692159944d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6295729121761624d, y: 0.5252200458421868d), new NpgsqlTypes.NpgsqlPoint(x: 0.4356902856022873d, y: 0.9621631530774807d), new NpgsqlTypes.NpgsqlPoint(x: 0.7525114546214272d, y: 0.21783965616012413d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.017019185081928456d, y: 0.8707663734570097d), new NpgsqlTypes.NpgsqlPoint(x: 0.6846793325884912d, y: 0.005729528428238817d), new NpgsqlTypes.NpgsqlPoint(x: 0.1895737966878972d, y: 0.030432572474420883d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4165130599736051d, y: 0.7723018929107274d), new NpgsqlTypes.NpgsqlPoint(x: 0.01526143995814111d, y: 0.3425098867353926d), new NpgsqlTypes.NpgsqlPoint(x: 0.6494610570680636d, y: 0.1845391481926838d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6928241521884663d, y: 0.8420703358240309d), new NpgsqlTypes.NpgsqlPoint(x: 0.8185033461189962d, y: 0.9903457120329426d), new NpgsqlTypes.NpgsqlPoint(x: 0.3280965245294679d, y: 0.634591991111133d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12788800217486662d, y: 0.11022960889558431d), new NpgsqlTypes.NpgsqlPoint(x: 0.8797993457323025d, y: 0.6167986719174645d), new NpgsqlTypes.NpgsqlPoint(x: 0.9770377868391699d, y: 0.5770748107436597d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8817709212678135d, y: 0.1221861724575346d), new NpgsqlTypes.NpgsqlPoint(x: 0.8251426613492906d, y: 0.45070871014698155d), new NpgsqlTypes.NpgsqlPoint(x: 0.6016177974759489d, y: 0.908905347151417d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8406940366122336d, y: 0.7230394756702488d), new NpgsqlTypes.NpgsqlPoint(x: 0.4041459318219618d, y: 0.6715257358488967d), new NpgsqlTypes.NpgsqlPoint(x: 0.21843737625545923d, y: 0.23701541101803203d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6464420583601787d, y: 0.578766616826311d), new NpgsqlTypes.NpgsqlPoint(x: 0.13494418441267375d, y: 0.3500602013306582d), new NpgsqlTypes.NpgsqlPoint(x: 0.6663486537561685d, y: 0.6209861471705669d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20693995383250696d, y: 0.6447666617266381d), new NpgsqlTypes.NpgsqlPoint(x: 0.193679495541633d, y: 0.7948725718204089d), new NpgsqlTypes.NpgsqlPoint(x: 0.9249610274897021d, y: 0.0036931366895293083d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7764785941520207d, y: 0.6322583134697929d), new NpgsqlTypes.NpgsqlPoint(x: 0.15507966054890432d, y: 0.5458321236566682d), new NpgsqlTypes.NpgsqlPoint(x: 0.5559806338461516d, y: 0.291125571546207d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7846503589745569d, y: 0.131738612878872d), new NpgsqlTypes.NpgsqlPoint(x: 0.8911645668509655d, y: 0.760125984064843d), new NpgsqlTypes.NpgsqlPoint(x: 0.06270801941569071d, y: 0.9253525418764176d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4295284151428086d, y: 0.030492352355105057d), new NpgsqlTypes.NpgsqlPoint(x: 0.30293825620202475d, y: 0.44867397415146315d), new NpgsqlTypes.NpgsqlPoint(x: 0.22722543864928701d, y: 0.2286950503361589d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2808000994293952d, y: 0.6525292312459335d), new NpgsqlTypes.NpgsqlPoint(x: 0.850377120659646d, y: 0.24365105094358253d), new NpgsqlTypes.NpgsqlPoint(x: 0.6791316864635702d, y: 0.9646903951185829d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygon0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygon0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygon0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
FROM public.binary_npgsqlpolygonpolygon0m m
LEFT JOIN public.binary_npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygon0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygon0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygon0mi
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
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI), typeof(NpgsqlPolygonpolygon0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygon0MI>();
                var models2 = new List<NpgsqlPolygonpolygon0MI>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MI>();
                var models2 = new List<NpgsqlPolygonpolygon0MI>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygon0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA), typeof(NpgsqlPolygonpolygon0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygon0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygon0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

