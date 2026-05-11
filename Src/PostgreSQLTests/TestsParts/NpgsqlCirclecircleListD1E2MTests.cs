

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
    internal partial interface INpgsqlCircleListcircleListD1
    {
    }
    
    internal partial class NpgsqlCircleListcircleListD1 : INpgsqlCircleListcircleListD1
    {


#region TestData

        private readonly NpgsqlCirclecircleListD1E2M[] _testData = new NpgsqlCirclecircleListD1E2M[]
        {
            new NpgsqlCirclecircleListD1E2M
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.304784783627406d, y: 0.4367251795062037d), radius: 0.7434283887266555d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7597605681572314d, y: 0.24104161112495603d), radius: 0.4487174684476516d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6090102243535678d, y: 0.7654885237344483d), radius: 0.9425900825666009d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9808804695762071d, y: 0.42108128648734844d), radius: 0.9437172734200183d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5381052216424201d, y: 0.5878737470100446d), radius: 0.8618488740254514d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8600009202190254d, y: 0.7728577099011851d), radius: 0.1468093093992876d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14831159952528838d, y: 0.014488769759556597d), radius: 0.030161880402838737d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3320075074065555d, y: 0.7397000992688794d), radius: 0.6764015790859315d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4648651636726153d, y: 0.18589639618627984d), radius: 0.24955695497314667d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6227870558249498d, y: 0.3967288816949245d), radius: 0.7501703094648026d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2476637730029536d, y: 0.18729853151008846d), radius: 0.7088026603423754d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3674212173260164d, y: 0.2123863500289198d), radius: 0.37060674554316686d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6972548873456286d, y: 0.21964978169028926d), radius: 0.35157035487693267d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20653240302903564d, y: 0.023787925874476645d), radius: 0.1533645218299069d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03918951176569352d, y: 0.6698533873407827d), radius: 0.25607480559082896d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4045894937587893d, y: 0.7235787021809643d), radius: 0.1650730490922312d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5632557966970796d, y: 0.5913407507114837d), radius: 0.34243336785071987d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.851761953955178d, y: 0.4021647861366656d), radius: 0.008035731128508306d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8758332755184651d, y: 0.7642269581029142d), radius: 0.9484375610953066d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5712381891865824d, y: 0.9109671443137841d), radius: 0.8935921555505358d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1182540470189426d, y: 0.6584367317614895d), radius: 0.7312605596205856d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9333194420780486d, y: 0.7295039152731371d), radius: 0.14464884630463626d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.585069538578421d, y: 0.8875204654429716d), radius: 0.6276730628600634d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3349710909220134d, y: 0.3973963371810978d), radius: 0.8780892907824016d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6575975055116514d, y: 0.8155033141892534d), radius: 0.07179645877308105d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.488410747209425d, y: 0.9842832762377762d), radius: 0.25676375753980163d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6138532287588616d, y: 0.6520642683526656d), radius: 0.9502813087619735d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3529839310175005d, y: 0.7770410973815388d), radius: 0.27438984644282327d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9946126973554875d, y: 0.09110264352417763d), radius: 0.6049629506334392d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6166674553583228d, y: 0.4244935500040764d), radius: 0.3769165398938562d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6200645520853262d, y: 0.21707792882820798d), radius: 0.4898704652687388d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3675340956586248d, y: 0.093460108030744d), radius: 0.19646889290579728d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43996377060023883d, y: 0.9531411046901103d), radius: 0.16368538621381157d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.968378149306332d, y: 0.6578826165009463d), radius: 0.06872478001814908d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6117658025467015d, y: 0.7946213749629975d), radius: 0.330467887210252d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7614229690260349d, y: 0.666995910478041d), radius: 0.7206842783365636d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7489134056463052d, y: 0.9407139958708317d), radius: 0.19803573448459222d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9635365433461724d, y: 0.6707138911578103d), radius: 0.7593529058800956d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0711570702325991d, y: 0.6119103106496231d), radius: 0.3435717972699347d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.660717520520767d, y: 0.355066641657679d), radius: 0.2958501998979193d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01972136051215101d, y: 0.9007709819508527d), radius: 0.7401051365782688d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8660195797802777d, y: 0.2110180562835655d), radius: 0.35007881141233177d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9469052997678209d, y: 0.691475695675338d), radius: 0.6394162036596798d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4701171605820772d, y: 0.12066675646152503d), radius: 0.6383011481963548d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8203242411057455d, y: 0.6742765084478313d), radius: 0.9633671259891915d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06929072637046796d, y: 0.44968411109554973d), radius: 0.7169343179195469d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.011313468175132013d, y: 0.426087997175138d), radius: 0.09191579193266775d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49796672949917753d, y: 0.3402512003855642d), radius: 0.8506639753945184d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8915549204292326d, y: 0.6075124003029021d), radius: 0.818772488971772d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6771624350501102d, y: 0.08205375020943384d), radius: 0.7803206366059673d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3395641614185002d, y: 0.0380016977336487d), radius: 0.2714854930721746d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2098943067494864d, y: 0.34293880104359975d), radius: 0.6594024111497794d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2203709531072663d, y: 0.6976002305522865d), radius: 0.8770266772615768d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9988792345489987d, y: 0.7449784698492004d), radius: 0.9402233047329696d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5442583324410896d, y: 0.399516264980731d), radius: 0.8059548484661939d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6969718414591585d, y: 0.532473260110728d), radius: 0.3059266504806266d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8181242188852528d, y: 0.022475120502732038d), radius: 0.4699597537731043d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22024126205672412d, y: 0.9180094337831061d), radius: 0.984523806465696d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.389263632982208d, y: 0.527234120578756d), radius: 0.9367559788879443d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7627206481823503d, y: 0.05433776378652211d), radius: 0.19177993416030537d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7261800000689398d, y: 0.06278915916925065d), radius: 0.35124924771046484d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18805453899201796d, y: 0.5435777047166184d), radius: 0.45841546073367245d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25235792385065803d, y: 0.8737378496128946d), radius: 0.4035763017233125d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3698130495775338d, y: 0.7632553786913588d), radius: 0.7226851973872478d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36325037845746955d, y: 0.9366465584541092d), radius: 0.4064130819016325d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0864003918204983d, y: 0.6138464467476765d), radius: 0.24349549815207605d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7489476262587814d, y: 0.8788334572032186d), radius: 0.33154900187714675d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5474187551706258d, y: 0.19923027662818282d), radius: 0.7346227743429928d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7254745291862674d, y: 0.893488395025393d), radius: 0.46111738008655245d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9688025225924165d, y: 0.6311776442265868d), radius: 0.8217938109907384d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7688638348040054d, y: 0.9314757418405135d), radius: 0.4537066485444312d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9479212533345293d, y: 0.07034854620991016d), radius: 0.6433006407957143d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8829868076823396d, y: 0.5224630637468434d), radius: 0.951218573282747d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33881120416677424d, y: 0.8532077357620899d), radius: 0.3511127468854769d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7498598857942328d, y: 0.09456194541239427d), radius: 0.7055469092645318d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3022050813778575d, y: 0.8317463231149624d), radius: 0.1931610248791954d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0007199203082027816d, y: 0.7688151631309297d), radius: 0.07005100578147283d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9492284417755669d, y: 0.44822907230127573d), radius: 0.6839533893140154d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49158183859427285d, y: 0.4039399569611636d), radius: 0.2262245443505515d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6521651975286951d, y: 0.6785223245526469d), radius: 0.35345676846992247d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4593992513163768d, y: 0.6485534511482458d), radius: 0.43887921558654275d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7814590414329747d, y: 0.8142123528600756d), radius: 0.06013191603008461d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0016034021350026517d, y: 0.6095279610470642d), radius: 0.019377161824783884d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8234423142840194d, y: 0.2532264881261972d), radius: 0.18056421736763506d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4107841412883235d, y: 0.6645196982086606d), radius: 0.29426625855065547d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7069178399907959d, y: 0.41808448908123985d), radius: 0.6977685372408349d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47338557652354596d, y: 0.7959050897365835d), radius: 0.974101157529579d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06584052161085796d, y: 0.1534892968370425d), radius: 0.18941667616642688d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9775657966193654d, y: 0.3994929807278438d), radius: 0.2662488189895159d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5212925633905787d, y: 0.9177862308558709d), radius: 0.8691001355575103d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020152268235958837d, y: 0.8639859653059168d), radius: 0.26544138417913166d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26928174581211206d, y: 0.033061406572394536d), radius: 0.4236232045198075d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4293053335822117d, y: 0.42894766985153143d), radius: 0.42776517622239196d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2866936673752416d, y: 0.38211625754294365d), radius: 0.3487761492802498d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3444534767216061d, y: 0.7096557883421545d), radius: 0.12234166745466468d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7089788880808925d, y: 0.3052711461220007d), radius: 0.4870672338717944d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29839157823640705d, y: 0.8961498421924813d), radius: 0.464172679889886d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18150885835972397d, y: 0.5402270381061821d), radius: 0.17917155521705597d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22888131471048256d, y: 0.8563924453312977d), radius: 0.7215603611803673d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9281816284794475d, y: 0.06511833887207663d), radius: 0.4081857203079672d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2472417610628148d, y: 0.26893384311410196d), radius: 0.2270095457608714d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8126221758741525d, y: 0.2979791169058066d), radius: 0.1293558779642826d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7391820056781766d, y: 0.519271265604117d), radius: 0.9456525894077111d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12575015502585984d, y: 0.36061279601130825d), radius: 0.653226133045098d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.914210201384559d, y: 0.24359342388930705d), radius: 0.7968008412125094d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3512447382191136d, y: 0.045224749759858685d), radius: 0.077103988153429d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2236194714402867d, y: 0.879843959869486d), radius: 0.986953282751126d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.206016747932803d, y: 0.013627002279981482d), radius: 0.0845872519001234d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5668685381448704d, y: 0.18290544410433507d), radius: 0.9603453485549168d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46998286302750536d, y: 0.9725104895324682d), radius: 0.2606989976566323d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2683598885938905d, y: 0.6934425036751309d), radius: 0.5194488752341457d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5915710792367229d, y: 0.4913865892475774d), radius: 0.4416338279382598d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4776292973039924d, y: 0.5700583110778846d), radius: 0.17092976874919297d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.775786416669532d, y: 0.4808930754926437d), radius: 0.3939043724071005d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3395644160987368d, y: 0.6220429958204743d), radius: 0.5574847321182077d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3317578847528344d, y: 0.8414789422323254d), radius: 0.2298233142426256d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24859402733695313d, y: 0.6367273388340706d), radius: 0.03025153267123515d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23223873571473586d, y: 0.002743113123611418d), radius: 0.4268459869679111d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02658679052700208d, y: 0.7028949491244323d), radius: 0.4815443954712382d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6965209707049422d, y: 0.6505468033782337d), radius: 0.4243627111478989d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35029088169318445d, y: 0.5441266283703702d), radius: 0.40738356997153036d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9313372637849667d, y: 0.407297434080403d), radius: 0.364671284561918d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5503224743316277d, y: 0.7816593417607587d), radius: 0.3369489996548004d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9404886940128038d, y: 0.46199793698716995d), radius: 0.521353676461469d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4693014586024179d, y: 0.361180538484684d), radius: 0.6531139190179428d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3741619315993788d, y: 0.03423809367839492d), radius: 0.9998388902641835d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10235350696132839d, y: 0.3193398734250882d), radius: 0.6676058980161729d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8688159896296126d, y: 0.7443233395496979d), radius: 0.7268966362221518d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5532008722511211d, y: 0.8066223758244112d), radius: 0.9748420783257626d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5575301643758538d, y: 0.2472913819450333d), radius: 0.6099837629729521d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9102018434238727d, y: 0.44619817835463893d), radius: 0.6191916495912702d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9078498249334747d, y: 0.06594695741720369d), radius: 0.01592811442209363d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11360111418922902d, y: 0.4398434831743455d), radius: 0.2303504165269019d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.719764825618439d, y: 0.9399076512953637d), radius: 0.9985147497523278d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09937843384192291d, y: 0.38291014770748066d), radius: 0.6168257729904773d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42438815193593515d, y: 0.6156103677823977d), radius: 0.8884095324471443d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06972376416732962d, y: 0.09458932071691706d), radius: 0.07107911838118597d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07747767627127988d, y: 0.27897442107666737d), radius: 0.8240636957653809d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4998728761172928d, y: 0.6009385332897669d), radius: 0.9632212224734696d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.693998729157138d, y: 0.6043257623885178d), radius: 0.09069642811863554d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27741332632132343d, y: 0.9745464095983059d), radius: 0.669276152550185d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.905214936822679d, y: 0.8043649534724778d), radius: 0.6070462227677657d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7141268599685009d, y: 0.9958327294950352d), radius: 0.5244425146833418d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8754430781233017d, y: 0.3861887468461217d), radius: 0.7786738594663275d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6307200832870279d, y: 0.060043919838887905d), radius: 0.16999737068763d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6501648493081544d, y: 0.26470052041899195d), radius: 0.4729882725509982d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30243026371135184d, y: 0.3779175828337582d), radius: 0.6846986532197438d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03819196378572198d, y: 0.5627646569260737d), radius: 0.8428820898842229d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8404823531096419d, y: 0.8091594679079617d), radius: 0.2366818582969764d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5674307478434888d, y: 0.0036379036657004926d), radius: 0.9502504823513273d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.655251984393415d, y: 0.09627420599086256d), radius: 0.5526443912178077d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.352752546641412d, y: 0.2699578857802367d), radius: 0.7963977661547629d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9159959352304429d, y: 0.448152674312995d), radius: 0.6539573877175993d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8839251518743165d, y: 0.05469797980129554d), radius: 0.7662539552661958d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6911339644887871d, y: 0.38062109097513097d), radius: 0.5976957466342224d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.019635890745876572d, y: 0.44984324350891336d), radius: 0.4647441036820953d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6890579254745581d, y: 0.40634364942918877d), radius: 0.995365931747134d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43994929163953955d, y: 0.5627047941450716d), radius: 0.88202152407506d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03654076874228662d, y: 0.052266083044819944d), radius: 0.46810920742756834d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36437626645895527d, y: 0.042326989858581965d), radius: 0.8082395118350965d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2014559533967274d, y: 0.49562646617782957d), radius: 0.6920026426329167d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9091784718128992d, y: 0.6199690569310463d), radius: 0.7717890998058028d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36858074500776816d, y: 0.41510845006032016d), radius: 0.49471078810312896d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9166710716078733d, y: 0.7987394041208231d), radius: 0.2501309877625688d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0805292034927182d, y: 0.1816379774176644d), radius: 0.14653604080424354d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7913249370621385d, y: 0.9590250590364688d), radius: 0.7725982771234933d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8072843839562577d, y: 0.3718953042272021d), radius: 0.8993575634775092d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9866474345127407d, y: 0.30790573903132323d), radius: 0.4822278561683274d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3405880554864633d, y: 0.8068669526666907d), radius: 0.16427709302413496d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8113783954310315d, y: 0.45146367222679107d), radius: 0.003392192526502358d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37643892649514477d, y: 0.7259066347464771d), radius: 0.16821001257451917d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8497540694014679d, y: 0.3184759892691137d), radius: 0.11844284014582618d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.052723160485090736d, y: 0.5566760069906965d), radius: 0.3657164472582246d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8795879847082392d, y: 0.19940701979844566d), radius: 0.6103136314668096d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30449733051230243d, y: 0.08226867399136917d), radius: 0.8846521604949832d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5498329238787034d, y: 0.742983414198865d), radius: 0.3971019118404535d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5781541828966438d, y: 0.7758618890743124d), radius: 0.4741976785358736d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.031212857550489526d, y: 0.9427927627395282d), radius: 0.8455133149030347d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9348709257641532d, y: 0.9383366716463546d), radius: 0.1737137509490826d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43973792340644224d, y: 0.03834785037498645d), radius: 0.2569190778340694d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7655918930772532d, y: 0.3603888160555103d), radius: 0.8216122720852355d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9859259782056669d, y: 0.4309960595021427d), radius: 0.17156055333530484d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2866515715447401d, y: 0.7966529694770583d), radius: 0.6292528533659272d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01285372237404414d, y: 0.6329174978524004d), radius: 0.19341304265929882d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8015966133860607d, y: 0.8561897126684845d), radius: 0.045073984171201564d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6096059338482664d, y: 0.038069125135240856d), radius: 0.4546924570779378d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5530777214749538d, y: 0.14869360054016612d), radius: 0.5512525296987988d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4436076108818159d, y: 0.46123691309382764d), radius: 0.9037196679684929d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8236447810819695d, y: 0.7796419905096305d), radius: 0.11875463501490713d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5707359469106936d, y: 0.07726960519003945d), radius: 0.8382892993272347d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2413540934021825d, y: 0.8503416463980052d), radius: 0.35986574658223314d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.019360571294537943d, y: 0.9452918451234036d), radius: 0.24587010784073493d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20518906768897083d, y: 0.09837179021486764d), radius: 0.3587591587498534d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5416770195421861d, y: 0.6358692451616631d), radius: 0.04258197666136365d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.604487123960645d, y: 0.4987160661702612d), radius: 0.5012564750108318d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9200806097019764d, y: 0.13929155069288024d), radius: 0.581355084255038d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2480852083255105d, y: 0.08396797351670404d), radius: 0.2211830925289674d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5984439725544493d, y: 0.7937195129326379d), radius: 0.1920330091506759d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4553070077328387d, y: 0.6070323114155218d), radius: 0.3584986993996062d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8258120272360631d, y: 0.8769576251596277d), radius: 0.6545660584128539d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9334074569916369d, y: 0.9637904716721443d), radius: 0.6903041675901692d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0720883243713143d, y: 0.5849469442016734d), radius: 0.15672193134706147d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.755274074175703d, y: 0.25693446133096143d), radius: 0.4581595263472318d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4746656510470454d, y: 0.14453109654629193d), radius: 0.19183090636531508d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46345940331052093d, y: 0.3040615770024979d), radius: 0.36676377752606437d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7799228612081609d, y: 0.08011708931311678d), radius: 0.4476838492507996d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.158402348084424d, y: 0.07977148214207175d), radius: 0.31319459305595543d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14956709507402088d, y: 0.06131462436443735d), radius: 0.998555796957435d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7307770558917078d, y: 0.7702533812417443d), radius: 0.6837419160396174d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6817527495709408d, y: 0.017797104288302723d), radius: 0.5070948712109404d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6920577877390302d, y: 0.15155195101180052d), radius: 0.23515303669580567d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6933615656332638d, y: 0.7493194660015944d), radius: 0.6359447165847367d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1829218519998408d, y: 0.4219861208470965d), radius: 0.08020744732605012d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03378608480063483d, y: 0.7738370993551663d), radius: 0.3563152986472322d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23480049101244393d, y: 0.02035417314939625d), radius: 0.7079742915852242d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7568356426228425d, y: 0.7172605406926684d), radius: 0.9452395900340953d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7564566073259367d, y: 0.3601936353688523d), radius: 0.428341290593272d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6635652580405625d, y: 0.4563685143339322d), radius: 0.8161571772745563d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35769710744716965d, y: 0.9924570129833838d), radius: 0.49072416178101896d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.455262985528311d, y: 0.21594012493114156d), radius: 0.8551811999405281d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29129610945256756d, y: 0.960469567788755d), radius: 0.20206233904038196d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2415239436906167d, y: 0.7463049099123502d), radius: 0.3088753745763121d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11067895453837062d, y: 0.4861282174388618d), radius: 0.45208269485607755d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9826594479487398d, y: 0.01254867660940806d), radius: 0.42928636947081067d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6698309277334679d, y: 0.6079911252991403d), radius: 0.2827836841892306d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9629943160414642d, y: 0.663305987559702d), radius: 0.3857644863078493d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.526044798054403d, y: 0.1525110595025062d), radius: 0.49895105099857573d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3976737114701565d, y: 0.9130133188191377d), radius: 0.01573771024599524d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5533109219571869d, y: 0.17664548248074585d), radius: 0.5791378884562185d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9121281421699777d, y: 0.2493506262985935d), radius: 0.9824581832483069d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.974604368612739d, y: 0.3053856687384683d), radius: 0.577728868870782d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1989524391658699d, y: 0.4913081917251376d), radius: 0.4545911972090807d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8302951489152472d, y: 0.72627592841999d), radius: 0.8141419330650349d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5026155462535521d, y: 0.08949896822187875d), radius: 0.527493826002191d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28709498167724967d, y: 0.6830604887378808d), radius: 0.00743026856916118d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6069776689417766d, y: 0.80270995967349d), radius: 0.9581344553925027d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2624243650527166d, y: 0.5882517593527462d), radius: 0.8966796066673499d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007303138587826941d, y: 0.4383218378183621d), radius: 0.4958821314001227d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4248070324724501d, y: 0.9858679067290278d), radius: 0.9863880309118646d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.838616253429521d, y: 0.878933148356402d), radius: 0.4508046938404294d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5750219779973431d, y: 0.29797306569683824d), radius: 0.6109217756978201d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6980743446325786d, y: 0.3627701341890286d), radius: 0.25300418781560596d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03226766038847684d, y: 0.5076233071464552d), radius: 0.09722543599695099d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08517084004920372d, y: 0.21554471815261877d), radius: 0.3906906511096051d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.812831133549669d, y: 0.2755443027661342d), radius: 0.48180888911468334d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12034716316592553d, y: 0.5144937536091296d), radius: 0.4627969445869998d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03011310088224306d, y: 0.20617287936982143d), radius: 0.5545998343099381d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9810443968523186d, y: 0.5018650989393171d), radius: 0.3607611464038969d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.028058977113804118d, y: 0.029856800133828743d), radius: 0.748438805606354d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6248436980159299d, y: 0.9457402280323995d), radius: 0.5235153002820473d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44130516408417075d, y: 0.13613813092572047d), radius: 0.47390283550197554d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9244371850134162d, y: 0.34593071326949243d), radius: 0.006423049728510599d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3853148142925379d, y: 0.30391636575395775d), radius: 0.7331108616196579d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14873562903198678d, y: 0.9486675543376685d), radius: 0.13912396878899624d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29498523383979336d, y: 0.044804832325113675d), radius: 0.3419560182549338d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6368835970109089d, y: 0.8558177254849024d), radius: 0.3250430880851243d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28464546530057555d, y: 0.8115623940013158d), radius: 0.2798790551061253d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7428178091835966d, y: 0.5616537515511291d), radius: 0.5607766504957252d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6398455270189355d, y: 0.6244839227773047d), radius: 0.2875989285955458d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5740552847530122d, y: 0.5343413312929934d), radius: 0.004716977774318898d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6086249158322884d, y: 0.6588450286689227d), radius: 0.8941312924471801d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3862531254073499d, y: 0.07908728381035968d), radius: 0.5671234986428441d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4600090020383172d, y: 0.684166684332581d), radius: 0.7458862016035207d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2989001869919695d, y: 0.30265426310265686d), radius: 0.5870677075025806d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7634376422416126d, y: 0.4666811390110941d), radius: 0.5722672062011268d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12328214112253333d, y: 0.06778495226380743d), radius: 0.8303034401485612d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5749421146524724d, y: 0.04590930434853602d), radius: 0.0736517788850738d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29235531791186764d, y: 0.9674530495548851d), radius: 0.08299451402980451d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4854775538503029d, y: 0.30826199566993373d), radius: 0.3000567117921529d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38049525080843183d, y: 0.48282427086394475d), radius: 0.12634870076208804d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38069968867575743d, y: 0.17952572059711203d), radius: 0.8581744462702153d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6465789393352172d, y: 0.7072084067256023d), radius: 0.9027652706778189d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclelistd1e2mi(
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclelistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
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

                changedRows =  ((INpgsqlCircleListcircleListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleListcircleListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclelistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclelistd1e2mi_id", 
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
                changedRows =  ((INpgsqlCircleListcircleListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleListcircleListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleListcircleListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleListcircleListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclelistd1e2mi_id
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
    npgsqlcirclecirclelistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclelistd1e2mi_id
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
    npgsqlcirclecirclelistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclelistd1e2mi_id", 
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
                List<NpgsqlCirclecircleListD1E2M> models = null;

                models =  ((INpgsqlCircleListcircleListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlCircleListcircleListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlCircleListcircleListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlCircleListcircleListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleListD1E2M> models = null;

                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M), typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                ((INpgsqlCircleListcircleListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleListcircleListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
LEFT JOIN public.npgsqlcirclecirclelistd1e2mi mi ON mi.id = m.npgsqlcirclecirclelistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
                var models = await ((INpgsqlCircleListcircleListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M), typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                ((INpgsqlCircleListcircleListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
LEFT JOIN public.npgsqlcirclecirclelistd1e2mi mi ON mi.id = m.npgsqlcirclecirclelistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
                var models = await ((INpgsqlCircleListcircleListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleListcircleListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M), typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[34], false);
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
                parametr2.Value = 143;
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 152;
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
LEFT JOIN public.npgsqlcirclecirclelistd1e2mi mi ON mi.id = m.npgsqlcirclecirclelistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
                var models = await((INpgsqlCircleListcircleListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[34], false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M), typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 102, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 152, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 43, query1, 144, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 95, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 61, query1, 25, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[29],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 152, query1, 26, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 144, query1, 137, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 86, query1, 122, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
LEFT JOIN public.npgsqlcirclecirclelistd1e2mi mi ON mi.id = m.npgsqlcirclecirclelistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
                var models = await((INpgsqlCircleListcircleListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 24, 16))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[31],_testData[34], false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleListD1)this).DbConnectionSTSelectModelBatch(connection, 57, 143))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleListcircleListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleListcircleListD1)this).SetDbConnectionSelectModelParametrs(cmd, 81);
                var models = await ((INpgsqlCircleListcircleListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[18], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[19], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[20], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[21], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[22], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[23], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[24], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[25], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[26], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[27], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[28], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[29], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[30], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[31], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[32], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[33], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleListcircleListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleListcircleListD1)this).SetDbConnectionSelectModelParametrs(cmd, 25);
                var models =  ((INpgsqlCircleListcircleListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[5], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[6], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[7], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[8], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[9], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[10], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[11], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[12], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[13], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[14], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[15], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[16], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[17], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[18], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[19], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[20], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[21], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[22], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[23], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[24], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[25], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[26], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[27], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[28], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[29], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[25],_testData[30], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[26],_testData[31], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[27],_testData[32], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[28],_testData[33], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[29],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleListD1E2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleListcircleListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleListcircleListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleListD1E2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleListcircleListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleListcircleListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclelistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleListD1E2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
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
FROM public.binary_npgsqlcirclecirclelistd1e2m m
LEFT JOIN public.binary_npgsqlcirclecirclelistd1e2mi mi ON mi.id = m.npgsqlcirclecirclelistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleListcircleListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleListcircleListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleListcircleListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclelistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models =  ((INpgsqlCircleListcircleListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleListcircleListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA), typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                await ((INpgsqlCircleListcircleListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                ((INpgsqlCircleListcircleListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA), typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                await ((INpgsqlCircleListcircleListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                ((INpgsqlCircleListcircleListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
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
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MI), typeof(NpgsqlCirclecircleListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MI>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MI>();
                await ((INpgsqlCircleListcircleListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MI>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MI>();
                ((INpgsqlCircleListcircleListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleListcircleListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA), typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                await ((INpgsqlCircleListcircleListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                ((INpgsqlCircleListcircleListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
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
                var models = await ((INpgsqlCircleListcircleListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

