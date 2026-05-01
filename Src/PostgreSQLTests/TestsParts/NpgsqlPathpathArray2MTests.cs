

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
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23696276071954958d, y: 0.37632273498016366d), new NpgsqlTypes.NpgsqlPoint(x: 0.7395041077685114d, y: 0.06437017996548722d), new NpgsqlTypes.NpgsqlPoint(x: 0.05801526227476961d, y: 0.7204443722717611d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7514089811749712d, y: 0.11693031482848948d), new NpgsqlTypes.NpgsqlPoint(x: 0.458149436307302d, y: 0.6280158062859836d), new NpgsqlTypes.NpgsqlPoint(x: 0.315085686072355d, y: 0.2785183040978988d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33047359371063567d, y: 0.5798171944833171d), new NpgsqlTypes.NpgsqlPoint(x: 0.9752954705632786d, y: 0.303274104804484d), new NpgsqlTypes.NpgsqlPoint(x: 0.8636212346931599d, y: 0.1418996242678222d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8334526633061698d, y: 0.25271188083365836d), new NpgsqlTypes.NpgsqlPoint(x: 0.5763219043375347d, y: 0.12692822732540265d), new NpgsqlTypes.NpgsqlPoint(x: 0.6915092610276811d, y: 0.056330943924510324d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6949972273637197d, y: 0.22106302427759061d), new NpgsqlTypes.NpgsqlPoint(x: 0.44808196758214847d, y: 0.10651378169298364d), new NpgsqlTypes.NpgsqlPoint(x: 0.2682568526590603d, y: 0.5065588950692871d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.99772026834457d, y: 0.47388712110952924d), new NpgsqlTypes.NpgsqlPoint(x: 0.20205484062408308d, y: 0.3067234140155458d), new NpgsqlTypes.NpgsqlPoint(x: 0.15901193127239044d, y: 0.5403617398436726d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35095418948162405d, y: 0.6466098078996673d), new NpgsqlTypes.NpgsqlPoint(x: 0.3440607669221122d, y: 0.49007336786646116d), new NpgsqlTypes.NpgsqlPoint(x: 0.47456835219014926d, y: 0.7733738938568356d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2674401340921909d, y: 0.09445170317409635d), new NpgsqlTypes.NpgsqlPoint(x: 0.2932392619962887d, y: 0.10502257865114184d), new NpgsqlTypes.NpgsqlPoint(x: 0.34309787582911966d, y: 0.10393798400869025d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8378253713449777d, y: 0.9165257563250031d), new NpgsqlTypes.NpgsqlPoint(x: 0.9709677672458484d, y: 0.4155327512459709d), new NpgsqlTypes.NpgsqlPoint(x: 0.8726131844009954d, y: 0.33281725541468177d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4917862504720174d, y: 0.8177427756145761d), new NpgsqlTypes.NpgsqlPoint(x: 0.5693063386450303d, y: 0.4527679413452834d), new NpgsqlTypes.NpgsqlPoint(x: 0.29947544214587485d, y: 0.24261794156196048d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44939582509189635d, y: 0.9045518926137747d), new NpgsqlTypes.NpgsqlPoint(x: 0.5559188588748424d, y: 0.7374562136786232d), new NpgsqlTypes.NpgsqlPoint(x: 0.9204775889794707d, y: 0.41123808602608836d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3456004226273862d, y: 0.6655074826551551d), new NpgsqlTypes.NpgsqlPoint(x: 0.43786783836227405d, y: 0.4522929232943631d), new NpgsqlTypes.NpgsqlPoint(x: 0.8275981356102372d, y: 0.3307746629019992d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5964152017006065d, y: 0.425362377686647d), new NpgsqlTypes.NpgsqlPoint(x: 0.0690042711299459d, y: 0.39444290200602083d), new NpgsqlTypes.NpgsqlPoint(x: 0.21094707705318394d, y: 0.07824048588607524d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26545268183863613d, y: 0.4491266576662375d), new NpgsqlTypes.NpgsqlPoint(x: 0.9183555008319032d, y: 0.8185372839841034d), new NpgsqlTypes.NpgsqlPoint(x: 0.5952757577204626d, y: 0.09309463804982532d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4542074820166112d, y: 0.9886397329816808d), new NpgsqlTypes.NpgsqlPoint(x: 0.029326368332805663d, y: 0.44206976037456125d), new NpgsqlTypes.NpgsqlPoint(x: 0.308460271483614d, y: 0.9044393915869952d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.843922956849431d, y: 0.9728524577416261d), new NpgsqlTypes.NpgsqlPoint(x: 0.5219580877703401d, y: 0.0460825486895311d), new NpgsqlTypes.NpgsqlPoint(x: 0.21922296229944405d, y: 0.5107868441965053d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02460092824691973d, y: 0.46440702439942616d), new NpgsqlTypes.NpgsqlPoint(x: 0.5095904047083727d, y: 0.6083695539414318d), new NpgsqlTypes.NpgsqlPoint(x: 0.8218187634467662d, y: 0.2323298892458021d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36609543502311226d, y: 0.4154740413952327d), new NpgsqlTypes.NpgsqlPoint(x: 0.6295353934198166d, y: 0.9950562384202529d), new NpgsqlTypes.NpgsqlPoint(x: 0.2842125615740745d, y: 0.7679039901142977d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7302413204446268d, y: 0.29114316048833d), new NpgsqlTypes.NpgsqlPoint(x: 0.9449048118925985d, y: 0.1086303662970961d), new NpgsqlTypes.NpgsqlPoint(x: 0.7410429510338847d, y: 0.8525152083072198d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7792458528290634d, y: 0.3958745631714402d), new NpgsqlTypes.NpgsqlPoint(x: 0.8243453852177712d, y: 0.3558067051530648d), new NpgsqlTypes.NpgsqlPoint(x: 0.09800239438271985d, y: 0.6921623719434692d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9831123057421525d, y: 0.1820639874902864d), new NpgsqlTypes.NpgsqlPoint(x: 0.4004911858804331d, y: 0.24104705639419355d), new NpgsqlTypes.NpgsqlPoint(x: 0.1976747820786683d, y: 0.40602754742297d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4428378620256982d, y: 0.6587581398188066d), new NpgsqlTypes.NpgsqlPoint(x: 0.3541856891872044d, y: 0.606466642232415d), new NpgsqlTypes.NpgsqlPoint(x: 0.1834404233603355d, y: 0.4415207754888848d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5430114674622495d, y: 0.5527073666469665d), new NpgsqlTypes.NpgsqlPoint(x: 0.03775571244366027d, y: 0.4919115527757666d), new NpgsqlTypes.NpgsqlPoint(x: 0.14925010550433304d, y: 0.6651923711167599d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6982630131572353d, y: 0.02334601174765627d), new NpgsqlTypes.NpgsqlPoint(x: 0.13372364861695785d, y: 0.10093113547244303d), new NpgsqlTypes.NpgsqlPoint(x: 0.40910893374027535d, y: 0.2782884376938043d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44277562652046987d, y: 0.615497591824552d), new NpgsqlTypes.NpgsqlPoint(x: 0.8580268936538303d, y: 0.04371797396110788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7519399175520785d, y: 0.6788025378229913d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8031778847826543d, y: 0.40439098729931444d), new NpgsqlTypes.NpgsqlPoint(x: 0.8382336645089704d, y: 0.9397946954985689d), new NpgsqlTypes.NpgsqlPoint(x: 0.4530453971024241d, y: 0.9024621793755603d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9587725737902749d, y: 0.5567834123719411d), new NpgsqlTypes.NpgsqlPoint(x: 0.3240238253989285d, y: 0.8965207426450865d), new NpgsqlTypes.NpgsqlPoint(x: 0.33441310983556427d, y: 0.5378740465862626d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9489537022962711d, y: 0.9267513886885856d), new NpgsqlTypes.NpgsqlPoint(x: 0.19194954313688983d, y: 0.14206279115569276d), new NpgsqlTypes.NpgsqlPoint(x: 0.48286978838392935d, y: 0.8294675588502286d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2860434333246238d, y: 0.7255417958796899d), new NpgsqlTypes.NpgsqlPoint(x: 0.03311950510545236d, y: 0.9899818218607808d), new NpgsqlTypes.NpgsqlPoint(x: 0.748035189913309d, y: 0.07881305533964478d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14610365945817916d, y: 0.7594090844846311d), new NpgsqlTypes.NpgsqlPoint(x: 0.1515056487737112d, y: 0.5872609581829777d), new NpgsqlTypes.NpgsqlPoint(x: 0.10223588807095074d, y: 0.7080552307011317d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9877820395216265d, y: 0.8991814772404219d), new NpgsqlTypes.NpgsqlPoint(x: 0.7338563055204178d, y: 0.964547778984841d), new NpgsqlTypes.NpgsqlPoint(x: 0.12951660944578736d, y: 0.047925314480052994d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9096041571820854d, y: 0.16258755607765296d), new NpgsqlTypes.NpgsqlPoint(x: 0.12348026775575482d, y: 0.2961475088888237d), new NpgsqlTypes.NpgsqlPoint(x: 0.7730980145264735d, y: 0.2547502528721134d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2616719051068326d, y: 0.9801670362742811d), new NpgsqlTypes.NpgsqlPoint(x: 0.5513391017774967d, y: 0.322375173091488d), new NpgsqlTypes.NpgsqlPoint(x: 0.21088899429179708d, y: 0.8879921885274614d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8854354819746976d, y: 0.28298778786670975d), new NpgsqlTypes.NpgsqlPoint(x: 0.8871496569389515d, y: 0.14132940447479114d), new NpgsqlTypes.NpgsqlPoint(x: 0.12791614591133005d, y: 0.635832111885022d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08726794788282921d, y: 0.14944681581064978d), new NpgsqlTypes.NpgsqlPoint(x: 0.1825304313385736d, y: 0.7245745089540402d), new NpgsqlTypes.NpgsqlPoint(x: 0.6557345259263946d, y: 0.2108702472817685d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4538149590432742d, y: 0.949518384830755d), new NpgsqlTypes.NpgsqlPoint(x: 0.06301970979771077d, y: 0.324592150971041d), new NpgsqlTypes.NpgsqlPoint(x: 0.7038478631773948d, y: 0.9456545026344328d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0909794369859489d, y: 0.20315357209052232d), new NpgsqlTypes.NpgsqlPoint(x: 0.46263070948740725d, y: 0.16470813917968974d), new NpgsqlTypes.NpgsqlPoint(x: 0.7859653931216392d, y: 0.3039589011319205d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1982261815352806d, y: 0.5398702289268223d), new NpgsqlTypes.NpgsqlPoint(x: 0.1595043137871761d, y: 0.9893426601480161d), new NpgsqlTypes.NpgsqlPoint(x: 0.012201022137671935d, y: 0.1347509938243121d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7692527006465122d, y: 0.6126692818586458d), new NpgsqlTypes.NpgsqlPoint(x: 0.7621975436693048d, y: 0.5911290973881322d), new NpgsqlTypes.NpgsqlPoint(x: 0.3569117387347386d, y: 0.5873567303427374d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5721983740704278d, y: 0.6181448914884794d), new NpgsqlTypes.NpgsqlPoint(x: 0.7482244364007413d, y: 0.002797537255686766d), new NpgsqlTypes.NpgsqlPoint(x: 0.7412514915084373d, y: 0.3715674593054059d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6013274135281531d, y: 0.8435646790245724d), new NpgsqlTypes.NpgsqlPoint(x: 0.7694662208357265d, y: 0.7872697679259542d), new NpgsqlTypes.NpgsqlPoint(x: 0.49221666673736d, y: 0.750419141864522d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.98582615687951d, y: 0.41905688080297454d), new NpgsqlTypes.NpgsqlPoint(x: 0.31572848691336663d, y: 0.3254654318826903d), new NpgsqlTypes.NpgsqlPoint(x: 0.8793098632978765d, y: 0.1327051661756251d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9148610602899045d, y: 0.7349256413991457d), new NpgsqlTypes.NpgsqlPoint(x: 0.8695919614578242d, y: 0.42987281553136536d), new NpgsqlTypes.NpgsqlPoint(x: 0.3988142260995936d, y: 0.6884542473251618d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24545586237913997d, y: 0.9559257527751872d), new NpgsqlTypes.NpgsqlPoint(x: 0.6519983888875742d, y: 0.24271066671002006d), new NpgsqlTypes.NpgsqlPoint(x: 0.7836515346635483d, y: 0.6431936961965988d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14074664953694782d, y: 0.6332220913111631d), new NpgsqlTypes.NpgsqlPoint(x: 0.43083688323174407d, y: 0.19966030388665912d), new NpgsqlTypes.NpgsqlPoint(x: 0.32445087574080533d, y: 0.23249759881042154d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1704645007527671d, y: 0.278730914253165d), new NpgsqlTypes.NpgsqlPoint(x: 0.4361042178314972d, y: 0.5472169819466595d), new NpgsqlTypes.NpgsqlPoint(x: 0.740536464890902d, y: 0.8768427429421034d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3789863875656315d, y: 0.7342764864099548d), new NpgsqlTypes.NpgsqlPoint(x: 0.20864739759975703d, y: 0.6866104245517164d), new NpgsqlTypes.NpgsqlPoint(x: 0.5081874351527761d, y: 0.05425224920849858d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37918454505142674d, y: 0.44119944829561675d), new NpgsqlTypes.NpgsqlPoint(x: 0.5403164062791934d, y: 0.5616397934432208d), new NpgsqlTypes.NpgsqlPoint(x: 0.7500940847745065d, y: 0.6887467458992402d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26352956105426584d, y: 0.3317972176355848d), new NpgsqlTypes.NpgsqlPoint(x: 0.18734658139343063d, y: 0.2035484671947836d), new NpgsqlTypes.NpgsqlPoint(x: 0.5575069953185858d, y: 0.8210714929335502d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6901811676777004d, y: 0.09290901516154215d), new NpgsqlTypes.NpgsqlPoint(x: 0.7134629243611031d, y: 0.40597846321794673d), new NpgsqlTypes.NpgsqlPoint(x: 0.9161614026641364d, y: 0.9448670518487481d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2934537376534082d, y: 0.27502967749795215d), new NpgsqlTypes.NpgsqlPoint(x: 0.12424853934782076d, y: 0.6166601759374062d), new NpgsqlTypes.NpgsqlPoint(x: 0.8907304610278132d, y: 0.6038618848988593d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.688048266283801d, y: 0.5383979719634889d), new NpgsqlTypes.NpgsqlPoint(x: 0.6682432614077093d, y: 0.1954942397628997d), new NpgsqlTypes.NpgsqlPoint(x: 0.2855160527246009d, y: 0.5576930992331306d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2059061601272415d, y: 0.2635755955091488d), new NpgsqlTypes.NpgsqlPoint(x: 0.9186543950955183d, y: 0.4168992037444338d), new NpgsqlTypes.NpgsqlPoint(x: 0.30346141044829267d, y: 0.4570412790644208d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40437244704450415d, y: 0.48909659741581013d), new NpgsqlTypes.NpgsqlPoint(x: 0.31110098695774047d, y: 0.4608825623663827d), new NpgsqlTypes.NpgsqlPoint(x: 0.5829577861631488d, y: 0.387577983409507d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6021660790789244d, y: 0.5986412236345957d), new NpgsqlTypes.NpgsqlPoint(x: 0.8168373426164922d, y: 0.7999901207534204d), new NpgsqlTypes.NpgsqlPoint(x: 0.3998914876938141d, y: 0.3655092290167403d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8691551502622051d, y: 0.23619415454788661d), new NpgsqlTypes.NpgsqlPoint(x: 0.07333215349701527d, y: 0.38784394538250666d), new NpgsqlTypes.NpgsqlPoint(x: 0.5335338223021907d, y: 0.8646542115840258d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8976280826202963d, y: 0.3625227685122573d), new NpgsqlTypes.NpgsqlPoint(x: 0.2842861951886243d, y: 0.2628548074540795d), new NpgsqlTypes.NpgsqlPoint(x: 0.8726175405440414d, y: 0.3900152876496493d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8750046950178075d, y: 0.2982931384420109d), new NpgsqlTypes.NpgsqlPoint(x: 0.1514702239422412d, y: 0.7451988239908484d), new NpgsqlTypes.NpgsqlPoint(x: 0.5166864478740413d, y: 0.12916680205416964d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9352967593638802d, y: 0.3637606172734211d), new NpgsqlTypes.NpgsqlPoint(x: 0.040495306372988815d, y: 0.15430003522431757d), new NpgsqlTypes.NpgsqlPoint(x: 0.3079934462136191d, y: 0.15421272011592446d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22076516433263715d, y: 0.19003954562160252d), new NpgsqlTypes.NpgsqlPoint(x: 0.8938715373284191d, y: 0.5865106991609451d), new NpgsqlTypes.NpgsqlPoint(x: 0.7765727381662342d, y: 0.9971452801874728d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17662146321880112d, y: 0.8555578309017563d), new NpgsqlTypes.NpgsqlPoint(x: 0.47217745361753904d, y: 0.9878694003096323d), new NpgsqlTypes.NpgsqlPoint(x: 0.35396106630168633d, y: 0.8173952551177291d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7233674598375057d, y: 0.3578592330048369d), new NpgsqlTypes.NpgsqlPoint(x: 0.04457055444930069d, y: 0.09422848670886441d), new NpgsqlTypes.NpgsqlPoint(x: 0.13646742492772312d, y: 0.9836085429844303d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.401648842020884d, y: 0.19268313571321927d), new NpgsqlTypes.NpgsqlPoint(x: 0.14379223202043945d, y: 0.39971403785174575d), new NpgsqlTypes.NpgsqlPoint(x: 0.521291276157807d, y: 0.544663741317939d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11227738869503945d, y: 0.18351785135241216d), new NpgsqlTypes.NpgsqlPoint(x: 0.2963796239187708d, y: 0.3605637435071948d), new NpgsqlTypes.NpgsqlPoint(x: 0.008899158035381993d, y: 0.6828588076025408d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06881207258734612d, y: 0.523681399296679d), new NpgsqlTypes.NpgsqlPoint(x: 0.4217120479481973d, y: 0.09882617505811275d), new NpgsqlTypes.NpgsqlPoint(x: 0.03294876509254718d, y: 0.8438908939442923d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15227006990990677d, y: 0.634084867207215d), new NpgsqlTypes.NpgsqlPoint(x: 0.2590657656356993d, y: 0.9449333261260454d), new NpgsqlTypes.NpgsqlPoint(x: 0.9439556683116418d, y: 0.23943058095913494d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9464434444714458d, y: 0.04065686229318621d), new NpgsqlTypes.NpgsqlPoint(x: 0.07951013210181879d, y: 0.2654678871347036d), new NpgsqlTypes.NpgsqlPoint(x: 0.1860950342944213d, y: 0.3652917066039584d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06373443455836225d, y: 0.7483246529956996d), new NpgsqlTypes.NpgsqlPoint(x: 0.21564364594352348d, y: 0.8428944331447733d), new NpgsqlTypes.NpgsqlPoint(x: 0.8223844500672813d, y: 0.10663857593874393d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8114324458417199d, y: 0.8667412200262591d), new NpgsqlTypes.NpgsqlPoint(x: 0.3200587194858937d, y: 0.047120088242252d), new NpgsqlTypes.NpgsqlPoint(x: 0.5767403011536849d, y: 0.062157683791070895d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9657294847779927d, y: 0.09336904517207678d), new NpgsqlTypes.NpgsqlPoint(x: 0.17467463782380144d, y: 0.5694050142376212d), new NpgsqlTypes.NpgsqlPoint(x: 0.5494226230991921d, y: 0.14981244157798013d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03281758018907477d, y: 0.4079322574902773d), new NpgsqlTypes.NpgsqlPoint(x: 0.06107130716668474d, y: 0.1440556511354142d), new NpgsqlTypes.NpgsqlPoint(x: 0.8637859676436558d, y: 0.5193214070234988d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8824092872863541d, y: 0.9242932858069314d), new NpgsqlTypes.NpgsqlPoint(x: 0.22894017245304354d, y: 0.3397289253808172d), new NpgsqlTypes.NpgsqlPoint(x: 0.3378222052860399d, y: 0.3179819814195648d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14793848606246307d, y: 0.5896121155885673d), new NpgsqlTypes.NpgsqlPoint(x: 0.6875541141611433d, y: 0.6622570837628601d), new NpgsqlTypes.NpgsqlPoint(x: 0.27319652573170483d, y: 0.02786373221080629d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5664733577157631d, y: 0.6228954061334285d), new NpgsqlTypes.NpgsqlPoint(x: 0.9531279938620761d, y: 0.5893215918216858d), new NpgsqlTypes.NpgsqlPoint(x: 0.8713471051057274d, y: 0.49002048796796427d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6595698031701559d, y: 0.451742324642601d), new NpgsqlTypes.NpgsqlPoint(x: 0.5991979832010591d, y: 0.7755342515447784d), new NpgsqlTypes.NpgsqlPoint(x: 0.4655021537294469d, y: 0.9310419332424119d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4085813597345902d, y: 0.19521814748676847d), new NpgsqlTypes.NpgsqlPoint(x: 0.33300742784289716d, y: 0.26949246782758585d), new NpgsqlTypes.NpgsqlPoint(x: 0.34024762650347795d, y: 0.04664156503960348d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2972270813469877d, y: 0.3237775734921965d), new NpgsqlTypes.NpgsqlPoint(x: 0.002967947998197662d, y: 0.02895192626607157d), new NpgsqlTypes.NpgsqlPoint(x: 0.7484287285551514d, y: 0.3573065578725869d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40772942782031696d, y: 0.2254083795951063d), new NpgsqlTypes.NpgsqlPoint(x: 0.9967513887466402d, y: 0.8623748776870979d), new NpgsqlTypes.NpgsqlPoint(x: 0.580593017973745d, y: 0.7956598789176996d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2655046825259195d, y: 0.978501415273029d), new NpgsqlTypes.NpgsqlPoint(x: 0.947352559386241d, y: 0.4025174936715167d), new NpgsqlTypes.NpgsqlPoint(x: 0.6349834368245469d, y: 0.4958635225752781d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11365105933306052d, y: 0.09453511627513844d), new NpgsqlTypes.NpgsqlPoint(x: 0.41776946257503966d, y: 0.5978038638647206d), new NpgsqlTypes.NpgsqlPoint(x: 0.5061154701560897d, y: 0.6973148476497616d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21713908830610928d, y: 0.8955830768898186d), new NpgsqlTypes.NpgsqlPoint(x: 0.496222944636713d, y: 0.6672210504682965d), new NpgsqlTypes.NpgsqlPoint(x: 0.8516578957226202d, y: 0.10751849684783132d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37033261962247443d, y: 0.5924811766683361d), new NpgsqlTypes.NpgsqlPoint(x: 0.2868839848987924d, y: 0.6878737326731388d), new NpgsqlTypes.NpgsqlPoint(x: 0.2257718129679649d, y: 0.24977440154819053d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5095394460874765d, y: 0.5885820541369523d), new NpgsqlTypes.NpgsqlPoint(x: 0.3848214893294829d, y: 0.5656767850079196d), new NpgsqlTypes.NpgsqlPoint(x: 0.19060724212736857d, y: 0.7582664550206235d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7010404657554654d, y: 0.934388130461252d), new NpgsqlTypes.NpgsqlPoint(x: 0.17185432665234845d, y: 0.3858375150547746d), new NpgsqlTypes.NpgsqlPoint(x: 0.1307389585610973d, y: 0.8811073445230511d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04053143868703779d, y: 0.5617553610920349d), new NpgsqlTypes.NpgsqlPoint(x: 0.762201777769294d, y: 0.5102319353370255d), new NpgsqlTypes.NpgsqlPoint(x: 0.43765164393541534d, y: 0.604358832064802d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5500817177003383d, y: 0.4075229754914593d), new NpgsqlTypes.NpgsqlPoint(x: 0.39156879961298674d, y: 0.8354107557180059d), new NpgsqlTypes.NpgsqlPoint(x: 0.09412444591130387d, y: 0.4049968868259938d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3212539493348091d, y: 0.17214081436781048d), new NpgsqlTypes.NpgsqlPoint(x: 0.9658495348439097d, y: 0.8768348287070834d), new NpgsqlTypes.NpgsqlPoint(x: 0.2032639756853879d, y: 0.24122431806532196d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06828906053326711d, y: 0.3476440204407031d), new NpgsqlTypes.NpgsqlPoint(x: 0.7069446027926326d, y: 0.829444823775439d), new NpgsqlTypes.NpgsqlPoint(x: 0.10053712176496277d, y: 0.38238867562598233d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6102633554556195d, y: 0.8328922473027328d), new NpgsqlTypes.NpgsqlPoint(x: 0.6146811193387527d, y: 0.6556338980362266d), new NpgsqlTypes.NpgsqlPoint(x: 0.9104092596319745d, y: 0.00023210145925578463d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5303800194395201d, y: 0.7481658850309638d), new NpgsqlTypes.NpgsqlPoint(x: 0.20331423322911046d, y: 0.022252493972624965d), new NpgsqlTypes.NpgsqlPoint(x: 0.43120903206530903d, y: 0.5813405752456067d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.782416643649706d, y: 0.6956119028359082d), new NpgsqlTypes.NpgsqlPoint(x: 0.34301765021223063d, y: 0.24589017386097078d), new NpgsqlTypes.NpgsqlPoint(x: 0.21034542441195647d, y: 0.31992216113258076d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38389511989409d, y: 0.2118297831759176d), new NpgsqlTypes.NpgsqlPoint(x: 0.344436368992872d, y: 0.369872313653683d), new NpgsqlTypes.NpgsqlPoint(x: 0.1091930638347628d, y: 0.4083272711525542d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46971402961482867d, y: 0.392717652991626d), new NpgsqlTypes.NpgsqlPoint(x: 0.8918944861226366d, y: 0.5101010509147957d), new NpgsqlTypes.NpgsqlPoint(x: 0.41345983425829236d, y: 0.23337860461013948d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3171470869854168d, y: 0.9986077600964972d), new NpgsqlTypes.NpgsqlPoint(x: 0.4667493562451902d, y: 0.3277251958266696d), new NpgsqlTypes.NpgsqlPoint(x: 0.021633761816586827d, y: 0.41045942483345843d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2253376782847074d, y: 0.7000790631920843d), new NpgsqlTypes.NpgsqlPoint(x: 0.3681335460164803d, y: 0.9219624604495134d), new NpgsqlTypes.NpgsqlPoint(x: 0.23634313923545025d, y: 0.19957574667307787d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8814090946781902d, y: 0.43393497585516105d), new NpgsqlTypes.NpgsqlPoint(x: 0.9591738361998714d, y: 0.32472830663619745d), new NpgsqlTypes.NpgsqlPoint(x: 0.22691127606170125d, y: 0.8448191125619564d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06001900286684758d, y: 0.16272193564853388d), new NpgsqlTypes.NpgsqlPoint(x: 0.4831453003854712d, y: 0.7678747029246066d), new NpgsqlTypes.NpgsqlPoint(x: 0.9055775718988504d, y: 0.392225292143215d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2597770758121968d, y: 0.5612913628662523d), new NpgsqlTypes.NpgsqlPoint(x: 0.9039608883281554d, y: 0.08259984704070256d), new NpgsqlTypes.NpgsqlPoint(x: 0.31898233563442624d, y: 0.2547956709842617d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11696839275657d, y: 0.6214465004481989d), new NpgsqlTypes.NpgsqlPoint(x: 0.673094862205437d, y: 0.5017238604637243d), new NpgsqlTypes.NpgsqlPoint(x: 0.3801175022070289d, y: 0.5402482495033514d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9793273771220673d, y: 0.0373897397829388d), new NpgsqlTypes.NpgsqlPoint(x: 0.18287069564435376d, y: 0.6751569025136943d), new NpgsqlTypes.NpgsqlPoint(x: 0.11807187936451902d, y: 0.7245749361901492d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.043167724764550774d, y: 0.4267255671366684d), new NpgsqlTypes.NpgsqlPoint(x: 0.2212379896017873d, y: 0.26758029493232127d), new NpgsqlTypes.NpgsqlPoint(x: 0.13313973151790892d, y: 0.585798898175373d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8763435734554196d, y: 0.9296671000374482d), new NpgsqlTypes.NpgsqlPoint(x: 0.19123943693626033d, y: 0.39105090004917276d), new NpgsqlTypes.NpgsqlPoint(x: 0.8818150704988422d, y: 0.4547433407454705d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4875781128739566d, y: 0.5396363547763018d), new NpgsqlTypes.NpgsqlPoint(x: 0.2386167758105665d, y: 0.02856538825847732d), new NpgsqlTypes.NpgsqlPoint(x: 0.04987686503444233d, y: 0.6000988391573081d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21769613876468397d, y: 0.931205779322837d), new NpgsqlTypes.NpgsqlPoint(x: 0.7958023710636678d, y: 0.27307639079511337d), new NpgsqlTypes.NpgsqlPoint(x: 0.3422476885752469d, y: 0.59067249991802d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0024996041813850622d, y: 0.34165426974233815d), new NpgsqlTypes.NpgsqlPoint(x: 0.7523199522296179d, y: 0.14258842019247342d), new NpgsqlTypes.NpgsqlPoint(x: 0.25466056472095666d, y: 0.5059226695758994d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0523539080992006d, y: 0.8492067320062054d), new NpgsqlTypes.NpgsqlPoint(x: 0.7610114146076138d, y: 0.09971427711640224d), new NpgsqlTypes.NpgsqlPoint(x: 0.26272325689139675d, y: 0.00397415398158385d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3023064320555079d, y: 0.29267067988972906d), new NpgsqlTypes.NpgsqlPoint(x: 0.43310423522252706d, y: 0.236057198517586d), new NpgsqlTypes.NpgsqlPoint(x: 0.8119604712309618d, y: 0.6776424077440343d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8630578800603255d, y: 0.7612617796775105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5299993950694616d, y: 0.6751972373120031d), new NpgsqlTypes.NpgsqlPoint(x: 0.5035761215641101d, y: 0.27476391770539355d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9526428565557881d, y: 0.8003424528109886d), new NpgsqlTypes.NpgsqlPoint(x: 0.17619839357987566d, y: 0.16673283943324668d), new NpgsqlTypes.NpgsqlPoint(x: 0.5297064896758065d, y: 0.6423174432895683d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9793846290937086d, y: 0.2557247892339426d), new NpgsqlTypes.NpgsqlPoint(x: 0.011045809549683483d, y: 0.6448184214642835d), new NpgsqlTypes.NpgsqlPoint(x: 0.9304578845894722d, y: 0.26069718809642106d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9797242608281767d, y: 0.11147915913177797d), new NpgsqlTypes.NpgsqlPoint(x: 0.016915578544317467d, y: 0.39688396439431284d), new NpgsqlTypes.NpgsqlPoint(x: 0.003229928357655787d, y: 0.08156554228938884d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4059043195984371d, y: 0.32645802197291296d), new NpgsqlTypes.NpgsqlPoint(x: 0.31294877303800406d, y: 0.6681130887472272d), new NpgsqlTypes.NpgsqlPoint(x: 0.9376348319838322d, y: 0.3716535824073077d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20446131406894663d, y: 0.18986358237044487d), new NpgsqlTypes.NpgsqlPoint(x: 0.15533750370195698d, y: 0.7538895383712221d), new NpgsqlTypes.NpgsqlPoint(x: 0.7041360944665132d, y: 0.526247378496938d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9531881488171715d, y: 0.37608629309046315d), new NpgsqlTypes.NpgsqlPoint(x: 0.16241461827401804d, y: 0.815732122253579d), new NpgsqlTypes.NpgsqlPoint(x: 0.27191910629788074d, y: 0.9707644528863519d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8426667829520534d, y: 0.4448582406807112d), new NpgsqlTypes.NpgsqlPoint(x: 0.74399812872434d, y: 0.772836733866761d), new NpgsqlTypes.NpgsqlPoint(x: 0.243776251053907d, y: 0.35081947901262855d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4755586667649895d, y: 0.5795935271564817d), new NpgsqlTypes.NpgsqlPoint(x: 0.8198516740528784d, y: 0.10140272977857734d), new NpgsqlTypes.NpgsqlPoint(x: 0.8185329680928874d, y: 0.23464363383431674d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.432642390729821d, y: 0.5246614900718413d), new NpgsqlTypes.NpgsqlPoint(x: 0.45058761190884666d, y: 0.9771091940425177d), new NpgsqlTypes.NpgsqlPoint(x: 0.5195778835467718d, y: 0.344526165463903d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1057566544831059d, y: 0.5289211049107634d), new NpgsqlTypes.NpgsqlPoint(x: 0.05701251731620127d, y: 0.2349318427572883d), new NpgsqlTypes.NpgsqlPoint(x: 0.5174639894798213d, y: 0.9562799093412052d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15183210345873954d, y: 0.588235625204929d), new NpgsqlTypes.NpgsqlPoint(x: 0.42060993469209884d, y: 0.6583970251849048d), new NpgsqlTypes.NpgsqlPoint(x: 0.25000415367788253d, y: 0.9089390650525223d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4738642849712247d, y: 0.5408105441906608d), new NpgsqlTypes.NpgsqlPoint(x: 0.1597311073032608d, y: 0.803302710628201d), new NpgsqlTypes.NpgsqlPoint(x: 0.5753662871277933d, y: 0.8002267547807673d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6130193678225678d, y: 0.2193865495374263d), new NpgsqlTypes.NpgsqlPoint(x: 0.2159902517766369d, y: 0.7501966325850478d), new NpgsqlTypes.NpgsqlPoint(x: 0.4916941330272302d, y: 0.28782188024976474d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2047594508083802d, y: 0.7787484886764308d), new NpgsqlTypes.NpgsqlPoint(x: 0.5907215109231881d, y: 0.3573052388907074d), new NpgsqlTypes.NpgsqlPoint(x: 0.1258306964154854d, y: 0.119259282180458d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1300482921728906d, y: 0.10955061503260055d), new NpgsqlTypes.NpgsqlPoint(x: 0.35410683273369914d, y: 0.011403554906449842d), new NpgsqlTypes.NpgsqlPoint(x: 0.1520614154144021d, y: 0.39225040532869027d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4634340237428659d, y: 0.7443053417117006d), new NpgsqlTypes.NpgsqlPoint(x: 0.11139017213696323d, y: 0.26221532512832135d), new NpgsqlTypes.NpgsqlPoint(x: 0.01348752726706437d, y: 0.9257116877715311d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8616063793977197d, y: 0.44127762425370365d), new NpgsqlTypes.NpgsqlPoint(x: 0.12678043733557443d, y: 0.12999170410886385d), new NpgsqlTypes.NpgsqlPoint(x: 0.8917894751714567d, y: 0.6471242250310475d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41989389106603237d, y: 0.004010190835522565d), new NpgsqlTypes.NpgsqlPoint(x: 0.13817308711170306d, y: 0.42494199320853654d), new NpgsqlTypes.NpgsqlPoint(x: 0.8071588814228251d, y: 0.8186214893221672d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3326450277391134d, y: 0.6459901995513089d), new NpgsqlTypes.NpgsqlPoint(x: 0.06386921794851064d, y: 0.5197035164883259d), new NpgsqlTypes.NpgsqlPoint(x: 0.6923675970430341d, y: 0.42069549063743916d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09329704043289755d, y: 0.7505824583527922d), new NpgsqlTypes.NpgsqlPoint(x: 0.4019668601198375d, y: 0.2795908131848217d), new NpgsqlTypes.NpgsqlPoint(x: 0.9235513665097588d, y: 0.6161774128918861d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21250239995345288d, y: 0.5580932341273478d), new NpgsqlTypes.NpgsqlPoint(x: 0.7204280376862258d, y: 0.3504144299339371d), new NpgsqlTypes.NpgsqlPoint(x: 0.6380484005537219d, y: 0.8152877069788292d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9828899849239427d, y: 0.0929350651555193d), new NpgsqlTypes.NpgsqlPoint(x: 0.7274458220266076d, y: 0.08812595506066134d), new NpgsqlTypes.NpgsqlPoint(x: 0.6761824793607114d, y: 0.772130492300273d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6814259696954182d, y: 0.1301637306345096d), new NpgsqlTypes.NpgsqlPoint(x: 0.19305854460380611d, y: 0.38915567089921166d), new NpgsqlTypes.NpgsqlPoint(x: 0.4237990134730162d, y: 0.3812481675259317d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35894666635705574d, y: 0.819019812736185d), new NpgsqlTypes.NpgsqlPoint(x: 0.9608513789467876d, y: 0.25186540478174646d), new NpgsqlTypes.NpgsqlPoint(x: 0.9354919244372375d, y: 0.5283124326044956d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3841684223866255d, y: 0.888457294069091d), new NpgsqlTypes.NpgsqlPoint(x: 0.2723166221663542d, y: 0.5281045292275028d), new NpgsqlTypes.NpgsqlPoint(x: 0.1450790525494532d, y: 0.7486957638686474d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15069939266034604d, y: 0.8130950890366498d), new NpgsqlTypes.NpgsqlPoint(x: 0.9518882826389661d, y: 0.4240371335510569d), new NpgsqlTypes.NpgsqlPoint(x: 0.862148459890529d, y: 0.029244286366534533d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5321929518200125d, y: 0.5396273753143421d), new NpgsqlTypes.NpgsqlPoint(x: 0.018531466360244053d, y: 0.9035379788916679d), new NpgsqlTypes.NpgsqlPoint(x: 0.1737836721277929d, y: 0.3323160721448496d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8913745972858492d, y: 0.8050268356330432d), new NpgsqlTypes.NpgsqlPoint(x: 0.005754543322117001d, y: 0.6687901390810822d), new NpgsqlTypes.NpgsqlPoint(x: 0.9603633862120715d, y: 0.39200081598495495d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8526024782909615d, y: 0.16732305768687317d), new NpgsqlTypes.NpgsqlPoint(x: 0.7691913875619995d, y: 0.9712959718600964d), new NpgsqlTypes.NpgsqlPoint(x: 0.9914582010013898d, y: 0.19922787836923617d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5358457760890261d, y: 0.5807700534356246d), new NpgsqlTypes.NpgsqlPoint(x: 0.8729552034029032d, y: 0.1572641789102972d), new NpgsqlTypes.NpgsqlPoint(x: 0.16353983391155857d, y: 0.0773599528738842d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3110260593426234d, y: 0.6726469622159561d), new NpgsqlTypes.NpgsqlPoint(x: 0.04623031634585839d, y: 0.1807280836933467d), new NpgsqlTypes.NpgsqlPoint(x: 0.4259868521408233d, y: 0.5353246792891895d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8011045820882903d, y: 0.6502809552049015d), new NpgsqlTypes.NpgsqlPoint(x: 0.7829841546711972d, y: 0.10083013534235086d), new NpgsqlTypes.NpgsqlPoint(x: 0.17805431832818852d, y: 0.554354105715807d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10914642345707493d, y: 0.8956240548660528d), new NpgsqlTypes.NpgsqlPoint(x: 0.3947414192139327d, y: 0.8753636920230462d), new NpgsqlTypes.NpgsqlPoint(x: 0.6640470151306411d, y: 0.06376240970880909d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4009623634275684d, y: 0.38828445477958073d), new NpgsqlTypes.NpgsqlPoint(x: 0.532633153894018d, y: 0.4566089355983055d), new NpgsqlTypes.NpgsqlPoint(x: 0.3401227062333756d, y: 0.5951936648431013d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8281335859378248d, y: 0.5464931464164899d), new NpgsqlTypes.NpgsqlPoint(x: 0.8251673961577805d, y: 0.8734116533720968d), new NpgsqlTypes.NpgsqlPoint(x: 0.2647788997711342d, y: 0.8475218861675098d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04652467853664055d, y: 0.05730413172279025d), new NpgsqlTypes.NpgsqlPoint(x: 0.4200575754826923d, y: 0.3115075771409854d), new NpgsqlTypes.NpgsqlPoint(x: 0.17361155113156668d, y: 0.751780320729573d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7087154105450598d, y: 0.4962883190861723d), new NpgsqlTypes.NpgsqlPoint(x: 0.3477479153785743d, y: 0.27641007435497067d), new NpgsqlTypes.NpgsqlPoint(x: 0.8759880586836923d, y: 0.44860830903978566d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9484032664539612d, y: 0.7131678794860936d), new NpgsqlTypes.NpgsqlPoint(x: 0.3405287603752337d, y: 0.907853856629182d), new NpgsqlTypes.NpgsqlPoint(x: 0.17483815509460277d, y: 0.7789664645208808d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7741067455292409d, y: 0.6973387221326917d), new NpgsqlTypes.NpgsqlPoint(x: 0.064742554745288d, y: 0.9491949852252174d), new NpgsqlTypes.NpgsqlPoint(x: 0.3610742745080845d, y: 0.37545247744203925d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5450094450510761d, y: 0.834920487642205d), new NpgsqlTypes.NpgsqlPoint(x: 0.07044416277977972d, y: 0.40306695894469324d), new NpgsqlTypes.NpgsqlPoint(x: 0.42066340884230946d, y: 0.6607491668275965d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.489513688257597d, y: 0.9359067769629063d), new NpgsqlTypes.NpgsqlPoint(x: 0.5332907301241123d, y: 0.504592577655321d), new NpgsqlTypes.NpgsqlPoint(x: 0.16950431089828077d, y: 0.8464453752390432d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16090887468274329d, y: 0.49865512675963897d), new NpgsqlTypes.NpgsqlPoint(x: 0.3447852098509181d, y: 0.3753017680027586d), new NpgsqlTypes.NpgsqlPoint(x: 0.8089440195634268d, y: 0.45208297588356183d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8069936820581189d, y: 0.363062536750157d), new NpgsqlTypes.NpgsqlPoint(x: 0.27187684985036054d, y: 0.7182379020441996d), new NpgsqlTypes.NpgsqlPoint(x: 0.26651425606714585d, y: 0.3947297488087661d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13415281010906854d, y: 0.3490652681485331d), new NpgsqlTypes.NpgsqlPoint(x: 0.6363051850806423d, y: 0.04013631367128534d), new NpgsqlTypes.NpgsqlPoint(x: 0.7741933930014453d, y: 0.47130104104121784d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7016578707045164d, y: 0.8739609233110187d), new NpgsqlTypes.NpgsqlPoint(x: 0.810028307575861d, y: 0.2628483122571671d), new NpgsqlTypes.NpgsqlPoint(x: 0.3839376040231508d, y: 0.3725146577195363d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9200998063564491d, y: 0.6710127241675684d), new NpgsqlTypes.NpgsqlPoint(x: 0.1167007333422675d, y: 0.06129002578361076d), new NpgsqlTypes.NpgsqlPoint(x: 0.4636724142393336d, y: 0.6284273963737661d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006711694010077207d, y: 0.9462672333457492d), new NpgsqlTypes.NpgsqlPoint(x: 0.7468717938785625d, y: 0.19158909022089587d), new NpgsqlTypes.NpgsqlPoint(x: 0.5649317198889594d, y: 0.3469405348990382d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3731243634033852d, y: 0.9239777692123785d), new NpgsqlTypes.NpgsqlPoint(x: 0.2761711013542606d, y: 0.9578913753719941d), new NpgsqlTypes.NpgsqlPoint(x: 0.38645678192047583d, y: 0.6554548274574736d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013826668446174972d, y: 0.5866487893701677d), new NpgsqlTypes.NpgsqlPoint(x: 0.679189032977392d, y: 0.8158486145455627d), new NpgsqlTypes.NpgsqlPoint(x: 0.39503733068754d, y: 0.7878968281787786d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9856501210777999d, y: 0.6975313533894927d), new NpgsqlTypes.NpgsqlPoint(x: 0.41208116653624915d, y: 0.5181627507034071d), new NpgsqlTypes.NpgsqlPoint(x: 0.5586013770868081d, y: 0.6390273497719516d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8187139761439811d, y: 0.6639513388408594d), new NpgsqlTypes.NpgsqlPoint(x: 0.8615824461969084d, y: 0.5042559735135617d), new NpgsqlTypes.NpgsqlPoint(x: 0.7533493022787578d, y: 0.2819800581031846d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2449764166579138d, y: 0.49399061819307866d), new NpgsqlTypes.NpgsqlPoint(x: 0.3651233550759885d, y: 0.7323123388029997d), new NpgsqlTypes.NpgsqlPoint(x: 0.11849705677610056d, y: 0.3605272737034181d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39151475648973344d, y: 0.9856225811129499d), new NpgsqlTypes.NpgsqlPoint(x: 0.6105162449583573d, y: 0.6096806444000292d), new NpgsqlTypes.NpgsqlPoint(x: 0.26415130817564625d, y: 0.8669759592756544d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9507660393512205d, y: 0.9110805729292587d), new NpgsqlTypes.NpgsqlPoint(x: 0.1518121497766466d, y: 0.9098781841178817d), new NpgsqlTypes.NpgsqlPoint(x: 0.3455886983765133d, y: 0.45036449138723d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34226953699988305d, y: 0.5794021483620131d), new NpgsqlTypes.NpgsqlPoint(x: 0.2934480573576438d, y: 0.1245289097044161d), new NpgsqlTypes.NpgsqlPoint(x: 0.5338087689701969d, y: 0.0036412052917275117d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.772105902637698d, y: 0.449022812693059d), new NpgsqlTypes.NpgsqlPoint(x: 0.9642389374434412d, y: 0.2715205189305092d), new NpgsqlTypes.NpgsqlPoint(x: 0.17381944576759523d, y: 0.20722616076420053d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6144559426323811d, y: 0.885038278326893d), new NpgsqlTypes.NpgsqlPoint(x: 0.49038066864189744d, y: 0.562230727313969d), new NpgsqlTypes.NpgsqlPoint(x: 0.8104057077566055d, y: 0.05159848002044842d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3978700445430622d, y: 0.15023137504175377d), new NpgsqlTypes.NpgsqlPoint(x: 0.25903993810526615d, y: 0.06844027801613106d), new NpgsqlTypes.NpgsqlPoint(x: 0.2649130716110697d, y: 0.6353050551577122d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5877017132433666d, y: 0.14445661185935077d), new NpgsqlTypes.NpgsqlPoint(x: 0.14748748120870891d, y: 0.7021483477972275d), new NpgsqlTypes.NpgsqlPoint(x: 0.21142041747779572d, y: 0.31914052965964623d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5718318633275484d, y: 0.2484586587282429d), new NpgsqlTypes.NpgsqlPoint(x: 0.6880401121559654d, y: 0.8673857541804594d), new NpgsqlTypes.NpgsqlPoint(x: 0.075650628087229d, y: 0.5129276305789312d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05870805904637466d, y: 0.4374184482541871d), new NpgsqlTypes.NpgsqlPoint(x: 0.15145520279748403d, y: 0.48941603936260225d), new NpgsqlTypes.NpgsqlPoint(x: 0.8911739289296543d, y: 0.6021306798877564d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6222474133687698d, y: 0.027532144259751146d), new NpgsqlTypes.NpgsqlPoint(x: 0.6145165987176378d, y: 0.12102318667473977d), new NpgsqlTypes.NpgsqlPoint(x: 0.5133429326005752d, y: 0.7522787865973664d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36791655477175866d, y: 0.2659792634387791d), new NpgsqlTypes.NpgsqlPoint(x: 0.16957594154906297d, y: 0.00640685771122651d), new NpgsqlTypes.NpgsqlPoint(x: 0.5112469971052842d, y: 0.22726863579206968d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3339888064677592d, y: 0.31136820463263226d), new NpgsqlTypes.NpgsqlPoint(x: 0.8794701364454528d, y: 0.6726328783117225d), new NpgsqlTypes.NpgsqlPoint(x: 0.597829116483573d, y: 0.9038837279249201d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3883873107227689d, y: 0.8784549440652009d), new NpgsqlTypes.NpgsqlPoint(x: 0.837109926832989d, y: 0.9973658023290674d), new NpgsqlTypes.NpgsqlPoint(x: 0.7436406039236514d, y: 0.8243475462160142d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.464671360827422d, y: 0.07121540154046746d), new NpgsqlTypes.NpgsqlPoint(x: 0.42019195843898394d, y: 0.48898610306925483d), new NpgsqlTypes.NpgsqlPoint(x: 0.6645734154525365d, y: 0.8654090608708674d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5004957001622347d, y: 0.3664593279973175d), new NpgsqlTypes.NpgsqlPoint(x: 0.2420901755989343d, y: 0.45045636199874606d), new NpgsqlTypes.NpgsqlPoint(x: 0.6593439289333943d, y: 0.5642823141714451d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8436182610363664d, y: 0.1265755990513756d), new NpgsqlTypes.NpgsqlPoint(x: 0.32928861028446077d, y: 0.49576343410780266d), new NpgsqlTypes.NpgsqlPoint(x: 0.5586980347347535d, y: 0.14450592588959488d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6364915535367041d, y: 0.4239194307619879d), new NpgsqlTypes.NpgsqlPoint(x: 0.01017649448945357d, y: 0.6526387636095283d), new NpgsqlTypes.NpgsqlPoint(x: 0.908801199892729d, y: 0.43394451556282765d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3816250958689633d, y: 0.3188157226037338d), new NpgsqlTypes.NpgsqlPoint(x: 0.6111536409631194d, y: 0.1516686000669012d), new NpgsqlTypes.NpgsqlPoint(x: 0.13131219428031937d, y: 0.2536504853615822d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1280894322176297d, y: 0.03846365468724833d), new NpgsqlTypes.NpgsqlPoint(x: 0.6445763321002635d, y: 0.7109163752802042d), new NpgsqlTypes.NpgsqlPoint(x: 0.06226556260308369d, y: 0.2131218171121647d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22565097588036342d, y: 0.5076085548568406d), new NpgsqlTypes.NpgsqlPoint(x: 0.9375347185175991d, y: 0.9073890158577306d), new NpgsqlTypes.NpgsqlPoint(x: 0.3929007217627426d, y: 0.0700235054877163d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4398925431941485d, y: 0.48656809871223416d), new NpgsqlTypes.NpgsqlPoint(x: 0.3939470988082404d, y: 0.509197129002077d), new NpgsqlTypes.NpgsqlPoint(x: 0.19687262947646234d, y: 0.11679994889923129d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15024862661364013d, y: 0.5634713718051237d), new NpgsqlTypes.NpgsqlPoint(x: 0.31888974382021174d, y: 0.43207873088270865d), new NpgsqlTypes.NpgsqlPoint(x: 0.02048722155331162d, y: 0.5480963456221658d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.747162680736029d, y: 0.10639350818625204d), new NpgsqlTypes.NpgsqlPoint(x: 0.8098225853712682d, y: 0.9890589208066165d), new NpgsqlTypes.NpgsqlPoint(x: 0.30782361080042897d, y: 0.9629266345569876d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21186960291411505d, y: 0.04323463568799579d), new NpgsqlTypes.NpgsqlPoint(x: 0.07043148213388639d, y: 0.20161390553148684d), new NpgsqlTypes.NpgsqlPoint(x: 0.5485071041346269d, y: 0.8596550803381686d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10046981120180831d, y: 0.9492824472954635d), new NpgsqlTypes.NpgsqlPoint(x: 0.48971100725696404d, y: 0.9874468142984719d), new NpgsqlTypes.NpgsqlPoint(x: 0.9747997845191614d, y: 0.5506868643197183d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8945737781169005d, y: 0.7061544962737656d), new NpgsqlTypes.NpgsqlPoint(x: 0.8548837826359185d, y: 0.7292874420700932d), new NpgsqlTypes.NpgsqlPoint(x: 0.16841708404153832d, y: 0.9685152166414247d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9164948820292903d, y: 0.7862932300605298d), new NpgsqlTypes.NpgsqlPoint(x: 0.2850177985251503d, y: 0.44448215049421813d), new NpgsqlTypes.NpgsqlPoint(x: 0.2221301218053361d, y: 0.5659563755291184d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08484549145353915d, y: 0.17764473268472736d), new NpgsqlTypes.NpgsqlPoint(x: 0.9355310281100095d, y: 0.13622487883728973d), new NpgsqlTypes.NpgsqlPoint(x: 0.9348449595421264d, y: 0.8036518258487998d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.017938286535954084d, y: 0.23193622781908718d), new NpgsqlTypes.NpgsqlPoint(x: 0.856311225500877d, y: 0.7141339854925682d), new NpgsqlTypes.NpgsqlPoint(x: 0.8184762332663937d, y: 0.7874739185457001d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5098220723905419d, y: 0.08624274178213898d), new NpgsqlTypes.NpgsqlPoint(x: 0.5987252896319419d, y: 0.5683395938665715d), new NpgsqlTypes.NpgsqlPoint(x: 0.04399134183577158d, y: 0.10606425527053276d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9053679489149635d, y: 0.2260873007617923d), new NpgsqlTypes.NpgsqlPoint(x: 0.9240501025450333d, y: 0.9556659467159417d), new NpgsqlTypes.NpgsqlPoint(x: 0.5262350775274981d, y: 0.12391394453021465d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.480892878707057d, y: 0.7520606739866716d), new NpgsqlTypes.NpgsqlPoint(x: 0.31791538482117565d, y: 0.5847193764095076d), new NpgsqlTypes.NpgsqlPoint(x: 0.8091198836064165d, y: 0.44696785539881123d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5338855740150529d, y: 0.6386972520055193d), new NpgsqlTypes.NpgsqlPoint(x: 0.8822437723625713d, y: 0.7349592615023177d), new NpgsqlTypes.NpgsqlPoint(x: 0.32932447391881203d, y: 0.7043524458461164d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37743455182645747d, y: 0.4855833146470946d), new NpgsqlTypes.NpgsqlPoint(x: 0.4953015897576347d, y: 0.2267849400408366d), new NpgsqlTypes.NpgsqlPoint(x: 0.0567747060174294d, y: 0.17951859013562255d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.82736438304258d, y: 0.4296376613618197d), new NpgsqlTypes.NpgsqlPoint(x: 0.7832604785709916d, y: 0.3641661597078598d), new NpgsqlTypes.NpgsqlPoint(x: 0.8384595403278112d, y: 0.27537315017435227d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23171403977451366d, y: 0.8941360306812854d), new NpgsqlTypes.NpgsqlPoint(x: 0.07753130803469466d, y: 0.3669790449354302d), new NpgsqlTypes.NpgsqlPoint(x: 0.7318364903841134d, y: 0.844495079671919d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.367167997428843d, y: 0.07078553317525138d), new NpgsqlTypes.NpgsqlPoint(x: 0.16504184204842265d, y: 0.11819033282527147d), new NpgsqlTypes.NpgsqlPoint(x: 0.5922696035751959d, y: 0.10316088908249266d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.713774955821177d, y: 0.2504840311761356d), new NpgsqlTypes.NpgsqlPoint(x: 0.4757949974642409d, y: 0.8930232038821133d), new NpgsqlTypes.NpgsqlPoint(x: 0.7667832813139003d, y: 0.08011646085053281d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7663746711718065d, y: 0.4467578022245454d), new NpgsqlTypes.NpgsqlPoint(x: 0.9943999390471978d, y: 0.8937974364978527d), new NpgsqlTypes.NpgsqlPoint(x: 0.6926321897022908d, y: 0.38005995205873655d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45976072799896883d, y: 0.9722361999613361d), new NpgsqlTypes.NpgsqlPoint(x: 0.013873886492488219d, y: 0.12938621481563806d), new NpgsqlTypes.NpgsqlPoint(x: 0.333264290882772d, y: 0.6774787275950174d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16966218367787222d, y: 0.7836839894445672d), new NpgsqlTypes.NpgsqlPoint(x: 0.011693444803232755d, y: 0.9567950523619101d), new NpgsqlTypes.NpgsqlPoint(x: 0.7378144290060024d, y: 0.16567189274512795d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2738404195959232d, y: 0.05172682494464653d), new NpgsqlTypes.NpgsqlPoint(x: 0.7080310807261243d, y: 0.6165146618427291d), new NpgsqlTypes.NpgsqlPoint(x: 0.49483189058866406d, y: 0.3062576964817739d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32468481877119115d, y: 0.5913220926268665d), new NpgsqlTypes.NpgsqlPoint(x: 0.5717427756537197d, y: 0.68403755054967d), new NpgsqlTypes.NpgsqlPoint(x: 0.1937320320480831d, y: 0.3644839885877762d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9378517249050276d, y: 0.6697024035115379d), new NpgsqlTypes.NpgsqlPoint(x: 0.023030379241868904d, y: 0.6291741822354884d), new NpgsqlTypes.NpgsqlPoint(x: 0.608249659287337d, y: 0.44202886223072524d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08144991469264151d, y: 0.9068457262781715d), new NpgsqlTypes.NpgsqlPoint(x: 0.77879799795231d, y: 0.3406689839241712d), new NpgsqlTypes.NpgsqlPoint(x: 0.4281764307286853d, y: 0.20003215740236246d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47099003965635167d, y: 0.8694004245321024d), new NpgsqlTypes.NpgsqlPoint(x: 0.3864682760437663d, y: 0.5468636017261925d), new NpgsqlTypes.NpgsqlPoint(x: 0.722537826340906d, y: 0.2056439574655725d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42469070450569435d, y: 0.7458073780175555d), new NpgsqlTypes.NpgsqlPoint(x: 0.7781236273341218d, y: 0.6758903327991023d), new NpgsqlTypes.NpgsqlPoint(x: 0.5881230905028426d, y: 0.3167470325974264d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.060607539684523704d, y: 0.42339317931383724d), new NpgsqlTypes.NpgsqlPoint(x: 0.07392449323469918d, y: 0.8518334506392283d), new NpgsqlTypes.NpgsqlPoint(x: 0.9699639189134814d, y: 0.8614803667891988d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6353309764908917d, y: 0.14150123683305005d), new NpgsqlTypes.NpgsqlPoint(x: 0.37992415852774575d, y: 0.5361454795111136d), new NpgsqlTypes.NpgsqlPoint(x: 0.4581547151778912d, y: 0.9778449086214639d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.447027524311696d, y: 0.470908117246181d), new NpgsqlTypes.NpgsqlPoint(x: 0.5415200601810183d, y: 0.2243015469133003d), new NpgsqlTypes.NpgsqlPoint(x: 0.16445424078343662d, y: 0.6964962583361501d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8350891650875992d, y: 0.3516891864627446d), new NpgsqlTypes.NpgsqlPoint(x: 0.8769730453065281d, y: 0.7399120234514176d), new NpgsqlTypes.NpgsqlPoint(x: 0.5154551843709638d, y: 0.33508210364961777d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.633519235673355d, y: 0.27217045175859644d), new NpgsqlTypes.NpgsqlPoint(x: 0.10859647223686753d, y: 0.3622978788221456d), new NpgsqlTypes.NpgsqlPoint(x: 0.6343524630002121d, y: 0.4650176773491286d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8112633999182236d, y: 0.34563808462775036d), new NpgsqlTypes.NpgsqlPoint(x: 0.8562877097255331d, y: 0.8854333987862418d), new NpgsqlTypes.NpgsqlPoint(x: 0.8421183154888829d, y: 0.9458815981732795d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7607240724320897d, y: 0.3656725654345079d), new NpgsqlTypes.NpgsqlPoint(x: 0.09715793186763944d, y: 0.3206957385065613d), new NpgsqlTypes.NpgsqlPoint(x: 0.9502366785039694d, y: 0.5109656486879183d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7875477287747132d, y: 0.25440753058901466d), new NpgsqlTypes.NpgsqlPoint(x: 0.6187261432520214d, y: 0.19454026640322797d), new NpgsqlTypes.NpgsqlPoint(x: 0.2249982077100129d, y: 0.546577817937575d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17882043726304853d, y: 0.2795125130789211d), new NpgsqlTypes.NpgsqlPoint(x: 0.6680835182739255d, y: 0.3463951556153001d), new NpgsqlTypes.NpgsqlPoint(x: 0.36685808942017906d, y: 0.6635687745183324d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49153426446848947d, y: 0.2726256707860988d), new NpgsqlTypes.NpgsqlPoint(x: 0.8107159568626077d, y: 0.35800447859620865d), new NpgsqlTypes.NpgsqlPoint(x: 0.5187314961867173d, y: 0.9630501223848243d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23870487292770382d, y: 0.9633092000903499d), new NpgsqlTypes.NpgsqlPoint(x: 0.5815301952086275d, y: 0.25431330026062104d), new NpgsqlTypes.NpgsqlPoint(x: 0.9111716357498024d, y: 0.6296250569685855d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8532192594437702d, y: 0.6767763350852659d), new NpgsqlTypes.NpgsqlPoint(x: 0.7335470440540801d, y: 0.0026548291202366237d), new NpgsqlTypes.NpgsqlPoint(x: 0.17485726364664655d, y: 0.9089784855562457d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4506629814322549d, y: 0.08672129853463639d), new NpgsqlTypes.NpgsqlPoint(x: 0.13774591191397412d, y: 0.5326966794070748d), new NpgsqlTypes.NpgsqlPoint(x: 0.095744022612272d, y: 0.48648357279063126d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6483067855277332d, y: 0.1904439729147137d), new NpgsqlTypes.NpgsqlPoint(x: 0.9962667153951028d, y: 0.09511948127085512d), new NpgsqlTypes.NpgsqlPoint(x: 0.527874542253355d, y: 0.20339469309800418d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06746226667792499d, y: 0.4512878549860343d), new NpgsqlTypes.NpgsqlPoint(x: 0.12290975148025451d, y: 0.659471391894272d), new NpgsqlTypes.NpgsqlPoint(x: 0.08261218784917512d, y: 0.8860443536660911d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8131641811865526d, y: 0.16203353531010622d), new NpgsqlTypes.NpgsqlPoint(x: 0.6544607858320518d, y: 0.33955879670184896d), new NpgsqlTypes.NpgsqlPoint(x: 0.4131745855452418d, y: 0.20953814513077607d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7258672035409456d, y: 0.37729021633630844d), new NpgsqlTypes.NpgsqlPoint(x: 0.0681917523992841d, y: 0.46349942246319653d), new NpgsqlTypes.NpgsqlPoint(x: 0.778996197642051d, y: 0.24531734704452024d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.053055709460063105d, y: 0.3988468798949524d), new NpgsqlTypes.NpgsqlPoint(x: 0.673291100389949d, y: 0.12761957244678013d), new NpgsqlTypes.NpgsqlPoint(x: 0.8156060574061929d, y: 0.30724173070988825d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.880152624617231d, y: 0.2972560598138668d), new NpgsqlTypes.NpgsqlPoint(x: 0.47606567645509057d, y: 0.6098479480300019d), new NpgsqlTypes.NpgsqlPoint(x: 0.2357722418667315d, y: 0.07774555430827546d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8375309699051102d, y: 0.45787405770012224d), new NpgsqlTypes.NpgsqlPoint(x: 0.005452009453737805d, y: 0.6440993666125086d), new NpgsqlTypes.NpgsqlPoint(x: 0.6715890813783622d, y: 0.7396653475442037d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04812333886883324d, y: 0.13309694739618716d), new NpgsqlTypes.NpgsqlPoint(x: 0.822240635547737d, y: 0.647590078040621d), new NpgsqlTypes.NpgsqlPoint(x: 0.7127901846981639d, y: 0.42685795481749933d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6680280898737918d, y: 0.9525966353648981d), new NpgsqlTypes.NpgsqlPoint(x: 0.4022354147464343d, y: 0.1554936812524137d), new NpgsqlTypes.NpgsqlPoint(x: 0.6912243697566333d, y: 0.7605226079459386d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6951566879099843d, y: 0.6641414818280296d), new NpgsqlTypes.NpgsqlPoint(x: 0.43362481178393775d, y: 0.2291513313802308d), new NpgsqlTypes.NpgsqlPoint(x: 0.5140296013235991d, y: 0.9951179335223262d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7016033033955231d, y: 0.8091293263095706d), new NpgsqlTypes.NpgsqlPoint(x: 0.4738240163998968d, y: 0.22375677309882092d), new NpgsqlTypes.NpgsqlPoint(x: 0.3730401882565417d, y: 0.39675901065319363d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18350147513393755d, y: 0.9474006564594978d), new NpgsqlTypes.NpgsqlPoint(x: 0.44902463280744553d, y: 0.7179353864415837d), new NpgsqlTypes.NpgsqlPoint(x: 0.5779994986830287d, y: 0.7815530319799301d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7425392086731505d, y: 0.032931840527987255d), new NpgsqlTypes.NpgsqlPoint(x: 0.7900005190532449d, y: 0.680724629822456d), new NpgsqlTypes.NpgsqlPoint(x: 0.9652210805356723d, y: 0.1253580352435213d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39838713394828773d, y: 0.6459234533061291d), new NpgsqlTypes.NpgsqlPoint(x: 0.894574955921148d, y: 0.4120058034792242d), new NpgsqlTypes.NpgsqlPoint(x: 0.11537017483857681d, y: 0.29753081016263283d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015976773761362528d, y: 0.30348682425323703d), new NpgsqlTypes.NpgsqlPoint(x: 0.49102601817292413d, y: 0.4726846317529013d), new NpgsqlTypes.NpgsqlPoint(x: 0.17348682064926502d, y: 0.0976344916643076d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4595049235017675d, y: 0.16146726931378286d), new NpgsqlTypes.NpgsqlPoint(x: 0.9971155831176237d, y: 0.3418207752697401d), new NpgsqlTypes.NpgsqlPoint(x: 0.4461802133651819d, y: 0.5486654422095776d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7495771433337319d, y: 0.7451657871819959d), new NpgsqlTypes.NpgsqlPoint(x: 0.026230046656038786d, y: 0.8972866374310847d), new NpgsqlTypes.NpgsqlPoint(x: 0.8429979509937738d, y: 0.7810938893412006d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7329502444109951d, y: 0.10037620723351925d), new NpgsqlTypes.NpgsqlPoint(x: 0.47283367404988275d, y: 0.4239099782713851d), new NpgsqlTypes.NpgsqlPoint(x: 0.5980918894180544d, y: 0.8485919526491509d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04308032951209895d, y: 0.6378338487513536d), new NpgsqlTypes.NpgsqlPoint(x: 0.3330687764378687d, y: 0.15008212186073422d), new NpgsqlTypes.NpgsqlPoint(x: 0.059967333620595586d, y: 0.9361872499532051d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.094686701642694d, y: 0.6971621985023269d), new NpgsqlTypes.NpgsqlPoint(x: 0.5293795376719107d, y: 0.7064522335206378d), new NpgsqlTypes.NpgsqlPoint(x: 0.49109549012889875d, y: 0.3989107191850062d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6415865373707759d, y: 0.8952985723305559d), new NpgsqlTypes.NpgsqlPoint(x: 0.4077230117529541d, y: 0.9637495587013988d), new NpgsqlTypes.NpgsqlPoint(x: 0.09778699086114451d, y: 0.8825249377986938d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21377967147730703d, y: 0.22455683110534874d), new NpgsqlTypes.NpgsqlPoint(x: 0.7529879851250395d, y: 0.976632094465625d), new NpgsqlTypes.NpgsqlPoint(x: 0.5172391475667111d, y: 0.9236645031447479d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2816198404787875d, y: 0.113306680849664d), new NpgsqlTypes.NpgsqlPoint(x: 0.8380866455899572d, y: 0.05155314757981744d), new NpgsqlTypes.NpgsqlPoint(x: 0.46476680718934626d, y: 0.37285575049776987d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5657369117754486d, y: 0.3039947417663048d), new NpgsqlTypes.NpgsqlPoint(x: 0.38504649235091426d, y: 0.556222287820246d), new NpgsqlTypes.NpgsqlPoint(x: 0.5582693557996901d, y: 0.6784025847972142d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7159724344270184d, y: 0.25628801275504054d), new NpgsqlTypes.NpgsqlPoint(x: 0.4066137812744207d, y: 0.5437252280837545d), new NpgsqlTypes.NpgsqlPoint(x: 0.5179115395511864d, y: 0.4047643742691449d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2394549667898983d, y: 0.29322003446706324d), new NpgsqlTypes.NpgsqlPoint(x: 0.6286230791418723d, y: 0.7836013915074109d), new NpgsqlTypes.NpgsqlPoint(x: 0.9043168668287671d, y: 0.7104694399045266d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1332907227915705d, y: 0.29265609442743534d), new NpgsqlTypes.NpgsqlPoint(x: 0.051528730791773d, y: 0.7355377712041905d), new NpgsqlTypes.NpgsqlPoint(x: 0.19624564412262469d, y: 0.24292863946907328d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6089912973853315d, y: 0.9191231566646114d), new NpgsqlTypes.NpgsqlPoint(x: 0.438036326389765d, y: 0.2822994312807042d), new NpgsqlTypes.NpgsqlPoint(x: 0.7798317950076183d, y: 0.2447659439206935d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7376520116680109d, y: 0.5476508473333404d), new NpgsqlTypes.NpgsqlPoint(x: 0.41517304557248236d, y: 0.30820166494600787d), new NpgsqlTypes.NpgsqlPoint(x: 0.4257852192741475d, y: 0.6595117271431462d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6736323415350733d, y: 0.9623957414605326d), new NpgsqlTypes.NpgsqlPoint(x: 0.9682893052967532d, y: 0.6340055158314398d), new NpgsqlTypes.NpgsqlPoint(x: 0.522506695789585d, y: 0.39282210170373044d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9352314466019801d, y: 0.34055089311097286d), new NpgsqlTypes.NpgsqlPoint(x: 0.9445991466838459d, y: 0.19234063901188403d), new NpgsqlTypes.NpgsqlPoint(x: 0.5836620402437046d, y: 0.2807604627625139d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014599733561242112d, y: 0.8321942572549096d), new NpgsqlTypes.NpgsqlPoint(x: 0.42055993357548815d, y: 0.4225524129688101d), new NpgsqlTypes.NpgsqlPoint(x: 0.6536179794342455d, y: 0.02642963761612327d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28048302062858055d, y: 0.8062387204749303d), new NpgsqlTypes.NpgsqlPoint(x: 0.05299508884080484d, y: 0.7626168973805085d), new NpgsqlTypes.NpgsqlPoint(x: 0.8026640682389127d, y: 0.8235032292465673d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4506424990150433d, y: 0.2556233780249384d), new NpgsqlTypes.NpgsqlPoint(x: 0.6702249744235058d, y: 0.1364102913432379d), new NpgsqlTypes.NpgsqlPoint(x: 0.635584198598d, y: 0.10115594491102753d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8192178559368943d, y: 0.22883501045115295d), new NpgsqlTypes.NpgsqlPoint(x: 0.9705788688832664d, y: 0.4813948799505847d), new NpgsqlTypes.NpgsqlPoint(x: 0.2521103388240038d, y: 0.2873720814575892d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09366741477335527d, y: 0.12458859551329438d), new NpgsqlTypes.NpgsqlPoint(x: 0.3511740827803781d, y: 0.6290847555507145d), new NpgsqlTypes.NpgsqlPoint(x: 0.9626443665528049d, y: 0.6631689110705754d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.995667940370628d, y: 0.05188931887277559d), new NpgsqlTypes.NpgsqlPoint(x: 0.16796876923436d, y: 0.3887583417691052d), new NpgsqlTypes.NpgsqlPoint(x: 0.7503018716694003d, y: 0.5950999535245681d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1637398544138995d, y: 0.4355188473304509d), new NpgsqlTypes.NpgsqlPoint(x: 0.05115936710851576d, y: 0.07381374515082761d), new NpgsqlTypes.NpgsqlPoint(x: 0.8182935911046301d, y: 0.9289307132647127d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6043164375942267d, y: 0.491546111039982d), new NpgsqlTypes.NpgsqlPoint(x: 0.674582546554464d, y: 0.7452373560159545d), new NpgsqlTypes.NpgsqlPoint(x: 0.44101916701627875d, y: 0.5074596411780496d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7986552122720221d, y: 0.971980107632819d), new NpgsqlTypes.NpgsqlPoint(x: 0.34110615374279185d, y: 0.40462824699414235d), new NpgsqlTypes.NpgsqlPoint(x: 0.12814974639499122d, y: 0.7997799233349447d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7310152849572802d, y: 0.9926200767353986d), new NpgsqlTypes.NpgsqlPoint(x: 0.6620766382094361d, y: 0.62602269720117d), new NpgsqlTypes.NpgsqlPoint(x: 0.8546563715160546d, y: 0.4692695350211151d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6985443730102225d, y: 0.10273769720688597d), new NpgsqlTypes.NpgsqlPoint(x: 0.9965401071697536d, y: 0.2001878588547752d), new NpgsqlTypes.NpgsqlPoint(x: 0.42583147941948163d, y: 0.10286747829283893d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11088701365240172d, y: 0.8856839981098903d), new NpgsqlTypes.NpgsqlPoint(x: 0.6791169501909624d, y: 0.9482748541169557d), new NpgsqlTypes.NpgsqlPoint(x: 0.3787555118325786d, y: 0.33961158419672755d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3133887743482051d, y: 0.2979195337047641d), new NpgsqlTypes.NpgsqlPoint(x: 0.42873347883249047d, y: 0.10575297677029272d), new NpgsqlTypes.NpgsqlPoint(x: 0.9144342011165496d, y: 0.9550384214516707d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8834630248217832d, y: 0.02768003636709493d), new NpgsqlTypes.NpgsqlPoint(x: 0.8198182134340062d, y: 0.9567473294441596d), new NpgsqlTypes.NpgsqlPoint(x: 0.6600698028936899d, y: 0.7543906408882102d)),

},
    ModelInner = null,
    NullableValue = null,
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[34], false);
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
                parametr1.Value = 143;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[34], false);
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
                parametr1.Value = 85;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
                parametr1.Value = 115;
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[34], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[34], false);
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
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 69, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[29],_testData[34], false);
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
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 141, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[31],_testData[34], false);
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
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 135, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[34], false);
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
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 49, query1, 139, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 32, query1, 126, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[34], false);
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
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 117, query1, 23, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[29],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 23, query1, 69, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[34], false);
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
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 69, query1, 61, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 1, 108))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[33],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatch(connection, 143, 45))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 49);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], false);
                NpgsqlPathpathArray2M.AssertModel(models[1],_testData[10], false);
                NpgsqlPathpathArray2M.AssertModel(models[2],_testData[11], false);
                NpgsqlPathpathArray2M.AssertModel(models[3],_testData[12], false);
                NpgsqlPathpathArray2M.AssertModel(models[4],_testData[13], false);
                NpgsqlPathpathArray2M.AssertModel(models[5],_testData[14], false);
                NpgsqlPathpathArray2M.AssertModel(models[6],_testData[15], false);
                NpgsqlPathpathArray2M.AssertModel(models[7],_testData[16], false);
                NpgsqlPathpathArray2M.AssertModel(models[8],_testData[17], false);
                NpgsqlPathpathArray2M.AssertModel(models[9],_testData[18], false);
                NpgsqlPathpathArray2M.AssertModel(models[10],_testData[19], false);
                NpgsqlPathpathArray2M.AssertModel(models[11],_testData[20], false);
                NpgsqlPathpathArray2M.AssertModel(models[12],_testData[21], false);
                NpgsqlPathpathArray2M.AssertModel(models[13],_testData[22], false);
                NpgsqlPathpathArray2M.AssertModel(models[14],_testData[23], false);
                NpgsqlPathpathArray2M.AssertModel(models[15],_testData[24], false);
                NpgsqlPathpathArray2M.AssertModel(models[16],_testData[25], false);
                NpgsqlPathpathArray2M.AssertModel(models[17],_testData[26], false);
                NpgsqlPathpathArray2M.AssertModel(models[18],_testData[27], false);
                NpgsqlPathpathArray2M.AssertModel(models[19],_testData[28], false);
                NpgsqlPathpathArray2M.AssertModel(models[20],_testData[29], false);
                NpgsqlPathpathArray2M.AssertModel(models[21],_testData[30], false);
                NpgsqlPathpathArray2M.AssertModel(models[22],_testData[31], false);
                NpgsqlPathpathArray2M.AssertModel(models[23],_testData[32], false);
                NpgsqlPathpathArray2M.AssertModel(models[24],_testData[33], false);
                NpgsqlPathpathArray2M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 52);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

