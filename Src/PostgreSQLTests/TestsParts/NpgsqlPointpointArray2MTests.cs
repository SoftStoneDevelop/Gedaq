

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
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8644083656156151d, y: 0.6323118786914348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9420408926273979d, y: 0.670643118611903d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37170243350978105d, y: 0.5900108481861277d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8848541374262625d, y: 0.6570007315891565d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7977367294714893d, y: 0.7320758173922305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04254115479309861d, y: 0.571992257287944d),

new NpgsqlTypes.NpgsqlPoint(x: 0.341422255326851d, y: 0.2942267690607654d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1899182745225496d, y: 0.8755923634640074d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7511583337771982d, y: 0.8575830981575336d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7197023581124112d, y: 0.500278008659812d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5123486722272155d, y: 0.1361799994424594d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2668215233875463d, y: 0.29647547440879607d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08463640420478147d, y: 0.33134014842077086d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8046565021175731d, y: 0.5510726612989154d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.30949510797755986d, y: 0.4064018568208384d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8712587548456945d, y: 0.8177887817087802d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3956193155173048d, y: 0.13135754318770332d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6040769897393199d, y: 0.5118776474052954d),

new NpgsqlTypes.NpgsqlPoint(x: 0.023165034001881857d, y: 0.7332396325048285d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7407593613472331d, y: 0.138614941972242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.339520646958419d, y: 0.19109315200925858d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.997598023951104d, y: 0.4897421443539399d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9849868432077908d, y: 0.07217979024965715d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06852231209592363d, y: 0.028867192647969553d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8044823233794002d, y: 0.8567432076576212d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9236665080771941d, y: 0.13942028080014024d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7751460535094544d, y: 0.7246293009886234d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6819681422373459d, y: 0.5338944017941893d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37080377193811687d, y: 0.32522509113186426d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23290960212609657d, y: 0.8636114372524542d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7387322622821395d, y: 0.10344764660323702d),

new NpgsqlTypes.NpgsqlPoint(x: 0.011996749521060557d, y: 0.23870954348820173d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5905235611674008d, y: 0.9607029414613513d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03321877388126304d, y: 0.05070005563530888d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9923950335800978d, y: 0.11017129500799006d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.25840970306146915d, y: 0.7415572475527185d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0578835581515843d, y: 0.3585585936151756d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9034025682267063d, y: 0.6230186330881575d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9643263984883853d, y: 0.3880227050647702d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.479048961509687d, y: 0.8121214940581236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9711371610203697d, y: 0.5840351453890036d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5877500187205346d, y: 0.748947182605238d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.57832193732678d, y: 0.2194847209203019d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5411054350449701d, y: 0.314459996211518d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22534932357623105d, y: 0.22613166357381598d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.31069452495048044d, y: 0.4707848278760468d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6739277216576789d, y: 0.826005977313362d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7715863598560845d, y: 0.811225378545877d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3281463493426703d, y: 0.7982780633949667d),

new NpgsqlTypes.NpgsqlPoint(x: 0.43688381001802d, y: 0.7663623151828302d),

new NpgsqlTypes.NpgsqlPoint(x: 0.43535157607304353d, y: 0.6575405751684084d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7155416446229954d, y: 0.2729672353448712d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5874731754635694d, y: 0.4651801440407498d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4185835344464458d, y: 0.5084316292362425d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2742359459093212d, y: 0.9225851308419558d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5584482210735205d, y: 0.6353558787140902d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9809364201939087d, y: 0.23215150337424295d),

new NpgsqlTypes.NpgsqlPoint(x: 0.017179677699310614d, y: 0.7352765586337573d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4464879032070085d, y: 0.11989732079382387d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7332943178249479d, y: 0.8544550745845686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7849646805180829d, y: 0.6260058563189309d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45554888139135385d, y: 0.12925334343875805d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6164787617185721d, y: 0.886501019106815d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5759918482396759d, y: 0.19557142867263977d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08792327787853227d, y: 0.4026031271251145d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08582581694558122d, y: 0.2140400845104652d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6556124245336483d, y: 0.6875642956616468d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4739908600383007d, y: 0.21525702245685563d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6271772904953918d, y: 0.9041433982374816d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08157643287297522d, y: 0.31671926558953256d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3032375522240923d, y: 0.26220576661125694d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8243211020204113d, y: 0.31127091095501214d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8794364750362376d, y: 0.46038285938015333d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27144294564461735d, y: 0.8317660004778152d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8769118030394686d, y: 0.6267823612807519d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6633162699712909d, y: 0.07329806424488594d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0852097779101908d, y: 0.4550774573559081d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6120577801106895d, y: 0.04720979008124426d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4059212071674648d, y: 0.691588769418763d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1766898029713473d, y: 0.8214014938210871d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28638417163117735d, y: 0.5991283424051961d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7462296301125181d, y: 0.3428665292185482d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20477411203792617d, y: 0.9898291335767007d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3987025447987681d, y: 0.6405412337381488d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11037151279186685d, y: 0.568883634999289d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5240477997451933d, y: 0.07965167717418253d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7830426734261768d, y: 0.9942306587878745d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6385021988367113d, y: 0.5160732134930016d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8840024487634606d, y: 0.4750567101315416d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.00022921222157090693d, y: 0.9513140193967854d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07427190834642083d, y: 0.21635942325551227d),

new NpgsqlTypes.NpgsqlPoint(x: 0.675936944609737d, y: 0.8288540194071301d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47923671718510796d, y: 0.24081252226938643d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3224084930630775d, y: 0.7723049262543853d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8282449959881114d, y: 0.03948802501743609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40182821339092833d, y: 0.5674436867514069d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7680596621828605d, y: 0.4242212921550018d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8890756308372502d, y: 0.08051829827081913d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3533751791356583d, y: 0.42103279842662333d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8564184914843811d, y: 0.6640849938833301d),

new NpgsqlTypes.NpgsqlPoint(x: 0.030349324818902512d, y: 0.7471947460614214d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7467652771367772d, y: 0.008584030137796406d),

new NpgsqlTypes.NpgsqlPoint(x: 0.838185691219108d, y: 0.8289270560422328d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.25356436987242503d, y: 0.6675969698315205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8604247425013825d, y: 0.6509629104234419d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7279510952593482d, y: 0.23438092306630898d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7285174712532362d, y: 0.602664291943764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7754554299561307d, y: 0.9304877937351567d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8225830157278073d, y: 0.511059382520667d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5212096819282979d, y: 0.3869603612047673d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9524156146665339d, y: 0.6484255007234776d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3868734218013342d, y: 0.9130956943847516d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18494324280294594d, y: 0.7009037463770315d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8631079503917528d, y: 0.9441254155250792d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22423149618372373d, y: 0.38606692226813033d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4786578523690097d, y: 0.4152953500592742d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41465213015065316d, y: 0.7698542306586216d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5535150280900379d, y: 0.5388581548833887d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5350490935703215d, y: 0.02058636094937638d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2815762100310988d, y: 0.9690516725475765d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06580018691107825d, y: 0.3139180257272177d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10140878489492389d, y: 0.7681251427373894d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33913835280503757d, y: 0.15756732641528792d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5333339370307856d, y: 0.05249436790011974d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5349477158152517d, y: 0.7968581348310013d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6241012367003214d, y: 0.29044029019737294d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6634007069673193d, y: 0.9066876710727413d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7921487340291158d, y: 0.8856521663473217d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10613247770890266d, y: 0.4410406548311724d),

new NpgsqlTypes.NpgsqlPoint(x: 0.46359161148470884d, y: 0.5725682066739419d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5986217403279578d, y: 0.22951118743380905d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12494372817967747d, y: 0.8071278778275092d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.26890239672350447d, y: 0.018319622745447295d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0586970866345401d, y: 0.7019694409610777d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7493167781805911d, y: 0.6059529669148671d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9796745631117055d, y: 0.752846414589621d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.45477594018885004d, y: 0.6505484346219321d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8860115997970425d, y: 0.4719249012365503d),

new NpgsqlTypes.NpgsqlPoint(x: 0.447434327456661d, y: 0.5576209025571746d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7641363402002448d, y: 0.7024494568009373d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.43622460858840273d, y: 0.06099727039155389d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8854375143267169d, y: 0.47605974921505134d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1409198546412308d, y: 0.5428744989011842d),

new NpgsqlTypes.NpgsqlPoint(x: 0.00894467924260467d, y: 0.9258687513716819d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5542666663803205d, y: 0.908258013206265d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6619025218380842d, y: 0.126032235395228d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6223576982494449d, y: 0.3589463089577709d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09907453968848512d, y: 0.1528532497451185d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16357557599794403d, y: 0.21157533007835994d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38070898060404545d, y: 0.7324239006055141d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03855486522101337d, y: 0.8617335190930725d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6674302917775145d, y: 0.1965115966899179d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6767288182529129d, y: 0.21965846637816633d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7161334358553324d, y: 0.4655569645741696d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49027464963425416d, y: 0.8593394653989248d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9987063596584287d, y: 0.910389045768843d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8649484586653954d, y: 0.6829116011493533d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9987205244883782d, y: 0.3166219572984399d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9593796459131233d, y: 0.8907622454157175d),

new NpgsqlTypes.NpgsqlPoint(x: 0.001026809662720729d, y: 0.32506140469685485d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2800321254560264d, y: 0.23197076239448555d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4946419173062244d, y: 0.4983324364350368d),

new NpgsqlTypes.NpgsqlPoint(x: 0.918177997861819d, y: 0.1914279305173463d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5439352252222494d, y: 0.7662626090298735d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7009730745917903d, y: 0.9264847084183119d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8595531983092007d, y: 0.35758513461765284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9203281924887676d, y: 0.00023133815335618646d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9698844371220221d, y: 0.6756979581108833d),

new NpgsqlTypes.NpgsqlPoint(x: 0.044883760646722504d, y: 0.629031491757331d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0165242666151747d, y: 0.8835791355616662d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9720290298389174d, y: 0.7868785893226719d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9065979684635007d, y: 0.5558011023503857d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9873634950502477d, y: 0.41765300163742514d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6530251815101046d, y: 0.4950044933313881d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4984277508824986d, y: 0.48870325177727325d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5216117101078751d, y: 0.328645761899493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.045912416540667356d, y: 0.4774607431646476d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7763645826358828d, y: 0.9295789035682669d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7797498429357032d, y: 0.31342786579652415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.35815575493295204d, y: 0.9868455033793042d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46773405797080847d, y: 0.33441618345911417d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10303386876263065d, y: 0.8121567728821217d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5224829312165606d, y: 0.35056244222252286d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.596602847199333d, y: 0.8328149521325812d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5794490629700318d, y: 0.679126183252682d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9914144799653604d, y: 0.9736499675226773d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15272303071330062d, y: 0.7323972308701733d),

new NpgsqlTypes.NpgsqlPoint(x: 0.730655840229455d, y: 0.5746867408610583d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10279114556918045d, y: 0.9488357884839512d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.40842647489597483d, y: 0.8710669123644031d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20410832975925852d, y: 0.7698586290275952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.719632660983296d, y: 0.7399464621864943d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17458542698958368d, y: 0.13783064029614134d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3096737422923176d, y: 0.13162472399424718d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9902291016402739d, y: 0.7160395013228215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2207786596197615d, y: 0.41327295837011746d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7895404095739961d, y: 0.19342409945435624d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6555368939600956d, y: 0.9665364483710948d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7022786817926963d, y: 0.37040364797870495d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3079561805013301d, y: 0.30260261766477736d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.25080754214530077d, y: 0.3575355921465597d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09990363320385653d, y: 0.7796872004960539d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28979816141071246d, y: 0.17629892975542416d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7939596290175173d, y: 0.8242545877161797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6496782219928722d, y: 0.3722380301126741d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6493458998673879d, y: 0.21710813540947937d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9881818442152713d, y: 0.5481167083981319d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4807179690854596d, y: 0.24575951952249908d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23754103221670475d, y: 0.8564890800538412d),

new NpgsqlTypes.NpgsqlPoint(x: 0.903226782047021d, y: 0.28041449633157667d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5448311382595858d, y: 0.541572625858553d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8778469144049538d, y: 0.6201681305329874d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1433337427086966d, y: 0.6417486801778501d),

new NpgsqlTypes.NpgsqlPoint(x: 0.016733908170446288d, y: 0.18816630165774073d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.98850658474124d, y: 0.6052657305195362d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1971981939218742d, y: 0.941691428660453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09761538192350783d, y: 0.938496883031048d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0859723098215942d, y: 0.7875993725498767d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7188975536885811d, y: 0.5521781401171827d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3034790460864726d, y: 0.30904712810984036d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8884150016414626d, y: 0.8666162796951633d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22577302185924453d, y: 0.3156448561124987d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20569679714087818d, y: 0.8319054146773955d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8885046020377323d, y: 0.3166987164387587d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5575207656688878d, y: 0.7080742941562559d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.664777213704734d, y: 0.5190398176349387d),

new NpgsqlTypes.NpgsqlPoint(x: 0.770792523520211d, y: 0.4603718042262608d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47080117295544566d, y: 0.7000013166356162d),

},
},
    NullableValue = null,
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[12], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[13], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[14], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[15], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[16], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[17], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[18], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
        private void DbConnectionSelectModelDynParBatchConfig()
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[2], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[3], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[4], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[5], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[6], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[7], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[8], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[9], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[10], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[20],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[21],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[22],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[23],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[24],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[25],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[26],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[1], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[2], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[3], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[4], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[5], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[6], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[7], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[8], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[9], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[10], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[20],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[21],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[22],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[23],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[24],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[25],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[26],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[27],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[28],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[9], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[10], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[10], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 103, query1, 25, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[7], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[8], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[9], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[10], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[11], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[12], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[13], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[14], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[15], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[16], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[17], false);FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[18], false);FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 127, query1, 16, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[6], false);FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[7], false);FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[8], false);FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[9], false);FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[10], false);FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[11], false);FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[12], false);FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[13], false);FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[14], false);FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[15], false);FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[16], false);FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[17], false);FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[18], false);FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[19], false);FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[20], false);FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[21], false);FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[22], false);FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[23], false);FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[24], false);FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[25], false);FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[26], false);FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[27], false);FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[28], false);FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlPointListpointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSelectModelBatchAsync(connection, 49, 5))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[3], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[4], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[5], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[6], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[7], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[8], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[9], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[10], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[20],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[21],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[22],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[23],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[24],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[25],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[26],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSelectModelBatch(connection, 149, 71))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[29], false);
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
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 1);
                var models = await ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[1], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[2], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[3], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[4], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[5], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[6], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[7], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[8], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[9], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[10], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[20],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[21],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[22],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[23],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[24],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[25],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[26],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[27],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 118);
                var models =  ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
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
        private void ImportModelInnerConfig()
        {
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
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPointListpointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((INpgsqlPointListpointArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPointListpointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray2M>(15);

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
                ((INpgsqlPointListpointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPointListpointArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPointListpointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlPointpointArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlPointpointArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlPointpointArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlPointpointArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlPointpointArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlPointpointArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlPointpointArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlPointpointArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlPointpointArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlPointpointArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlPointpointArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlPointpointArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlPointpointArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlPointpointArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlPointpointArray2M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointListpointArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

