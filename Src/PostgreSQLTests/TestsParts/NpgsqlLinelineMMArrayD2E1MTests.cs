

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
    internal partial interface INpgsqlLineMArraylineMMArrayD2
    {
    }
    
    internal partial class NpgsqlLineMArraylineMMArrayD2 : INpgsqlLineMArraylineMMArrayD2
    {


#region TestData

        private readonly NpgsqlLinelineMMArrayD2E1M[] _testData = new NpgsqlLinelineMMArrayD2E1M[]
        {
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7751108742995659d, b: 0.8705711973083305d, c: 0.5771820792941768d), new NpgsqlTypes.NpgsqlLine(a: 0.3885577468365742d, b: 0.6418999548359733d, c: 0.900222829457445d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.959038147106314d, b: 0.3200071378897995d, c: 0.4199531908262407d), new NpgsqlTypes.NpgsqlLine(a: 0.3578306390967103d, b: 0.05905861145094815d, c: 0.8655403954749871d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.4200363379397559d, b: 0.804995994436807d, c: 0.44758505255819314d), new NpgsqlTypes.NpgsqlLine(a: 0.9551453158190639d, b: 0.8522660129009851d, c: 0.43172113708227344d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.5326123587166752d, b: 0.5861022666344164d, c: 0.19268099760320334d), new NpgsqlTypes.NpgsqlLine(a: 0.6096886996286847d, b: 0.674362832802254d, c: 0.7538524808079156d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.25149409653484056d, b: 0.8406778220055398d, c: 0.7574466178235146d), new NpgsqlTypes.NpgsqlLine(a: 0.0967243955170225d, b: 0.9446874994341122d, c: 0.06057914349404647d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.3259379725611182d, b: 0.03371467201735823d, c: 0.5854626933515603d), new NpgsqlTypes.NpgsqlLine(a: 0.3223697576271797d, b: 0.9913636166844774d, c: 0.2315428050810251d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7930329333219917d, b: 0.9712023054500639d, c: 0.2115810196522412d), new NpgsqlTypes.NpgsqlLine(a: 0.30416150015366294d, b: 0.8747703152334536d, c: 0.09024070357812886d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9343421154201622d, b: 0.6455808785648435d, c: 0.3592673590470301d), new NpgsqlTypes.NpgsqlLine(a: 0.27919199455081756d, b: 0.07571452879189866d, c: 0.8199866199551732d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.1610206860810084d, b: 0.5049285291367905d, c: 0.48493205668146966d), new NpgsqlTypes.NpgsqlLine(a: 0.20274326316168767d, b: 0.011892463851367885d, c: 0.5853405803694484d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.21442224885809313d, b: 0.5156609809378686d, c: 0.7875280117474642d), new NpgsqlTypes.NpgsqlLine(a: 0.6344086578781177d, b: 0.10953602780829408d, c: 0.937317069930685d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7181737588029549d, b: 0.536126713803161d, c: 0.5109297132152665d), new NpgsqlTypes.NpgsqlLine(a: 0.6204537823166565d, b: 0.40379285660870323d, c: 0.5619242756671976d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8592506203299537d, b: 0.10992723621786571d, c: 0.8009631895177762d), new NpgsqlTypes.NpgsqlLine(a: 0.385753160462285d, b: 0.8582875862086993d, c: 0.35288450632432466d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5248865186603141d, b: 0.5605966898269075d, c: 0.8086424458409693d), new NpgsqlTypes.NpgsqlLine(a: 0.8908006650438853d, b: 0.4109735660461923d, c: 0.0757888711569471d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8442847541033878d, b: 0.0010281246018413182d, c: 0.2287974362843993d), new NpgsqlTypes.NpgsqlLine(a: 0.7917531097605693d, b: 0.16721966747197914d, c: 0.4576149065255989d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5425923033690833d, b: 0.5659657372034059d, c: 0.20031363436451743d), new NpgsqlTypes.NpgsqlLine(a: 0.31651406061764975d, b: 0.21635370839336077d, c: 0.32700607504017576d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8030273243401699d, b: 0.8203639569896349d, c: 0.4567233937301559d), new NpgsqlTypes.NpgsqlLine(a: 0.12504614211320164d, b: 0.2088718798854695d, c: 0.20615748794737965d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.27744800261289215d, b: 0.475806038466839d, c: 0.9540239735920572d), new NpgsqlTypes.NpgsqlLine(a: 0.08538703884962173d, b: 0.5873079452189656d, c: 0.11229769522856625d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.11069413978470899d, b: 0.862174165459199d, c: 0.7846875298930235d), new NpgsqlTypes.NpgsqlLine(a: 0.41401419859441646d, b: 0.4839209721102501d, c: 0.8460863276827465d), }, },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.48920460526251797d, b: 0.14752088145130304d, c: 0.9723024436012355d), new NpgsqlTypes.NpgsqlLine(a: 0.5497473805458827d, b: 0.0038713428462258115d, c: 0.18656747015606945d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.5564255974660997d, b: 0.6853236134028637d, c: 0.4395394201608349d), new NpgsqlTypes.NpgsqlLine(a: 0.7907096788226856d, b: 0.7947161899955222d, c: 0.6668831865847634d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6943523972982787d, b: 0.20342327465855237d, c: 0.26376122077284003d), new NpgsqlTypes.NpgsqlLine(a: 0.15530516799367167d, b: 0.41181360707097103d, c: 0.7038720291862922d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6373314033383279d, b: 0.7730432111133446d, c: 0.053785815822154914d), new NpgsqlTypes.NpgsqlLine(a: 0.3152197824429891d, b: 0.5587643438881493d, c: 0.7452813109267804d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.13314136323009207d, b: 0.5563010091695443d, c: 0.21821503377379636d), new NpgsqlTypes.NpgsqlLine(a: 0.11120228624485873d, b: 0.5459760818969002d, c: 0.9263029979115572d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8038574606533225d, b: 0.25580876787007245d, c: 0.5003967667823673d), new NpgsqlTypes.NpgsqlLine(a: 0.8839216803150707d, b: 0.574325524073581d, c: 0.7479861408823627d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.13260233094838003d, b: 0.5811909030964437d, c: 0.3578170414066628d), new NpgsqlTypes.NpgsqlLine(a: 0.9577966648393373d, b: 0.2676792387435315d, c: 0.5722901605462589d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.5393968121096467d, b: 0.5531076387933355d, c: 0.7251939670031614d), new NpgsqlTypes.NpgsqlLine(a: 0.8936719994167069d, b: 0.4020798655851049d, c: 0.2169869130926999d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5036925718669448d, b: 0.8808280801500145d, c: 0.07655628179607399d), new NpgsqlTypes.NpgsqlLine(a: 0.8608459289079962d, b: 0.8685444879425611d, c: 0.6607041046492739d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.4864245791009514d, b: 0.8917596538554727d, c: 0.46152266055954005d), new NpgsqlTypes.NpgsqlLine(a: 0.002460057497594925d, b: 0.8676704939925313d, c: 0.40016853209881365d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.36370782409130586d, b: 0.9874607488278605d, c: 0.5986981555307512d), new NpgsqlTypes.NpgsqlLine(a: 0.7145858086812792d, b: 0.7527581042095544d, c: 0.521575247883638d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.801826653295513d, b: 0.8500572710338188d, c: 0.020581683590429445d), new NpgsqlTypes.NpgsqlLine(a: 0.11418225105386237d, b: 0.8315173442131382d, c: 0.12534063079971425d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8809152469921038d, b: 0.8144757550059113d, c: 0.6109210014565211d), new NpgsqlTypes.NpgsqlLine(a: 0.7864980668229412d, b: 0.7749789754345199d, c: 0.7183182755327902d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.016547804477722527d, b: 0.644007401345035d, c: 0.799327104913701d), new NpgsqlTypes.NpgsqlLine(a: 0.9237774947996131d, b: 0.520633057487466d, c: 0.8556566709484478d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9601587206287403d, b: 0.35300485382828406d, c: 0.4871531750849045d), new NpgsqlTypes.NpgsqlLine(a: 0.5830166622072572d, b: 0.08624438472504758d, c: 0.008827280051454611d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.3833344731550903d, b: 0.9777328017976195d, c: 0.7499178664001497d), new NpgsqlTypes.NpgsqlLine(a: 0.665882838518042d, b: 0.8707175084950785d, c: 0.5045994764365679d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9181275287894919d, b: 0.09846242283091122d, c: 0.5670841194798758d), new NpgsqlTypes.NpgsqlLine(a: 0.5288539637423664d, b: 0.20606460309301455d, c: 0.08599969130999563d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6797965204433767d, b: 0.9617959706464333d, c: 0.9480322062708276d), new NpgsqlTypes.NpgsqlLine(a: 0.15557931376507916d, b: 0.04109402418945152d, c: 0.02877028547331717d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9327798274760706d, b: 0.2527999545397128d, c: 0.3710687372134299d), new NpgsqlTypes.NpgsqlLine(a: 0.1242425747863346d, b: 0.3916633966387044d, c: 0.20935705180860764d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.011532796234742793d, b: 0.4714378033580935d, c: 0.8955707834868706d), new NpgsqlTypes.NpgsqlLine(a: 0.20096745901601565d, b: 0.3339420513037963d, c: 0.5348612983545665d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6228644937827665d, b: 0.9564003311429539d, c: 0.47486649230376543d), new NpgsqlTypes.NpgsqlLine(a: 0.1400735126899113d, b: 0.9067378555820976d, c: 0.1017259018976523d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.3027377673339643d, b: 0.875757948650562d, c: 0.5909629953808807d), new NpgsqlTypes.NpgsqlLine(a: 0.6637025953317758d, b: 0.8689395302494488d, c: 0.20090516319100848d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.32084746825698585d, b: 0.7741817178714917d, c: 0.547968616711444d), new NpgsqlTypes.NpgsqlLine(a: 0.07026102610745955d, b: 0.7467437129739753d, c: 0.07925330557718135d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7785964262999535d, b: 0.4308401990960463d, c: 0.7284914890879107d), new NpgsqlTypes.NpgsqlLine(a: 0.495224995560132d, b: 0.8878963035796688d, c: 0.970513895545922d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5364650837609373d, b: 0.3225598768848775d, c: 0.7453481784643842d), new NpgsqlTypes.NpgsqlLine(a: 0.20615319741248805d, b: 0.507188634238446d, c: 0.8852424689274346d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.21597816776017953d, b: 0.9864001331128756d, c: 0.0814424744667025d), new NpgsqlTypes.NpgsqlLine(a: 0.2319156789667166d, b: 0.7572005531796304d, c: 0.10685097074920602d), }, },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.4111129662798523d, b: 0.8898466892251218d, c: 0.6662095142779163d), new NpgsqlTypes.NpgsqlLine(a: 0.04060444476870584d, b: 0.784922858677175d, c: 0.7711936300385137d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.1047282734556908d, b: 0.7148279073386061d, c: 0.5483239261572921d), new NpgsqlTypes.NpgsqlLine(a: 0.9750522994838488d, b: 0.6597983876249731d, c: 0.9114884733845235d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5333003133763718d, b: 0.5020345811862147d, c: 0.9768563167734416d), new NpgsqlTypes.NpgsqlLine(a: 0.26130465959555993d, b: 0.6686885654176384d, c: 0.149497492220398d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9430156114702245d, b: 0.889675298071108d, c: 0.21097872231429726d), new NpgsqlTypes.NpgsqlLine(a: 0.8308712303500865d, b: 0.11119845204612877d, c: 0.10228185230063502d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.02555926777936013d, b: 0.756665520603733d, c: 0.7276927269007777d), new NpgsqlTypes.NpgsqlLine(a: 0.05117473256981131d, b: 0.5784716919913996d, c: 0.6280696538075932d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.4131752461803798d, b: 0.8313801324373785d, c: 0.8629646226294062d), new NpgsqlTypes.NpgsqlLine(a: 0.7856149113991655d, b: 0.999650756478418d, c: 0.2910859020444502d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5814058927679011d, b: 0.4202588037395326d, c: 0.2672047489534465d), new NpgsqlTypes.NpgsqlLine(a: 0.25852653455767005d, b: 0.9064750658409512d, c: 0.22827687810569475d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.48790322733462177d, b: 0.994108276733307d, c: 0.570210067098246d), new NpgsqlTypes.NpgsqlLine(a: 0.4654627823708122d, b: 0.8864570408554813d, c: 0.4070704113632042d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7249293184866985d, b: 0.07825617686215314d, c: 0.5480677155494487d), new NpgsqlTypes.NpgsqlLine(a: 0.35491092994188667d, b: 0.9132319849652349d, c: 0.33771115543995933d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.5601025766438619d, b: 0.6690260446196864d, c: 0.27548206302593825d), new NpgsqlTypes.NpgsqlLine(a: 0.5080901620664411d, b: 0.4028306834449511d, c: 0.5750031024010822d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.43346480725563064d, b: 0.7598252961837251d, c: 0.07887135334041251d), new NpgsqlTypes.NpgsqlLine(a: 0.8900399382890581d, b: 0.5623978595250035d, c: 0.5708610538078231d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7603328960581419d, b: 0.038972561894610847d, c: 0.47907812872325817d), new NpgsqlTypes.NpgsqlLine(a: 0.9572978765479531d, b: 0.30288658344757435d, c: 0.6598888615567771d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.12044118954094407d, b: 0.19217026738135867d, c: 0.4405383673730443d), new NpgsqlTypes.NpgsqlLine(a: 0.9277397775919503d, b: 0.9372046657057532d, c: 0.05475040836440981d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.63020895345826d, b: 0.5349250037152424d, c: 0.16265630378905716d), new NpgsqlTypes.NpgsqlLine(a: 0.6244701177372224d, b: 0.445146077522492d, c: 0.8427329049623025d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8581160493887147d, b: 0.8509410084541484d, c: 0.7488847516796547d), new NpgsqlTypes.NpgsqlLine(a: 0.4289204855645282d, b: 0.84317137190293d, c: 0.2281799015504986d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9701779516404817d, b: 0.47543955427767015d, c: 0.2984857811605668d), new NpgsqlTypes.NpgsqlLine(a: 0.421522877677424d, b: 0.6042822713059997d, c: 0.26163433651710977d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.912518715236828d, b: 0.5545814615099887d, c: 0.003648785454948622d), new NpgsqlTypes.NpgsqlLine(a: 0.5854692677925998d, b: 0.7814473075839171d, c: 0.5659566727174636d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.007164484729808129d, b: 0.2938432950950314d, c: 0.5517116745586383d), new NpgsqlTypes.NpgsqlLine(a: 0.15831096081689533d, b: 0.3848711956988541d, c: 0.6945957387102086d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9203125490630395d, b: 0.7580780833755351d, c: 0.15603846012565603d), new NpgsqlTypes.NpgsqlLine(a: 0.8331997920893089d, b: 0.40659790647370964d, c: 0.15475800213881707d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8014468071951443d, b: 0.8381278028789345d, c: 0.12225890752079283d), new NpgsqlTypes.NpgsqlLine(a: 0.7837188275443258d, b: 0.055829180409922796d, c: 0.9245348184938741d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.57037691178668d, b: 0.9896285213204098d, c: 0.26525480916547317d), new NpgsqlTypes.NpgsqlLine(a: 0.5222927104300843d, b: 0.747215008320032d, c: 0.27779133038586834d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.3456237897316531d, b: 0.5380342001174718d, c: 0.843654374723224d), new NpgsqlTypes.NpgsqlLine(a: 0.9132482842811154d, b: 0.42596696380964316d, c: 0.05380554927007419d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.40388765204588617d, b: 0.38644270758179966d, c: 0.2750122295956605d), new NpgsqlTypes.NpgsqlLine(a: 0.678234655320027d, b: 0.652041010954858d, c: 0.6516652553905695d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.5809065988099833d, b: 0.7342983699804555d, c: 0.7050066629823905d), new NpgsqlTypes.NpgsqlLine(a: 0.8485819938978024d, b: 0.9863127244018342d, c: 0.7237410263052128d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5484901498605754d, b: 0.7612581985051768d, c: 0.7907662834720649d), new NpgsqlTypes.NpgsqlLine(a: 0.5126915143388471d, b: 0.4803459933453178d, c: 0.904889709444662d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8868656483589671d, b: 0.9336411009930454d, c: 0.44644716662146333d), new NpgsqlTypes.NpgsqlLine(a: 0.7037286595660952d, b: 0.722732376480552d, c: 0.4375383119566739d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.2629563845025724d, b: 0.6063820759167454d, c: 0.305299308759291d), new NpgsqlTypes.NpgsqlLine(a: 0.8330370474684627d, b: 0.8182721329856609d, c: 0.15388513788353997d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.863169104112433d, b: 0.7310517432655699d, c: 0.15569032201988364d), new NpgsqlTypes.NpgsqlLine(a: 0.8406551885539111d, b: 0.8384639356125676d, c: 0.46587924125593627d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.3795118463108085d, b: 0.01110692531148505d, c: 0.7589424717739599d), new NpgsqlTypes.NpgsqlLine(a: 0.5763787401748748d, b: 0.7177946165973283d, c: 0.4311178901192655d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.27779841133069094d, b: 0.29246229314188754d, c: 0.7953197435416517d), new NpgsqlTypes.NpgsqlLine(a: 0.4209579686317183d, b: 0.1919274302421783d, c: 0.6527773390920756d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9249303781555294d, b: 0.227919198664144d, c: 0.23772325116093518d), new NpgsqlTypes.NpgsqlLine(a: 0.4256962153029986d, b: 0.6397515391730353d, c: 0.9622904292075752d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.019328815912525443d, b: 0.9325861638978878d, c: 0.7646823074917367d), new NpgsqlTypes.NpgsqlLine(a: 0.1770235757002474d, b: 0.3460405158968375d, c: 0.07806152079433326d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6183734055457422d, b: 0.608025681974421d, c: 0.2556418320870254d), new NpgsqlTypes.NpgsqlLine(a: 0.7759376479503519d, b: 0.43446517736326207d, c: 0.02738409826881194d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.4828152886945414d, b: 0.15064282688872255d, c: 0.6388616538924273d), new NpgsqlTypes.NpgsqlLine(a: 0.969710813446595d, b: 0.47909045592766486d, c: 0.529701323153715d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.24425823914672629d, b: 0.2266256099865599d, c: 0.48468113698379656d), new NpgsqlTypes.NpgsqlLine(a: 0.3002035132613924d, b: 0.4814127749342245d, c: 0.15474369084813955d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8659966336466501d, b: 0.585360322804176d, c: 0.3933284656903874d), new NpgsqlTypes.NpgsqlLine(a: 0.6914740000839169d, b: 0.6107951492532714d, c: 0.9346860703484212d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5829156699765561d, b: 0.24120946515720854d, c: 0.3142337291623247d), new NpgsqlTypes.NpgsqlLine(a: 0.4050375220943423d, b: 0.14811859516597659d, c: 0.6989890547195092d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.5397397473249353d, b: 0.7204234719146779d, c: 0.3770703850363588d), new NpgsqlTypes.NpgsqlLine(a: 0.4754930707669488d, b: 0.5115680474124509d, c: 0.08424287830705424d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.11369909375372822d, b: 0.33254656618431466d, c: 0.9155608301881631d), new NpgsqlTypes.NpgsqlLine(a: 0.41338667052202316d, b: 0.6392065528003783d, c: 0.26401804101629833d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.828198965795826d, b: 0.31632402049097386d, c: 0.08715404671661431d), new NpgsqlTypes.NpgsqlLine(a: 0.4235966234721721d, b: 0.15135845372766144d, c: 0.2873953969809331d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.08827199423515764d, b: 0.9270165655903961d, c: 0.10434386224343717d), new NpgsqlTypes.NpgsqlLine(a: 0.8766861344351158d, b: 0.3605522627485497d, c: 0.9446255886095201d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.015533172594863198d, b: 0.5033718470804932d, c: 0.9933853847231122d), new NpgsqlTypes.NpgsqlLine(a: 0.3278889501618337d, b: 0.5787524886448413d, c: 0.5653658434502018d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.489504315017655d, b: 0.5852560805164766d, c: 0.7002163117862957d), new NpgsqlTypes.NpgsqlLine(a: 0.8706808244011135d, b: 0.4660777829172821d, c: 0.953163400905825d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.4652542672692569d, b: 0.7350313368176206d, c: 0.6176837906972991d), new NpgsqlTypes.NpgsqlLine(a: 0.757127426381729d, b: 0.21992748765284875d, c: 0.6655298245389882d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9178655556353679d, b: 0.8967887500567362d, c: 0.14205542943332916d), new NpgsqlTypes.NpgsqlLine(a: 0.9580616787029329d, b: 0.23696058827993716d, c: 0.7965581599886978d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.3425547564586995d, b: 0.04034204561070409d, c: 0.9539505763142306d), new NpgsqlTypes.NpgsqlLine(a: 0.318120327778907d, b: 0.6524759360033098d, c: 0.9698675697529004d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.35261228370804354d, b: 0.7209231868116072d, c: 0.8570020679562064d), new NpgsqlTypes.NpgsqlLine(a: 0.1199944671365355d, b: 0.26642739010187755d, c: 0.5898450290273531d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8403577297014232d, b: 0.4542728105413496d, c: 0.6833653255458885d), new NpgsqlTypes.NpgsqlLine(a: 0.6064961274933972d, b: 0.24028427826287757d, c: 0.9431530949798026d), }, },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.923137448568605d, b: 0.6460499981148842d, c: 0.2586902917134649d), new NpgsqlTypes.NpgsqlLine(a: 0.5861192031520501d, b: 0.2786007000351304d, c: 0.6849943644788974d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.3517927400837415d, b: 0.277832068374095d, c: 0.9932983786745793d), new NpgsqlTypes.NpgsqlLine(a: 0.589178579905633d, b: 0.48876203631168946d, c: 0.7833619117662134d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8007952658830866d, b: 0.2645228686602793d, c: 0.4308573471939623d), new NpgsqlTypes.NpgsqlLine(a: 0.0005519813123500139d, b: 0.3576731812569053d, c: 0.0674399656647281d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.14826296722439392d, b: 0.037388186407952606d, c: 0.713662584587427d), new NpgsqlTypes.NpgsqlLine(a: 0.2392468268702378d, b: 0.4779482613697661d, c: 0.6503890408204566d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8356119925039504d, b: 0.5223012159039971d, c: 0.38242032068328335d), new NpgsqlTypes.NpgsqlLine(a: 0.7068136404016684d, b: 0.1763585234935967d, c: 0.7164762370189044d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6463480937823726d, b: 0.29966170037656337d, c: 0.9150327705292748d), new NpgsqlTypes.NpgsqlLine(a: 0.6502778854637877d, b: 0.7593526538354056d, c: 0.38730639867068506d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.648458580959374d, b: 0.1639553212945244d, c: 0.24401563281284944d), new NpgsqlTypes.NpgsqlLine(a: 0.46741098478000165d, b: 0.7969134210072004d, c: 0.6348393898466997d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.18764462376831603d, b: 0.23787611275884135d, c: 0.19035431629226018d), new NpgsqlTypes.NpgsqlLine(a: 0.5838441884264193d, b: 0.2380771313363481d, c: 0.6418437455746862d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9351482861327055d, b: 0.24690232529990297d, c: 0.8882870451355589d), new NpgsqlTypes.NpgsqlLine(a: 0.9129488455336306d, b: 0.6565035508487511d, c: 0.09420919500960134d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.3810555892377655d, b: 0.08958889439673634d, c: 0.9845727570530997d), new NpgsqlTypes.NpgsqlLine(a: 0.5252217689928151d, b: 0.10830437285775951d, c: 0.031052857352137364d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.3800166707833409d, b: 0.011109420366749667d, c: 0.9929698073913028d), new NpgsqlTypes.NpgsqlLine(a: 0.6253039663042991d, b: 0.42189717890270617d, c: 0.5779898555632744d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6093033977862363d, b: 0.1588651970551137d, c: 0.14834937807943438d), new NpgsqlTypes.NpgsqlLine(a: 0.017569836884058887d, b: 0.148405474024366d, c: 0.7131909589160808d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.985216225011832d, b: 0.09040856836680478d, c: 0.578982005038191d), new NpgsqlTypes.NpgsqlLine(a: 0.3471919651805816d, b: 0.07130325716864594d, c: 0.04684418683895053d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6863783054994781d, b: 0.41733746888830725d, c: 0.4990952397562357d), new NpgsqlTypes.NpgsqlLine(a: 0.4361677033923501d, b: 0.6364480908769007d, c: 0.7860610672447305d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.03604778051325008d, b: 0.5683382638227198d, c: 0.9939851120820812d), new NpgsqlTypes.NpgsqlLine(a: 0.44123091806279957d, b: 0.2694884518782257d, c: 0.35404594722737914d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9672291235619018d, b: 0.7034831543514316d, c: 0.8831991794792668d), new NpgsqlTypes.NpgsqlLine(a: 0.6259446111000525d, b: 0.868274808620295d, c: 0.9758798889703942d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6915837787495777d, b: 0.09322377900296619d, c: 0.47117174603546697d), new NpgsqlTypes.NpgsqlLine(a: 0.053699930642931326d, b: 0.5676018662057727d, c: 0.7600077590933929d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.07854198809742508d, b: 0.24703131756915775d, c: 0.35260244414262276d), new NpgsqlTypes.NpgsqlLine(a: 0.07894827142769345d, b: 0.6229406836127015d, c: 0.02946961531817227d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.10023192846171625d, b: 0.529042843659026d, c: 0.4625294817103476d), new NpgsqlTypes.NpgsqlLine(a: 0.43746359490317277d, b: 0.4681331555927497d, c: 0.3440990764867281d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.28368837139537995d, b: 0.21691029777610082d, c: 0.954982983233355d), new NpgsqlTypes.NpgsqlLine(a: 0.9434314366256246d, b: 0.1966516157373367d, c: 0.21090663213181648d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.3406569984811868d, b: 0.3543140212200989d, c: 0.12261282261866813d), new NpgsqlTypes.NpgsqlLine(a: 0.191825483901368d, b: 0.9170437575756839d, c: 0.5312880282630545d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8137450833803868d, b: 0.6183713067624429d, c: 0.26006646211349194d), new NpgsqlTypes.NpgsqlLine(a: 0.23377246318288913d, b: 0.3803588486109284d, c: 0.6986091602376671d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8249896023631835d, b: 0.9663956803771764d, c: 0.6325892114731286d), new NpgsqlTypes.NpgsqlLine(a: 0.8213746588155234d, b: 0.6655867197818333d, c: 0.13875712781586802d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9388260370328639d, b: 0.781958971088358d, c: 0.6240012152617324d), new NpgsqlTypes.NpgsqlLine(a: 0.22548544456853747d, b: 0.7728585542377298d, c: 0.6588563018154296d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.012853347218442557d, b: 0.7544659457626267d, c: 0.8200149849265095d), new NpgsqlTypes.NpgsqlLine(a: 0.7474837276635854d, b: 0.09612665708072787d, c: 0.3971725325831037d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8296681228346034d, b: 0.4861214426620979d, c: 0.7766285737346652d), new NpgsqlTypes.NpgsqlLine(a: 0.960511159488514d, b: 0.021273437573054665d, c: 0.42853471413541955d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.14057114795364856d, b: 0.31555808266724217d, c: 0.4067851430468572d), new NpgsqlTypes.NpgsqlLine(a: 0.2511752664807002d, b: 0.7822142489676034d, c: 0.7826441575561532d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9415978465642152d, b: 0.3770078269002045d, c: 0.881271515455419d), new NpgsqlTypes.NpgsqlLine(a: 0.22386843787232402d, b: 0.939940025859429d, c: 0.14797666954218702d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5813359721408418d, b: 0.7533313328701623d, c: 0.5458118254266396d), new NpgsqlTypes.NpgsqlLine(a: 0.7752940644548548d, b: 0.06723473628726917d, c: 0.29536185086770517d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.34828403584040635d, b: 0.20006491852688701d, c: 0.6996312595127031d), new NpgsqlTypes.NpgsqlLine(a: 0.6619790038950463d, b: 0.9784580181618643d, c: 0.3484202666610532d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6102123331533466d, b: 0.18414866692373844d, c: 0.0835742492733047d), new NpgsqlTypes.NpgsqlLine(a: 0.3437028705680867d, b: 0.4341604755950479d, c: 0.5507778430782188d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.45800836681488577d, b: 0.5947001748756854d, c: 0.4568159157498549d), new NpgsqlTypes.NpgsqlLine(a: 0.9887142265086892d, b: 0.93469781005712d, c: 0.36636735233749107d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9778491249056649d, b: 0.7757428238979857d, c: 0.46380470866859547d), new NpgsqlTypes.NpgsqlLine(a: 0.15228591925310908d, b: 0.36147921231703206d, c: 0.7542365269270964d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.08675001495307122d, b: 0.9981695161198048d, c: 0.8074041763418182d), new NpgsqlTypes.NpgsqlLine(a: 0.5261811898575056d, b: 0.9202992270076601d, c: 0.1413683329186357d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 161,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.2712544298136982d, b: 0.005942283464528519d, c: 0.23328855815095673d), new NpgsqlTypes.NpgsqlLine(a: 0.7105563014981936d, b: 0.169436437872302d, c: 0.4385888097317183d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.3536005432426491d, b: 0.9010638079941671d, c: 0.5883943026479533d), new NpgsqlTypes.NpgsqlLine(a: 0.9855868300836166d, b: 0.7473446287626505d, c: 1.2292239991440468E-06d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.2695679636975429d, b: 0.015805633293435317d, c: 0.8874757018554261d), new NpgsqlTypes.NpgsqlLine(a: 0.8335112030877265d, b: 0.5833887301752815d, c: 0.8535859150016131d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7989511565163849d, b: 0.9217099516203094d, c: 0.7711215622658549d), new NpgsqlTypes.NpgsqlLine(a: 0.07640063648189821d, b: 0.5211934959730526d, c: 0.945040993182332d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 169,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7558700933032041d, b: 0.0881198481790666d, c: 0.16147036034230944d), new NpgsqlTypes.NpgsqlLine(a: 0.2302951488418018d, b: 0.718978652612837d, c: 0.7426450357272519d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9801831957409082d, b: 0.10400546799610177d, c: 0.9893884637810348d), new NpgsqlTypes.NpgsqlLine(a: 0.9032724577203901d, b: 0.16863669553246952d, c: 0.7225753271493176d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9723638268202022d, b: 0.2604832294837981d, c: 0.5974664801930603d), new NpgsqlTypes.NpgsqlLine(a: 0.24052857566903485d, b: 0.2244427304545702d, c: 0.3376158646247003d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.03438541057076794d, b: 0.7985727269730343d, c: 0.2694847469771565d), new NpgsqlTypes.NpgsqlLine(a: 0.8719131015940328d, b: 0.12852891038470582d, c: 0.5184891103512193d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 177,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.3300853742683839d, b: 0.5569621703267111d, c: 0.8813830467633207d), new NpgsqlTypes.NpgsqlLine(a: 0.04268920085226591d, b: 0.06752824650223777d, c: 0.7174888060557766d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.4391736614544397d, b: 0.8945668323661634d, c: 0.451411976599174d), new NpgsqlTypes.NpgsqlLine(a: 0.09326599772282418d, b: 0.5161421911508408d, c: 0.7270629701337477d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.8799292778731153d, b: 0.5862423145872722d, c: 0.21502923782858208d), new NpgsqlTypes.NpgsqlLine(a: 0.5879689251825897d, b: 0.7306635130402921d, c: 0.5034776056844158d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.8178161830827753d, b: 0.9264650674871446d, c: 0.6803274916350295d), new NpgsqlTypes.NpgsqlLine(a: 0.924192409359598d, b: 0.8081059715900413d, c: 0.564958249693409d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.74293988740726d, b: 0.9597458740495465d, c: 0.49610931098647904d), new NpgsqlTypes.NpgsqlLine(a: 0.4437289624965256d, b: 0.8780249339185493d, c: 0.11106203494305344d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9439343171460717d, b: 0.6328337739428618d, c: 0.37466488797182473d), new NpgsqlTypes.NpgsqlLine(a: 0.6268003112579916d, b: 0.12599963942233805d, c: 0.47060617833534724d), }, },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 185,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9755125963995183d, b: 0.4093518754093709d, c: 0.42822829987239164d), new NpgsqlTypes.NpgsqlLine(a: 0.7020830313754223d, b: 0.16367553236462906d, c: 0.07588949989835414d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.3493289566645127d, b: 0.9449097933798113d, c: 0.3553189338568259d), new NpgsqlTypes.NpgsqlLine(a: 0.6465174995475165d, b: 0.7489299823889471d, c: 0.34731815102361285d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.048821262250944186d, b: 0.0378240680812173d, c: 0.9459468555678123d), new NpgsqlTypes.NpgsqlLine(a: 0.827927632365995d, b: 0.6714554497499065d, c: 0.3837959305162221d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.3053391664234786d, b: 0.9348643010936384d, c: 0.43252465600644086d), new NpgsqlTypes.NpgsqlLine(a: 0.449303060402119d, b: 0.8364732690234965d, c: 0.2933414467551648d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 193,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.1305267652144545d, b: 0.5503537799970976d, c: 0.828514951105724d), new NpgsqlTypes.NpgsqlLine(a: 0.2728711231139801d, b: 0.11261654732345028d, c: 0.03848563609290012d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9809391045134885d, b: 0.631382225591198d, c: 0.5554896671401094d), new NpgsqlTypes.NpgsqlLine(a: 0.793650599917137d, b: 0.6341820159702676d, c: 0.47098443601650075d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.28368934856176375d, b: 0.994586788840516d, c: 0.06482084040391323d), new NpgsqlTypes.NpgsqlLine(a: 0.8071825794429208d, b: 0.46819936880559143d, c: 0.4383637776496131d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7011166118629111d, b: 0.6194116530205456d, c: 0.23034243523349163d), new NpgsqlTypes.NpgsqlLine(a: 0.0438726161197327d, b: 0.09362208208307332d, c: 0.36724097249045407d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7662002415505587d, b: 0.07854303710625454d, c: 0.35225869057098846d), new NpgsqlTypes.NpgsqlLine(a: 0.5628549513864403d, b: 0.660435325903377d, c: 0.3323116133742726d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.1249826475875957d, b: 0.8886684496498173d, c: 0.4777643078583983d), new NpgsqlTypes.NpgsqlLine(a: 0.5418309420648897d, b: 0.7979386080911819d, c: 0.37713693850678043d), }, },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 202,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.014259225157143285d, b: 0.36602605259538856d, c: 0.7610569309858631d), new NpgsqlTypes.NpgsqlLine(a: 0.0892177332532954d, b: 0.12807170360156805d, c: 0.71045176973378d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.02976706394528439d, b: 0.5078161918041112d, c: 0.36591525572661043d), new NpgsqlTypes.NpgsqlLine(a: 0.1270424176760021d, b: 0.5929370376426828d, c: 0.6338858035703246d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9893543992804849d, b: 0.14226250479699232d, c: 0.664195321970563d), new NpgsqlTypes.NpgsqlLine(a: 0.6885155334097988d, b: 0.15970987081529886d, c: 0.1422217803414335d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9852740895092476d, b: 0.7396856232621248d, c: 0.5599484040365564d), new NpgsqlTypes.NpgsqlLine(a: 0.8862136862757845d, b: 0.13838295769748765d, c: 0.5587771977729441d), }, },
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 209,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7212010993270631d, b: 0.06452564925939375d, c: 0.5896992142165687d), new NpgsqlTypes.NpgsqlLine(a: 0.7592371900513891d, b: 0.04335726255237382d, c: 0.21629930337378545d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9637507229725015d, b: 0.2990590522847253d, c: 0.681968402247634d), new NpgsqlTypes.NpgsqlLine(a: 0.43134817181145013d, b: 0.7298094319920495d, c: 0.9422639028596492d), }, },
    ModelInner = new NpgsqlLinelineMMArrayD2E1MI
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.06768278746728895d, b: 0.10101235427380961d, c: 0.9754821374429651d), new NpgsqlTypes.NpgsqlLine(a: 0.14061159717855143d, b: 0.8233856552188504d, c: 0.1775418774157198d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.018973598831560468d, b: 0.5112898070298824d, c: 0.9954063072420449d), new NpgsqlTypes.NpgsqlLine(a: 0.9052076247999947d, b: 0.46741299046344353d, c: 0.3303913180350537d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.7594390608208127d, b: 0.38042677426825744d, c: 0.3492516361921798d), new NpgsqlTypes.NpgsqlLine(a: 0.40803707190251726d, b: 0.05999474772499103d, c: 0.4881784042900952d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6730412308826751d, b: 0.34474436524002927d, c: 0.8716556190210001d), new NpgsqlTypes.NpgsqlLine(a: 0.7687829762357072d, b: 0.37781662128140614d, c: 0.8934956059824462d), }, },
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD2E1M
{
    Id = 211,
    Value = 
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.833576355549733d, b: 0.734012708659896d, c: 0.9545047155087308d), new NpgsqlTypes.NpgsqlLine(a: 0.3024601451009946d, b: 0.5669182341395422d, c: 0.267198764568792d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7750647463381238d, b: 0.4858701809291709d, c: 0.6595723281698185d), new NpgsqlTypes.NpgsqlLine(a: 0.4089911324498149d, b: 0.10658500401283766d, c: 0.048366255965450855d), }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
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

                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinemmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd2e1mi_id
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
    npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.6943523972982787d, b: 0.20342327465855237d, c: 0.26376122077284003d), new NpgsqlTypes.NpgsqlLine(a: 0.15530516799367167d, b: 0.41181360707097103d, c: 0.7038720291862922d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.6373314033383279d, b: 0.7730432111133446d, c: 0.053785815822154914d), new NpgsqlTypes.NpgsqlLine(a: 0.3152197824429891d, b: 0.5587643438881493d, c: 0.7452813109267804d), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5036925718669448d, b: 0.8808280801500145d, c: 0.07655628179607399d), new NpgsqlTypes.NpgsqlLine(a: 0.8608459289079962d, b: 0.8685444879425611d, c: 0.6607041046492739d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.4864245791009514d, b: 0.8917596538554727d, c: 0.46152266055954005d), new NpgsqlTypes.NpgsqlLine(a: 0.002460057497594925d, b: 0.8676704939925313d, c: 0.40016853209881365d), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd2e1mi_id
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
    npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinemmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.9327798274760706d, b: 0.2527999545397128d, c: 0.3710687372134299d), new NpgsqlTypes.NpgsqlLine(a: 0.1242425747863346d, b: 0.3916633966387044d, c: 0.20935705180860764d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.011532796234742793d, b: 0.4714378033580935d, c: 0.8955707834868706d), new NpgsqlTypes.NpgsqlLine(a: 0.20096745901601565d, b: 0.3339420513037963d, c: 0.5348612983545665d), }, }));
                nullable =  ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[,] nullable = null;
                nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.5333003133763718d, b: 0.5020345811862147d, c: 0.9768563167734416d), new NpgsqlTypes.NpgsqlLine(a: 0.26130465959555993d, b: 0.6686885654176384d, c: 0.149497492220398d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.9430156114702245d, b: 0.889675298071108d, c: 0.21097872231429726d), new NpgsqlTypes.NpgsqlLine(a: 0.8308712303500865d, b: 0.11119845204612877d, c: 0.10228185230063502d), }, }));
                nullable = await ((INpgsqlLineMArraylineMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[,] { { new NpgsqlTypes.NpgsqlLine(a: 0.43346480725563064d, b: 0.7598252961837251d, c: 0.07887135334041251d), new NpgsqlTypes.NpgsqlLine(a: 0.8900399382890581d, b: 0.5623978595250035d, c: 0.5708610538078231d), }, { new NpgsqlTypes.NpgsqlLine(a: 0.7603328960581419d, b: 0.038972561894610847d, c: 0.47907812872325817d), new NpgsqlTypes.NpgsqlLine(a: 0.9572978765479531d, b: 0.30288658344757435d, c: 0.6598888615567771d), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineMMArrayD2E1M> models = null;

                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineMMArrayD2E1M> models = null;

                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineMArraylineMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 193;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 30;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 185;
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 169;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M), typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 157, query1, 75, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 146, query1, 75, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 185, query1, 4, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 29, query1, 161, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 47, query1, 169, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 134, query1, 146, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 153, query1, 38, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
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
FROM public.npgsqllinelinemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD2E1M>();
                 ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 8, query1, 75, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 54, 30))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 68, 23))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlLinelineMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineMArraylineMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineMArraylineMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 134);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineMArraylineMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineMArraylineMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 68);
                var models =  ((INpgsqlLineMArraylineMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                NpgsqlLinelineMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MIWA),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MI),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineMMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
FROM public.binary_npgsqllinelinemmarrayd2e1m m
LEFT JOIN public.binary_npgsqllinelinemmarrayd2e1mi mi ON mi.id = m.npgsqllinelinemmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineMArraylineMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineMArraylineMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinemmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models =  ((INpgsqlLineMArraylineMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA), typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA), typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
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
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI), typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MI>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA), typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD2E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD2))]
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
                var models = await ((INpgsqlLineMArraylineMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

