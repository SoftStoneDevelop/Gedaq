

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
    internal partial interface INpgsqlPointArraypointArray
    {
    }
    
    internal partial class NpgsqlPointArraypointArray : INpgsqlPointArraypointArray
    {


#region TestData

        private readonly NpgsqlPointpointArray1M[] _testData = new NpgsqlPointpointArray1M[]
        {
            new NpgsqlPointpointArray1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12269652061395075d, y: 0.2287140481404334d),
new NpgsqlTypes.NpgsqlPoint(x: 0.531344880235548d, y: 0.8227767186244244d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43290933835867706d, y: 0.6558477607159927d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5835945547077613d, y: 0.41822621355602496d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7296044963595895d, y: 0.2043496028787204d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7974158281292779d, y: 0.3487242978806363d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11883338414519695d, y: 0.923593986899266d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7581097540165336d, y: 0.0759523495590746d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08369564128420537d, y: 0.1074380591945725d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5525468759641313d, y: 0.5461789356023965d),
new NpgsqlTypes.NpgsqlPoint(x: 0.255747337950906d, y: 0.604642472347215d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3993101643520405d, y: 0.9071057587157888d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49100371992975655d, y: 0.5273441700422312d),
new NpgsqlTypes.NpgsqlPoint(x: 0.33270716023248725d, y: 0.4539164167773797d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9481258400848965d, y: 0.7507516004454357d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06950390536525453d, y: 0.12746921562973945d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7586389812286485d, y: 0.5878523922146502d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46878436674951185d, y: 0.3068815071257349d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3664538059666814d, y: 0.5157635600062509d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16561898432706634d, y: 0.8408913927325208d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4731287688011623d, y: 0.18399558477749367d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14125913775416277d, y: 0.45036393830337385d),
new NpgsqlTypes.NpgsqlPoint(x: 0.981151214737707d, y: 0.963744957634131d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3783379965667728d, y: 0.5200363191207062d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0411042349719658d, y: 0.7404277441873767d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3558414351874909d, y: 0.12102290406674654d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3410998784966468d, y: 0.9747944175791902d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4845794082582826d, y: 0.152055977123555d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9183829948054486d, y: 0.6355376329366277d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3794934456397029d, y: 0.8066124156709389d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7104655338193712d, y: 0.6141561105098354d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06268235771002273d, y: 0.5182427420720893d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17677747004714794d, y: 0.061985163679477484d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4133257348750433d, y: 0.3497528972364554d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.012681426589028821d, y: 0.816252105751079d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9878088669340915d, y: 0.844420747979937d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15295248685001472d, y: 0.09470483775629979d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0899852708401574d, y: 0.7786594030905106d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7549287919855858d, y: 0.647730473564788d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4063358096563153d, y: 0.11164012760608921d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32968467175895155d, y: 0.6268697899839675d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5968049248664821d, y: 0.019731666873855525d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8372508547094053d, y: 0.7523655688782818d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3261853201513214d, y: 0.04828234301786316d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14520692081938813d, y: 0.27702579438671016d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22163505838805164d, y: 0.4447010006362021d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7334835332661876d, y: 0.025138688689517852d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4908483740653361d, y: 0.012431835433920124d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7775762816085894d, y: 0.6016739690766196d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8786410240579993d, y: 0.8558319887144213d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32959492044618477d, y: 0.1735738762213921d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3109349661169246d, y: 0.9997421805259372d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32953276529095754d, y: 0.11077540141197173d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07253837850465505d, y: 0.5433234154452039d),
new NpgsqlTypes.NpgsqlPoint(x: 0.45312174468440525d, y: 0.7195369240200201d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8487465061104689d, y: 0.6709845130121436d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4996890231016714d, y: 0.36266531024282656d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9603332663175829d, y: 0.9334529445813302d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14861998062612758d, y: 0.9807495293909423d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.28838637502562103d, y: 0.24318659398318865d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5285656475031624d, y: 0.9785292994794521d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6150418380383708d, y: 0.22494663569538087d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.016188883732819903d, y: 0.5290128393306759d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8929941322278597d, y: 0.3953136303998638d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7491321235791998d, y: 0.24645940283523005d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5238067604609636d, y: 0.2966703240361195d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7676850746788655d, y: 0.6517956626195095d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1736405280083847d, y: 0.9092132678807983d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7794740566925886d, y: 0.7216682876302624d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24898850254771598d, y: 0.6718823441032162d),
new NpgsqlTypes.NpgsqlPoint(x: 0.151053926438261d, y: 0.48078626382359435d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5996667729166075d, y: 0.26174554129713345d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5192534806874229d, y: 0.8811965574957202d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9393631998390324d, y: 0.4482721998918745d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2614475730465611d, y: 0.08664421271852585d),
new NpgsqlTypes.NpgsqlPoint(x: 0.765547872847263d, y: 0.739254685853526d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2073523721419266d, y: 0.8431611171381828d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17808851295496653d, y: 0.7654895419969289d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8213548932252519d, y: 0.898297691005164d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3669341329293516d, y: 0.36906227906974d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16765091474538596d, y: 0.3595206057315321d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7935639189478844d, y: 0.6876043742237437d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8015800625118161d, y: 0.7473297421074612d),
new NpgsqlTypes.NpgsqlPoint(x: 0.059212951357100585d, y: 0.22691429110770556d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9797310546323144d, y: 0.19488204972776535d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6141201278345501d, y: 0.002433197169128265d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8061627250491149d, y: 0.5213167512665962d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.27303816929780544d, y: 0.24434922995976194d),
new NpgsqlTypes.NpgsqlPoint(x: 0.38616794777253116d, y: 0.9744315978007216d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3109531998816788d, y: 0.1020933068553348d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8135979671253838d, y: 0.02813266521312141d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3372475171119389d, y: 0.5732079524508877d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9431148989108413d, y: 0.6923796511293547d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06264845605849756d, y: 0.467206390592525d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15474082269265854d, y: 0.006282152035780086d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17671433338822518d, y: 0.13990313337718085d),
new NpgsqlTypes.NpgsqlPoint(x: 0.708733764621054d, y: 0.1979301730695604d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7167971698749864d, y: 0.6865579255572141d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1951806400296302d, y: 0.6796181393412767d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8895137001595531d, y: 0.9388499477279206d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6643686814522468d, y: 0.43613597378084845d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.712621406113183d, y: 0.00910824752478212d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9608122465424619d, y: 0.9749152376548722d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5032951153867293d, y: 0.7594748670204817d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3299514420967521d, y: 0.4201883973162216d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.27328624199041507d, y: 0.0885370328807964d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15654339659902972d, y: 0.7863340245237112d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3044837247241774d, y: 0.6745394674662798d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09496901016438741d, y: 0.14106452298770622d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9712925342809958d, y: 0.47058294438975534d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22299358806206904d, y: 0.6669291855576703d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2125063837324741d, y: 0.7697650199920777d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.28008434541752936d, y: 0.14945219759882622d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8615909156685719d, y: 0.6058775535511532d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8520132025098308d, y: 0.23441110413471777d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20740633153363175d, y: 0.28610369173788075d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21563312999262196d, y: 0.36426275918930406d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03898576248658858d, y: 0.4203086384216548d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0069472306283890894d, y: 0.45775128821506383d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6556787876280386d, y: 0.45468176930456883d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9338968670960054d, y: 0.2467358355515451d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7412868887506346d, y: 0.6257612442169984d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7846436310986926d, y: 0.05535901874706828d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9618391102335968d, y: 0.4971233105166295d),
new NpgsqlTypes.NpgsqlPoint(x: 0.44758950061536995d, y: 0.8243422526662483d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6514027886390669d, y: 0.043232809680605166d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49622753486057847d, y: 0.7276104445935782d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3304490738451199d, y: 0.30498175999824684d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5348583480310484d, y: 0.35017943857451217d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3918322406375587d, y: 0.4422168601331995d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5210179345451211d, y: 0.7387906426796192d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23159453414848452d, y: 0.7808425072831268d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7760969295087052d, y: 0.5824291120175773d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46266017343454624d, y: 0.5811680854442047d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9452576541829071d, y: 0.9798978907810938d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4541183551850061d, y: 0.009960010596433255d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3121131701718246d, y: 0.8291968388414215d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8116896142251887d, y: 0.10351978733815381d),
new NpgsqlTypes.NpgsqlPoint(x: 0.23483004634477378d, y: 0.20506348956767706d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10133351950215097d, y: 0.3953251280491159d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.970323918373754d, y: 0.08455999069819609d),
new NpgsqlTypes.NpgsqlPoint(x: 0.057367133978558416d, y: 0.8536749248253795d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5079128463424776d, y: 0.2540562671290084d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6791319947699178d, y: 0.0356518276330976d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09333177224781952d, y: 0.1060406581063561d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9775588557414651d, y: 0.4482159626582126d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8803597586473864d, y: 0.3032365009765132d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8537743696133784d, y: 0.4094382709773392d),
new NpgsqlTypes.NpgsqlPoint(x: 0.44628901935293297d, y: 0.04631117025370579d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9153119974099166d, y: 0.05814671328195198d),
new NpgsqlTypes.NpgsqlPoint(x: 0.033832749709269416d, y: 0.476875128003477d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.592194208859031d, y: 0.6486840170368524d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6924481799273609d, y: 0.3517421549320725d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3670841943201404d, y: 0.006965490617567127d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7848405668156566d, y: 0.7200429439477323d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8101381194469822d, y: 0.9240106827656347d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22587549481043578d, y: 0.1373296860201616d),
new NpgsqlTypes.NpgsqlPoint(x: 0.526209735338928d, y: 0.7455666817183658d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3455511095984005d, y: 0.030571123354268814d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6095243191739395d, y: 0.5606905517381938d),
new NpgsqlTypes.NpgsqlPoint(x: 0.27892614462583787d, y: 0.5624723400699879d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7391794348241445d, y: 0.2158264312411453d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.30220394791292404d, y: 0.06593673166812919d),
new NpgsqlTypes.NpgsqlPoint(x: 0.015168715565107793d, y: 0.43783504696630304d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5174355799796827d, y: 0.8537648458159116d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5535189166447204d, y: 0.7463257602277423d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7178914116002216d, y: 0.8813289842202093d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3197842887918957d, y: 0.791991217915109d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.42498283829805994d, y: 0.39838628542412213d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3617985729751029d, y: 0.6332232670897542d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5670436116972212d, y: 0.6791249333830762d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7122668099956115d, y: 0.14496674266135456d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6978555673917535d, y: 0.5029476199016467d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8855296140040437d, y: 0.7194849810149623d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22188347653808105d, y: 0.22438340828749115d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5033947475081892d, y: 0.07680603705366484d),
new NpgsqlTypes.NpgsqlPoint(x: 0.173412461787106d, y: 0.21214198543665408d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4263209334772128d, y: 0.9791888991427459d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1154451404782516d, y: 0.4947632743901659d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3062419890359358d, y: 0.9809123481222685d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0980657404949471d, y: 0.7346280656930383d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06617028787130297d, y: 0.4120470210123208d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1829568634193115d, y: 0.20575999009762258d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8030495889528831d, y: 0.784827135168301d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1067914340424827d, y: 0.4186586305633425d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7382249066870463d, y: 0.9619909940718958d),
new NpgsqlTypes.NpgsqlPoint(x: 0.046535721783632855d, y: 0.2931656982495153d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9494424054147826d, y: 0.2549856720509289d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6782150422222479d, y: 0.15746474998186621d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3335729144898283d, y: 0.4316183598039993d),
new NpgsqlTypes.NpgsqlPoint(x: 0.33681482031966936d, y: 0.28518779814077244d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2034429664771621d, y: 0.708023159397492d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5528988744719221d, y: 0.09149706028860083d),
new NpgsqlTypes.NpgsqlPoint(x: 0.41617840885991875d, y: 0.2777199959796627d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7662922679978535d, y: 0.2510871245858889d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3135014627707865d, y: 0.9193408743177071d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10254016345785055d, y: 0.5075593785522946d),
new NpgsqlTypes.NpgsqlPoint(x: 0.51873387141504d, y: 0.10018154036590632d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5940411803540284d, y: 0.9577121687230785d),
new NpgsqlTypes.NpgsqlPoint(x: 0.635462804284181d, y: 0.04400856794635222d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7229692064656d, y: 0.9891715058291102d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5976691798487246d, y: 0.2612055244572036d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6822298800017764d, y: 0.14497573247528328d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09952184514436746d, y: 0.4749589713429333d),
new NpgsqlTypes.NpgsqlPoint(x: 0.973744100057867d, y: 0.8227496659893777d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6044042522482121d, y: 0.5999497214170068d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32968395931106353d, y: 0.906206592207285d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4034350569299636d, y: 0.41112743287035525d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1522804514497681d, y: 0.07323477283702984d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7239403943875289d, y: 0.7153729566335999d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9399934685776511d, y: 0.28347653799053785d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.055317630772453d, y: 0.9051182963871733d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15372266967407278d, y: 0.09252298057993902d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9889868697167321d, y: 0.8470669076699276d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5710863074930781d, y: 0.1456269926561098d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3895904844139444d, y: 0.30079315075078317d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8596828327522262d, y: 0.21151913548863954d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21237252042584653d, y: 0.31191481383130737d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.052466243060290685d, y: 0.23403148755426695d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6192995873908028d, y: 0.6592778212056485d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6982648094203712d, y: 0.034319697226345314d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13281467653162105d, y: 0.7080037908911033d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7913064054427835d, y: 0.20601294469430909d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6757810937063006d, y: 0.2250305449935346d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8208490242504284d, y: 0.7786707221214734d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6828337188566599d, y: 0.5118387058223834d),
new NpgsqlTypes.NpgsqlPoint(x: 0.596528093564391d, y: 0.5340962321263156d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08944992894833259d, y: 0.8112667126457918d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4257711833848823d, y: 0.40076716288570313d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5498689378099227d, y: 0.18290923675169712d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4833038319837478d, y: 0.4763994575736963d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40889447213594377d, y: 0.8975027361273326d),
new NpgsqlTypes.NpgsqlPoint(x: 0.18203378017881355d, y: 0.3116519791372636d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21175868076177295d, y: 0.8441814354037d),
new NpgsqlTypes.NpgsqlPoint(x: 0.38344733196537983d, y: 0.8702791397658787d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 172,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13303823786787417d, y: 0.2391488447028608d),
new NpgsqlTypes.NpgsqlPoint(x: 0.456109227223235d, y: 0.16342121043287205d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05342231905514072d, y: 0.5469140275315718d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5391831783827068d, y: 0.7137406601380308d),
new NpgsqlTypes.NpgsqlPoint(x: 0.766876790448426d, y: 0.7023672981297614d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4820658838761308d, y: 0.4879563994030155d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8823367365689605d, y: 0.5661153071675137d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5251425095984499d, y: 0.7766862002842088d),
new NpgsqlTypes.NpgsqlPoint(x: 0.893253115890776d, y: 0.3173662043696488d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5342372424478831d, y: 0.330108197852773d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 176,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5158141534503703d, y: 0.6886415645052059d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1941418871776417d, y: 0.802778693194749d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5963776660198251d, y: 0.14905326424253795d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 178,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9144073924065825d, y: 0.04266971691845356d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05145319795905112d, y: 0.019078065773063924d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7165637693195382d, y: 0.42425659048031406d),
new NpgsqlTypes.NpgsqlPoint(x: 0.29396878344317634d, y: 0.9299279428256413d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.629787035176014d, y: 0.32645117245126354d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16475536474480168d, y: 0.10958151971197616d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0524421465568341d, y: 0.3797142063876402d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25131407243158077d, y: 0.10919514392177321d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 184,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7915682454357231d, y: 0.8964359664505804d),
new NpgsqlTypes.NpgsqlPoint(x: 0.43711217902123967d, y: 0.17867994022515798d),
new NpgsqlTypes.NpgsqlPoint(x: 0.609209209750798d, y: 0.32392240115977766d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6906683147415823d, y: 0.3085884618046557d),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
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

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
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
                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5968049248664821d, y: 0.019731666873855525d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8372508547094053d, y: 0.7523655688782818d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3261853201513214d, y: 0.04828234301786316d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14520692081938813d, y: 0.27702579438671016d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8135979671253838d, y: 0.02813266521312141d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3372475171119389d, y: 0.5732079524508877d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9431148989108413d, y: 0.6923796511293547d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06264845605849756d, y: 0.467206390592525d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;

                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointArraypointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointArraypointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 163;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 48;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[31],_testData[34], false);
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
                parametr2.Value = 37;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 136;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[34], false);
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
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 67, query1, 60, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 113, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 23, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 31, query1, 163, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 26, query1, 123, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 172, query1, 67, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 50, query1, 176, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 7, query1, 80, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 31, 7))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[33],_testData[34], false);
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
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatch(connection, 37, 56))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 80);
                var models = await ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[17], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[18], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[19], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[20], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[21], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[22], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[23], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[24], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[25], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[26], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[27], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[28], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[29], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[30], false);
                NpgsqlPointpointArray1M.AssertModel(models[15],_testData[31], false);
                NpgsqlPointpointArray1M.AssertModel(models[16],_testData[32], false);
                NpgsqlPointpointArray1M.AssertModel(models[17],_testData[33], false);
                NpgsqlPointpointArray1M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 37);
                var models =  ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[14], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[15], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[16], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[17], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[18], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[19], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[20], false);
                NpgsqlPointpointArray1M.AssertModel(models[15],_testData[21], false);
                NpgsqlPointpointArray1M.AssertModel(models[16],_testData[22], false);
                NpgsqlPointpointArray1M.AssertModel(models[17],_testData[23], false);
                NpgsqlPointpointArray1M.AssertModel(models[18],_testData[24], false);
                NpgsqlPointpointArray1M.AssertModel(models[19],_testData[25], false);
                NpgsqlPointpointArray1M.AssertModel(models[20],_testData[26], false);
                NpgsqlPointpointArray1M.AssertModel(models[21],_testData[27], false);
                NpgsqlPointpointArray1M.AssertModel(models[22],_testData[28], false);
                NpgsqlPointpointArray1M.AssertModel(models[23],_testData[29], false);
                NpgsqlPointpointArray1M.AssertModel(models[24],_testData[30], false);
                NpgsqlPointpointArray1M.AssertModel(models[25],_testData[31], false);
                NpgsqlPointpointArray1M.AssertModel(models[26],_testData[32], false);
                NpgsqlPointpointArray1M.AssertModel(models[27],_testData[33], false);
                NpgsqlPointpointArray1M.AssertModel(models[28],_testData[34], false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MIWA),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointArraypointArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointArraypointArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointArraypointArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointArraypointArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointArraypointArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MI),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointArraypointArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointArraypointArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointArraypointArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointArraypointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointArray1M),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
FROM public.binary_npgsqlpointpointarray1m m
LEFT JOIN public.binary_npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointArraypointArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointArraypointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointArraypointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models =  ((INpgsqlPointArraypointArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA), typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                await ((INpgsqlPointArraypointArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                ((INpgsqlPointArraypointArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA), typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                await ((INpgsqlPointArraypointArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                ((INpgsqlPointArraypointArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models = await ((INpgsqlPointArraypointArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray1mi
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
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI), typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models1 = new List<NpgsqlPointpointArray1MI>();
                var models2 = new List<NpgsqlPointpointArray1MI>();
                await ((INpgsqlPointArraypointArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MI>();
                var models2 = new List<NpgsqlPointpointArray1MI>();
                ((INpgsqlPointArraypointArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA), typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                await ((INpgsqlPointArraypointArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray1MIWA>();
                var models2 = new List<NpgsqlPointpointArray1MIWA>();
                ((INpgsqlPointArraypointArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointArraypointArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

