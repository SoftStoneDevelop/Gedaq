

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
    internal partial interface INpgsqlCircleArraycircleArray
    {
    }
    
    internal partial class NpgsqlCircleArraycircleArray : INpgsqlCircleArraycircleArray
    {


#region TestData

        private readonly NpgsqlCirclecircleArray1M[] _testData = new NpgsqlCirclecircleArray1M[]
        {
            new NpgsqlCirclecircleArray1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38398760832292567d, y: 0.17316385772826148d), radius: 0.904227861157167d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01782439409849268d, y: 0.47492484961994574d), radius: 0.28507649003545743d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8732471372327487d, y: 0.38430683877245864d), radius: 0.3657334520016452d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8590324470052381d, y: 0.8962341172402915d), radius: 0.6044456440235771d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7384500625526619d, y: 0.9990384467933467d), radius: 0.06890915615613535d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.858393054736627d, y: 0.06225886959584115d), radius: 0.3067661048484501d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40365933475970994d, y: 0.17905290978410238d), radius: 0.42885808227911504d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0476350188251059d, y: 0.05963153504765373d), radius: 0.30633876800465887d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5236213354862769d, y: 0.1362222416602875d), radius: 0.6665407512423402d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10339300303438992d, y: 0.5982254372681224d), radius: 0.3255601111469574d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6894893973804979d, y: 0.7925182967866561d), radius: 0.31228052858112054d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42386382737684003d, y: 0.041060929559414094d), radius: 0.903249804190913d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8591102026287455d, y: 0.18296679932796223d), radius: 0.29242850364347583d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45178025698081603d, y: 0.21588460848004443d), radius: 0.504598630462675d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9194183677581039d, y: 0.44088583092981504d), radius: 0.939415661602889d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9187427193711013d, y: 0.88681296184586d), radius: 0.10999976913199505d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8324751513679681d, y: 0.7788171474532389d), radius: 0.44340836007471174d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9983748103222465d, y: 0.06671573993403479d), radius: 0.34841765885773435d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4324599006659726d, y: 0.9226724072103965d), radius: 0.7475921526504088d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13771046810072263d, y: 0.44954037710485983d), radius: 0.06263508733528422d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9019809405640503d, y: 0.7287543710448368d), radius: 0.9353869762451505d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4375658390027486d, y: 0.8078611245345134d), radius: 0.06902227408659256d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5605423704650304d, y: 0.5612361836045684d), radius: 0.39222342991468495d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43112786377905066d, y: 0.8356635285804114d), radius: 0.7497352731853959d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1105965827190788d, y: 0.10469399858473272d), radius: 0.1250659657429073d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7948267373605555d, y: 0.27014883866650896d), radius: 0.27149498420438467d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9588076417889223d, y: 0.6811921665828801d), radius: 0.44637051036055375d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2908938561484179d, y: 0.7976319311291484d), radius: 0.09720150165465968d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4748574645185133d, y: 0.7490204145831976d), radius: 0.1588751139030956d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.048002901017422994d, y: 0.9110519784058354d), radius: 0.33064076832805056d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3930850789385849d, y: 0.05763971672786794d), radius: 0.4439075792231497d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5864552781815635d, y: 0.3514463128924422d), radius: 0.18287914498471947d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.212327477164708d, y: 0.7985500692744011d), radius: 0.23354613075241148d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7750306387331194d, y: 0.47696826686428095d), radius: 0.7411490897178635d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39136789719869003d, y: 0.02382262610496666d), radius: 0.9259461509006811d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16835682403940044d, y: 0.9167511687277511d), radius: 0.1299601728845332d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.811610394254903d, y: 0.6592300246258749d), radius: 0.2182851569105887d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03274635426659711d, y: 0.07760911233672707d), radius: 0.9633525574758037d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20777541250170706d, y: 0.6028537287284311d), radius: 0.6322375943526041d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6410901878971945d, y: 0.24626456840850053d), radius: 0.4261396772462648d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4442204797403613d, y: 0.015491326238710634d), radius: 0.4191599120124583d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22888887348080666d, y: 0.5045532119822246d), radius: 0.730669887828412d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6213758120024396d, y: 0.5539652275877849d), radius: 0.9631288733486436d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24505214867935599d, y: 0.3741100684529505d), radius: 0.6502518487768203d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6920596242763672d, y: 0.4675524016978938d), radius: 0.3472491840152848d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23194494172572033d, y: 0.2534988755239238d), radius: 0.05968225474288602d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27176482274342817d, y: 0.10513424476810729d), radius: 0.7936374203672597d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6231561898280886d, y: 0.16175898126856825d), radius: 0.45313404252620515d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35047524107767514d, y: 0.05867293530748363d), radius: 0.07822722408013316d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7320746449453482d, y: 0.7266499699324248d), radius: 0.3285885612618368d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6530747909834309d, y: 0.9287309362222403d), radius: 0.8964918514753728d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6047443038198507d, y: 0.3494018036500962d), radius: 0.3849094495912575d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24059683590311742d, y: 0.1998970282191883d), radius: 0.16719617953228483d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7737660615618952d, y: 0.6654574354337398d), radius: 0.10083165579828524d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7417111014204802d, y: 0.7858398936577454d), radius: 0.550707779330959d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7364172354962921d, y: 0.7667920778697057d), radius: 0.5527397323254261d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4798662364513864d, y: 0.38793127803494576d), radius: 0.23684150550052008d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9134108257844822d, y: 0.6184022880255641d), radius: 0.6666591738615275d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6498312406745768d, y: 0.5489215884074339d), radius: 0.21568332594684603d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8072655516686978d, y: 0.027481491106234546d), radius: 0.4762926563195675d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1031808353434327d, y: 0.589118379219526d), radius: 0.03622020608523602d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7841876394394804d, y: 0.2987623751119459d), radius: 0.3816817010781992d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12570883814113631d, y: 0.16674509873764354d), radius: 0.8275547185698907d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38365334444672217d, y: 0.8155114604464138d), radius: 0.74336530108758d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.799936746884409d, y: 0.25316981346971923d), radius: 0.8485973376566338d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3942305484771149d, y: 0.7250697232767861d), radius: 0.5833799745672372d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5709283001973178d, y: 0.5546350748221871d), radius: 0.60040269863436d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5039886340940044d, y: 0.22397571313324605d), radius: 0.9879067071299268d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4752248154208658d, y: 0.034439052152906435d), radius: 0.6391163058606113d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.767304755165704d, y: 0.44699434265857285d), radius: 0.2597822920755014d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24247893734431747d, y: 0.7133266336082217d), radius: 0.7383136915939797d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.014116567038762295d, y: 0.0012940393695740626d), radius: 0.21725862473585855d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9599751017191992d, y: 0.8680581190439955d), radius: 0.4001782191223562d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6361395312777014d, y: 0.5689564037442011d), radius: 0.7427758467898498d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6563119589738999d, y: 0.8637356339249888d), radius: 0.07539755898614209d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5313815630587778d, y: 0.7680215995247913d), radius: 0.07865307806622512d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7685738654247984d, y: 0.31919983366464866d), radius: 0.3540094774410578d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6621288655001338d, y: 0.8576753226324274d), radius: 0.16823371563879175d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9959785454642918d, y: 0.6061504467673137d), radius: 0.1744371438687503d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0013310599764203568d, y: 0.39941646979159295d), radius: 0.43305191235640916d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.842795492729278d, y: 0.4102956619966659d), radius: 0.009929865015841477d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0777120489122729d, y: 0.8536925093089033d), radius: 0.2498420655811603d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.909550695221277d, y: 0.25834321358411005d), radius: 0.28772342552121566d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48539332405906455d, y: 0.022219527175289078d), radius: 0.1924519758549682d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9980671678599481d, y: 0.12114124471952337d), radius: 0.8018522740317894d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11797820999965192d, y: 0.7870353434413516d), radius: 0.77755701425142d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06548422988016056d, y: 0.7600055735855326d), radius: 0.28496136686489015d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7894238598901248d, y: 0.9550378701201372d), radius: 0.26113243719431334d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9848708289140845d, y: 0.5655519088213906d), radius: 0.7732009644313993d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9396922706063554d, y: 0.5823585919345852d), radius: 0.82359947676901d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3914967444911738d, y: 0.11639579921523635d), radius: 0.5742828481305486d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17694877336979298d, y: 0.41803232552441716d), radius: 0.5755377395276043d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6630151756797606d, y: 0.016064926889803544d), radius: 0.8206046176790912d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19020914263775413d, y: 0.6645494492129141d), radius: 0.2731455314945326d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8281602656741415d, y: 0.9749188680056169d), radius: 0.6718574129824179d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8444116962939204d, y: 0.8795092464291535d), radius: 0.02625624430602591d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7598932413677856d, y: 0.9484147678320125d), radius: 0.8368586354863699d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.877348740888851d, y: 0.06619246449367033d), radius: 0.6517266945611482d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15861769004471715d, y: 0.6584063112478735d), radius: 0.06587145216339552d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5258948121215676d, y: 0.972596395616019d), radius: 0.6063854193453526d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8450207731129525d, y: 0.7346393868066508d), radius: 0.5686421240741291d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6110074467381332d, y: 0.599371644549994d), radius: 0.6024235138225075d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1701677722890541d, y: 0.8715929953774507d), radius: 0.7324419665195507d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7209756633854507d, y: 0.012965362879795772d), radius: 0.065166898522792d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8343147472163276d, y: 0.33938773670056255d), radius: 0.04108755376608064d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6649891762863914d, y: 0.545399471250983d), radius: 0.5754823140190606d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09695694186166148d, y: 0.5950451169654998d), radius: 0.5478791020425704d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6211108593910463d, y: 0.3384508407900598d), radius: 0.7818382423484692d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7631255333646524d, y: 0.36801195526100927d), radius: 0.6420485305952961d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9306633738993992d, y: 0.0783855506338419d), radius: 0.27223068564832764d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07896825024891241d, y: 0.47024968477571927d), radius: 0.9464904868941981d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9823902112896195d, y: 0.848139369538425d), radius: 0.3512336013877251d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7997262685709338d, y: 0.11883514570338372d), radius: 0.4331446656619121d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38241725375619773d, y: 0.9918016668947568d), radius: 0.504661310298799d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46738731750947526d, y: 0.20202764209868396d), radius: 0.30015887502707095d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17912204918563746d, y: 0.17775226220751117d), radius: 0.9843526569108848d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3502023479689066d, y: 0.663654729696336d), radius: 0.7492057200404991d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7625159045085312d, y: 0.8829051510767646d), radius: 0.27778382841600024d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.641257202187503d, y: 0.9327712386206124d), radius: 0.6884274476271354d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4680526855433158d, y: 0.4320501035431481d), radius: 0.19439827882205096d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40576838375004853d, y: 0.013328339329696126d), radius: 0.09277283591578589d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8929786133464658d, y: 0.9141660849486899d), radius: 0.25291178779125467d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16804575169795177d, y: 0.798235280255195d), radius: 0.1671427785954146d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5973691531176714d, y: 0.5769896970668397d), radius: 0.6387504478812381d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18468474564966753d, y: 0.5133880660091946d), radius: 0.2754085811423217d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7517464458706408d, y: 0.7375260290422613d), radius: 0.20597057554899878d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.032541295740166065d, y: 0.5207068185001852d), radius: 0.26851504576624685d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13034998159887912d, y: 0.9600303572504281d), radius: 0.26413974134646245d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7938379909526712d, y: 0.6971876854287384d), radius: 0.4048534876996195d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6761010861825414d, y: 0.8689534857214211d), radius: 0.6870366625018058d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8202151176097712d, y: 0.6327379446981107d), radius: 0.8894348976726754d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.055088449610117274d, y: 0.8745718732726963d), radius: 0.519487883226347d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09752585902137645d, y: 0.5937392576698935d), radius: 0.9970888558465307d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05644947837585623d, y: 0.7432326892181169d), radius: 0.7245765266689038d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46103355665398016d, y: 0.42485322382093904d), radius: 0.5219799535900529d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6538174342904773d, y: 0.7895641024567085d), radius: 0.7168037586193925d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3834982327640303d, y: 0.5199236486763433d), radius: 0.530653914729524d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19214452213665079d, y: 0.14576576922416473d), radius: 0.24904354770988102d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6433935574731774d, y: 0.4234175468924021d), radius: 0.38547593478583364d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11821301264263517d, y: 0.6311582902283127d), radius: 0.45191850078487406d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7146386038513775d, y: 0.7286973097376267d), radius: 0.09729272931173971d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0630580793979757d, y: 0.34481942245382d), radius: 0.4036041220241702d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.765412504051708d, y: 0.6385919000186506d), radius: 0.2734992330436926d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8541749977228346d, y: 0.9035240582677425d), radius: 0.7900480771505529d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4812468753017094d, y: 0.5153540115461679d), radius: 0.43726223430999467d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.030124504413218456d, y: 0.429693887707167d), radius: 0.9833645719824444d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4556087487993217d, y: 0.49881234551673836d), radius: 0.43200352847646883d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5812009648467019d, y: 0.8793040238805259d), radius: 0.2538359966846109d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12372891728005664d, y: 0.8048167708495186d), radius: 0.04795643949790496d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26300204577336417d, y: 0.3224189425680777d), radius: 0.3399274228219278d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7801994933640822d, y: 0.12493511764025511d), radius: 0.3537958774776765d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.493214123759507d, y: 0.8723428197079197d), radius: 0.3463319281417214d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6557207723051582d, y: 0.6411725843841017d), radius: 0.49687426374691746d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.600228888699813d, y: 0.2878302349129548d), radius: 0.5193042749364026d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5143164457211826d, y: 0.7844225989547151d), radius: 0.06976343066777246d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8836706932883174d, y: 0.8048201095522908d), radius: 0.2501470701839791d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9299526373020076d, y: 0.8258322470227866d), radius: 0.6357106104922726d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7234041670337619d, y: 0.6442703347666777d), radius: 0.13815987736126556d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0974116976163073d, y: 0.8579740657203234d), radius: 0.8377161391465142d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5497869575718105d, y: 0.2999241253871d), radius: 0.8246126657711413d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8606424934730069d, y: 0.2539901887241819d), radius: 0.005250522412001968d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7076768475611397d, y: 0.05336132999216614d), radius: 0.26159950351211003d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2778671634544173d, y: 0.6801390056056574d), radius: 0.5251401864914056d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5862732846029564d, y: 0.9397037010927507d), radius: 0.9054800044721854d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9315483206132643d, y: 0.26647284312728825d), radius: 0.08101548371775202d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7870825174033325d, y: 0.27316487172807824d), radius: 0.0958936574342043d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24002915094893318d, y: 0.1977832961658469d), radius: 0.20304611660123684d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5507458067345389d, y: 0.48038503879881767d), radius: 0.8409370625206851d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7798657896364717d, y: 0.7517556190678394d), radius: 0.3785586530865078d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8249836105370014d, y: 0.057309281482459284d), radius: 0.3941550489991599d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8123198035481776d, y: 0.9238472374143408d), radius: 0.40918615647767365d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35951262511355797d, y: 0.516372102174854d), radius: 0.8962031141787955d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48169916381984257d, y: 0.7662233240960011d), radius: 0.3095483440363008d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9647340903569541d, y: 0.31797329089315574d), radius: 0.5403205596758435d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4603147420831962d, y: 0.13606911065411653d), radius: 0.7069282424941701d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.609104558174547d, y: 0.5152121993527514d), radius: 0.012383005820901682d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10219227118628471d, y: 0.07180686638430678d), radius: 0.4495771477114876d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.012502281737606702d, y: 0.7358077059441894d), radius: 0.9985427487538451d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06961605753665256d, y: 0.214759314755662d), radius: 0.5752540981397489d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7849048223953444d, y: 0.5985136858967224d), radius: 0.8007485827885011d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2767160234025904d, y: 0.7190335602898258d), radius: 0.7657114703084393d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9358045475452155d, y: 0.7919813226435778d), radius: 0.36267479984335527d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020177603855349724d, y: 0.1475577126694848d), radius: 0.9028209830461124d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8936731386715245d, y: 0.15321079865718223d), radius: 0.7678531418636663d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6687838480150816d, y: 0.2988440837251971d), radius: 0.5527749586849737d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9252537962465966d, y: 0.6817740885518161d), radius: 0.599714513216483d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4168141794252349d, y: 0.855377237652572d), radius: 0.8479783467253257d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09104623362496733d, y: 0.5444579061284496d), radius: 0.4897010140813678d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32115113633317893d, y: 0.5608014668351781d), radius: 0.6980590218194833d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08044297072231199d, y: 0.15334803371856143d), radius: 0.4210520013921414d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3186998396162305d, y: 0.36130395625894884d), radius: 0.9945680600562924d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4254213061250498d, y: 0.5557667373707401d), radius: 0.9783251865734409d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9290757334408418d, y: 0.8803716179280344d), radius: 0.9629731561878841d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32241000478806514d, y: 0.48128549570814727d), radius: 0.47780112949308606d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4633511877174117d, y: 0.7663137240639308d), radius: 0.7059583532847196d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6668453329211922d, y: 0.4374954416662664d), radius: 0.9002711090615835d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33053556811264617d, y: 0.7758404062964089d), radius: 0.5089684249371029d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5519836226759667d, y: 0.17839430071895557d), radius: 0.687202981832235d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8507526322913925d, y: 0.5814164400264409d), radius: 0.8743105960599085d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4006319697923142d, y: 0.4194563428893838d), radius: 0.9820448768216098d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9303759633910667d, y: 0.5423143249675978d), radius: 0.47430638675581105d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5767788254697588d, y: 0.9557564078130849d), radius: 0.2151208430906485d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5150007950281762d, y: 0.3399572275817493d), radius: 0.3913816921933708d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8545940356091192d, y: 0.99509288210353d), radius: 0.22745059109672638d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.889835620434622d, y: 0.07886200246752495d), radius: 0.11639399395949257d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41884136776935454d, y: 0.16484916676922112d), radius: 0.6247968273370231d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6607763615356643d, y: 0.17003351323532034d), radius: 0.3027017726886091d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5253596383245167d, y: 0.820492096586006d), radius: 0.03226514487892462d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2174438378944109d, y: 0.4449970944699593d), radius: 0.19821399628941228d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8086489623835771d, y: 0.989372377343357d), radius: 0.48464964582475434d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3064779427603467d, y: 0.965836685224448d), radius: 0.3876149634811449d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5418737988357374d, y: 0.49814738073287634d), radius: 0.9039247029937096d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35126573076408174d, y: 0.5875587703194841d), radius: 0.422862553091896d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3984631915965767d, y: 0.6703293051952846d), radius: 0.8781801180059458d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5090323443825271d, y: 0.0582888861353672d), radius: 0.8278004689247198d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08630650035020304d, y: 0.2901705646682289d), radius: 0.6850647380378989d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7032132561830196d, y: 0.8121447403733952d), radius: 0.9941625179357958d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1215869643508195d, y: 0.4725348021918644d), radius: 0.762398061572822d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8233262625344544d, y: 0.1236372186608613d), radius: 0.4224564644838129d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12307009614044606d, y: 0.1497717259527468d), radius: 0.4023158001548066d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6177955878110618d, y: 0.6414206435572072d), radius: 0.9135925299373772d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17974193988856824d, y: 0.30312829298533284d), radius: 0.6695391018054336d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09878366810061823d, y: 0.6785834077387977d), radius: 0.6379505098273117d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.586712686483165d, y: 0.06883263728678624d), radius: 0.34752917666944694d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10372610196841359d, y: 0.5231163628365791d), radius: 0.5671263418760194d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25959486921014907d, y: 0.2920795382151885d), radius: 0.7760611262644178d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9328501221724466d, y: 0.26521549240211706d), radius: 0.2504262524129558d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8266083822326544d, y: 0.5820141011480559d), radius: 0.6967467173222549d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5398829912957378d, y: 0.2813427646563893d), radius: 0.3360952344974433d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 166,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08603316882056888d, y: 0.12866780007214962d), radius: 0.971872087994241d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29973798094784065d, y: 0.4735219288379017d), radius: 0.21191344747017993d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.037465047201037605d, y: 0.22515344399803816d), radius: 0.417514827341276d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42871639714329557d, y: 0.3180077501289368d), radius: 0.42579519575034175d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27142784127670416d, y: 0.3344195002281487d), radius: 0.9138467644688605d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0457307960587231d, y: 0.2309982404384654d), radius: 0.09439684539256665d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1691940794658704d, y: 0.9696588020022429d), radius: 0.5000657103856421d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7037786433968759d, y: 0.26876652563073045d), radius: 0.21139266977760007d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6586601811004843d, y: 0.8399612929297693d), radius: 0.4591764698434676d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4212586939597631d, y: 0.8949006632734738d), radius: 0.7535144352053587d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25712266987763455d, y: 0.43250993903752966d), radius: 0.49624522612391186d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8939254011625531d, y: 0.5245365033230277d), radius: 0.46454427211952d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24921485675952515d, y: 0.602459541523431d), radius: 0.8279988573054937d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9416124181701182d, y: 0.8909080514050682d), radius: 0.036349892925848226d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 172,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5032264496485103d, y: 0.9133369806718928d), radius: 0.8093834716344568d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7353086614462235d, y: 0.7258717784938098d), radius: 0.41117799176089453d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4487060247222462d, y: 0.4473433170138854d), radius: 0.7578103908657484d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8234147662014029d, y: 0.0012559582629049215d), radius: 0.05855931220517552d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7650056315667823d, y: 0.7102851130978619d), radius: 0.280402776410825d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17142891044477948d, y: 0.7192935855507805d), radius: 0.4644994043520252d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 180,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7016839462016828d, y: 0.13670061861677785d), radius: 0.23216471782731418d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04814978147012394d, y: 0.1624424913349759d), radius: 0.5159717282263304d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13522126784708666d, y: 0.2697762011255934d), radius: 0.9103607599663153d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8785248494822165d, y: 0.3061741818066951d), radius: 0.9085655016545694d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7190866914262175d, y: 0.228152854882534d), radius: 0.4805269363102491d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6241364493194399d, y: 0.29454353025959057d), radius: 0.420489010232338d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5868324981240461d, y: 0.36991713938474846d), radius: 0.7135583322751764d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12368954138263166d, y: 0.3260226098491049d), radius: 0.5154051580513133d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5094639149868707d, y: 0.6244191784379532d), radius: 0.27023922961669944d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.953637192933366d, y: 0.6464198865402326d), radius: 0.3522221979982145d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 181,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41057943041893585d, y: 0.3261364590102759d), radius: 0.029290354225305903d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43043372521090073d, y: 0.5699610384745626d), radius: 0.5823623544077475d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5296401836849973d, y: 0.5748904006220444d), radius: 0.9597893027498705d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 184,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.013878758956010095d, y: 0.6062404615772744d), radius: 0.49013900838642066d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5038695785027025d, y: 0.576570526406343d), radius: 0.9608345047701408d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8963413927053757d, y: 0.7761033217483682d), radius: 0.8799428590235205d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2168510066718191d, y: 0.2781617692094538d), radius: 0.6661685603011602d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6746852441770413d, y: 0.22285462357818786d), radius: 0.7358019423115638d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5694639200615446d, y: 0.7147528597965616d), radius: 0.07680859439378152d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15358616401933134d, y: 0.3763939101508209d), radius: 0.4733618737953914d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0251028262691374d, y: 0.32443587255670425d), radius: 0.05427393579896278d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08569420821401041d, y: 0.7601075992688825d), radius: 0.5109006402413407d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5246705656553085d, y: 0.3262199096435585d), radius: 0.7191978892517487d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.90681462561679d, y: 0.693464346193093d), radius: 0.7919646015883679d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 186,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11608811616041603d, y: 0.7377630232561865d), radius: 0.3308123930229607d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46058359127254966d, y: 0.870627115814681d), radius: 0.42768852059222306d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.911815151355008d, y: 0.5153810947210735d), radius: 0.5865363413902529d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2699961798080317d, y: 0.13404543608333708d), radius: 0.15303435287893208d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8871895067896383d, y: 0.23930121043100883d), radius: 0.5122897128154491d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5194128903988737d, y: 0.9761231928373406d), radius: 0.5183017512358002d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9978235549249588d, y: 0.21642903574723327d), radius: 0.930260502934743d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1mi(
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
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

                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray1mi_id", 
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
                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray1mi_id", 
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12570883814113631d, y: 0.16674509873764354d), radius: 0.8275547185698907d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38365334444672217d, y: 0.8155114604464138d), radius: 0.74336530108758d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.799936746884409d, y: 0.25316981346971923d), radius: 0.8485973376566338d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3942305484771149d, y: 0.7250697232767861d), radius: 0.5833799745672372d),
}));
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0777120489122729d, y: 0.8536925093089033d), radius: 0.2498420655811603d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.909550695221277d, y: 0.25834321358411005d), radius: 0.28772342552121566d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48539332405906455d, y: 0.022219527175289078d), radius: 0.1924519758549682d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9980671678599481d, y: 0.12114124471952337d), radius: 0.8018522740317894d),
}));
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6630151756797606d, y: 0.016064926889803544d), radius: 0.8206046176790912d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19020914263775413d, y: 0.6645494492129141d), radius: 0.2731455314945326d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8281602656741415d, y: 0.9749188680056169d), radius: 0.6718574129824179d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray1M> models = null;

                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray1M> models = null;

                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleArraycircleArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 158;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[34], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 135, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 65, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 10, query1, 35, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 55, query1, 172, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 172, query1, 150, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 72, query1, 158, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 75, query1, 137, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 35, query1, 75, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 4, 111))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[34], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatch(connection, 55, 28))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 128);
                var models = await ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[24], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[25], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[26], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[27], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[28], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[29], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[30], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[31], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[32], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[33], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 96);
                var models =  ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[20], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[21], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[22], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[23], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[24], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[25], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[26], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[27], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[28], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[29], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[30], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[31], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[32], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[33], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MI),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleArraycircleArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleArraycircleArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleArray1M),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray1m m
LEFT JOIN public.binary_npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleArraycircleArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleArraycircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models =  ((INpgsqlCircleArraycircleArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA), typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA), typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI), typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models1 = new List<NpgsqlCirclecircleArray1MI>();
                var models2 = new List<NpgsqlCirclecircleArray1MI>();
                await ((INpgsqlCircleArraycircleArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MI>();
                var models2 = new List<NpgsqlCirclecircleArray1MI>();
                ((INpgsqlCircleArraycircleArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA), typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                await ((INpgsqlCircleArraycircleArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                ((INpgsqlCircleArraycircleArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

