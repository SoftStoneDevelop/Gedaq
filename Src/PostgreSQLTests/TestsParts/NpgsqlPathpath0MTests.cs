

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
    internal partial interface INpgsqlPathSingleTypepath
    {
    }
    
    internal partial class NpgsqlPathSingleTypepath : INpgsqlPathSingleTypepath
    {


#region TestData

        private readonly NpgsqlPathpath0M[] _testData = new NpgsqlPathpath0M[]
        {
            new NpgsqlPathpath0M
{
    Id = 1,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33791430432565017d, y: 0.7919574131475985d), new NpgsqlTypes.NpgsqlPoint(x: 0.21061619451231828d, y: 0.20750852321123303d), new NpgsqlTypes.NpgsqlPoint(x: 0.44990941488881686d, y: 0.2020878661674168d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6731759744459354d, y: 0.04097432848003435d), new NpgsqlTypes.NpgsqlPoint(x: 0.5714301581407971d, y: 0.8773656456767885d), new NpgsqlTypes.NpgsqlPoint(x: 0.2262731811641402d, y: 0.28536965211232157d)),
},
            new NpgsqlPathpath0M
{
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4875711549225823d, y: 0.563576525491812d), new NpgsqlTypes.NpgsqlPoint(x: 0.9632784580146451d, y: 0.1745592948228497d), new NpgsqlTypes.NpgsqlPoint(x: 0.5955380959556921d, y: 0.8951221630972473d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5156645355055374d, y: 0.05727368351065698d), new NpgsqlTypes.NpgsqlPoint(x: 0.061200460134538615d, y: 0.5958916389795146d), new NpgsqlTypes.NpgsqlPoint(x: 0.030989805512925406d, y: 0.7511905220430584d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33250168937652924d, y: 0.006583030274135759d), new NpgsqlTypes.NpgsqlPoint(x: 0.03336256879387234d, y: 0.046304592733809824d), new NpgsqlTypes.NpgsqlPoint(x: 0.026196668110002985d, y: 0.9736753057652325d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.665293884056195d, y: 0.3791146874362603d), new NpgsqlTypes.NpgsqlPoint(x: 0.7203342843600141d, y: 0.21976862933412056d), new NpgsqlTypes.NpgsqlPoint(x: 0.18899378100529174d, y: 0.3830498135690762d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9039260957184664d, y: 0.15320726454503608d), new NpgsqlTypes.NpgsqlPoint(x: 0.518668858269669d, y: 0.5100172717611301d), new NpgsqlTypes.NpgsqlPoint(x: 0.8775213932350722d, y: 0.6901630982062326d)),
},
            new NpgsqlPathpath0M
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7030882636679531d, y: 0.44270380050094793d), new NpgsqlTypes.NpgsqlPoint(x: 0.4670362595126387d, y: 0.8110027625807872d), new NpgsqlTypes.NpgsqlPoint(x: 0.8386859048455277d, y: 0.6487462630331386d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48819139690688584d, y: 0.7491903432051813d), new NpgsqlTypes.NpgsqlPoint(x: 0.8633254215990293d, y: 0.16914235372917896d), new NpgsqlTypes.NpgsqlPoint(x: 0.8050710557386759d, y: 0.4858517528465881d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2962995739841525d, y: 0.17323159102692853d), new NpgsqlTypes.NpgsqlPoint(x: 0.3174279063027263d, y: 0.42947261454230345d), new NpgsqlTypes.NpgsqlPoint(x: 0.7552218549075149d, y: 0.4590812866724031d)),
},
            new NpgsqlPathpath0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7773373168662235d, y: 0.5157332436631209d), new NpgsqlTypes.NpgsqlPoint(x: 0.5454589029981913d, y: 0.06748835757761784d), new NpgsqlTypes.NpgsqlPoint(x: 0.01579340883833591d, y: 0.6401279634886438d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8375163902500591d, y: 0.010387174255450882d), new NpgsqlTypes.NpgsqlPoint(x: 0.9320786711969773d, y: 0.6527518503152696d), new NpgsqlTypes.NpgsqlPoint(x: 0.3131583259815168d, y: 0.20023837601571715d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6783767338385488d, y: 0.7372193010697361d), new NpgsqlTypes.NpgsqlPoint(x: 0.17962579527581046d, y: 0.5829491257497201d), new NpgsqlTypes.NpgsqlPoint(x: 0.08823416018535901d, y: 0.9259785862470227d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.515081454813287d, y: 0.8406584511365887d), new NpgsqlTypes.NpgsqlPoint(x: 0.7270587082831941d, y: 0.3259914564372083d), new NpgsqlTypes.NpgsqlPoint(x: 0.5010689557373134d, y: 0.3208270578743506d)),
},
            new NpgsqlPathpath0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5447504626458278d, y: 0.40022815063653505d), new NpgsqlTypes.NpgsqlPoint(x: 0.6945332454509319d, y: 0.13444963425907253d), new NpgsqlTypes.NpgsqlPoint(x: 0.9547368598657561d, y: 0.6907077402996722d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9559681541950189d, y: 0.5406816337222956d), new NpgsqlTypes.NpgsqlPoint(x: 0.13304506185824272d, y: 0.453966516878865d), new NpgsqlTypes.NpgsqlPoint(x: 0.2339859576386044d, y: 0.19815551387835972d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.737339115546486d, y: 0.4302536366228854d), new NpgsqlTypes.NpgsqlPoint(x: 0.9014757323982275d, y: 0.23064310783944553d), new NpgsqlTypes.NpgsqlPoint(x: 0.8564939688323643d, y: 0.33841812379358605d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7686240755061517d, y: 0.07926748617107582d), new NpgsqlTypes.NpgsqlPoint(x: 0.6743368677835534d, y: 0.9267180123030674d), new NpgsqlTypes.NpgsqlPoint(x: 0.5631934361381653d, y: 0.01320716612367967d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5393497637057595d, y: 0.36509132762411456d), new NpgsqlTypes.NpgsqlPoint(x: 0.6966660276235518d, y: 0.9457187239398691d), new NpgsqlTypes.NpgsqlPoint(x: 0.591022410914032d, y: 0.1739876961346336d)),
},
            new NpgsqlPathpath0M
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0487322847571946d, y: 0.06017999951651709d), new NpgsqlTypes.NpgsqlPoint(x: 0.5829436271739258d, y: 0.05957531658694104d), new NpgsqlTypes.NpgsqlPoint(x: 0.41944208769984326d, y: 0.3011488226073976d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12689461511033373d, y: 0.5259258577258713d), new NpgsqlTypes.NpgsqlPoint(x: 0.0003026222983922855d, y: 0.6002495554092282d), new NpgsqlTypes.NpgsqlPoint(x: 0.6238356414531168d, y: 0.15251378523908665d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32961575328128323d, y: 0.8195578541497548d), new NpgsqlTypes.NpgsqlPoint(x: 0.10272939059757835d, y: 0.7876178901781932d), new NpgsqlTypes.NpgsqlPoint(x: 0.7180262036569123d, y: 0.10229259677351088d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40189615467576056d, y: 0.18365348270280835d), new NpgsqlTypes.NpgsqlPoint(x: 0.06391533074334144d, y: 0.6400325120640765d), new NpgsqlTypes.NpgsqlPoint(x: 0.5291304375839393d, y: 0.16457450714356592d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9131104741661471d, y: 0.09426244666781813d), new NpgsqlTypes.NpgsqlPoint(x: 0.6098768997804923d, y: 0.579004628466868d), new NpgsqlTypes.NpgsqlPoint(x: 0.43876712822734343d, y: 0.6841427945723075d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03697767842369348d, y: 0.9147315704519862d), new NpgsqlTypes.NpgsqlPoint(x: 0.02487832509029786d, y: 0.912355568026644d), new NpgsqlTypes.NpgsqlPoint(x: 0.32580581351797855d, y: 0.5568034600298316d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32894454225857417d, y: 0.24239106013510736d), new NpgsqlTypes.NpgsqlPoint(x: 0.8874465356904846d, y: 0.810432102036785d), new NpgsqlTypes.NpgsqlPoint(x: 0.7776616134368473d, y: 0.860073303559888d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44067958948917363d, y: 0.9141314792908606d), new NpgsqlTypes.NpgsqlPoint(x: 0.22561941880380443d, y: 0.17185799423259518d), new NpgsqlTypes.NpgsqlPoint(x: 0.19126109191865392d, y: 0.32240845806551366d)),
},
            new NpgsqlPathpath0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34438054627622294d, y: 0.09529530309215761d), new NpgsqlTypes.NpgsqlPoint(x: 0.6859528751979902d, y: 0.7879033769768619d), new NpgsqlTypes.NpgsqlPoint(x: 0.1925541007469862d, y: 0.926757898915424d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46754546828048105d, y: 0.3650000189093141d), new NpgsqlTypes.NpgsqlPoint(x: 0.733435783799051d, y: 0.28683530595933515d), new NpgsqlTypes.NpgsqlPoint(x: 0.5674458508370716d, y: 0.9901273287496026d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33048484875000594d, y: 0.2028907335258845d), new NpgsqlTypes.NpgsqlPoint(x: 0.5927784175866514d, y: 0.13936810963316715d), new NpgsqlTypes.NpgsqlPoint(x: 0.6864643627205288d, y: 0.7373710361473427d)),
},
            new NpgsqlPathpath0M
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2109860135974143d, y: 0.48284582773011697d), new NpgsqlTypes.NpgsqlPoint(x: 0.637080745002536d, y: 0.5128446641641823d), new NpgsqlTypes.NpgsqlPoint(x: 0.1466506833893647d, y: 0.060547678698796625d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7335752952202572d, y: 0.09444752486913077d), new NpgsqlTypes.NpgsqlPoint(x: 0.06410498833315958d, y: 0.9151304964563581d), new NpgsqlTypes.NpgsqlPoint(x: 0.1901864472816016d, y: 0.7321266582636775d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.025733531764596695d, y: 0.7981002658310914d), new NpgsqlTypes.NpgsqlPoint(x: 0.28176004125489185d, y: 0.26021180353976503d), new NpgsqlTypes.NpgsqlPoint(x: 0.06210572165419004d, y: 0.8049899658716249d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05004055698538423d, y: 0.44095533927107944d), new NpgsqlTypes.NpgsqlPoint(x: 0.36543305961182504d, y: 0.37444508697096757d), new NpgsqlTypes.NpgsqlPoint(x: 0.8751542254462913d, y: 0.703533572810716d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5210857038037093d, y: 0.11932783039793315d), new NpgsqlTypes.NpgsqlPoint(x: 0.27575528982754305d, y: 0.2832180122251847d), new NpgsqlTypes.NpgsqlPoint(x: 0.980224424789703d, y: 0.38711687415307794d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6921144853927277d, y: 0.879694450835172d), new NpgsqlTypes.NpgsqlPoint(x: 0.9750858650305393d, y: 0.6765819563087107d), new NpgsqlTypes.NpgsqlPoint(x: 0.7746455258581997d, y: 0.8517237445567841d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05445302762591142d, y: 0.4276323570309174d), new NpgsqlTypes.NpgsqlPoint(x: 0.49015971939922687d, y: 0.35725326638890453d), new NpgsqlTypes.NpgsqlPoint(x: 0.385058001889128d, y: 0.9648141526052064d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.027380941799975855d, y: 0.6667728289309822d), new NpgsqlTypes.NpgsqlPoint(x: 0.1123322762824992d, y: 0.03318850675705376d), new NpgsqlTypes.NpgsqlPoint(x: 0.7811996775989571d, y: 0.5934030427372874d)),
},
            new NpgsqlPathpath0M
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.587263823554979d, y: 0.6650461459398295d), new NpgsqlTypes.NpgsqlPoint(x: 0.28395738262067394d, y: 0.7723345009079359d), new NpgsqlTypes.NpgsqlPoint(x: 0.312157327843125d, y: 0.5604714803151128d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7400491923094735d, y: 0.4610360912511168d), new NpgsqlTypes.NpgsqlPoint(x: 0.8169255993070913d, y: 0.9065897418066372d), new NpgsqlTypes.NpgsqlPoint(x: 0.6872990389939155d, y: 0.5976838066980485d)),
},
            new NpgsqlPathpath0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8918039463910601d, y: 0.6715230029973289d), new NpgsqlTypes.NpgsqlPoint(x: 0.7110012054779836d, y: 0.26424447715762067d), new NpgsqlTypes.NpgsqlPoint(x: 0.11162431385565474d, y: 0.6326416105134488d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17320402075926178d, y: 0.8428510891138943d), new NpgsqlTypes.NpgsqlPoint(x: 0.6852581778230727d, y: 0.08989464354403698d), new NpgsqlTypes.NpgsqlPoint(x: 0.04642863062453595d, y: 0.8249777867567083d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11466435922194795d, y: 0.7351691691520567d), new NpgsqlTypes.NpgsqlPoint(x: 0.42454961473725117d, y: 0.20321713386147888d), new NpgsqlTypes.NpgsqlPoint(x: 0.4253862608328538d, y: 0.4125889157020044d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3351570527376738d, y: 0.4404294209119717d), new NpgsqlTypes.NpgsqlPoint(x: 0.7456120713655527d, y: 0.7425652061306875d), new NpgsqlTypes.NpgsqlPoint(x: 0.01878353940557409d, y: 0.8707207436890413d)),
},
            new NpgsqlPathpath0M
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.263823407015608d, y: 0.4847887744482363d), new NpgsqlTypes.NpgsqlPoint(x: 0.2215080334039461d, y: 0.3171637766013289d), new NpgsqlTypes.NpgsqlPoint(x: 0.3017698913326702d, y: 0.8523779936567596d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3097963109610766d, y: 0.031360557085182705d), new NpgsqlTypes.NpgsqlPoint(x: 0.4663845974463542d, y: 0.7383650379624618d), new NpgsqlTypes.NpgsqlPoint(x: 0.572146127748278d, y: 0.823460461895058d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16717900041301081d, y: 0.9814097794856423d), new NpgsqlTypes.NpgsqlPoint(x: 0.10017351541033359d, y: 0.8192212657338129d), new NpgsqlTypes.NpgsqlPoint(x: 0.9558904524261804d, y: 0.362501769169006d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8213794036889185d, y: 0.9898542009031959d), new NpgsqlTypes.NpgsqlPoint(x: 0.6925678776831625d, y: 0.952044323951547d), new NpgsqlTypes.NpgsqlPoint(x: 0.9875126816303158d, y: 0.557082057247297d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6251794255155856d, y: 0.6515934917802145d), new NpgsqlTypes.NpgsqlPoint(x: 0.6440965056567838d, y: 0.08149081370510369d), new NpgsqlTypes.NpgsqlPoint(x: 0.7773797051252238d, y: 0.11091592621634205d)),
},
            new NpgsqlPathpath0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.80674803246815d, y: 0.6247172265710026d), new NpgsqlTypes.NpgsqlPoint(x: 0.004293497042797578d, y: 0.9670519493861437d), new NpgsqlTypes.NpgsqlPoint(x: 0.6967997093476701d, y: 0.5971657733604994d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3593682522574576d, y: 0.9822021225386578d), new NpgsqlTypes.NpgsqlPoint(x: 0.10150869660346706d, y: 0.8880690399915078d), new NpgsqlTypes.NpgsqlPoint(x: 0.26425538162233d, y: 0.15263988208864787d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7832977870747574d, y: 0.06551455515206805d), new NpgsqlTypes.NpgsqlPoint(x: 0.7579224832228059d, y: 0.8103897923236184d), new NpgsqlTypes.NpgsqlPoint(x: 0.4722344107673364d, y: 0.134326659521259d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2815382174410883d, y: 0.8611241955532555d), new NpgsqlTypes.NpgsqlPoint(x: 0.9491977438908823d, y: 0.8869326097228761d), new NpgsqlTypes.NpgsqlPoint(x: 0.24246731483145123d, y: 0.8266396514476144d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7104775399049988d, y: 0.5298423990751424d), new NpgsqlTypes.NpgsqlPoint(x: 0.7307910269476404d, y: 0.9340622963413886d), new NpgsqlTypes.NpgsqlPoint(x: 0.1212190754450283d, y: 0.1922105611393019d)),
},
            new NpgsqlPathpath0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5088823535300733d, y: 0.6952721591470171d), new NpgsqlTypes.NpgsqlPoint(x: 0.41056947038357483d, y: 0.32645561404625045d), new NpgsqlTypes.NpgsqlPoint(x: 0.675000477502112d, y: 0.9185973489898716d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8660673673803396d, y: 0.7931506365553892d), new NpgsqlTypes.NpgsqlPoint(x: 0.9795919114838263d, y: 0.3846803604684955d), new NpgsqlTypes.NpgsqlPoint(x: 0.3143599180139768d, y: 0.24184356314784938d)),
},
            new NpgsqlPathpath0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8723893096224349d, y: 0.21380373226824d), new NpgsqlTypes.NpgsqlPoint(x: 0.5446502117204755d, y: 0.6983119706960635d), new NpgsqlTypes.NpgsqlPoint(x: 0.6497327073263113d, y: 0.38988997105883505d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5684203417401891d, y: 0.5998610592059745d), new NpgsqlTypes.NpgsqlPoint(x: 0.8049147214539695d, y: 0.17617842174857168d), new NpgsqlTypes.NpgsqlPoint(x: 0.287479300534066d, y: 0.7136781570839503d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05542367797282366d, y: 0.8276737183548022d), new NpgsqlTypes.NpgsqlPoint(x: 0.419214220897536d, y: 0.2327973075079255d), new NpgsqlTypes.NpgsqlPoint(x: 0.02700258260665922d, y: 0.5210446431773427d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 124,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0601354589271661d, y: 0.45990366022337537d), new NpgsqlTypes.NpgsqlPoint(x: 0.7398806293735114d, y: 0.7397778627256805d), new NpgsqlTypes.NpgsqlPoint(x: 0.38624686977146716d, y: 0.8558489889554333d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7517075295907283d, y: 0.9440827301945958d), new NpgsqlTypes.NpgsqlPoint(x: 0.5576122842212244d, y: 0.08472913951857575d), new NpgsqlTypes.NpgsqlPoint(x: 0.6898432456754164d, y: 0.9908236161729177d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5667189815463245d, y: 0.5027583297422372d), new NpgsqlTypes.NpgsqlPoint(x: 0.008921074018053421d, y: 0.3626443224929129d), new NpgsqlTypes.NpgsqlPoint(x: 0.39268638012791035d, y: 0.7826613227342841d)),
},
            new NpgsqlPathpath0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20222528304035747d, y: 0.003236941573519281d), new NpgsqlTypes.NpgsqlPoint(x: 0.058891715706515746d, y: 0.7517465408215327d), new NpgsqlTypes.NpgsqlPoint(x: 0.3380305219610946d, y: 0.39913439992641153d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24280644449533184d, y: 0.29302247072194854d), new NpgsqlTypes.NpgsqlPoint(x: 0.6538164137309863d, y: 0.5423370558620952d), new NpgsqlTypes.NpgsqlPoint(x: 0.7858889236638196d, y: 0.7085745974207086d)),
},
            new NpgsqlPathpath0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5361829439644034d, y: 0.9819540654462928d), new NpgsqlTypes.NpgsqlPoint(x: 0.6651851927759784d, y: 0.34838727151210647d), new NpgsqlTypes.NpgsqlPoint(x: 0.04511353469381474d, y: 0.8748473999927088d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.690546851973595d, y: 0.8400878974380434d), new NpgsqlTypes.NpgsqlPoint(x: 0.9975710738318291d, y: 0.6196521102205178d), new NpgsqlTypes.NpgsqlPoint(x: 0.8935166759575435d, y: 0.7018470440252068d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.978495278395631d, y: 0.18398458926043582d), new NpgsqlTypes.NpgsqlPoint(x: 0.8201875239313584d, y: 0.7313920242851337d), new NpgsqlTypes.NpgsqlPoint(x: 0.16782553461639982d, y: 0.0608059838216749d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5817815845984335d, y: 0.2084441517393324d), new NpgsqlTypes.NpgsqlPoint(x: 0.28400579183613983d, y: 0.9666767144523549d), new NpgsqlTypes.NpgsqlPoint(x: 0.26949856236594827d, y: 0.012038040126292171d)),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpath0mi_id", 
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
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.515081454813287d, y: 0.8406584511365887d), new NpgsqlTypes.NpgsqlPoint(x: 0.7270587082831941d, y: 0.3259914564372083d), new NpgsqlTypes.NpgsqlPoint(x: 0.5010689557373134d, y: 0.3208270578743506d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpath0mi_id", 
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5393497637057595d, y: 0.36509132762411456d), new NpgsqlTypes.NpgsqlPoint(x: 0.6966660276235518d, y: 0.9457187239398691d), new NpgsqlTypes.NpgsqlPoint(x: 0.591022410914032d, y: 0.1739876961346336d))));
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpath0M> models = null;

                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpath0M> models = null;

                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpathpath0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPath), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpathpath0mi_id", 
                methodParametrName: "npgsqlpathpath0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathSingleTypepath)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 20;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 111;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[29], false);
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
                parametr1.Value = 45;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[29], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 34, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 26, query1, 113, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 7, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 2, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 20, query1, 38, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 20, query1, 7, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[26],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 80, query1, 67, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 113, query1, 47, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 14, 76))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[29], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 76, 124))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 27);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
NpgsqlPathpath0M.AssertModel(models[0],_testData[7], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[8], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[9], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[10], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[21],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 111);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
NpgsqlPathpath0M.AssertModel(models[0],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33791430432565017d, y: 0.7919574131475985d), new NpgsqlTypes.NpgsqlPoint(x: 0.21061619451231828d, y: 0.20750852321123303d), new NpgsqlTypes.NpgsqlPoint(x: 0.44990941488881686d, y: 0.2020878661674168d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6731759744459354d, y: 0.04097432848003435d), new NpgsqlTypes.NpgsqlPoint(x: 0.5714301581407971d, y: 0.8773656456767885d), new NpgsqlTypes.NpgsqlPoint(x: 0.2262731811641402d, y: 0.28536965211232157d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4875711549225823d, y: 0.563576525491812d), new NpgsqlTypes.NpgsqlPoint(x: 0.9632784580146451d, y: 0.1745592948228497d), new NpgsqlTypes.NpgsqlPoint(x: 0.5955380959556921d, y: 0.8951221630972473d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5156645355055374d, y: 0.05727368351065698d), new NpgsqlTypes.NpgsqlPoint(x: 0.061200460134538615d, y: 0.5958916389795146d), new NpgsqlTypes.NpgsqlPoint(x: 0.030989805512925406d, y: 0.7511905220430584d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33250168937652924d, y: 0.006583030274135759d), new NpgsqlTypes.NpgsqlPoint(x: 0.03336256879387234d, y: 0.046304592733809824d), new NpgsqlTypes.NpgsqlPoint(x: 0.026196668110002985d, y: 0.9736753057652325d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.665293884056195d, y: 0.3791146874362603d), new NpgsqlTypes.NpgsqlPoint(x: 0.7203342843600141d, y: 0.21976862933412056d), new NpgsqlTypes.NpgsqlPoint(x: 0.18899378100529174d, y: 0.3830498135690762d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9039260957184664d, y: 0.15320726454503608d), new NpgsqlTypes.NpgsqlPoint(x: 0.518668858269669d, y: 0.5100172717611301d), new NpgsqlTypes.NpgsqlPoint(x: 0.8775213932350722d, y: 0.6901630982062326d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7030882636679531d, y: 0.44270380050094793d), new NpgsqlTypes.NpgsqlPoint(x: 0.4670362595126387d, y: 0.8110027625807872d), new NpgsqlTypes.NpgsqlPoint(x: 0.8386859048455277d, y: 0.6487462630331386d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48819139690688584d, y: 0.7491903432051813d), new NpgsqlTypes.NpgsqlPoint(x: 0.8633254215990293d, y: 0.16914235372917896d), new NpgsqlTypes.NpgsqlPoint(x: 0.8050710557386759d, y: 0.4858517528465881d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2962995739841525d, y: 0.17323159102692853d), new NpgsqlTypes.NpgsqlPoint(x: 0.3174279063027263d, y: 0.42947261454230345d), new NpgsqlTypes.NpgsqlPoint(x: 0.7552218549075149d, y: 0.4590812866724031d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7773373168662235d, y: 0.5157332436631209d), new NpgsqlTypes.NpgsqlPoint(x: 0.5454589029981913d, y: 0.06748835757761784d), new NpgsqlTypes.NpgsqlPoint(x: 0.01579340883833591d, y: 0.6401279634886438d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8375163902500591d, y: 0.010387174255450882d), new NpgsqlTypes.NpgsqlPoint(x: 0.9320786711969773d, y: 0.6527518503152696d), new NpgsqlTypes.NpgsqlPoint(x: 0.3131583259815168d, y: 0.20023837601571715d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6783767338385488d, y: 0.7372193010697361d), new NpgsqlTypes.NpgsqlPoint(x: 0.17962579527581046d, y: 0.5829491257497201d), new NpgsqlTypes.NpgsqlPoint(x: 0.08823416018535901d, y: 0.9259785862470227d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.515081454813287d, y: 0.8406584511365887d), new NpgsqlTypes.NpgsqlPoint(x: 0.7270587082831941d, y: 0.3259914564372083d), new NpgsqlTypes.NpgsqlPoint(x: 0.5010689557373134d, y: 0.3208270578743506d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5447504626458278d, y: 0.40022815063653505d), new NpgsqlTypes.NpgsqlPoint(x: 0.6945332454509319d, y: 0.13444963425907253d), new NpgsqlTypes.NpgsqlPoint(x: 0.9547368598657561d, y: 0.6907077402996722d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9559681541950189d, y: 0.5406816337222956d), new NpgsqlTypes.NpgsqlPoint(x: 0.13304506185824272d, y: 0.453966516878865d), new NpgsqlTypes.NpgsqlPoint(x: 0.2339859576386044d, y: 0.19815551387835972d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.737339115546486d, y: 0.4302536366228854d), new NpgsqlTypes.NpgsqlPoint(x: 0.9014757323982275d, y: 0.23064310783944553d), new NpgsqlTypes.NpgsqlPoint(x: 0.8564939688323643d, y: 0.33841812379358605d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7686240755061517d, y: 0.07926748617107582d), new NpgsqlTypes.NpgsqlPoint(x: 0.6743368677835534d, y: 0.9267180123030674d), new NpgsqlTypes.NpgsqlPoint(x: 0.5631934361381653d, y: 0.01320716612367967d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5393497637057595d, y: 0.36509132762411456d), new NpgsqlTypes.NpgsqlPoint(x: 0.6966660276235518d, y: 0.9457187239398691d), new NpgsqlTypes.NpgsqlPoint(x: 0.591022410914032d, y: 0.1739876961346336d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0487322847571946d, y: 0.06017999951651709d), new NpgsqlTypes.NpgsqlPoint(x: 0.5829436271739258d, y: 0.05957531658694104d), new NpgsqlTypes.NpgsqlPoint(x: 0.41944208769984326d, y: 0.3011488226073976d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12689461511033373d, y: 0.5259258577258713d), new NpgsqlTypes.NpgsqlPoint(x: 0.0003026222983922855d, y: 0.6002495554092282d), new NpgsqlTypes.NpgsqlPoint(x: 0.6238356414531168d, y: 0.15251378523908665d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32961575328128323d, y: 0.8195578541497548d), new NpgsqlTypes.NpgsqlPoint(x: 0.10272939059757835d, y: 0.7876178901781932d), new NpgsqlTypes.NpgsqlPoint(x: 0.7180262036569123d, y: 0.10229259677351088d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40189615467576056d, y: 0.18365348270280835d), new NpgsqlTypes.NpgsqlPoint(x: 0.06391533074334144d, y: 0.6400325120640765d), new NpgsqlTypes.NpgsqlPoint(x: 0.5291304375839393d, y: 0.16457450714356592d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9131104741661471d, y: 0.09426244666781813d), new NpgsqlTypes.NpgsqlPoint(x: 0.6098768997804923d, y: 0.579004628466868d), new NpgsqlTypes.NpgsqlPoint(x: 0.43876712822734343d, y: 0.6841427945723075d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03697767842369348d, y: 0.9147315704519862d), new NpgsqlTypes.NpgsqlPoint(x: 0.02487832509029786d, y: 0.912355568026644d), new NpgsqlTypes.NpgsqlPoint(x: 0.32580581351797855d, y: 0.5568034600298316d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32894454225857417d, y: 0.24239106013510736d), new NpgsqlTypes.NpgsqlPoint(x: 0.8874465356904846d, y: 0.810432102036785d), new NpgsqlTypes.NpgsqlPoint(x: 0.7776616134368473d, y: 0.860073303559888d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44067958948917363d, y: 0.9141314792908606d), new NpgsqlTypes.NpgsqlPoint(x: 0.22561941880380443d, y: 0.17185799423259518d), new NpgsqlTypes.NpgsqlPoint(x: 0.19126109191865392d, y: 0.32240845806551366d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34438054627622294d, y: 0.09529530309215761d), new NpgsqlTypes.NpgsqlPoint(x: 0.6859528751979902d, y: 0.7879033769768619d), new NpgsqlTypes.NpgsqlPoint(x: 0.1925541007469862d, y: 0.926757898915424d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46754546828048105d, y: 0.3650000189093141d), new NpgsqlTypes.NpgsqlPoint(x: 0.733435783799051d, y: 0.28683530595933515d), new NpgsqlTypes.NpgsqlPoint(x: 0.5674458508370716d, y: 0.9901273287496026d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33048484875000594d, y: 0.2028907335258845d), new NpgsqlTypes.NpgsqlPoint(x: 0.5927784175866514d, y: 0.13936810963316715d), new NpgsqlTypes.NpgsqlPoint(x: 0.6864643627205288d, y: 0.7373710361473427d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2109860135974143d, y: 0.48284582773011697d), new NpgsqlTypes.NpgsqlPoint(x: 0.637080745002536d, y: 0.5128446641641823d), new NpgsqlTypes.NpgsqlPoint(x: 0.1466506833893647d, y: 0.060547678698796625d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7335752952202572d, y: 0.09444752486913077d), new NpgsqlTypes.NpgsqlPoint(x: 0.06410498833315958d, y: 0.9151304964563581d), new NpgsqlTypes.NpgsqlPoint(x: 0.1901864472816016d, y: 0.7321266582636775d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.025733531764596695d, y: 0.7981002658310914d), new NpgsqlTypes.NpgsqlPoint(x: 0.28176004125489185d, y: 0.26021180353976503d), new NpgsqlTypes.NpgsqlPoint(x: 0.06210572165419004d, y: 0.8049899658716249d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05004055698538423d, y: 0.44095533927107944d), new NpgsqlTypes.NpgsqlPoint(x: 0.36543305961182504d, y: 0.37444508697096757d), new NpgsqlTypes.NpgsqlPoint(x: 0.8751542254462913d, y: 0.703533572810716d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5210857038037093d, y: 0.11932783039793315d), new NpgsqlTypes.NpgsqlPoint(x: 0.27575528982754305d, y: 0.2832180122251847d), new NpgsqlTypes.NpgsqlPoint(x: 0.980224424789703d, y: 0.38711687415307794d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6921144853927277d, y: 0.879694450835172d), new NpgsqlTypes.NpgsqlPoint(x: 0.9750858650305393d, y: 0.6765819563087107d), new NpgsqlTypes.NpgsqlPoint(x: 0.7746455258581997d, y: 0.8517237445567841d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05445302762591142d, y: 0.4276323570309174d), new NpgsqlTypes.NpgsqlPoint(x: 0.49015971939922687d, y: 0.35725326638890453d), new NpgsqlTypes.NpgsqlPoint(x: 0.385058001889128d, y: 0.9648141526052064d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.027380941799975855d, y: 0.6667728289309822d), new NpgsqlTypes.NpgsqlPoint(x: 0.1123322762824992d, y: 0.03318850675705376d), new NpgsqlTypes.NpgsqlPoint(x: 0.7811996775989571d, y: 0.5934030427372874d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.587263823554979d, y: 0.6650461459398295d), new NpgsqlTypes.NpgsqlPoint(x: 0.28395738262067394d, y: 0.7723345009079359d), new NpgsqlTypes.NpgsqlPoint(x: 0.312157327843125d, y: 0.5604714803151128d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7400491923094735d, y: 0.4610360912511168d), new NpgsqlTypes.NpgsqlPoint(x: 0.8169255993070913d, y: 0.9065897418066372d), new NpgsqlTypes.NpgsqlPoint(x: 0.6872990389939155d, y: 0.5976838066980485d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8918039463910601d, y: 0.6715230029973289d), new NpgsqlTypes.NpgsqlPoint(x: 0.7110012054779836d, y: 0.26424447715762067d), new NpgsqlTypes.NpgsqlPoint(x: 0.11162431385565474d, y: 0.6326416105134488d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17320402075926178d, y: 0.8428510891138943d), new NpgsqlTypes.NpgsqlPoint(x: 0.6852581778230727d, y: 0.08989464354403698d), new NpgsqlTypes.NpgsqlPoint(x: 0.04642863062453595d, y: 0.8249777867567083d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11466435922194795d, y: 0.7351691691520567d), new NpgsqlTypes.NpgsqlPoint(x: 0.42454961473725117d, y: 0.20321713386147888d), new NpgsqlTypes.NpgsqlPoint(x: 0.4253862608328538d, y: 0.4125889157020044d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3351570527376738d, y: 0.4404294209119717d), new NpgsqlTypes.NpgsqlPoint(x: 0.7456120713655527d, y: 0.7425652061306875d), new NpgsqlTypes.NpgsqlPoint(x: 0.01878353940557409d, y: 0.8707207436890413d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.263823407015608d, y: 0.4847887744482363d), new NpgsqlTypes.NpgsqlPoint(x: 0.2215080334039461d, y: 0.3171637766013289d), new NpgsqlTypes.NpgsqlPoint(x: 0.3017698913326702d, y: 0.8523779936567596d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3097963109610766d, y: 0.031360557085182705d), new NpgsqlTypes.NpgsqlPoint(x: 0.4663845974463542d, y: 0.7383650379624618d), new NpgsqlTypes.NpgsqlPoint(x: 0.572146127748278d, y: 0.823460461895058d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16717900041301081d, y: 0.9814097794856423d), new NpgsqlTypes.NpgsqlPoint(x: 0.10017351541033359d, y: 0.8192212657338129d), new NpgsqlTypes.NpgsqlPoint(x: 0.9558904524261804d, y: 0.362501769169006d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8213794036889185d, y: 0.9898542009031959d), new NpgsqlTypes.NpgsqlPoint(x: 0.6925678776831625d, y: 0.952044323951547d), new NpgsqlTypes.NpgsqlPoint(x: 0.9875126816303158d, y: 0.557082057247297d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6251794255155856d, y: 0.6515934917802145d), new NpgsqlTypes.NpgsqlPoint(x: 0.6440965056567838d, y: 0.08149081370510369d), new NpgsqlTypes.NpgsqlPoint(x: 0.7773797051252238d, y: 0.11091592621634205d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.80674803246815d, y: 0.6247172265710026d), new NpgsqlTypes.NpgsqlPoint(x: 0.004293497042797578d, y: 0.9670519493861437d), new NpgsqlTypes.NpgsqlPoint(x: 0.6967997093476701d, y: 0.5971657733604994d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3593682522574576d, y: 0.9822021225386578d), new NpgsqlTypes.NpgsqlPoint(x: 0.10150869660346706d, y: 0.8880690399915078d), new NpgsqlTypes.NpgsqlPoint(x: 0.26425538162233d, y: 0.15263988208864787d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7832977870747574d, y: 0.06551455515206805d), new NpgsqlTypes.NpgsqlPoint(x: 0.7579224832228059d, y: 0.8103897923236184d), new NpgsqlTypes.NpgsqlPoint(x: 0.4722344107673364d, y: 0.134326659521259d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2815382174410883d, y: 0.8611241955532555d), new NpgsqlTypes.NpgsqlPoint(x: 0.9491977438908823d, y: 0.8869326097228761d), new NpgsqlTypes.NpgsqlPoint(x: 0.24246731483145123d, y: 0.8266396514476144d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7104775399049988d, y: 0.5298423990751424d), new NpgsqlTypes.NpgsqlPoint(x: 0.7307910269476404d, y: 0.9340622963413886d), new NpgsqlTypes.NpgsqlPoint(x: 0.1212190754450283d, y: 0.1922105611393019d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5088823535300733d, y: 0.6952721591470171d), new NpgsqlTypes.NpgsqlPoint(x: 0.41056947038357483d, y: 0.32645561404625045d), new NpgsqlTypes.NpgsqlPoint(x: 0.675000477502112d, y: 0.9185973489898716d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8660673673803396d, y: 0.7931506365553892d), new NpgsqlTypes.NpgsqlPoint(x: 0.9795919114838263d, y: 0.3846803604684955d), new NpgsqlTypes.NpgsqlPoint(x: 0.3143599180139768d, y: 0.24184356314784938d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8723893096224349d, y: 0.21380373226824d), new NpgsqlTypes.NpgsqlPoint(x: 0.5446502117204755d, y: 0.6983119706960635d), new NpgsqlTypes.NpgsqlPoint(x: 0.6497327073263113d, y: 0.38988997105883505d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5684203417401891d, y: 0.5998610592059745d), new NpgsqlTypes.NpgsqlPoint(x: 0.8049147214539695d, y: 0.17617842174857168d), new NpgsqlTypes.NpgsqlPoint(x: 0.287479300534066d, y: 0.7136781570839503d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05542367797282366d, y: 0.8276737183548022d), new NpgsqlTypes.NpgsqlPoint(x: 0.419214220897536d, y: 0.2327973075079255d), new NpgsqlTypes.NpgsqlPoint(x: 0.02700258260665922d, y: 0.5210446431773427d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0601354589271661d, y: 0.45990366022337537d), new NpgsqlTypes.NpgsqlPoint(x: 0.7398806293735114d, y: 0.7397778627256805d), new NpgsqlTypes.NpgsqlPoint(x: 0.38624686977146716d, y: 0.8558489889554333d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7517075295907283d, y: 0.9440827301945958d), new NpgsqlTypes.NpgsqlPoint(x: 0.5576122842212244d, y: 0.08472913951857575d), new NpgsqlTypes.NpgsqlPoint(x: 0.6898432456754164d, y: 0.9908236161729177d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5667189815463245d, y: 0.5027583297422372d), new NpgsqlTypes.NpgsqlPoint(x: 0.008921074018053421d, y: 0.3626443224929129d), new NpgsqlTypes.NpgsqlPoint(x: 0.39268638012791035d, y: 0.7826613227342841d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20222528304035747d, y: 0.003236941573519281d), new NpgsqlTypes.NpgsqlPoint(x: 0.058891715706515746d, y: 0.7517465408215327d), new NpgsqlTypes.NpgsqlPoint(x: 0.3380305219610946d, y: 0.39913439992641153d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24280644449533184d, y: 0.29302247072194854d), new NpgsqlTypes.NpgsqlPoint(x: 0.6538164137309863d, y: 0.5423370558620952d), new NpgsqlTypes.NpgsqlPoint(x: 0.7858889236638196d, y: 0.7085745974207086d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5361829439644034d, y: 0.9819540654462928d), new NpgsqlTypes.NpgsqlPoint(x: 0.6651851927759784d, y: 0.34838727151210647d), new NpgsqlTypes.NpgsqlPoint(x: 0.04511353469381474d, y: 0.8748473999927088d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.690546851973595d, y: 0.8400878974380434d), new NpgsqlTypes.NpgsqlPoint(x: 0.9975710738318291d, y: 0.6196521102205178d), new NpgsqlTypes.NpgsqlPoint(x: 0.8935166759575435d, y: 0.7018470440252068d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.978495278395631d, y: 0.18398458926043582d), new NpgsqlTypes.NpgsqlPoint(x: 0.8201875239313584d, y: 0.7313920242851337d), new NpgsqlTypes.NpgsqlPoint(x: 0.16782553461639982d, y: 0.0608059838216749d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5817815845984335d, y: 0.2084441517393324d), new NpgsqlTypes.NpgsqlPoint(x: 0.28400579183613983d, y: 0.9666767144523549d), new NpgsqlTypes.NpgsqlPoint(x: 0.26949856236594827d, y: 0.012038040126292171d)))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33791430432565017d, y: 0.7919574131475985d), new NpgsqlTypes.NpgsqlPoint(x: 0.21061619451231828d, y: 0.20750852321123303d), new NpgsqlTypes.NpgsqlPoint(x: 0.44990941488881686d, y: 0.2020878661674168d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6731759744459354d, y: 0.04097432848003435d), new NpgsqlTypes.NpgsqlPoint(x: 0.5714301581407971d, y: 0.8773656456767885d), new NpgsqlTypes.NpgsqlPoint(x: 0.2262731811641402d, y: 0.28536965211232157d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4875711549225823d, y: 0.563576525491812d), new NpgsqlTypes.NpgsqlPoint(x: 0.9632784580146451d, y: 0.1745592948228497d), new NpgsqlTypes.NpgsqlPoint(x: 0.5955380959556921d, y: 0.8951221630972473d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5156645355055374d, y: 0.05727368351065698d), new NpgsqlTypes.NpgsqlPoint(x: 0.061200460134538615d, y: 0.5958916389795146d), new NpgsqlTypes.NpgsqlPoint(x: 0.030989805512925406d, y: 0.7511905220430584d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33250168937652924d, y: 0.006583030274135759d), new NpgsqlTypes.NpgsqlPoint(x: 0.03336256879387234d, y: 0.046304592733809824d), new NpgsqlTypes.NpgsqlPoint(x: 0.026196668110002985d, y: 0.9736753057652325d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.665293884056195d, y: 0.3791146874362603d), new NpgsqlTypes.NpgsqlPoint(x: 0.7203342843600141d, y: 0.21976862933412056d), new NpgsqlTypes.NpgsqlPoint(x: 0.18899378100529174d, y: 0.3830498135690762d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9039260957184664d, y: 0.15320726454503608d), new NpgsqlTypes.NpgsqlPoint(x: 0.518668858269669d, y: 0.5100172717611301d), new NpgsqlTypes.NpgsqlPoint(x: 0.8775213932350722d, y: 0.6901630982062326d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7030882636679531d, y: 0.44270380050094793d), new NpgsqlTypes.NpgsqlPoint(x: 0.4670362595126387d, y: 0.8110027625807872d), new NpgsqlTypes.NpgsqlPoint(x: 0.8386859048455277d, y: 0.6487462630331386d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48819139690688584d, y: 0.7491903432051813d), new NpgsqlTypes.NpgsqlPoint(x: 0.8633254215990293d, y: 0.16914235372917896d), new NpgsqlTypes.NpgsqlPoint(x: 0.8050710557386759d, y: 0.4858517528465881d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2962995739841525d, y: 0.17323159102692853d), new NpgsqlTypes.NpgsqlPoint(x: 0.3174279063027263d, y: 0.42947261454230345d), new NpgsqlTypes.NpgsqlPoint(x: 0.7552218549075149d, y: 0.4590812866724031d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7773373168662235d, y: 0.5157332436631209d), new NpgsqlTypes.NpgsqlPoint(x: 0.5454589029981913d, y: 0.06748835757761784d), new NpgsqlTypes.NpgsqlPoint(x: 0.01579340883833591d, y: 0.6401279634886438d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8375163902500591d, y: 0.010387174255450882d), new NpgsqlTypes.NpgsqlPoint(x: 0.9320786711969773d, y: 0.6527518503152696d), new NpgsqlTypes.NpgsqlPoint(x: 0.3131583259815168d, y: 0.20023837601571715d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6783767338385488d, y: 0.7372193010697361d), new NpgsqlTypes.NpgsqlPoint(x: 0.17962579527581046d, y: 0.5829491257497201d), new NpgsqlTypes.NpgsqlPoint(x: 0.08823416018535901d, y: 0.9259785862470227d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.515081454813287d, y: 0.8406584511365887d), new NpgsqlTypes.NpgsqlPoint(x: 0.7270587082831941d, y: 0.3259914564372083d), new NpgsqlTypes.NpgsqlPoint(x: 0.5010689557373134d, y: 0.3208270578743506d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5447504626458278d, y: 0.40022815063653505d), new NpgsqlTypes.NpgsqlPoint(x: 0.6945332454509319d, y: 0.13444963425907253d), new NpgsqlTypes.NpgsqlPoint(x: 0.9547368598657561d, y: 0.6907077402996722d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9559681541950189d, y: 0.5406816337222956d), new NpgsqlTypes.NpgsqlPoint(x: 0.13304506185824272d, y: 0.453966516878865d), new NpgsqlTypes.NpgsqlPoint(x: 0.2339859576386044d, y: 0.19815551387835972d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.737339115546486d, y: 0.4302536366228854d), new NpgsqlTypes.NpgsqlPoint(x: 0.9014757323982275d, y: 0.23064310783944553d), new NpgsqlTypes.NpgsqlPoint(x: 0.8564939688323643d, y: 0.33841812379358605d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7686240755061517d, y: 0.07926748617107582d), new NpgsqlTypes.NpgsqlPoint(x: 0.6743368677835534d, y: 0.9267180123030674d), new NpgsqlTypes.NpgsqlPoint(x: 0.5631934361381653d, y: 0.01320716612367967d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5393497637057595d, y: 0.36509132762411456d), new NpgsqlTypes.NpgsqlPoint(x: 0.6966660276235518d, y: 0.9457187239398691d), new NpgsqlTypes.NpgsqlPoint(x: 0.591022410914032d, y: 0.1739876961346336d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0487322847571946d, y: 0.06017999951651709d), new NpgsqlTypes.NpgsqlPoint(x: 0.5829436271739258d, y: 0.05957531658694104d), new NpgsqlTypes.NpgsqlPoint(x: 0.41944208769984326d, y: 0.3011488226073976d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12689461511033373d, y: 0.5259258577258713d), new NpgsqlTypes.NpgsqlPoint(x: 0.0003026222983922855d, y: 0.6002495554092282d), new NpgsqlTypes.NpgsqlPoint(x: 0.6238356414531168d, y: 0.15251378523908665d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32961575328128323d, y: 0.8195578541497548d), new NpgsqlTypes.NpgsqlPoint(x: 0.10272939059757835d, y: 0.7876178901781932d), new NpgsqlTypes.NpgsqlPoint(x: 0.7180262036569123d, y: 0.10229259677351088d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40189615467576056d, y: 0.18365348270280835d), new NpgsqlTypes.NpgsqlPoint(x: 0.06391533074334144d, y: 0.6400325120640765d), new NpgsqlTypes.NpgsqlPoint(x: 0.5291304375839393d, y: 0.16457450714356592d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9131104741661471d, y: 0.09426244666781813d), new NpgsqlTypes.NpgsqlPoint(x: 0.6098768997804923d, y: 0.579004628466868d), new NpgsqlTypes.NpgsqlPoint(x: 0.43876712822734343d, y: 0.6841427945723075d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03697767842369348d, y: 0.9147315704519862d), new NpgsqlTypes.NpgsqlPoint(x: 0.02487832509029786d, y: 0.912355568026644d), new NpgsqlTypes.NpgsqlPoint(x: 0.32580581351797855d, y: 0.5568034600298316d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32894454225857417d, y: 0.24239106013510736d), new NpgsqlTypes.NpgsqlPoint(x: 0.8874465356904846d, y: 0.810432102036785d), new NpgsqlTypes.NpgsqlPoint(x: 0.7776616134368473d, y: 0.860073303559888d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44067958948917363d, y: 0.9141314792908606d), new NpgsqlTypes.NpgsqlPoint(x: 0.22561941880380443d, y: 0.17185799423259518d), new NpgsqlTypes.NpgsqlPoint(x: 0.19126109191865392d, y: 0.32240845806551366d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34438054627622294d, y: 0.09529530309215761d), new NpgsqlTypes.NpgsqlPoint(x: 0.6859528751979902d, y: 0.7879033769768619d), new NpgsqlTypes.NpgsqlPoint(x: 0.1925541007469862d, y: 0.926757898915424d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46754546828048105d, y: 0.3650000189093141d), new NpgsqlTypes.NpgsqlPoint(x: 0.733435783799051d, y: 0.28683530595933515d), new NpgsqlTypes.NpgsqlPoint(x: 0.5674458508370716d, y: 0.9901273287496026d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33048484875000594d, y: 0.2028907335258845d), new NpgsqlTypes.NpgsqlPoint(x: 0.5927784175866514d, y: 0.13936810963316715d), new NpgsqlTypes.NpgsqlPoint(x: 0.6864643627205288d, y: 0.7373710361473427d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2109860135974143d, y: 0.48284582773011697d), new NpgsqlTypes.NpgsqlPoint(x: 0.637080745002536d, y: 0.5128446641641823d), new NpgsqlTypes.NpgsqlPoint(x: 0.1466506833893647d, y: 0.060547678698796625d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7335752952202572d, y: 0.09444752486913077d), new NpgsqlTypes.NpgsqlPoint(x: 0.06410498833315958d, y: 0.9151304964563581d), new NpgsqlTypes.NpgsqlPoint(x: 0.1901864472816016d, y: 0.7321266582636775d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.025733531764596695d, y: 0.7981002658310914d), new NpgsqlTypes.NpgsqlPoint(x: 0.28176004125489185d, y: 0.26021180353976503d), new NpgsqlTypes.NpgsqlPoint(x: 0.06210572165419004d, y: 0.8049899658716249d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05004055698538423d, y: 0.44095533927107944d), new NpgsqlTypes.NpgsqlPoint(x: 0.36543305961182504d, y: 0.37444508697096757d), new NpgsqlTypes.NpgsqlPoint(x: 0.8751542254462913d, y: 0.703533572810716d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5210857038037093d, y: 0.11932783039793315d), new NpgsqlTypes.NpgsqlPoint(x: 0.27575528982754305d, y: 0.2832180122251847d), new NpgsqlTypes.NpgsqlPoint(x: 0.980224424789703d, y: 0.38711687415307794d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6921144853927277d, y: 0.879694450835172d), new NpgsqlTypes.NpgsqlPoint(x: 0.9750858650305393d, y: 0.6765819563087107d), new NpgsqlTypes.NpgsqlPoint(x: 0.7746455258581997d, y: 0.8517237445567841d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05445302762591142d, y: 0.4276323570309174d), new NpgsqlTypes.NpgsqlPoint(x: 0.49015971939922687d, y: 0.35725326638890453d), new NpgsqlTypes.NpgsqlPoint(x: 0.385058001889128d, y: 0.9648141526052064d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.027380941799975855d, y: 0.6667728289309822d), new NpgsqlTypes.NpgsqlPoint(x: 0.1123322762824992d, y: 0.03318850675705376d), new NpgsqlTypes.NpgsqlPoint(x: 0.7811996775989571d, y: 0.5934030427372874d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.587263823554979d, y: 0.6650461459398295d), new NpgsqlTypes.NpgsqlPoint(x: 0.28395738262067394d, y: 0.7723345009079359d), new NpgsqlTypes.NpgsqlPoint(x: 0.312157327843125d, y: 0.5604714803151128d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7400491923094735d, y: 0.4610360912511168d), new NpgsqlTypes.NpgsqlPoint(x: 0.8169255993070913d, y: 0.9065897418066372d), new NpgsqlTypes.NpgsqlPoint(x: 0.6872990389939155d, y: 0.5976838066980485d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8918039463910601d, y: 0.6715230029973289d), new NpgsqlTypes.NpgsqlPoint(x: 0.7110012054779836d, y: 0.26424447715762067d), new NpgsqlTypes.NpgsqlPoint(x: 0.11162431385565474d, y: 0.6326416105134488d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17320402075926178d, y: 0.8428510891138943d), new NpgsqlTypes.NpgsqlPoint(x: 0.6852581778230727d, y: 0.08989464354403698d), new NpgsqlTypes.NpgsqlPoint(x: 0.04642863062453595d, y: 0.8249777867567083d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11466435922194795d, y: 0.7351691691520567d), new NpgsqlTypes.NpgsqlPoint(x: 0.42454961473725117d, y: 0.20321713386147888d), new NpgsqlTypes.NpgsqlPoint(x: 0.4253862608328538d, y: 0.4125889157020044d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3351570527376738d, y: 0.4404294209119717d), new NpgsqlTypes.NpgsqlPoint(x: 0.7456120713655527d, y: 0.7425652061306875d), new NpgsqlTypes.NpgsqlPoint(x: 0.01878353940557409d, y: 0.8707207436890413d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.263823407015608d, y: 0.4847887744482363d), new NpgsqlTypes.NpgsqlPoint(x: 0.2215080334039461d, y: 0.3171637766013289d), new NpgsqlTypes.NpgsqlPoint(x: 0.3017698913326702d, y: 0.8523779936567596d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3097963109610766d, y: 0.031360557085182705d), new NpgsqlTypes.NpgsqlPoint(x: 0.4663845974463542d, y: 0.7383650379624618d), new NpgsqlTypes.NpgsqlPoint(x: 0.572146127748278d, y: 0.823460461895058d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16717900041301081d, y: 0.9814097794856423d), new NpgsqlTypes.NpgsqlPoint(x: 0.10017351541033359d, y: 0.8192212657338129d), new NpgsqlTypes.NpgsqlPoint(x: 0.9558904524261804d, y: 0.362501769169006d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8213794036889185d, y: 0.9898542009031959d), new NpgsqlTypes.NpgsqlPoint(x: 0.6925678776831625d, y: 0.952044323951547d), new NpgsqlTypes.NpgsqlPoint(x: 0.9875126816303158d, y: 0.557082057247297d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6251794255155856d, y: 0.6515934917802145d), new NpgsqlTypes.NpgsqlPoint(x: 0.6440965056567838d, y: 0.08149081370510369d), new NpgsqlTypes.NpgsqlPoint(x: 0.7773797051252238d, y: 0.11091592621634205d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.80674803246815d, y: 0.6247172265710026d), new NpgsqlTypes.NpgsqlPoint(x: 0.004293497042797578d, y: 0.9670519493861437d), new NpgsqlTypes.NpgsqlPoint(x: 0.6967997093476701d, y: 0.5971657733604994d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3593682522574576d, y: 0.9822021225386578d), new NpgsqlTypes.NpgsqlPoint(x: 0.10150869660346706d, y: 0.8880690399915078d), new NpgsqlTypes.NpgsqlPoint(x: 0.26425538162233d, y: 0.15263988208864787d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7832977870747574d, y: 0.06551455515206805d), new NpgsqlTypes.NpgsqlPoint(x: 0.7579224832228059d, y: 0.8103897923236184d), new NpgsqlTypes.NpgsqlPoint(x: 0.4722344107673364d, y: 0.134326659521259d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2815382174410883d, y: 0.8611241955532555d), new NpgsqlTypes.NpgsqlPoint(x: 0.9491977438908823d, y: 0.8869326097228761d), new NpgsqlTypes.NpgsqlPoint(x: 0.24246731483145123d, y: 0.8266396514476144d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7104775399049988d, y: 0.5298423990751424d), new NpgsqlTypes.NpgsqlPoint(x: 0.7307910269476404d, y: 0.9340622963413886d), new NpgsqlTypes.NpgsqlPoint(x: 0.1212190754450283d, y: 0.1922105611393019d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5088823535300733d, y: 0.6952721591470171d), new NpgsqlTypes.NpgsqlPoint(x: 0.41056947038357483d, y: 0.32645561404625045d), new NpgsqlTypes.NpgsqlPoint(x: 0.675000477502112d, y: 0.9185973489898716d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8660673673803396d, y: 0.7931506365553892d), new NpgsqlTypes.NpgsqlPoint(x: 0.9795919114838263d, y: 0.3846803604684955d), new NpgsqlTypes.NpgsqlPoint(x: 0.3143599180139768d, y: 0.24184356314784938d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8723893096224349d, y: 0.21380373226824d), new NpgsqlTypes.NpgsqlPoint(x: 0.5446502117204755d, y: 0.6983119706960635d), new NpgsqlTypes.NpgsqlPoint(x: 0.6497327073263113d, y: 0.38988997105883505d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5684203417401891d, y: 0.5998610592059745d), new NpgsqlTypes.NpgsqlPoint(x: 0.8049147214539695d, y: 0.17617842174857168d), new NpgsqlTypes.NpgsqlPoint(x: 0.287479300534066d, y: 0.7136781570839503d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05542367797282366d, y: 0.8276737183548022d), new NpgsqlTypes.NpgsqlPoint(x: 0.419214220897536d, y: 0.2327973075079255d), new NpgsqlTypes.NpgsqlPoint(x: 0.02700258260665922d, y: 0.5210446431773427d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0601354589271661d, y: 0.45990366022337537d), new NpgsqlTypes.NpgsqlPoint(x: 0.7398806293735114d, y: 0.7397778627256805d), new NpgsqlTypes.NpgsqlPoint(x: 0.38624686977146716d, y: 0.8558489889554333d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7517075295907283d, y: 0.9440827301945958d), new NpgsqlTypes.NpgsqlPoint(x: 0.5576122842212244d, y: 0.08472913951857575d), new NpgsqlTypes.NpgsqlPoint(x: 0.6898432456754164d, y: 0.9908236161729177d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5667189815463245d, y: 0.5027583297422372d), new NpgsqlTypes.NpgsqlPoint(x: 0.008921074018053421d, y: 0.3626443224929129d), new NpgsqlTypes.NpgsqlPoint(x: 0.39268638012791035d, y: 0.7826613227342841d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20222528304035747d, y: 0.003236941573519281d), new NpgsqlTypes.NpgsqlPoint(x: 0.058891715706515746d, y: 0.7517465408215327d), new NpgsqlTypes.NpgsqlPoint(x: 0.3380305219610946d, y: 0.39913439992641153d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24280644449533184d, y: 0.29302247072194854d), new NpgsqlTypes.NpgsqlPoint(x: 0.6538164137309863d, y: 0.5423370558620952d), new NpgsqlTypes.NpgsqlPoint(x: 0.7858889236638196d, y: 0.7085745974207086d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5361829439644034d, y: 0.9819540654462928d), new NpgsqlTypes.NpgsqlPoint(x: 0.6651851927759784d, y: 0.34838727151210647d), new NpgsqlTypes.NpgsqlPoint(x: 0.04511353469381474d, y: 0.8748473999927088d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.690546851973595d, y: 0.8400878974380434d), new NpgsqlTypes.NpgsqlPoint(x: 0.9975710738318291d, y: 0.6196521102205178d), new NpgsqlTypes.NpgsqlPoint(x: 0.8935166759575435d, y: 0.7018470440252068d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.978495278395631d, y: 0.18398458926043582d), new NpgsqlTypes.NpgsqlPoint(x: 0.8201875239313584d, y: 0.7313920242851337d), new NpgsqlTypes.NpgsqlPoint(x: 0.16782553461639982d, y: 0.0608059838216749d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5817815845984335d, y: 0.2084441517393324d), new NpgsqlTypes.NpgsqlPoint(x: 0.28400579183613983d, y: 0.9666767144523549d), new NpgsqlTypes.NpgsqlPoint(x: 0.26949856236594827d, y: 0.012038040126292171d)))));

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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpath0MIWA),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpath0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpath0MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpath0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpath0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
FROM public.binary_npgsqlpathpath0m m
LEFT JOIN public.binary_npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpath0M>(15);

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
                ((INpgsqlPathSingleTypepath)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathSingleTypepath)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpath0M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpath0M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpath0M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpath0M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpath0M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpath0M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpath0M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpath0M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpath0M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpath0M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpath0M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpath0M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpath0M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpath0M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpath0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpath0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpath0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

