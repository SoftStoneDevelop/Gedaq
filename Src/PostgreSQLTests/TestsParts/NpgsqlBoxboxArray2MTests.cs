

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
    internal partial interface INpgsqlBoxListboxArray
    {
    }
    
    internal partial class NpgsqlBoxListboxArray : INpgsqlBoxListboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray2M[] _testData = new NpgsqlBoxboxArray2M[]
        {
            new NpgsqlBoxboxArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.42332157652647073d,right: 0.4128340232430824d,bottom: 0.09584748983864377d,left: 0.2958508620603253d),

new NpgsqlTypes.NpgsqlBox(top: 0.29569349296129466d,right: 0.40163722513050715d,bottom: 0.007028035281664846d,left: 0.25989139102865655d),

new NpgsqlTypes.NpgsqlBox(top: 0.5820284287174756d,right: 0.7606604981433185d,bottom: 0.042105725735543165d,left: 0.31042711676030843d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5874387870280359d,right: 0.3276094337175097d,bottom: 0.021945469568680265d,left: 0.20196034435491061d),

new NpgsqlTypes.NpgsqlBox(top: 0.8998497084409132d,right: 0.9767492229426714d,bottom: 0.29884058542814207d,left: 0.9151515217237693d),

new NpgsqlTypes.NpgsqlBox(top: 0.36114496149712716d,right: 0.5579257047287108d,bottom: 0.17250143559242093d,left: 0.23207758163376457d),

new NpgsqlTypes.NpgsqlBox(top: 0.26317812371135785d,right: 0.3872356984305869d,bottom: 0.25039604199255816d,left: 0.35764156994960217d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6485145906086728d,right: 0.42863750108112597d,bottom: 0.5379044923886164d,left: 0.07007534726888232d),

new NpgsqlTypes.NpgsqlBox(top: 0.5955347480104853d,right: 0.7545021969883592d,bottom: 0.11010894300688323d,left: 0.5489120109490707d),

new NpgsqlTypes.NpgsqlBox(top: 0.22176304035306227d,right: 0.9318454136943483d,bottom: 0.1487389131254473d,left: 0.16941881683915405d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7334238947853964d,right: 0.7752564181446048d,bottom: 0.6305476489163413d,left: 0.15203999922082712d),

new NpgsqlTypes.NpgsqlBox(top: 0.574905312134371d,right: 0.9149005738855213d,bottom: 0.2971448196311274d,left: 0.5324819061738785d),

new NpgsqlTypes.NpgsqlBox(top: 0.9040747698895446d,right: 0.19293402387118308d,bottom: 0.1606385355420873d,left: 0.17459595170351472d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9223566892518702d,right: 0.9072724142215817d,bottom: 0.5940119785812971d,left: 0.23625650651611663d),

new NpgsqlTypes.NpgsqlBox(top: 0.9731367582024951d,right: 0.42162200962638163d,bottom: 0.09434238003810702d,left: 0.22754385746587613d),

new NpgsqlTypes.NpgsqlBox(top: 0.674803366467689d,right: 0.9840982758660007d,bottom: 0.34707219764188624d,left: 0.5413516274728675d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6228984648237569d,right: 0.4245857193992245d,bottom: 0.46436827163814764d,left: 0.3414926790798284d),

new NpgsqlTypes.NpgsqlBox(top: 0.8063209673795596d,right: 0.558717253054055d,bottom: 0.5967690220175547d,left: 0.181279481874405d),

new NpgsqlTypes.NpgsqlBox(top: 0.754658355195957d,right: 0.5437237139231672d,bottom: 0.4252810059117421d,left: 0.25432111774728416d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9648402399857906d,right: 0.46833713500246876d,bottom: 0.002413146618260975d,left: 0.391582797885373d),

new NpgsqlTypes.NpgsqlBox(top: 0.8715573719779693d,right: 0.5483859234617546d,bottom: 0.34692052916630256d,left: 0.32107410172841655d),

new NpgsqlTypes.NpgsqlBox(top: 0.8789559252177052d,right: 0.600983395541344d,bottom: 0.2469894538977122d,left: 0.5229529323990063d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8953128236715875d,right: 0.6576194478711094d,bottom: 0.87901740157738d,left: 0.3736144946607981d),

new NpgsqlTypes.NpgsqlBox(top: 0.777097018058009d,right: 0.10175034430371277d,bottom: 0.5622149304168309d,left: 0.10145576176542559d),

new NpgsqlTypes.NpgsqlBox(top: 0.843586594743712d,right: 0.11070259827668472d,bottom: 0.8072115516760706d,left: 0.10447864727267442d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8443959460389723d,right: 0.36710170598777714d,bottom: 0.710085483961768d,left: 0.01295176688644839d),

new NpgsqlTypes.NpgsqlBox(top: 0.9443711544424855d,right: 0.7971070778546563d,bottom: 0.3087907363046902d,left: 0.5492900504109955d),

new NpgsqlTypes.NpgsqlBox(top: 0.3426307075974939d,right: 0.2604716362211559d,bottom: 0.20728172633391673d,left: 0.25415267510776507d),

new NpgsqlTypes.NpgsqlBox(top: 0.8386467245958403d,right: 0.988830180961242d,bottom: 0.2807211664019772d,left: 0.6878065235643536d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.903366293322907d,right: 0.4739193859587908d,bottom: 0.45553446185688884d,left: 0.0761097814238324d),

new NpgsqlTypes.NpgsqlBox(top: 0.13768186179205066d,right: 0.5633893054062187d,bottom: 0.07129315528416191d,left: 0.3559583030294994d),

new NpgsqlTypes.NpgsqlBox(top: 0.4723017415441467d,right: 0.258482801948706d,bottom: 0.4153998280361004d,left: 0.10981147474157416d),

new NpgsqlTypes.NpgsqlBox(top: 0.30503276747542274d,right: 0.48411839314378113d,bottom: 0.20749849688571564d,left: 0.30481654758310295d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.48331947040649437d,right: 0.7525025543779384d,bottom: 0.30762479849612345d,left: 0.42515626558319386d),

new NpgsqlTypes.NpgsqlBox(top: 0.865201946419871d,right: 0.7909331932896753d,bottom: 0.015584495992456926d,left: 0.6636830233916958d),

new NpgsqlTypes.NpgsqlBox(top: 0.9801362374188946d,right: 0.4492414290289428d,bottom: 0.3388894156922104d,left: 0.2590619552691493d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.647111288901892d,right: 0.3827095219056562d,bottom: 0.26350148215574976d,left: 0.1462522777085239d),

new NpgsqlTypes.NpgsqlBox(top: 0.43150098907458645d,right: 0.6425173095126216d,bottom: 0.2639041506559271d,left: 0.6178004855650538d),

new NpgsqlTypes.NpgsqlBox(top: 0.4552272306732511d,right: 0.857036181468103d,bottom: 0.40456057207834695d,left: 0.8284823666711967d),

new NpgsqlTypes.NpgsqlBox(top: 0.8298032774352966d,right: 0.9781732361325595d,bottom: 0.12683082467640172d,left: 0.81611344515615d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7383174753134579d,right: 0.6049566263863279d,bottom: 0.21854311610274246d,left: 0.3480663236531497d),

new NpgsqlTypes.NpgsqlBox(top: 0.6197320243115619d,right: 0.8085288078446972d,bottom: 0.5109664305913812d,left: 0.5856427618350956d),

new NpgsqlTypes.NpgsqlBox(top: 0.9390952569001527d,right: 0.11336633518122041d,bottom: 0.1704238031944263d,left: 0.06254836649207884d),

new NpgsqlTypes.NpgsqlBox(top: 0.821640497980647d,right: 0.5402418840902207d,bottom: 0.7251068296824164d,left: 0.3276664648016614d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9247379957238301d,right: 0.2689566413854736d,bottom: 0.15584749820314714d,left: 0.07335638701582048d),

new NpgsqlTypes.NpgsqlBox(top: 0.9081483060991797d,right: 0.20430221487923506d,bottom: 0.4607593806462421d,left: 0.057814931918874324d),

new NpgsqlTypes.NpgsqlBox(top: 0.5393214445396546d,right: 0.8473542787757388d,bottom: 0.3253853019976538d,left: 0.4334072920616764d),

new NpgsqlTypes.NpgsqlBox(top: 0.610406109779823d,right: 0.7615898919698428d,bottom: 0.04514593823390711d,left: 0.15064190911057873d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9576371465128922d,right: 0.9948563596458636d,bottom: 0.3240224184174685d,left: 0.6429622698209156d),

new NpgsqlTypes.NpgsqlBox(top: 0.9576601772690592d,right: 0.9808824669851609d,bottom: 0.692042266650212d,left: 0.9369826897654585d),

new NpgsqlTypes.NpgsqlBox(top: 0.7748800259401464d,right: 0.6392082333469519d,bottom: 0.3073089218110562d,left: 0.1088976228050823d),

new NpgsqlTypes.NpgsqlBox(top: 0.5391818091176565d,right: 0.7813934965947846d,bottom: 0.44853543270563656d,left: 0.2009045043305412d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7981889444459891d,right: 0.9727855865552908d,bottom: 0.3022550330941951d,left: 0.8298148087127621d),

new NpgsqlTypes.NpgsqlBox(top: 0.2535660129285673d,right: 0.868578850891915d,bottom: 0.23307855130087374d,left: 0.625682554663207d),

new NpgsqlTypes.NpgsqlBox(top: 0.2155823009055874d,right: 0.9102098746173913d,bottom: 0.1560371758336928d,left: 0.3290344997814786d),

new NpgsqlTypes.NpgsqlBox(top: 0.7579302259251843d,right: 0.9177208639351834d,bottom: 0.660501638473982d,left: 0.888857485959998d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.42281797134921495d,right: 0.9423083443642601d,bottom: 0.25943398268279294d,left: 0.6484072936790979d),

new NpgsqlTypes.NpgsqlBox(top: 0.3052384036890935d,right: 0.17292084955716902d,bottom: 0.146801670525867d,left: 0.06159078022494435d),

new NpgsqlTypes.NpgsqlBox(top: 0.0955263566328538d,right: 0.6616809778888204d,bottom: 0.07956710919254772d,left: 0.46033523826746914d),

new NpgsqlTypes.NpgsqlBox(top: 0.988069151780853d,right: 0.695990563522866d,bottom: 0.9743572286733182d,left: 0.21327816722975135d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7769238612448276d,right: 0.7432347383876213d,bottom: 0.29926078363346154d,left: 0.605629514823362d),

new NpgsqlTypes.NpgsqlBox(top: 0.7547258075278827d,right: 0.5923676565661806d,bottom: 0.26423884584063084d,left: 0.4907474113453304d),

new NpgsqlTypes.NpgsqlBox(top: 0.2341136176776102d,right: 0.550565741007141d,bottom: 0.007290211043869399d,left: 0.1710300471563998d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.43680897226393545d,right: 0.9186789880218225d,bottom: 0.2271510800404557d,left: 0.5131262856262176d),

new NpgsqlTypes.NpgsqlBox(top: 0.6941940527661565d,right: 0.496791670889581d,bottom: 0.22898605384077553d,left: 0.34957839462801765d),

new NpgsqlTypes.NpgsqlBox(top: 0.4401104685354016d,right: 0.6982447790405684d,bottom: 0.39409970451495724d,left: 0.441267127179659d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6343010751957155d,right: 0.5045161986577545d,bottom: 0.07141777332716515d,left: 0.3514268913791373d),

new NpgsqlTypes.NpgsqlBox(top: 0.7907428291535137d,right: 0.04044392963544452d,bottom: 0.6901987049161001d,left: 0.03275709078265454d),

new NpgsqlTypes.NpgsqlBox(top: 0.7383497893409436d,right: 0.307026891504111d,bottom: 0.07974873961447804d,left: 0.2898350922979226d),

new NpgsqlTypes.NpgsqlBox(top: 0.7366056149634164d,right: 0.44387708751535027d,bottom: 0.22476330794510102d,left: 0.33367913208405287d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3187094512882631d,right: 0.6015138331050826d,bottom: 0.13021113074051327d,left: 0.281606061061085d),

new NpgsqlTypes.NpgsqlBox(top: 0.43575176166432295d,right: 0.7875258188728966d,bottom: 0.4209333798123641d,left: 0.5218086584329834d),

new NpgsqlTypes.NpgsqlBox(top: 0.6462353684162925d,right: 0.9715423226776697d,bottom: 0.4526897058178744d,left: 0.11257433495504776d),

new NpgsqlTypes.NpgsqlBox(top: 0.6536801024438792d,right: 0.6352055869534067d,bottom: 0.20732174019467942d,left: 0.19606768613835268d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9390042155837826d,right: 0.062372694494151615d,bottom: 0.8752358076241057d,left: 0.02525058581236661d),

new NpgsqlTypes.NpgsqlBox(top: 0.8260886570293985d,right: 0.8843065135923772d,bottom: 0.7772808227026635d,left: 0.579415170037925d),

new NpgsqlTypes.NpgsqlBox(top: 0.9500979271055933d,right: 0.8391123767220293d,bottom: 0.5171906010455785d,left: 0.811453134343636d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.46584049055651666d,right: 0.635596681094111d,bottom: 0.4118852143347037d,left: 0.31458299951833046d),

new NpgsqlTypes.NpgsqlBox(top: 0.4065519751469654d,right: 0.7312552904591182d,bottom: 0.21336445849066277d,left: 0.3434376896415996d),

new NpgsqlTypes.NpgsqlBox(top: 0.5407270426039941d,right: 0.6236412472494073d,bottom: 0.34808242885578555d,left: 0.030000753612743125d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.06640024143535161d,right: 0.7131007089486779d,bottom: 0.05728245000227039d,left: 0.2546040673102239d),

new NpgsqlTypes.NpgsqlBox(top: 0.9567931249055291d,right: 0.387353703883054d,bottom: 0.5137418887923924d,left: 0.1852875991518551d),

new NpgsqlTypes.NpgsqlBox(top: 0.8796394513245968d,right: 0.7603126038344648d,bottom: 0.7542792200777515d,left: 0.370034885163132d),

new NpgsqlTypes.NpgsqlBox(top: 0.8583414321950062d,right: 0.5994808746467317d,bottom: 0.7724367877222081d,left: 0.4598230036631833d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5358482858436499d,right: 0.18065735067267485d,bottom: 0.06048053899619288d,left: 0.16959166646077328d),

new NpgsqlTypes.NpgsqlBox(top: 0.16072494981469132d,right: 0.10195510071981306d,bottom: 0.06372819874083291d,left: 0.0032484745317770125d),

new NpgsqlTypes.NpgsqlBox(top: 0.596326764791777d,right: 0.9157130190816103d,bottom: 0.506200324014561d,left: 0.4661657299865549d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7508947878901793d,right: 0.7186847855942957d,bottom: 0.35191073381783844d,left: 0.6104192000991571d),

new NpgsqlTypes.NpgsqlBox(top: 0.9769491179372006d,right: 0.8545880978989128d,bottom: 0.14220939908404018d,left: 0.4707960526761319d),

new NpgsqlTypes.NpgsqlBox(top: 0.15493628646583535d,right: 0.6343472231373879d,bottom: 0.02659137168270931d,left: 0.5026598882183861d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7765516731055411d,right: 0.8287121791505601d,bottom: 0.7693708193456804d,left: 0.06311914306504729d),

new NpgsqlTypes.NpgsqlBox(top: 0.6950269922327038d,right: 0.9739998183342569d,bottom: 0.1691600662138062d,left: 0.707160730908332d),

new NpgsqlTypes.NpgsqlBox(top: 0.47852699785254404d,right: 0.5325631664761921d,bottom: 0.34011749326730545d,left: 0.5064491830703155d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6442457149704369d,right: 0.415040931272908d,bottom: 0.292109729926478d,left: 0.2578427352469703d),

new NpgsqlTypes.NpgsqlBox(top: 0.42619365544671306d,right: 0.6417848515396524d,bottom: 0.3563610828653966d,left: 0.30273428859413865d),

new NpgsqlTypes.NpgsqlBox(top: 0.7628733647988039d,right: 0.18948124612205075d,bottom: 0.5012455774444632d,left: 0.17047146103160038d),

new NpgsqlTypes.NpgsqlBox(top: 0.39404720956036954d,right: 0.7178118016554049d,bottom: 0.06928468138110166d,left: 0.4076406288559039d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.758682082739847d,right: 0.6492144030265351d,bottom: 0.2550267845133968d,left: 0.0732804766796753d),

new NpgsqlTypes.NpgsqlBox(top: 0.47445340061641084d,right: 0.2895045758438678d,bottom: 0.29710790462281d,left: 0.11366411276414257d),

new NpgsqlTypes.NpgsqlBox(top: 0.8724799372359541d,right: 0.5710421271430381d,bottom: 0.6080945144009836d,left: 0.47679963294650485d),

new NpgsqlTypes.NpgsqlBox(top: 0.9456349393203332d,right: 0.9761998117241334d,bottom: 0.6916368677644206d,left: 0.6083412745327684d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7563273160314535d,right: 0.748597429142136d,bottom: 0.6417726605972884d,left: 0.30733881941679997d),

new NpgsqlTypes.NpgsqlBox(top: 0.8927527719740732d,right: 0.5972210547579742d,bottom: 0.6610872308377747d,left: 0.19620928856792919d),

new NpgsqlTypes.NpgsqlBox(top: 0.7745022987218122d,right: 0.46468086924176966d,bottom: 0.5256469831860052d,left: 0.11955319113527729d),

new NpgsqlTypes.NpgsqlBox(top: 0.9920706990068355d,right: 0.4051792718533378d,bottom: 0.9466746912923508d,left: 0.4007295579978293d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9684530421244235d,right: 0.646087880737792d,bottom: 0.20402557012854883d,left: 0.372469138494706d),

new NpgsqlTypes.NpgsqlBox(top: 0.5651439598047058d,right: 0.47540419189285d,bottom: 0.38762106671268104d,left: 0.43956678312142206d),

new NpgsqlTypes.NpgsqlBox(top: 0.44782848586090473d,right: 0.2585034828427558d,bottom: 0.07405376366149452d,left: 0.0180835378453561d),

new NpgsqlTypes.NpgsqlBox(top: 0.9827280870757431d,right: 0.6682937424704417d,bottom: 0.5784830580197451d,left: 0.5079728755072643d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7497510950941509d,right: 0.9588859685725769d,bottom: 0.009256996081110191d,left: 0.39859473458620254d),

new NpgsqlTypes.NpgsqlBox(top: 0.5454897239500257d,right: 0.9431144738451114d,bottom: 0.23519718629589426d,left: 0.13205427170180395d),

new NpgsqlTypes.NpgsqlBox(top: 0.12666711306916356d,right: 0.8170172354303374d,bottom: 0.04136687469400846d,left: 0.6254529444113295d),

new NpgsqlTypes.NpgsqlBox(top: 0.6665802082648845d,right: 0.8917719767422544d,bottom: 0.4020269511580371d,left: 0.7516977140786805d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.15021198220074627d,right: 0.48880510306065217d,bottom: 0.043829844407918594d,left: 0.36682597615177015d),

new NpgsqlTypes.NpgsqlBox(top: 0.5056422631792672d,right: 0.5778456525698971d,bottom: 0.1189914605424961d,left: 0.21427820796081432d),

new NpgsqlTypes.NpgsqlBox(top: 0.9735777654105585d,right: 0.8880759847335407d,bottom: 0.7708167962063698d,left: 0.4761636182228558d),

new NpgsqlTypes.NpgsqlBox(top: 0.8622921561937601d,right: 0.9073834050556115d,bottom: 0.2492504576771054d,left: 0.13086131693363023d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.36767235555462785d,right: 0.26450555040397916d,bottom: 0.2766738341524908d,left: 0.16555764948099438d),

new NpgsqlTypes.NpgsqlBox(top: 0.7434642066013682d,right: 0.8880422003195463d,bottom: 0.48622139026877975d,left: 0.13535521305233433d),

new NpgsqlTypes.NpgsqlBox(top: 0.7097105334117572d,right: 0.7420367353307994d,bottom: 0.46881387393226237d,left: 0.0906624215083448d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.48158744711989987d,right: 0.882708604053274d,bottom: 0.15169307642779084d,left: 0.005685234369565029d),

new NpgsqlTypes.NpgsqlBox(top: 0.33197362145529685d,right: 0.8783500840483561d,bottom: 0.06903801033436718d,left: 0.7451818341867559d),

new NpgsqlTypes.NpgsqlBox(top: 0.9382504946858994d,right: 0.5539227514842796d,bottom: 0.00354439696782316d,left: 0.34052188882562695d),

new NpgsqlTypes.NpgsqlBox(top: 0.5949561949385699d,right: 0.21080694656539678d,bottom: 0.0900305057169365d,left: 0.06839763924599263d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9636454221738241d,right: 0.3745095615833014d,bottom: 0.2624729634661367d,left: 0.010399480032892705d),

new NpgsqlTypes.NpgsqlBox(top: 0.25760276569710505d,right: 0.4458150770875743d,bottom: 0.24072940635338047d,left: 0.061729571761688584d),

new NpgsqlTypes.NpgsqlBox(top: 0.7715269197550045d,right: 0.33787818633529587d,bottom: 0.46896161345002885d,left: 0.3373904049591766d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9375747962922827d,right: 0.48468030196149026d,bottom: 0.4990401280211999d,left: 0.3216227633539688d),

new NpgsqlTypes.NpgsqlBox(top: 0.17613458291898576d,right: 0.3595299041861104d,bottom: 0.04174693218628023d,left: 0.2841152486992694d),

new NpgsqlTypes.NpgsqlBox(top: 0.07530428209379059d,right: 0.21033079020884426d,bottom: 0.05004509687610326d,left: 0.14783025199599054d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.23817256256692265d,right: 0.7908655621382195d,bottom: 0.023553685173949845d,left: 0.589864417024915d),

new NpgsqlTypes.NpgsqlBox(top: 0.21105482478203386d,right: 0.802053719681446d,bottom: 0.12850723857399238d,left: 0.26329192111576427d),

new NpgsqlTypes.NpgsqlBox(top: 0.9246721509955607d,right: 0.36898796004711276d,bottom: 0.28289130875503055d,left: 0.36777397862219585d),

new NpgsqlTypes.NpgsqlBox(top: 0.8539441945298889d,right: 0.39061095183686845d,bottom: 0.4107553761174684d,left: 0.15485478209916637d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9967814845424726d,right: 0.8792166747765376d,bottom: 0.4440572640642131d,left: 0.42169364587043556d),

new NpgsqlTypes.NpgsqlBox(top: 0.9260794456838037d,right: 0.9056887942551353d,bottom: 0.4823547295797548d,left: 0.6319198762903956d),

new NpgsqlTypes.NpgsqlBox(top: 0.41114474610858043d,right: 0.9592798266378231d,bottom: 0.38170699861571555d,left: 0.48921679083829106d),

new NpgsqlTypes.NpgsqlBox(top: 0.8545891581565115d,right: 0.22810537902201344d,bottom: 0.5656235805464812d,left: 0.17968417333755105d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4144514490511493d,right: 0.9718911118677682d,bottom: 0.270233493061261d,left: 0.9164141805315634d),

new NpgsqlTypes.NpgsqlBox(top: 0.7528291476121772d,right: 0.36791474725129436d,bottom: 0.043718027212977906d,left: 0.006544117895682211d),

new NpgsqlTypes.NpgsqlBox(top: 0.6334194808442922d,right: 0.781008386799686d,bottom: 0.3476603573126634d,left: 0.6557944475019858d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.05453631949646642d,right: 0.1936119798771032d,bottom: 0.021415282069958574d,left: 0.016754795921249732d),

new NpgsqlTypes.NpgsqlBox(top: 0.501282045665889d,right: 0.6749448913924357d,bottom: 0.17281744682372402d,left: 0.1352045016156218d),

new NpgsqlTypes.NpgsqlBox(top: 0.5843074712327501d,right: 0.7897891373722586d,bottom: 0.06396089412340289d,left: 0.6482268052395611d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8803882438803569d,right: 0.9951447543067556d,bottom: 0.42488626533295504d,left: 0.5039798132146732d),

new NpgsqlTypes.NpgsqlBox(top: 0.9085567257301006d,right: 0.8795949655019559d,bottom: 0.11214514713151402d,left: 0.392443597125647d),

new NpgsqlTypes.NpgsqlBox(top: 0.9761609672570072d,right: 0.520245344947339d,bottom: 0.19989996489513384d,left: 0.26357160658169665d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.31090215369892216d,right: 0.9480106437407027d,bottom: 0.17002899348135925d,left: 0.7212570121348865d),

new NpgsqlTypes.NpgsqlBox(top: 0.8116987696810722d,right: 0.9486489470819943d,bottom: 0.37501599080349435d,left: 0.2557764375236188d),

new NpgsqlTypes.NpgsqlBox(top: 0.9365334114834934d,right: 0.9044375313237215d,bottom: 0.2458550504023851d,left: 0.1712803228505998d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8661939014410132d,right: 0.8475965386578307d,bottom: 0.5688510164310463d,left: 0.11613796856950953d),

new NpgsqlTypes.NpgsqlBox(top: 0.4106817776696965d,right: 0.8649924266995863d,bottom: 0.24796996462255372d,left: 0.39008985554840236d),

new NpgsqlTypes.NpgsqlBox(top: 0.8477090229121826d,right: 0.8114874696020588d,bottom: 0.6704506815327075d,left: 0.13740606793007182d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4235778654435136d,right: 0.49935694426652166d,bottom: 0.15571225563894597d,left: 0.2338035072678173d),

new NpgsqlTypes.NpgsqlBox(top: 0.4490584525841179d,right: 0.21273486919910856d,bottom: 0.1763322122782861d,left: 0.10046871838642668d),

new NpgsqlTypes.NpgsqlBox(top: 0.9341405937878325d,right: 0.8017459110156431d,bottom: 0.7547023809686456d,left: 0.33048856208583255d),

new NpgsqlTypes.NpgsqlBox(top: 0.6931453479193062d,right: 0.5098407356074519d,bottom: 0.17891004158410817d,left: 0.044707793884522395d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9025751161739625d,right: 0.9227554917740428d,bottom: 0.5498540460672708d,left: 0.19266414235339857d),

new NpgsqlTypes.NpgsqlBox(top: 0.6537873173110121d,right: 0.8096038758202688d,bottom: 0.29441730883726547d,left: 0.12128984898666484d),

new NpgsqlTypes.NpgsqlBox(top: 0.7017275635511645d,right: 0.8356621893070872d,bottom: 0.08800197087095685d,left: 0.19595673329119134d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7477636279054424d,right: 0.9024411863086381d,bottom: 0.34202741602341824d,left: 0.6840841214740323d),

new NpgsqlTypes.NpgsqlBox(top: 0.8174558614336519d,right: 0.20403828487257014d,bottom: 0.5010187981775079d,left: 0.06672429272738778d),

new NpgsqlTypes.NpgsqlBox(top: 0.27113450161944086d,right: 0.27272720023696895d,bottom: 0.2589682932862658d,left: 0.1752639361398628d),

new NpgsqlTypes.NpgsqlBox(top: 0.7488369100768731d,right: 0.8470844072749212d,bottom: 0.1893341449507988d,left: 0.4466505983054371d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9484877513157535d,right: 0.40391394367761435d,bottom: 0.6507220618926848d,left: 0.3103968761299306d),

new NpgsqlTypes.NpgsqlBox(top: 0.44442296271268866d,right: 0.047616061677426935d,bottom: 0.18242393332416795d,left: 0.03682777515987479d),

new NpgsqlTypes.NpgsqlBox(top: 0.2903118176323666d,right: 0.6508219630800184d,bottom: 0.15134243252843838d,left: 0.492914679084135d),

new NpgsqlTypes.NpgsqlBox(top: 0.6617071233605389d,right: 0.9397785760161156d,bottom: 0.4596887635900737d,left: 0.7272870326161555d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9434629598396672d,right: 0.49086498135775625d,bottom: 0.04307582850825176d,left: 0.4732698839791969d),

new NpgsqlTypes.NpgsqlBox(top: 0.49212406907118966d,right: 0.6672893524477843d,bottom: 0.33190973896046627d,left: 0.12928544911218032d),

new NpgsqlTypes.NpgsqlBox(top: 0.613682416638634d,right: 0.31092725547721156d,bottom: 0.4715324551489031d,left: 0.07743601644292952d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5943635401682622d,right: 0.8202334898168308d,bottom: 0.2548222851820915d,left: 0.06697351229078441d),

new NpgsqlTypes.NpgsqlBox(top: 0.3810276003269386d,right: 0.6614990315512072d,bottom: 0.03444331904348563d,left: 0.3011345972333829d),

new NpgsqlTypes.NpgsqlBox(top: 0.5409919142875455d,right: 0.939520034223278d,bottom: 0.12773915150727333d,left: 0.3576547705988402d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.22833725107463232d,right: 0.6800134603929087d,bottom: 0.1568831807200134d,left: 0.148873505013853d),

new NpgsqlTypes.NpgsqlBox(top: 0.9850552139046611d,right: 0.8715355883235971d,bottom: 0.4594126061700403d,left: 0.7842459749845965d),

new NpgsqlTypes.NpgsqlBox(top: 0.8098149485367062d,right: 0.9194899178001567d,bottom: 0.6460103323223969d,left: 0.09909699244647652d),

new NpgsqlTypes.NpgsqlBox(top: 0.9977020164629794d,right: 0.33919648392076496d,bottom: 0.5332440288601943d,left: 0.05545361715216757d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8379326202630433d,right: 0.7232507846493373d,bottom: 0.041736004825497d,left: 0.6449338226224003d),

new NpgsqlTypes.NpgsqlBox(top: 0.5700432377226946d,right: 0.9606910945588055d,bottom: 0.2591838555627438d,left: 0.5249121666530854d),

new NpgsqlTypes.NpgsqlBox(top: 0.8305941607416909d,right: 0.3861569513509767d,bottom: 0.14495462375587498d,left: 0.36737711092804626d),

new NpgsqlTypes.NpgsqlBox(top: 0.7971265967444984d,right: 0.4009630511253398d,bottom: 0.2907686904466311d,left: 0.12165996010122737d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6685313975887984d,right: 0.4166125180798058d,bottom: 0.5645549281479959d,left: 0.36771028101385483d),

new NpgsqlTypes.NpgsqlBox(top: 0.7168207569109762d,right: 0.8752433303586071d,bottom: 0.6738858228028695d,left: 0.311486131466548d),

new NpgsqlTypes.NpgsqlBox(top: 0.785704529012592d,right: 0.8076722665567964d,bottom: 0.13966553690783645d,left: 0.6467401139953413d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5724891305697931d,right: 0.8801128004666577d,bottom: 0.022235633335791927d,left: 0.14411401836064264d),

new NpgsqlTypes.NpgsqlBox(top: 0.9838818257663509d,right: 0.8771560651413558d,bottom: 0.7722099633284568d,left: 0.016983066961477666d),

new NpgsqlTypes.NpgsqlBox(top: 0.9707039134030215d,right: 0.7148492909497742d,bottom: 0.03636567288357995d,left: 0.1328594312185385d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5139948752351566d,right: 0.8091090919216759d,bottom: 0.33358027559752723d,left: 0.057234560140495105d),

new NpgsqlTypes.NpgsqlBox(top: 0.28073240306382063d,right: 0.9435596276125464d,bottom: 0.11676023385528989d,left: 0.46786542102608497d),

new NpgsqlTypes.NpgsqlBox(top: 0.7621849266577435d,right: 0.8478895556733387d,bottom: 0.7466714565868522d,left: 0.6966349073318315d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.775399438608043d,right: 0.8785634292779188d,bottom: 0.7452700407557121d,left: 0.26029667578368787d),

new NpgsqlTypes.NpgsqlBox(top: 0.2650406654761194d,right: 0.9621086675836055d,bottom: 0.22123372317196055d,left: 0.7976562807025283d),

new NpgsqlTypes.NpgsqlBox(top: 0.7578640288489529d,right: 0.22101147468019322d,bottom: 0.21460543488648154d,left: 0.14652643506859164d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7024703987413466d,right: 0.46802013939601683d,bottom: 0.28829085661163756d,left: 0.4678735080634684d),

new NpgsqlTypes.NpgsqlBox(top: 0.6654612505722305d,right: 0.815623962566898d,bottom: 0.5585168262784006d,left: 0.45713333856789506d),

new NpgsqlTypes.NpgsqlBox(top: 0.8823403164287015d,right: 0.5760010000716953d,bottom: 0.35938669992462136d,left: 0.11860872483274831d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9830453455236237d,right: 0.20274357778868268d,bottom: 0.40191787123677325d,left: 0.033988610936258046d),

new NpgsqlTypes.NpgsqlBox(top: 0.6610697943824961d,right: 0.930371785874608d,bottom: 0.34265778997852236d,left: 0.8909399148751083d),

new NpgsqlTypes.NpgsqlBox(top: 0.4141428676181871d,right: 0.9743944621183588d,bottom: 0.30221889214408826d,left: 0.5102198953106888d),

new NpgsqlTypes.NpgsqlBox(top: 0.7516673215587194d,right: 0.9210195710100363d,bottom: 0.43282982850552554d,left: 0.6139374303850171d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8275620935275956d,right: 0.7657748428088812d,bottom: 0.5557207371775386d,left: 0.3463926821721137d),

new NpgsqlTypes.NpgsqlBox(top: 0.454721944027051d,right: 0.47422258729426947d,bottom: 0.38172212443020104d,left: 0.2480108135988912d),

new NpgsqlTypes.NpgsqlBox(top: 0.3494921698891309d,right: 0.7467269177257169d,bottom: 0.2074140899312863d,left: 0.6727450879680431d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3083394122473966d,right: 0.9971153808323584d,bottom: 0.2594119892673118d,left: 0.251095331076978d),

new NpgsqlTypes.NpgsqlBox(top: 0.7234761906840032d,right: 0.8723669409578185d,bottom: 0.4973757804869866d,left: 0.8514146961533692d),

new NpgsqlTypes.NpgsqlBox(top: 0.8797469396020944d,right: 0.4478137433783713d,bottom: 0.16471778433585416d,left: 0.32042267543517045d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8512492727302446d,right: 0.4585270786664625d,bottom: 0.4214167562572424d,left: 0.1555211838277657d),

new NpgsqlTypes.NpgsqlBox(top: 0.9517700480022657d,right: 0.9033610310783594d,bottom: 0.6800206634321588d,left: 0.262531000814782d),

new NpgsqlTypes.NpgsqlBox(top: 0.40245245760379444d,right: 0.562922269041047d,bottom: 0.32030679406435225d,left: 0.11572979245755532d),

new NpgsqlTypes.NpgsqlBox(top: 0.4180011010196625d,right: 0.4275812756984604d,bottom: 0.39098299707061523d,left: 0.3672658206911601d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9928483225138657d,right: 0.6271747376220314d,bottom: 0.046809990486232356d,left: 0.36109248567274144d),

new NpgsqlTypes.NpgsqlBox(top: 0.4829646916639925d,right: 0.5160255788935189d,bottom: 0.2667175133883871d,left: 0.3495094084458783d),

new NpgsqlTypes.NpgsqlBox(top: 0.36618827241948626d,right: 0.9175719832638437d,bottom: 0.15046377481989148d,left: 0.044350537024565595d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6694109406442611d,right: 0.6241263935749143d,bottom: 0.6223118572594225d,left: 0.15829895687102402d),

new NpgsqlTypes.NpgsqlBox(top: 0.6177059384809896d,right: 0.7908344526333423d,bottom: 0.35291626572110046d,left: 0.1604020211791376d),

new NpgsqlTypes.NpgsqlBox(top: 0.19471271566155923d,right: 0.728086647263563d,bottom: 0.10739038523028543d,left: 0.3307055198203239d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5799673648490102d,right: 0.9185440299692527d,bottom: 0.17106991500870095d,left: 0.2997547200868993d),

new NpgsqlTypes.NpgsqlBox(top: 0.6934842542588406d,right: 0.8361894978214038d,bottom: 0.36957321229783324d,left: 0.29249607705476344d),

new NpgsqlTypes.NpgsqlBox(top: 0.5738825915251236d,right: 0.6198055096389504d,bottom: 0.44681855671123194d,left: 0.40974461390416295d),

new NpgsqlTypes.NpgsqlBox(top: 0.6942279842276492d,right: 0.5019774921262403d,bottom: 0.632054744511722d,left: 0.4695855934198041d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2214614202515578d,right: 0.790529233772057d,bottom: 0.10627615778050747d,left: 0.06170098161646653d),

new NpgsqlTypes.NpgsqlBox(top: 0.9293061638699449d,right: 0.9706165849818673d,bottom: 0.9203066224721326d,left: 0.23256812421665285d),

new NpgsqlTypes.NpgsqlBox(top: 0.9758043211268113d,right: 0.2572742872233844d,bottom: 0.8388878182622617d,left: 0.08429374304211079d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7032791693867958d,right: 0.41023887336038156d,bottom: 0.4536483200228514d,left: 0.2731794362405612d),

new NpgsqlTypes.NpgsqlBox(top: 0.9760051860744019d,right: 0.5509769420537408d,bottom: 0.26123444581843136d,left: 0.010622457121601037d),

new NpgsqlTypes.NpgsqlBox(top: 0.49748597577820086d,right: 0.5437174436953603d,bottom: 0.09516364921900078d,left: 0.12127980333010724d),

new NpgsqlTypes.NpgsqlBox(top: 0.6031454733742895d,right: 0.8324096451234076d,bottom: 0.08729490383766147d,left: 0.019057081601591475d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3007024293242321d,right: 0.7983379604967045d,bottom: 0.26937207448575196d,left: 0.14352755980440568d),

new NpgsqlTypes.NpgsqlBox(top: 0.6820120005928242d,right: 0.42146228435298416d,bottom: 0.06698819353323415d,left: 0.268753093612206d),

new NpgsqlTypes.NpgsqlBox(top: 0.8145145960794088d,right: 0.5335881301780145d,bottom: 0.12787138880239268d,left: 0.19275254970084932d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2mi(
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
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

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxListboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxListboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxListboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxListboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray2mi_id
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
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray2mi_id", 
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
                List<NpgsqlBoxboxArray2M> models = null;

                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlBoxListboxArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray2M> models = null;

                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxListboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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

                var models = await ((INpgsqlBoxListboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((INpgsqlBoxListboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxListboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlBoxListboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxListboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 52;
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[10], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[11], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[12], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[13], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[14], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[15], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[16], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[17], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 117;
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[14], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[15], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[16], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[17], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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

                var models = await ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[5], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[6], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[29], false);
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

                var models =  ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 108, query1, 94, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 94, query1, 108, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[29], false);
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
FROM public.npgsqlboxboxarray2m m
LEFT JOIN public.npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
                var models = await ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelBatchAsync(connection, 40, 8))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[1], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[2], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[3], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[4], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[5], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[6], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[29], false);
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
                var models =  ((INpgsqlBoxListboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelBatch(connection, 122, 71))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[29], false);
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
                await using var cmd = await ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 74);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 80);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
FROM public.binary_npgsqlboxboxarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlBoxListboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlBoxListboxArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlBoxListboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
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
FROM public.binary_npgsqlboxboxarray2m m
LEFT JOIN public.binary_npgsqlboxboxarray2mi mi ON mi.id = m.npgsqlboxboxarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray2M>(15);

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
                ((INpgsqlBoxListboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxListboxArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlBoxListboxArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlBoxListboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlBoxboxArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlBoxboxArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxListboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxListboxArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

