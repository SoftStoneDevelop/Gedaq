

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
    internal partial interface INpgsqlPointListpointArray
    {
    }
    
    internal partial class NpgsqlPointListpointArray : INpgsqlPointListpointArray
    {


#region TestData

        private readonly NpgsqlPointpointArray2M[] _testData = new NpgsqlPointpointArray2M[]
        {
            new NpgsqlPointpointArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9023920326468309d, y: 0.7087824097437191d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3683286047125679d, y: 0.6509475340919044d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6046064474999598d, y: 0.7944850804979888d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6090027599001933d, y: 0.9320592904366632d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6844879660875786d, y: 0.41733352128632417d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4756047650897879d, y: 0.862118755934025d),

new NpgsqlTypes.NpgsqlPoint(x: 0.679157207458795d, y: 0.02506401817930004d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11780723527082515d, y: 0.902665790294494d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20188625826368278d, y: 0.17297724853780794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.032454267782322965d, y: 0.2769335530517598d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41690334339909085d, y: 0.7042810483151678d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.060468126558637314d, y: 0.23123638055409168d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3694013499678612d, y: 0.9418820629240617d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26637340182680713d, y: 0.11273032837354091d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8580430525149876d, y: 0.5025099008643729d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5986735906149694d, y: 0.43123332760567346d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07757840119530823d, y: 0.45509124504359144d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3550846767745568d, y: 0.44647801720617575d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4544566173718635d, y: 0.27885569730593307d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6900694005129685d, y: 0.7350101331688478d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7847158834790952d, y: 0.7698157521962785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6277180440353718d, y: 0.4886136753435082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8122276537313513d, y: 0.9449533980071276d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5457402492252138d, y: 0.2442026773450794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.832211708669229d, y: 0.7037602737935263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8124401541530398d, y: 0.7487705934097065d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31870215039101113d, y: 0.995967522967186d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05138535343454731d, y: 0.8045296143842867d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15026879468796128d, y: 0.22810519589805733d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4414980510406973d, y: 0.5263941496979306d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5100713536138869d, y: 0.0985324964013109d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17411655852004393d, y: 0.16100345363033586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3541955701956616d, y: 0.2660404559790477d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4062420552231981d, y: 0.13561189311319444d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7312884496107541d, y: 0.7794636490247713d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47402797380134476d, y: 0.7618531465658073d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5683742579967979d, y: 0.5174116950232824d),

new NpgsqlTypes.NpgsqlPoint(x: 0.007931068257281959d, y: 0.30460932900506044d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.48315393092891057d, y: 0.32277623606089156d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6513264295974945d, y: 0.3086328365996478d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8772356286315797d, y: 0.1465782936200195d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4999979310291862d, y: 0.39090673129806974d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7566469347282374d, y: 0.9532446434990469d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6676024615855102d, y: 0.8259281638790948d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3586675765831532d, y: 0.9911964547956372d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9947302765170242d, y: 0.27915800812523794d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9728491964220797d, y: 0.32461374421147926d),

new NpgsqlTypes.NpgsqlPoint(x: 0.733387271902039d, y: 0.6957687677962235d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9197860387189594d, y: 0.6047751137125679d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3188847651694693d, y: 0.6335583594752933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9938485997222758d, y: 0.5611447042658553d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3563829270782025d, y: 0.8577178743438078d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.612073864343633d, y: 0.7574245294428826d),

new NpgsqlTypes.NpgsqlPoint(x: 0.773566816529263d, y: 0.5971017726851724d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28941117722472576d, y: 0.680862336754704d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5889954686353882d, y: 0.15245537247952978d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06050184908525302d, y: 0.2261875196528006d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9405597343775121d, y: 0.23926869384126215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6994347828262857d, y: 0.1562130369445065d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4271278014285981d, y: 0.03443191394417178d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8627600226074831d, y: 0.09894192312494332d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33290804004285035d, y: 0.268924040360184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2217480360618277d, y: 0.16679244476613897d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6208301637547917d, y: 0.8658958001855469d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9427563799999691d, y: 0.5111633229192573d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3897789658783256d, y: 0.0071832353695922d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7309981836122841d, y: 0.7026884252699303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13900720732809924d, y: 0.3086907843827311d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7422155332944275d, y: 0.4286004036058373d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22703056903420726d, y: 0.17991832607221758d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3561603683393163d, y: 0.5701551852304639d),

new NpgsqlTypes.NpgsqlPoint(x: 0.783492357009962d, y: 0.7168487114416363d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40601601607494964d, y: 0.5173601637647791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5222294337077085d, y: 0.019094696738941708d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05252149067106071d, y: 0.5627371541534476d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5342222777637322d, y: 0.7109946622396821d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5345309094668284d, y: 0.7904100754473627d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44408903036532377d, y: 0.7205131760304885d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4141044092591507d, y: 0.5678941856517142d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7264786750219162d, y: 0.2818150106583721d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3804906059860085d, y: 0.15190968120306947d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08473405988713822d, y: 0.1994790670983302d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3694432723181489d, y: 0.9892838304795656d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9297118522365966d, y: 0.39018081661167936d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7082374440117102d, y: 0.5635176808824134d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6741251991783882d, y: 0.058299209506847416d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8106354824298007d, y: 0.2865054179423482d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04054592683543479d, y: 0.34346974427803145d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.024501699275190636d, y: 0.8022438876547136d),

new NpgsqlTypes.NpgsqlPoint(x: 0.845208258584872d, y: 0.7954977215543422d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6841876480255702d, y: 0.08520390634738728d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1746076908122557d, y: 0.7055411834740389d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21755512709013825d, y: 0.500303013772096d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30343531727155104d, y: 0.9872883984725538d),

new NpgsqlTypes.NpgsqlPoint(x: 0.024431173264483186d, y: 0.062014359138731434d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4730902449602947d, y: 0.24348273512084795d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14569615257174562d, y: 0.9472036420112785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.925397719723735d, y: 0.0008661274016629195d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2855709798686601d, y: 0.1329261401341193d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5153989730955196d, y: 0.5022585394685827d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3225621230964013d, y: 0.5640967020273399d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7824053088250156d, y: 0.8514225792733987d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7363775318556729d, y: 0.9540074477008772d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6790583118424975d, y: 0.4962664176492012d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32003397620404694d, y: 0.8693893724811457d),

new NpgsqlTypes.NpgsqlPoint(x: 0.840277539677958d, y: 0.643845075680328d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9393883848361477d, y: 0.9749330650499445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6337784704694958d, y: 0.6611719419017454d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3465148063876594d, y: 0.7015239441065274d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6010337277287084d, y: 0.7067794758407326d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38155598346697406d, y: 0.03216620468232401d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5211407825943662d, y: 0.03172296437501598d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05041832234836752d, y: 0.1906831558011256d),

new NpgsqlTypes.NpgsqlPoint(x: 0.013250416992712344d, y: 0.9200916991501118d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17397749812448504d, y: 0.5474262819615623d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6185465954191551d, y: 0.060853258575088165d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7135743568219183d, y: 0.9533863895116587d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7005592097377324d, y: 0.4025249695346025d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9699522336338301d, y: 0.35525821570765914d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26588919723867677d, y: 0.6647344155324405d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08969855492160728d, y: 0.0773905148700168d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3391284588763386d, y: 0.8798072712868695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8682150314181518d, y: 0.564069334595821d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4843627126392306d, y: 0.8445555369839225d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24731437201940543d, y: 0.11273182550589622d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8904972435296026d, y: 0.3460388876866851d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22063104006476442d, y: 0.7400122363986471d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6145362286471764d, y: 0.5905110659699851d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12376069843279558d, y: 0.1399426154792247d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7725331124479579d, y: 0.743015437651434d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4471209720765009d, y: 0.24580807176076225d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.743095677895697d, y: 0.5640428773641974d),

new NpgsqlTypes.NpgsqlPoint(x: 0.77028178245929d, y: 0.9356224980010973d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12382234120314284d, y: 0.12553608195041677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5948745755221786d, y: 0.049097370275446806d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9630574359231857d, y: 0.7089241601659043d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47866124467560067d, y: 0.392267136305283d),

new NpgsqlTypes.NpgsqlPoint(x: 0.500307563349606d, y: 0.8835624201154869d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7987076461812902d, y: 0.7680067558746655d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5345091020903074d, y: 0.31787871530753165d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9116035626842983d, y: 0.11584492290962989d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4343670164263316d, y: 0.01217635610989487d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6075440701587528d, y: 0.054903674027519944d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7863491668658289d, y: 0.5599698726274458d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7822847367917626d, y: 0.37583782421064293d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06412951967113611d, y: 0.8551551543302227d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7069018103631363d, y: 0.022571652512802576d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28997406457855734d, y: 0.20771178336758145d),

new NpgsqlTypes.NpgsqlPoint(x: 0.493981736425707d, y: 0.9967863517943906d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5248826705430656d, y: 0.5487325923781065d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17283891188290823d, y: 0.9603234989830541d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6919063912998437d, y: 0.8893108872332685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19423154505453144d, y: 0.6255799724387482d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4824495394595414d, y: 0.8561095838674524d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7008758377693629d, y: 0.6245103380941667d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6026348114984985d, y: 0.7290692424072599d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09669828980561845d, y: 0.49890408644722617d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21932424106018422d, y: 0.9191989143447363d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6404676779728204d, y: 0.4512913897988625d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12067016776730866d, y: 0.6126589827445901d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28859641155607574d, y: 0.23425849952555733d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5178784351379998d, y: 0.299615125389749d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3830770475675489d, y: 0.7762025914003837d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10059089188467307d, y: 0.559245857583228d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31471912730856344d, y: 0.46889375176373027d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26732108907059826d, y: 0.22875835635729536d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5341281910085051d, y: 0.38181801845465324d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9818185870566535d, y: 0.7908991990348156d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02646030998303628d, y: 0.7971470136747092d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3788836280848731d, y: 0.5156403818598775d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17501183184669067d, y: 0.48639914370883663d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36444102729426076d, y: 0.9159103157623845d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8901428180527613d, y: 0.6916373311980001d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6142111856426586d, y: 0.696334895605443d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07913935229166769d, y: 0.7430317324981601d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4873237458380031d, y: 0.8726851566131877d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10434187419342444d, y: 0.3454225734375952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9129243854704377d, y: 0.5293062555544863d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.659437926826609d, y: 0.3688827075200477d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7160262100268124d, y: 0.3285578169493544d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8768967563395141d, y: 0.26682190836932274d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7065362422253316d, y: 0.8484733617025032d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6568153501240338d, y: 0.3722224544432807d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5751951701893796d, y: 0.6639328579811691d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8371301967657727d, y: 0.9770629563349591d),

new NpgsqlTypes.NpgsqlPoint(x: 0.029297936555807813d, y: 0.7722003784545485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6596567840080058d, y: 0.03403828631253525d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46940674867369425d, y: 0.6692977701511051d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8981405721207211d, y: 0.028649953496775682d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6995264065469082d, y: 0.8165502249719657d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41602303734629875d, y: 0.8052360017342494d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06036806491898428d, y: 0.7240795486200431d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8583014897558715d, y: 0.7148280496910314d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6571930858418592d, y: 0.40908162938433534d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.583803596784575d, y: 0.39779434332552066d),

new NpgsqlTypes.NpgsqlPoint(x: 0.021609084628404607d, y: 0.18092042777141037d),

new NpgsqlTypes.NpgsqlPoint(x: 0.507593886381614d, y: 0.8933293548294791d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29086586574111095d, y: 0.7743258884539004d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8037095092575057d, y: 0.6033266304990139d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8114311613161656d, y: 0.0965864966427269d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7159198098161672d, y: 0.2699759631147918d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12342563253810412d, y: 0.08213982378540874d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04583030125870158d, y: 0.20400450932540815d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3993165017047583d, y: 0.7163472837159351d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8978123150545783d, y: 0.2992985135688263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3970157197728881d, y: 0.4418432405837355d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23877673966971047d, y: 0.7741297119336875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32346785217548735d, y: 0.663686590790081d),

new NpgsqlTypes.NpgsqlPoint(x: 0.76269232566422d, y: 0.12499063306620006d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22934631999171018d, y: 0.32497100256909817d),

new NpgsqlTypes.NpgsqlPoint(x: 0.013205652767006915d, y: 0.3426511225728801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5597087789539955d, y: 0.5100906882756939d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1314527082534762d, y: 0.506312360125833d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5194273622556985d, y: 0.03016234836004228d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41242624687863483d, y: 0.4982506149029443d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9510107541556141d, y: 0.9329892287093641d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4153808277252452d, y: 0.756497325998735d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12005741431130101d, y: 0.9984619108857293d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5408028295792209d, y: 0.18484910882047356d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4520547277102782d, y: 0.9694110342007449d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.692088121652148d, y: 0.4801360702233347d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1693227261765503d, y: 0.9823896336884484d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02545579039684842d, y: 0.9778756965135854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9734563839832323d, y: 0.42199669520690586d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10740420910505788d, y: 0.22973103053080335d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8125897521163505d, y: 0.8301015904795574d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28340850366380244d, y: 0.849737049621093d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4507137457505437d, y: 0.0863875433546647d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5876452486039385d, y: 0.1400987460762967d),

new NpgsqlTypes.NpgsqlPoint(x: 0.006159725791885173d, y: 0.53480116410182d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14615659268098635d, y: 0.5293255175915498d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2740583885504805d, y: 0.7253496663381981d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8599435948016392d, y: 0.9515705948937223d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19413784909693932d, y: 0.9078411418792838d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04110582818315356d, y: 0.9343318435634145d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7890869104499113d, y: 0.5509563128506895d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7147289377334498d, y: 0.9524850875283045d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47454111948118827d, y: 0.2387236772993815d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04803008037694789d, y: 0.5213238459190477d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7752312142410082d, y: 0.27650740117325767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9762808140262145d, y: 0.09171074166114912d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6393230658182718d, y: 0.28809291009308824d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16923515545067758d, y: 0.5246449262967078d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6018908700138765d, y: 0.9409756783019506d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2179882586894809d, y: 0.08767101805543187d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8982517111410313d, y: 0.11509689854336325d),

new NpgsqlTypes.NpgsqlPoint(x: 0.315396370129985d, y: 0.7200872973075686d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8980396976564867d, y: 0.7381068146380938d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07720910016474036d, y: 0.21690427864604767d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17771945831199942d, y: 0.1030162903887809d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3493281811827591d, y: 0.7029240604371415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7105823349254898d, y: 0.47653907480049396d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6465043006760672d, y: 0.21884547644169317d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0010741068791776387d, y: 0.12800474205692958d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.544439132747125d, y: 0.9032480410008614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08701705847491459d, y: 0.9845918719874848d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14514671463656714d, y: 0.14533460257464037d),

new NpgsqlTypes.NpgsqlPoint(x: 0.005570349212734027d, y: 0.3021640092806911d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29987070914749003d, y: 0.016984317839869756d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40501534389177496d, y: 0.6051254393865112d),

new NpgsqlTypes.NpgsqlPoint(x: 0.678762760621907d, y: 0.1997618814164145d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8499710513213125d, y: 0.2502647773222606d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4275380730869791d, y: 0.4018997856453258d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5803029905738795d, y: 0.1781729606036201d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6571220499875489d, y: 0.8455682826254126d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6193202554966066d, y: 0.11298484180801738d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8125739598362838d, y: 0.6732335454367123d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4459410178943879d, y: 0.404046140376786d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8206774681074555d, y: 0.028790821014623935d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47933795091093456d, y: 0.8236534889458371d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9734053125461538d, y: 0.38625576798748396d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08462982830676546d, y: 0.26059323425960823d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9746042140081581d, y: 0.8536510692536199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42579323177150386d, y: 0.6368537181782352d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5758141716192251d, y: 0.09642880032631818d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9957323506358712d, y: 0.35286083964217974d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8058511965566708d, y: 0.11592416824308882d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.360651988977157d, y: 0.14153737205623718d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5689078823644266d, y: 0.138105478693355d),

new NpgsqlTypes.NpgsqlPoint(x: 0.006271679770712524d, y: 0.5142729616131505d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2200623704396668d, y: 0.17582488740508628d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8772706490635198d, y: 0.7357805940889479d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9089819453600775d, y: 0.7987719690719127d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6128802471291601d, y: 0.0031810331752871734d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.35494539907911604d, y: 0.9447341827777502d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25573950996282857d, y: 0.2752609755720843d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4207858856686306d, y: 0.8877577963255566d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5920731844794603d, y: 0.4411797330299755d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.30157796519550484d, y: 0.2952916168440801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.060558861104965d, y: 0.9834497756296022d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1981661478159793d, y: 0.529061233206216d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2mi(
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
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

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointListpointArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointListpointArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
            asPartInterface: typeof(INpgsqlPointListpointArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray2mi_id", 
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
                changedRows =  ((INpgsqlPointListpointArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointListpointArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray2M> models = null;

                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray2M> models = null;

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointListpointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointListpointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 147;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 29;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 149;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[34], false);
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
                var models = ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 12, query1, 19, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 160, query1, 149, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 144, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 124, query1, 60, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 147, query1, 94, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 19, query1, 30, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 147, query1, 106, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 8, query1, 14, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await((INpgsqlPointListpointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 15, 19))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[28],_testData[34], false);
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
                var models = ((INpgsqlPointListpointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatch(connection, 156, 137))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 14);
                var models = await ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[3], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[4], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[5], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[6], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[7], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[8], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[9], false);
                NpgsqlPointpointArray2M.AssertModel(models[7],_testData[10], false);
                NpgsqlPointpointArray2M.AssertModel(models[8],_testData[11], false);
                NpgsqlPointpointArray2M.AssertModel(models[9],_testData[12], false);
                NpgsqlPointpointArray2M.AssertModel(models[10],_testData[13], false);
                NpgsqlPointpointArray2M.AssertModel(models[11],_testData[14], false);
                NpgsqlPointpointArray2M.AssertModel(models[12],_testData[15], false);
                NpgsqlPointpointArray2M.AssertModel(models[13],_testData[16], false);
                NpgsqlPointpointArray2M.AssertModel(models[14],_testData[17], false);
                NpgsqlPointpointArray2M.AssertModel(models[15],_testData[18], false);
                NpgsqlPointpointArray2M.AssertModel(models[16],_testData[19], false);
                NpgsqlPointpointArray2M.AssertModel(models[17],_testData[20], false);
                NpgsqlPointpointArray2M.AssertModel(models[18],_testData[21], false);
                NpgsqlPointpointArray2M.AssertModel(models[19],_testData[22], false);
                NpgsqlPointpointArray2M.AssertModel(models[20],_testData[23], false);
                NpgsqlPointpointArray2M.AssertModel(models[21],_testData[24], false);
                NpgsqlPointpointArray2M.AssertModel(models[22],_testData[25], false);
                NpgsqlPointpointArray2M.AssertModel(models[23],_testData[26], false);
                NpgsqlPointpointArray2M.AssertModel(models[24],_testData[27], false);
                NpgsqlPointpointArray2M.AssertModel(models[25],_testData[28], false);
                NpgsqlPointpointArray2M.AssertModel(models[26],_testData[29], false);
                NpgsqlPointpointArray2M.AssertModel(models[27],_testData[30], false);
                NpgsqlPointpointArray2M.AssertModel(models[28],_testData[31], false);
                NpgsqlPointpointArray2M.AssertModel(models[29],_testData[32], false);
                NpgsqlPointpointArray2M.AssertModel(models[30],_testData[33], false);
                NpgsqlPointpointArray2M.AssertModel(models[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 94);
                var models =  ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[20], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[21], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[22], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[23], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[24], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[25], false);
                NpgsqlPointpointArray2M.AssertModel(models[7],_testData[26], false);
                NpgsqlPointpointArray2M.AssertModel(models[8],_testData[27], false);
                NpgsqlPointpointArray2M.AssertModel(models[9],_testData[28], false);
                NpgsqlPointpointArray2M.AssertModel(models[10],_testData[29], false);
                NpgsqlPointpointArray2M.AssertModel(models[11],_testData[30], false);
                NpgsqlPointpointArray2M.AssertModel(models[12],_testData[31], false);
                NpgsqlPointpointArray2M.AssertModel(models[13],_testData[32], false);
                NpgsqlPointpointArray2M.AssertModel(models[14],_testData[33], false);
                NpgsqlPointpointArray2M.AssertModel(models[15],_testData[34], false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MI),
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointArray2M),
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
FROM public.binary_npgsqlpointpointarray2m m
LEFT JOIN public.binary_npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models =  ((INpgsqlPointListpointArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models = await ((INpgsqlPointListpointArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI), typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models1 = new List<NpgsqlPointpointArray2MI>();
                var models2 = new List<NpgsqlPointpointArray2MI>();
                await ((INpgsqlPointListpointArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MI>();
                var models2 = new List<NpgsqlPointpointArray2MI>();
                ((INpgsqlPointListpointArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models = await ((INpgsqlPointListpointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

