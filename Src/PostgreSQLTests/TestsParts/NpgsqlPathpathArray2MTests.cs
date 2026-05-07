

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
    internal partial interface INpgsqlPathListpathArray
    {
    }
    
    internal partial class NpgsqlPathListpathArray : INpgsqlPathListpathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray2M[] _testData = new NpgsqlPathpathArray2M[]
        {
            new NpgsqlPathpathArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.377069847343234d, y: 0.8175511634643512d), new NpgsqlTypes.NpgsqlPoint(x: 0.7729836239080612d, y: 0.18298623069136055d), new NpgsqlTypes.NpgsqlPoint(x: 0.10953557936775371d, y: 0.13381712864486905d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.008460993397899741d, y: 0.8828672640890087d), new NpgsqlTypes.NpgsqlPoint(x: 0.9090126744259502d, y: 0.9463985028750724d), new NpgsqlTypes.NpgsqlPoint(x: 0.41789333925590677d, y: 0.3525728556972255d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9380757791003578d, y: 0.8854765746094165d), new NpgsqlTypes.NpgsqlPoint(x: 0.030403490509819053d, y: 0.9505391191956751d), new NpgsqlTypes.NpgsqlPoint(x: 0.23367755861126216d, y: 0.8790816443806542d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8051463998360632d, y: 0.4962742333078153d), new NpgsqlTypes.NpgsqlPoint(x: 0.009504598281317778d, y: 0.9546238842148466d), new NpgsqlTypes.NpgsqlPoint(x: 0.6162608703391524d, y: 0.5470736779931872d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.790729402628103d, y: 0.7957723841397196d), new NpgsqlTypes.NpgsqlPoint(x: 0.7329100482758516d, y: 0.9137760321647348d), new NpgsqlTypes.NpgsqlPoint(x: 0.9638001653783711d, y: 0.033627369751484615d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7330628879695926d, y: 0.3258247601830221d), new NpgsqlTypes.NpgsqlPoint(x: 0.5716928308359649d, y: 0.7763946438495251d), new NpgsqlTypes.NpgsqlPoint(x: 0.7440023299045725d, y: 0.5214948006787404d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9134766078287578d, y: 0.5346036492338457d), new NpgsqlTypes.NpgsqlPoint(x: 0.14269733043205823d, y: 0.3678139091617869d), new NpgsqlTypes.NpgsqlPoint(x: 0.8522279966300251d, y: 0.023093106352731096d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21092038424687987d, y: 0.6585228385955232d), new NpgsqlTypes.NpgsqlPoint(x: 0.9219414692648511d, y: 0.6594575873950034d), new NpgsqlTypes.NpgsqlPoint(x: 0.8160640890388224d, y: 0.9069053317482526d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8474911186528198d, y: 0.5018501400941827d), new NpgsqlTypes.NpgsqlPoint(x: 0.4977484206297421d, y: 0.41197278866081555d), new NpgsqlTypes.NpgsqlPoint(x: 0.3638326893898127d, y: 0.7246125790831737d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.582012578418424d, y: 0.12476662704624886d), new NpgsqlTypes.NpgsqlPoint(x: 0.43186634095343523d, y: 0.18051600254818378d), new NpgsqlTypes.NpgsqlPoint(x: 0.4746137415434648d, y: 0.0068354627523324885d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5274831941662476d, y: 0.9815593646569205d), new NpgsqlTypes.NpgsqlPoint(x: 0.4531661450028204d, y: 0.9185659806222053d), new NpgsqlTypes.NpgsqlPoint(x: 0.14069826910131333d, y: 0.1370149259264306d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04431417168152885d, y: 0.8919394471570823d), new NpgsqlTypes.NpgsqlPoint(x: 0.953806318375384d, y: 0.25745435203411715d), new NpgsqlTypes.NpgsqlPoint(x: 0.8545956126168969d, y: 0.9085822489525508d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3158964628029124d, y: 0.39027550685526236d), new NpgsqlTypes.NpgsqlPoint(x: 0.6606518810821984d, y: 0.06855700424250755d), new NpgsqlTypes.NpgsqlPoint(x: 0.1204303166347046d, y: 0.8335384351790218d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33549063723043493d, y: 0.129575855276994d), new NpgsqlTypes.NpgsqlPoint(x: 0.4828085199786405d, y: 0.9158253014577831d), new NpgsqlTypes.NpgsqlPoint(x: 0.2936279289760301d, y: 0.2221564160571391d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7604764853071627d, y: 0.6687409681906793d), new NpgsqlTypes.NpgsqlPoint(x: 0.20257230060799503d, y: 0.5067150211787306d), new NpgsqlTypes.NpgsqlPoint(x: 0.563205005549884d, y: 0.7343001652454829d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9399265674573243d, y: 0.09181558252585054d), new NpgsqlTypes.NpgsqlPoint(x: 0.8262075801403039d, y: 0.18645656612925843d), new NpgsqlTypes.NpgsqlPoint(x: 0.8095802690286662d, y: 0.9071957386328513d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08612319727172635d, y: 0.30862921195452564d), new NpgsqlTypes.NpgsqlPoint(x: 0.34008537752971935d, y: 0.48171537946558585d), new NpgsqlTypes.NpgsqlPoint(x: 0.15359069685384252d, y: 0.5299008199734311d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5357147184272415d, y: 0.9340769543132577d), new NpgsqlTypes.NpgsqlPoint(x: 0.2576475481144521d, y: 0.360142329976157d), new NpgsqlTypes.NpgsqlPoint(x: 0.7361920068866553d, y: 0.7408520697946153d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2891855139492592d, y: 0.7278394266697357d), new NpgsqlTypes.NpgsqlPoint(x: 0.9390664941118128d, y: 0.9420848743100713d), new NpgsqlTypes.NpgsqlPoint(x: 0.9680707812321836d, y: 0.38790375898506624d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9613271169876442d, y: 0.2705945582306899d), new NpgsqlTypes.NpgsqlPoint(x: 0.7403803983504788d, y: 0.5623656894064288d), new NpgsqlTypes.NpgsqlPoint(x: 0.7662159635100304d, y: 0.5650038757741639d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2576484416165312d, y: 0.562934378235836d), new NpgsqlTypes.NpgsqlPoint(x: 0.21719633486381196d, y: 0.7639112355567481d), new NpgsqlTypes.NpgsqlPoint(x: 0.09537986834250456d, y: 0.9757300019454378d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08266749935803719d, y: 0.2733195146648941d), new NpgsqlTypes.NpgsqlPoint(x: 0.8922885751588023d, y: 0.3000188926120849d), new NpgsqlTypes.NpgsqlPoint(x: 0.3363757169852122d, y: 0.2550105732814628d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4709163003745688d, y: 0.8923554458798436d), new NpgsqlTypes.NpgsqlPoint(x: 0.30957060401190617d, y: 0.5553200627955889d), new NpgsqlTypes.NpgsqlPoint(x: 0.46265685442474846d, y: 0.11424837598047888d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16880574829536044d, y: 0.2924230269131066d), new NpgsqlTypes.NpgsqlPoint(x: 0.8066053465944973d, y: 0.0917029580245855d), new NpgsqlTypes.NpgsqlPoint(x: 0.016949127038206835d, y: 0.15193676175029147d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8424169353833697d, y: 0.08470090105096517d), new NpgsqlTypes.NpgsqlPoint(x: 0.8225883225563689d, y: 0.44064713266911626d), new NpgsqlTypes.NpgsqlPoint(x: 0.6771271928290019d, y: 0.21434942322617234d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08103243226663093d, y: 0.7406836107468409d), new NpgsqlTypes.NpgsqlPoint(x: 0.0886513150426298d, y: 0.19716077589201852d), new NpgsqlTypes.NpgsqlPoint(x: 0.18089331593274482d, y: 0.9459287623547873d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8250009992586451d, y: 0.4274952680264408d), new NpgsqlTypes.NpgsqlPoint(x: 0.8554200998314958d, y: 0.15290349074720566d), new NpgsqlTypes.NpgsqlPoint(x: 0.11789453418200335d, y: 0.8424714504564098d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5875347595683545d, y: 0.3470977327608131d), new NpgsqlTypes.NpgsqlPoint(x: 0.18703933426200492d, y: 0.6028196473640661d), new NpgsqlTypes.NpgsqlPoint(x: 0.3470731352785028d, y: 0.740450988853352d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0757775488984953d, y: 0.313628160623039d), new NpgsqlTypes.NpgsqlPoint(x: 0.7495099681909326d, y: 0.4458233213146925d), new NpgsqlTypes.NpgsqlPoint(x: 0.8604591392048779d, y: 0.5550328765259953d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4165179850463925d, y: 0.919989643187463d), new NpgsqlTypes.NpgsqlPoint(x: 0.8909869361532278d, y: 0.1920699869496174d), new NpgsqlTypes.NpgsqlPoint(x: 0.3241943174798928d, y: 0.20208946292046837d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4944084181894316d, y: 0.3101970884933606d), new NpgsqlTypes.NpgsqlPoint(x: 0.05297542257498422d, y: 0.80673755786336d), new NpgsqlTypes.NpgsqlPoint(x: 0.9644341564074315d, y: 0.04583010044173985d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03543491056119563d, y: 0.9729826999626412d), new NpgsqlTypes.NpgsqlPoint(x: 0.8863095446032818d, y: 0.9821874220591651d), new NpgsqlTypes.NpgsqlPoint(x: 0.9424736962611348d, y: 0.6098196607625832d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2634215905978944d, y: 0.7768219348539689d), new NpgsqlTypes.NpgsqlPoint(x: 0.21911392779955186d, y: 0.5326899683785218d), new NpgsqlTypes.NpgsqlPoint(x: 0.8402380753164245d, y: 0.19168431614624437d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4090873472458273d, y: 0.7494544848091331d), new NpgsqlTypes.NpgsqlPoint(x: 0.024848421480297644d, y: 0.11893933413024682d), new NpgsqlTypes.NpgsqlPoint(x: 0.04705833543208238d, y: 0.5887745490398292d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21897530559761935d, y: 0.21812700981019806d), new NpgsqlTypes.NpgsqlPoint(x: 0.01259539532612075d, y: 0.12954891123740664d), new NpgsqlTypes.NpgsqlPoint(x: 0.13799886138079853d, y: 0.5515434990383908d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2585622546689743d, y: 0.42319580001260126d), new NpgsqlTypes.NpgsqlPoint(x: 0.9378508679808362d, y: 0.0012962183709763764d), new NpgsqlTypes.NpgsqlPoint(x: 0.21667149983189704d, y: 0.9177843301809282d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0009310620709828132d, y: 0.47848950620193786d), new NpgsqlTypes.NpgsqlPoint(x: 0.3699588868264386d, y: 0.8777330721502767d), new NpgsqlTypes.NpgsqlPoint(x: 0.8559552664469419d, y: 0.5580900011930597d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9483510936093252d, y: 0.711081098190464d), new NpgsqlTypes.NpgsqlPoint(x: 0.4197528117529561d, y: 0.8762111947640104d), new NpgsqlTypes.NpgsqlPoint(x: 0.7253822433142949d, y: 0.022701676664576675d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31618431602377484d, y: 0.17570982172477867d), new NpgsqlTypes.NpgsqlPoint(x: 0.3481286863877764d, y: 0.18716989938793627d), new NpgsqlTypes.NpgsqlPoint(x: 0.9704365079478685d, y: 0.05093989907068963d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7958192584113429d, y: 0.22038353267536792d), new NpgsqlTypes.NpgsqlPoint(x: 0.5887080661572139d, y: 0.0755575186967623d), new NpgsqlTypes.NpgsqlPoint(x: 0.9885164954697311d, y: 0.3768842974589056d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6467522182426106d, y: 0.5919002631196654d), new NpgsqlTypes.NpgsqlPoint(x: 0.2814610695339509d, y: 0.16978852870782557d), new NpgsqlTypes.NpgsqlPoint(x: 0.987204623278649d, y: 0.2983323508974176d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6825503423285655d, y: 0.09010707967609799d), new NpgsqlTypes.NpgsqlPoint(x: 0.8371392189293023d, y: 0.3040870572088312d), new NpgsqlTypes.NpgsqlPoint(x: 0.4210934930732575d, y: 0.24398032246783286d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11401182109888874d, y: 0.016591810818417985d), new NpgsqlTypes.NpgsqlPoint(x: 0.1254599014897756d, y: 0.14554387236163124d), new NpgsqlTypes.NpgsqlPoint(x: 0.5991680445706875d, y: 0.21296465448324076d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23396020678638485d, y: 0.6238461012719774d), new NpgsqlTypes.NpgsqlPoint(x: 0.4829579550905324d, y: 0.3135798948442313d), new NpgsqlTypes.NpgsqlPoint(x: 0.9311745047423848d, y: 0.7934361024403433d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7134822900365082d, y: 0.8072249918335854d), new NpgsqlTypes.NpgsqlPoint(x: 0.8560682824925141d, y: 0.9525854401644847d), new NpgsqlTypes.NpgsqlPoint(x: 0.6806229713260957d, y: 0.2472525210509824d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6926045018099425d, y: 0.5037280838039021d), new NpgsqlTypes.NpgsqlPoint(x: 0.07134273854923545d, y: 0.8919646913843428d), new NpgsqlTypes.NpgsqlPoint(x: 0.9860591829735353d, y: 0.9802709759650039d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42613466450669724d, y: 0.6430140624427287d), new NpgsqlTypes.NpgsqlPoint(x: 0.7885282783034574d, y: 0.07964367721959753d), new NpgsqlTypes.NpgsqlPoint(x: 0.49741143890447304d, y: 0.6365233862951007d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7060287480868068d, y: 0.597416571515664d), new NpgsqlTypes.NpgsqlPoint(x: 0.0775067761945808d, y: 0.42147640010744314d), new NpgsqlTypes.NpgsqlPoint(x: 0.262037352748406d, y: 0.34611108844892724d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5536356816260335d, y: 0.4548161464017485d), new NpgsqlTypes.NpgsqlPoint(x: 0.3740894769380082d, y: 0.17924901431747298d), new NpgsqlTypes.NpgsqlPoint(x: 0.6181306099383316d, y: 0.6902315981811316d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7785378035143061d, y: 0.5692625543053111d), new NpgsqlTypes.NpgsqlPoint(x: 0.8306562947713555d, y: 0.3779925526478216d), new NpgsqlTypes.NpgsqlPoint(x: 0.8177862409599531d, y: 0.6753447982310185d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47849564022381064d, y: 0.4020799729486877d), new NpgsqlTypes.NpgsqlPoint(x: 0.9903430255465464d, y: 0.929830883944003d), new NpgsqlTypes.NpgsqlPoint(x: 0.011199808591980553d, y: 0.42378508923110747d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.798032224965633d, y: 0.2196254959517534d), new NpgsqlTypes.NpgsqlPoint(x: 0.15620793564736146d, y: 0.5534866269326159d), new NpgsqlTypes.NpgsqlPoint(x: 0.8264037588772538d, y: 0.07480402988897605d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.549703854452106d, y: 0.5316692596015509d), new NpgsqlTypes.NpgsqlPoint(x: 0.7606623206793124d, y: 0.8882555588043879d), new NpgsqlTypes.NpgsqlPoint(x: 0.47811720580211503d, y: 0.6969170847705772d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.584215399186922d, y: 0.952424597769143d), new NpgsqlTypes.NpgsqlPoint(x: 0.19860859149758003d, y: 0.10690110808192788d), new NpgsqlTypes.NpgsqlPoint(x: 0.45937044842731967d, y: 0.3009861270886879d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6290226045054294d, y: 0.45944593768327624d), new NpgsqlTypes.NpgsqlPoint(x: 0.5170887941902436d, y: 0.47729272603330986d), new NpgsqlTypes.NpgsqlPoint(x: 0.44327959325885324d, y: 0.603306358382903d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9357458957947484d, y: 0.6386657687258456d), new NpgsqlTypes.NpgsqlPoint(x: 0.24630434332813678d, y: 0.7527216001287887d), new NpgsqlTypes.NpgsqlPoint(x: 0.09416715289257127d, y: 0.7187072273207387d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8228137774544831d, y: 0.6678410300665111d), new NpgsqlTypes.NpgsqlPoint(x: 0.7223696529942741d, y: 0.48348996063565397d), new NpgsqlTypes.NpgsqlPoint(x: 0.26443125808936074d, y: 0.4586986289061815d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8088549240207877d, y: 0.7472273950184841d), new NpgsqlTypes.NpgsqlPoint(x: 0.9905135986606954d, y: 0.7019270545275992d), new NpgsqlTypes.NpgsqlPoint(x: 0.05819499308867426d, y: 0.07289236150025324d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37152432613313713d, y: 0.5352157309549979d), new NpgsqlTypes.NpgsqlPoint(x: 0.4963597246204383d, y: 0.21663502091276177d), new NpgsqlTypes.NpgsqlPoint(x: 0.3831875472240638d, y: 0.0707819078451869d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3032845004585977d, y: 0.08639613097889753d), new NpgsqlTypes.NpgsqlPoint(x: 0.18522843652502774d, y: 0.4626410417288137d), new NpgsqlTypes.NpgsqlPoint(x: 0.7393619556376398d, y: 0.341287521137269d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.232489329338453d, y: 0.9710968768053778d), new NpgsqlTypes.NpgsqlPoint(x: 0.117038261530228d, y: 0.47262285818372296d), new NpgsqlTypes.NpgsqlPoint(x: 0.6677115243889146d, y: 0.7094656895205648d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32491619621607437d, y: 0.2516950353946683d), new NpgsqlTypes.NpgsqlPoint(x: 0.021994925419875244d, y: 0.25383838739349796d), new NpgsqlTypes.NpgsqlPoint(x: 0.734134702887665d, y: 0.642974136403107d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18089843400947336d, y: 0.8752264191903535d), new NpgsqlTypes.NpgsqlPoint(x: 0.6403174484521873d, y: 0.6425445012953d), new NpgsqlTypes.NpgsqlPoint(x: 0.23028556847385062d, y: 0.550156179040471d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9505844769130074d, y: 0.8310011887249197d), new NpgsqlTypes.NpgsqlPoint(x: 0.17909023975895533d, y: 0.3082316771461645d), new NpgsqlTypes.NpgsqlPoint(x: 0.722734858275781d, y: 0.9298176775744892d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8457713012003323d, y: 0.43539043212613815d), new NpgsqlTypes.NpgsqlPoint(x: 0.6705065796679089d, y: 0.164500089022646d), new NpgsqlTypes.NpgsqlPoint(x: 0.05595016504023065d, y: 0.2045025314265294d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5773022574770756d, y: 0.9005526693630473d), new NpgsqlTypes.NpgsqlPoint(x: 0.5047308555488257d, y: 0.1695285995451553d), new NpgsqlTypes.NpgsqlPoint(x: 0.6397969768242712d, y: 0.2932191408617739d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7917502894383378d, y: 0.3719422676193298d), new NpgsqlTypes.NpgsqlPoint(x: 0.2690386315581994d, y: 0.7674977993460406d), new NpgsqlTypes.NpgsqlPoint(x: 0.5853461899261858d, y: 0.5846185729411821d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5378843508753436d, y: 0.5561715340369893d), new NpgsqlTypes.NpgsqlPoint(x: 0.5564436986530072d, y: 0.3280115082440729d), new NpgsqlTypes.NpgsqlPoint(x: 0.22698869729036597d, y: 0.041339638074903706d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4593258661940137d, y: 0.8834489157915283d), new NpgsqlTypes.NpgsqlPoint(x: 0.8953255286102236d, y: 0.6611061074126486d), new NpgsqlTypes.NpgsqlPoint(x: 0.36634990779044563d, y: 0.3164818911133914d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6710633703334958d, y: 0.359906133417352d), new NpgsqlTypes.NpgsqlPoint(x: 0.6764471674706318d, y: 0.06420875984351537d), new NpgsqlTypes.NpgsqlPoint(x: 0.1611099344540221d, y: 0.3337036733114427d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5202235084889236d, y: 0.6276394761866638d), new NpgsqlTypes.NpgsqlPoint(x: 0.06549003957826427d, y: 0.5796356236220785d), new NpgsqlTypes.NpgsqlPoint(x: 0.3349818795238556d, y: 0.6583551177286089d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6717603230394413d, y: 0.2592283185604063d), new NpgsqlTypes.NpgsqlPoint(x: 0.19756200579387218d, y: 0.9451664079447762d), new NpgsqlTypes.NpgsqlPoint(x: 0.13838536213066555d, y: 0.5649216215283012d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6003275565053341d, y: 0.1836963061775888d), new NpgsqlTypes.NpgsqlPoint(x: 0.5777236109489262d, y: 0.43241973949782164d), new NpgsqlTypes.NpgsqlPoint(x: 0.4181748954011746d, y: 0.11780545363497552d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3719117958682d, y: 0.8876593116143263d), new NpgsqlTypes.NpgsqlPoint(x: 0.15126226715876256d, y: 0.4795515517361333d), new NpgsqlTypes.NpgsqlPoint(x: 0.3538042714151982d, y: 0.0766810740678624d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5137916818944158d, y: 0.25384379342257435d), new NpgsqlTypes.NpgsqlPoint(x: 0.55400526333604d, y: 0.08621788423898791d), new NpgsqlTypes.NpgsqlPoint(x: 0.3602264754980544d, y: 0.07388254715538067d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8923844579574288d, y: 0.4742278552386826d), new NpgsqlTypes.NpgsqlPoint(x: 0.8236712913629834d, y: 0.8655713158128634d), new NpgsqlTypes.NpgsqlPoint(x: 0.39994160161282477d, y: 0.1172089525850959d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05229292858556267d, y: 0.7830527060887293d), new NpgsqlTypes.NpgsqlPoint(x: 0.4154854039228385d, y: 0.8025430115916841d), new NpgsqlTypes.NpgsqlPoint(x: 0.3492649405908208d, y: 0.22987403876162704d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3787019472659523d, y: 0.5534298250155206d), new NpgsqlTypes.NpgsqlPoint(x: 0.7870936364599406d, y: 0.6691679425514991d), new NpgsqlTypes.NpgsqlPoint(x: 0.8288345032289346d, y: 0.3957631279176823d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03972376336036276d, y: 0.2337775602450799d), new NpgsqlTypes.NpgsqlPoint(x: 0.9448874325656628d, y: 0.8827324343346912d), new NpgsqlTypes.NpgsqlPoint(x: 0.7080211994020327d, y: 0.8880160053321253d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5576490454364575d, y: 0.12466072071609768d), new NpgsqlTypes.NpgsqlPoint(x: 0.7178911296358506d, y: 0.6325377427880373d), new NpgsqlTypes.NpgsqlPoint(x: 0.08031874931183136d, y: 0.33390330509096333d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9100185985029604d, y: 0.8654077666163867d), new NpgsqlTypes.NpgsqlPoint(x: 0.862736477144655d, y: 0.4711464317611417d), new NpgsqlTypes.NpgsqlPoint(x: 0.718680548303351d, y: 0.5864142508606796d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7633661350123883d, y: 0.7649087370024953d), new NpgsqlTypes.NpgsqlPoint(x: 0.9941139821191819d, y: 0.9116009891485548d), new NpgsqlTypes.NpgsqlPoint(x: 0.33202661284820634d, y: 0.8320486952282111d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46678884675108534d, y: 0.5482742650259247d), new NpgsqlTypes.NpgsqlPoint(x: 0.47606049365922376d, y: 0.3452415425930392d), new NpgsqlTypes.NpgsqlPoint(x: 0.7426986194743793d, y: 0.25910271748024594d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4791006968225915d, y: 0.7559514256751187d), new NpgsqlTypes.NpgsqlPoint(x: 0.15902508233945611d, y: 0.011658772064843004d), new NpgsqlTypes.NpgsqlPoint(x: 0.15314966295789045d, y: 0.5565830309709977d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8997614369327466d, y: 0.5140962803522038d), new NpgsqlTypes.NpgsqlPoint(x: 0.46594739479765634d, y: 0.3229685393281524d), new NpgsqlTypes.NpgsqlPoint(x: 0.2839921260442091d, y: 0.6274392334659405d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5574399117484157d, y: 0.04923966229664911d), new NpgsqlTypes.NpgsqlPoint(x: 0.5205580082727816d, y: 0.9291758952161965d), new NpgsqlTypes.NpgsqlPoint(x: 0.7273756726841645d, y: 0.5940456690449684d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3989295035433803d, y: 0.43436309646555227d), new NpgsqlTypes.NpgsqlPoint(x: 0.13408945105438597d, y: 0.08509157659695354d), new NpgsqlTypes.NpgsqlPoint(x: 0.07788228537703379d, y: 0.41631145416797843d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5248317768458463d, y: 0.8772826222491554d), new NpgsqlTypes.NpgsqlPoint(x: 0.9459622302504886d, y: 0.6179107917126895d), new NpgsqlTypes.NpgsqlPoint(x: 0.43867668757195566d, y: 0.8036027774327741d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04441592775729297d, y: 0.6655371509187026d), new NpgsqlTypes.NpgsqlPoint(x: 0.18875655918703893d, y: 0.9262277114174274d), new NpgsqlTypes.NpgsqlPoint(x: 0.4841634240378059d, y: 0.9343005255116407d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05454391765366806d, y: 0.7152009281112172d), new NpgsqlTypes.NpgsqlPoint(x: 0.6617852673132445d, y: 0.5080897668226825d), new NpgsqlTypes.NpgsqlPoint(x: 0.9722792629756156d, y: 0.8310821030029094d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6868756792464427d, y: 0.277452188967241d), new NpgsqlTypes.NpgsqlPoint(x: 0.9668862973720215d, y: 0.8395523024577278d), new NpgsqlTypes.NpgsqlPoint(x: 0.7433020801392685d, y: 0.4385985722186567d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11402480599698128d, y: 0.7132621038626487d), new NpgsqlTypes.NpgsqlPoint(x: 0.7588720445003402d, y: 0.480680427270464d), new NpgsqlTypes.NpgsqlPoint(x: 0.7990307654041057d, y: 0.439699375926789d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8489448938447998d, y: 0.6139441220104367d), new NpgsqlTypes.NpgsqlPoint(x: 0.19846353583354148d, y: 0.29723168850982085d), new NpgsqlTypes.NpgsqlPoint(x: 0.4105150092792714d, y: 0.055750184775849476d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10628906951087402d, y: 0.2977183258261573d), new NpgsqlTypes.NpgsqlPoint(x: 0.16458589049533268d, y: 0.8331932965058165d), new NpgsqlTypes.NpgsqlPoint(x: 0.6387259158361192d, y: 0.004729064297329999d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8333160914318047d, y: 0.4832327782553896d), new NpgsqlTypes.NpgsqlPoint(x: 0.3513111426403278d, y: 0.4144525342476888d), new NpgsqlTypes.NpgsqlPoint(x: 0.47317236204386304d, y: 0.21960404177719983d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04321746414441696d, y: 0.11461601276720712d), new NpgsqlTypes.NpgsqlPoint(x: 0.4954188955976052d, y: 0.8246140150606519d), new NpgsqlTypes.NpgsqlPoint(x: 0.10686760802545159d, y: 0.7047636036701157d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5055114628544848d, y: 0.5332611335060075d), new NpgsqlTypes.NpgsqlPoint(x: 0.3009995515563554d, y: 0.7256884289389582d), new NpgsqlTypes.NpgsqlPoint(x: 0.6255385918118149d, y: 0.3557684865280215d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42867390113599124d, y: 0.4240100818355702d), new NpgsqlTypes.NpgsqlPoint(x: 0.7578828625089418d, y: 0.5569945757461624d), new NpgsqlTypes.NpgsqlPoint(x: 0.6745835409464338d, y: 0.7501378733574411d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7376760781233425d, y: 0.7765726709664853d), new NpgsqlTypes.NpgsqlPoint(x: 0.9726499665903356d, y: 0.3725740404376736d), new NpgsqlTypes.NpgsqlPoint(x: 0.047775884781549816d, y: 0.801507653984485d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1674309803398515d, y: 0.6682884486148672d), new NpgsqlTypes.NpgsqlPoint(x: 0.925654868072909d, y: 0.48580967849108014d), new NpgsqlTypes.NpgsqlPoint(x: 0.6241422460143107d, y: 0.1726920184716184d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37351103609968117d, y: 0.4210423627197183d), new NpgsqlTypes.NpgsqlPoint(x: 0.7774372908851849d, y: 0.772190318432025d), new NpgsqlTypes.NpgsqlPoint(x: 0.641175848730836d, y: 0.952013220376951d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7510946351692198d, y: 0.7566593457632624d), new NpgsqlTypes.NpgsqlPoint(x: 0.22635290820049558d, y: 0.4947102907241717d), new NpgsqlTypes.NpgsqlPoint(x: 0.22280324602990698d, y: 0.5983359362405158d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7676263077627715d, y: 0.2924123101767302d), new NpgsqlTypes.NpgsqlPoint(x: 0.3750329738789413d, y: 0.17501988421571812d), new NpgsqlTypes.NpgsqlPoint(x: 0.45809231520942173d, y: 0.47872333622808705d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9878505696651954d, y: 0.6527296674850119d), new NpgsqlTypes.NpgsqlPoint(x: 0.23925514424171335d, y: 0.402099688123128d), new NpgsqlTypes.NpgsqlPoint(x: 0.5829527008745684d, y: 0.4825834540636309d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6044440071491574d, y: 0.035720595598084826d), new NpgsqlTypes.NpgsqlPoint(x: 0.497528158700115d, y: 0.7671641966089597d), new NpgsqlTypes.NpgsqlPoint(x: 0.2284245580322597d, y: 0.21819416590092433d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4206468524567808d, y: 0.4677563530457527d), new NpgsqlTypes.NpgsqlPoint(x: 0.6362501444477178d, y: 0.8614619677486964d), new NpgsqlTypes.NpgsqlPoint(x: 0.9106040491770405d, y: 0.9718576636633881d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45922784459601773d, y: 0.992246151016889d), new NpgsqlTypes.NpgsqlPoint(x: 0.761603698208146d, y: 0.138315319644282d), new NpgsqlTypes.NpgsqlPoint(x: 0.20019888282383247d, y: 0.20866350128016475d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15653129311309333d, y: 0.5903842370528974d), new NpgsqlTypes.NpgsqlPoint(x: 0.4074823666141655d, y: 0.8030152546188433d), new NpgsqlTypes.NpgsqlPoint(x: 0.7897559123428798d, y: 0.8073740744959882d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9396657439751968d, y: 0.6880894744559183d), new NpgsqlTypes.NpgsqlPoint(x: 0.5165542891643621d, y: 0.9525972947154983d), new NpgsqlTypes.NpgsqlPoint(x: 0.09573946396008404d, y: 0.9630087504906235d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.362982591413878d, y: 0.16032709590708072d), new NpgsqlTypes.NpgsqlPoint(x: 0.40490247276195734d, y: 0.9752207055592788d), new NpgsqlTypes.NpgsqlPoint(x: 0.8158580802952623d, y: 0.2516900652976185d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7100853836664799d, y: 0.5436992385121583d), new NpgsqlTypes.NpgsqlPoint(x: 0.6268510138899213d, y: 0.46652610276642836d), new NpgsqlTypes.NpgsqlPoint(x: 0.8190117012567272d, y: 0.8872503458996847d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27330929194631026d, y: 0.061629951458245236d), new NpgsqlTypes.NpgsqlPoint(x: 0.3765158321583012d, y: 0.9002474512004989d), new NpgsqlTypes.NpgsqlPoint(x: 0.15801155108136145d, y: 0.7826244047653595d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04125083311580591d, y: 0.5983728696991854d), new NpgsqlTypes.NpgsqlPoint(x: 0.7777211947802376d, y: 0.552948469261818d), new NpgsqlTypes.NpgsqlPoint(x: 0.3785489877071363d, y: 0.45102394093929454d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8222313746144653d, y: 0.6316016167796816d), new NpgsqlTypes.NpgsqlPoint(x: 0.7120350299408977d, y: 0.6274864745038637d), new NpgsqlTypes.NpgsqlPoint(x: 0.7484591512860022d, y: 0.18816358452788395d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4831631109657665d, y: 0.7434523847317929d), new NpgsqlTypes.NpgsqlPoint(x: 0.49399084026794726d, y: 0.5617170947439898d), new NpgsqlTypes.NpgsqlPoint(x: 0.5087271633377445d, y: 0.960481928646422d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8859933746703068d, y: 0.6681230248522333d), new NpgsqlTypes.NpgsqlPoint(x: 0.6794792870745923d, y: 0.9228597152612539d), new NpgsqlTypes.NpgsqlPoint(x: 0.506344918083088d, y: 0.6689590550022111d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8840479084249925d, y: 0.065337730312935d), new NpgsqlTypes.NpgsqlPoint(x: 0.9620882097966224d, y: 0.6077234446188673d), new NpgsqlTypes.NpgsqlPoint(x: 0.217416203047479d, y: 0.7770611411518107d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.919817676520484d, y: 0.939020007079705d), new NpgsqlTypes.NpgsqlPoint(x: 0.36975040883118204d, y: 0.25210520326007635d), new NpgsqlTypes.NpgsqlPoint(x: 0.8880176527480667d, y: 0.005233710369030642d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1428528212285155d, y: 0.7514340896938431d), new NpgsqlTypes.NpgsqlPoint(x: 0.076684389945333d, y: 0.5224712236575441d), new NpgsqlTypes.NpgsqlPoint(x: 0.9724632134700265d, y: 0.9321756064529749d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7637624484211054d, y: 0.13988868602006588d), new NpgsqlTypes.NpgsqlPoint(x: 0.744203258080403d, y: 0.25539139399830957d), new NpgsqlTypes.NpgsqlPoint(x: 0.6277381044780406d, y: 0.21805695752506327d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22435887393523446d, y: 0.08082822978602489d), new NpgsqlTypes.NpgsqlPoint(x: 0.6202929933529577d, y: 0.940457491341904d), new NpgsqlTypes.NpgsqlPoint(x: 0.6535057241555995d, y: 0.8334416081612385d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8879705946936443d, y: 0.9935434532205715d), new NpgsqlTypes.NpgsqlPoint(x: 0.9961839475688491d, y: 0.32321228437728045d), new NpgsqlTypes.NpgsqlPoint(x: 0.18184982677332306d, y: 0.6658519482068543d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9120544221584305d, y: 0.04651367101800141d), new NpgsqlTypes.NpgsqlPoint(x: 0.5574691595019928d, y: 0.8218029471368719d), new NpgsqlTypes.NpgsqlPoint(x: 0.08499846265940858d, y: 0.002591876056231346d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5508961006977923d, y: 0.9624575187081252d), new NpgsqlTypes.NpgsqlPoint(x: 0.8005913241870195d, y: 0.07752362022117809d), new NpgsqlTypes.NpgsqlPoint(x: 0.47241981641211805d, y: 0.42286826265886535d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.288851101372538d, y: 0.02479004666743312d), new NpgsqlTypes.NpgsqlPoint(x: 0.17651213576875402d, y: 0.7959434242183148d), new NpgsqlTypes.NpgsqlPoint(x: 0.955795779828684d, y: 0.16056232292202666d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3172695649228898d, y: 0.4317625159257096d), new NpgsqlTypes.NpgsqlPoint(x: 0.7346744413391236d, y: 0.33805335283608273d), new NpgsqlTypes.NpgsqlPoint(x: 0.5475718982085734d, y: 0.22011066115187206d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7487146548178508d, y: 0.9538918995815561d), new NpgsqlTypes.NpgsqlPoint(x: 0.9160157374512451d, y: 0.48338636494718856d), new NpgsqlTypes.NpgsqlPoint(x: 0.28446379574531866d, y: 0.04943354634584929d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2721385956137141d, y: 0.9110193356828301d), new NpgsqlTypes.NpgsqlPoint(x: 0.8738466221133352d, y: 0.5207250097868344d), new NpgsqlTypes.NpgsqlPoint(x: 0.8124878531244274d, y: 0.8756620743186089d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15949873351146904d, y: 0.27142944138630376d), new NpgsqlTypes.NpgsqlPoint(x: 0.30184956164793064d, y: 0.540720057364367d), new NpgsqlTypes.NpgsqlPoint(x: 0.1749505355466756d, y: 0.336688172364615d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09872126512187829d, y: 0.3752579339094141d), new NpgsqlTypes.NpgsqlPoint(x: 0.7376218403243734d, y: 0.4195272937101334d), new NpgsqlTypes.NpgsqlPoint(x: 0.0766050312820683d, y: 0.3497055097902044d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8811260617293842d, y: 0.7940301546035945d), new NpgsqlTypes.NpgsqlPoint(x: 0.5302532613297161d, y: 0.06846148774013283d), new NpgsqlTypes.NpgsqlPoint(x: 0.2091348533740458d, y: 0.8362930197204073d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9298765894551536d, y: 0.8050530601181288d), new NpgsqlTypes.NpgsqlPoint(x: 0.7885944031630803d, y: 0.8100379593847306d), new NpgsqlTypes.NpgsqlPoint(x: 0.7204653270560758d, y: 0.7921348559112737d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.094604283445481d, y: 0.4778492633979875d), new NpgsqlTypes.NpgsqlPoint(x: 0.47775284044207145d, y: 0.8158745145503988d), new NpgsqlTypes.NpgsqlPoint(x: 0.8668661499366801d, y: 0.019629387532054565d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30679372912273595d, y: 0.14978590944913062d), new NpgsqlTypes.NpgsqlPoint(x: 0.3258913760691726d, y: 0.3953847671858419d), new NpgsqlTypes.NpgsqlPoint(x: 0.2266804467045459d, y: 0.4667896228805575d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.393823654902726d, y: 0.2976196456269462d), new NpgsqlTypes.NpgsqlPoint(x: 0.16531820684671328d, y: 0.91988523613799d), new NpgsqlTypes.NpgsqlPoint(x: 0.29099762963709275d, y: 0.21651107595794294d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0659442547794592d, y: 0.9023599215942901d), new NpgsqlTypes.NpgsqlPoint(x: 0.17282249941115202d, y: 0.9272991948242261d), new NpgsqlTypes.NpgsqlPoint(x: 0.16585921667017378d, y: 0.5371138338386302d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8421844652651174d, y: 0.8850171164657822d), new NpgsqlTypes.NpgsqlPoint(x: 0.9895878779300677d, y: 0.8248356229019375d), new NpgsqlTypes.NpgsqlPoint(x: 0.26264318272867815d, y: 0.3046318180110882d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46781618172165007d, y: 0.053496847503893386d), new NpgsqlTypes.NpgsqlPoint(x: 0.07739438410492716d, y: 0.4371509989768325d), new NpgsqlTypes.NpgsqlPoint(x: 0.2755282492943184d, y: 0.4871002892870777d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9172917525197398d, y: 0.8013553162330973d), new NpgsqlTypes.NpgsqlPoint(x: 0.35672873348187184d, y: 0.5821808220422009d), new NpgsqlTypes.NpgsqlPoint(x: 0.9052706059459396d, y: 0.5845433812487232d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9974100436487603d, y: 0.7491723855096187d), new NpgsqlTypes.NpgsqlPoint(x: 0.30527770407972665d, y: 0.4268935763192665d), new NpgsqlTypes.NpgsqlPoint(x: 0.7621646848710385d, y: 0.12723439075768128d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35341735889842074d, y: 0.5750758952644467d), new NpgsqlTypes.NpgsqlPoint(x: 0.9636192357309005d, y: 0.34078001730819174d), new NpgsqlTypes.NpgsqlPoint(x: 0.12934659814615757d, y: 0.9507081310663124d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4212087220448032d, y: 0.590320448975257d), new NpgsqlTypes.NpgsqlPoint(x: 0.24336153690832363d, y: 0.5993280537339081d), new NpgsqlTypes.NpgsqlPoint(x: 0.3516370828096048d, y: 0.12094084109240011d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03418987466708279d, y: 0.06697368439607998d), new NpgsqlTypes.NpgsqlPoint(x: 0.9422043079650506d, y: 0.11910705044330927d), new NpgsqlTypes.NpgsqlPoint(x: 0.7197692258135131d, y: 0.26732915872650465d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.657263949815261d, y: 0.22087540588703758d), new NpgsqlTypes.NpgsqlPoint(x: 0.6730050667693434d, y: 0.5014119186223981d), new NpgsqlTypes.NpgsqlPoint(x: 0.8670492609901237d, y: 0.7810719628442487d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6705027236769914d, y: 0.6114612554176755d), new NpgsqlTypes.NpgsqlPoint(x: 0.6591429732420366d, y: 0.4905283424042056d), new NpgsqlTypes.NpgsqlPoint(x: 0.9958131035495946d, y: 0.8027532142654775d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08684328683330822d, y: 0.9304851823260025d), new NpgsqlTypes.NpgsqlPoint(x: 0.7603388326649757d, y: 0.3359956187539539d), new NpgsqlTypes.NpgsqlPoint(x: 0.46115789402272256d, y: 0.6504452130452968d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3349563888453456d, y: 0.9248091057731623d), new NpgsqlTypes.NpgsqlPoint(x: 0.609073617633261d, y: 0.7489560404984521d), new NpgsqlTypes.NpgsqlPoint(x: 0.5724350978255247d, y: 0.1351671149215612d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5259920495012698d, y: 0.642192123610925d), new NpgsqlTypes.NpgsqlPoint(x: 0.5084970795292648d, y: 0.9619230761496582d), new NpgsqlTypes.NpgsqlPoint(x: 0.131032081394164d, y: 0.07426742481956461d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25159397616674517d, y: 0.885960045726275d), new NpgsqlTypes.NpgsqlPoint(x: 0.7763435967130029d, y: 0.7668128339361399d), new NpgsqlTypes.NpgsqlPoint(x: 0.03541546758599634d, y: 0.9799763046919215d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5472910160780796d, y: 0.746141534960368d), new NpgsqlTypes.NpgsqlPoint(x: 0.5965426410684702d, y: 0.5794011929325279d), new NpgsqlTypes.NpgsqlPoint(x: 0.9866273501967613d, y: 0.7634725228919423d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.339264811331063d, y: 0.23561390911116098d), new NpgsqlTypes.NpgsqlPoint(x: 0.8796579583827582d, y: 0.8883977507295807d), new NpgsqlTypes.NpgsqlPoint(x: 0.8062101693247978d, y: 0.4207199356012006d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.845236033951774d, y: 0.7639961941285169d), new NpgsqlTypes.NpgsqlPoint(x: 0.9814519324539548d, y: 0.515545886561993d), new NpgsqlTypes.NpgsqlPoint(x: 0.17497843532163826d, y: 0.9867191847533647d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6548480522861659d, y: 0.5670777358280261d), new NpgsqlTypes.NpgsqlPoint(x: 0.10695788479841706d, y: 0.5367071514611147d), new NpgsqlTypes.NpgsqlPoint(x: 0.6201192585149233d, y: 0.8837731250222255d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2677994364079007d, y: 0.5222036036261682d), new NpgsqlTypes.NpgsqlPoint(x: 0.6852613712083053d, y: 0.9693361150058394d), new NpgsqlTypes.NpgsqlPoint(x: 0.26421145514760613d, y: 0.8943362422346596d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19891383269832397d, y: 0.5333888340240713d), new NpgsqlTypes.NpgsqlPoint(x: 0.6391316213400741d, y: 0.960257133808486d), new NpgsqlTypes.NpgsqlPoint(x: 0.4806884883063298d, y: 0.049243117256141056d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.044030229497761475d, y: 0.8653360835285584d), new NpgsqlTypes.NpgsqlPoint(x: 0.3924921406710661d, y: 0.20326946127623047d), new NpgsqlTypes.NpgsqlPoint(x: 0.9641100350001424d, y: 0.557737319915047d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.034402814232082024d, y: 0.5801533392990801d), new NpgsqlTypes.NpgsqlPoint(x: 0.42699335769516267d, y: 0.1831233299175048d), new NpgsqlTypes.NpgsqlPoint(x: 0.7593033850968781d, y: 0.42599662878323685d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.021341958121286364d, y: 0.09723681303198206d), new NpgsqlTypes.NpgsqlPoint(x: 0.4810991731433999d, y: 0.1691595331586272d), new NpgsqlTypes.NpgsqlPoint(x: 0.3995841731028946d, y: 0.3515988179869215d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3787071846845975d, y: 0.34748348341334545d), new NpgsqlTypes.NpgsqlPoint(x: 0.390968889891556d, y: 0.05892716971988288d), new NpgsqlTypes.NpgsqlPoint(x: 0.38570294245250036d, y: 0.36961282666959017d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.546830380310258d, y: 0.684275767495902d), new NpgsqlTypes.NpgsqlPoint(x: 0.9737867902001d, y: 0.5104306241150106d), new NpgsqlTypes.NpgsqlPoint(x: 0.26449764839839207d, y: 0.3023309179469301d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8270544762422583d, y: 0.6051494648241693d), new NpgsqlTypes.NpgsqlPoint(x: 0.45393621094816194d, y: 0.8986841372907122d), new NpgsqlTypes.NpgsqlPoint(x: 0.6809774871759865d, y: 0.9075985637097351d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8135822779093322d, y: 0.9283691964898315d), new NpgsqlTypes.NpgsqlPoint(x: 0.8371396034404297d, y: 0.4592027973425401d), new NpgsqlTypes.NpgsqlPoint(x: 0.03170551947719791d, y: 0.21351614109271d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3079790136149394d, y: 0.6102624646106339d), new NpgsqlTypes.NpgsqlPoint(x: 0.84238064741834d, y: 0.5497187897657256d), new NpgsqlTypes.NpgsqlPoint(x: 0.614062167610874d, y: 0.26934792715477596d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.233623717585403d, y: 0.15504891378036512d), new NpgsqlTypes.NpgsqlPoint(x: 0.48468861814647146d, y: 0.42200378787880766d), new NpgsqlTypes.NpgsqlPoint(x: 0.7969636322970958d, y: 0.6332888471870498d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1946364324948986d, y: 0.06647155805960525d), new NpgsqlTypes.NpgsqlPoint(x: 0.7146024223613295d, y: 0.004665780546848963d), new NpgsqlTypes.NpgsqlPoint(x: 0.17177329033896005d, y: 0.7589479799577482d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5158925300982654d, y: 0.6359019106018999d), new NpgsqlTypes.NpgsqlPoint(x: 0.8378326259917781d, y: 0.16766021847244006d), new NpgsqlTypes.NpgsqlPoint(x: 0.6136928079962115d, y: 0.2393819324185953d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1656999231138936d, y: 0.6932436501969917d), new NpgsqlTypes.NpgsqlPoint(x: 0.9175904290812518d, y: 0.7647165770105621d), new NpgsqlTypes.NpgsqlPoint(x: 0.06567304971331689d, y: 0.5681019473857727d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7104101835405793d, y: 0.640061028020983d), new NpgsqlTypes.NpgsqlPoint(x: 0.6088596827102232d, y: 0.5008142510119336d), new NpgsqlTypes.NpgsqlPoint(x: 0.5006484104731572d, y: 0.2037225327217832d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3216289020286732d, y: 0.7943739622511258d), new NpgsqlTypes.NpgsqlPoint(x: 0.4530970961468641d, y: 0.5450343568004827d), new NpgsqlTypes.NpgsqlPoint(x: 0.5060737213006808d, y: 0.07292612573273127d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2759988832200778d, y: 0.5614902084620704d), new NpgsqlTypes.NpgsqlPoint(x: 0.2003252450682239d, y: 0.25092254013507354d), new NpgsqlTypes.NpgsqlPoint(x: 0.37022363533171154d, y: 0.5763145821765449d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8946322721640789d, y: 0.976665892417643d), new NpgsqlTypes.NpgsqlPoint(x: 0.47031244682511897d, y: 0.9576230531617588d), new NpgsqlTypes.NpgsqlPoint(x: 0.7905353238308155d, y: 0.8551879660380055d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12168014592274634d, y: 0.11641208364905176d), new NpgsqlTypes.NpgsqlPoint(x: 0.19736549266002767d, y: 0.46872960793470175d), new NpgsqlTypes.NpgsqlPoint(x: 0.9456367165520515d, y: 0.36810239549862944d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03080821394579769d, y: 0.619898285768245d), new NpgsqlTypes.NpgsqlPoint(x: 0.8321503905184552d, y: 0.5472317187003393d), new NpgsqlTypes.NpgsqlPoint(x: 0.08804883287984455d, y: 0.22753814587392074d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23126544518580072d, y: 0.7322643439838238d), new NpgsqlTypes.NpgsqlPoint(x: 0.4260019071652522d, y: 0.7104475662855001d), new NpgsqlTypes.NpgsqlPoint(x: 0.24419967241487162d, y: 0.8210605590847039d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7763672809767884d, y: 0.7566180823271524d), new NpgsqlTypes.NpgsqlPoint(x: 0.9178274992202506d, y: 0.48998611089808897d), new NpgsqlTypes.NpgsqlPoint(x: 0.27413312277705637d, y: 0.8392342341107302d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9891593817812033d, y: 0.222107702550022d), new NpgsqlTypes.NpgsqlPoint(x: 0.8539478613987816d, y: 0.9127545661955112d), new NpgsqlTypes.NpgsqlPoint(x: 0.9542758690608878d, y: 0.6587876608479679d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7864566921907497d, y: 0.49578316029224245d), new NpgsqlTypes.NpgsqlPoint(x: 0.28178253155200217d, y: 0.42791992019908653d), new NpgsqlTypes.NpgsqlPoint(x: 0.6240596349608472d, y: 0.03784557375283204d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.558575122200271d, y: 0.7945646596739301d), new NpgsqlTypes.NpgsqlPoint(x: 0.8805206710604475d, y: 0.695008399567657d), new NpgsqlTypes.NpgsqlPoint(x: 0.7141141453488591d, y: 0.28887387963391975d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21895351610500402d, y: 0.35672118465189073d), new NpgsqlTypes.NpgsqlPoint(x: 0.24587665956157778d, y: 0.8997285386932765d), new NpgsqlTypes.NpgsqlPoint(x: 0.9510044482963665d, y: 0.1655060294319457d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6450531604075722d, y: 0.8853526315957643d), new NpgsqlTypes.NpgsqlPoint(x: 0.9663980728937732d, y: 0.6273610182259828d), new NpgsqlTypes.NpgsqlPoint(x: 0.9523765367505926d, y: 0.335743747877124d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.767275713198793d, y: 0.6955129083143353d), new NpgsqlTypes.NpgsqlPoint(x: 0.1498558784027072d, y: 0.9084970343868146d), new NpgsqlTypes.NpgsqlPoint(x: 0.12116681531356632d, y: 0.31597631551256333d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28025766413004194d, y: 0.33181291756875453d), new NpgsqlTypes.NpgsqlPoint(x: 0.4783571515592627d, y: 0.9329146507946826d), new NpgsqlTypes.NpgsqlPoint(x: 0.7080029335549965d, y: 0.899987878692151d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8749544365727473d, y: 0.19301888639181997d), new NpgsqlTypes.NpgsqlPoint(x: 0.1896983446594973d, y: 0.04241888473958133d), new NpgsqlTypes.NpgsqlPoint(x: 0.9499557877459015d, y: 0.3596101906732615d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4822122534309998d, y: 0.19794841510407168d), new NpgsqlTypes.NpgsqlPoint(x: 0.47267452234913676d, y: 0.6188201926461975d), new NpgsqlTypes.NpgsqlPoint(x: 0.39674994577985434d, y: 0.5688131435571471d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.051795748664395735d, y: 0.733186452859358d), new NpgsqlTypes.NpgsqlPoint(x: 0.9000584104224081d, y: 0.49213161163061026d), new NpgsqlTypes.NpgsqlPoint(x: 0.18997637282481106d, y: 0.2743932127622455d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18364498014129327d, y: 0.6814611034719096d), new NpgsqlTypes.NpgsqlPoint(x: 0.13796007185570358d, y: 0.9125249910227479d), new NpgsqlTypes.NpgsqlPoint(x: 0.5944391776098972d, y: 0.3058390838038364d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8344123582759647d, y: 0.10501042982407471d), new NpgsqlTypes.NpgsqlPoint(x: 0.8403403707283283d, y: 0.13507153683985718d), new NpgsqlTypes.NpgsqlPoint(x: 0.4013098453214049d, y: 0.3887575861969329d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4604644083625463d, y: 0.27665049177375145d), new NpgsqlTypes.NpgsqlPoint(x: 0.3293091538800831d, y: 0.6848993590965343d), new NpgsqlTypes.NpgsqlPoint(x: 0.9648229492466852d, y: 0.43283225586643415d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17742929250581074d, y: 0.35914659612579614d), new NpgsqlTypes.NpgsqlPoint(x: 0.451051248373044d, y: 0.5521907044864451d), new NpgsqlTypes.NpgsqlPoint(x: 0.7205586353444116d, y: 0.142667492460948d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4632069362765113d, y: 0.05166648523708983d), new NpgsqlTypes.NpgsqlPoint(x: 0.30275207935244997d, y: 0.05520032685834708d), new NpgsqlTypes.NpgsqlPoint(x: 0.7557445571544467d, y: 0.21987125347959813d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07084545183692992d, y: 0.6255345462243485d), new NpgsqlTypes.NpgsqlPoint(x: 0.10341328626680613d, y: 0.1802469770309134d), new NpgsqlTypes.NpgsqlPoint(x: 0.43582847873717245d, y: 0.32018496990982115d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.00727051350211827d, y: 0.6324761577474385d), new NpgsqlTypes.NpgsqlPoint(x: 0.07976613741389527d, y: 0.703995907562488d), new NpgsqlTypes.NpgsqlPoint(x: 0.3803161676992225d, y: 0.011047508897271907d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34364099717426944d, y: 0.934714886248108d), new NpgsqlTypes.NpgsqlPoint(x: 0.08841492465608614d, y: 0.785109619874143d), new NpgsqlTypes.NpgsqlPoint(x: 0.36810765818368596d, y: 0.9031277507410046d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07976497756906265d, y: 0.7263438109926371d), new NpgsqlTypes.NpgsqlPoint(x: 0.18915649003136126d, y: 0.46243374650304914d), new NpgsqlTypes.NpgsqlPoint(x: 0.1935586265603242d, y: 0.9029782648576233d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05444676535248594d, y: 0.5280881550610196d), new NpgsqlTypes.NpgsqlPoint(x: 0.3974154952514737d, y: 0.5921950151077329d), new NpgsqlTypes.NpgsqlPoint(x: 0.1610030666206903d, y: 0.9822453879018372d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7628892980920423d, y: 0.06244463215016249d), new NpgsqlTypes.NpgsqlPoint(x: 0.8801177756323004d, y: 0.6781663736308908d), new NpgsqlTypes.NpgsqlPoint(x: 0.9137321854805214d, y: 0.07359055207129617d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1466435216726889d, y: 0.8292336396574649d), new NpgsqlTypes.NpgsqlPoint(x: 0.2967544245956548d, y: 0.339571533538361d), new NpgsqlTypes.NpgsqlPoint(x: 0.15914386321185459d, y: 0.7794355609109389d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8129832139379917d, y: 0.9589953639298052d), new NpgsqlTypes.NpgsqlPoint(x: 0.1790223946758459d, y: 0.5905365037134134d), new NpgsqlTypes.NpgsqlPoint(x: 0.38746047422689334d, y: 0.30130749459881545d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4555783191781434d, y: 0.6075352579445148d), new NpgsqlTypes.NpgsqlPoint(x: 0.48709900641828374d, y: 0.24513754323527448d), new NpgsqlTypes.NpgsqlPoint(x: 0.6319026349505389d, y: 0.11058366989550872d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7191085081534039d, y: 0.3583814932121764d), new NpgsqlTypes.NpgsqlPoint(x: 0.20800949251100254d, y: 0.6897566569193744d), new NpgsqlTypes.NpgsqlPoint(x: 0.3371071937056058d, y: 0.2810801781430121d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9838867784276716d, y: 0.8920640798609168d), new NpgsqlTypes.NpgsqlPoint(x: 0.14995972638895483d, y: 0.721196187422521d), new NpgsqlTypes.NpgsqlPoint(x: 0.9239146861971897d, y: 0.6846389521321439d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8815036937735491d, y: 0.7580107610308163d), new NpgsqlTypes.NpgsqlPoint(x: 0.9566245905873844d, y: 0.8604214697676915d), new NpgsqlTypes.NpgsqlPoint(x: 0.05635253969920018d, y: 0.33024711789272987d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26378921949400747d, y: 0.9832454264906091d), new NpgsqlTypes.NpgsqlPoint(x: 0.31918260239793117d, y: 0.29664753320104653d), new NpgsqlTypes.NpgsqlPoint(x: 0.8610704310101861d, y: 0.4358124591378897d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8301103033697751d, y: 0.9648928000673184d), new NpgsqlTypes.NpgsqlPoint(x: 0.07335945202449345d, y: 0.1814265415916113d), new NpgsqlTypes.NpgsqlPoint(x: 0.18908635212602198d, y: 0.8709661392221307d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8277040960736942d, y: 0.06860332045225381d), new NpgsqlTypes.NpgsqlPoint(x: 0.695325290454997d, y: 0.5681836494628122d), new NpgsqlTypes.NpgsqlPoint(x: 0.11269526812229802d, y: 0.00568263680893355d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5160693536615849d, y: 0.535533094759163d), new NpgsqlTypes.NpgsqlPoint(x: 0.7183057405599568d, y: 0.5602965355183915d), new NpgsqlTypes.NpgsqlPoint(x: 0.38013060303779656d, y: 0.9061245853671297d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33038446569247193d, y: 0.037512573242527325d), new NpgsqlTypes.NpgsqlPoint(x: 0.44029351950858775d, y: 0.8913853951266806d), new NpgsqlTypes.NpgsqlPoint(x: 0.14752881058692824d, y: 0.9675278170723828d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3009493486517657d, y: 0.615519054725294d), new NpgsqlTypes.NpgsqlPoint(x: 0.029895103867064843d, y: 0.47800806190496414d), new NpgsqlTypes.NpgsqlPoint(x: 0.5906550052209919d, y: 0.8061362484152202d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7028203288929529d, y: 0.38854266666191095d), new NpgsqlTypes.NpgsqlPoint(x: 0.2770191631543494d, y: 0.6748411970028769d), new NpgsqlTypes.NpgsqlPoint(x: 0.06348782128283936d, y: 0.5103037332773963d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6254772812357167d, y: 0.3151583014870918d), new NpgsqlTypes.NpgsqlPoint(x: 0.07436258159603082d, y: 0.7341954455891139d), new NpgsqlTypes.NpgsqlPoint(x: 0.8351871922491786d, y: 0.8897119578850223d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6783008755329437d, y: 0.4092312242441535d), new NpgsqlTypes.NpgsqlPoint(x: 0.040324428373813115d, y: 0.896473515290414d), new NpgsqlTypes.NpgsqlPoint(x: 0.7299053297885706d, y: 0.2655730678668238d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4161191279725326d, y: 0.46497127612374767d), new NpgsqlTypes.NpgsqlPoint(x: 0.2507477449839087d, y: 0.9476489495580398d), new NpgsqlTypes.NpgsqlPoint(x: 0.9022131443032944d, y: 0.7376995411468833d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5385681501089707d, y: 0.9521030830373647d), new NpgsqlTypes.NpgsqlPoint(x: 0.2001406913445407d, y: 0.5147595055441361d), new NpgsqlTypes.NpgsqlPoint(x: 0.4693278046507118d, y: 0.8387178607427709d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4710585022818965d, y: 0.7400469283982901d), new NpgsqlTypes.NpgsqlPoint(x: 0.9946253784915524d, y: 0.23501998463771268d), new NpgsqlTypes.NpgsqlPoint(x: 0.8845574329729876d, y: 0.8952443103330545d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5463046406577229d, y: 0.5053783937186349d), new NpgsqlTypes.NpgsqlPoint(x: 0.8865992015564685d, y: 0.48530923401448156d), new NpgsqlTypes.NpgsqlPoint(x: 0.406930600020009d, y: 0.16919611607829943d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10085170006442556d, y: 0.7818127733074229d), new NpgsqlTypes.NpgsqlPoint(x: 0.11805838800597646d, y: 0.8437677053021969d), new NpgsqlTypes.NpgsqlPoint(x: 0.532765874034173d, y: 0.045020275891774264d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32970812744977696d, y: 0.6964783607088394d), new NpgsqlTypes.NpgsqlPoint(x: 0.40437506663532286d, y: 0.7826660690014877d), new NpgsqlTypes.NpgsqlPoint(x: 0.2196315110599616d, y: 0.5457887283369905d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31331095531126363d, y: 0.849466247274446d), new NpgsqlTypes.NpgsqlPoint(x: 0.24263547172990318d, y: 0.3152487337566898d), new NpgsqlTypes.NpgsqlPoint(x: 0.7857628947780966d, y: 0.9666831522107842d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5754839375685588d, y: 0.8345286939895135d), new NpgsqlTypes.NpgsqlPoint(x: 0.31680532899120595d, y: 0.9235515015114244d), new NpgsqlTypes.NpgsqlPoint(x: 0.9537706214322337d, y: 0.5725673670350576d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29058816962181333d, y: 0.7951312419217086d), new NpgsqlTypes.NpgsqlPoint(x: 0.6852455381495272d, y: 0.24942961290173804d), new NpgsqlTypes.NpgsqlPoint(x: 0.6506228349767449d, y: 0.6660104419501729d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5882906958003921d, y: 0.6792237567077002d), new NpgsqlTypes.NpgsqlPoint(x: 0.4868319772070383d, y: 0.4916444848379007d), new NpgsqlTypes.NpgsqlPoint(x: 0.1299915800635255d, y: 0.919296983292599d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.790065573172284d, y: 0.9143866142167282d), new NpgsqlTypes.NpgsqlPoint(x: 0.8530919672856561d, y: 0.19913910054887607d), new NpgsqlTypes.NpgsqlPoint(x: 0.25988512951565657d, y: 0.31370724380964266d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07737079271566438d, y: 0.10928082583949406d), new NpgsqlTypes.NpgsqlPoint(x: 0.480638143429058d, y: 0.7905337183465792d), new NpgsqlTypes.NpgsqlPoint(x: 0.8869167584863662d, y: 0.9121403296380385d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04106818963062453d, y: 0.6332450325607376d), new NpgsqlTypes.NpgsqlPoint(x: 0.3709483163292504d, y: 0.9957729222658025d), new NpgsqlTypes.NpgsqlPoint(x: 0.20453140685712234d, y: 0.8861210646303778d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9563842319068001d, y: 0.8069352558106188d), new NpgsqlTypes.NpgsqlPoint(x: 0.040382987874062026d, y: 0.48559717566159977d), new NpgsqlTypes.NpgsqlPoint(x: 0.6999687285203487d, y: 0.37604444759725386d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 185,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6765150369275774d, y: 0.1210084794002495d), new NpgsqlTypes.NpgsqlPoint(x: 0.8957449944169855d, y: 0.34153990972214887d), new NpgsqlTypes.NpgsqlPoint(x: 0.16776454791738016d, y: 0.9524297130638577d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41481826951670775d, y: 0.21205130420223728d), new NpgsqlTypes.NpgsqlPoint(x: 0.18921348475645872d, y: 0.8458401203622301d), new NpgsqlTypes.NpgsqlPoint(x: 0.6705142229146454d, y: 0.2298835184480772d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8911482403348587d, y: 0.5054405860763669d), new NpgsqlTypes.NpgsqlPoint(x: 0.13676566710726434d, y: 0.6204606626417164d), new NpgsqlTypes.NpgsqlPoint(x: 0.48528113945487017d, y: 0.6899245036261782d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 188,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9392428125254194d, y: 0.09110609041973028d), new NpgsqlTypes.NpgsqlPoint(x: 0.1537783409642418d, y: 0.7167662750521014d), new NpgsqlTypes.NpgsqlPoint(x: 0.4022183508882624d, y: 0.7120979903074854d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5220001716560373d, y: 0.6942299467811169d), new NpgsqlTypes.NpgsqlPoint(x: 0.1696631214181743d, y: 0.4169219242697667d), new NpgsqlTypes.NpgsqlPoint(x: 0.07207938729720176d, y: 0.4564021148639049d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8247706913795193d, y: 0.7489422568883554d), new NpgsqlTypes.NpgsqlPoint(x: 0.9278902087206256d, y: 0.35192107282238483d), new NpgsqlTypes.NpgsqlPoint(x: 0.573044895100054d, y: 0.6060907181729397d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08594906983358852d, y: 0.5777606644749861d), new NpgsqlTypes.NpgsqlPoint(x: 0.7092688756215859d, y: 0.4396694290505926d), new NpgsqlTypes.NpgsqlPoint(x: 0.3831985373657466d, y: 0.048509016186268905d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.908904674389755d, y: 0.1329968087624659d), new NpgsqlTypes.NpgsqlPoint(x: 0.01477775459007824d, y: 0.9136867878895262d), new NpgsqlTypes.NpgsqlPoint(x: 0.4524884955292191d, y: 0.8748465850918252d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9109361744199093d, y: 0.7178906151013569d), new NpgsqlTypes.NpgsqlPoint(x: 0.8154653677588939d, y: 0.017490087773614937d), new NpgsqlTypes.NpgsqlPoint(x: 0.6003004942027234d, y: 0.29000565613270335d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6540405915218869d, y: 0.44076888590865804d), new NpgsqlTypes.NpgsqlPoint(x: 0.3487951002674111d, y: 0.15939320164574333d), new NpgsqlTypes.NpgsqlPoint(x: 0.46479116460556225d, y: 0.27986321464357367d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5400993549661499d, y: 0.7048549187394123d), new NpgsqlTypes.NpgsqlPoint(x: 0.8148345821195256d, y: 0.8147323978798977d), new NpgsqlTypes.NpgsqlPoint(x: 0.6291699749166255d, y: 0.33370714672742796d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7199707365744101d, y: 0.3796128915414405d), new NpgsqlTypes.NpgsqlPoint(x: 0.40757847981055684d, y: 0.45049357123773526d), new NpgsqlTypes.NpgsqlPoint(x: 0.7543869563646176d, y: 0.5442333603241299d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5100664912656825d, y: 0.8459865778679428d), new NpgsqlTypes.NpgsqlPoint(x: 0.7895801511562799d, y: 0.6324179032662068d), new NpgsqlTypes.NpgsqlPoint(x: 0.639805208788605d, y: 0.33885447568631377d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5931848109120247d, y: 0.4236734479009159d), new NpgsqlTypes.NpgsqlPoint(x: 0.9996938943689287d, y: 0.9253742545411493d), new NpgsqlTypes.NpgsqlPoint(x: 0.5521641457369232d, y: 0.09256920382187328d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 191,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6733422527977497d, y: 0.3836538080255255d), new NpgsqlTypes.NpgsqlPoint(x: 0.4473518614287848d, y: 0.0889845155668949d), new NpgsqlTypes.NpgsqlPoint(x: 0.708676161098967d, y: 0.10094340558341997d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11618813861791288d, y: 0.8932287296276075d), new NpgsqlTypes.NpgsqlPoint(x: 0.644135766670881d, y: 0.8370512255049054d), new NpgsqlTypes.NpgsqlPoint(x: 0.9703612510436573d, y: 0.659201034297378d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14886740256606323d, y: 0.06920064612016674d), new NpgsqlTypes.NpgsqlPoint(x: 0.3356435327944366d, y: 0.6557889775681646d), new NpgsqlTypes.NpgsqlPoint(x: 0.0558569134324034d, y: 0.5742510582407743d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 199,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5281213695717856d, y: 0.022887220499969052d), new NpgsqlTypes.NpgsqlPoint(x: 0.029908257792813475d, y: 0.6965274869046699d), new NpgsqlTypes.NpgsqlPoint(x: 0.7387657177705991d, y: 0.10585464178908377d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6262271152300395d, y: 0.5147485755316582d), new NpgsqlTypes.NpgsqlPoint(x: 0.5360422847257234d, y: 0.07589036489753453d), new NpgsqlTypes.NpgsqlPoint(x: 0.5543579600583299d, y: 0.5077579018080787d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5819064513861455d, y: 0.035057626656907814d), new NpgsqlTypes.NpgsqlPoint(x: 0.860312401659149d, y: 0.8060595646173935d), new NpgsqlTypes.NpgsqlPoint(x: 0.9671663701233215d, y: 0.899234047434858d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9266510252874389d, y: 0.3377033806243571d), new NpgsqlTypes.NpgsqlPoint(x: 0.27625820149842883d, y: 0.3523900001486324d), new NpgsqlTypes.NpgsqlPoint(x: 0.6260481782028832d, y: 0.3159867356259255d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3073715205906895d, y: 0.27444602652864025d), new NpgsqlTypes.NpgsqlPoint(x: 0.8622118382153592d, y: 0.9969935038082052d), new NpgsqlTypes.NpgsqlPoint(x: 0.3580987265733252d, y: 0.9302797627543965d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8947097637482178d, y: 0.9223978315340503d), new NpgsqlTypes.NpgsqlPoint(x: 0.7756364703027555d, y: 0.7813702911258972d), new NpgsqlTypes.NpgsqlPoint(x: 0.8371303845809088d, y: 0.14957696609443483d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6002797485371618d, y: 0.755711674065443d), new NpgsqlTypes.NpgsqlPoint(x: 0.396813613994501d, y: 0.36537097397999485d), new NpgsqlTypes.NpgsqlPoint(x: 0.9607421562746422d, y: 0.010579940549459432d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 203,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7021248539743801d, y: 0.03726981860465184d), new NpgsqlTypes.NpgsqlPoint(x: 0.23309007028783457d, y: 0.6831308207572837d), new NpgsqlTypes.NpgsqlPoint(x: 0.35755123691068347d, y: 0.8966580132366561d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24496502164319411d, y: 0.012463447978035669d), new NpgsqlTypes.NpgsqlPoint(x: 0.43762266007336237d, y: 0.4355015347122537d), new NpgsqlTypes.NpgsqlPoint(x: 0.199922353000212d, y: 0.05276620253104647d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2255093113412353d, y: 0.534052860833099d), new NpgsqlTypes.NpgsqlPoint(x: 0.49976328425706806d, y: 0.18435701469986976d), new NpgsqlTypes.NpgsqlPoint(x: 0.1956357310780672d, y: 0.8322546497355111d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0022370801306600407d, y: 0.1622299668559033d), new NpgsqlTypes.NpgsqlPoint(x: 0.2289488122992125d, y: 0.6626764704028618d), new NpgsqlTypes.NpgsqlPoint(x: 0.1998306461233219d, y: 0.6270414087258861d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04326201217811698d, y: 0.9694242097855346d), new NpgsqlTypes.NpgsqlPoint(x: 0.9969654955817329d, y: 0.03916662184034081d), new NpgsqlTypes.NpgsqlPoint(x: 0.04678265469845566d, y: 0.5204090950071034d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.870352917152013d, y: 0.21462193895467718d), new NpgsqlTypes.NpgsqlPoint(x: 0.08792458548586657d, y: 0.9764988888016758d), new NpgsqlTypes.NpgsqlPoint(x: 0.28553028216307674d, y: 0.6909420616892514d)),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
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

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
            asPartInterface: typeof(INpgsqlPathListpathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                List<NpgsqlPathpathArray2M> models = null;

                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray2M> models = null;

                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathListpathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathListpathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 44;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 185;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 168;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 185;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 177;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[34], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 50, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 44, query1, 151, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 123, query1, 151, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 123, query1, 159, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 95, query1, 44, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 101, query1, 72, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 11, query1, 143, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 143, query1, 50, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 123, 151))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[34], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatch(connection, 110, 14))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[30],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 44);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[14], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[15], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[16], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[17], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[18], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[19], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[20], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[21], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[22], false);
                NpgsqlPathpathArray2M.AssertModel(models[15],_testData[23], false);
                NpgsqlPathpathArray2M.AssertModel(models[16],_testData[24], false);
                NpgsqlPathpathArray2M.AssertModel(models[17],_testData[25], false);
                NpgsqlPathpathArray2M.AssertModel(models[18],_testData[26], false);
                NpgsqlPathpathArray2M.AssertModel(models[19],_testData[27], false);
                NpgsqlPathpathArray2M.AssertModel(models[20],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[21],_testData[29], false);
                NpgsqlPathpathArray2M.AssertModel(models[22],_testData[30], false);
                NpgsqlPathpathArray2M.AssertModel(models[23],_testData[31], false);
                NpgsqlPathpathArray2M.AssertModel(models[24],_testData[32], false);
                NpgsqlPathpathArray2M.AssertModel(models[25],_testData[33], false);
                NpgsqlPathpathArray2M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 185);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[31], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[32], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[33], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[34], false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MI),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray2M),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
FROM public.binary_npgsqlpathpatharray2m m
LEFT JOIN public.binary_npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models =  ((INpgsqlPathListpathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models = await ((INpgsqlPathListpathArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI), typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models1 = new List<NpgsqlPathpathArray2MI>();
                var models2 = new List<NpgsqlPathpathArray2MI>();
                await ((INpgsqlPathListpathArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MI>();
                var models2 = new List<NpgsqlPathpathArray2MI>();
                ((INpgsqlPathListpathArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models = await ((INpgsqlPathListpathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

