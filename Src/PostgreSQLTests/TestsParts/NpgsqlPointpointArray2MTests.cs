

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6502723226358265d, y: 0.896743983522959d),

new NpgsqlTypes.NpgsqlPoint(x: 0.013127256730716574d, y: 0.6799461528982604d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2635908019217512d, y: 0.7386930222158213d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.741748908990062d, y: 0.4583342557806268d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9065223297250853d, y: 0.6950244437482535d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8521059288400057d, y: 0.6541908885200356d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4365764047657612d, y: 0.14357631444429053d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39483467333222544d, y: 0.701177901924952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.34016392249735605d, y: 0.43556693945008873d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4499299723567166d, y: 0.2606230293556965d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.033777206961743134d, y: 0.9588124691903785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7892536794889887d, y: 0.081665305979436d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1990453569882924d, y: 0.7761382202636014d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5414690758317726d, y: 0.450341637466082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1780866509219301d, y: 0.5906968009891942d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3623848800032684d, y: 0.4337107293866235d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7813049031031777d, y: 0.8571889255811418d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7746010773146214d, y: 0.3795733413003751d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03247435546748445d, y: 0.7088931703995937d),

new NpgsqlTypes.NpgsqlPoint(x: 0.725413232174283d, y: 0.09516349918384304d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7860408846630681d, y: 0.009930903904919575d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6826968434793957d, y: 0.9322492401155743d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37901601939643925d, y: 0.38114595457406464d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49481838812182444d, y: 0.06458530893743786d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5535869763097276d, y: 0.7617488249855409d),

new NpgsqlTypes.NpgsqlPoint(x: 0.730829536630286d, y: 0.9307630184599666d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8858949606417604d, y: 0.4141067464716185d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8814275607202352d, y: 0.14811890505201186d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06245154925716767d, y: 0.02347841114503868d),

new NpgsqlTypes.NpgsqlPoint(x: 0.054333292341465445d, y: 0.3555294274455282d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23047951777062736d, y: 0.6081038930439925d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4075022566740102d, y: 0.47553299447627095d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9147266917937104d, y: 0.036033132667463d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2661256697652642d, y: 0.4686142643914736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.914976178510326d, y: 0.3705405882538402d),

new NpgsqlTypes.NpgsqlPoint(x: 0.49100663225704255d, y: 0.4507432531193353d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7145736554872558d, y: 0.6521282442673014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8677173578284614d, y: 0.21776058702888723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.560990483545758d, y: 0.09672927059705971d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6651343873906291d, y: 0.5548776759488139d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9082041595224201d, y: 0.009993084218254289d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5087460967467402d, y: 0.011874155440242617d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9634837927944323d, y: 0.5590625671259115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8752115033432863d, y: 0.25453479250993283d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5567414301602173d, y: 0.3382236639288415d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8382824126623245d, y: 0.5022145465695945d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7787767420607323d, y: 0.507536081766537d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6754927089187637d, y: 0.3061195053893405d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05370613161213156d, y: 0.7604507664638931d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7767075980270397d, y: 0.8672286840066381d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7115297650584854d, y: 0.49492911270062345d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9455159539319201d, y: 0.8661940217054294d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5525774402928797d, y: 0.2432200470278476d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4147180499868095d, y: 0.10220255396126565d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9096006058259959d, y: 0.5916178324399066d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16616040437652524d, y: 0.7558724417860931d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1973914375319724d, y: 0.016417302481435803d),

new NpgsqlTypes.NpgsqlPoint(x: 0.734051809594001d, y: 0.013401341064409822d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5292745871124771d, y: 0.6751955461520979d),

new NpgsqlTypes.NpgsqlPoint(x: 0.744639451549779d, y: 0.6155109478051014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20030050370959074d, y: 0.8292717063846887d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4033161399335147d, y: 0.6892841342659691d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5631637998034551d, y: 0.07601532070918582d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12115056030567917d, y: 0.782197817802391d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47019490945356734d, y: 0.2178877143737944d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4847615855391769d, y: 0.8269683233695315d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0655726738696778d, y: 0.17978216966711535d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10979734611749092d, y: 0.42273643848825804d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9047204213705112d, y: 0.37382222177888724d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11825032862912377d, y: 0.9238691418573463d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7552567133388017d, y: 0.4023483342168236d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7723236971098687d, y: 0.029431797623756473d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15235662444685671d, y: 0.32024908155482956d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6197046933518763d, y: 0.5617543577142722d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9592342223139413d, y: 0.6926220131798356d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47220602395988076d, y: 0.9038423849890526d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2673428623815044d, y: 0.9424844563245232d),

new NpgsqlTypes.NpgsqlPoint(x: 0.751591588417299d, y: 0.515769089353586d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1656980453796364d, y: 0.6913684023393492d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24108030602264452d, y: 0.7368755425495054d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5485687468440034d, y: 0.4696433350615945d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11735799668654745d, y: 0.3508175523960424d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3867994710829228d, y: 0.058747045594913394d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9230601814523088d, y: 0.5233649849618404d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47813638550924187d, y: 0.9787952743048998d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4420651168020814d, y: 0.3384465713682234d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6034148088981676d, y: 0.024066039560768582d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.030486113214250987d, y: 0.045441508169368094d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11185402187026916d, y: 0.9056630172686284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.775437066622335d, y: 0.578323702087412d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8787255078829711d, y: 0.8715888576588889d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2148622781673719d, y: 0.2717413004295044d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1327723230889687d, y: 0.25626144053467814d),

new NpgsqlTypes.NpgsqlPoint(x: 0.956237469386359d, y: 0.6524735436079777d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5335964643778455d, y: 0.3410758963366328d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6515587859079403d, y: 0.19894644398009875d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0520797160712001d, y: 0.5113802576087605d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.45831309639929696d, y: 0.3068204768103372d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0751515986603587d, y: 0.47632588182482083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18701270875196097d, y: 0.6549790877114162d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7367604964676703d, y: 0.5116079738353944d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48650041556434864d, y: 0.490762939254348d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5151379614061403d, y: 0.885564688536798d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7437387522211802d, y: 0.9758253656493762d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41660553568951686d, y: 0.8743375857580085d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9354075940283477d, y: 0.6440036235240014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5530423209478963d, y: 0.2264504213783558d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04415072477681481d, y: 0.13784068129829774d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6908183892907895d, y: 0.3523504289731304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.597465852692773d, y: 0.5527185396176899d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12639115752413865d, y: 0.6217251908142974d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11889235791058295d, y: 0.08052826526956236d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2629463604667579d, y: 0.8238487444834177d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9341208989108912d, y: 0.7651857181896301d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6802181848352833d, y: 0.024359444164241184d),

new NpgsqlTypes.NpgsqlPoint(x: 0.011166225478618341d, y: 0.6676135156732363d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7211667680622866d, y: 0.5938107222497266d),

new NpgsqlTypes.NpgsqlPoint(x: 0.351875800094139d, y: 0.052640516400044746d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.058137797254073864d, y: 0.65411058841263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13328007937663733d, y: 0.6319555278205686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22894129716414402d, y: 0.8194237560885619d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.011934928587286842d, y: 0.3693882609632658d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3933465159543267d, y: 0.7452793749326748d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9365104185752737d, y: 0.4196790373029552d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6032928946260007d, y: 0.22280510263180509d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11077995080815484d, y: 0.9238419078932831d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4492643950491346d, y: 0.7773845617247818d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7310406114785409d, y: 0.8854911502200659d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16011102537163635d, y: 0.04916472166239383d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3690322129139312d, y: 0.8720440702404239d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8465886109584948d, y: 0.45789850958453515d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8301984813385193d, y: 0.6359415248905543d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1418141454316103d, y: 0.5446734263100593d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5452400183268362d, y: 0.7688961975389097d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5100478505618092d, y: 0.6060689319606415d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04127833077326082d, y: 0.3148733187095015d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6965925028499768d, y: 0.6060835926979606d),

new NpgsqlTypes.NpgsqlPoint(x: 0.622245259143219d, y: 0.5551589443332994d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13870356294595798d, y: 0.5176739382596911d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11951364232363915d, y: 0.7672825906743888d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5029915906028073d, y: 0.9672862655557529d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2477778590871319d, y: 0.692302151648572d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.27789330893351116d, y: 0.2149543766445785d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3676641231998229d, y: 0.5240379202089952d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8144351708303713d, y: 0.3756475250577971d),

new NpgsqlTypes.NpgsqlPoint(x: 0.823440110431902d, y: 0.4473656672651273d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.02355052498662291d, y: 0.6084340166571979d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0006331415762007575d, y: 0.703162164912933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2204968971299922d, y: 0.7613923279356191d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5581085213864666d, y: 0.8768979404188666d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4107371148049609d, y: 0.17312588417071606d),

new NpgsqlTypes.NpgsqlPoint(x: 0.210855262524141d, y: 0.06601009036638028d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22269278633123002d, y: 0.6085648154900493d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3417155603842945d, y: 0.3088047067930336d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9962265930648102d, y: 0.8176959662038671d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8233535894967395d, y: 0.2862429456566825d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3868230549254261d, y: 0.33155168376646993d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7740625214007736d, y: 0.36901732402538723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39314044646353163d, y: 0.9439259864571639d),

new NpgsqlTypes.NpgsqlPoint(x: 0.926758291639904d, y: 0.19037432510899233d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.138403199260292d, y: 0.13475591582494395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9463367018179286d, y: 0.10076854359160659d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2063077106060458d, y: 0.14394028566683592d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4865988992791076d, y: 0.19366810865442052d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.009349295302838345d, y: 0.36343407836936936d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9620869207533231d, y: 0.3200943463725673d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12353466754595621d, y: 0.006433038966928262d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6787190741822996d, y: 0.6551013553178983d),

new NpgsqlTypes.NpgsqlPoint(x: 0.038363146465476006d, y: 0.6937597934962509d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12568709536828893d, y: 0.17429644234565866d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2003728166602059d, y: 0.5546888555664276d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7707279418497036d, y: 0.19153902168769776d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8097064839666385d, y: 0.1788846510200507d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5621075971537906d, y: 0.24734049812229097d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.648464058807162d, y: 0.6045196455999394d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5585938819446636d, y: 0.1919799344347476d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7510204785033584d, y: 0.3358460204206828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5098787149870306d, y: 0.716786920098325d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.26085333627438545d, y: 0.026249893131091828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02069545015137053d, y: 0.37441893608719345d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9548607444985354d, y: 0.6766405437919878d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7113441183123134d, y: 0.8491546587390402d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2794258935371253d, y: 0.9814259596902664d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5605489316740707d, y: 0.6007278794122762d),

new NpgsqlTypes.NpgsqlPoint(x: 0.057254689112339d, y: 0.47741167917607463d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9763778379005025d, y: 0.2510687140419604d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2695335459762894d, y: 0.7573641155085477d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8492110746554234d, y: 0.9876661663906043d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21283189816553172d, y: 0.27960934085304734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7870306267537973d, y: 0.6716761817154759d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1616399681270665d, y: 0.31782912055402823d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.819075034492513d, y: 0.646738951434098d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9452046119504374d, y: 0.8153186194874571d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2837637973557062d, y: 0.4829051723108324d),

new NpgsqlTypes.NpgsqlPoint(x: 0.499378506192791d, y: 0.07592249940274487d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2308804717672157d, y: 0.09042367341674884d),

new NpgsqlTypes.NpgsqlPoint(x: 0.812010407199984d, y: 0.4779755239660469d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8646683900347749d, y: 0.429828743977965d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.006189891691238403d, y: 0.8305173403142605d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6599405594344364d, y: 0.46852971099575125d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20964529828952017d, y: 0.30478921068490483d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41764697076229973d, y: 0.5901142299160402d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5795755268462294d, y: 0.4800849345496626d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7210902264352673d, y: 0.005958237417398093d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6972404828005024d, y: 0.1867127920444137d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7914758011444752d, y: 0.1315800111579153d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17722860157411147d, y: 0.2245253164778318d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2678750781787015d, y: 0.69750029240082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5489090917994336d, y: 0.8890667139480243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4415900692282274d, y: 0.5749053128690398d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7141619048914554d, y: 0.8352546254532169d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41286423259104843d, y: 0.6880389059641976d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9586514487581361d, y: 0.23578377702239828d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8356432938932343d, y: 0.5337781498155536d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37776443061430975d, y: 0.6193815225822668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08126818602161667d, y: 0.7730152984373898d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6629794182892922d, y: 0.7081295294808744d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1281829125416113d, y: 0.3074804984413452d),

new NpgsqlTypes.NpgsqlPoint(x: 0.83291314160054d, y: 0.5129412618422988d),

new NpgsqlTypes.NpgsqlPoint(x: 0.132926347545669d, y: 0.24093943783248983d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2990090241108868d, y: 0.7127493860855373d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37260584195686675d, y: 0.3728193568303674d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30414457582138055d, y: 0.06430078050320853d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9846451846821183d, y: 0.41392878621927165d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.528658902060754d, y: 0.06505567359163744d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7265932969075511d, y: 0.3347451851464526d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20031154670411022d, y: 0.4307490819355836d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.32234170414562757d, y: 0.7106009082791996d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6706187723511217d, y: 0.7543054032640529d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7902046084336088d, y: 0.745397211974767d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20220787454597855d, y: 0.9987927890141304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44803034625049876d, y: 0.9488588459763116d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5244915705460669d, y: 0.18707722099096846d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6050815807375882d, y: 0.9019798614503389d),

new NpgsqlTypes.NpgsqlPoint(x: 0.596988518231847d, y: 0.8417272879006228d),

new NpgsqlTypes.NpgsqlPoint(x: 0.304315807856292d, y: 0.9904324333057442d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3067795953573238d, y: 0.36100894274698536d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1340671288727192d, y: 0.44111166461752305d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10530158746143303d, y: 0.41725736205844777d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15926267910510694d, y: 0.44112795929790716d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5457226082981071d, y: 0.37292330919485583d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6178876395107894d, y: 0.6151690356763003d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45841959096447893d, y: 0.7365594459716388d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7515920396854257d, y: 0.29557687344466144d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5799712546861956d, y: 0.8575831315042157d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6569176011066198d, y: 0.006271180096982243d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37961848999475667d, y: 0.09806866500372768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4596028634803462d, y: 0.7927867466089518d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33632043812701673d, y: 0.3821426551243794d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9510017619892116d, y: 0.5832828905131616d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2837099963350532d, y: 0.7262633500266978d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7618238573573369d, y: 0.6744298474363047d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6783628584489005d, y: 0.8758942591859886d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9129846577745023d, y: 0.6888057934307671d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7449548920757898d, y: 0.7887240366069271d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3690139054484102d, y: 0.9112210689258671d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5394388782894114d, y: 0.3360875201652359d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21437615631391171d, y: 0.742000091530399d),

new NpgsqlTypes.NpgsqlPoint(x: 0.788671205904133d, y: 0.3066064530328989d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9356794186149533d, y: 0.932042230901046d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.724305017252148d, y: 0.795999792879701d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9242752770045269d, y: 0.9886927859376664d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30269305044799777d, y: 0.6287373905008037d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02699453579532385d, y: 0.3491074967486876d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7198884496719387d, y: 0.9448434443068542d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8865205211743629d, y: 0.5985423791291165d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6833284097375497d, y: 0.2528128272265112d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5445175205538848d, y: 0.5756799255870416d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5046527684274649d, y: 0.057375012497888456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6141704035584826d, y: 0.7657608420467656d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5691664949272716d, y: 0.2025566080140171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4562450586315716d, y: 0.02727985335975691d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.33686666731052095d, y: 0.10041160887590883d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19086283804793014d, y: 0.9113884053561949d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13898776988853767d, y: 0.918081467563456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9726996603798841d, y: 0.8131891909214035d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7143513210089435d, y: 0.24944685069232453d),

new NpgsqlTypes.NpgsqlPoint(x: 0.890452059372276d, y: 0.09619528398918897d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6522148706883146d, y: 0.781893265398644d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1770919957977929d, y: 0.6720011118171484d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9184915391116406d, y: 0.35589567698964464d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8685110181413356d, y: 0.5284050904814224d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9887576514943465d, y: 0.46487876576716136d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7635648700258473d, y: 0.600288162150928d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21874280347632835d, y: 0.8042346473677203d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19393711770061783d, y: 0.18793153428760778d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11797449708708563d, y: 0.639521604431005d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2079805144937097d, y: 0.7154810004653944d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8768214210773166d, y: 0.365808643793921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6031392981026816d, y: 0.4094140371772572d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9007433730244979d, y: 0.9859433508529803d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05447934220531192d, y: 0.5743877212181692d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7631261351183164d, y: 0.17671545497922725d),

new NpgsqlTypes.NpgsqlPoint(x: 0.048240975713288003d, y: 0.013372024133398885d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 176,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6145059726359235d, y: 0.11520812843011019d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36680083668045005d, y: 0.8301195724207945d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9902833746509236d, y: 0.09821209268629882d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8714503126279687d, y: 0.037107924648363655d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7951169091370877d, y: 0.14639828359407303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.34459165333980446d, y: 0.3462273660475542d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9987558433355939d, y: 0.17319939113376248d),

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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 133;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[34], false);
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
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 66;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[34], false);
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
                parametr1.Value = 172;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[30],_testData[34], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 17, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 57, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 167, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[34], false);
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
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 46, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 54, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[34], false);
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
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 172, query1, 46, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 64, query1, 8, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[33],_testData[34], false);
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
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 142, query1, 17, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[32],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 151, 22))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatch(connection, 133, 133))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[34], false);
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
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 44);
                var models = await ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[8], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[9], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[10], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[11], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[12], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[20],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[21],_testData[29], false);NpgsqlPointpointArray2M.AssertModel(models[22],_testData[30], false);NpgsqlPointpointArray2M.AssertModel(models[23],_testData[31], false);NpgsqlPointpointArray2M.AssertModel(models[24],_testData[32], false);NpgsqlPointpointArray2M.AssertModel(models[25],_testData[33], false);NpgsqlPointpointArray2M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 128);
                var models =  ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[29], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[30], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[31], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[32], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[33], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[34], false);
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
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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
                var models = ((INpgsqlPointListpointArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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

        [Test, Order(13)]
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

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPointListpointArray)this).ExportModelInner(connection).ToList();
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

