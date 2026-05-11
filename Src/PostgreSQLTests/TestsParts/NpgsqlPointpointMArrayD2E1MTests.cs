

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
    internal partial interface INpgsqlPointMArraypointMArrayD2
    {
    }
    
    internal partial class NpgsqlPointMArraypointMArrayD2 : INpgsqlPointMArraypointMArrayD2
    {


#region TestData

        private readonly NpgsqlPointpointMArrayD2E1M[] _testData = new NpgsqlPointpointMArrayD2E1M[]
        {
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.9726851965688439d, y: 0.6201499854380851d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7259820069583689d, y: 0.5329174569712503d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.0025390089604734323d, y: 0.1050206046950225d),
new NpgsqlTypes.NpgsqlPoint(x: 0.42013114214573233d, y: 0.9408814297016581d), } },
    ModelInner = new NpgsqlPointpointMArrayD21MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.8672396182892295d, y: 0.3199343202823941d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19952236122327827d, y: 0.07471058063905867d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.12549279335730779d, y: 0.04542193057876387d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9587033300569099d, y: 0.23742693160654327d), } },
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.7762954085717001d, y: 0.9636316948307273d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5189257825692556d, y: 0.6271312543040537d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.15528926734987014d, y: 0.20041990219652472d),
new NpgsqlTypes.NpgsqlPoint(x: 0.000765650802029616d, y: 0.48137875978909894d), } },
    ModelInner = new NpgsqlPointpointMArrayD21MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.2891690118926633d, y: 0.9132678590124991d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7495286056767746d, y: 0.5494585213127906d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.9498963106464916d, y: 0.6420491962606604d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07802050479500733d, y: 0.16026808635675793d), } },
},
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.22800981351944793d, y: 0.9322080387485697d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31093433273987936d, y: 0.9994041431163365d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.22498135291947607d, y: 0.8446197306893961d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6913133879087338d, y: 0.022425912414090643d), } },
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.41369601254285526d, y: 0.9978499836856548d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5419828897339374d, y: 0.5212759011881527d), } },
    ModelInner = new NpgsqlPointpointMArrayD21MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.9659891964273806d, y: 0.48305298216038217d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6958045862741576d, y: 0.3636118783075265d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.5774489213283442d, y: 0.5727499830505495d),
new NpgsqlTypes.NpgsqlPoint(x: 0.29850543016965847d, y: 0.6847475569340593d), } },
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.5759247739839982d, y: 0.7495548687381538d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24350125852591775d, y: 0.3017581907985769d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.4278424124212149d, y: 0.10380448837395484d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9499079451700668d, y: 0.36687443737922676d), } },
    ModelInner = new NpgsqlPointpointMArrayD21MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.1643353868827535d, y: 0.9021290862368412d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4231582992754982d, y: 0.38270971523389885d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.9432988413153953d, y: 0.8528292491768674d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14353395228231292d, y: 0.9898755690544836d), } },
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.6554767771061424d, y: 0.1600429835454561d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24898030629283707d, y: 0.11572447198272806d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.7599808468259752d, y: 0.9713079006550618d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3875860559924247d, y: 0.26501236846836684d), } },
    ModelInner = new NpgsqlPointpointMArrayD21MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.8419934043980423d, y: 0.6087517110931607d),
new NpgsqlTypes.NpgsqlPoint(x: 0.022798499297775332d, y: 0.9059418422900242d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.7998280683816225d, y: 0.41400663151392736d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5621964496384598d, y: 0.2880329740419121d), } },
},
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.7660061398067388d, y: 0.29921236315196686d),
new NpgsqlTypes.NpgsqlPoint(x: 0.44193178489923224d, y: 0.38084415461803245d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.697899637316338d, y: 0.626903978011537d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1447002322883475d, y: 0.7031578126021328d), } },
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.9094992917146792d, y: 0.54101089670239d),
new NpgsqlTypes.NpgsqlPoint(x: 0.272256835087373d, y: 0.6849158414407273d), } },
    ModelInner = new NpgsqlPointpointMArrayD21MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.9120464674160755d, y: 0.9370231203717955d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6109736852248926d, y: 0.19270413681059717d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.62581496540578d, y: 0.2850915719678655d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6041504023071201d, y: 0.13028199663255446d), } },
},
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.124431116430745d, y: 0.3856009799519666d),
new NpgsqlTypes.NpgsqlPoint(x: 0.40280283527027794d, y: 0.23255363299794574d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.9411194884676397d, y: 0.5381169362153977d),
new NpgsqlTypes.NpgsqlPoint(x: 0.40615510459002724d, y: 0.2562250302610942d), } },
    ModelInner = new NpgsqlPointpointMArrayD21MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.9368846427375903d, y: 0.8037956047738818d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09290909003744818d, y: 0.009108394797287978d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.386693837084061d, y: 0.22815091495971618d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1286881722742138d, y: 0.31012120511396746d), } },
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.07301334503019474d, y: 0.32843477524953535d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25173140358241575d, y: 0.9022312520976221d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.28710626663787375d, y: 0.43254997017838936d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9924527276745467d, y: 0.1538012771186078d), } },
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.22286492902960853d, y: 0.2203692644896298d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5353851254118378d, y: 0.6606231448036344d), } },
    ModelInner = new NpgsqlPointpointMArrayD21MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.29018054037983465d, y: 0.15475533435227595d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5546035305292095d, y: 0.3312238755358966d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.7348608666426136d, y: 0.17066797630681962d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8337095551719653d, y: 0.22708446083512557d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.9864528917847475d, y: 0.8303520891140439d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2895073097248876d, y: 0.5709610510975337d), } },
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.8026783322804002d, y: 0.10978955847695304d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4568810978647243d, y: 0.9305632466763758d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.3613163154877783d, y: 0.14782959938794094d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2532121420954545d, y: 0.9350855519786471d), } },
    ModelInner = new NpgsqlPointpointMArrayD21MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.19489169954372032d, y: 0.015740593070875275d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8476532773926696d, y: 0.028956105933862553d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.639132631284179d, y: 0.6107671975241494d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9101180304761872d, y: 0.781348023554923d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.6738649220683379d, y: 0.2425809621065822d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3169524030170938d, y: 0.9110022380336463d), } },
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.5896821860893183d, y: 0.574948647723659d),
new NpgsqlTypes.NpgsqlPoint(x: 0.41518099714892887d, y: 0.2910781978548057d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.9172043471859119d, y: 0.5770078137238688d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08025282695254732d, y: 0.38505400090515307d), } },
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.5853539682125324d, y: 0.37582766898751785d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4080005780783349d, y: 0.38543617955175724d), } },
    ModelInner = new NpgsqlPointpointMArrayD21MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.22656882845976856d, y: 0.8617233854767402d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7650828837730875d, y: 0.5206237794857685d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.32483813546731377d, y: 0.06303039943268329d),
new NpgsqlTypes.NpgsqlPoint(x: 0.027155711937925764d, y: 0.4855478677014703d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.22006726581608393d, y: 0.40314172141019644d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9572084571604101d, y: 0.6362633534385466d), } },
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.18328170917509679d, y: 0.3431324032049984d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6604991002760433d, y: 0.9470386523752944d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.7587183333282955d, y: 0.04591043285515073d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5496530002349018d, y: 0.07282112600537616d), } },
    ModelInner = new NpgsqlPointpointMArrayD21MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.9535407755329331d, y: 0.10877383694840259d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19230090953952472d, y: 0.16885940788210663d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.7655406423291115d, y: 0.3140033942991024d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7754583074830078d, y: 0.6470754090057453d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.9982830128614006d, y: 0.19186147876968884d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4601372422384056d, y: 0.541850397917187d), } },
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.6991237793813246d, y: 0.27386810279275d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2948712477648411d, y: 0.9893140168421305d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.283541468631919d, y: 0.32209129727144736d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9249324866262116d, y: 0.49078309216491955d), } },
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.920314321110264d, y: 0.7125435941609232d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8078573508443935d, y: 0.4222164123732066d), } },
    ModelInner = new NpgsqlPointpointMArrayD21MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.26733587185272845d, y: 0.394427042178774d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5405292072431099d, y: 0.8259124586716153d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.1251551675384499d, y: 0.057355434770903435d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5815536028429226d, y: 0.6428706599491106d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.33103802322255005d, y: 0.949203110249924d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3387948408506879d, y: 0.9629415672984413d), } },
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.558166586209658d, y: 0.8711511783574788d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22738332086373758d, y: 0.5639723312466527d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.6703407571554593d, y: 0.5248379651932493d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4564039339836804d, y: 0.7123602043660269d), } },
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.6756820982304361d, y: 0.07169601024532946d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46405158280914693d, y: 0.8678739196568814d), } },
    ModelInner = new NpgsqlPointpointMArrayD21MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.42254877875905106d, y: 0.9922916217580039d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3299807348233935d, y: 0.6483815839114827d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.2106586971894424d, y: 0.13131859494744325d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5432677063801363d, y: 0.9593752320782779d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.19021938331000232d, y: 0.27848217559955024d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24054566906368102d, y: 0.25982093619485513d), } },
    ModelInner = new NpgsqlPointpointMArrayD21MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.4693051927468531d, y: 0.3450459794240873d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24538084150548345d, y: 0.48520229877577126d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.6490480787552118d, y: 0.5913514978470299d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03407004371150746d, y: 0.48591035500792235d), } },
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.31128329471399685d, y: 0.6726420825529946d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03444059824603629d, y: 0.26924677480514303d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.5325819655298916d, y: 0.852289375861564d),
new NpgsqlTypes.NpgsqlPoint(x: 0.167453528600509d, y: 0.9682635288972711d), } },
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.8965812240532283d, y: 0.5371691210967732d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9561873514048469d, y: 0.18875878801279256d), } },
    ModelInner = new NpgsqlPointpointMArrayD21MI
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.5336439209736445d, y: 0.7775765645218107d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7086066838017391d, y: 0.5490240830932975d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.6509280175532368d, y: 0.648519613315852d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8208756745290475d, y: 0.12477585351031872d), } },
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.7638193886750076d, y: 0.45309871053621475d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16885250951589115d, y: 0.7511274889551546d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.28889014551236236d, y: 0.06451752360261076d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6680758780826451d, y: 0.8686246731936947d), } },
    ModelInner = new NpgsqlPointpointMArrayD21MI
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.0835035112541116d, y: 0.3010605843206067d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22792288086369317d, y: 0.42773643421565233d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.493338233264093d, y: 0.4692668466716766d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4363069575751234d, y: 0.891437240376793d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.9925413216454473d, y: 0.6332561805734408d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3615931864807679d, y: 0.640086640593852d), } },
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 171,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.5901396058123415d, y: 0.4638691338997818d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6653362501646826d, y: 0.7779335521366827d), } },
    ModelInner = new NpgsqlPointpointMArrayD21MI
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.14257687038262534d, y: 0.525079326484233d),
new NpgsqlTypes.NpgsqlPoint(x: 0.35000722706012233d, y: 0.44928779587350653d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMArrayD2E1M
{
    Id = 178,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.22643681922766368d, y: 0.39803086036399604d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8229386149180644d, y: 0.9855609751236339d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.5553114637193083d, y: 0.853669230023792d),
new NpgsqlTypes.NpgsqlPoint(x: 0.18387319935685353d, y: 0.8944953056597562d), } },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmarrayd21mi(
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmarrayd21mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]), 
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

                changedRows =  ((INpgsqlPointMArraypointMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointMArraypointMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointMArraypointMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointMArraypointMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmarrayd21mi_id
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointmarrayd21mi_id", 
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
                changedRows =  ((INpgsqlPointMArraypointMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointMArraypointMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmarrayd21mi_id
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
    npgsqlpointpointmarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
                NpgsqlTypes.NpgsqlPoint[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlPointMArraypointMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.22498135291947607d, y: 0.8446197306893961d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6913133879087338d, y: 0.022425912414090643d), } }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlPointMArraypointMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.5774489213283442d, y: 0.5727499830505495d),
new NpgsqlTypes.NpgsqlPoint(x: 0.29850543016965847d, y: 0.6847475569340593d), } }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlPointMArraypointMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlPointMArraypointMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.9432988413153953d, y: 0.8528292491768674d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14353395228231292d, y: 0.9898755690544836d), } }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmarrayd21mi_id
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
    npgsqlpointpointmarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointmarrayd21mi_id", 
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
                NpgsqlTypes.NpgsqlPoint[,] nullable = null;
                nullable =  ((INpgsqlPointMArraypointMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPointMArraypointMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[,] nullable = null;
                nullable = await ((INpgsqlPointMArraypointMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[,] { {
new NpgsqlTypes.NpgsqlPoint(x: 0.697899637316338d, y: 0.626903978011537d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1447002322883475d, y: 0.7031578126021328d), } }));
                nullable = await ((INpgsqlPointMArraypointMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointMArrayD2E1M> models = null;

                models =  ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointMArrayD2E1M> models = null;

                models = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointMArraypointMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMArrayD2E1M), typeof(FlatNpgsqlPointpointMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                ((INpgsqlPointMArraypointMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointMArraypointMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointMArraypointMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmarrayd2e1m m
LEFT JOIN public.npgsqlpointpointmarrayd21mi mi ON mi.id = m.npgsqlpointpointmarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
                var models = await ((INpgsqlPointMArraypointMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointMArraypointMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMArrayD2E1M), typeof(FlatNpgsqlPointpointMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                ((INpgsqlPointMArraypointMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointMArraypointMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointMArraypointMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmarrayd2e1m m
LEFT JOIN public.npgsqlpointpointmarrayd21mi mi ON mi.id = m.npgsqlpointpointmarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
                var models = await ((INpgsqlPointMArraypointMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointMArraypointMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMArrayD2E1M), typeof(FlatNpgsqlPointpointMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                await((INpgsqlPointMArraypointMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 7;
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
FROM public.npgsqlpointpointmarrayd2e1m m
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 2;
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
FROM public.npgsqlpointpointmarrayd2e1m m
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
FROM public.npgsqlpointpointmarrayd2e1m m
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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
FROM public.npgsqlpointpointmarrayd2e1m m
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointMArraypointMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmarrayd2e1m m
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmarrayd2e1m m
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmarrayd2e1m m
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmarrayd2e1m m
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlpointpointmarrayd2e1m m
LEFT JOIN public.npgsqlpointpointmarrayd21mi mi ON mi.id = m.npgsqlpointpointmarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
                var models = await((INpgsqlPointMArraypointMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[31],_testData[34], false);
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
                var models = ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMArrayD2E1M), typeof(FlatNpgsqlPointpointMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                await((INpgsqlPointMArraypointMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmarrayd2e1m m
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 2, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlpointpointmarrayd2e1m m
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 146, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmarrayd2e1m m
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 18, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpointpointmarrayd2e1m m
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 25, query1, 91, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointMArraypointMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmarrayd2e1m m
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 56, query1, 126, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
FROM public.npgsqlpointpointmarrayd2e1m m
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 30, query1, 5, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmarrayd2e1m m
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 69, query1, 152, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(models[3],_testData[34], false);
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
FROM public.npgsqlpointpointmarrayd2e1m m
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
FROM public.npgsqlpointpointmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 152, query1, 146, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointMArrayD2E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlpointpointmarrayd2e1m m
LEFT JOIN public.npgsqlpointpointmarrayd21mi mi ON mi.id = m.npgsqlpointpointmarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
                var models = await((INpgsqlPointMArraypointMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 25, 85))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[17],_testData[34], false);
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
                var models = ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointMArraypointMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 130, 5))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPointpointMArrayD2E1M.AssertModel(models[32],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointMArraypointMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointMArraypointMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 151);
                var models = await ((INpgsqlPointMArraypointMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointMArraypointMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointMArraypointMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 18);
                var models =  ((INpgsqlPointMArraypointMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPointpointMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                NpgsqlPointpointMArrayD2E1M.AssertModel(models[29],_testData[34], false);
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
FROM public.binary_npgsqlpointpointmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMArrayD21MIWA),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMArrayD21MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointMArraypointMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMArrayD21MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointMArraypointMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMArrayD21MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointMArraypointMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMArrayD21MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointMArraypointMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmarrayd21mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMArrayD21MI),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMArrayD21MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointMArraypointMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMArrayD21MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointMArraypointMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMArrayD21MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMArrayD21MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointmarrayd21mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2))]
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
FROM public.binary_npgsqlpointpointmarrayd2e1m m
LEFT JOIN public.binary_npgsqlpointpointmarrayd21mi mi ON mi.id = m.npgsqlpointpointmarrayd21mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointMArraypointMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointMArraypointMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointmarrayd21mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
                var models =  ((INpgsqlPointMArraypointMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointMArraypointMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD21MIWA), typeof(NpgsqlPointpointMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
                var models1 = new List<NpgsqlPointpointMArrayD21MIWA>();
                var models2 = new List<NpgsqlPointpointMArrayD21MIWA>();
                await ((INpgsqlPointMArraypointMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMArrayD21MIWA>();
                var models2 = new List<NpgsqlPointpointMArrayD21MIWA>();
                ((INpgsqlPointMArraypointMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
                var models = await ((INpgsqlPointMArraypointMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointmarrayd21mi
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
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointmarrayd21mi
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
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD21MIWA), typeof(NpgsqlPointpointMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2))]
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
                var models1 = new List<NpgsqlPointpointMArrayD21MIWA>();
                var models2 = new List<NpgsqlPointpointMArrayD21MIWA>();
                await ((INpgsqlPointMArraypointMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMArrayD21MIWA>();
                var models2 = new List<NpgsqlPointpointMArrayD21MIWA>();
                ((INpgsqlPointMArraypointMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2))]
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
                var models = await ((INpgsqlPointMArraypointMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointmarrayd21mi
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
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointmarrayd21mi
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
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointmarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD21MI), typeof(NpgsqlPointpointMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
                var models1 = new List<NpgsqlPointpointMArrayD21MI>();
                var models2 = new List<NpgsqlPointpointMArrayD21MI>();
                await ((INpgsqlPointMArraypointMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMArrayD21MI>();
                var models2 = new List<NpgsqlPointpointMArrayD21MI>();
                ((INpgsqlPointMArraypointMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmarrayd21mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2)),
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
                var models = await ((INpgsqlPointMArraypointMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointmarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD21MIWA), typeof(NpgsqlPointpointMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2))]
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
                var models1 = new List<NpgsqlPointpointMArrayD21MIWA>();
                var models2 = new List<NpgsqlPointpointMArrayD21MIWA>();
                await ((INpgsqlPointMArraypointMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMArrayD21MIWA>();
                var models2 = new List<NpgsqlPointpointMArrayD21MIWA>();
                ((INpgsqlPointMArraypointMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmarrayd21mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMArrayD2))]
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
                var models = await ((INpgsqlPointMArraypointMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

